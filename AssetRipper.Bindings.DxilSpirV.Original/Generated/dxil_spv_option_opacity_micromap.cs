namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_opacity_micromap
{
    public dxil_spv_option_base @base;

    [NativeTypeName("dxil_spv_bool")]
    public byte enabled;

    [NativeTypeName("dxil_spv_bool")]
    public byte ray_query_force_omm_execution_mode;
}
