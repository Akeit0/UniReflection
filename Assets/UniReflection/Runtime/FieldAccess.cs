#if UNITY_EDITOR|| !ENABLE_IL2CPP
#define Mono
#endif


using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using UniReflection.IL2CPP;
namespace UniReflection {

    public static unsafe class FieldAccess {
        class SimpleClass {
            public byte I;
        }
        public static readonly int BaseClassFieldOffset= UnsafeUtility.GetFieldOffset(typeof(SimpleClass).GetField("I"));
        public static void Read<T>(Span<T> a){}
        
        public static int GetOffset(this FieldInfo fieldInfo) {
            var declaringType = fieldInfo.DeclaringType;
            if(declaringType is null) throw new NullReferenceException();
            if(declaringType.IsValueType) return UnsafeUtility.GetFieldOffset(fieldInfo);
            return UnsafeUtility.GetFieldOffset(fieldInfo)-BaseClassFieldOffset;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref byte GetBaseRef(this object obj) {
            return ref Unsafe.As<SimpleClass>(obj).I;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly TValue ReadFieldFromObject<TValue>(object obj,int offset) {
           return ref Unsafe.As<byte,TValue>(ref Unsafe.Add(ref obj.GetBaseRef(),offset));
        } 
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref  TValue GetFieldReferenceFromObject<TValue>(object obj,int offset) {
            return ref Unsafe.As<byte,TValue>(ref Unsafe.AddByteOffset(ref Unsafe.As<SimpleClass>(obj).I,(IntPtr)offset));
        } 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly TValue ReadFieldFromRef<T,TValue>(in  T obj,int offset) {//where T:struct
            return ref Unsafe.As<T,TValue>(ref Unsafe.AddByteOffset(ref Unsafe.AsRef(in obj),(IntPtr)offset));
        } 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref  TValue GetFieldReferenceFromRef<T,TValue>(ref  T obj,int offset) {
            return ref Unsafe.As<T,TValue>(ref Unsafe.AddByteOffset(ref  obj,(IntPtr)offset));
        } 
        
        public static Func<TValue> CreateStaticFieldGetter<TValue>(
            this FieldInfo fieldInfo) {
#if Mono
            DynamicMethod m = new DynamicMethod("getter", typeof(TValue),TypeArrayCache<object>.TypeArray);
            ILGenerator cg = m.GetILGenerator();
            cg.Emit(OpCodes.Ldsfld, fieldInfo);
            cg.Emit(OpCodes.Ret);
            return (Func<TValue>) m.CreateDelegate(typeof(Func<TValue>));
#else
            var handle = fieldInfo.GetHandle();
            if(!handle.IsStatic)return null;
            return () => {
                var v = default(TValue);
                Il2CppApi.il2cpp_field_static_get_value(handle, Unsafe.AsPointer(ref v));
                return v;
            };
#endif
        }
        public static Action<TValue> CreateStaticFieldSetter<TValue>(
            this FieldInfo fieldInfo) {
#if Mono
            DynamicMethod m = new DynamicMethod("setter", null,TypeArrayCache<object,TValue>.TypeArray);
            ILGenerator cg = m.GetILGenerator();
            cg.Emit(OpCodes.Ldarg_1);
            cg.Emit(OpCodes.Stsfld, fieldInfo);
            cg.Emit(OpCodes.Ret);
            return (Action<TValue>) m.CreateDelegate(typeof(Action<TValue>));
#else
            var handle = fieldInfo.GetHandle();
            if(!handle.IsStatic)return null;
            var t=typeof(TValue);
            if(t.IsValueType&&!t.IsPointer)
            {
                return v => { Il2CppApi.il2cpp_field_static_set_value(handle, Unsafe.AsPointer(ref v)); };
            }
            {
                return v => Il2CppApi.il2cpp_field_static_set_value(handle, Unsafe.As<TValue, IntPtr>(ref v).ToPointer());
            }
#endif
        }
    }
}