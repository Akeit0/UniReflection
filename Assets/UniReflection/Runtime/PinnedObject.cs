using System;
using Unity.Collections.LowLevel.Unsafe;
namespace UniReflection
{
    public  unsafe struct PinnedObject : IDisposable
    {
        public readonly IntPtr ObjectPointer;
        public readonly ulong GCHandle;
        
        public PinnedObject(object obj)
        {
            if(obj is null) throw new NullReferenceException("GC can't pin null");
            else ObjectPointer=(IntPtr) UnsafeUtility.PinGCObjectAndGetAddress(obj,out  GCHandle); 
        }

        public void Dispose()
        {
            if(ObjectPointer==IntPtr.Zero) return;
            UnsafeUtility.ReleaseGCObject(GCHandle);
            this= default;
           // ObjectPointer = IntPtr.Zero;
        }
    }
}