namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionComputeShaderDerivatives
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte SupportsNv;

    [NativeTypeName("dxil_spv_bool")]
    public byte SupportsKhr;
}
