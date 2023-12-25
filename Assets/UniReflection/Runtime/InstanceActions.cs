
#if UNITY_EDITOR ||!ENABLE_IL2CPP
#define Mono
#else
using UniReflection.IL2CPP;
#endif
using System;

namespace UniReflection
{
    public unsafe struct InstanceAction<T0>: IDisposable
    {
        private PinnedObject pinnedObject;
        public PinnedObject Object=>pinnedObject;
#if Mono
        private readonly delegate* unmanaged[Cdecl]<IntPtr,T0,void> functionPointer;
        
         public InstanceAction(Action<T0> action)
        
        {
            pinnedObject =new(action.Target);
            functionPointer = (delegate*unmanaged[Cdecl]<IntPtr,T0,void> )action.Method.MethodHandle.GetFunctionPointer();
        }
        
        public readonly void Invoke(T0 t0)
        {
            functionPointer(pinnedObject.ObjectPointer,t0);
        }
#else
         private readonly Il2CppMethodInfoHandle methodInfoHandle;

        public InstanceAction(Action<T0> action)
        
        {
            pinnedObject =new(action.Target);
            methodInfoHandle =new (action.Method)  ;
        }
        
        public readonly void Invoke(T0 t0)
        {
            ((delegate* unmanaged[Cdecl]<IntPtr,T0,Il2CppMethodInfoHandle, void>)methodInfoHandle.MethodPointer)(pinnedObject.ObjectPointer,t0, methodInfoHandle);
        }
#endif
        public void Dispose()
        {
            pinnedObject.Dispose();
        }
    }
    public unsafe struct InstanceAction<T0,T1>: IDisposable
    {
        private PinnedObject pinnedObject;
        public PinnedObject Object=>pinnedObject;
#if Mono
        private readonly delegate* unmanaged[Cdecl]<IntPtr,T0,T1,void> functionPointer;
        
         public InstanceAction(Action<T0,T1> action)
        
        {
            pinnedObject =new(action.Target);
            functionPointer = (delegate*unmanaged[Cdecl]<IntPtr,T0,T1,void> )action.Method.MethodHandle.GetFunctionPointer();
        }
        
        public readonly void Invoke(T0 t0,T1 t1)
        {
            functionPointer(pinnedObject.ObjectPointer,t0,t1);
        }
#else
         private readonly Il2CppMethodInfoHandle methodInfoHandle;

        public InstanceAction(Action<T0,T1> action)
        
        {
            pinnedObject =new(action.Target);
            methodInfoHandle =new (action.Method)  ;
        }
        
        public readonly void Invoke(T0 t0,T1 t1)
        {
            ((delegate* unmanaged[Cdecl]<IntPtr,T0,T1,Il2CppMethodInfoHandle, void>)methodInfoHandle.MethodPointer)(pinnedObject.ObjectPointer,t0,t1, methodInfoHandle);
        }
#endif
        public void Dispose()
        {
            pinnedObject.Dispose();
        }
    }
    public unsafe struct InstanceAction<T0,T1,T2>: IDisposable
    {
        private PinnedObject pinnedObject;
        public PinnedObject Object=>pinnedObject;
#if Mono
        private readonly delegate* unmanaged[Cdecl]<IntPtr,T0,T1,T2,void> functionPointer;
        
         public InstanceAction(Action<T0,T1,T2> action)
        
        {
            pinnedObject =new(action.Target);
            functionPointer = (delegate*unmanaged[Cdecl]<IntPtr,T0,T1,T2,void> )action.Method.MethodHandle.GetFunctionPointer();
        }
        
        public readonly void Invoke(T0 t0,T1 t1,T2 t2)
        {
            functionPointer(pinnedObject.ObjectPointer,t0,t1,t2);
        }
#else
         private readonly Il2CppMethodInfoHandle methodInfoHandle;

        public InstanceAction(Action<T0,T1,T2> action)
        
        {
            pinnedObject =new(action.Target);
            methodInfoHandle =new (action.Method)  ;
        }
        
        public readonly void Invoke(T0 t0,T1 t1,T2 t2)
        {
            ((delegate* unmanaged[Cdecl]<IntPtr,T0,T1,T2,Il2CppMethodInfoHandle, void>)methodInfoHandle.MethodPointer)(pinnedObject.ObjectPointer,t0,t1,t2, methodInfoHandle);
        }
#endif
        public void Dispose()
        {
            pinnedObject.Dispose();
        }
    }
    public unsafe struct InstanceAction<T0,T1,T2,T3>: IDisposable
    {
        private PinnedObject pinnedObject;
        public PinnedObject Object=>pinnedObject;
#if Mono
        private readonly delegate* unmanaged[Cdecl]<IntPtr,T0,T1,T2,T3,void> functionPointer;
        
         public InstanceAction(Action<T0,T1,T2,T3> action)
        
        {
            pinnedObject =new(action.Target);
            functionPointer = (delegate*unmanaged[Cdecl]<IntPtr,T0,T1,T2,T3,void> )action.Method.MethodHandle.GetFunctionPointer();
        }
        
        public readonly void Invoke(T0 t0,T1 t1,T2 t2,T3 t3)
        {
            functionPointer(pinnedObject.ObjectPointer,t0,t1,t2,t3);
        }
#else
         private readonly Il2CppMethodInfoHandle methodInfoHandle;

        public InstanceAction(Action<T0,T1,T2,T3> action)
        
        {
            pinnedObject =new(action.Target);
            methodInfoHandle =new (action.Method)  ;
        }
        
        public readonly void Invoke(T0 t0,T1 t1,T2 t2,T3 t3)
        {
            ((delegate* unmanaged[Cdecl]<IntPtr,T0,T1,T2,T3,Il2CppMethodInfoHandle, void>)methodInfoHandle.MethodPointer)(pinnedObject.ObjectPointer,t0,t1,t2,t3, methodInfoHandle);
        }
#endif
        public void Dispose()
        {
            pinnedObject.Dispose();
        }
    }
    public unsafe struct InstanceAction<T0,T1,T2,T3,T4>: IDisposable
    {
        private PinnedObject pinnedObject;
        public PinnedObject Object=>pinnedObject;
#if Mono
        private readonly delegate* unmanaged[Cdecl]<IntPtr,T0,T1,T2,T3,T4,void> functionPointer;
        
         public InstanceAction(Action<T0,T1,T2,T3,T4> action)
        
        {
            pinnedObject =new(action.Target);
            functionPointer = (delegate*unmanaged[Cdecl]<IntPtr,T0,T1,T2,T3,T4,void> )action.Method.MethodHandle.GetFunctionPointer();
        }
        
        public readonly void Invoke(T0 t0,T1 t1,T2 t2,T3 t3,T4 t4)
        {
            functionPointer(pinnedObject.ObjectPointer,t0,t1,t2,t3,t4);
        }
#else
         private readonly Il2CppMethodInfoHandle methodInfoHandle;

        public InstanceAction(Action<T0,T1,T2,T3,T4> action)
        
        {
            pinnedObject =new(action.Target);
            methodInfoHandle =new (action.Method)  ;
        }
        
        public readonly void Invoke(T0 t0,T1 t1,T2 t2,T3 t3,T4 t4)
        {
            ((delegate* unmanaged[Cdecl]<IntPtr,T0,T1,T2,T3,T4,Il2CppMethodInfoHandle, void>)methodInfoHandle.MethodPointer)(pinnedObject.ObjectPointer,t0,t1,t2,t3,t4, methodInfoHandle);
        }
#endif
        public void Dispose()
        {
            pinnedObject.Dispose();
        }
    }
    public unsafe struct InstanceAction<T0,T1,T2,T3,T4,T5>: IDisposable
    {
        private PinnedObject pinnedObject;
        public PinnedObject Object=>pinnedObject;
#if Mono
        private readonly delegate* unmanaged[Cdecl]<IntPtr,T0,T1,T2,T3,T4,T5,void> functionPointer;
        
         public InstanceAction(Action<T0,T1,T2,T3,T4,T5> action)
        
        {
            pinnedObject =new(action.Target);
            functionPointer = (delegate*unmanaged[Cdecl]<IntPtr,T0,T1,T2,T3,T4,T5,void> )action.Method.MethodHandle.GetFunctionPointer();
        }
        
        public readonly void Invoke(T0 t0,T1 t1,T2 t2,T3 t3,T4 t4,T5 t5)
        {
            functionPointer(pinnedObject.ObjectPointer,t0,t1,t2,t3,t4,t5);
        }
#else
         private readonly Il2CppMethodInfoHandle methodInfoHandle;

        public InstanceAction(Action<T0,T1,T2,T3,T4,T5> action)
        
        {
            pinnedObject =new(action.Target);
            methodInfoHandle =new (action.Method)  ;
        }
        
        public readonly void Invoke(T0 t0,T1 t1,T2 t2,T3 t3,T4 t4,T5 t5)
        {
            ((delegate* unmanaged[Cdecl]<IntPtr,T0,T1,T2,T3,T4,T5,Il2CppMethodInfoHandle, void>)methodInfoHandle.MethodPointer)(pinnedObject.ObjectPointer,t0,t1,t2,t3,t4,t5, methodInfoHandle);
        }
#endif
        public void Dispose()
        {
            pinnedObject.Dispose();
        }
    }
    public unsafe struct InstanceAction<T0,T1,T2,T3,T4,T5,T6>: IDisposable
    {
        private PinnedObject pinnedObject;
        public PinnedObject Object=>pinnedObject;
#if Mono
        private readonly delegate* unmanaged[Cdecl]<IntPtr,T0,T1,T2,T3,T4,T5,T6,void> functionPointer;
        
         public InstanceAction(Action<T0,T1,T2,T3,T4,T5,T6> action)
        
        {
            pinnedObject =new(action.Target);
            functionPointer = (delegate*unmanaged[Cdecl]<IntPtr,T0,T1,T2,T3,T4,T5,T6,void> )action.Method.MethodHandle.GetFunctionPointer();
        }
        
        public readonly void Invoke(T0 t0,T1 t1,T2 t2,T3 t3,T4 t4,T5 t5,T6 t6)
        {
            functionPointer(pinnedObject.ObjectPointer,t0,t1,t2,t3,t4,t5,t6);
        }
#else
         private readonly Il2CppMethodInfoHandle methodInfoHandle;

        public InstanceAction(Action<T0,T1,T2,T3,T4,T5,T6> action)
        
        {
            pinnedObject =new(action.Target);
            methodInfoHandle =new (action.Method)  ;
        }
        
        public readonly void Invoke(T0 t0,T1 t1,T2 t2,T3 t3,T4 t4,T5 t5,T6 t6)
        {
            ((delegate* unmanaged[Cdecl]<IntPtr,T0,T1,T2,T3,T4,T5,T6,Il2CppMethodInfoHandle, void>)methodInfoHandle.MethodPointer)(pinnedObject.ObjectPointer,t0,t1,t2,t3,t4,t5,t6, methodInfoHandle);
        }
#endif
        public void Dispose()
        {
            pinnedObject.Dispose();
        }
    }
}
