
function readCString(ptr) {
  if (!Module || !Module.HEAPU8) {
    log("错误：HEAPU8 未就绪", "error");
    return "";
  }
  const view = Module.HEAPU8;
  let end = ptr;
  while (view[end] !== 0) end++;
  const bytes = view.slice(ptr, end);
  return new TextDecoder("utf-8").decode(bytes);
}

// ==================== 程序集加载逻辑 ====================

async function loadAllAssemblies() {
  console.log("🔍 开始扫描程序集文件...", "info");

  const dllFiles = [
    "mscorlib.dll",
    "System.dll",
    "System.Core.dll",
    "CoreTests.dll",
    "CoreTests.pdb",
  ];


  let loadedCount = 0;
  const totalCount = dllFiles.length;

  for (const filename of dllFiles) {
    try {
      const response = await fetch(filename + ".bin");
      if (!response.ok) throw new Error(`HTTP ${response.status}`);

      const buffer = await response.arrayBuffer();
      const assemblyName = filename.replace(".bytes", "");
      assemblyCache[assemblyName] = new Uint8Array(buffer);

      console.log(`✓ 已加载: ${filename} (${fileSize})`);
      loadedCount++;
    } catch (error) {
      console.error(`✗ 加载失败: ${filename} - ${error.message}`);
    }
  }

  log(`✅ 程序集加载完成: ${loadedCount}/${totalCount}`, "success");
  return loadedCount === totalCount;
}

// ==================== WASM 模块初始化 ====================

function initializeModule() {
  return new Promise((resolve, reject) => {
    const moduleConfig = {
      print: (text) => console.log(text), // redirect stdout (printf)
      printErr: (text) => console.error(text), // redirect stderr
    };

    createStartupModule(moduleConfig)
      .then((Module_) => {
        Module = Module_;
        console.log("✓ WASM 模块加载成功");

        // 不缓存 memory 引用，直接用 Module.HEAPU8，避免内存增长导致 buffer 失效
        if (!Module.HEAPU8) {
          console.log("⚠️  警告：未能获取 HEAPU8，运行时方法可能未正确导出");
        }

        // 实现 load_assembly_file 回调
        Module.load_assembly_file = function (
          namePtr,
          extensionPtr,
          bufPtr,
          sizePtr,
        ) {
          const assemblyName = readCString(namePtr);
          const extension = readCString(extensionPtr);
          console.log(
            `📂 正在加载程序集: ${assemblyName} with extension: ${extension}`,
          );
          const fileName = extension
            ? `${assemblyName}.${extension}`
            : assemblyName;
          if (assemblyCache[fileName]) {
            const data = assemblyCache[fileName];
            try {
              // 在 WASM 内存中分配空间（使用 runtime allocate，内部调用 _malloc）
              const ptr = Module._malloc(data.length);

              // 将数据写入 WASM 内存（allocate 已写入，但为安全起见再 set 一次覆盖）
              Module.HEAPU8.set(data, ptr);

              // 设置输出参数
              Module.setValue(bufPtr, ptr, "*");
              Module.setValue(sizePtr, data.length, "i32");

              console.log(`   ✓ 已加载 ${data.length} 字节`);
              return 0;
            } catch (error) {
              console.log(`   ✗ 加载失败: ${error.message}`);
              return 1;
            }
          } else {
            console.log(
              `   ✗ 文件未找到: ${fileName}`,
              extension == "dll" ? "error" : "warning",
            );
            return 1;
          }
        };

        console.log("✓ load_assembly_file 回调已实现");
        resolve();
      })
      .catch(reject);
  });
}

// ==================== 运行时初始化 ====================

function initRuntime() {

  try {
    console.log("🔧 开始初始化运行时...");

    const result = Module.ccall("initialize_runtime", "number", [], []);

    if (result === 0) {
      console.log("✅ 运行时初始化成功！");
    } else {
      console.log(`❌ 运行时初始化失败，错误码: ${result}`);
    }
  } catch (error) {
    console.log(`❌ 初始化错误: ${error.message}`);
  } finally {

  }
}

export default class LeanCLRSdk {
  start() {}

  update() {}

  render() {}
}
