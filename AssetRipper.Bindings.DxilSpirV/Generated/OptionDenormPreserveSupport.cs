namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionDenormPreserveSupport
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte SupportsFloat16DenormPreserve;

    [NativeTypeName("dxil_spv_bool")]
    public byte SupportsFloat64DenormPreserve;
}
