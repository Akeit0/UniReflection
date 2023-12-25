using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;

namespace UniReflection.IL2CPP {
    public unsafe struct VirtualInvokeData
    {
        public IntPtr methodPtr;
        public Il2CppMethodInfoHandle method;
    }
    public unsafe struct Il2CppMethodInfoHandle {
        public MethodInfo* Value;

        public Il2CppMethodInfoHandle(IntPtr value) {
            Value = (MethodInfo*)value;
        }
        public Il2CppMethodInfoHandle(MethodBase methodBase) {
            Value = (MethodInfo*)methodBase.MethodHandle.Value;
        }
     
        public object Invoke(void* obj, void** args, out Exception ex) {
            return Il2CppApi.il2cpp_runtime_invoke(Value, obj, args, out ex);
        }
        public object InvokeConvertArgs(object obj, Span<object> args, out Exception ex) {
            var objPtr=(void*) UnsafeUtility.As<object, IntPtr>(ref obj);
            if (args.IsEmpty) {
                return Il2CppApi.il2cpp_runtime_invoke_convert_args(Value, objPtr, null,0, out ex);
            }
            else {
                return Il2CppApi.il2cpp_runtime_invoke_convert_args(Value, objPtr, (void**)UnsafeUtility.AddressOf(ref UnsafeUtility.As<object, IntPtr>(
                    ref args[0])),args.Length, out ex);
            }
          
        }
        public  object InvokeConvertArgs( void* obj, void** param,
            int paramCount, out Exception exc) {
            return Il2CppApi.il2cpp_runtime_invoke_convert_args(Value, obj, param, paramCount, out exc);
        }
        /// <summary>
        /// Invoke without any check.
        /// If obj or args is value type, you should pass the address of the value.
        /// If obj or args is reference (e.g. class, ref), you should pass the reference it's self.
        /// </summary>
        /// <param name="obj">Invoke Instance reference</param>
        /// <param name="args">Invoke argument references</param>
        /// <param name="returnValue">return target reference</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InvokeUnsafe(void* obj, void** args, void* returnValue) {
            Value->invoker_method(Value->methodPointer, Value, obj, args, returnValue);
        }

        public MethodAttributes Attributes {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (MethodAttributes) Value->flags;
        }

        public bool IsAbstract => (uint) (this.Attributes & MethodAttributes.Abstract) > 0U;

        public bool IsConstructor => !this.IsStatic &&
                                     (this.Attributes & MethodAttributes.RTSpecialName) ==
                                     MethodAttributes.RTSpecialName;

        public bool IsFinal => (uint) (this.Attributes & MethodAttributes.Final) > 0U;

        public bool IsHideBySig => (uint) (this.Attributes & MethodAttributes.HideBySig) > 0U;

        public bool IsSpecialName => (uint) (this.Attributes & MethodAttributes.SpecialName) > 0U;

        public bool IsStatic {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint) (this.Attributes & MethodAttributes.Static) > 0U;
        }

        public bool IsVirtual => (uint) (this.Attributes & MethodAttributes.Virtual) > 0U;

        public bool IsAssembly => (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Assembly;

        public bool IsFamily => (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Family;

        public bool IsFamilyAndAssembly =>
            (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.FamANDAssem;

        public bool IsFamilyOrAssembly =>
            (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.FamORAssem;

        public bool IsPrivate => (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Private;

        public bool IsPublic => (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Public;
        public byte ParametersCount => Value->parameters_count;
        
        public bool IsGenericMethod => (Value->_bitfield0 & MethodInfo.Bitfield0.is_generic) != 0;
        public bool IsInflated => (Value->_bitfield0 & MethodInfo.Bitfield0.is_inflated) != 0;
        public bool IsWrapperType => (Value->_bitfield0 & MethodInfo.Bitfield0.wrapper_type) != 0;
        public bool HasFullRangeGenericParameters => (Value->_bitfield0 & MethodInfo.Bitfield0.has_full_generic_sharing_signature) != 0;
        
        public ReadOnlySpan<Il2CppTypeHandle> Parameters {
            get {
                var span = new ReadOnlySpan<Il2CppTypeHandle>(Value->parameters, ParametersCount);
                return span;
            }
        }
        public Il2CppTypeHandle ReturnType => Value->return_type;
        public Il2CppClassHandle DeclaringType => Value->klass;
        
        public void *MethodPointer {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get=> Value->methodPointer;
            }
        public  unsafe struct MethodInfo {
            public void* methodPointer;
            public void* virtualMethodPointer;
            public delegate*unmanaged[Cdecl]<void*, void*, void*, void**, void*, void> invoker_method;
            public NativeString name;
            public Il2CppClassHandle klass;
            public Il2CppTypeHandle return_type;
            public Il2CppTypeHandle* parameters;
            public void* runtime_data;
            public void* generic_data;
            public uint token;
            public ushort flags;
            public ushort iflags;
            public ushort slot;
            public byte parameters_count;
            public Bitfield0 _bitfield0;
            [Flags]

            public enum Bitfield0 : byte {
                BIT_is_generic = 0,
                is_generic = (1 << BIT_is_generic),
                BIT_is_inflated = 1,
                is_inflated = (1 << BIT_is_inflated),
                BIT_wrapper_type = 2,
                wrapper_type = (1 << BIT_wrapper_type),
                BIT_has_full_generic_sharing_signature = 3,
                has_full_generic_sharing_signature = (1 << BIT_has_full_generic_sharing_signature),
                #if UNITY_2023_2_OR_NEWER
                BIT_is_unmanaged_callers_only = 4,
                is_unmanaged_callers_only = (1 << BIT_is_unmanaged_callers_only),
                #endif
            }
        }
    }
}