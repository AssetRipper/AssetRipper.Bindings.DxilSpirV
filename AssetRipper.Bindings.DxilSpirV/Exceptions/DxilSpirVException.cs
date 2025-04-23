using System;

namespace AssetRipper.Bindings.DxilSpirV.Exceptions;

public class DxilSpirVException : Exception
{
	public DxilSpirVException(Result result) : base(result.ToString())
	{
	}
}
