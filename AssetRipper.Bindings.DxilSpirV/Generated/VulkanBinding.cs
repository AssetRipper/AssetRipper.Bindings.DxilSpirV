namespace AssetRipper.Bindings.DxilSpirV;

public partial struct VulkanBinding
{
    [NativeTypeName("unsigned int")]
    public uint Set;

    [NativeTypeName("unsigned int")]
    public uint Binding;

    [NativeTypeName("unsigned int")]
    public uint RootConstantIndex;

    [NativeTypeName("__AnonymousRecord_dxil_spirv_c_L294_C2")]
    public _Bindless_e__Struct Bindless;

    [NativeTypeName("dxil_spv_vulkan_descriptor_type")]
    public VulkanDescriptorType DescriptorType;

    public partial struct _Bindless_e__Struct
    {
        [NativeTypeName("unsigned int")]
        public uint HeapRootOffset;

        [NativeTypeName("dxil_spv_bool")]
        public byte UseHeap;
    }
}
