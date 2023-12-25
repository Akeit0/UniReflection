using System;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;

namespace UniReflection {
    public static unsafe  class UnsafeConversion {
#if UNITY_EDITOR||!ENABLE_IL2CPP
        public static readonly delegate*<IntPtr, IntPtr> IdentityFunctionPointer =(delegate*<IntPtr, IntPtr>) ((Func<IntPtr, IntPtr>) Identity).Method.MethodHandle.GetFunctionPointer();
#else
        public  static readonly delegate*<IntPtr, IntPtr> IdentityFunctionPointer = &Identity;
#endif
        
        
        
        
        
        public static IntPtr Identity(IntPtr ptr) {
            return ptr;
        }
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T As<T>(object o ){
            return UnsafeUtility.As<object, T>(ref o);
        }
    }
}