using System;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.DxilSpirV;

internal static unsafe class NativeString
{
	public static string ToString(sbyte* str)
	{
		return Marshal.PtrToStringAnsi((IntPtr)str) ?? string.Empty;
	}
}
