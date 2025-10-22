using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.DxilSpirV;

public static unsafe partial class NativeMethods
{
    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_get_version", ExactSpelling = true)]
    public static extern void GetVersion([NativeTypeName("unsigned int *")] uint* major, [NativeTypeName("unsigned int *")] uint* minor, [NativeTypeName("unsigned int *")] uint* patch);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_parse_dxil_blob", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ParseDxilBlob([NativeTypeName("const void *")] void* Data, [NativeTypeName("size_t")] nuint Size, [NativeTypeName("dxil_spv_parsed_blob *")] ParsedBlob** blob);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_parse_reflection_dxil_blob", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ParseReflectionDxilBlob([NativeTypeName("const void *")] void* Data, [NativeTypeName("size_t")] nuint Size, [NativeTypeName("dxil_spv_parsed_blob *")] ParsedBlob** blob);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_parse_dxil", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ParseDxil([NativeTypeName("const void *")] void* Data, [NativeTypeName("size_t")] nuint Size, [NativeTypeName("dxil_spv_parsed_blob *")] ParsedBlob** blob);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_parsed_blob_dump_llvm_ir", ExactSpelling = true)]
    public static extern void ParsedBlobDumpLlvmIr([NativeTypeName("dxil_spv_parsed_blob")] ParsedBlob* blob);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_parsed_blob_get_disassembled_ir", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ParsedBlobGetDisassembledIr([NativeTypeName("dxil_spv_parsed_blob")] ParsedBlob* blob, [NativeTypeName("const char **")] sbyte** str);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_parsed_blob_get_raw_ir", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ParsedBlobGetRawIr([NativeTypeName("dxil_spv_parsed_blob")] ParsedBlob* blob, [NativeTypeName("const void **")] void** Data, [NativeTypeName("size_t *")] nuint* Size);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_parsed_blob_get_shader_stage", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_shader_stage")]
    public static extern ShaderStage ParsedBlobGetShaderStage([NativeTypeName("dxil_spv_parsed_blob")] ParsedBlob* blob);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_parsed_blob_get_shader_stage_for_entry", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_shader_stage")]
    public static extern ShaderStage ParsedBlobGetShaderStageForEntry([NativeTypeName("dxil_spv_parsed_blob")] ParsedBlob* blob, [NativeTypeName("const char *")] sbyte* entry);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_parsed_blob_get_entry_index_by_name", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ParsedBlobGetEntryIndexByName([NativeTypeName("dxil_spv_parsed_blob")] ParsedBlob* blob, [NativeTypeName("const char *")] sbyte* entry, [NativeTypeName("unsigned int *")] uint* index);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_parsed_blob_get_num_entry_points", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ParsedBlobGetNumEntryPoints([NativeTypeName("dxil_spv_parsed_blob")] ParsedBlob* blob, [NativeTypeName("unsigned int *")] uint* count);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_parsed_blob_get_entry_point_name", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ParsedBlobGetEntryPointName([NativeTypeName("dxil_spv_parsed_blob")] ParsedBlob* blob, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("const char **")] sbyte** mangled_entry);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_parsed_blob_get_entry_point_demangled_name", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ParsedBlobGetEntryPointDemangledName([NativeTypeName("dxil_spv_parsed_blob")] ParsedBlob* blob, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("const char **")] sbyte** demangled_entry);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_parsed_blob_scan_resources", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ParsedBlobScanResources([NativeTypeName("dxil_spv_parsed_blob")] ParsedBlob* blob, [NativeTypeName("dxil_spv_srv_remapper_cb")] delegate* unmanaged[Cdecl]<void*, D3dBinding*, SrvVulkanBinding*, byte> srv_remapper, [NativeTypeName("dxil_spv_sampler_remapper_cb")] delegate* unmanaged[Cdecl]<void*, D3dBinding*, VulkanBinding*, byte> sampler_remapper, [NativeTypeName("dxil_spv_cbv_remapper_cb")] delegate* unmanaged[Cdecl]<void*, D3dBinding*, CbvVulkanBinding*, byte> cbv_remapper, [NativeTypeName("dxil_spv_uav_remapper_cb")] delegate* unmanaged[Cdecl]<void*, UavD3dBinding*, UavVulkanBinding*, byte> uav_remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_parsed_blob_get_num_rdat_subobjects", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ParsedBlobGetNumRdatSubobjects([NativeTypeName("dxil_spv_parsed_blob")] ParsedBlob* blob);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_parsed_blob_get_rdat_subobject", ExactSpelling = true)]
    public static extern void ParsedBlobGetRdatSubobject([NativeTypeName("dxil_spv_parsed_blob")] ParsedBlob* blob, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("dxil_spv_rdat_subobject *")] RdatSubobject* subobject);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_parsed_blob_free", ExactSpelling = true)]
    public static extern void ParsedBlobFree([NativeTypeName("dxil_spv_parsed_blob")] ParsedBlob* blob);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_set_thread_log_callback", ExactSpelling = true)]
    public static extern void SetThreadLogCallback([NativeTypeName("dxil_spv_log_cb")] delegate* unmanaged[Cdecl]<void*, LogLevel, sbyte*, void> callback, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_create_converter", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result CreateConverter([NativeTypeName("dxil_spv_parsed_blob")] ParsedBlob* blob, [NativeTypeName("dxil_spv_converter *")] Converter** converter);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_create_converter_with_reflection", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result CreateConverterWithReflection([NativeTypeName("dxil_spv_parsed_blob")] ParsedBlob* blob, [NativeTypeName("dxil_spv_parsed_blob")] ParsedBlob* reflection_blob, [NativeTypeName("dxil_spv_converter *")] Converter** converter);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_free", ExactSpelling = true)]
    public static extern void ConverterFree([NativeTypeName("dxil_spv_converter")] Converter* converter);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_set_entry_point", ExactSpelling = true)]
    public static extern void ConverterSetEntryPoint([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("const char *")] sbyte* entry_point);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_set_stage_input_remapper", ExactSpelling = true)]
    public static extern void ConverterSetStageInputRemapper([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("dxil_spv_shader_stage_io_remapper_cb")] delegate* unmanaged[Cdecl]<void*, D3dShaderStageIo*, VulkanShaderStageIo*, byte> remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_set_stage_output_remapper", ExactSpelling = true)]
    public static extern void ConverterSetStageOutputRemapper([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("dxil_spv_shader_stage_io_remapper_cb")] delegate* unmanaged[Cdecl]<void*, D3dShaderStageIo*, VulkanShaderStageIo*, byte> remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_set_vertex_input_remapper", ExactSpelling = true)]
    public static extern void ConverterSetVertexInputRemapper([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("dxil_spv_vertex_input_remapper_cb")] delegate* unmanaged[Cdecl]<void*, D3dVertexInput*, VulkanVertexInput*, byte> remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_set_stream_output_remapper", ExactSpelling = true)]
    public static extern void ConverterSetStreamOutputRemapper([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("dxil_spv_stream_output_remapper_cb")] delegate* unmanaged[Cdecl]<void*, D3dStreamOutput*, VulkanStreamOutput*, byte> remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_set_srv_remapper", ExactSpelling = true)]
    public static extern void ConverterSetSrvRemapper([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("dxil_spv_srv_remapper_cb")] delegate* unmanaged[Cdecl]<void*, D3dBinding*, SrvVulkanBinding*, byte> remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_set_sampler_remapper", ExactSpelling = true)]
    public static extern void ConverterSetSamplerRemapper([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("dxil_spv_sampler_remapper_cb")] delegate* unmanaged[Cdecl]<void*, D3dBinding*, VulkanBinding*, byte> remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_set_root_constant_word_count", ExactSpelling = true)]
    public static extern void ConverterSetRootConstantWordCount([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("unsigned int")] uint num_words);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_set_root_descriptor_count", ExactSpelling = true)]
    public static extern void ConverterSetRootDescriptorCount([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("unsigned int")] uint count);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_set_uav_remapper", ExactSpelling = true)]
    public static extern void ConverterSetUavRemapper([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("dxil_spv_uav_remapper_cb")] delegate* unmanaged[Cdecl]<void*, UavD3dBinding*, UavVulkanBinding*, byte> remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_set_cbv_remapper", ExactSpelling = true)]
    public static extern void ConverterSetCbvRemapper([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("dxil_spv_cbv_remapper_cb")] delegate* unmanaged[Cdecl]<void*, D3dBinding*, CbvVulkanBinding*, byte> remapper, void* userdata);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_add_local_root_constants", ExactSpelling = true)]
    public static extern void ConverterAddLocalRootConstants([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("unsigned int")] uint RegisterSpace, [NativeTypeName("unsigned int")] uint RegisterIndex, [NativeTypeName("unsigned int")] uint num_words);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_add_local_root_descriptor", ExactSpelling = true)]
    public static extern void ConverterAddLocalRootDescriptor([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("dxil_spv_resource_class")] ResourceClass resource_class, [NativeTypeName("unsigned int")] uint RegisterSpace, [NativeTypeName("unsigned int")] uint RegisterIndex);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_add_local_root_descriptor_table", ExactSpelling = true)]
    public static extern void ConverterAddLocalRootDescriptorTable([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("dxil_spv_resource_class")] ResourceClass resource_class, [NativeTypeName("unsigned int")] uint RegisterSpace, [NativeTypeName("unsigned int")] uint RegisterIndex, [NativeTypeName("unsigned int")] uint num_descriptors_in_range, [NativeTypeName("unsigned int")] uint offset_in_heap);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_begin_local_root_descriptor_table", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ConverterBeginLocalRootDescriptorTable([NativeTypeName("dxil_spv_converter")] Converter* converter);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_end_local_root_descriptor_table", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ConverterEndLocalRootDescriptorTable([NativeTypeName("dxil_spv_converter")] Converter* converter);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_add_root_parameter_mapping", ExactSpelling = true)]
    public static extern void ConverterAddRootParameterMapping([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("unsigned int")] uint root_parameter_index, [NativeTypeName("unsigned int")] uint Offset);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_add_root_descriptor_mapping", ExactSpelling = true)]
    public static extern void ConverterAddRootDescriptorMapping([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("unsigned int")] uint root_parameter_index, [NativeTypeName("unsigned int")] uint DescSet, [NativeTypeName("unsigned int")] uint Binding);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_add_non_semantic_debug_info", ExactSpelling = true)]
    public static extern void ConverterAddNonSemanticDebugInfo([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("const char *")] sbyte* tag, [NativeTypeName("const void *")] void* Data, [NativeTypeName("size_t")] nuint Size);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_set_patch_location_offset", ExactSpelling = true)]
    public static extern void ConverterSetPatchLocationOffset([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("unsigned int")] uint Offset);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_run", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ConverterRun([NativeTypeName("dxil_spv_converter")] Converter* converter);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_get_compiled_spirv", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ConverterGetCompiledSpirv([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("dxil_spv_compiled_spirv *")] CompiledSpirv* compiled);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_get_compiled_entry_point", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ConverterGetCompiledEntryPoint([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("const char **")] sbyte** entry_point);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_supports_option", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_bool")]
    public static extern byte ConverterSupportsOption([NativeTypeName("dxil_spv_option")] Option option);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_add_option", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ConverterAddOption([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("const dxil_spv_option_base *")] OptionBase* option);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_uses_subgroup_size", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_bool")]
    public static extern byte ConverterUsesSubgroupSize([NativeTypeName("dxil_spv_converter")] Converter* converter);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_get_compute_workgroup_dimensions", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ConverterGetComputeWorkgroupDimensions([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("unsigned int *")] uint* x, [NativeTypeName("unsigned int *")] uint* y, [NativeTypeName("unsigned int *")] uint* z);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_get_compute_required_wave_size", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ConverterGetComputeRequiredWaveSize([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("unsigned int *")] uint* wave_size);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_get_compute_wave_size_range", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ConverterGetComputeWaveSizeRange([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("unsigned int *")] uint* wave_size, [NativeTypeName("unsigned int *")] uint* wave_size_max, [NativeTypeName("unsigned int *")] uint* wave_size_preferred);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_get_compute_heuristic_max_wave_size", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ConverterGetComputeHeuristicMaxWaveSize([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("unsigned int *")] uint* wave_size);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_get_compute_heuristic_min_wave_size", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ConverterGetComputeHeuristicMinWaveSize([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("unsigned int *")] uint* wave_size);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_get_patch_vertex_count", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ConverterGetPatchVertexCount([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("unsigned int *")] uint* patch_vertices);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_get_patch_location_offset", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ConverterGetPatchLocationOffset([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("unsigned int *")] uint* patch_location_offset);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_uses_shader_feature", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_bool")]
    public static extern byte ConverterUsesShaderFeature([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("dxil_spv_shader_feature")] ShaderFeature feature);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_get_analysis_warnings", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ConverterGetAnalysisWarnings([NativeTypeName("dxil_spv_converter")] Converter* converter);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_converter_set_meta_descriptor", ExactSpelling = true)]
    [return: NativeTypeName("dxil_spv_result")]
    public static extern Result ConverterSetMetaDescriptor([NativeTypeName("dxil_spv_converter")] Converter* converter, [NativeTypeName("dxil_spv_meta_descriptor")] MetaDescriptor meta, [NativeTypeName("dxil_spv_meta_descriptor_kind")] MetaDescriptorKind Kind, [NativeTypeName("unsigned int")] uint DescSet, [NativeTypeName("unsigned int")] uint binding_or_push_index);

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_begin_thread_allocator_context", ExactSpelling = true)]
    public static extern void BeginThreadAllocatorContext();

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_end_thread_allocator_context", ExactSpelling = true)]
    public static extern void EndThreadAllocatorContext();

    [DllImport("dxil-spirv-c-shared", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dxil_spv_reset_thread_allocator_context", ExactSpelling = true)]
    public static extern void ResetThreadAllocatorContext();

    [NativeTypeName("#define DXIL_SPV_API_VERSION_MAJOR 2")]
    public const int ApiVersionMajor = 2;

    [NativeTypeName("#define DXIL_SPV_API_VERSION_MINOR 60")]
    public const int ApiVersionMinor = 60;

    [NativeTypeName("#define DXIL_SPV_API_VERSION_PATCH 0")]
    public const int ApiVersionPatch = 0;

    [NativeTypeName("#define DXIL_SPV_DESCRIPTOR_QA_INTERFACE_VERSION 2")]
    public const int DescriptorQaInterfaceVersion = 2;

    [NativeTypeName("#define DXIL_SPV_INSTRUCTION_INSTRUMENTATION_INTERFACE_VERSION 2")]
    public const int InstructionInstrumentationInterfaceVersion = 2;
}
