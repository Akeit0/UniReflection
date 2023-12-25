#if UNITY_EDITOR||!ENABLE_IL2CPP
#define Mono
#endif
using System.Reflection;
using System;
using Unity.Collections.LowLevel.Unsafe;

namespace UniReflection.IL2CPP {
    public static unsafe class Extensions {
        public static Il2CppFieldInfoHandle GetHandle(this FieldInfo fieldInfo) {
            return new Il2CppFieldInfoHandle(fieldInfo);
        }

        public static Il2CppClassHandle GetClassHandle(this Type type) {
            return new Il2CppClassHandle(type);
        }

        public static Il2CppTypeHandle GetTypeHandle(this Type type) {
            return new Il2CppTypeHandle(type);
        }

        public static unsafe Il2CppClassHandle GetClassHandleFromObject(this object obj) {
            return new Il2CppObjectHandle(obj).Value->klass;
        }

        public static unsafe Il2CppTypeHandle GetTypeHandleFromObject(this object obj) {
            return new Il2CppTypeHandle(&(new Il2CppObjectHandle(obj).Value->klass.Value->byval_arg));
        }

        public static IntPtr AsPointer(this object obj) {
            return UnsafeUtility.As<object, IntPtr>(ref obj);
        }

        public static Il2CppMethodInfoHandle GetHandle(this System.Reflection.MethodInfo methodInfo) {
            return new Il2CppMethodInfoHandle(methodInfo);
        }
        public static void* GetFunctionPointer(this System.Reflection.MethodBase methodBase) {
#if Mono
            return methodBase.MethodHandle.GetFunctionPointer().ToPointer();
 #else
            return (void*)methodBase.MethodHandle.Value;
#endif
        }
    }

   
}