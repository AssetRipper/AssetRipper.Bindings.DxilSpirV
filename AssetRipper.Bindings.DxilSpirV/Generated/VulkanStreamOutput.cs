namespace AssetRipper.Bindings.DxilSpirV;

public partial struct VulkanStreamOutput
{
    [NativeTypeName("unsigned int")]
    public uint Offset;

    [NativeTypeName("unsigned int")]
    public uint Stride;

    [NativeTypeName("unsigned int")]
    public uint BufferIndex;

    [NativeTypeName("dxil_spv_bool")]
    public byte Enable;
}
