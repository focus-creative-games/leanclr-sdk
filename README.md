# leanclr-sdk

本项目用于演示如何实现 JS 库对应的 C# SDK，通过嵌入 LeanCLR，可实现 C# 与 JS 的高效互操作，支持在微信、抖音等平台运行。

## 目录结构简介

- `native/`  
	LeanCLR 运行时及相关 C/C++ 源码，包含 wasm 目标的构建脚本和平台适配代码。此目录负责生成可嵌入 JS 环境的 WebAssembly 模块。
- `managed/`  
	C# 业务代码与 SDK 实现，包括平台 API 封装、业务逻辑、示例工程等。所有 C# 代码均可通过 LeanCLR 在 wasm 环境下运行。

## 示例项目

- `src/samples/skybattle/`  
	SkyBattle 微信小游戏示例，演示如何将 JS 游戏逻辑迁移为 C#，并通过 LeanCLR 与 JS 层交互。
	- 详细说明见 [skybattle/README.md](src/samples/skybattle/README.md)

---
sdk for platform weixin, douyin, etc.
