using System;

namespace UniReflection.IL2CPP {
    public  readonly unsafe struct Il2CppTypeHandle {
        public readonly Il2CppType* Value;
        
        public Il2CppTypeHandle(Type type) {
            Value = (Il2CppType*)type.TypeHandle.Value;
        }
        public Il2CppTypeHandle(Il2CppType* value) {
            Value = value;
        }
        public Type SystemType=>Il2CppApi.il2cpp_type_get_object(this).SystemType;
        public Il2CppClassHandle ClassHandle=>Il2CppApi.il2cpp_class_from_type(this);
        
        public bool IsByRef => (Value->_bitfield0 & Il2CppType.Bitfield0.byref) != 0;
        public bool IsValueType => (Value->_bitfield0 & Il2CppType.Bitfield0.valuetype) != 0;
        public bool IsRefOrByRef => IsByRef || !IsValueType;
        public bool IsVoid => Value->type ==Il2CppTypeEnum.IL2CPP_TYPE_VOID;
        public bool IsPinned => (Value->_bitfield0 & Il2CppType.Bitfield0.pinned) != 0;
        public Il2CppTypeEnum TypeEnum => Value->type;
        
    
        public unsafe struct Il2CppType {
            public void* data;
            public ushort attrs;
            public Il2CppTypeEnum type;
            public Bitfield0 _bitfield0;

            [Flags]
            public enum Bitfield0 : byte {
                byref = (1 << 5),
                pinned = (1 << 6),
                valuetype = (1 << 7),
            }

            public bool IsByRef => (_bitfield0 & Bitfield0.byref) != 0;
            public bool IsValueType => (_bitfield0 & Bitfield0.valuetype) != 0;
            public bool IsRefOrByRef => IsByRef || IsValueType;
            public bool IsVoid => type ==Il2CppTypeEnum.IL2CPP_TYPE_VOID;
        }
    }
    
    
}