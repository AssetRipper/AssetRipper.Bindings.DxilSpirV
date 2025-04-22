namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_scalar_block_layout
{
    public dxil_spv_option_base @base;

    [NativeTypeName("dxil_spv_bool")]
    public byte supported;

    [NativeTypeName("dxil_spv_bool")]
    public byte supports_per_component_robustness;
}
