namespace UniReflection.IL2CPP {
    public unsafe struct Il2CppImageHandle {
        public Il2CppImage* Value;
        public struct Il2CppImage {
            public NativeString name;
            public NativeString nameNoExt;
            public Il2CppAssemblyHandle assembly;
            public uint typeCount;
            public uint exportedTypeCount;
            public uint customAttributeCount;
            public Il2CppMetadataImageHandle metadataHandle;
            public void* nameToClassHashTable;
            public void* codeGenModule;
            public uint token;
            public byte dynamic;
        }
    }
}