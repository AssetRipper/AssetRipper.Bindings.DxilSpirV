namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionSampleGradOptimizationControl
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte Enabled;

    [NativeTypeName("dxil_spv_bool")]
    public byte AssumeUniformScale;
}
