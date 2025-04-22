namespace AssetRipper.Bindings.DxilSpirV;

public enum InstructionInstrumentationType
{
    TypeFullNanInf = 0,
    TypeExternallyVisibleWriteNanInf = 1,
    TypeFlushNanToZero = 2,
    TypeExpectAssume = 3,
    TypeBufferSynchronizationValidation = 4,
    IntMax = 0x7fffffff,
}
