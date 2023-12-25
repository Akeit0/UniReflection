using System;
using System.Reflection;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace UniReflection.IL2CPP {
    public unsafe struct Il2CppClassHandle {
        public Il2CppClass* Value;
        
        public Il2CppClassHandle(Type type) {
            this=Il2CppApi.il2cpp_class_from_type(type.GetTypeHandle());
        }
        public Il2CppClassHandle(Il2CppTypeHandle typeHandle) {
            this= Il2CppApi.il2cpp_class_from_type(typeHandle);
        }

        public void Init() {
            Il2CppApi.il2cpp_runtime_class_init(this);
        }
        public static Il2CppClass* Alloc(int  vTableSlots)=>
            (Il2CppClass*)Il2CppApi.il2cpp_alloc((uint) (sizeof(Il2CppClass) + sizeof(VirtualInvokeData) * vTableSlots));
        
        public uint ActualSize => Value->actualSize;

        public object NewUninitialized() => Il2CppApi.il2cpp_object_new(this).SystemObject;
        
        
        public object New() {
            var o= Il2CppApi.il2cpp_object_new(this).SystemObject;
            foreach (var m in Methods) {
                if(m is { IsConstructor: true, Parameters: { Length: 0 } }) {
                    var method = (delegate*unmanaged[Cdecl]<object,void>)m.Value->methodPointer;
                    method(o);
                    break;
                }
            }

            return o;
        }
        public Type SystemType=>Il2CppApi.il2cpp_class_get_type(this).SystemType;

        public ReadOnlySpan<Il2CppClassHandle> ImplementedInterfaces {
            get {
                var count = Value->interfaces_count;
                if(count==0)return ReadOnlySpan<Il2CppClassHandle>.Empty;
                Init();
                void* interfaces = null;
                Il2CppApi.il2cpp_class_get_interfaces(this, ref interfaces);
                return new ReadOnlySpan<Il2CppClassHandle>(interfaces, Value->interfaces_count);
            }
        }

        public ReadOnlySpan<Il2CppClassHandle> NestedTypes {
            get {  Init();
                return new ReadOnlySpan<Il2CppClassHandle>(Value->nestedTypes, Value->nested_type_count); }
        }

        public ReadOnlySpan<Il2CppFieldInfoHandle.FieldInfo> Fields {
            get {   
                var count = Value->interfaces_count;
                if(count==0)return ReadOnlySpan<Il2CppFieldInfoHandle.FieldInfo>.Empty;
                void* fields = null;
                Il2CppApi.il2cpp_class_get_fields(this, ref fields);
                return new ReadOnlySpan<Il2CppFieldInfoHandle.FieldInfo>(fields, count); }
        }

        public ReadOnlySpan<Il2CppMethodInfoHandle> Methods {
            get {   Init();
                void* methods = null;
                Il2CppApi.il2cpp_class_get_methods(this, ref methods);
                return new ReadOnlySpan<Il2CppMethodInfoHandle>(methods, Value->method_count); }
        }
        
        public bool IsAssignableFrom(Il2CppClassHandle other) {
            return Il2CppApi.il2cpp_class_is_assignable_from(this, other);
        }
        
        public bool IsSubclassOf(Il2CppClassHandle other,bool checkInterfaces=true) {
            return Il2CppApi.il2cpp_class_is_subclass_of(this, other,checkInterfaces);
        }
        public NativeString Name=>Value->name;
        public NativeString Namespace=>Value->namespaze;
        
        public  static Func<T> CreateConstructorDelegate<T>() {
            var klass=typeof(T).GetClassHandle();
            if (klass.Value->byval_arg.IsValueType) {
                return () => default(T);
            }
            foreach (var m in klass.Methods) {
                if(m.IsConstructor&&m.Parameters.Length==1) {
                    var method = (delegate*unmanaged[Cdecl]<object,void>)m.Value->methodPointer;
                    return () => {
                        var o = Il2CppApi.il2cpp_object_new(klass);
                        var instance = UnsafeUtility.As<Il2CppObjectHandle,T>(ref o);
                        method(instance);
                        return instance;
                    };
                }
            }
            return null;
        }
        public  static Func<TArg,T> CreateConstructorDelegate<T,TArg>() {
            var klass=typeof(T).GetClassHandle();
            foreach (var m in klass.Methods) {
                var parameters = m.Parameters;
                if(m.IsConstructor&&parameters.Length==2&&parameters[1].SystemType==typeof(TArg)) {
                    if (!parameters[1].IsValueType) {
                        if(!klass.Value->byval_arg.IsValueType) {
                            var method = (delegate*unmanaged[Cdecl]<object, object, void>) m.Value->methodPointer;
                            return (tArg) => {
                                var o = Il2CppApi.il2cpp_object_new(klass);
                                var instance = UnsafeUtility.As<Il2CppObjectHandle, T>(ref o);
                                var arg = UnsafeUtility.As<TArg, object>(ref tArg);
                                method(instance, arg);
                                return instance;
                            };
                        }
                        else {
                            var method = (delegate*unmanaged[Cdecl]<ref byte, object, void>) m.Value->methodPointer;
                            return (tArg) => {
                                var o = default(T);
                                var arg = UnsafeUtility.As<TArg, object>(ref tArg);
                                method(ref UnsafeUtility.As<T,byte>(ref o), arg);
                                return o;
                            };
                        }
                    }
                    else {
                        if(!klass.Value->byval_arg.IsValueType) {
                            return (tArg) => {
                                var o = Il2CppApi.il2cpp_object_new(klass);
                                var p=UnsafeUtility.AddressOf(ref UnsafeUtility.As<TArg, IntPtr>(ref tArg));
                                m.InvokeUnsafe(o.Value, &p,null);
                                return UnsafeUtility.As<Il2CppObjectHandle, T>(ref o);
                            };
                        }
                        else {
                            return (tArg) => {
                                var o = default(T);
                                var oPtr=UnsafeUtility.AddressOf(ref UnsafeUtility.As<T, IntPtr>(ref o));
                                var p=UnsafeUtility.AddressOf(ref UnsafeUtility.As<TArg, IntPtr>(ref tArg));
                                m.InvokeUnsafe(oPtr, &p,null);
                                return o;
                            };
                        }
                    }
                   
                }
            }
            return null;
        }
        
        public bool IsValueType => Value->byval_arg.IsValueType;
        public Il2CppClassHandle GetBaseClassHandle()=>Value->parent;
        public Type GetSystemType()=>Il2CppApi.il2cpp_type_get_object(new Il2CppTypeHandle(&Value->parent.Value->byval_arg)).SystemType;
        public struct Il2CppClass {
             public Il2CppImageHandle image;
            public void* gc_desc;
            public NativeString name;
            public NativeString namespaze;
            public Il2CppTypeHandle.Il2CppType byval_arg;
            public Il2CppTypeHandle.Il2CppType this_arg;
            public Il2CppClassHandle element_class;
            public Il2CppClassHandle castClass;
            public Il2CppClassHandle declaringType;
            public Il2CppClassHandle parent;
            public Il2CppGenericClassHandle generic_class;
            public Il2CppMetadataTypeHandle typeMetadataHandle;
            public void* interopData;
            public Il2CppClassHandle klass;
            // The following fields need initialized before access. This can be done per field or as an aggregate via a call to Class::Init
            public Il2CppFieldInfoHandle fields;
            public Il2CppEventInfoHandle events;
            public Il2CppPropertyInfoHandle properties;
            public Il2CppMethodInfoHandle* methods;
            public Il2CppClassHandle* nestedTypes;
            public Il2CppClassHandle* implementedInterfaces;
            public Il2CppRuntimeInterfaceOffsetPairHandle interfaceOffsets;
            public void* static_fields;
            public void* rgctx_data;
            public Il2CppClassHandle* typeHierarchy;
            public void* unity_user_data;
#if UNITY_2023_1_OR_NEWER
            public Il2CppGCHandle initializationExceptionGCHandle;
#else
            public uint initializationExceptionGCHandle;
#endif
            public uint cctor_started;
            public uint cctor_finished_or_no_cctor;
            public IntPtr cctor_thread;
            public Il2CppMetadataGenericContainerHandle genericContainerHandle;
            public uint instance_size;
            public uint stack_slot_size;
            public uint actualSize;
            public uint element_size;
            public int native_size;
            public uint static_fields_size;
            public uint thread_static_fields_size;
            public int thread_static_fields_offset;
            public TypeAttributes flags;
            public uint token;
            public ushort method_count;
            public ushort property_count;
            public ushort field_count;
            public ushort event_count;
            public ushort nested_type_count;
            public ushort vtable_count;
            public ushort interfaces_count;
            public ushort interface_offsets_count;
            public byte typeHierarchyDepth;
            public byte genericRecursionDepth;
            public byte rank;
            public byte minimumAlignment;
            public byte packingSize;
            public Bitfield0 _bitfield0;
            public Bitfield1 _bitfield1;
            [Flags]
            public enum Bitfield0 : byte
            {
                BIT_initialized_and_no_error = 0,
                initialized_and_no_error = (1 << BIT_initialized_and_no_error),
                BIT_initialized = 1,
                initialized = (1 << BIT_initialized),
                BIT_enumtype = 2,
                enumtype = (1 << BIT_enumtype),
                BIT_nullabletype = 3,
                nullabletype = (1 << BIT_nullabletype),
                BIT_is_generic = 4,
                is_generic = (1 << BIT_is_generic),
                BIT_has_references = 5,
                has_references = (1 << BIT_has_references),
                BIT_init_pending = 6,
                init_pending = (1 << BIT_init_pending),
                BIT_size_init_pending = 7,
                size_init_pending = (1 << BIT_size_init_pending),
            }

            public enum Bitfield1 : byte
            {
                BIT_size_inited = 0,
                size_inited = (1 << BIT_size_inited),
                BIT_has_finalize = 1,
                has_finalize = (1 << BIT_has_finalize),
                BIT_has_cctor = 2,
                has_cctor = (1 << BIT_has_cctor),
                BIT_is_blittable = 3,
                is_blittable = (1 << BIT_is_blittable),
                BIT_is_import_or_windows_runtime = 4,
                is_import_or_windows_runtime = (1 << BIT_is_import_or_windows_runtime),
                BIT_is_vtable_initialized = 5,
                is_vtable_initialized = (1 << BIT_is_vtable_initialized),
                BIT_is_byref_like = 6,
                is_byref_like = (1 << BIT_is_byref_like),
            }
        }
    }
}