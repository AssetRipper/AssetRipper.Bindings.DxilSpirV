namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_vulkan_binding
{
    [NativeTypeName("unsigned int")]
    public uint set;

    [NativeTypeName("unsigned int")]
    public uint binding;

    [NativeTypeName("unsigned int")]
    public uint root_constant_index;

    [NativeTypeName("__AnonymousRecord_dxil_spirv_c_L292_C2")]
    public _bindless_e__Struct bindless;

    public dxil_spv_vulkan_descriptor_type descriptor_type;

    public partial struct _bindless_e__Struct
    {
        [NativeTypeName("unsigned int")]
        public uint heap_root_offset;

        [NativeTypeName("dxil_spv_bool")]
        public byte use_heap;
    }
}
