using System;
using System.Runtime.InteropServices;

namespace UniReflection.IL2CPP
{
    public unsafe struct MarshaledString:IDisposable {
        public override bool Equals(object obj) {
            return obj is MarshaledString other && Equals(other);
        }

        public override int GetHashCode() {
            return unchecked((int) (long) Chars);
        }

        public byte* Chars;
        public MarshaledString(string str) {
            Chars=(byte*)Marshal.StringToHGlobalAnsi(str);
        }
        public NativeString AsNativeString() => new NativeString(Chars);
        public static bool operator ==(MarshaledString a, MarshaledString b) => a.Equals(b);
        public static bool operator !=(MarshaledString a, MarshaledString b) => !a.Equals(b);
        public static bool operator ==(MarshaledString a, NativeString b) => a.Equals(b);
        public static bool operator !=(MarshaledString a, NativeString b) => !a.Equals(b);
        
        public bool Equals(NativeString other) => NativeString.AnsiEquals(Chars,other.Chars);
        public bool Equals(MarshaledString other) => NativeString.AnsiEquals(Chars,other.Chars);
        public void Dispose() {
            if(Chars==null) return;
            Marshal.FreeHGlobal((IntPtr)Chars);
            Chars = null;
        }
    }
}