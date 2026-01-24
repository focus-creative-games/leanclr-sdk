

rem set CONFIG=Debug
set CONFIG=Release
call emcmake cmake -B build-wasm -DCMAKE_BUILD_TYPE=%CONFIG%
call emmake cmake --build build-wasm --parallel

copy build-wasm\bin\wx.wasm ..\samples\skybattle\wasm\wx.wasm /Y
copy build-wasm\bin\wx.js ..\samples\skybattle\js\wx.js /Y

dotnet build ..\managed\managed.sln -c %CONFIG%
copy ..\managed\WxSdk\bin\%CONFIG%\WxSdk.dll ..\samples\skybattle\dlls\WxSdk.dll.bin /Y
copy ..\managed\WxSdk\bin\%CONFIG%\WxSdk.pdb ..\samples\skybattle\dlls\WxSdk.pdb.bin /Y
copy ..\managed\Game\bin\%CONFIG%\Game.dll ..\samples\skybattle\dlls\Game.dll.bin /Y
copy ..\managed\Game\bin\%CONFIG%\Game.pdb ..\samples\skybattle\dlls\Game.pdb.bin /Y

