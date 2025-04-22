namespace AssetRipper.Bindings.DxilSpirV;

public partial struct SrvVulkanBinding
{
    [NativeTypeName("dxil_spv_vulkan_binding")]
    public VulkanBinding BufferBinding;

    [NativeTypeName("dxil_spv_vulkan_binding")]
    public VulkanBinding OffsetBinding;
}
