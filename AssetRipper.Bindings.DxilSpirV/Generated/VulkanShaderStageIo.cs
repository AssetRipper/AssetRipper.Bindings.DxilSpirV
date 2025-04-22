namespace AssetRipper.Bindings.DxilSpirV;

public partial struct VulkanShaderStageIo
{
    [NativeTypeName("unsigned int")]
    public uint Location;

    [NativeTypeName("unsigned int")]
    public uint Component;

    [NativeTypeName("unsigned int")]
    public uint Flags;
}
