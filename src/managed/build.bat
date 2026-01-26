dotnet build managed.sln -c Debug
copy WxSdk\bin\Debug\WxSdk.dll ..\samples\skybattle\dlls\WxSdk.dll.bin /Y
copy WxSdk\bin\Debug\WxSdk.pdb ..\samples\skybattle\dlls\WxSdk.pdb.bin /Y
copy Game\bin\Debug\Game.dll ..\samples\skybattle\dlls\Game.dll.bin /Y
copy Game\bin\Debug\Game.pdb ..\samples\skybattle\dlls\Game.pdb.bin /Y