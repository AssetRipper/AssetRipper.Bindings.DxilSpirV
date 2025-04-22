namespace AssetRipper.Bindings.DxilSpirV;

public partial struct UavD3dBinding
{
    [NativeTypeName("dxil_spv_d3d_binding")]
    public D3dBinding D3dBinding;

    [NativeTypeName("dxil_spv_bool")]
    public byte HasCounter;
}
