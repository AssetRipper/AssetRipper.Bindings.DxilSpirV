namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionSsboAddressingBehavior
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte SsboWraps32bitOffsetBeforeRobustness;

    [NativeTypeName("dxil_spv_bool")]
    public byte RawAccessChainWraps32bitOffsetBeforeRobustness;
}
