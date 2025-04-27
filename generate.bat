dotnet tool install --global ClangSharpPInvokeGenerator
dotnet tool update --global ClangSharpPInvokeGenerator
cd AssetRipper.Bindings.DxilSpirV.Original.Generator
dotnet run
cd ../AssetRipper.Bindings.DxilSpirV.Generator
dotnet run
cd ..
