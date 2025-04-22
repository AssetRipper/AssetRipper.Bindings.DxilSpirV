namespace AssetRipper.Bindings.DxilSpirV;

public enum Result
{
    Success = 0,
    ErrorOutOfMemory = -1,
    ErrorGeneric = -2,
    ErrorUnsupportedFeature = -3,
    ErrorParser = -4,
    ErrorFailedValidation = -5,
    ErrorInvalidArgument = -6,
    ErrorNoData = -7,
    IntMax = 0x7fffffff,
}
