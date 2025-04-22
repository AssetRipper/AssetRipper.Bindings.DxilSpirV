namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionRasterizerSampleCount
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("unsigned int")]
    public uint SampleCount;

    [NativeTypeName("dxil_spv_bool")]
    public byte SpecConstant;
}
