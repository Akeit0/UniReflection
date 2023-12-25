namespace UniReflection.IL2CPP {
    public unsafe struct Il2CppEventInfoHandle {
        public EventInfo* Value;
        public struct EventInfo {
            public NativeString name;
            public Il2CppTypeHandle eventType;
            public Il2CppClassHandle parent;
            public Il2CppMethodInfoHandle add;
            public Il2CppMethodInfoHandle remove;
            public Il2CppMethodInfoHandle raise;
            public uint token;
        }
    }
}