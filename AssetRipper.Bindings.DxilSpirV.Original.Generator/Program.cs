using System.Diagnostics;

namespace AssetRipper.Bindings.DxilSpirV.Original.Generator;

internal static class Program
{
	private const string RepositoryRoot = "../../../../";
	private const string OutputPath = "./AssetRipper.Bindings.DxilSpirV.Original/Generated";

	static void Main()
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		try
		{
			Directory.SetCurrentDirectory(Path.Combine(AppContext.BaseDirectory, RepositoryRoot));
			if (Directory.Exists(OutputPath))
			{
				Directory.Delete(OutputPath, true);
			}

			Process? process = Process.Start(new ProcessStartInfo("dotnet", ["tool", "run", "ClangSharpPInvokeGenerator", "@generate.rsp"]));

			process?.WaitForExit();
		}
		finally
		{
			Directory.SetCurrentDirectory(currentDirectory);
		}
	}
}
