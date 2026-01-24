
# SkyBattle 微信小游戏 C# 示例（基于 LeanCLR）

## 项目简介

本项目原为微信小游戏的 JavaScript Demo。现已集成 [LeanCLR](https://github.com/focus-creative-games/leanclr)，将全部业务逻辑和 SDK 实现迁移为纯 C#，为游戏开发者提供了在微信小游戏平台上运行 C# 代码的完整范例。

本示例展示了如何：

- 使用 LeanCLR 运行时在 WebAssembly (wasm) 环境下运行 C# 游戏逻辑
- 构建 C# 版微信小游戏 SDK，并与 JS 层互操作
- 将原有 JS 游戏逻辑迁移为 C# 实现

> **注意：** 本示例仅用于演示 C# SDK 的实现方式，SDK 代码未做优化与架构设计，不建议直接用于生产环境。

## 目录结构与说明

- `wasm/wx.wasm`  
	基于 LeanCLR 的 C# 版微信小游戏 SDK，编译为 WebAssembly。
- `js/wx.js`  
	与 `wx.wasm` 配套的 JS glue 代码，由 emscripten 编译生成，负责 wasm 加载与 JS/C# 互操作。
- `leanclrsdk.js`  
	LeanCLR SDK 的核心 JS 实现，提供底层运行时支持。
- `../../managed/WxSdk`  
	C# 版微信小游戏 SDK 的源码目录，包含所有 API 封装与平台适配代码。
- `../../managed/Game`  
	游戏主逻辑的 C# 实现，原 JS 逻辑已全部迁移至此。
- `../../native`  
	`wx.wasm` 的 C/C++ 源码，集成 LeanCLR 运行时及必要的辅助函数。

## 运行说明

1. 编译 `../../native` 目录下的源码，生成 `wasm/wx.wasm`。
2. 使用 emscripten 生成 `js/wx.js`。
3. 构建 C# 项目（`../../managed/WxSdk` 和 `../../managed/Game`）。
4. 通过微信开发者工具或浏览器加载本示例，体验 C# 逻辑驱动的小游戏。

## 适用人群

本项目适合：

- 有意将 C# 代码迁移到微信小游戏平台的开发者
- 关注 WebAssembly、.NET/C# 跨平台运行的技术爱好者
- 需要自定义微信小游戏 SDK 或扩展 JS/C# 互操作的开发者

