namespace AssetRipper.Bindings.DxilSpirV;

public enum ShaderQuirk
{
    None = 0,
    ForceDeviceMemoryBarriersThreadGroupCoherence = 1,
    ASSUME_BROKEN_SUB_8x8_CUBE_MIPS = 2,
    RobustPhysicalCbvForwarding = 3,
    MeshOutputsRobustness = 4,
    AggressiveNonuniform = 5,
    RobustPhysicalCbv = 6,
    PromoteGroupToDeviceMemoryBarrier = 7,
    GroupSharedAutoBarrier = 8,
    FixupLoopHeaderUndefPhis = 9,
    FixupRsqrtInfNan = 10,
    IntMax = 0x7fffffff,
}
