import createStartupModule from "./wx";

export default class LeanCLRSdk {
  async start() {
    // 1. 先加载所有程序集
    await this.loadAllAssemblies();
    // 2. 加载并初始化 WASM
    await this.initWasm();
    // 3. 初始化运行时
    this.initRuntime();
    this.loadGameAssembly();
  }

  loadAllAssemblies() {
    // 需要加载的程序集列表
    const dllFiles = [
      "mscorlib.dll",
      "System.dll",
      "System.Core.dll",
      "LeanCLRSdk.dll",
      "LeanCLRSdk.pdb",
      "Game.dll",
      "Game.pdb",
    ];
    this.assemblyCache = {};
    const fs = wx.getFileSystemManager();
    let loadedCount = 0;
    const totalCount = dllFiles.length;

    return new Promise((resolve, reject) => {
      dllFiles.forEach((name) => {
        fs.readFile({
          filePath: `dlls/${name}.bin`,
          success: (res) => {
            let arr;
            if (res.data instanceof ArrayBuffer) {
              arr = new Uint8Array(res.data);
            } else if (res.data && res.data.buffer) {
              arr = new Uint8Array(res.data.buffer);
            } else {
              arr = new Uint8Array(0);
            }
            this.assemblyCache[name] = arr;
            loadedCount++;
            console.log(`已加载: ${name}.bin, 长度: ${arr.length}`);
            if (loadedCount === totalCount) {
              console.log("所有程序集加载完成");
              resolve();
            }
          },
          fail: (err) => {
            console.error(`加载失败: ${name}.bin`, err);
            reject(err);
          },
        });
      });
    });
  }

  async initWasm() {
    const wasmPath = "wasm/wx.wasm";
    const self = this;
    const Module = {
      instantiateWasm(info, receiveInstance) {
        WXWebAssembly.instantiate(wasmPath, info)
          .then((result) => {
            receiveInstance(result.instance, result.module);
          })
          .catch((err) => {
            console.error("WASM 加载失败", err);
          });
        // 告诉 Emscripten 这是异步
        return {};
      },
      // 可根据需要添加 print/printErr 等回调
    };
    try {
      this.wasmModule = await createStartupModule(Module);
      console.log("WASM 加载成功");
      this.setupLoadAssemblyFile();
    } catch (err) {
      console.error("WASM 初始化失败", err);
      throw err;
    }
  }

  setupLoadAssemblyFile() {
    // 参考 index.html，WASM 侧会调用此回调获取程序集数据
    // 这里假设 wx.wasm 导出 setLoadAssemblyFile(cb) 或类似机制
    // 伪代码：this.wasmModule.setLoadAssemblyFile(this.loadAssemblyFile.bind(this));
    // 实际API需根据 wx.wasm 导出接口调整
    if (
      this.wasmModule &&
      typeof this.wasmModule.setLoadAssemblyFile === "function"
    ) {
      this.wasmModule.setLoadAssemblyFile(this.loadAssemblyFile.bind(this));
    } else {
      // 如果是通过 imports 传递，可以在创建 WASM 时传递
      // 或者直接在全局注册
      this.wasmModule.load_assembly_file = this.loadAssemblyFile.bind(this);
    }
  }

  // name: 程序集名（含扩展名），extension: 扩展名，bufPtr/sizePtr: WASM 内存指针
  loadAssemblyFile(namePtr, extensionPtr, bufPtr, sizePtr) {
    // 需要实现 C 字符串读取，和 index.html 逻辑一致
    const readCString = (ptr) => {
      const view = this.wasmModule.HEAPU8;
      let end = ptr;
      while (view[end] !== 0) end++;
      const bytes = view.slice(ptr, end);
      return new TextDecoder("utf-8").decode(bytes);
    };
    const assemblyName = readCString(namePtr);
    const extension = readCString(extensionPtr);
    const fileName = extension ? `${assemblyName}.${extension}` : assemblyName;
    const data = this.assemblyCache[fileName];
    if (data) {
      const ptr = this.wasmModule._malloc(data.length);
      this.wasmModule.HEAPU8.set(data, ptr);
      this.wasmModule.setValue(bufPtr, ptr, "*");
      this.wasmModule.setValue(sizePtr, data.length, "i32");
      console.log(`已提供程序集: ${fileName}`);
      return 0;
    } else {
      console.error(`程序集未找到: ${fileName}`);
      return 1;
    }
  }

  initRuntime() {
    // 调用 WASM 导出的初始化方法
    if (!this.wasmModule) {
      console.error("WASM 未初始化");
      return;
    }
    // 缓存 load_assembly 和 invoke_method
    if (typeof this.wasmModule.cwrap === "function") {
      this.load_assembly = this.wasmModule.cwrap("load_assembly", "number", [
        "string",
      ]);
      // invoke_method(RtAssembly*, className, methodName)
      this.invoke_method = this.wasmModule.cwrap("invoke_method", "number", [
        "number",
        "string",
        "string",
      ]);
    } else {
      this.load_assembly = this.wasmModule.load_assembly;
      this.invoke_method = this.wasmModule.invoke_method;
    }
    if (!this.load_assembly) {
      console.error("未找到 load_assembly 导出函数");
    }
    if (!this.invoke_method) {
      console.error("未找到 invoke_method 导出函数");
    }
    if (typeof this.wasmModule.ccall === "function") {
      const result = this.wasmModule.ccall(
        "initialize_runtime",
        "number",
        [],
        [],
      );
      if (result === 0) {
        console.log("运行时初始化成功！");
      } else {
        console.error("运行时初始化失败，错误码:", result);
      }
    } else {
      console.error("WASM ccall 不可用");
    }
  }

  loadGameAssembly() {
    if (!this.wasmModule) {
      console.error("WASM 未初始化，无法加载 Game.dll");
      return;
    }
    if (!this.load_assembly) {
      console.error("未找到 load_assembly 导出函数");
      return;
    }
    const result = this.load_assembly("Game");
    if (result) {
      console.log("Game.dll 加载成功，返回值:", result);
      this.gameAssembly = result;
    } else {
      console.error("Game.dll 加载失败，返回值:", result);
    }
  }

  callGameStart() {
    if (!this.wasmModule) {
      console.error("WASM 未初始化，无法调用 Game.App::Start");
      return;
    }
    if (!this.invoke_method) {
      console.error("未找到 invoke_method 导出函数");
      return;
    }
    if (!this.gameAssembly) {
      console.error("Game.dll 未加载，无法调用 Game.App::Start");
      return;
    }
    const result = this.invoke_method(this.gameAssembly, "Game.App", "Start");
    if (result === 0) {
      console.log("Game.App::Start 调用成功");
    } else {
      console.error("Game.App::Start 调用失败，返回值:", result);
    }
  }

  update() {
    if (!this.wasmModule || !this.invoke_method || !this.gameAssembly) return;
    this.invoke_method(this.gameAssembly, "Game.App", "Update");
  }

  render() {}
}
