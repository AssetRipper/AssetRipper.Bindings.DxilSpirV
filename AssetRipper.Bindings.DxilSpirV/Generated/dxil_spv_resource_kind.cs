namespace AssetRipper.Bindings.DxilSpirV;

public enum dxil_spv_resource_kind
{
    DXIL_SPV_RESOURCE_KIND_INVALID = 0,
    DXIL_SPV_RESOURCE_KIND_TEXTURE_1D = 1,
    DXIL_SPV_RESOURCE_KIND_TEXTURE_2D = 2,
    DXIL_SPV_RESOURCE_KIND_TEXTURE_2DMS = 3,
    DXIL_SPV_RESOURCE_KIND_TEXTURE_3D = 4,
    DXIL_SPV_RESOURCE_KIND_TEXTURE_CUBE = 5,
    DXIL_SPV_RESOURCE_KIND_TEXTURE_1D_ARRAY = 6,
    DXIL_SPV_RESOURCE_KIND_TEXTURE_2D_ARRAY = 7,
    DXIL_SPV_RESOURCE_KIND_TEXTURE_2D_MS_ARRAY = 8,
    DXIL_SPV_RESOURCE_KIND_TEXTURE_CUBE_ARRAY = 9,
    DXIL_SPV_RESOURCE_KIND_TYPED_BUFFER = 10,
    DXIL_SPV_RESOURCE_KIND_RAW_BUFFER = 11,
    DXIL_SPV_RESOURCE_KIND_STRUCTURED_BUFFER = 12,
    DXIL_SPV_RESOURCE_KIND_CONSTANT_BUFFER = 13,
    DXIL_SPV_RESOURCE_KIND_SAMPLER = 14,
    DXIL_SPV_RESOURCE_KIND_TBUFFER = 15,
    DXIL_SPV_RESOURCE_KIND_RT_ACCELERATION_STRUCTURE = 16,
    DXIL_SPV_RESOURCE_KIND_FEEDBACK_TEXTURE_2D = 17,
    DXIL_SPV_RESOURCE_KIND_FEEDBACK_TEXTURE_2D_ARRAY = 18,
    DXIL_SPV_RESOURCE_KIND_INT_MAX = 0x7fffffff,
}