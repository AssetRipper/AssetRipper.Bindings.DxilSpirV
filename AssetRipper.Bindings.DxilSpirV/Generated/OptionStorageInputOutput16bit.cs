namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionStorageInputOutput16bit
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte Supported;
}
