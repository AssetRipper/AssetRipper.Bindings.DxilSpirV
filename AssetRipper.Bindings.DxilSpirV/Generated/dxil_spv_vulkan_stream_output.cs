namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_vulkan_stream_output
{
    [NativeTypeName("unsigned int")]
    public uint offset;

    [NativeTypeName("unsigned int")]
    public uint stride;

    [NativeTypeName("unsigned int")]
    public uint buffer_index;

    [NativeTypeName("dxil_spv_bool")]
    public byte enable;
}
