using AssetRipper.Bindings.DxilSpirV.Extensions;
using System;
using System.Diagnostics;

namespace AssetRipper.Bindings.DxilSpirV;

public readonly unsafe struct DxilConverter : IDisposable
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public Converter* Pointer { get; }
	public bool IsNull => Pointer == null;

	public string AnalysisWarnings
	{
		get
		{
			ThrowIfNull();
			return NativeString.ToString(NativeMethods.ConverterGetAnalysisWarnings(Pointer));
		}
	}

	public DxilConverter(Converter* pointer)
	{
		Pointer = pointer;
	}

	public void Run()
	{
		ThrowIfNull();
		NativeMethods.ConverterRun(Pointer).ThrowIfFailed();
	}

	public ReadOnlySpan<byte> GetCompiledSpirV()
	{
		ThrowIfNull();
		CompiledSpirv result = default;
		NativeMethods.ConverterGetCompiledSpirv(Pointer, &result).ThrowIfFailed();
		return new ReadOnlySpan<byte>(result.Data, (int)result.Size);
	}

	private void ThrowIfNull()
	{
		if (IsNull)
		{
			throw new InvalidOperationException("ParsedBlob pointer is null.");
		}
	}

	public void Free()
	{
		if (!IsNull)
		{
			NativeMethods.ConverterFree(Pointer);
		}
	}

	void IDisposable.Dispose() => Free();
}
