namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_descriptor_qa
{
    public dxil_spv_option_base @base;

    [NativeTypeName("dxil_spv_bool")]
    public byte enabled;

    [NativeTypeName("unsigned int")]
    public uint version;

    [NativeTypeName("unsigned int")]
    public uint global_desc_set;

    [NativeTypeName("unsigned int")]
    public uint global_binding;

    [NativeTypeName("unsigned int")]
    public uint heap_desc_set;

    [NativeTypeName("unsigned int")]
    public uint heap_binding;

    [NativeTypeName("unsigned long long")]
    public ulong shader_hash;
}
