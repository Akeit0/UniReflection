using System;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;

namespace UniReflection.IL2CPP {


    public unsafe struct Il2CppStringHandle {
        public Il2CppString* Value;

        public Il2CppStringHandle(Il2CppString* value) {
            Value = value;
        }

        public Il2CppStringHandle(string str) {
            Value = (Il2CppString*) UnsafeUtility.As<string, IntPtr>(ref str);
        }

        public  string SystemString {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get =>  Unsafe.As<Il2CppStringHandle, string>(ref this);
            
        }
        public static implicit operator Il2CppStringHandle(string str) => new Il2CppStringHandle(str);
        public override string ToString() => SystemString;
    }



    public unsafe struct Il2CppString {
        public Il2CppObject Object;
        public  int length;
        public  char* chars;
    }
}