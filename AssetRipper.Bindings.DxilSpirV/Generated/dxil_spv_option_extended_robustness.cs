namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_extended_robustness
{
    public dxil_spv_option_base @base;

    [NativeTypeName("dxil_spv_bool")]
    public byte robust_group_shared;

    [NativeTypeName("dxil_spv_bool")]
    public byte robust_alloca;

    [NativeTypeName("dxil_spv_bool")]
    public byte robust_constant_lut;
}
