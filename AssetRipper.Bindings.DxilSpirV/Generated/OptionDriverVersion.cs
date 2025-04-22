namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionDriverVersion
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("unsigned int")]
    public uint DriverId;

    [NativeTypeName("unsigned int")]
    public uint DriverVersion;
}
