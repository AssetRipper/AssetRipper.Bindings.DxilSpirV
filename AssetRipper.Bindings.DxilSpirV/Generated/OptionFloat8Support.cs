namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionFloat8Support
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte WmmaFp8;

    [NativeTypeName("dxil_spv_bool")]
    public byte NvCooperativeMatrix2Conversions;
}
