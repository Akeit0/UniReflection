#if UNITY_EDITOR ||!ENABLE_IL2CPP
#define Mono
#else
using UniReflection.IL2CPP;
#endif
using System;

namespace UniReflection
{
    public unsafe struct InstanceFunc<T0, TRet> : IDisposable
    {
        private PinnedObject pinnedObject;
        public PinnedObject Object=>pinnedObject;
#if Mono
        private readonly delegate* unmanaged[Cdecl]<IntPtr, T0, TRet> functionPointer;

        public InstanceFunc(Func<T0> func)

        {
            pinnedObject = new(func.Target);
            functionPointer =
                (delegate*unmanaged[Cdecl]<IntPtr, T0, TRet>)func.Method.MethodHandle.GetFunctionPointer();
        }

        public readonly TRet Invoke(T0 t0)
        {
           return functionPointer(pinnedObject.ObjectPointer, t0);
        }
#else
         private readonly Il2CppMethodInfoHandle methodInfoHandle;

        public InstanceFunc(Func<T0> func)
        
        {
            pinnedObject = new(func.Target);
            methodInfoHandle = new (func.Method)  ;
        }
        
        public readonly TRet Invoke(T0 t0)
        {
            return ((delegate* unmanaged[Cdecl]<IntPtr,T0,Il2CppMethodInfoHandle, TRet>)methodInfoHandle.MethodPointer)(pinnedObject.ObjectPointer,t0, methodInfoHandle);
        }
#endif
        public void Dispose()
        {
            pinnedObject.Dispose();
        }
    }

    public unsafe struct InstanceFunc<T0, T1, TRet> : IDisposable
    {
        private PinnedObject pinnedObject;
        public PinnedObject Object=>pinnedObject;
#if Mono
        private readonly delegate* unmanaged[Cdecl]<IntPtr, T0, T1, TRet> functionPointer;

        public InstanceFunc(Func<T0, T1> func)

        {
            pinnedObject = new(func.Target);
            functionPointer =
                (delegate*unmanaged[Cdecl]<IntPtr, T0, T1, TRet>)func.Method.MethodHandle.GetFunctionPointer();
        }

        public readonly TRet Invoke(T0 t0, T1 t1)
        {
            return functionPointer(pinnedObject.ObjectPointer, t0, t1);
        }
#else
         private readonly Il2CppMethodInfoHandle methodInfoHandle;

        public InstanceFunc(Func<T0,T1> func)
        
        {
            pinnedObject = new(func.Target);
            methodInfoHandle = new (func.Method)  ;
        }
        
        public readonly TRet Invoke(T0 t0,T1 t1)
        {
            return ((delegate* unmanaged[Cdecl]<IntPtr,T0,T1,Il2CppMethodInfoHandle, TRet>)methodInfoHandle.MethodPointer)(pinnedObject.ObjectPointer,t0,t1, methodInfoHandle);
        }
#endif
        public void Dispose()
        {
            pinnedObject.Dispose();
        }
    }

    public unsafe struct InstanceFunc<T0, T1, T2, TRet> : IDisposable
    {
        private PinnedObject pinnedObject;
        public PinnedObject Object=>pinnedObject;
#if Mono
        private readonly delegate* unmanaged[Cdecl]<IntPtr, T0, T1, T2, TRet> functionPointer;

        public InstanceFunc(Func<T0, T1, T2> func)

        {
            pinnedObject = new(func.Target);
            functionPointer =
                (delegate*unmanaged[Cdecl]<IntPtr, T0, T1, T2, TRet>)func.Method.MethodHandle.GetFunctionPointer();
        }

        public readonly TRet Invoke(T0 t0, T1 t1, T2 t2)
        {
           return functionPointer(pinnedObject.ObjectPointer, t0, t1, t2);
        }
#else
         private readonly Il2CppMethodInfoHandle methodInfoHandle;

        public InstanceFunc(Func<T0,T1,T2> func)
        
        {
            pinnedObject = new(func.Target);
            methodInfoHandle = new (func.Method)  ;
        }
        
        public readonly TRet Invoke(T0 t0,T1 t1,T2 t2)
        {
            return ((delegate* unmanaged[Cdecl]<IntPtr,T0,T1,T2,Il2CppMethodInfoHandle, TRet>)methodInfoHandle.MethodPointer)(pinnedObject.ObjectPointer,t0,t1,t2, methodInfoHandle);
        }
#endif
        public void Dispose()
        {
            pinnedObject.Dispose();
        }
    }

    public unsafe struct InstanceFunc<T0, T1, T2, T3, TRet> : IDisposable
    {
        private PinnedObject pinnedObject;
        public PinnedObject Object=>pinnedObject;
#if Mono
        private readonly delegate* unmanaged[Cdecl]<IntPtr, T0, T1, T2, T3, TRet> functionPointer;

        public InstanceFunc(Func<T0, T1, T2, T3> func)

        {
            pinnedObject = new(func.Target);
            functionPointer =
                (delegate*unmanaged[Cdecl]<IntPtr, T0, T1, T2, T3, TRet>)func.Method.MethodHandle
                    .GetFunctionPointer();
        }

        public readonly TRet Invoke(T0 t0, T1 t1, T2 t2, T3 t3)
        {
           return functionPointer(pinnedObject.ObjectPointer, t0, t1, t2, t3);
        }
#else
         private readonly Il2CppMethodInfoHandle methodInfoHandle;

        public InstanceFunc(Func<T0,T1,T2,T3> func)
        
        {
            pinnedObject = new(func.Target);
            methodInfoHandle = new (func.Method)  ;
        }
        
        public readonly TRet Invoke(T0 t0,T1 t1,T2 t2,T3 t3)
        {
            return ((delegate* unmanaged[Cdecl]<IntPtr,T0,T1,T2,T3,Il2CppMethodInfoHandle, TRet>)methodInfoHandle.MethodPointer)(pinnedObject.ObjectPointer,t0,t1,t2,t3, methodInfoHandle);
        }
#endif
        public void Dispose()
        {
            pinnedObject.Dispose();
        }
    }

    public unsafe struct InstanceFunc<T0, T1, T2, T3, T4, TRet> : IDisposable
    {
        private PinnedObject pinnedObject;
        public PinnedObject Object=>pinnedObject;
#if Mono
        private readonly delegate* unmanaged[Cdecl]<IntPtr, T0, T1, T2, T3, T4, TRet> functionPointer;

        public InstanceFunc(Func<T0, T1, T2, T3, T4> func)

        {
            pinnedObject = new(func.Target);
            functionPointer =
                (delegate*unmanaged[Cdecl]<IntPtr, T0, T1, T2, T3, T4, TRet>)func.Method.MethodHandle
                    .GetFunctionPointer();
        }

        public readonly TRet Invoke(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4)
        {
           return functionPointer(pinnedObject.ObjectPointer, t0, t1, t2, t3, t4);
        }
#else
         private readonly Il2CppMethodInfoHandle methodInfoHandle;

        public InstanceFunc(Func<T0,T1,T2,T3,T4> func)
        
        {
            pinnedObject = new(func.Target);
            methodInfoHandle = new (func.Method)  ;
        }
        
        public readonly TRet Invoke(T0 t0,T1 t1,T2 t2,T3 t3,T4 t4)
        {
            return ((delegate* unmanaged[Cdecl]<IntPtr,T0,T1,T2,T3,T4,Il2CppMethodInfoHandle, TRet>)methodInfoHandle.MethodPointer)(pinnedObject.ObjectPointer,t0,t1,t2,t3,t4, methodInfoHandle);
        }
#endif
        public void Dispose()
        {
            pinnedObject.Dispose();
        }
    }

    public unsafe struct InstanceFunc<T0, T1, T2, T3, T4, T5, TRet> : IDisposable
    {
        private PinnedObject pinnedObject;
        public PinnedObject Object=>pinnedObject;
#if Mono
        private readonly delegate* unmanaged[Cdecl]<IntPtr, T0, T1, T2, T3, T4, T5, TRet> functionPointer;

        public InstanceFunc(Func<T0, T1, T2, T3, T4, T5> func)

        {
            pinnedObject = new(func.Target);
            functionPointer =
                (delegate*unmanaged[Cdecl]<IntPtr, T0, T1, T2, T3, T4, T5, TRet>)func.Method.MethodHandle
                    .GetFunctionPointer();
        }

        public readonly TRet Invoke(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
           return functionPointer(pinnedObject.ObjectPointer, t0, t1, t2, t3, t4, t5);
        }
#else
         private readonly Il2CppMethodInfoHandle methodInfoHandle;

        public InstanceFunc(Func<T0,T1,T2,T3,T4,T5> func)
        
        {
            pinnedObject = new(func.Target);
            methodInfoHandle = new (func.Method)  ;
        }
        
        public readonly TRet Invoke(T0 t0,T1 t1,T2 t2,T3 t3,T4 t4,T5 t5)
        {
            return ((delegate* unmanaged[Cdecl]<IntPtr,T0,T1,T2,T3,T4,T5,Il2CppMethodInfoHandle, TRet>)methodInfoHandle.MethodPointer)(pinnedObject.ObjectPointer,t0,t1,t2,t3,t4,t5, methodInfoHandle);
        }
#endif
        public void Dispose()
        {
            pinnedObject.Dispose();
        }
    }

    public unsafe struct InstanceFunc<T0, T1, T2, T3, T4, T5, T6, TRet> : IDisposable
    {
        private PinnedObject pinnedObject;
        public PinnedObject Object=>pinnedObject;
#if Mono
        private readonly delegate* unmanaged[Cdecl]<IntPtr, T0, T1, T2, T3, T4, T5, T6, TRet> functionPointer;

        public InstanceFunc(Func<T0, T1, T2, T3, T4, T5, T6> func)

        {
            pinnedObject = new(func.Target);
            functionPointer =
                (delegate*unmanaged[Cdecl]<IntPtr, T0, T1, T2, T3, T4, T5, T6, TRet>)func.Method.MethodHandle
                    .GetFunctionPointer();
        }

        public readonly TRet Invoke(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
           return functionPointer(pinnedObject.ObjectPointer, t0, t1, t2, t3, t4, t5, t6);
        }
#else
         private readonly Il2CppMethodInfoHandle methodInfoHandle;

        public InstanceFunc(Func<T0,T1,T2,T3,T4,T5,T6> func)
        
        {
            pinnedObject = new(func.Target);
            methodInfoHandle = new (func.Method)  ;
        }
        
        public readonly TRet Invoke(T0 t0,T1 t1,T2 t2,T3 t3,T4 t4,T5 t5,T6 t6)
        {
            return ((delegate* unmanaged[Cdecl]<IntPtr,T0,T1,T2,T3,T4,T5,T6,Il2CppMethodInfoHandle, TRet>)methodInfoHandle.MethodPointer)(pinnedObject.ObjectPointer,t0,t1,t2,t3,t4,t5,t6, methodInfoHandle);
        }
#endif
        public void Dispose()
        {
            pinnedObject.Dispose();
        }
    }
}