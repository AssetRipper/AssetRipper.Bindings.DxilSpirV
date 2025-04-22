namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionInstructionInstrumentation
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte Enabled;

    [NativeTypeName("unsigned int")]
    public uint Version;

    [NativeTypeName("unsigned int")]
    public uint ControlDescSet;

    [NativeTypeName("unsigned int")]
    public uint ControlBinding;

    [NativeTypeName("unsigned int")]
    public uint PayloadDescSet;

    [NativeTypeName("unsigned int")]
    public uint PayloadBinding;

    [NativeTypeName("unsigned long long")]
    public ulong ShaderHash;

    [NativeTypeName("dxil_spv_instruction_instrumentation_type")]
    public InstructionInstrumentationType Type;
}
