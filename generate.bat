dotnet tool install --global ClangSharpPInvokeGenerator --version 18.1.0.3
cd AssetRipper.Bindings.DxilSpirV
if not exist "Generated" mkdir "Generated"
rmdir /s /q Generated
cd ..
ClangSharpPInvokeGenerator @generate.rsp