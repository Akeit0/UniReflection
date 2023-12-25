using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;

namespace UniReflection.IL2CPP {
    public unsafe struct Il2CppObjectHandle {
        public Il2CppObject* Value;

        public Il2CppObjectHandle(Il2CppObject* value) {
            Value = value;
        }

        public Il2CppObjectHandle(object o) {
            Value = (Il2CppObject*) o.AsPointer();
        }
        
        public  object SystemObject {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Unsafe.As<Il2CppObjectHandle, object>(ref this);
        }

        public override string ToString() => SystemObject.ToString();
    }


    public unsafe struct Il2CppObject {
        public Il2CppClassHandle klass;
        MonitorData* monitor;
    }

    public struct MonitorData {
    }
}