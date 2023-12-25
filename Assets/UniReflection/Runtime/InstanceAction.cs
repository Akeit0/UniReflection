using System;
using UniReflection.IL2CPP;

namespace UniReflection
{
    public unsafe struct InstanceAction: IDisposable
    {
        private PinnedObject pinnedObject;
        public PinnedObject Object=>pinnedObject;
        
#if Mono
        delegate* unmanaged[Cdecl]<IntPtr,void> functionPointer;
#else
        private readonly Il2CppMethodInfoHandle methodInfoHandle;
#endif
        public InstanceAction(Action action)
        
        {
            pinnedObject =new(action.Target);
#if Mono
            functionPointer = (delegate*unmanaged[Cdecl]<IntPtr,void> )action.Method.MethodHandle.GetFunctionPointer();
#else
            methodInfoHandle =new (action.Method)  ;
#endif
        }
        
        public readonly void Invoke()
        {
#if Mono
            functionPointer(Object.ObjectPointer);
#else
            ((delegate* unmanaged[Cdecl]<IntPtr,Il2CppMethodInfoHandle, void>)methodInfoHandle.MethodPointer)(pinnedObject.ObjectPointer, methodInfoHandle);
#endif
        }
        public void Dispose()
        {
            pinnedObject.Dispose();
        }
    }
}