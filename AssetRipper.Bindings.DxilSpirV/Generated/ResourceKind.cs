namespace AssetRipper.Bindings.DxilSpirV;

public enum ResourceKind
{
    Invalid = 0,
    Texture1d = 1,
    Texture2d = 2,
    Texture2dms = 3,
    Texture3d = 4,
    TextureCube = 5,
    Texture1dArray = 6,
    Texture2dArray = 7,
    Texture2dMsArray = 8,
    TextureCubeArray = 9,
    TypedBuffer = 10,
    RawBuffer = 11,
    StructuredBuffer = 12,
    ConstantBuffer = 13,
    Sampler = 14,
    Tbuffer = 15,
    RtAccelerationStructure = 16,
    FeedbackTexture2d = 17,
    FeedbackTexture2dArray = 18,
    IntMax = 0x7fffffff,
}
