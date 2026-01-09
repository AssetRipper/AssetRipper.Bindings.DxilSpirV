namespace AssetRipper.Bindings.DxilSpirV;

public enum VulkanDescriptorType
{
    Identity = 0,
    Ssbo = 1,
    TexelBuffer = 2,
    BufferDeviceAddress = 3,
    Ubo = 4,
    InputAttachment = 5,
    IntMax = 0x7fffffff,
}
