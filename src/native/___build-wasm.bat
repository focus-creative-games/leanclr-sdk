

call emcmake cmake -B build-wasm -DCMAKE_BUILD_TYPE=Debug
call emmake cmake --build build-wasm --parallel

copy build-wasm\bin\wx.wasm ..\samples\flybattle\wasm\wx.wasm /Y
copy build-wasm\bin\wx.js ..\samples\flybattle\js\wx.js /Y

dotnet build ..\managed\managed.sln -c Debug
copy ..\managed\WxSdk\bin\Debug\WxSdk.dll ..\samples\flybattle\dlls\WxSdk.dll.bin /Y
copy ..\managed\WxSdk\bin\Debug\WxSdk.pdb ..\samples\flybattle\dlls\WxSdk.pdb.bin /Y
copy ..\managed\Game\bin\Debug\Game.dll ..\samples\flybattle\dlls\Game.dll.bin /Y
copy ..\managed\Game\bin\Debug\Game.pdb ..\samples\flybattle\dlls\Game.pdb.bin /Y