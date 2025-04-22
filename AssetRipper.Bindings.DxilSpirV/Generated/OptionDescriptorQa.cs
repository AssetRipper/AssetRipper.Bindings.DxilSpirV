namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionDescriptorQa
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte Enabled;

    [NativeTypeName("unsigned int")]
    public uint Version;

    [NativeTypeName("unsigned int")]
    public uint GlobalDescSet;

    [NativeTypeName("unsigned int")]
    public uint GlobalBinding;

    [NativeTypeName("unsigned int")]
    public uint HeapDescSet;

    [NativeTypeName("unsigned int")]
    public uint HeapBinding;

    [NativeTypeName("unsigned long long")]
    public ulong ShaderHash;
}
