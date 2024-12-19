namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_denorm_preserve_support
{
    public dxil_spv_option_base @base;

    [NativeTypeName("dxil_spv_bool")]
    public byte supports_float16_denorm_preserve;

    [NativeTypeName("dxil_spv_bool")]
    public byte supports_float64_denorm_preserve;
}
