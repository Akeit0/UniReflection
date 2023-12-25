namespace UniReflection.IL2CPP {
    public unsafe struct Il2CppPropertyInfoHandle {
        public PropertyInfo* Value;
        public struct PropertyInfo {
            public Il2CppClassHandle parent;
            public NativeString name;
            public Il2CppMethodInfoHandle get;
            public Il2CppMethodInfoHandle set;
            public uint attrs;
            public uint token;
        }
    }
}