namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionQuadControlReconvergence
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte SupportsQuadControl;

    [NativeTypeName("dxil_spv_bool")]
    public byte SupportsMaximalReconvergence;

    [NativeTypeName("dxil_spv_bool")]
    public byte ForceMaximalReconvergence;
}
