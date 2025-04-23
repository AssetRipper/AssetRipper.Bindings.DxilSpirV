using AssetRipper.Bindings.DxilSpirV.Exceptions;

namespace AssetRipper.Bindings.DxilSpirV.Extensions;

public static class ResultExtensions
{
	public static void ThrowIfFailed(this Result result)
	{
		if (result != Result.Success)
		{
			throw new DxilSpirVException(result);
		}
	}
}
