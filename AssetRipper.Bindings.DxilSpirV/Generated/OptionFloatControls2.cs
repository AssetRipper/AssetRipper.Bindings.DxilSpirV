namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionFloatControls2
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte Supported;
}
