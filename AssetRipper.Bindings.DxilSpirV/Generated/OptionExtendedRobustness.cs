namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionExtendedRobustness
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte RobustGroupShared;

    [NativeTypeName("dxil_spv_bool")]
    public byte RobustAlloca;

    [NativeTypeName("dxil_spv_bool")]
    public byte RobustConstantLut;
}
