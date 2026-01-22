dotnet build managed.sln -c Debug
copy LeanCLRSdk\bin\Debug\LeanCLRSdk.dll ..\samples\flybattle\dlls\LeanCLRSdk.dll.bin /Y
copy LeanCLRSdk\bin\Debug\LeanCLRSdk.pdb ..\samples\flybattle\dlls\LeanCLRSdk.pdb.bin /Y
copy Game\bin\Debug\Game.dll ..\samples\flybattle\dlls\Game.dll.bin /Y
copy Game\bin\Debug\Game.pdb ..\samples\flybattle\dlls\Game.pdb.bin /Y