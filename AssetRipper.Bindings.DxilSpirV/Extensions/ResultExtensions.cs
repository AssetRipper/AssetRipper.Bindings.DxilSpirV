using AssetRipper.Bindings.DxilSpirV.Exceptions;
using System;

namespace AssetRipper.Bindings.DxilSpirV.Extensions;

public static class ResultExtensions
{
	public static void ThrowIfFailed(this Result result)
	{
		switch (result)
		{
			case Result.Success:
				break;
			case Result.ErrorUnsupportedFeature:
				throw new FeatureNotSupportedException();
			case Result.ErrorOutOfMemory:
				throw new OutOfMemoryException();
			case Result.ErrorParser:
				throw new DxilParseException();
			case Result.ErrorFailedValidation:
				throw new ValidationFailedException();
			case Result.ErrorInvalidArgument:
				throw new ArgumentException("Invalid argument provided to dxil-spirv");
			case Result.ErrorNoData:
				throw new ArgumentException("No data provided to dxil-spirv");
			default:
				throw new GenericDxilSpirVException(result);
		}
	}
}
