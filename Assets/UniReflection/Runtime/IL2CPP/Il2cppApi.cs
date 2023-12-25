using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UniReflection.IL2CPP {
    [Preserve]
    public static unsafe  class Il2CppApi {
        private const string AssemblyName = "__Internal";


        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_init(void* domain_name);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_init_utf16(void* domain_name);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_shutdown();

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_set_config_dir(void* config_path);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_set_data_dir(void* data_path);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_set_temp_dir(void* temp_path);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_set_commandline_arguments(int argc, void* argv, void* basedir);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_set_commandline_arguments_utf16(int argc, void* argv, void* basedir);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_set_config_utf16(void* executablePath);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_set_config(void* executablePath);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_set_memory_callbacks(void* callbacks);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppImageHandle il2cpp_get_corlib();

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_add_internal_call(void* name, void* method);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_resolve_icall(NativeString name);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_alloc(uint size);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_free(void* ptr);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_array_class_get(void* element_class, uint rank);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint il2cpp_array_length(void* array);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint il2cpp_array_get_byte_length(void* array);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_array_new(void* elementTypeInfo, ulong length);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_array_new_specific(void* arrayTypeInfo, ulong length);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_array_new_full(void* array_class, ref ulong lengths, ref ulong lower_bounds);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_bounded_array_class_get(void* element_class, uint rank,
            [MarshalAs(UnmanagedType.I1)] bool bounded);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int il2cpp_array_element_size(void* array_class);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_assembly_get_image(void* assembly);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppTypeHandle il2cpp_class_enum_basetype(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_class_is_generic(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_class_is_inflated(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_class_is_assignable_from(Il2CppClassHandle klass, Il2CppClassHandle oklass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_class_is_subclass_of(Il2CppClassHandle klass, Il2CppClassHandle klassc,
            [MarshalAs(UnmanagedType.I1)] bool check_interfaces);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_class_has_parent(Il2CppClassHandle klass, Il2CppClassHandle klassc);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppClassHandle il2cpp_class_from_il2cpp_type(Il2CppTypeHandle type);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppClassHandle il2cpp_class_from_name(Il2CppImageHandle image,
             NativeString namespaze,
             NativeString name);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppClassHandle il2cpp_class_from_system_type(Il2CppReflectionTypeHandle type);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppClassHandle il2cpp_class_get_element_class(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_class_get_events(Il2CppClassHandle klass, ref void* iter);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppFieldInfoHandle il2cpp_class_get_fields(Il2CppClassHandle klass, ref void* iter);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_class_get_nested_types(Il2CppClassHandle klass, ref void* iter);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_class_get_interfaces(Il2CppClassHandle klass, ref void* iter);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_class_get_properties(Il2CppClassHandle klass, ref void* iter);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_class_get_property_from_name(Il2CppClassHandle klass, void* name);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_class_get_field_from_name(Il2CppClassHandle klass,
             NativeString name);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_class_get_methods(Il2CppClassHandle klass, ref void* iter);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_class_get_method_from_name(Il2CppClassHandle klass,
            NativeString name, int argsCount);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_class_get_name(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_class_get_namespace(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_class_get_parent(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_class_get_declaring_type(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int il2cpp_class_instance_size(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint il2cpp_class_num_fields(void* enumKlass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_class_is_valuetype(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int il2cpp_class_value_size(void* klass, ref uint align);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_class_is_blittable(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int il2cpp_class_get_flags(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_class_is_abstract(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_class_is_interface(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int il2cpp_class_array_element_size(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppClassHandle il2cpp_class_from_type(Il2CppTypeHandle type);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppTypeHandle il2cpp_class_get_type(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint il2cpp_class_get_type_token(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_class_has_attribute(Il2CppClassHandle klass, Il2CppClassHandle attr_class);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_class_has_references(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_class_is_enum(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_class_get_image(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_class_get_assemblyname(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int il2cpp_class_get_rank(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint il2cpp_class_get_bitmap_size(void* klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_class_get_bitmap(void* klass, ref uint bitmap);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_stats_dump_to_file(void* path);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern ulong il2cpp_stats_get_value(int stat);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_domain_get();

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_domain_assembly_open(void* domain, void* name);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void** il2cpp_domain_get_assemblies(void* domain, ref uint size);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void*
            il2cpp_exception_from_name_msg(void* image, void* name_space, void* name, void* msg);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_get_exception_argument_null(void* arg);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_format_exception(void* ex, void* message, int message_size);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_format_stack_trace(void* ex, void* output, int output_size);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_unhandled_exception(void* ex);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int il2cpp_field_get_flags(Il2CppFieldInfoHandle field);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_field_get_name(Il2CppFieldInfoHandle field);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppClassHandle il2cpp_field_get_parent(Il2CppFieldInfoHandle field);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint il2cpp_field_get_offset(Il2CppFieldInfoHandle field);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_field_get_type(Il2CppFieldInfoHandle field);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_field_get_value(Il2CppObjectHandle obj, Il2CppFieldInfoHandle field,
            void* value);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppObjectHandle il2cpp_field_get_value_object(Il2CppFieldInfoHandle field,
            Il2CppObjectHandle obj);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_field_has_attribute(Il2CppFieldInfoHandle field, Il2CppClassHandle attr_class);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_field_set_value(Il2CppObjectHandle obj, Il2CppFieldInfoHandle field,
            void* value);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_field_static_get_value(Il2CppFieldInfoHandle field, void* value);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_field_static_set_value(Il2CppFieldInfoHandle field, void* value);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_field_set_value_object(Il2CppObjectHandle instance,
            Il2CppFieldInfoHandle field, Il2CppObjectHandle value);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_gc_collect(int maxGenerations);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int il2cpp_gc_collect_a_little();

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_gc_disable();

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_gc_enable();

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_gc_is_disabled();

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_gc_set_mode(Il2CppGCMode mode);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long il2cpp_gc_get_max_time_slice_ns();

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_gc_set_max_time_slice_ns(long maxTimeSlice);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_gc_is_incremental();

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long il2cpp_gc_get_used_size();

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern long il2cpp_gc_get_heap_size();


        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_stop_gc_world();

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_start_gc_world();

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_gc_alloc_fixed(nint size);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_gc_free_fixed(void* address);


        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_gc_wbarrier_set_field(void* obj, void* targetAddress, void* gcObj);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern nint il2cpp_gchandle_new(void* obj, [MarshalAs(UnmanagedType.I1)] bool pinned);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern nint il2cpp_gchandle_new_weakref(void* obj,
            [MarshalAs(UnmanagedType.I1)] bool track_resurrection);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_gchandle_get_target(nint gchandle);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_gchandle_free(uint gchandle);

// #if !UNITY_WEBGL
//
//     [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
//     public static extern void* il2cpp_unity_liveness_calculation_begin(void* filter, int max_object_count,
//         void* callback, void* userdata, void* onWorldStarted, void* onWorldStopped);
//
//
//     [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
//     public static extern void il2cpp_unity_liveness_calculation_end(void* state);
//
//     [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
//     public static extern void il2cpp_unity_liveness_calculation_from_root(void* root, void* state);
//
//     [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
//     public static extern void il2cpp_unity_liveness_calculation_from_statics(void* state);
// #endif

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppTypeHandle il2cpp_method_get_return_type(Il2CppMethodInfoHandle method);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_method_get_declaring_type(void* method);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_method_get_name(void* method);


        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern void* il2cpp_method_get_from_reflection(void* method);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_method_get_object(void* method, void* refclass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_method_is_generic(void* method);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_method_is_inflated(void* method);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_method_is_instance(void* method);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint il2cpp_method_get_param_count(void* method);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_method_get_param(void* method, uint index);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_method_get_class(void* method);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_method_has_attribute(void* method, void* attr_class);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint il2cpp_method_get_flags(void* method, ref uint iflags);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint il2cpp_method_get_token(void* method);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_method_get_param_name(void* method, uint index);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_profiler_install(void* prof, void* shutdown_callback);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_profiler_set_events(int events);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_profiler_install_enter_leave(void* enter, void* fleave);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_profiler_install_allocation(void* callback);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_profiler_install_gc(void* callback, void* heap_resize_callback);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_profiler_install_fileio(void* callback);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_profiler_install_thread(void* start, void* end);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint il2cpp_property_get_flags(void* prop);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_property_get_get_method(void* prop);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_property_get_set_method(void* prop);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_property_get_name(void* prop);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_property_get_parent(void* prop);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_object_get_class(void* obj);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint il2cpp_object_get_size(void* obj);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_object_get_virtual_method(void* obj, void* method);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppObjectHandle il2cpp_object_new(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_object_unbox(Il2CppObjectHandle obj);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppObjectHandle il2cpp_value_box(Il2CppClassHandle klass, void* data);
#if !UNITY_WEBGL
        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_monitor_enter(Il2CppObjectHandle obj);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_monitor_try_enter(Il2CppObjectHandle obj, uint timeout);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_monitor_exit(Il2CppObjectHandle obj);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_monitor_pulse(Il2CppObjectHandle obj);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_monitor_pulse_all(Il2CppObjectHandle obj);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_monitor_wait(Il2CppObjectHandle obj);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_monitor_try_wait(Il2CppObjectHandle obj, uint timeout);
#endif
        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern object il2cpp_runtime_invoke(void* method, void* obj, void** param, out Exception exc);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        // param can be of Il2CppObject*
        public static extern object il2cpp_runtime_invoke_convert_args(void* method, void* obj, void** param,
            int paramCount, out Exception exc);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_runtime_class_init(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_runtime_object_init(Il2CppObjectHandle obj);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_runtime_object_init_exception(object obj, out Exception exc);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_runtime_unhandled_exception_policy_set(int value);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int il2cpp_string_length(Il2CppStringHandle str);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern ushort* il2cpp_string_chars(Il2CppStringHandle str);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppStringHandle il2cpp_string_new(byte* str);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppStringHandle il2cpp_string_new_len(ushort* str, uint length);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppStringHandle il2cpp_string_new_utf16(ushort* text, int len);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppStringHandle il2cpp_string_new_wrapper(byte* str);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppStringHandle il2cpp_string_intern(Il2CppStringHandle str);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppStringHandle il2cpp_string_is_interned(Il2CppStringHandle str);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_thread_current();

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_thread_attach(void* domain);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_thread_detach(void* thread);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void** il2cpp_thread_get_all_attached_threads(ref uint size);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_is_vm_thread(void* thread);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_current_thread_walk_frame_stack(void* func, void* user_data);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_thread_walk_frame_stack(void* thread, void* func, void* user_data);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_current_thread_get_top_frame(void* frame);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_thread_get_top_frame(void* thread, void* frame);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_current_thread_get_frame_at(int offset, void* frame);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_thread_get_frame_at(void* thread, int offset, void* frame);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int il2cpp_current_thread_get_stack_depth();

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int il2cpp_thread_get_stack_depth(void* thread);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppReflectionTypeHandle il2cpp_type_get_object(Il2CppTypeHandle type);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int il2cpp_type_get_type(Il2CppTypeHandle type);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppClassHandle il2cpp_type_get_class_or_element_class(Il2CppTypeHandle type);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_type_get_name(Il2CppTypeHandle type);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_type_is_byref(Il2CppTypeHandle type);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint il2cpp_type_get_attrs(Il2CppTypeHandle type);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_type_equals(Il2CppTypeHandle type, Il2CppTypeHandle otherType);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_type_get_assembly_qualified_name(Il2CppTypeHandle type);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_image_get_assembly(Il2CppImageHandle image);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_image_get_name(Il2CppImageHandle image);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_image_get_filename(Il2CppImageHandle image);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppMethodInfoHandle il2cpp_image_get_entry_point(Il2CppImageHandle image);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint il2cpp_image_get_class_count(Il2CppImageHandle image);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_image_get_class(Il2CppImageHandle image, uint index);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_capture_memory_snapshot();

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_free_captured_memory_snapshot(void* snapshot);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_set_find_plugin_callback(void* method);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_register_log_callback(void* method);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_debugger_set_agent_options(void* options);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_is_debugger_attached();

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_unity_install_unitytls_interface(void* unitytlsInterfaceStruct);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppCustomAttrInfoHandle il2cpp_custom_attrs_from_class(Il2CppClassHandle klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Il2CppCustomAttrInfoHandle il2cpp_custom_attrs_from_method(Il2CppMethodInfoHandle method);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_custom_attrs_get_attr(Il2CppCustomAttrInfoHandle ainfo,
            Il2CppClassHandle attr_klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool il2cpp_custom_attrs_has_attr(Il2CppCustomAttrInfoHandle ainfo,
            Il2CppClassHandle attr_klass);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void* il2cpp_custom_attrs_construct(Il2CppCustomAttrInfoHandle cinfo);

        [DllImport(AssemblyName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void il2cpp_custom_attrs_free(Il2CppCustomAttrInfoHandle ainfo);

        public static T* Alloc<T>(uint count = 1) where T : unmanaged {
            return (T*) il2cpp_alloc(count * (uint) sizeof(T));
        }
        public static T* Alloc<T>(int count = 1) where T : unmanaged {
            return (T*) il2cpp_alloc((uint)(count * sizeof(T)));
        }
    }
}