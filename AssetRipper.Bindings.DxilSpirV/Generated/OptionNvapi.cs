namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionNvapi
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte Enabled;

    [NativeTypeName("unsigned int")]
    public uint RegisterIndex;

    [NativeTypeName("unsigned int")]
    public uint RegisterSpace;
}
