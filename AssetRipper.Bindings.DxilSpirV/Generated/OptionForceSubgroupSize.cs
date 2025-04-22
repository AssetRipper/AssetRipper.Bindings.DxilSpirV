namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionForceSubgroupSize
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("unsigned int")]
    public uint ForcedValue;

    [NativeTypeName("dxil_spv_bool")]
    public byte WaveSizeEnable;
}
