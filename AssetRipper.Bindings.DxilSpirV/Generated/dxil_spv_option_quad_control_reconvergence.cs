namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_quad_control_reconvergence
{
    public dxil_spv_option_base @base;

    [NativeTypeName("dxil_spv_bool")]
    public byte supports_quad_control;

    [NativeTypeName("dxil_spv_bool")]
    public byte supports_maximal_reconvergence;

    [NativeTypeName("dxil_spv_bool")]
    public byte force_maximal_reconvergence;
}
