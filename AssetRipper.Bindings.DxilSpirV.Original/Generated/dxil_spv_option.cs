namespace AssetRipper.Bindings.DxilSpirV;

public enum dxil_spv_option
{
    DXIL_SPV_OPTION_INVALID = 0,
    DXIL_SPV_OPTION_SHADER_DEMOTE_TO_HELPER = 1,
    DXIL_SPV_OPTION_DUAL_SOURCE_BLENDING = 2,
    DXIL_SPV_OPTION_OUTPUT_SWIZZLE = 3,
    DXIL_SPV_OPTION_RASTERIZER_SAMPLE_COUNT = 4,
    DXIL_SPV_OPTION_ROOT_CONSTANT_INLINE_UNIFORM_BLOCK = 5,
    DXIL_SPV_OPTION_BINDLESS_CBV_SSBO_EMULATION = 6,
    DXIL_SPV_OPTION_PHYSICAL_STORAGE_BUFFER = 7,
    DXIL_SPV_OPTION_SBT_DESCRIPTOR_SIZE_LOG2 = 8,
    DXIL_SPV_OPTION_SSBO_ALIGNMENT = 9,
    DXIL_SPV_OPTION_TYPED_UAV_READ_WITHOUT_FORMAT = 10,
    DXIL_SPV_OPTION_SHADER_SOURCE_FILE = 11,
    DXIL_SPV_OPTION_BINDLESS_TYPED_BUFFER_OFFSETS = 12,
    DXIL_SPV_OPTION_BINDLESS_OFFSET_BUFFER_LAYOUT = 13,
    DXIL_SPV_OPTION_STORAGE_INPUT_OUTPUT_16BIT = 14,
    DXIL_SPV_OPTION_DESCRIPTOR_QA = 15,
    DXIL_SPV_OPTION_MIN_PRECISION_NATIVE_16BIT = 16,
    DXIL_SPV_OPTION_SHADER_I8_DOT = 17,
    DXIL_SPV_OPTION_SHADER_RAY_TRACING_PRIMITIVE_CULLING = 18,
    DXIL_SPV_OPTION_INVARIANT_POSITION = 19,
    DXIL_SPV_OPTION_SCALAR_BLOCK_LAYOUT = 20,
    DXIL_SPV_OPTION_BARYCENTRIC_KHR = 21,
    DXIL_SPV_OPTION_ROBUST_PHYSICAL_CBV_LOAD = 22,
    DXIL_SPV_OPTION_ARITHMETIC_RELAXED_PRECISION = 23,
    DXIL_SPV_OPTION_PHYSICAL_ADDRESS_DESCRIPTOR_INDEXING = 24,
    DXIL_SPV_OPTION_FORCE_SUBGROUP_SIZE = 25,
    DXIL_SPV_OPTION_DENORM_PRESERVE_SUPPORT = 26,
    DXIL_SPV_OPTION_STRICT_HELPER_LANE_WAVE_OPS = 27,
    DXIL_SPV_OPTION_SUBGROUP_PARTITIONED_NV = 28,
    DXIL_SPV_OPTION_DEAD_CODE_ELIMINATE = 29,
    DXIL_SPV_OPTION_PRECISE_CONTROL = 30,
    DXIL_SPV_OPTION_SAMPLE_GRAD_OPTIMIZATION_CONTROL = 31,
    DXIL_SPV_OPTION_OPACITY_MICROMAP = 32,
    DXIL_SPV_OPTION_BRANCH_CONTROL = 33,
    DXIL_SPV_OPTION_SUBGROUP_PROPERTIES = 34,
    DXIL_SPV_OPTION_DESCRIPTOR_HEAP_ROBUSTNESS = 35,
    DXIL_SPV_OPTION_COMPUTE_SHADER_DERIVATIVES_NV = 36,
    DXIL_SPV_OPTION_QUAD_CONTROL_RECONVERGENCE = 37,
    DXIL_SPV_OPTION_RAW_ACCESS_CHAINS_NV = 38,
    DXIL_SPV_OPTION_DRIVER_VERSION = 39,
    DXIL_SPV_OPTION_COMPUTE_SHADER_DERIVATIVES = 40,
    DXIL_SPV_OPTION_INSTRUCTION_INSTRUMENTATION = 41,
    DXIL_SPV_OPTION_SHADER_QUIRK = 42,
    DXIL_SPV_OPTION_EXTENDED_ROBUSTNESS = 43,
    DXIL_SPV_OPTION_MAX_TESS_FACTOR = 44,
    DXIL_SPV_OPTION_VULKAN_MEMORY_MODEL = 45,
    DXIL_SPV_OPTION_FLOAT8_SUPPORT = 46,
    DXIL_SPV_OPTION_NVAPI = 47,
    DXIL_SPV_OPTION_INT_MAX = 0x7fffffff,
}
