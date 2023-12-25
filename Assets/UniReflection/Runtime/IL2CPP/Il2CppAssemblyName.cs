namespace UniReflection.IL2CPP {
    public unsafe  struct Il2CppAssemblyNameHandle {
        public Il2CppAssemblyName* Value;
    }
    
    public unsafe  struct Il2CppAssemblyName {
        public byte* name;
        public byte* culture;
        public byte* public_key;
        public uint hash_alg;
        public int hash_len;
        public uint flags;
        public int major;
        public int minor;
        public int build;
        public int revision;
        public ulong public_key_token;
    }
}