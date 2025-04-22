namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionArithmeticRelaxedPrecision
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte Enabled;
}
