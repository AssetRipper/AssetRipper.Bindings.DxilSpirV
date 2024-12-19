namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_instruction_instrumentation
{
    public dxil_spv_option_base @base;

    [NativeTypeName("dxil_spv_bool")]
    public byte enabled;

    [NativeTypeName("unsigned int")]
    public uint version;

    [NativeTypeName("unsigned int")]
    public uint control_desc_set;

    [NativeTypeName("unsigned int")]
    public uint control_binding;

    [NativeTypeName("unsigned int")]
    public uint payload_desc_set;

    [NativeTypeName("unsigned int")]
    public uint payload_binding;

    [NativeTypeName("unsigned long long")]
    public ulong shader_hash;

    public dxil_spv_instruction_instrumentation_type type;
}
