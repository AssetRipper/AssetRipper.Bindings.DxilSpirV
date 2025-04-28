using System;

namespace AssetRipper.Bindings.DxilSpirV.Exceptions;

public class GenericDxilSpirVException : Exception
{
	public GenericDxilSpirVException(Result result) : base(result.ToString())
	{
	}
}
