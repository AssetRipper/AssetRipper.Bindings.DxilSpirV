namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_rasterizer_sample_count
{
    public dxil_spv_option_base @base;

    [NativeTypeName("unsigned int")]
    public uint sample_count;

    [NativeTypeName("dxil_spv_bool")]
    public byte spec_constant;
}
