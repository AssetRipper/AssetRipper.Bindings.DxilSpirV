namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_d3d_binding
{
    public dxil_spv_shader_stage stage;

    public dxil_spv_resource_kind kind;

    [NativeTypeName("unsigned int")]
    public uint resource_index;

    [NativeTypeName("unsigned int")]
    public uint register_space;

    [NativeTypeName("unsigned int")]
    public uint register_index;

    [NativeTypeName("unsigned int")]
    public uint range_size;

    [NativeTypeName("unsigned int")]
    public uint alignment;
}
