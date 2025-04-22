namespace AssetRipper.Bindings.DxilSpirV;

public enum ShaderStage
{
    Unknown = 0,
    Vertex = 1,
    Hull = 2,
    Domain = 3,
    Geometry = 4,
    Pixel = 5,
    Compute = 6,
    Intersection = 7,
    ClosestHit = 8,
    Miss = 9,
    AnyHit = 10,
    RayGeneration = 11,
    Callable = 12,
    Amplification = 13,
    Mesh = 14,
    IntMax = 0x7fffffff,
}
