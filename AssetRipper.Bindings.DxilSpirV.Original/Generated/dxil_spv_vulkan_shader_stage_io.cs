namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_vulkan_shader_stage_io
{
    [NativeTypeName("unsigned int")]
    public uint location;

    [NativeTypeName("unsigned int")]
    public uint component;

    [NativeTypeName("unsigned int")]
    public uint flags;
}
