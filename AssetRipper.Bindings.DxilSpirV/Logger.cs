using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.DxilSpirV;

public static unsafe class Logger
{
	public static Action<LogLevel, string>? Callback;

	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
	internal static void LogMessage(void* userData, LogLevel level, sbyte* message)
	{
		Callback?.Invoke(level, NativeString.ToString(message));
	}

	public static void AddConsoleLogger()
	{
		Callback += (level, msg) =>
		{
			Console.WriteLine($"[{level}] {msg}");
		};
	}
}
