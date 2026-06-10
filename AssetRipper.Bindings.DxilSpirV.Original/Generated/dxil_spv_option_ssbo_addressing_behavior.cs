namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_ssbo_addressing_behavior
{
    public dxil_spv_option_base @base;

    [NativeTypeName("dxil_spv_bool")]
    public byte ssbo_wraps_32bit_offset_before_robustness;

    [NativeTypeName("dxil_spv_bool")]
    public byte raw_access_chain_wraps_32bit_offset_before_robustness;
}
