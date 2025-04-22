namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionSbtDescriptorSizeLog2
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("unsigned int")]
    public uint SizeLog2SrvUavCbv;

    [NativeTypeName("unsigned int")]
    public uint SizeLog2Sampler;
}
