namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionConservativeSsboVectorization
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte Enabled;
}
