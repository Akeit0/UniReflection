using System;
using Unity.Collections.LowLevel.Unsafe;

namespace UniReflection.IL2CPP {
    public unsafe struct Il2CppReflectionTypeHandle {
        public Il2CppReflectionType* Value;
        public Il2CppReflectionTypeHandle(Type type) {
            Value = (Il2CppReflectionType*) UnsafeUtility.As<Type, IntPtr>(ref type);
        }

        public  Type SystemType  {
            get {
                var p = (IntPtr*) UnsafeUtility.AddressOf(ref this);
                return  UnsafeUtility.As<IntPtr, Type>(ref p[0]);
            }
        }
        public static implicit operator Il2CppReflectionTypeHandle(Type type) => new Il2CppReflectionTypeHandle(type);
        public static explicit operator Type(Il2CppReflectionTypeHandle type) => type.SystemType;
        public override string ToString() => SystemType.ToString();
        public  struct Il2CppReflectionType
        {
            public Il2CppObject o;
            public Il2CppTypeHandle type;
        }
    }
}