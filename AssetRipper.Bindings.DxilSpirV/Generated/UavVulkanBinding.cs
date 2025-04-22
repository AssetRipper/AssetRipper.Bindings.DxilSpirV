namespace AssetRipper.Bindings.DxilSpirV;

public partial struct UavVulkanBinding
{
    [NativeTypeName("dxil_spv_vulkan_binding")]
    public VulkanBinding BufferBinding;

    [NativeTypeName("dxil_spv_vulkan_binding")]
    public VulkanBinding CounterBinding;

    [NativeTypeName("dxil_spv_vulkan_binding")]
    public VulkanBinding OffsetBinding;
}
