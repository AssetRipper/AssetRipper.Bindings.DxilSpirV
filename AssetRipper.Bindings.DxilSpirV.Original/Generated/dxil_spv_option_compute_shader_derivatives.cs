namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_compute_shader_derivatives
{
    public dxil_spv_option_base @base;

    [NativeTypeName("dxil_spv_bool")]
    public byte supports_nv;

    [NativeTypeName("dxil_spv_bool")]
    public byte supports_khr;
}
