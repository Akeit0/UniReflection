using System;
using System.Runtime.InteropServices;
using System.Text;
using Unity.Collections.LowLevel.Unsafe;

namespace UniReflection.IL2CPP {
    public  unsafe struct NativeString {
        public override bool Equals(object obj) {
            return obj is NativeString other && Equals(other);
        }

        public override int GetHashCode() {
            return unchecked((int) (long) Chars);
        }

        public byte* Chars;
        public NativeString(IntPtr str) {
            Chars=(byte*)str;
        }
        public NativeString(byte* str) {
            Chars=str;
        }
        public override string ToString() {
            if(Chars==null||Chars[0]==0) return "";
            return Marshal.PtrToStringAnsi((IntPtr) Chars);
        }
        
        public static explicit operator string(NativeString str) => str.ToString();
        public static bool operator ==(NativeString a, NativeString b) => a.Equals(b);
        public static bool operator !=(NativeString a, NativeString b) => !a.Equals(b);
        public static bool operator ==(NativeString a, MarshaledString b) => a.Equals(b);
        public static bool operator !=(NativeString a, MarshaledString b) => !a.Equals(b);
        
        public static bool AnsiEquals(byte* a, byte* b) {
            
            if(a==b) return true;
            if(a==null||b==null) return false;
            while ((*a & *b)!=0) {
                if(*a++!=*b++)return false;
            }
            return true;
        }
        public bool Equals(NativeString other) => AnsiEquals(Chars,other.Chars);
        public bool Equals(MarshaledString other) => AnsiEquals(Chars,other.Chars);
        
        
    }
}