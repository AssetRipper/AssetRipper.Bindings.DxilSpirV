namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_uav_d3d_binding
{
    public dxil_spv_d3d_binding d3d_binding;

    [NativeTypeName("dxil_spv_bool")]
    public byte has_counter;
}
