namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_float8_support
{
    public dxil_spv_option_base @base;

    [NativeTypeName("dxil_spv_bool")]
    public byte wmma_fp8;

    [NativeTypeName("dxil_spv_bool")]
    public byte nv_cooperative_matrix2_conversions;
}
