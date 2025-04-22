using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.DxilSpirV;

public static unsafe partial class NativeMethods
{
    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_get_version([NativeTypeName("unsigned int *")] uint* major, [NativeTypeName("unsigned int *")] uint* minor, [NativeTypeName("unsigned int *")] uint* patch);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_parse_dxil_blob([NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint size, [NativeTypeName("dxil_spv_parsed_blob *")] dxil_spv_parsed_blob_s** blob);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_parse_reflection_dxil_blob([NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint size, [NativeTypeName("dxil_spv_parsed_blob *")] dxil_spv_parsed_blob_s** blob);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_parse_dxil([NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint size, [NativeTypeName("dxil_spv_parsed_blob *")] dxil_spv_parsed_blob_s** blob);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_parsed_blob_dump_llvm_ir([NativeTypeName("dxil_spv_parsed_blob")] dxil_spv_parsed_blob_s* blob);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_parsed_blob_get_disassembled_ir([NativeTypeName("dxil_spv_parsed_blob")] dxil_spv_parsed_blob_s* blob, [NativeTypeName("const char **")] sbyte** str);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_parsed_blob_get_raw_ir([NativeTypeName("dxil_spv_parsed_blob")] dxil_spv_parsed_blob_s* blob, [NativeTypeName("const void **")] void** data, [NativeTypeName("size_t *")] nuint* size);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_shader_stage dxil_spv_parsed_blob_get_shader_stage([NativeTypeName("dxil_spv_parsed_blob")] dxil_spv_parsed_blob_s* blob);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_shader_stage dxil_spv_parsed_blob_get_shader_stage_for_entry([NativeTypeName("dxil_spv_parsed_blob")] dxil_spv_parsed_blob_s* blob, [NativeTypeName("const char *")] sbyte* entry);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_parsed_blob_get_entry_index_by_name([NativeTypeName("dxil_spv_parsed_blob")] dxil_spv_parsed_blob_s* blob, [NativeTypeName("const char *")] sbyte* entry, [NativeTypeName("unsigned int *")] uint* index);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_parsed_blob_get_num_entry_points([NativeTypeName("dxil_spv_parsed_blob")] dxil_spv_parsed_blob_s* blob, [NativeTypeName("unsigned int *")] uint* count);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_parsed_blob_get_entry_point_name([NativeTypeName("dxil_spv_parsed_blob")] dxil_spv_parsed_blob_s* blob, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("const char **")] sbyte** mangled_entry);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_parsed_blob_get_entry_point_demangled_name([NativeTypeName("dxil_spv_parsed_blob")] dxil_spv_parsed_blob_s* blob, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("const char **")] sbyte** demangled_entry);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_parsed_blob_scan_resources([NativeTypeName("dxil_spv_parsed_blob")] dxil_spv_parsed_blob_s* blob, [NativeTypeName("dxil_spv_srv_remapper_cb")] delegate* unmanaged[Cdecl]<void*, dxil_spv_d3d_binding*, dxil_spv_srv_vulkan_binding*, byte> srv_remapper, [NativeTypeName("dxil_spv_sampler_remapper_cb")] delegate* unmanaged[Cdecl]<void*, dxil_spv_d3d_binding*, dxil_spv_vulkan_binding*, byte> sampler_remapper, [NativeTypeName("dxil_spv_cbv_remapper_cb")] delegate* unmanaged[Cdecl]<void*, dxil_spv_d3d_binding*, dxil_spv_cbv_vulkan_binding*, byte> cbv_remapper, [NativeTypeName("dxil_spv_uav_remapper_cb")] delegate* unmanaged[Cdecl]<void*, dxil_spv_uav_d3d_binding*, dxil_spv_uav_vulkan_binding*, byte> uav_remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint dxil_spv_parsed_blob_get_num_rdat_subobjects([NativeTypeName("dxil_spv_parsed_blob")] dxil_spv_parsed_blob_s* blob);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_parsed_blob_get_rdat_subobject([NativeTypeName("dxil_spv_parsed_blob")] dxil_spv_parsed_blob_s* blob, [NativeTypeName("unsigned int")] uint index, dxil_spv_rdat_subobject* subobject);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_parsed_blob_free([NativeTypeName("dxil_spv_parsed_blob")] dxil_spv_parsed_blob_s* blob);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_set_thread_log_callback([NativeTypeName("dxil_spv_log_cb")] delegate* unmanaged[Cdecl]<void*, dxil_spv_log_level, sbyte*, void> callback, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_create_converter([NativeTypeName("dxil_spv_parsed_blob")] dxil_spv_parsed_blob_s* blob, [NativeTypeName("dxil_spv_converter *")] dxil_spv_converter_s** converter);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_create_converter_with_reflection([NativeTypeName("dxil_spv_parsed_blob")] dxil_spv_parsed_blob_s* blob, [NativeTypeName("dxil_spv_parsed_blob")] dxil_spv_parsed_blob_s* reflection_blob, [NativeTypeName("dxil_spv_converter *")] dxil_spv_converter_s** converter);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_converter_free([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_converter_set_entry_point([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("const char *")] sbyte* entry_point);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_converter_set_stage_input_remapper([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("dxil_spv_shader_stage_io_remapper_cb")] delegate* unmanaged[Cdecl]<void*, dxil_spv_d3d_shader_stage_io*, dxil_spv_vulkan_shader_stage_io*, byte> remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_converter_set_stage_output_remapper([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("dxil_spv_shader_stage_io_remapper_cb")] delegate* unmanaged[Cdecl]<void*, dxil_spv_d3d_shader_stage_io*, dxil_spv_vulkan_shader_stage_io*, byte> remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_converter_set_vertex_input_remapper([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("dxil_spv_vertex_input_remapper_cb")] delegate* unmanaged[Cdecl]<void*, dxil_spv_d3d_vertex_input*, dxil_spv_vulkan_vertex_input*, byte> remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_converter_set_stream_output_remapper([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("dxil_spv_stream_output_remapper_cb")] delegate* unmanaged[Cdecl]<void*, dxil_spv_d3d_stream_output*, dxil_spv_vulkan_stream_output*, byte> remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_converter_set_srv_remapper([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("dxil_spv_srv_remapper_cb")] delegate* unmanaged[Cdecl]<void*, dxil_spv_d3d_binding*, dxil_spv_srv_vulkan_binding*, byte> remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_converter_set_sampler_remapper([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("dxil_spv_sampler_remapper_cb")] delegate* unmanaged[Cdecl]<void*, dxil_spv_d3d_binding*, dxil_spv_vulkan_binding*, byte> remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_converter_set_root_constant_word_count([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("unsigned int")] uint num_words);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_converter_set_root_descriptor_count([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("unsigned int")] uint count);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_converter_set_uav_remapper([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("dxil_spv_uav_remapper_cb")] delegate* unmanaged[Cdecl]<void*, dxil_spv_uav_d3d_binding*, dxil_spv_uav_vulkan_binding*, byte> remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_converter_set_cbv_remapper([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("dxil_spv_cbv_remapper_cb")] delegate* unmanaged[Cdecl]<void*, dxil_spv_d3d_binding*, dxil_spv_cbv_vulkan_binding*, byte> remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_converter_add_local_root_constants([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("unsigned int")] uint register_space, [NativeTypeName("unsigned int")] uint register_index, [NativeTypeName("unsigned int")] uint num_words);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_converter_add_local_root_descriptor([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, dxil_spv_resource_class resource_class, [NativeTypeName("unsigned int")] uint register_space, [NativeTypeName("unsigned int")] uint register_index);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_converter_add_local_root_descriptor_table([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, dxil_spv_resource_class resource_class, [NativeTypeName("unsigned int")] uint register_space, [NativeTypeName("unsigned int")] uint register_index, [NativeTypeName("unsigned int")] uint num_descriptors_in_range, [NativeTypeName("unsigned int")] uint offset_in_heap);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_converter_begin_local_root_descriptor_table([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_converter_end_local_root_descriptor_table([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_converter_run([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_converter_get_compiled_spirv([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, dxil_spv_compiled_spirv* compiled);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_converter_get_compiled_entry_point([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("const char **")] sbyte** entry_point);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_bool")]
    public static extern byte dxil_spv_converter_supports_option(dxil_spv_option option);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_converter_add_option([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("const dxil_spv_option_base *")] dxil_spv_option_base* option);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_bool")]
    public static extern byte dxil_spv_converter_uses_subgroup_size([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_converter_get_compute_workgroup_dimensions([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("unsigned int *")] uint* x, [NativeTypeName("unsigned int *")] uint* y, [NativeTypeName("unsigned int *")] uint* z);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_converter_get_compute_required_wave_size([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("unsigned int *")] uint* wave_size);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_converter_get_compute_wave_size_range([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("unsigned int *")] uint* wave_size, [NativeTypeName("unsigned int *")] uint* wave_size_max, [NativeTypeName("unsigned int *")] uint* wave_size_preferred);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_converter_get_compute_heuristic_max_wave_size([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("unsigned int *")] uint* wave_size);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern dxil_spv_result dxil_spv_converter_get_patch_vertex_count([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, [NativeTypeName("unsigned int *")] uint* patch_vertices);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_bool")]
    public static extern byte dxil_spv_converter_uses_shader_feature([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter, dxil_spv_shader_feature feature);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* dxil_spv_converter_get_analysis_warnings([NativeTypeName("dxil_spv_converter")] dxil_spv_converter_s* converter);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_begin_thread_allocator_context();

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_end_thread_allocator_context();

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void dxil_spv_reset_thread_allocator_context();

    [NativeTypeName("#define DXIL_SPV_API_VERSION_MAJOR 2")]
    public const int DXIL_SPV_API_VERSION_MAJOR = 2;

    [NativeTypeName("#define DXIL_SPV_API_VERSION_MINOR 50")]
    public const int DXIL_SPV_API_VERSION_MINOR = 50;

    [NativeTypeName("#define DXIL_SPV_API_VERSION_PATCH 0")]
    public const int DXIL_SPV_API_VERSION_PATCH = 0;

    [NativeTypeName("#define DXIL_SPV_DESCRIPTOR_QA_INTERFACE_VERSION 1")]
    public const int DXIL_SPV_DESCRIPTOR_QA_INTERFACE_VERSION = 1;

    [NativeTypeName("#define DXIL_SPV_INSTRUCTION_INSTRUMENTATION_INTERFACE_VERSION 2")]
    public const int DXIL_SPV_INSTRUCTION_INSTRUMENTATION_INTERFACE_VERSION = 2;

    [NativeTypeName("#define DXIL_SPV_TRUE ((dxil_spv_bool)1)")]
    public const byte DXIL_SPV_TRUE = ((byte)(1));

    [NativeTypeName("#define DXIL_SPV_FALSE ((dxil_spv_bool)0)")]
    public const byte DXIL_SPV_FALSE = ((byte)(0));
}
