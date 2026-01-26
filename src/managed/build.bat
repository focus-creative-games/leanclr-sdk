dotnet build managed.sln -c Debug
copy WxSdk\bin\Debug\WxSdk.dll ..\samples\flybattle\dlls\WxSdk.dll.bin /Y
copy WxSdk\bin\Debug\WxSdk.pdb ..\samples\flybattle\dlls\WxSdk.pdb.bin /Y
copy Game\bin\Debug\Game.dll ..\samples\flybattle\dlls\Game.dll.bin /Y
copy Game\bin\Debug\Game.pdb ..\samples\flybattle\dlls\Game.pdb.bin /Y