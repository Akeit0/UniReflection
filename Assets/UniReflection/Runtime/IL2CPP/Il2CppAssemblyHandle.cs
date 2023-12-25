namespace UniReflection.IL2CPP {
    public unsafe struct Il2CppAssemblyHandle {
        public Il2CppAssembly* Value;
        
    }
    public struct Il2CppAssembly {
        public Il2CppImageHandle image;
        public uint token;
        public int referencedAssemblyStart;
        public int referencedAssemblyCount;
        public Il2CppAssemblyNameHandle aname;
    }
}