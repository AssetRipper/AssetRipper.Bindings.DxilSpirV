namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionScalarBlockLayout
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte Supported;

    [NativeTypeName("dxil_spv_bool")]
    public byte SupportsPerComponentRobustness;
}
