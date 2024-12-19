namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_sample_grad_optimization_control
{
    public dxil_spv_option_base @base;

    [NativeTypeName("dxil_spv_bool")]
    public byte enabled;

    [NativeTypeName("dxil_spv_bool")]
    public byte assume_uniform_scale;
}
