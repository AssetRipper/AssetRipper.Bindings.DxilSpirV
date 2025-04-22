namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionSsboAlignment
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("unsigned int")]
    public uint Alignment;
}
