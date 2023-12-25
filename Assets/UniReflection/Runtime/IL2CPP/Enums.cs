namespace UniReflection.IL2CPP {
    public enum Il2CppGCMode
    {
    IL2CPP_GC_MODE_DISABLED = 0,
    IL2CPP_GC_MODE_ENABLED = 1,
    IL2CPP_GC_MODE_MANUAL = 2
    }
    public enum Il2CppStat {
        IL2CPP_STAT_NEW_OBJECT_COUNT,
        IL2CPP_STAT_INITIALIZED_CLASS_COUNT,
        //IL2CPP_STAT_GENERIC_VTABLE_COUNT,
        //IL2CPP_STAT_USED_CLASS_COUNT,
        IL2CPP_STAT_METHOD_COUNT,
        //IL2CPP_STAT_CLASS_VTABLE_SIZE,
        IL2CPP_STAT_CLASS_STATIC_DATA_SIZE,
        IL2CPP_STAT_GENERIC_INSTANCE_COUNT,
        IL2CPP_STAT_GENERIC_CLASS_COUNT,
        IL2CPP_STAT_INFLATED_METHOD_COUNT,
        IL2CPP_STAT_INFLATED_TYPE_COUNT,
        //IL2CPP_STAT_DELEGATE_CREATIONS,
        //IL2CPP_STAT_MINOR_GC_COUNT,
        //IL2CPP_STAT_MAJOR_GC_COUNT,
        //IL2CPP_STAT_MINOR_GC_TIME_USECS,
        //IL2CPP_STAT_MAJOR_GC_TIME_USECS
    }
    public enum Il2CppVarType
    {
        IL2CPP_VT_EMPTY = 0,
        IL2CPP_VT_NULL = 1,
        IL2CPP_VT_I2 = 2,
        IL2CPP_VT_I4 = 3,
        IL2CPP_VT_R4 = 4,
        IL2CPP_VT_R8 = 5,
        IL2CPP_VT_CY = 6,
        IL2CPP_VT_DATE = 7,
        IL2CPP_VT_BSTR = 8,
        IL2CPP_VT_DISPATCH = 9,
        IL2CPP_VT_ERROR = 10,
        IL2CPP_VT_BOOL = 11,
        IL2CPP_VT_VARIANT = 12,
        IL2CPP_VT_UNKNOWN = 13,
        IL2CPP_VT_DECIMAL = 14,
        IL2CPP_VT_I1 = 16,
        IL2CPP_VT_UI1 = 17,
        IL2CPP_VT_UI2 = 18,
        IL2CPP_VT_UI4 = 19,
        IL2CPP_VT_I8 = 20,
        IL2CPP_VT_UI8 = 21,
        IL2CPP_VT_INT = 22,
        IL2CPP_VT_UINT = 23,
        IL2CPP_VT_VOID = 24,
        IL2CPP_VT_HRESULT = 25,
        IL2CPP_VT_PTR = 26,
        IL2CPP_VT_SAFEARRAY = 27,
        IL2CPP_VT_CARRAY = 28,
        IL2CPP_VT_USERDEFINED = 29,
        IL2CPP_VT_LPSTR = 30,
        IL2CPP_VT_LPWSTR = 31,
        IL2CPP_VT_RECORD = 36,
        IL2CPP_VT_INT_PTR = 37,
        IL2CPP_VT_UINT_PTR = 38,
        IL2CPP_VT_FILETIME = 64,
        IL2CPP_VT_BLOB = 65,
        IL2CPP_VT_STREAM = 66,
        IL2CPP_VT_STORAGE = 67,
        IL2CPP_VT_STREAMED_OBJECT = 68,
        IL2CPP_VT_STORED_OBJECT = 69,
        IL2CPP_VT_BLOB_OBJECT = 70,
        IL2CPP_VT_CF = 71,
        IL2CPP_VT_CLSID = 72,
        IL2CPP_VT_VERSIONED_STREAM = 73,
        IL2CPP_VT_BSTR_BLOB = 0xfff,
        IL2CPP_VT_VECTOR = 0x1000,
        IL2CPP_VT_ARRAY = 0x2000,
        IL2CPP_VT_BYREF = 0x4000,
        IL2CPP_VT_RESERVED = 0x8000,
        IL2CPP_VT_ILLEGAL = 0xffff,
        IL2CPP_VT_ILLEGALMASKED = 0xfff,
        IL2CPP_VT_TYPEMASK = 0xfff,
    } 
    public enum Il2CppTypeEnum : byte
    {
        IL2CPP_TYPE_END = 0x00, /* End of List */
        IL2CPP_TYPE_VOID = 0x01,
        IL2CPP_TYPE_BOOLEAN = 0x02,
        IL2CPP_TYPE_CHAR = 0x03,
        IL2CPP_TYPE_I1 = 0x04,
        IL2CPP_TYPE_U1 = 0x05,
        IL2CPP_TYPE_I2 = 0x06,
        IL2CPP_TYPE_U2 = 0x07,
        IL2CPP_TYPE_I4 = 0x08,
        IL2CPP_TYPE_U4 = 0x09,
        IL2CPP_TYPE_I8 = 0x0a,
        IL2CPP_TYPE_U8 = 0x0b,
        IL2CPP_TYPE_R4 = 0x0c,
        IL2CPP_TYPE_R8 = 0x0d,
        IL2CPP_TYPE_STRING = 0x0e,
        IL2CPP_TYPE_PTR = 0x0f, /* arg: <type> token */
        IL2CPP_TYPE_BYREF = 0x10, /* arg: <type> token */
        IL2CPP_TYPE_VALUETYPE = 0x11, /* arg: <type> token */
        IL2CPP_TYPE_CLASS = 0x12, /* arg: <type> token */
        IL2CPP_TYPE_VAR =
            0x13, /* Generic parameter in a generic type definition, represented as number (compressed unsigned integer) number */
        IL2CPP_TYPE_ARRAY = 0x14, /* type, rank, boundsCount, bound1, loCount, lo1 */
        IL2CPP_TYPE_GENERICINST = 0x15, /* <type> <type-arg-count> <type-1> \x{2026} <type-n> */
        IL2CPP_TYPE_TYPEDBYREF = 0x16,
        IL2CPP_TYPE_I = 0x18,
        IL2CPP_TYPE_U = 0x19,
        IL2CPP_TYPE_FNPTR = 0x1b, /* arg: full method signature */
        IL2CPP_TYPE_OBJECT = 0x1c,
        IL2CPP_TYPE_SZARRAY = 0x1d, /* 0-based one-dim-array */

        IL2CPP_TYPE_MVAR =
            0x1e, /* Generic parameter in a generic method definition, represented as number (compressed unsigned integer)  */
        IL2CPP_TYPE_CMOD_REQD = 0x1f, /* arg: typedef or typeref token */
        IL2CPP_TYPE_CMOD_OPT = 0x20, /* optional arg: typedef or typref token */
        IL2CPP_TYPE_INTERNAL = 0x21, /* CLR internal type */

        IL2CPP_TYPE_MODIFIER = 0x40, /* Or with the following types */
        IL2CPP_TYPE_SENTINEL = 0x41, /* Sentinel for varargs method signature */
        IL2CPP_TYPE_PINNED = 0x45, /* Local var that points to pinned object */

        IL2CPP_TYPE_ENUM = 0x55 /* an enumeration */
    }
}