#if UNITY_EDITOR ||!ENABLE_IL2CPP
#define Mono
#else
using UniReflection.IL2CPP;
#endif
using System;

namespace UniReflection
{
    public unsafe struct InstanceFunc<T> : IDisposable
    {
        private PinnedObject pinnedObject;
        public PinnedObject Object=>pinnedObject;
#if Mono
        private readonly delegate* unmanaged[Cdecl]<IntPtr, T> functionPointer;

        public InstanceFunc(Func<T> func)

        {
            pinnedObject = new(func.Target);
            functionPointer = (delegate*unmanaged[Cdecl]<IntPtr, T>)func.Method.MethodHandle.GetFunctionPointer();
        }

        public readonly T Invoke()
        {
            return functionPointer(pinnedObject.ObjectPointer);
        }
#else
         private readonly Il2CppMethodInfoHandle methodInfoHandle;

        public InstanceFunc(Func<T> func)
        
        {
            pinnedObject = new(func.Target);
            methodInfoHandle = new (func.Method)  ;
        }
        
        public readonly T Invoke()
        {
           return ((delegate* unmanaged[Cdecl]<IntPtr,Il2CppMethodInfoHandle, T>)methodInfoHandle.MethodPointer)(pinnedObject.ObjectPointer, methodInfoHandle);
        }
#endif
        public void Dispose()
        {
            pinnedObject.Dispose();
        }
    }
}