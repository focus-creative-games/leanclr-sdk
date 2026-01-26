# 微信小游戏 API 整理


### 基础 | 微信开放文档

以下服务端接口可免 access_token 调用的场景：使用微信云托管通过微信令牌/开放接口服务调用；使用微信云开发通过云函数免服务器发起云调用。

|  | 名称 | 功能 |
| --- | --- | --- |
|  | wx.env | 环境变量 |
|  | 系统 |  |
|  | 名称 功能 wx.openSystemBluetoothSetting 跳转系统蓝牙设置页 wx.openAppAuthorizeSetting 跳转系统微信授权管理页 wx.getWindowInfo 获取窗口信息 wx.getSystemSetting 获取设备设置 wx.getSystemInfoSync wx.getSystemInfo 的同步版本 wx.getSystemInfoAsync 异步获取系统信息 wx.getSystemInfo 获取系统信息 wx.getDeviceInfo 获取设备基础信息 wx.getDeviceBenchmarkInfo 获取设备性能得分和机型档位数据 wx.getAppBaseInfo 获取微信APP基础信息 wx.getAppAuthorizeSetting 获取微信APP授权设置 |  | 名称 | 功能 |  | wx.openSystemBluetoothSetting | 跳转系统蓝牙设置页 |  | wx.openAppAuthorizeSetting | 跳转系统微信授权管理页 |  | wx.getWindowInfo | 获取窗口信息 |  | wx.getSystemSetting | 获取设备设置 |  | wx.getSystemInfoSync | wx.getSystemInfo 的同步版本 |  | wx.getSystemInfoAsync | 异步获取系统信息 |  | wx.getSystemInfo | 获取系统信息 |  | wx.getDeviceInfo | 获取设备基础信息 |  | wx.getDeviceBenchmarkInfo | 获取设备性能得分和机型档位数据 |  | wx.getAppBaseInfo | 获取微信APP基础信息 |  | wx.getAppAuthorizeSetting | 获取微信APP授权设置 |
|  | 名称 | 功能 |
|  | wx.openSystemBluetoothSetting | 跳转系统蓝牙设置页 |
|  | wx.openAppAuthorizeSetting | 跳转系统微信授权管理页 |
|  | wx.getWindowInfo | 获取窗口信息 |
|  | wx.getSystemSetting | 获取设备设置 |
|  | wx.getSystemInfoSync | wx.getSystemInfo 的同步版本 |
|  | wx.getSystemInfoAsync | 异步获取系统信息 |
|  | wx.getSystemInfo | 获取系统信息 |
|  | wx.getDeviceInfo | 获取设备基础信息 |
|  | wx.getDeviceBenchmarkInfo | 获取设备性能得分和机型档位数据 |
|  | wx.getAppBaseInfo | 获取微信APP基础信息 |
|  | wx.getAppAuthorizeSetting | 获取微信APP授权设置 |
|  | 更新 |  |
|  | 名称 功能 wx.updateWeChatApp 更新客户端版本 wx.getUpdateManager 获取全局唯一的版本更新管理器，用于管理小程序更新 UpdateManager UpdateManager 对象，用来管理更新，可通过 wx.getUpdateManager 接口获取实例 名称 功能 UpdateManager.applyUpdate 强制小程序重启并使用新版本 UpdateManager.onCheckForUpdate 监听向微信后台请求检查更新结果事件 UpdateManager.onUpdateFailed 监听小程序更新失败事件 UpdateManager.onUpdateReady 监听小程序有版本更新事件 |  | 名称 | 功能 |  | wx.updateWeChatApp | 更新客户端版本 |  | wx.getUpdateManager | 获取全局唯一的版本更新管理器，用于管理小程序更新 |  | UpdateManager | UpdateManager 对象，用来管理更新，可通过 wx.getUpdateManager 接口获取实例 |  | 名称 功能 UpdateManager.applyUpdate 强制小程序重启并使用新版本 UpdateManager.onCheckForUpdate 监听向微信后台请求检查更新结果事件 UpdateManager.onUpdateFailed 监听小程序更新失败事件 UpdateManager.onUpdateReady 监听小程序有版本更新事件 |  | 名称 | 功能 |  | UpdateManager.applyUpdate | 强制小程序重启并使用新版本 |  | UpdateManager.onCheckForUpdate | 监听向微信后台请求检查更新结果事件 |  | UpdateManager.onUpdateFailed | 监听小程序更新失败事件 |  | UpdateManager.onUpdateReady | 监听小程序有版本更新事件 |
|  | 名称 | 功能 |
|  | wx.updateWeChatApp | 更新客户端版本 |
|  | wx.getUpdateManager | 获取全局唯一的版本更新管理器，用于管理小程序更新 |
|  | UpdateManager | UpdateManager 对象，用来管理更新，可通过 wx.getUpdateManager 接口获取实例 |
|  | 名称 功能 UpdateManager.applyUpdate 强制小程序重启并使用新版本 UpdateManager.onCheckForUpdate 监听向微信后台请求检查更新结果事件 UpdateManager.onUpdateFailed 监听小程序更新失败事件 UpdateManager.onUpdateReady 监听小程序有版本更新事件 |  | 名称 | 功能 |  | UpdateManager.applyUpdate | 强制小程序重启并使用新版本 |  | UpdateManager.onCheckForUpdate | 监听向微信后台请求检查更新结果事件 |  | UpdateManager.onUpdateFailed | 监听小程序更新失败事件 |  | UpdateManager.onUpdateReady | 监听小程序有版本更新事件 |
|  | 名称 | 功能 |
|  | UpdateManager.applyUpdate | 强制小程序重启并使用新版本 |
|  | UpdateManager.onCheckForUpdate | 监听向微信后台请求检查更新结果事件 |
|  | UpdateManager.onUpdateFailed | 监听小程序更新失败事件 |
|  | UpdateManager.onUpdateReady | 监听小程序有版本更新事件 |
|  | 生命周期 |  |
|  | 名称 功能 wx.onShow 监听小游戏回到前台的事件 wx.onHide 监听小游戏隐藏到后台事件 wx.offShow 移除小游戏回到前台的事件的监听函数 wx.offHide 移除小游戏隐藏到后台事件的监听函数 wx.getLaunchOptionsSync 获取小游戏冷启动时的参数 wx.getEnterOptionsSync 获取小游戏打开的参数（包括冷启动和热启动） |  | 名称 | 功能 |  | wx.onShow | 监听小游戏回到前台的事件 |  | wx.onHide | 监听小游戏隐藏到后台事件 |  | wx.offShow | 移除小游戏回到前台的事件的监听函数 |  | wx.offHide | 移除小游戏隐藏到后台事件的监听函数 |  | wx.getLaunchOptionsSync | 获取小游戏冷启动时的参数 |  | wx.getEnterOptionsSync | 获取小游戏打开的参数（包括冷启动和热启动） |
|  | 名称 | 功能 |
|  | wx.onShow | 监听小游戏回到前台的事件 |
|  | wx.onHide | 监听小游戏隐藏到后台事件 |
|  | wx.offShow | 移除小游戏回到前台的事件的监听函数 |
|  | wx.offHide | 移除小游戏隐藏到后台事件的监听函数 |
|  | wx.getLaunchOptionsSync | 获取小游戏冷启动时的参数 |
|  | wx.getEnterOptionsSync | 获取小游戏打开的参数（包括冷启动和热启动） |
|  | 应用级事件 |  |
|  | 名称 功能 wx.onUnhandledRejection 监听未处理的 Promise 拒绝事件 wx.onError 监听全局错误事件 wx.onAudioInterruptionEnd 监听音频中断结束事件 wx.onAudioInterruptionBegin 监听音频因为受到系统占用而被中断开始事件 wx.offUnhandledRejection 移除未处理的 Promise 拒绝事件的监听函数 wx.offError 移除全局错误事件的监听函数 wx.offAudioInterruptionEnd 移除音频中断结束事件的监听函数 wx.offAudioInterruptionBegin 移除音频因为受到系统占用而被中断开始事件的监听函数 |  | 名称 | 功能 |  | wx.onUnhandledRejection | 监听未处理的 Promise 拒绝事件 |  | wx.onError | 监听全局错误事件 |  | wx.onAudioInterruptionEnd | 监听音频中断结束事件 |  | wx.onAudioInterruptionBegin | 监听音频因为受到系统占用而被中断开始事件 |  | wx.offUnhandledRejection | 移除未处理的 Promise 拒绝事件的监听函数 |  | wx.offError | 移除全局错误事件的监听函数 |  | wx.offAudioInterruptionEnd | 移除音频中断结束事件的监听函数 |  | wx.offAudioInterruptionBegin | 移除音频因为受到系统占用而被中断开始事件的监听函数 |
|  | 名称 | 功能 |
|  | wx.onUnhandledRejection | 监听未处理的 Promise 拒绝事件 |
|  | wx.onError | 监听全局错误事件 |
|  | wx.onAudioInterruptionEnd | 监听音频中断结束事件 |
|  | wx.onAudioInterruptionBegin | 监听音频因为受到系统占用而被中断开始事件 |
|  | wx.offUnhandledRejection | 移除未处理的 Promise 拒绝事件的监听函数 |
|  | wx.offError | 移除全局错误事件的监听函数 |
|  | wx.offAudioInterruptionEnd | 移除音频中断结束事件的监听函数 |
|  | wx.offAudioInterruptionBegin | 移除音频因为受到系统占用而被中断开始事件的监听函数 |
|  | 性能 |  |
|  | 名称 功能 wx.triggerGC 加快触发 JavaScriptCore 垃圾回收（Garbage Collection） wx.reportPerformance 小程序测速上报 wx.getPerformance 获取性能管理器 Performance 性能管理器 名称 功能 Performance.now 可以获取当前时间以微秒为单位的时间戳 |  | 名称 | 功能 |  | wx.triggerGC | 加快触发 JavaScriptCore 垃圾回收（Garbage Collection） |  | wx.reportPerformance | 小程序测速上报 |  | wx.getPerformance | 获取性能管理器 |  | Performance | 性能管理器 |  | 名称 功能 Performance.now 可以获取当前时间以微秒为单位的时间戳 |  | 名称 | 功能 |  | Performance.now | 可以获取当前时间以微秒为单位的时间戳 |
|  | 名称 | 功能 |
|  | wx.triggerGC | 加快触发 JavaScriptCore 垃圾回收（Garbage Collection） |
|  | wx.reportPerformance | 小程序测速上报 |
|  | wx.getPerformance | 获取性能管理器 |
|  | Performance | 性能管理器 |
|  | 名称 功能 Performance.now 可以获取当前时间以微秒为单位的时间戳 |  | 名称 | 功能 |  | Performance.now | 可以获取当前时间以微秒为单位的时间戳 |
|  | 名称 | 功能 |
|  | Performance.now | 可以获取当前时间以微秒为单位的时间戳 |
|  | 分包加载 |  |
|  | 名称 功能 wx.preDownloadSubpackage 触发分包预下载 wx.loadSubpackage 触发分包加载，详见 分包加载 LoadSubpackageTask 加载分包任务实例，用于获取分包加载状态 名称 功能 LoadSubpackageTask.onProgressUpdate 监听分包加载进度变化事件 PreDownloadSubpackageTask 预下载分包任务实例，用于获取分包预下载状态 名称 功能 PreDownloadSubpackageTask.onProgressUpdate 监听分包加载进度变化事件 |  | 名称 | 功能 |  | wx.preDownloadSubpackage | 触发分包预下载 |  | wx.loadSubpackage | 触发分包加载，详见 分包加载 |  | LoadSubpackageTask | 加载分包任务实例，用于获取分包加载状态 |  | 名称 功能 LoadSubpackageTask.onProgressUpdate 监听分包加载进度变化事件 |  | 名称 | 功能 |  | LoadSubpackageTask.onProgressUpdate | 监听分包加载进度变化事件 |  | PreDownloadSubpackageTask | 预下载分包任务实例，用于获取分包预下载状态 |  | 名称 功能 PreDownloadSubpackageTask.onProgressUpdate 监听分包加载进度变化事件 |  | 名称 | 功能 |  | PreDownloadSubpackageTask.onProgressUpdate | 监听分包加载进度变化事件 |
|  | 名称 | 功能 |
|  | wx.preDownloadSubpackage | 触发分包预下载 |
|  | wx.loadSubpackage | 触发分包加载，详见 分包加载 |
|  | LoadSubpackageTask | 加载分包任务实例，用于获取分包加载状态 |
|  | 名称 功能 LoadSubpackageTask.onProgressUpdate 监听分包加载进度变化事件 |  | 名称 | 功能 |  | LoadSubpackageTask.onProgressUpdate | 监听分包加载进度变化事件 |
|  | 名称 | 功能 |
|  | LoadSubpackageTask.onProgressUpdate | 监听分包加载进度变化事件 |
|  | PreDownloadSubpackageTask | 预下载分包任务实例，用于获取分包预下载状态 |
|  | 名称 功能 PreDownloadSubpackageTask.onProgressUpdate 监听分包加载进度变化事件 |  | 名称 | 功能 |  | PreDownloadSubpackageTask.onProgressUpdate | 监听分包加载进度变化事件 |
|  | 名称 | 功能 |
|  | PreDownloadSubpackageTask.onProgressUpdate | 监听分包加载进度变化事件 |
|  | 调试 |  |
|  | 名称 功能 wx.setEnableDebug 设置是否打开调试开关 wx.getRealtimeLogManager 获取实时日志管理器对象 wx.getLogManager 获取日志管理器对象 console 向调试面板中打印日志 名称 功能 console.debug 向调试面板中打印 debug 日志 console.error 向调试面板中打印 error 日志 console.group 在调试面板中创建一个新的分组 console.groupEnd 结束由 console.group 创建的分组 console.info 向调试面板中打印 info 日志 console.log 向调试面板中打印 log 日志 console.warn 向调试面板中打印 warn 日志 LogManager 日志管理器实例，可以通过 wx.getLogManager 获取 名称 功能 LogManager.debug 写 debug 日志 LogManager.info 写 info 日志 LogManager.log 写 log 日志 LogManager.warn 写 warn 日志 RealtimeLogManager 实时日志管理器实例，可以通过 wx.getRealtimeLogManager 获取 名称 功能 RealtimeLogManager.addFilterMsg 添加过滤关键字，暂不支持在插件使用 RealtimeLogManager.error 写 error 日志，暂不支持在插件使用 RealtimeLogManager.info 写 info 日志，暂不支持在插件使用 RealtimeLogManager.setFilterMsg 设置过滤关键字，暂不支持在插件使用 RealtimeLogManager.warn 写 warn 日志，暂不支持在插件使用 |  | 名称 | 功能 |  | wx.setEnableDebug | 设置是否打开调试开关 |  | wx.getRealtimeLogManager | 获取实时日志管理器对象 |  | wx.getLogManager | 获取日志管理器对象 |  | console | 向调试面板中打印日志 |  | 名称 功能 console.debug 向调试面板中打印 debug 日志 console.error 向调试面板中打印 error 日志 console.group 在调试面板中创建一个新的分组 console.groupEnd 结束由 console.group 创建的分组 console.info 向调试面板中打印 info 日志 console.log 向调试面板中打印 log 日志 console.warn 向调试面板中打印 warn 日志 |  | 名称 | 功能 |  | console.debug | 向调试面板中打印 debug 日志 |  | console.error | 向调试面板中打印 error 日志 |  | console.group | 在调试面板中创建一个新的分组 |  | console.groupEnd | 结束由 console.group 创建的分组 |  | console.info | 向调试面板中打印 info 日志 |  | console.log | 向调试面板中打印 log 日志 |  | console.warn | 向调试面板中打印 warn 日志 |  | LogManager | 日志管理器实例，可以通过 wx.getLogManager 获取 |  | 名称 功能 LogManager.debug 写 debug 日志 LogManager.info 写 info 日志 LogManager.log 写 log 日志 LogManager.warn 写 warn 日志 |  | 名称 | 功能 |  | LogManager.debug | 写 debug 日志 |  | LogManager.info | 写 info 日志 |  | LogManager.log | 写 log 日志 |  | LogManager.warn | 写 warn 日志 |  | RealtimeLogManager | 实时日志管理器实例，可以通过 wx.getRealtimeLogManager 获取 |  | 名称 功能 RealtimeLogManager.addFilterMsg 添加过滤关键字，暂不支持在插件使用 RealtimeLogManager.error 写 error 日志，暂不支持在插件使用 RealtimeLogManager.info 写 info 日志，暂不支持在插件使用 RealtimeLogManager.setFilterMsg 设置过滤关键字，暂不支持在插件使用 RealtimeLogManager.warn 写 warn 日志，暂不支持在插件使用 |  | 名称 | 功能 |  | RealtimeLogManager.addFilterMsg | 添加过滤关键字，暂不支持在插件使用 |  | RealtimeLogManager.error | 写 error 日志，暂不支持在插件使用 |  | RealtimeLogManager.info | 写 info 日志，暂不支持在插件使用 |  | RealtimeLogManager.setFilterMsg | 设置过滤关键字，暂不支持在插件使用 |  | RealtimeLogManager.warn | 写 warn 日志，暂不支持在插件使用 |
|  | 名称 | 功能 |
|  | wx.setEnableDebug | 设置是否打开调试开关 |
|  | wx.getRealtimeLogManager | 获取实时日志管理器对象 |
|  | wx.getLogManager | 获取日志管理器对象 |
|  | console | 向调试面板中打印日志 |
|  | 名称 功能 console.debug 向调试面板中打印 debug 日志 console.error 向调试面板中打印 error 日志 console.group 在调试面板中创建一个新的分组 console.groupEnd 结束由 console.group 创建的分组 console.info 向调试面板中打印 info 日志 console.log 向调试面板中打印 log 日志 console.warn 向调试面板中打印 warn 日志 |  | 名称 | 功能 |  | console.debug | 向调试面板中打印 debug 日志 |  | console.error | 向调试面板中打印 error 日志 |  | console.group | 在调试面板中创建一个新的分组 |  | console.groupEnd | 结束由 console.group 创建的分组 |  | console.info | 向调试面板中打印 info 日志 |  | console.log | 向调试面板中打印 log 日志 |  | console.warn | 向调试面板中打印 warn 日志 |
|  | 名称 | 功能 |
|  | console.debug | 向调试面板中打印 debug 日志 |
|  | console.error | 向调试面板中打印 error 日志 |
|  | console.group | 在调试面板中创建一个新的分组 |
|  | console.groupEnd | 结束由 console.group 创建的分组 |
|  | console.info | 向调试面板中打印 info 日志 |
|  | console.log | 向调试面板中打印 log 日志 |
|  | console.warn | 向调试面板中打印 warn 日志 |
|  | LogManager | 日志管理器实例，可以通过 wx.getLogManager 获取 |
|  | 名称 功能 LogManager.debug 写 debug 日志 LogManager.info 写 info 日志 LogManager.log 写 log 日志 LogManager.warn 写 warn 日志 |  | 名称 | 功能 |  | LogManager.debug | 写 debug 日志 |  | LogManager.info | 写 info 日志 |  | LogManager.log | 写 log 日志 |  | LogManager.warn | 写 warn 日志 |
|  | 名称 | 功能 |
|  | LogManager.debug | 写 debug 日志 |
|  | LogManager.info | 写 info 日志 |
|  | LogManager.log | 写 log 日志 |
|  | LogManager.warn | 写 warn 日志 |
|  | RealtimeLogManager | 实时日志管理器实例，可以通过 wx.getRealtimeLogManager 获取 |
|  | 名称 功能 RealtimeLogManager.addFilterMsg 添加过滤关键字，暂不支持在插件使用 RealtimeLogManager.error 写 error 日志，暂不支持在插件使用 RealtimeLogManager.info 写 info 日志，暂不支持在插件使用 RealtimeLogManager.setFilterMsg 设置过滤关键字，暂不支持在插件使用 RealtimeLogManager.warn 写 warn 日志，暂不支持在插件使用 |  | 名称 | 功能 |  | RealtimeLogManager.addFilterMsg | 添加过滤关键字，暂不支持在插件使用 |  | RealtimeLogManager.error | 写 error 日志，暂不支持在插件使用 |  | RealtimeLogManager.info | 写 info 日志，暂不支持在插件使用 |  | RealtimeLogManager.setFilterMsg | 设置过滤关键字，暂不支持在插件使用 |  | RealtimeLogManager.warn | 写 warn 日志，暂不支持在插件使用 |
|  | 名称 | 功能 |
|  | RealtimeLogManager.addFilterMsg | 添加过滤关键字，暂不支持在插件使用 |
|  | RealtimeLogManager.error | 写 error 日志，暂不支持在插件使用 |
|  | RealtimeLogManager.info | 写 info 日志，暂不支持在插件使用 |
|  | RealtimeLogManager.setFilterMsg | 设置过滤关键字，暂不支持在插件使用 |
|  | RealtimeLogManager.warn | 写 warn 日志，暂不支持在插件使用 |
|  | 加密 |  |
|  | 名称 功能 wx.getUserCryptoManager 获取用户加密模块 UserCryptoManager 用户加密模块 名称 功能 UserCryptoManager.getLatestUserKey 获取最新的用户加密密钥 UserCryptoManager.getRandomValues 获取密码学安全随机数 |  | 名称 | 功能 |  | wx.getUserCryptoManager | 获取用户加密模块 |  | UserCryptoManager | 用户加密模块 |  | 名称 功能 UserCryptoManager.getLatestUserKey 获取最新的用户加密密钥 UserCryptoManager.getRandomValues 获取密码学安全随机数 |  | 名称 | 功能 |  | UserCryptoManager.getLatestUserKey | 获取最新的用户加密密钥 |  | UserCryptoManager.getRandomValues | 获取密码学安全随机数 |
|  | 名称 | 功能 |
|  | wx.getUserCryptoManager | 获取用户加密模块 |
|  | UserCryptoManager | 用户加密模块 |
|  | 名称 功能 UserCryptoManager.getLatestUserKey 获取最新的用户加密密钥 UserCryptoManager.getRandomValues 获取密码学安全随机数 |  | 名称 | 功能 |  | UserCryptoManager.getLatestUserKey | 获取最新的用户加密密钥 |  | UserCryptoManager.getRandomValues | 获取密码学安全随机数 |
|  | 名称 | 功能 |
|  | UserCryptoManager.getLatestUserKey | 获取最新的用户加密密钥 |
|  | UserCryptoManager.getRandomValues | 获取密码学安全随机数 |


### BannerAd

banner 广告组件。banner 广告组件是一个原生组件，层级比普通组件高。banner 广告组件默认是隐藏的，需要调用 BannerAd.show() 将其显示。banner 广告会根据开发者设置的宽度进行等比缩放，缩放后的尺寸将通过 BannerAd.onResize() 事件中提供。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| left | number | banner 广告组件的左上角横坐标 |
| top | number | banner 广告组件的左上角纵坐标 |
| width | number | banner 广告组件的宽度。最小 300，最大至 屏幕宽度（屏幕宽度可以通过 wx.getSystemInfoSync() 获取）。 |
| height | number | banner 广告组件的高度 |
| realWidth | number | banner 广告组件经过缩放后真实的宽度 |
| realHeight | number | banner 广告组件经过缩放后真实的高度 |


### BannerAd.onError(function listener)

# 功能描述

|  | 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- |
|  | errMsg | string | 错误信息 |  |
|  | errCode | number | 错误码 | 2.2.2 |
|  | 合法值 说明 1000 后端接口调用失败 1001 参数错误 1002 广告单元无效 1003 内部错误 1004 无合适的广告 1005 广告组件审核中 1006 广告组件被驳回 1007 广告组件被封禁 1008 广告单元已关闭 | 合法值 | 说明 | 1000 | 后端接口调用失败 | 1001 | 参数错误 | 1002 | 广告单元无效 | 1003 | 内部错误 | 1004 | 无合适的广告 | 1005 | 广告组件审核中 | 1006 | 广告组件被驳回 | 1007 | 广告组件被封禁 | 1008 | 广告单元已关闭 |
| 合法值 | 说明 |
| 1000 | 后端接口调用失败 |
| 1001 | 参数错误 |
| 1002 | 广告单元无效 |
| 1003 | 内部错误 |
| 1004 | 无合适的广告 |
| 1005 | 广告组件审核中 |
| 1006 | 广告组件被驳回 |
| 1007 | 广告组件被封禁 |
| 1008 | 广告单元已关闭 |


### BannerAd.onResize(function listener)

# 功能描述

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| width | number | 缩放后的宽度 |
| height | number | 缩放后的高度 |


### BeaconInfo

相关文档: 蓝牙信标 (Beacon)

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| 0 | 信号太弱不足以计算距离，或非 iOS 设备 |  |
| 1 | 十分近 |  |
| 2 | 比较近 |  |
| 3 | 远 |  |


### BLEPeripheralServer.addService(Object object)

基础库 2.10.3 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | service | Object |  | 是 | 描述service的Object |
|  | 结构属性 类型 默认值 必填 说明 uuid String 是 蓝牙服务的 UUID characteristics Array.<Object> 是 characteristics列表 结构属性 类型 默认值 必填 说明 uuid String 是 characteristic 的 UUID properties Object 否 特征支持的操作 结构属性 类型 默认值 必填 说明 write Boolean false 否 写 writeNoResponse Boolean false 否 无回复写 read Boolean false 否 读 notify Boolean false 否 订阅 indicate Boolean false 否 回包 permission Object 否 特征权限 结构属性 类型 默认值 必填 说明 readable Boolean false 否 可读 writeable Boolean false 否 可写 readEncryptionRequired Boolean false 否 加密读请求 writeEncryptionRequired Boolean false 否 加密写请求 value ArrayBuffer 否 特征对应的二进制值 descriptors Array.<Object> 否 描述符数据 结构属性 类型 默认值 必填 说明 uuid String 是 Descriptor 的 UUID permission Object 否 描述符的权限 结构属性 类型 默认值 必填 说明 write Boolean false 否 写 read Boolean false 否 读 value ArrayBuffer 否 描述符数据 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | uuid | String |  | 是 | 蓝牙服务的 UUID |  | characteristics | Array.<Object> |  | 是 | characteristics列表 |  | 结构属性 类型 默认值 必填 说明 uuid String 是 characteristic 的 UUID properties Object 否 特征支持的操作 结构属性 类型 默认值 必填 说明 write Boolean false 否 写 writeNoResponse Boolean false 否 无回复写 read Boolean false 否 读 notify Boolean false 否 订阅 indicate Boolean false 否 回包 permission Object 否 特征权限 结构属性 类型 默认值 必填 说明 readable Boolean false 否 可读 writeable Boolean false 否 可写 readEncryptionRequired Boolean false 否 加密读请求 writeEncryptionRequired Boolean false 否 加密写请求 value ArrayBuffer 否 特征对应的二进制值 descriptors Array.<Object> 否 描述符数据 结构属性 类型 默认值 必填 说明 uuid String 是 Descriptor 的 UUID permission Object 否 描述符的权限 结构属性 类型 默认值 必填 说明 write Boolean false 否 写 read Boolean false 否 读 value ArrayBuffer 否 描述符数据 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | uuid | String |  | 是 | characteristic 的 UUID |  | properties | Object |  | 否 | 特征支持的操作 |  | 结构属性 类型 默认值 必填 说明 write Boolean false 否 写 writeNoResponse Boolean false 否 无回复写 read Boolean false 否 读 notify Boolean false 否 订阅 indicate Boolean false 否 回包 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | write | Boolean | false | 否 | 写 |  | writeNoResponse | Boolean | false | 否 | 无回复写 |  | read | Boolean | false | 否 | 读 |  | notify | Boolean | false | 否 | 订阅 |  | indicate | Boolean | false | 否 | 回包 |  | permission | Object |  | 否 | 特征权限 |  | 结构属性 类型 默认值 必填 说明 readable Boolean false 否 可读 writeable Boolean false 否 可写 readEncryptionRequired Boolean false 否 加密读请求 writeEncryptionRequired Boolean false 否 加密写请求 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | readable | Boolean | false | 否 | 可读 |  | writeable | Boolean | false | 否 | 可写 |  | readEncryptionRequired | Boolean | false | 否 | 加密读请求 |  | writeEncryptionRequired | Boolean | false | 否 | 加密写请求 |  | value | ArrayBuffer |  | 否 | 特征对应的二进制值 |  | descriptors | Array.<Object> |  | 否 | 描述符数据 |  | 结构属性 类型 默认值 必填 说明 uuid String 是 Descriptor 的 UUID permission Object 否 描述符的权限 结构属性 类型 默认值 必填 说明 write Boolean false 否 写 read Boolean false 否 读 value ArrayBuffer 否 描述符数据 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | uuid | String |  | 是 | Descriptor 的 UUID |  | permission | Object |  | 否 | 描述符的权限 |  | 结构属性 类型 默认值 必填 说明 write Boolean false 否 写 read Boolean false 否 读 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | write | Boolean | false | 否 | 写 |  | read | Boolean | false | 否 | 读 |  | value | ArrayBuffer |  | 否 | 描述符数据 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | uuid | String |  | 是 | 蓝牙服务的 UUID |
|  | characteristics | Array.<Object> |  | 是 | characteristics列表 |
|  | 结构属性 类型 默认值 必填 说明 uuid String 是 characteristic 的 UUID properties Object 否 特征支持的操作 结构属性 类型 默认值 必填 说明 write Boolean false 否 写 writeNoResponse Boolean false 否 无回复写 read Boolean false 否 读 notify Boolean false 否 订阅 indicate Boolean false 否 回包 permission Object 否 特征权限 结构属性 类型 默认值 必填 说明 readable Boolean false 否 可读 writeable Boolean false 否 可写 readEncryptionRequired Boolean false 否 加密读请求 writeEncryptionRequired Boolean false 否 加密写请求 value ArrayBuffer 否 特征对应的二进制值 descriptors Array.<Object> 否 描述符数据 结构属性 类型 默认值 必填 说明 uuid String 是 Descriptor 的 UUID permission Object 否 描述符的权限 结构属性 类型 默认值 必填 说明 write Boolean false 否 写 read Boolean false 否 读 value ArrayBuffer 否 描述符数据 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | uuid | String |  | 是 | characteristic 的 UUID |  | properties | Object |  | 否 | 特征支持的操作 |  | 结构属性 类型 默认值 必填 说明 write Boolean false 否 写 writeNoResponse Boolean false 否 无回复写 read Boolean false 否 读 notify Boolean false 否 订阅 indicate Boolean false 否 回包 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | write | Boolean | false | 否 | 写 |  | writeNoResponse | Boolean | false | 否 | 无回复写 |  | read | Boolean | false | 否 | 读 |  | notify | Boolean | false | 否 | 订阅 |  | indicate | Boolean | false | 否 | 回包 |  | permission | Object |  | 否 | 特征权限 |  | 结构属性 类型 默认值 必填 说明 readable Boolean false 否 可读 writeable Boolean false 否 可写 readEncryptionRequired Boolean false 否 加密读请求 writeEncryptionRequired Boolean false 否 加密写请求 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | readable | Boolean | false | 否 | 可读 |  | writeable | Boolean | false | 否 | 可写 |  | readEncryptionRequired | Boolean | false | 否 | 加密读请求 |  | writeEncryptionRequired | Boolean | false | 否 | 加密写请求 |  | value | ArrayBuffer |  | 否 | 特征对应的二进制值 |  | descriptors | Array.<Object> |  | 否 | 描述符数据 |  | 结构属性 类型 默认值 必填 说明 uuid String 是 Descriptor 的 UUID permission Object 否 描述符的权限 结构属性 类型 默认值 必填 说明 write Boolean false 否 写 read Boolean false 否 读 value ArrayBuffer 否 描述符数据 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | uuid | String |  | 是 | Descriptor 的 UUID |  | permission | Object |  | 否 | 描述符的权限 |  | 结构属性 类型 默认值 必填 说明 write Boolean false 否 写 read Boolean false 否 读 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | write | Boolean | false | 否 | 写 |  | read | Boolean | false | 否 | 读 |  | value | ArrayBuffer |  | 否 | 描述符数据 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | uuid | String |  | 是 | characteristic 的 UUID |
|  | properties | Object |  | 否 | 特征支持的操作 |
|  | 结构属性 类型 默认值 必填 说明 write Boolean false 否 写 writeNoResponse Boolean false 否 无回复写 read Boolean false 否 读 notify Boolean false 否 订阅 indicate Boolean false 否 回包 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | write | Boolean | false | 否 | 写 |  | writeNoResponse | Boolean | false | 否 | 无回复写 |  | read | Boolean | false | 否 | 读 |  | notify | Boolean | false | 否 | 订阅 |  | indicate | Boolean | false | 否 | 回包 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | write | Boolean | false | 否 | 写 |
|  | writeNoResponse | Boolean | false | 否 | 无回复写 |
|  | read | Boolean | false | 否 | 读 |
|  | notify | Boolean | false | 否 | 订阅 |
|  | indicate | Boolean | false | 否 | 回包 |
|  | permission | Object |  | 否 | 特征权限 |
|  | 结构属性 类型 默认值 必填 说明 readable Boolean false 否 可读 writeable Boolean false 否 可写 readEncryptionRequired Boolean false 否 加密读请求 writeEncryptionRequired Boolean false 否 加密写请求 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | readable | Boolean | false | 否 | 可读 |  | writeable | Boolean | false | 否 | 可写 |  | readEncryptionRequired | Boolean | false | 否 | 加密读请求 |  | writeEncryptionRequired | Boolean | false | 否 | 加密写请求 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | readable | Boolean | false | 否 | 可读 |
|  | writeable | Boolean | false | 否 | 可写 |
|  | readEncryptionRequired | Boolean | false | 否 | 加密读请求 |
|  | writeEncryptionRequired | Boolean | false | 否 | 加密写请求 |
|  | value | ArrayBuffer |  | 否 | 特征对应的二进制值 |
|  | descriptors | Array.<Object> |  | 否 | 描述符数据 |
|  | 结构属性 类型 默认值 必填 说明 uuid String 是 Descriptor 的 UUID permission Object 否 描述符的权限 结构属性 类型 默认值 必填 说明 write Boolean false 否 写 read Boolean false 否 读 value ArrayBuffer 否 描述符数据 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | uuid | String |  | 是 | Descriptor 的 UUID |  | permission | Object |  | 否 | 描述符的权限 |  | 结构属性 类型 默认值 必填 说明 write Boolean false 否 写 read Boolean false 否 读 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | write | Boolean | false | 否 | 写 |  | read | Boolean | false | 否 | 读 |  | value | ArrayBuffer |  | 否 | 描述符数据 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | uuid | String |  | 是 | Descriptor 的 UUID |
|  | permission | Object |  | 否 | 描述符的权限 |
|  | 结构属性 类型 默认值 必填 说明 write Boolean false 否 写 read Boolean false 否 读 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | write | Boolean | false | 否 | 写 |  | read | Boolean | false | 否 | 读 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | write | Boolean | false | 否 | 写 |
|  | read | Boolean | false | 否 | 读 |
|  | value | ArrayBuffer |  | 否 | 描述符数据 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### BLEPeripheralServer.onCharacteristicReadRequest(function listener)

基础库 2.10.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| serviceId | String | 蓝牙特征对应服务的 UUID |
| characteristicId | String | 蓝牙特征的 UUID |
| callbackId | Number | 唯一标识码，调用 writeCharacteristicValue 时使用 |


### BLEPeripheralServer.onCharacteristicSubscribed(function listener)

基础库 2.13.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| serviceId | String | 蓝牙特征对应服务的 UUID |
| characteristicId | String | 蓝牙特征的 UUID |


### BLEPeripheralServer.onCharacteristicUnsubscribed(function listener)

基础库 2.13.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| serviceId | String | 蓝牙特征对应服务的 UUID |
| characteristicId | String | 蓝牙特征的 UUID |


### BLEPeripheralServer.onCharacteristicWriteRequest(function listener)

基础库 2.10.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| serviceId | String | 蓝牙特征对应服务的 UUID |
| characteristicId | String | 蓝牙特征的 UUID |
| callbackId | Number | 唯一标识码，调用 writeCharacteristicValue 时使用 |
| value | ArrayBuffer | 请求写入特征的二进制数据值 |


### BLEPeripheralServer.removeService(Object object)

基础库 2.10.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| serviceId | String |  | 是 | service 的 UUID |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### BLEPeripheralServer.startAdvertising(Object Object)

基础库 2.10.3 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | advertiseRequest | Object |  | 是 | 广播自定义参数 |
|  | 结构属性 类型 默认值 必填 说明 最低版本 connectable Boolean true 否 当前设备是否可连接 deviceName String 否 广播中 deviceName 字段，默认为空 serviceUuids Array.<String> 否 要广播的服务 UUID 列表。使用 16/32 位 UUID 时请参考注意事项。 manufacturerData Array.<Object> 否 广播的制造商信息。仅安卓支持，iOS 因系统限制无法定制。 结构属性 类型 默认值 必填 说明 manufacturerId String 是 制造商ID，0x 开头的十六进制 manufacturerSpecificData ArrayBuffer 否 制造商信息 beacon Object 否 以 beacon 设备形式广播的参数。 2.20.1 结构属性 类型 默认值 必填 说明 uuid String 是 Beacon 设备广播的 UUID major Number 是 Beacon 设备的主 ID minor Number 是 Beacon 设备的次 ID measuredPower Number 否 用于判断距离设备 1 米时 RSSI 大小的参考值 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | connectable | Boolean | true | 否 | 当前设备是否可连接 |  |  | deviceName | String |  | 否 | 广播中 deviceName 字段，默认为空 |  |  | serviceUuids | Array.<String> |  | 否 | 要广播的服务 UUID 列表。使用 16/32 位 UUID 时请参考注意事项。 |  |  | manufacturerData | Array.<Object> |  | 否 | 广播的制造商信息。仅安卓支持，iOS 因系统限制无法定制。 |  |  | 结构属性 类型 默认值 必填 说明 manufacturerId String 是 制造商ID，0x 开头的十六进制 manufacturerSpecificData ArrayBuffer 否 制造商信息 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | manufacturerId | String |  | 是 | 制造商ID，0x 开头的十六进制 |  | manufacturerSpecificData | ArrayBuffer |  | 否 | 制造商信息 |  | beacon | Object |  | 否 | 以 beacon 设备形式广播的参数。 | 2.20.1 |  | 结构属性 类型 默认值 必填 说明 uuid String 是 Beacon 设备广播的 UUID major Number 是 Beacon 设备的主 ID minor Number 是 Beacon 设备的次 ID measuredPower Number 否 用于判断距离设备 1 米时 RSSI 大小的参考值 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | uuid | String |  | 是 | Beacon 设备广播的 UUID |  | major | Number |  | 是 | Beacon 设备的主 ID |  | minor | Number |  | 是 | Beacon 设备的次 ID |  | measuredPower | Number |  | 否 | 用于判断距离设备 1 米时 RSSI 大小的参考值 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
|  | connectable | Boolean | true | 否 | 当前设备是否可连接 |  |
|  | deviceName | String |  | 否 | 广播中 deviceName 字段，默认为空 |  |
|  | serviceUuids | Array.<String> |  | 否 | 要广播的服务 UUID 列表。使用 16/32 位 UUID 时请参考注意事项。 |  |
|  | manufacturerData | Array.<Object> |  | 否 | 广播的制造商信息。仅安卓支持，iOS 因系统限制无法定制。 |  |
|  | 结构属性 类型 默认值 必填 说明 manufacturerId String 是 制造商ID，0x 开头的十六进制 manufacturerSpecificData ArrayBuffer 否 制造商信息 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | manufacturerId | String |  | 是 | 制造商ID，0x 开头的十六进制 |  | manufacturerSpecificData | ArrayBuffer |  | 否 | 制造商信息 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | manufacturerId | String |  | 是 | 制造商ID，0x 开头的十六进制 |
|  | manufacturerSpecificData | ArrayBuffer |  | 否 | 制造商信息 |
|  | beacon | Object |  | 否 | 以 beacon 设备形式广播的参数。 | 2.20.1 |
|  | 结构属性 类型 默认值 必填 说明 uuid String 是 Beacon 设备广播的 UUID major Number 是 Beacon 设备的主 ID minor Number 是 Beacon 设备的次 ID measuredPower Number 否 用于判断距离设备 1 米时 RSSI 大小的参考值 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | uuid | String |  | 是 | Beacon 设备广播的 UUID |  | major | Number |  | 是 | Beacon 设备的主 ID |  | minor | Number |  | 是 | Beacon 设备的次 ID |  | measuredPower | Number |  | 否 | 用于判断距离设备 1 米时 RSSI 大小的参考值 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | uuid | String |  | 是 | Beacon 设备广播的 UUID |
|  | major | Number |  | 是 | Beacon 设备的主 ID |
|  | minor | Number |  | 是 | Beacon 设备的次 ID |
|  | measuredPower | Number |  | 否 | 用于判断距离设备 1 米时 RSSI 大小的参考值 |
|  | powerLevel | String | medium | 否 | 广播功率 |
|  | 合法值 说明 low 功率低 medium 功率适中 high 功率高 | 合法值 | 说明 | low | 功率低 | medium | 功率适中 | high | 功率高 |
| 合法值 | 说明 |
| low | 功率低 |
| medium | 功率适中 |
| high | 功率高 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### BLEPeripheralServer.stopAdvertising(Object object)

基础库 2.10.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### BLEPeripheralServer.writeCharacteristicValue(Object Object)

基础库 2.10.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| serviceId | String |  | 是 | 蓝牙特征对应服务的 UUID |
| characteristicId | String |  | 是 | 蓝牙特征的 UUID |
| value | ArrayBuffer |  | 是 | characteristic 对应的二进制值 |
| needNotify | Boolean |  | 是 | 是否需要通知主机 value 已更新 |
| callbackId | Number |  | 否 | 可选，处理回包时使用 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Camera.onCameraFrame(function callback)

基础库 2.9.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| width | number | 图像数据矩形的宽度 |
| height | number | 图像数据矩形的高度 |
| data | ArrayBuffer | 图像像素点数据，一维数组，每四项表示一个像素点的 rgba |


### Promise Camera.setZoom(Object args)

基础库 3.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| zoom | number |  | 是 | 缩放级别，范围 [1, maxZoom]。zoom 可取小数，精确到小数后一位。maxZoom 可在 bindinitdone 返回值中获取。 |


### RenderingContext Canvas.getContext(string contextType, Object contextAttributes)

微信 鸿蒙 OS 版：支持

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| 2d | 2d 绘图上下文 |  |
| webgl | webgl 绘图上下文 |  |
| webgl2 | webgl2 绘图上下文 | 2.24.0 |


### Canvas.toTempFilePath(Object object)

以 Promise 风格 调用：不支持

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | x | number | 0 | 否 | 截取 canvas 的左上角横坐标 |
|  | y | number | 0 | 否 | 截取 canvas 的左上角纵坐标 |
|  | width | number | canvas 的宽度 | 否 | 截取 canvas 的宽度 |
|  | height | number | canvas 的高度 | 否 | 截取 canvas 的高度 |
|  | destWidth | number | canvas 的宽度 | 否 | 目标文件的宽度，会将截取的部分拉伸或压缩至该数值 |
|  | destHeight | number | canvas 的高度 | 否 | 目标文件的高度，会将截取的部分拉伸或压缩至该数值 |
|  | fileType | string | png | 否 | 目标文件的类型 |
|  | 合法值 说明 jpg jpg 文件 png png 文件 | 合法值 | 说明 | jpg | jpg 文件 | png | png 文件 |
| 合法值 | 说明 |
| jpg | jpg 文件 |
| png | png 文件 |
|  | quality | number | 1.0 | 否 | jpg图片的质量，仅当 fileType 为 jpg 时有效。取值范围为 0.0（最低）- 1.0（最高），不含 0。不在范围内时当作 1.0 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### string Canvas.toTempFilePathSync(Object object)

以 Promise 风格 调用：不支持

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | x | number | 0 | 否 | 截取 canvas 的左上角横坐标 |
|  | y | number | 0 | 否 | 截取 canvas 的左上角纵坐标 |
|  | width | number | canvas 的宽度 | 否 | 截取 canvas 的宽度 |
|  | height | number | canvas 的高度 | 否 | 截取 canvas 的高度 |
|  | destWidth | number | canvas 的宽度 | 否 | 目标文件的宽度，会将截取的部分拉伸或压缩至该数值 |
|  | destHeight | number | canvas 的高度 | 否 | 目标文件的高度，会将截取的部分拉伸或压缩至该数值 |
|  | fileType | string | png | 否 | 目标文件的类型 |
|  | 合法值 说明 jpg jpg 文件 png png 文件 | 合法值 | 说明 | jpg | jpg 文件 | png | png 文件 |
| 合法值 | 说明 |
| jpg | jpg 文件 |
| png | png 文件 |
|  | quality | number | 1.0 | 否 | jpg图片的质量，仅当 fileType 为 jpg 时有效。取值范围为 0.0（最低）- 1.0（最高），不含 0。不在范围内时当作 1.0 |


### CustomAd

原生模板广告组件。原生模板广告组件是一个原生组件，层级比普通组件高。原生模板广告组件默认是隐藏的，需要调用 CustomAd.show() 将其显示。如果宽度可配置，原生模板广告会根据开发者设置的宽度进行等比缩放，部分模板缩放后的尺寸会通过 CustomAd.onResize() 事件中提供。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| left | number | 原生模板广告组件的左上角横坐标 |
| top | number | 原生模板广告组件的左上角纵坐标 |
| fixed | boolean | (只对小程序适用) 原生模板广告组件是否固定屏幕位置（不跟随屏幕滚动） |


### CustomAd.onError(function listener)

# 功能描述

|  | 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- |
|  | errMsg | string | 错误信息 |  |
|  | errCode | number | 错误码 | 2.2.2 |
|  | 合法值 说明 1000 后端接口调用失败 1001 参数错误 1002 广告单元无效 1003 内部错误 1004 无合适的广告 1005 广告组件审核中 1006 广告组件被驳回 1007 广告组件被封禁 1008 广告单元已关闭 2001 模板渲染错误 2002 模板为空 2003 模板解析失败 2004 触发频率限制 2005 触发频率限制 | 合法值 | 说明 | 1000 | 后端接口调用失败 | 1001 | 参数错误 | 1002 | 广告单元无效 | 1003 | 内部错误 | 1004 | 无合适的广告 | 1005 | 广告组件审核中 | 1006 | 广告组件被驳回 | 1007 | 广告组件被封禁 | 1008 | 广告单元已关闭 | 2001 | 模板渲染错误 | 2002 | 模板为空 | 2003 | 模板解析失败 | 2004 | 触发频率限制 | 2005 | 触发频率限制 |
| 合法值 | 说明 |
| 1000 | 后端接口调用失败 |
| 1001 | 参数错误 |
| 1002 | 广告单元无效 |
| 1003 | 内部错误 |
| 1004 | 无合适的广告 |
| 1005 | 广告组件审核中 |
| 1006 | 广告组件被驳回 |
| 1007 | 广告组件被封禁 |
| 1008 | 广告单元已关闭 |
| 2001 | 模板渲染错误 |
| 2002 | 模板为空 |
| 2003 | 模板解析失败 |
| 2004 | 触发频率限制 |
| 2005 | 触发频率限制 |


### CustomAd.onResize(function listener)

# 功能描述

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| width | number | 缩放后的宽度 |
| height | number | 缩放后的高度 |


### DownloadTask.onHeadersReceived(function listener)

基础库 2.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| header | Object | 开发者服务器返回的 HTTP Response Header |


### DownloadTask.onProgressUpdate(function listener)

基础库 1.4.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| progress | number | 下载进度百分比 |
| totalBytesWritten | number | 已经下载的数据长度，单位 Bytes |
| totalBytesExpectedToWrite | number | 预期需要下载的数据总长度，单位 Bytes |


### FeedbackButton

用户点击后打开意见反馈页面的按钮

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| text | 可以设置背景色和文本的按钮 |  |
| image | 只能设置背景贴图的按钮，背景贴图会直接拉伸到按钮的宽高 |  |


### FileSystemManager.access(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| path | string |  | 是 | 要判断是否存在的文件/目录路径 (本地路径) |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### FileSystemManager.accessSync(string path)

以 Promise 风格 调用：不支持

| 错误码 | 错误信息 | 说明 |
| --- | --- | --- |
| 1300001 | operation not permitted | 操作不被允许（例如，filePath 预期传入一个文件而实际传入一个目录） |
| 1300002 | no such file or directory ${path} | 文件/目录不存在，或者目标文件路径的上层目录不存在 |
| 1300005 | Input/output error | 输入输出流不可用 |
| 1300009 | bad file descriptor | 无效的文件描述符 |
| 1300013 | permission denied | 权限错误，文件是只读或只写 |
| 1300014 | Path permission denied | 传入的路径没有权限 |
| 1300020 | not a directory | dirPath 指定路径不是目录，常见于指定的写入路径的上级路径为一个文件的情况 |
| 1300021 | Is a directory | 指定路径是一个目录 |
| 1300022 | Invalid argument | 无效参数，可以检查length或offset是否越界 |
| 1300036 | File name too long | 文件名过长 |
| 1300066 | directory not empty | 目录不为空 |
| 1300201 | system error | 系统接口调用失败 |
| 1300202 | the maximum size of the file storage limit is exceeded | 存储空间不足，或文件大小超出上限（上限100M） |
| 1300203 | base64 encode error | 字符编码转换失败（例如 base64 格式错误） |
| 1300300 | sdcard not mounted | android sdcard 挂载失败 |
| 1300301 | unable to open as fileType | 无法以fileType打开文件 |
| 1301000 | permission denied, cannot access file path | 目标路径无访问权限（usr目录） |
| 1301002 | data to write is empty | 写入数据为空 |
| 1301003 | illegal operation on a directory | 不可对目录进行此操作（例如，指定的 filePath 是一个已经存在的目录） |
| 1301004 | illegal operation on a package directory | 不可对代码包目录进行此操作 |
| 1301005 | file already exists ${dirPath} | 已有同名文件或目录 |
| 1301006 | value of length is out of range | 传入的 length 不合法 |
| 1301007 | value of offset is out of range | 传入的 offset 不合法 |
| 1301009 | value of position is out of range | position值越界 |
| 1301100 | store directory is empty | store目录为空 |
| 1301102 | unzip open file fail | 压缩文件打开失败 |
| 1301103 | unzip entry fail | 解压单个文件失败 |
| 1301104 | unzip fail | 解压失败 |
| 1301111 | brotli decompress fail | brotli解压失败（例如，指定的 compressionAlgorithm 与文件实际压缩格式不符） |
| 1301112 | tempFilePath file not exist | 指定的 tempFilePath 找不到文件 |
| 1302001 | fail permission denied | 指定的 fd 路径没有读权限/没有写权限 |
| 1302002 | excced max concurrent fd limit | fd数量已达上限 |
| 1302003 | invalid flag | 无效的flag |
| 1302004 | permission denied when open using flag | 无法使用flag标志打开文件 |
| 1302005 | array buffer does not exist | 未传入arrayBuffer |
| 1302100 | array buffer is readonly | arrayBuffer只读 |


### FileSystemManager.appendFile(Object object)

基础库 2.1.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | filePath | string |  | 是 | 要追加内容的文件路径 (本地路径) |
|  | data | string/ArrayBuffer |  | 是 | 要追加的文本或二进制数据 |
|  | encoding | string | utf8 | 否 | 指定写入文件的字符编码 |
|  | 合法值 说明 ascii base64 binary hex ucs2 以小端序读取 ucs-2 以小端序读取 utf16le 以小端序读取 utf-16le 以小端序读取 utf-8 utf8 latin1 | 合法值 | 说明 | ascii |  | base64 |  | binary |  | hex |  | ucs2 | 以小端序读取 | ucs-2 | 以小端序读取 | utf16le | 以小端序读取 | utf-16le | 以小端序读取 | utf-8 |  | utf8 |  | latin1 |  |
| 合法值 | 说明 |
| ascii |  |
| base64 |  |
| binary |  |
| hex |  |
| ucs2 | 以小端序读取 |
| ucs-2 | 以小端序读取 |
| utf16le | 以小端序读取 |
| utf-16le | 以小端序读取 |
| utf-8 |  |
| utf8 |  |
| latin1 |  |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### FileSystemManager.appendFileSync(string filePath, string|ArrayBuffer data, string encoding)

基础库 2.1.0 开始支持，低版本需做兼容处理。

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| ascii |  |  |
| base64 |  |  |
| binary |  |  |
| hex |  |  |
| ucs2 | 以小端序读取 |  |
| ucs-2 | 以小端序读取 |  |
| utf16le | 以小端序读取 |  |
| utf-16le | 以小端序读取 |  |
| utf-8 |  |  |
| utf8 |  |  |
| latin1 |  |  |


### FileSystemManager.close(Object object)

基础库 2.16.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| fd | string |  | 是 | 需要被关闭的文件描述符。fd 通过 FileSystemManager.open 或 FileSystemManager.openSync 接口获得 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### undefined FileSystemManager.closeSync(Object object)

基础库 2.16.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| fd | string |  | 是 | 需要被关闭的文件描述符。fd 通过 FileSystemManager.open 或 FileSystemManager.openSync 接口获得 |


### FileSystemManager.copyFile(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| srcPath | string |  | 是 | 源文件路径，支持本地路径 |
| destPath | string |  | 是 | 目标文件路径，支持本地路径 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### FileSystemManager.copyFileSync(string srcPath, string destPath)

以 Promise 风格 调用：不支持

| 错误码 | 错误信息 | 说明 |
| --- | --- | --- |
| 1300001 | operation not permitted | 操作不被允许（例如，filePath 预期传入一个文件而实际传入一个目录） |
| 1300002 | no such file or directory ${path} | 文件/目录不存在，或者目标文件路径的上层目录不存在 |
| 1300005 | Input/output error | 输入输出流不可用 |
| 1300009 | bad file descriptor | 无效的文件描述符 |
| 1300013 | permission denied | 权限错误，文件是只读或只写 |
| 1300014 | Path permission denied | 传入的路径没有权限 |
| 1300020 | not a directory | dirPath 指定路径不是目录，常见于指定的写入路径的上级路径为一个文件的情况 |
| 1300021 | Is a directory | 指定路径是一个目录 |
| 1300022 | Invalid argument | 无效参数，可以检查length或offset是否越界 |
| 1300036 | File name too long | 文件名过长 |
| 1300066 | directory not empty | 目录不为空 |
| 1300201 | system error | 系统接口调用失败 |
| 1300202 | the maximum size of the file storage limit is exceeded | 存储空间不足，或文件大小超出上限（上限100M） |
| 1300203 | base64 encode error | 字符编码转换失败（例如 base64 格式错误） |
| 1300300 | sdcard not mounted | android sdcard 挂载失败 |
| 1300301 | unable to open as fileType | 无法以fileType打开文件 |
| 1301000 | permission denied, cannot access file path | 目标路径无访问权限（usr目录） |
| 1301002 | data to write is empty | 写入数据为空 |
| 1301003 | illegal operation on a directory | 不可对目录进行此操作（例如，指定的 filePath 是一个已经存在的目录） |
| 1301004 | illegal operation on a package directory | 不可对代码包目录进行此操作 |
| 1301005 | file already exists ${dirPath} | 已有同名文件或目录 |
| 1301006 | value of length is out of range | 传入的 length 不合法 |
| 1301007 | value of offset is out of range | 传入的 offset 不合法 |
| 1301009 | value of position is out of range | position值越界 |
| 1301100 | store directory is empty | store目录为空 |
| 1301102 | unzip open file fail | 压缩文件打开失败 |
| 1301103 | unzip entry fail | 解压单个文件失败 |
| 1301104 | unzip fail | 解压失败 |
| 1301111 | brotli decompress fail | brotli解压失败（例如，指定的 compressionAlgorithm 与文件实际压缩格式不符） |
| 1301112 | tempFilePath file not exist | 指定的 tempFilePath 找不到文件 |
| 1302001 | fail permission denied | 指定的 fd 路径没有读权限/没有写权限 |
| 1302002 | excced max concurrent fd limit | fd数量已达上限 |
| 1302003 | invalid flag | 无效的flag |
| 1302004 | permission denied when open using flag | 无法使用flag标志打开文件 |
| 1302005 | array buffer does not exist | 未传入arrayBuffer |
| 1302100 | array buffer is readonly | arrayBuffer只读 |


### FileSystemManager.fstat(Object object)

基础库 2.16.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| fd | string |  | 是 | 文件描述符。fd 通过 FileSystemManager.open 或 FileSystemManager.openSync 接口获得 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Stats FileSystemManager.fstatSync(Object object)

基础库 2.16.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| fd | string |  | 是 | 文件描述符。fd 通过 FileSystemManager.open 或 FileSystemManager.openSync 接口获得 |


### FileSystemManager.ftruncate(Object object)

基础库 2.16.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| fd | string |  | 是 | 文件描述符。fd 通过 FileSystemManager.open 或 FileSystemManager.openSync 接口获得 |
| length | number |  | 是 | 截断位置，默认0。如果 length 小于文件长度（单位：字节），则只有前面 length 个字节会保留在文件中，其余内容会被删除；如果 length 大于文件长度，则会对其进行扩展，并且扩展部分将填充空字节（'\0'） |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### undefined FileSystemManager.ftruncateSync(Object object)

基础库 2.16.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| fd | string |  | 是 | 文件描述符。fd 通过 FileSystemManager.open 或 FileSystemManager.openSync 接口获得 |
| length | number |  | 是 | 截断位置，默认0。如果 length 小于文件长度（单位：字节），则只有前面 length 个字节会保留在文件中，其余内容会被删除；如果 length 大于文件长度，则会对其进行扩展，并且扩展部分将填充空字节（'\0'） |


### FileSystemManager.getFileInfo(Object object)

以 Promise 风格 调用：不支持

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | filePath | string |  | 是 | 要读取的文件路径 (本地路径) |
|  | digestAlgorithm | string | md5 | 否 | 计算文件摘要的算法 |
|  | 合法值 说明 md5 md5 算法 sha1 sha1 算法 sha256 sha256 算法 | 合法值 | 说明 | md5 | md5 算法 | sha1 | sha1 算法 | sha256 | sha256 算法 |
| 合法值 | 说明 |
| md5 | md5 算法 |
| sha1 | sha1 算法 |
| sha256 | sha256 算法 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### FileSystemManager.getSavedFileList(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### FileSystemManager.mkdir(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| dirPath | string |  | 是 | 创建的目录路径 (本地路径) |  |
| recursive | boolean | false | 否 | 是否在递归创建该目录的上级目录后再创建该目录。如果对应的上级目录已经存在，则不创建该上级目录。如 dirPath 为 a/b/c/d 且 recursive 为 true，将创建 a 目录，再在 a 目录下创建 b 目录，以此类推直至创建 a/b/c 目录下的 d 目录。 | 2.3.0 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### FileSystemManager.mkdirSync(string dirPath, boolean recursive)

以 Promise 风格 调用：不支持

| 错误码 | 错误信息 | 说明 |
| --- | --- | --- |
| 1300001 | operation not permitted | 操作不被允许（例如，filePath 预期传入一个文件而实际传入一个目录） |
| 1300002 | no such file or directory ${path} | 文件/目录不存在，或者目标文件路径的上层目录不存在 |
| 1300005 | Input/output error | 输入输出流不可用 |
| 1300009 | bad file descriptor | 无效的文件描述符 |
| 1300013 | permission denied | 权限错误，文件是只读或只写 |
| 1300014 | Path permission denied | 传入的路径没有权限 |
| 1300020 | not a directory | dirPath 指定路径不是目录，常见于指定的写入路径的上级路径为一个文件的情况 |
| 1300021 | Is a directory | 指定路径是一个目录 |
| 1300022 | Invalid argument | 无效参数，可以检查length或offset是否越界 |
| 1300036 | File name too long | 文件名过长 |
| 1300066 | directory not empty | 目录不为空 |
| 1300201 | system error | 系统接口调用失败 |
| 1300202 | the maximum size of the file storage limit is exceeded | 存储空间不足，或文件大小超出上限（上限100M） |
| 1300203 | base64 encode error | 字符编码转换失败（例如 base64 格式错误） |
| 1300300 | sdcard not mounted | android sdcard 挂载失败 |
| 1300301 | unable to open as fileType | 无法以fileType打开文件 |
| 1301000 | permission denied, cannot access file path | 目标路径无访问权限（usr目录） |
| 1301002 | data to write is empty | 写入数据为空 |
| 1301003 | illegal operation on a directory | 不可对目录进行此操作（例如，指定的 filePath 是一个已经存在的目录） |
| 1301004 | illegal operation on a package directory | 不可对代码包目录进行此操作 |
| 1301005 | file already exists ${dirPath} | 已有同名文件或目录 |
| 1301006 | value of length is out of range | 传入的 length 不合法 |
| 1301007 | value of offset is out of range | 传入的 offset 不合法 |
| 1301009 | value of position is out of range | position值越界 |
| 1301100 | store directory is empty | store目录为空 |
| 1301102 | unzip open file fail | 压缩文件打开失败 |
| 1301103 | unzip entry fail | 解压单个文件失败 |
| 1301104 | unzip fail | 解压失败 |
| 1301111 | brotli decompress fail | brotli解压失败（例如，指定的 compressionAlgorithm 与文件实际压缩格式不符） |
| 1301112 | tempFilePath file not exist | 指定的 tempFilePath 找不到文件 |
| 1302001 | fail permission denied | 指定的 fd 路径没有读权限/没有写权限 |
| 1302002 | excced max concurrent fd limit | fd数量已达上限 |
| 1302003 | invalid flag | 无效的flag |
| 1302004 | permission denied when open using flag | 无法使用flag标志打开文件 |
| 1302005 | array buffer does not exist | 未传入arrayBuffer |
| 1302100 | array buffer is readonly | arrayBuffer只读 |


### FileSystemManager.open(Object object)

基础库 2.16.1 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | filePath | string |  | 是 | 文件路径 (本地路径) |
|  | flag | string | r | 否 | 文件系统标志，默认值: 'r' |
|  | 合法值 说明 a 打开文件用于追加。 如果文件不存在，则创建该文件 ax 类似于 'a'，但如果路径存在，则失败 a+ 打开文件用于读取和追加。 如果文件不存在，则创建该文件 ax+ 类似于 'a+'，但如果路径存在，则失败 as 打开文件用于追加（在同步模式中）。 如果文件不存在，则创建该文件 as+ 打开文件用于读取和追加（在同步模式中）。 如果文件不存在，则创建该文件 r 打开文件用于读取。 如果文件不存在，则会发生异常 r+ 打开文件用于读取和写入。 如果文件不存在，则会发生异常 w 打开文件用于写入。 如果文件不存在则创建文件，如果文件存在则截断文件 wx 类似于 'w'，但如果路径存在，则失败 w+ 打开文件用于读取和写入。 如果文件不存在则创建文件，如果文件存在则截断文件 wx+ 类似于 'w+'，但如果路径存在，则失败 | 合法值 | 说明 | a | 打开文件用于追加。 如果文件不存在，则创建该文件 | ax | 类似于 'a'，但如果路径存在，则失败 | a+ | 打开文件用于读取和追加。 如果文件不存在，则创建该文件 | ax+ | 类似于 'a+'，但如果路径存在，则失败 | as | 打开文件用于追加（在同步模式中）。 如果文件不存在，则创建该文件 | as+ | 打开文件用于读取和追加（在同步模式中）。 如果文件不存在，则创建该文件 | r | 打开文件用于读取。 如果文件不存在，则会发生异常 | r+ | 打开文件用于读取和写入。 如果文件不存在，则会发生异常 | w | 打开文件用于写入。 如果文件不存在则创建文件，如果文件存在则截断文件 | wx | 类似于 'w'，但如果路径存在，则失败 | w+ | 打开文件用于读取和写入。 如果文件不存在则创建文件，如果文件存在则截断文件 | wx+ | 类似于 'w+'，但如果路径存在，则失败 |
| 合法值 | 说明 |
| a | 打开文件用于追加。 如果文件不存在，则创建该文件 |
| ax | 类似于 'a'，但如果路径存在，则失败 |
| a+ | 打开文件用于读取和追加。 如果文件不存在，则创建该文件 |
| ax+ | 类似于 'a+'，但如果路径存在，则失败 |
| as | 打开文件用于追加（在同步模式中）。 如果文件不存在，则创建该文件 |
| as+ | 打开文件用于读取和追加（在同步模式中）。 如果文件不存在，则创建该文件 |
| r | 打开文件用于读取。 如果文件不存在，则会发生异常 |
| r+ | 打开文件用于读取和写入。 如果文件不存在，则会发生异常 |
| w | 打开文件用于写入。 如果文件不存在则创建文件，如果文件存在则截断文件 |
| wx | 类似于 'w'，但如果路径存在，则失败 |
| w+ | 打开文件用于读取和写入。 如果文件不存在则创建文件，如果文件存在则截断文件 |
| wx+ | 类似于 'w+'，但如果路径存在，则失败 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### string FileSystemManager.openSync(Object object)

基础库 2.16.1 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | filePath | string |  | 是 | 文件路径 (本地路径) |
|  | flag | string | r | 否 | 文件系统标志，默认值: 'r' |
|  | 合法值 说明 a 打开文件用于追加。 如果文件不存在，则创建该文件 ax 类似于 'a'，但如果路径存在，则失败 a+ 打开文件用于读取和追加。 如果文件不存在，则创建该文件 ax+ 类似于 'a+'，但如果路径存在，则失败 as 打开文件用于追加（在同步模式中）。 如果文件不存在，则创建该文件 as+ 打开文件用于读取和追加（在同步模式中）。 如果文件不存在，则创建该文件 r 打开文件用于读取。 如果文件不存在，则会发生异常 r+ 打开文件用于读取和写入。 如果文件不存在，则会发生异常 w 打开文件用于写入。 如果文件不存在则创建文件，如果文件存在则截断文件 wx 类似于 'w'，但如果路径存在，则失败 w+ 打开文件用于读取和写入。 如果文件不存在则创建文件，如果文件存在则截断文件 wx+ 类似于 'w+'，但如果路径存在，则失败 | 合法值 | 说明 | a | 打开文件用于追加。 如果文件不存在，则创建该文件 | ax | 类似于 'a'，但如果路径存在，则失败 | a+ | 打开文件用于读取和追加。 如果文件不存在，则创建该文件 | ax+ | 类似于 'a+'，但如果路径存在，则失败 | as | 打开文件用于追加（在同步模式中）。 如果文件不存在，则创建该文件 | as+ | 打开文件用于读取和追加（在同步模式中）。 如果文件不存在，则创建该文件 | r | 打开文件用于读取。 如果文件不存在，则会发生异常 | r+ | 打开文件用于读取和写入。 如果文件不存在，则会发生异常 | w | 打开文件用于写入。 如果文件不存在则创建文件，如果文件存在则截断文件 | wx | 类似于 'w'，但如果路径存在，则失败 | w+ | 打开文件用于读取和写入。 如果文件不存在则创建文件，如果文件存在则截断文件 | wx+ | 类似于 'w+'，但如果路径存在，则失败 |
| 合法值 | 说明 |
| a | 打开文件用于追加。 如果文件不存在，则创建该文件 |
| ax | 类似于 'a'，但如果路径存在，则失败 |
| a+ | 打开文件用于读取和追加。 如果文件不存在，则创建该文件 |
| ax+ | 类似于 'a+'，但如果路径存在，则失败 |
| as | 打开文件用于追加（在同步模式中）。 如果文件不存在，则创建该文件 |
| as+ | 打开文件用于读取和追加（在同步模式中）。 如果文件不存在，则创建该文件 |
| r | 打开文件用于读取。 如果文件不存在，则会发生异常 |
| r+ | 打开文件用于读取和写入。 如果文件不存在，则会发生异常 |
| w | 打开文件用于写入。 如果文件不存在则创建文件，如果文件存在则截断文件 |
| wx | 类似于 'w'，但如果路径存在，则失败 |
| w+ | 打开文件用于读取和写入。 如果文件不存在则创建文件，如果文件存在则截断文件 |
| wx+ | 类似于 'w+'，但如果路径存在，则失败 |


### FileSystemManager.read(Object object)

基础库 2.16.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| fd | string |  | 是 | 文件描述符。fd 通过 FileSystemManager.open 或 FileSystemManager.openSync 接口获得 |
| arrayBuffer | ArrayBuffer |  | 是 | 数据写入的缓冲区，必须是 ArrayBuffer 实例 |
| offset | number | 0 | 否 | 缓冲区中的写入偏移量，默认0 |
| length | number | 0 | 否 | 要从文件中读取的字节数，默认0 |
| position | number |  | 否 | 文件读取的起始位置，如不传或传 null，则会从当前文件指针的位置读取。如果 position 是正整数，则文件指针位置会保持不变并从 position 读取文件。 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### FileSystemManager.readCompressedFile(Object object)

基础库 2.21.1 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | filePath | string |  | 是 | 要读取的文件的路径 (本地用户文件或代码包文件) |
|  | compressionAlgorithm | string |  | 是 | 文件压缩类型，目前仅支持 'br'。 |
|  | 合法值 说明 br brotli压缩文件 | 合法值 | 说明 | br | brotli压缩文件 |
| 合法值 | 说明 |
| br | brotli压缩文件 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### ArrayBuffer FileSystemManager.readCompressedFileSync(Object object)

基础库 2.21.1 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | filePath | string |  | 是 | 要读取的文件的路径 (本地用户文件或代码包文件) |
|  | compressionAlgorithm | string |  | 是 | 文件压缩类型，目前仅支持 'br'。 |
|  | 合法值 说明 br brotli压缩文件 | 合法值 | 说明 | br | brotli压缩文件 |
| 合法值 | 说明 |
| br | brotli压缩文件 |


### FileSystemManager.readdir(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| dirPath | string |  | 是 | 要读取的目录路径 (本地路径) |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Array.<string> FileSystemManager.readdirSync(string dirPath)

以 Promise 风格 调用：不支持

| 错误码 | 错误信息 | 说明 |
| --- | --- | --- |
| 1300001 | operation not permitted | 操作不被允许（例如，filePath 预期传入一个文件而实际传入一个目录） |
| 1300002 | no such file or directory ${path} | 文件/目录不存在，或者目标文件路径的上层目录不存在 |
| 1300005 | Input/output error | 输入输出流不可用 |
| 1300009 | bad file descriptor | 无效的文件描述符 |
| 1300013 | permission denied | 权限错误，文件是只读或只写 |
| 1300014 | Path permission denied | 传入的路径没有权限 |
| 1300020 | not a directory | dirPath 指定路径不是目录，常见于指定的写入路径的上级路径为一个文件的情况 |
| 1300021 | Is a directory | 指定路径是一个目录 |
| 1300022 | Invalid argument | 无效参数，可以检查length或offset是否越界 |
| 1300036 | File name too long | 文件名过长 |
| 1300066 | directory not empty | 目录不为空 |
| 1300201 | system error | 系统接口调用失败 |
| 1300202 | the maximum size of the file storage limit is exceeded | 存储空间不足，或文件大小超出上限（上限100M） |
| 1300203 | base64 encode error | 字符编码转换失败（例如 base64 格式错误） |
| 1300300 | sdcard not mounted | android sdcard 挂载失败 |
| 1300301 | unable to open as fileType | 无法以fileType打开文件 |
| 1301000 | permission denied, cannot access file path | 目标路径无访问权限（usr目录） |
| 1301002 | data to write is empty | 写入数据为空 |
| 1301003 | illegal operation on a directory | 不可对目录进行此操作（例如，指定的 filePath 是一个已经存在的目录） |
| 1301004 | illegal operation on a package directory | 不可对代码包目录进行此操作 |
| 1301005 | file already exists ${dirPath} | 已有同名文件或目录 |
| 1301006 | value of length is out of range | 传入的 length 不合法 |
| 1301007 | value of offset is out of range | 传入的 offset 不合法 |
| 1301009 | value of position is out of range | position值越界 |
| 1301100 | store directory is empty | store目录为空 |
| 1301102 | unzip open file fail | 压缩文件打开失败 |
| 1301103 | unzip entry fail | 解压单个文件失败 |
| 1301104 | unzip fail | 解压失败 |
| 1301111 | brotli decompress fail | brotli解压失败（例如，指定的 compressionAlgorithm 与文件实际压缩格式不符） |
| 1301112 | tempFilePath file not exist | 指定的 tempFilePath 找不到文件 |
| 1302001 | fail permission denied | 指定的 fd 路径没有读权限/没有写权限 |
| 1302002 | excced max concurrent fd limit | fd数量已达上限 |
| 1302003 | invalid flag | 无效的flag |
| 1302004 | permission denied when open using flag | 无法使用flag标志打开文件 |
| 1302005 | array buffer does not exist | 未传入arrayBuffer |
| 1302100 | array buffer is readonly | arrayBuffer只读 |


### FileSystemManager.readFile(Object object)

以 Promise 风格 调用：不支持

|  | 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- | --- |
|  | filePath | string |  | 是 | 要读取的文件的路径 (本地路径) |  |
|  | encoding | string |  | 否 | 指定读取文件的字符编码，如果不传 encoding，则以 ArrayBuffer 格式读取文件的二进制内容 |  |
|  | 合法值 说明 ascii base64 binary hex ucs2 以小端序读取 ucs-2 以小端序读取 utf16le 以小端序读取 utf-16le 以小端序读取 utf-8 utf8 latin1 | 合法值 | 说明 | ascii |  | base64 |  | binary |  | hex |  | ucs2 | 以小端序读取 | ucs-2 | 以小端序读取 | utf16le | 以小端序读取 | utf-16le | 以小端序读取 | utf-8 |  | utf8 |  | latin1 |  |
| 合法值 | 说明 |
| ascii |  |
| base64 |  |
| binary |  |
| hex |  |
| ucs2 | 以小端序读取 |
| ucs-2 | 以小端序读取 |
| utf16le | 以小端序读取 |
| utf-16le | 以小端序读取 |
| utf-8 |  |
| utf8 |  |
| latin1 |  |
|  | position | number |  | 否 | 从文件指定位置开始读，如果不指定，则从文件头开始读。读取的范围应该是左闭右开区间 [position, position+length)。有效范围：[0, fileLength - 1]。单位：byte | 2.10.0 |
|  | length | number |  | 否 | 指定文件的长度，如果不指定，则读到文件末尾。有效范围：[1, fileLength]。单位：byte | 2.10.0 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |  |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |  |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### string|ArrayBuffer FileSystemManager.readFileSync(string filePath, string encoding, number position, number length)

以 Promise 风格 调用：不支持

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| ascii |  |  |
| base64 |  |  |
| binary |  |  |
| hex |  |  |
| ucs2 | 以小端序读取 |  |
| ucs-2 | 以小端序读取 |  |
| utf16le | 以小端序读取 |  |
| utf-16le | 以小端序读取 |  |
| utf-8 |  |  |
| utf8 |  |  |
| latin1 |  |  |


### ReadResult FileSystemManager.readSync(Object object)

基础库 2.16.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| fd | string |  | 是 | 文件描述符。fd 通过 FileSystemManager.open 或 FileSystemManager.openSync 接口获得 |
| arrayBuffer | ArrayBuffer |  | 是 | 数据写入的缓冲区，必须是 ArrayBuffer 实例 |
| offset | number | 0 | 否 | 缓冲区中的写入偏移量，默认0 |
| length | number | 0 | 否 | 要从文件中读取的字节数，默认0 |
| position | number |  | 否 | 文件读取的起始位置，如不传或传 null，则会从当前文件指针的位置读取。如果 position 是正整数，则文件指针位置会保持不变并从 position 读取文件。 |


### FileSystemManager.readZipEntry(Object object)

基础库 2.17.3 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | filePath | string |  | 是 | 要读取的压缩包的路径 (本地路径) |
|  | encoding | string |  | 否 | 统一指定读取文件的字符编码，只在 entries 值为"all"时有效。如果 entries 值为"all"且不传 encoding，则以 ArrayBuffer 格式读取文件的二进制内容 |
|  | 合法值 说明 ascii base64 binary hex ucs2 以小端序读取 ucs-2 以小端序读取 utf16le 以小端序读取 utf-16le 以小端序读取 utf-8 utf8 latin1 | 合法值 | 说明 | ascii |  | base64 |  | binary |  | hex |  | ucs2 | 以小端序读取 | ucs-2 | 以小端序读取 | utf16le | 以小端序读取 | utf-16le | 以小端序读取 | utf-8 |  | utf8 |  | latin1 |  |
| 合法值 | 说明 |
| ascii |  |
| base64 |  |
| binary |  |
| hex |  |
| ucs2 | 以小端序读取 |
| ucs-2 | 以小端序读取 |
| utf16le | 以小端序读取 |
| utf-16le | 以小端序读取 |
| utf-8 |  |
| utf8 |  |
| latin1 |  |
|  | entries | Array.<Object>/'all' |  | 是 | 要读取的压缩包内的文件列表（当传入"all" 时表示读取压缩包内所有文件） |
|  | 结构属性 类型 默认值 必填 说明 path string 是 压缩包内文件路径 encoding string 否 指定读取文件的字符编码，如果不传 encoding，则以 ArrayBuffer 格式读取文件的二进制内容 合法值 说明 ascii base64 binary hex ucs2 以小端序读取 ucs-2 以小端序读取 utf16le 以小端序读取 utf-16le 以小端序读取 utf-8 utf8 latin1 position number 否 从文件指定位置开始读，如果不指定，则从文件头开始读。读取的范围应该是左闭右开区间 [position, position+length)。有效范围：[0, fileLength - 1]。单位：byte length number 否 指定文件的长度，如果不指定，则读到文件末尾。有效范围：[1, fileLength]。单位：byte |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | path | string |  | 是 | 压缩包内文件路径 |  | encoding | string |  | 否 | 指定读取文件的字符编码，如果不传 encoding，则以 ArrayBuffer 格式读取文件的二进制内容 |  | 合法值 说明 ascii base64 binary hex ucs2 以小端序读取 ucs-2 以小端序读取 utf16le 以小端序读取 utf-16le 以小端序读取 utf-8 utf8 latin1 | 合法值 | 说明 | ascii |  | base64 |  | binary |  | hex |  | ucs2 | 以小端序读取 | ucs-2 | 以小端序读取 | utf16le | 以小端序读取 | utf-16le | 以小端序读取 | utf-8 |  | utf8 |  | latin1 |  |  | position | number |  | 否 | 从文件指定位置开始读，如果不指定，则从文件头开始读。读取的范围应该是左闭右开区间 [position, position+length)。有效范围：[0, fileLength - 1]。单位：byte |  | length | number |  | 否 | 指定文件的长度，如果不指定，则读到文件末尾。有效范围：[1, fileLength]。单位：byte |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | path | string |  | 是 | 压缩包内文件路径 |
|  | encoding | string |  | 否 | 指定读取文件的字符编码，如果不传 encoding，则以 ArrayBuffer 格式读取文件的二进制内容 |
|  | 合法值 说明 ascii base64 binary hex ucs2 以小端序读取 ucs-2 以小端序读取 utf16le 以小端序读取 utf-16le 以小端序读取 utf-8 utf8 latin1 | 合法值 | 说明 | ascii |  | base64 |  | binary |  | hex |  | ucs2 | 以小端序读取 | ucs-2 | 以小端序读取 | utf16le | 以小端序读取 | utf-16le | 以小端序读取 | utf-8 |  | utf8 |  | latin1 |  |
| 合法值 | 说明 |
| ascii |  |
| base64 |  |
| binary |  |
| hex |  |
| ucs2 | 以小端序读取 |
| ucs-2 | 以小端序读取 |
| utf16le | 以小端序读取 |
| utf-16le | 以小端序读取 |
| utf-8 |  |
| utf8 |  |
| latin1 |  |
|  | position | number |  | 否 | 从文件指定位置开始读，如果不指定，则从文件头开始读。读取的范围应该是左闭右开区间 [position, position+length)。有效范围：[0, fileLength - 1]。单位：byte |
|  | length | number |  | 否 | 指定文件的长度，如果不指定，则读到文件末尾。有效范围：[1, fileLength]。单位：byte |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### FileSystemManager.removeSavedFile(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| filePath | string |  | 是 | 需要删除的文件路径 (本地路径) |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### FileSystemManager.rename(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| oldPath | string |  | 是 | 源文件路径，支持本地路径 |
| newPath | string |  | 是 | 新文件路径，支持本地路径 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### FileSystemManager.renameSync(string oldPath, string newPath)

以 Promise 风格 调用：不支持

| 错误码 | 错误信息 | 说明 |
| --- | --- | --- |
| 1300001 | operation not permitted | 操作不被允许（例如，filePath 预期传入一个文件而实际传入一个目录） |
| 1300002 | no such file or directory ${path} | 文件/目录不存在，或者目标文件路径的上层目录不存在 |
| 1300005 | Input/output error | 输入输出流不可用 |
| 1300009 | bad file descriptor | 无效的文件描述符 |
| 1300013 | permission denied | 权限错误，文件是只读或只写 |
| 1300014 | Path permission denied | 传入的路径没有权限 |
| 1300020 | not a directory | dirPath 指定路径不是目录，常见于指定的写入路径的上级路径为一个文件的情况 |
| 1300021 | Is a directory | 指定路径是一个目录 |
| 1300022 | Invalid argument | 无效参数，可以检查length或offset是否越界 |
| 1300036 | File name too long | 文件名过长 |
| 1300066 | directory not empty | 目录不为空 |
| 1300201 | system error | 系统接口调用失败 |
| 1300202 | the maximum size of the file storage limit is exceeded | 存储空间不足，或文件大小超出上限（上限100M） |
| 1300203 | base64 encode error | 字符编码转换失败（例如 base64 格式错误） |
| 1300300 | sdcard not mounted | android sdcard 挂载失败 |
| 1300301 | unable to open as fileType | 无法以fileType打开文件 |
| 1301000 | permission denied, cannot access file path | 目标路径无访问权限（usr目录） |
| 1301002 | data to write is empty | 写入数据为空 |
| 1301003 | illegal operation on a directory | 不可对目录进行此操作（例如，指定的 filePath 是一个已经存在的目录） |
| 1301004 | illegal operation on a package directory | 不可对代码包目录进行此操作 |
| 1301005 | file already exists ${dirPath} | 已有同名文件或目录 |
| 1301006 | value of length is out of range | 传入的 length 不合法 |
| 1301007 | value of offset is out of range | 传入的 offset 不合法 |
| 1301009 | value of position is out of range | position值越界 |
| 1301100 | store directory is empty | store目录为空 |
| 1301102 | unzip open file fail | 压缩文件打开失败 |
| 1301103 | unzip entry fail | 解压单个文件失败 |
| 1301104 | unzip fail | 解压失败 |
| 1301111 | brotli decompress fail | brotli解压失败（例如，指定的 compressionAlgorithm 与文件实际压缩格式不符） |
| 1301112 | tempFilePath file not exist | 指定的 tempFilePath 找不到文件 |
| 1302001 | fail permission denied | 指定的 fd 路径没有读权限/没有写权限 |
| 1302002 | excced max concurrent fd limit | fd数量已达上限 |
| 1302003 | invalid flag | 无效的flag |
| 1302004 | permission denied when open using flag | 无法使用flag标志打开文件 |
| 1302005 | array buffer does not exist | 未传入arrayBuffer |
| 1302100 | array buffer is readonly | arrayBuffer只读 |


### FileSystemManager.rmdir(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| dirPath | string |  | 是 | 要删除的目录路径 (本地路径) |  |
| recursive | boolean | false | 否 | 是否递归删除目录。如果为 true，则删除该目录和该目录下的所有子目录以及文件。 | 2.3.0 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### FileSystemManager.rmdirSync(string dirPath, boolean recursive)

以 Promise 风格 调用：不支持

| 错误码 | 错误信息 | 说明 |
| --- | --- | --- |
| 1300001 | operation not permitted | 操作不被允许（例如，filePath 预期传入一个文件而实际传入一个目录） |
| 1300002 | no such file or directory ${path} | 文件/目录不存在，或者目标文件路径的上层目录不存在 |
| 1300005 | Input/output error | 输入输出流不可用 |
| 1300009 | bad file descriptor | 无效的文件描述符 |
| 1300013 | permission denied | 权限错误，文件是只读或只写 |
| 1300014 | Path permission denied | 传入的路径没有权限 |
| 1300020 | not a directory | dirPath 指定路径不是目录，常见于指定的写入路径的上级路径为一个文件的情况 |
| 1300021 | Is a directory | 指定路径是一个目录 |
| 1300022 | Invalid argument | 无效参数，可以检查length或offset是否越界 |
| 1300036 | File name too long | 文件名过长 |
| 1300066 | directory not empty | 目录不为空 |
| 1300201 | system error | 系统接口调用失败 |
| 1300202 | the maximum size of the file storage limit is exceeded | 存储空间不足，或文件大小超出上限（上限100M） |
| 1300203 | base64 encode error | 字符编码转换失败（例如 base64 格式错误） |
| 1300300 | sdcard not mounted | android sdcard 挂载失败 |
| 1300301 | unable to open as fileType | 无法以fileType打开文件 |
| 1301000 | permission denied, cannot access file path | 目标路径无访问权限（usr目录） |
| 1301002 | data to write is empty | 写入数据为空 |
| 1301003 | illegal operation on a directory | 不可对目录进行此操作（例如，指定的 filePath 是一个已经存在的目录） |
| 1301004 | illegal operation on a package directory | 不可对代码包目录进行此操作 |
| 1301005 | file already exists ${dirPath} | 已有同名文件或目录 |
| 1301006 | value of length is out of range | 传入的 length 不合法 |
| 1301007 | value of offset is out of range | 传入的 offset 不合法 |
| 1301009 | value of position is out of range | position值越界 |
| 1301100 | store directory is empty | store目录为空 |
| 1301102 | unzip open file fail | 压缩文件打开失败 |
| 1301103 | unzip entry fail | 解压单个文件失败 |
| 1301104 | unzip fail | 解压失败 |
| 1301111 | brotli decompress fail | brotli解压失败（例如，指定的 compressionAlgorithm 与文件实际压缩格式不符） |
| 1301112 | tempFilePath file not exist | 指定的 tempFilePath 找不到文件 |
| 1302001 | fail permission denied | 指定的 fd 路径没有读权限/没有写权限 |
| 1302002 | excced max concurrent fd limit | fd数量已达上限 |
| 1302003 | invalid flag | 无效的flag |
| 1302004 | permission denied when open using flag | 无法使用flag标志打开文件 |
| 1302005 | array buffer does not exist | 未传入arrayBuffer |
| 1302100 | array buffer is readonly | arrayBuffer只读 |


### FileSystemManager.saveFile(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| tempFilePath | string |  | 是 | 临时存储文件路径 (本地路径) |
| filePath | string |  | 否 | 要存储的文件路径 (本地路径) |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### string FileSystemManager.saveFileSync(string tempFilePath, string filePath)

以 Promise 风格 调用：不支持

| 错误码 | 错误信息 | 说明 |
| --- | --- | --- |
| 1300001 | operation not permitted | 操作不被允许（例如，filePath 预期传入一个文件而实际传入一个目录） |
| 1300002 | no such file or directory ${path} | 文件/目录不存在，或者目标文件路径的上层目录不存在 |
| 1300005 | Input/output error | 输入输出流不可用 |
| 1300009 | bad file descriptor | 无效的文件描述符 |
| 1300013 | permission denied | 权限错误，文件是只读或只写 |
| 1300014 | Path permission denied | 传入的路径没有权限 |
| 1300020 | not a directory | dirPath 指定路径不是目录，常见于指定的写入路径的上级路径为一个文件的情况 |
| 1300021 | Is a directory | 指定路径是一个目录 |
| 1300022 | Invalid argument | 无效参数，可以检查length或offset是否越界 |
| 1300036 | File name too long | 文件名过长 |
| 1300066 | directory not empty | 目录不为空 |
| 1300201 | system error | 系统接口调用失败 |
| 1300202 | the maximum size of the file storage limit is exceeded | 存储空间不足，或文件大小超出上限（上限100M） |
| 1300203 | base64 encode error | 字符编码转换失败（例如 base64 格式错误） |
| 1300300 | sdcard not mounted | android sdcard 挂载失败 |
| 1300301 | unable to open as fileType | 无法以fileType打开文件 |
| 1301000 | permission denied, cannot access file path | 目标路径无访问权限（usr目录） |
| 1301002 | data to write is empty | 写入数据为空 |
| 1301003 | illegal operation on a directory | 不可对目录进行此操作（例如，指定的 filePath 是一个已经存在的目录） |
| 1301004 | illegal operation on a package directory | 不可对代码包目录进行此操作 |
| 1301005 | file already exists ${dirPath} | 已有同名文件或目录 |
| 1301006 | value of length is out of range | 传入的 length 不合法 |
| 1301007 | value of offset is out of range | 传入的 offset 不合法 |
| 1301009 | value of position is out of range | position值越界 |
| 1301100 | store directory is empty | store目录为空 |
| 1301102 | unzip open file fail | 压缩文件打开失败 |
| 1301103 | unzip entry fail | 解压单个文件失败 |
| 1301104 | unzip fail | 解压失败 |
| 1301111 | brotli decompress fail | brotli解压失败（例如，指定的 compressionAlgorithm 与文件实际压缩格式不符） |
| 1301112 | tempFilePath file not exist | 指定的 tempFilePath 找不到文件 |
| 1302001 | fail permission denied | 指定的 fd 路径没有读权限/没有写权限 |
| 1302002 | excced max concurrent fd limit | fd数量已达上限 |
| 1302003 | invalid flag | 无效的flag |
| 1302004 | permission denied when open using flag | 无法使用flag标志打开文件 |
| 1302005 | array buffer does not exist | 未传入arrayBuffer |
| 1302100 | array buffer is readonly | arrayBuffer只读 |


### FileSystemManager.stat(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| path | string |  | 是 | 文件/目录路径 (本地路径) |  |
| recursive | boolean | false | 否 | 是否递归获取目录下的每个文件的 Stats 信息 | 2.3.0 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### Stats|Array.<FileStats> FileSystemManager.statSync(string path, boolean recursive)

以 Promise 风格 调用：不支持

| 错误码 | 错误信息 | 说明 |
| --- | --- | --- |
| 1300001 | operation not permitted | 操作不被允许（例如，filePath 预期传入一个文件而实际传入一个目录） |
| 1300002 | no such file or directory ${path} | 文件/目录不存在，或者目标文件路径的上层目录不存在 |
| 1300005 | Input/output error | 输入输出流不可用 |
| 1300009 | bad file descriptor | 无效的文件描述符 |
| 1300013 | permission denied | 权限错误，文件是只读或只写 |
| 1300014 | Path permission denied | 传入的路径没有权限 |
| 1300020 | not a directory | dirPath 指定路径不是目录，常见于指定的写入路径的上级路径为一个文件的情况 |
| 1300021 | Is a directory | 指定路径是一个目录 |
| 1300022 | Invalid argument | 无效参数，可以检查length或offset是否越界 |
| 1300036 | File name too long | 文件名过长 |
| 1300066 | directory not empty | 目录不为空 |
| 1300201 | system error | 系统接口调用失败 |
| 1300202 | the maximum size of the file storage limit is exceeded | 存储空间不足，或文件大小超出上限（上限100M） |
| 1300203 | base64 encode error | 字符编码转换失败（例如 base64 格式错误） |
| 1300300 | sdcard not mounted | android sdcard 挂载失败 |
| 1300301 | unable to open as fileType | 无法以fileType打开文件 |
| 1301000 | permission denied, cannot access file path | 目标路径无访问权限（usr目录） |
| 1301002 | data to write is empty | 写入数据为空 |
| 1301003 | illegal operation on a directory | 不可对目录进行此操作（例如，指定的 filePath 是一个已经存在的目录） |
| 1301004 | illegal operation on a package directory | 不可对代码包目录进行此操作 |
| 1301005 | file already exists ${dirPath} | 已有同名文件或目录 |
| 1301006 | value of length is out of range | 传入的 length 不合法 |
| 1301007 | value of offset is out of range | 传入的 offset 不合法 |
| 1301009 | value of position is out of range | position值越界 |
| 1301100 | store directory is empty | store目录为空 |
| 1301102 | unzip open file fail | 压缩文件打开失败 |
| 1301103 | unzip entry fail | 解压单个文件失败 |
| 1301104 | unzip fail | 解压失败 |
| 1301111 | brotli decompress fail | brotli解压失败（例如，指定的 compressionAlgorithm 与文件实际压缩格式不符） |
| 1301112 | tempFilePath file not exist | 指定的 tempFilePath 找不到文件 |
| 1302001 | fail permission denied | 指定的 fd 路径没有读权限/没有写权限 |
| 1302002 | excced max concurrent fd limit | fd数量已达上限 |
| 1302003 | invalid flag | 无效的flag |
| 1302004 | permission denied when open using flag | 无法使用flag标志打开文件 |
| 1302005 | array buffer does not exist | 未传入arrayBuffer |
| 1302100 | array buffer is readonly | arrayBuffer只读 |


### FileSystemManager.truncate(Object object)

基础库 2.16.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| filePath | string |  | 是 | 要截断的文件路径 (本地路径) |
| length | number | 0 | 否 | 截断位置，默认0。如果 length 小于文件长度（字节），则只有前面 length 个字节会保留在文件中，其余内容会被删除；如果 length 大于文件长度，则会对其进行扩展，并且扩展部分将填充空字节（'\0'） |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### undefined FileSystemManager.truncateSync(Object object)

基础库 2.16.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| filePath | string |  | 是 | 要截断的文件路径 (本地路径) |
| length | number | 0 | 否 | 截断位置，默认0。如果 length 小于文件长度（字节），则只有前面 length 个字节会保留在文件中，其余内容会被删除；如果 length 大于文件长度，则会对其进行扩展，并且扩展部分将填充空字节（'\0'） |


### FileSystemManager.unlink(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| filePath | string |  | 是 | 要删除的文件路径 (本地路径) |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### FileSystemManager.unlinkSync(string filePath)

以 Promise 风格 调用：不支持

| 错误码 | 错误信息 | 说明 |
| --- | --- | --- |
| 1300001 | operation not permitted | 操作不被允许（例如，filePath 预期传入一个文件而实际传入一个目录） |
| 1300002 | no such file or directory ${path} | 文件/目录不存在，或者目标文件路径的上层目录不存在 |
| 1300005 | Input/output error | 输入输出流不可用 |
| 1300009 | bad file descriptor | 无效的文件描述符 |
| 1300013 | permission denied | 权限错误，文件是只读或只写 |
| 1300014 | Path permission denied | 传入的路径没有权限 |
| 1300020 | not a directory | dirPath 指定路径不是目录，常见于指定的写入路径的上级路径为一个文件的情况 |
| 1300021 | Is a directory | 指定路径是一个目录 |
| 1300022 | Invalid argument | 无效参数，可以检查length或offset是否越界 |
| 1300036 | File name too long | 文件名过长 |
| 1300066 | directory not empty | 目录不为空 |
| 1300201 | system error | 系统接口调用失败 |
| 1300202 | the maximum size of the file storage limit is exceeded | 存储空间不足，或文件大小超出上限（上限100M） |
| 1300203 | base64 encode error | 字符编码转换失败（例如 base64 格式错误） |
| 1300300 | sdcard not mounted | android sdcard 挂载失败 |
| 1300301 | unable to open as fileType | 无法以fileType打开文件 |
| 1301000 | permission denied, cannot access file path | 目标路径无访问权限（usr目录） |
| 1301002 | data to write is empty | 写入数据为空 |
| 1301003 | illegal operation on a directory | 不可对目录进行此操作（例如，指定的 filePath 是一个已经存在的目录） |
| 1301004 | illegal operation on a package directory | 不可对代码包目录进行此操作 |
| 1301005 | file already exists ${dirPath} | 已有同名文件或目录 |
| 1301006 | value of length is out of range | 传入的 length 不合法 |
| 1301007 | value of offset is out of range | 传入的 offset 不合法 |
| 1301009 | value of position is out of range | position值越界 |
| 1301100 | store directory is empty | store目录为空 |
| 1301102 | unzip open file fail | 压缩文件打开失败 |
| 1301103 | unzip entry fail | 解压单个文件失败 |
| 1301104 | unzip fail | 解压失败 |
| 1301111 | brotli decompress fail | brotli解压失败（例如，指定的 compressionAlgorithm 与文件实际压缩格式不符） |
| 1301112 | tempFilePath file not exist | 指定的 tempFilePath 找不到文件 |
| 1302001 | fail permission denied | 指定的 fd 路径没有读权限/没有写权限 |
| 1302002 | excced max concurrent fd limit | fd数量已达上限 |
| 1302003 | invalid flag | 无效的flag |
| 1302004 | permission denied when open using flag | 无法使用flag标志打开文件 |
| 1302005 | array buffer does not exist | 未传入arrayBuffer |
| 1302100 | array buffer is readonly | arrayBuffer只读 |


### FileSystemManager.unzip(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| zipFilePath | string |  | 是 | 源文件路径，支持本地路径, 只可以是 zip 压缩文件 |
| targetPath | string |  | 是 | 目标目录路径, 支持本地路径 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### FileSystemManager.write(Object object)

基础库 2.16.1 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | fd | string |  | 是 | 文件描述符。fd 通过 FileSystemManager.open 或 FileSystemManager.openSync 接口获得 |
|  | data | string/ArrayBuffer |  | 是 | 写入的内容，类型为 String 或 ArrayBuffer |
|  | offset | number | 0 | 否 | 只在 data 类型是 ArrayBuffer 时有效，决定 ArrayBuffer 中要被写入的部位，即 ArrayBuffer 中的索引，默认0 |
|  | length | number |  | 否 | 只在 data 类型是 ArrayBuffer 时有效，指定要写入的字节数，默认为 ArrayBuffer 从0开始偏移 offset 个字节后剩余的字节数 |
|  | encoding | string | utf8 | 否 | 只在 data 类型是 String 时有效，指定写入文件的字符编码，默认为 utf8 |
|  | 合法值 说明 ascii base64 binary hex ucs2 以小端序读取 ucs-2 以小端序读取 utf16le 以小端序读取 utf-16le 以小端序读取 utf-8 utf8 latin1 | 合法值 | 说明 | ascii |  | base64 |  | binary |  | hex |  | ucs2 | 以小端序读取 | ucs-2 | 以小端序读取 | utf16le | 以小端序读取 | utf-16le | 以小端序读取 | utf-8 |  | utf8 |  | latin1 |  |
| 合法值 | 说明 |
| ascii |  |
| base64 |  |
| binary |  |
| hex |  |
| ucs2 | 以小端序读取 |
| ucs-2 | 以小端序读取 |
| utf16le | 以小端序读取 |
| utf-16le | 以小端序读取 |
| utf-8 |  |
| utf8 |  |
| latin1 |  |
|  | position | number |  | 否 | 指定文件开头的偏移量，即数据要被写入的位置。当 position 不传或者传入非 Number 类型的值时，数据会被写入当前指针所在位置。 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### FileSystemManager.writeFile(Object object)

以 Promise 风格 调用：不支持

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | filePath | string |  | 是 | 要写入的文件路径 (本地路径) |
|  | data | string/ArrayBuffer |  | 是 | 要写入的文本或二进制数据 |
|  | encoding | string | utf8 | 否 | 指定写入文件的字符编码 |
|  | 合法值 说明 ascii base64 （注意，选择 base64 编码，data 只需要传 base64 内容本身，不要传 Data URI 前缀，否则会报 fail base64 encode error 错误。例如，传 aGVsbG8= 而不是传 data:image/png;base64,aGVsbG8= ） binary hex ucs2 以小端序读取 ucs-2 以小端序读取 utf16le 以小端序读取 utf-16le 以小端序读取 utf-8 utf8 latin1 | 合法值 | 说明 | ascii |  | base64 | （注意，选择 base64 编码，data 只需要传 base64 内容本身，不要传 Data URI 前缀，否则会报 fail base64 encode error 错误。例如，传 aGVsbG8= 而不是传 data:image/png;base64,aGVsbG8= ） | binary |  | hex |  | ucs2 | 以小端序读取 | ucs-2 | 以小端序读取 | utf16le | 以小端序读取 | utf-16le | 以小端序读取 | utf-8 |  | utf8 |  | latin1 |  |
| 合法值 | 说明 |
| ascii |  |
| base64 | （注意，选择 base64 编码，data 只需要传 base64 内容本身，不要传 Data URI 前缀，否则会报 fail base64 encode error 错误。例如，传 aGVsbG8= 而不是传 data:image/png;base64,aGVsbG8= ） |
| binary |  |
| hex |  |
| ucs2 | 以小端序读取 |
| ucs-2 | 以小端序读取 |
| utf16le | 以小端序读取 |
| utf-16le | 以小端序读取 |
| utf-8 |  |
| utf8 |  |
| latin1 |  |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### FileSystemManager.writeFileSync(string filePath, string|ArrayBuffer data, string encoding)

以 Promise 风格 调用：不支持

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| ascii |  |  |
| base64 | （注意，选择 base64 编码，data 只需要传 base64 内容本身，不要传 Data URI 前缀，否则会报 fail base64 encode error 错误。例如，传 aGVsbG8= 而不是传 data:image/png;base64,aGVsbG8= ） |  |
| binary |  |  |
| hex |  |  |
| ucs2 | 以小端序读取 |  |
| ucs-2 | 以小端序读取 |  |
| utf16le | 以小端序读取 |  |
| utf-16le | 以小端序读取 |  |
| utf-8 |  |  |
| utf8 |  |  |
| latin1 |  |  |


### WriteResult FileSystemManager.writeSync(Object object)

基础库 2.16.1 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | fd | string |  | 是 | 文件描述符。fd 通过 FileSystemManager.open 或 FileSystemManager.openSync 接口获得 |
|  | data | string/ArrayBuffer |  | 是 | 写入的内容，类型为 String 或 ArrayBuffer |
|  | offset | number | 0 | 否 | 只在 data 类型是 ArrayBuffer 时有效，决定 ArrayBuffer 中要被写入的部位，即 ArrayBuffer 中的索引，默认0 |
|  | length | number |  | 否 | 只在 data 类型是 ArrayBuffer 时有效，指定要写入的字节数，默认为 ArrayBuffer 从0开始偏移 offset 个字节后剩余的字节数 |
|  | encoding | string | utf8 | 否 | 只在 data 类型是 String 时有效，指定写入文件的字符编码，默认为 utf8 |
|  | 合法值 说明 ascii base64 binary hex ucs2 以小端序读取 ucs-2 以小端序读取 utf16le 以小端序读取 utf-16le 以小端序读取 utf-8 utf8 latin1 | 合法值 | 说明 | ascii |  | base64 |  | binary |  | hex |  | ucs2 | 以小端序读取 | ucs-2 | 以小端序读取 | utf16le | 以小端序读取 | utf-16le | 以小端序读取 | utf-8 |  | utf8 |  | latin1 |  |
| 合法值 | 说明 |
| ascii |  |
| base64 |  |
| binary |  |
| hex |  |
| ucs2 | 以小端序读取 |
| ucs-2 | 以小端序读取 |
| utf16le | 以小端序读取 |
| utf-16le | 以小端序读取 |
| utf-8 |  |
| utf8 |  |
| latin1 |  |
|  | position | number |  | 否 | 指定文件开头的偏移量，即数据要被写入的位置。当 position 不传或者传入非 Number 类型的值时，数据会被写入当前指针所在位置。 |


### FriendSendGiftStatus

用户送礼状态信息

| 值 | 含义 |
| --- | --- |
| 151066168 | 当前时间周期已经赠送，目前支持一天赠送一次 |
| 151066169 | 注册天数不足 首次注册时间必须大于 24 小时才能赠礼 |


### GameClubButton

游戏圈按钮。游戏圈按钮被点击后会跳转到小游戏的游戏圈。更多关于游戏圈的信息见 游戏圈使用指南

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| green | 绿色的图标 |  |
| white | 白色的图标 |  |
| dark | 有黑色圆角背景的白色图标 |  |
| light | 有白色圆角背景的绿色图标 |  |


### GameLogManager.log(Object param)

基础库 3.7.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| level | string |  | 是 | 日志等级，用于标识日志的级别和重要性。只能是'info'、'warn'、'error'、'debug'中的一种。 |
| key | string | 'default' | 是 | 日志标签，用于日志分类（如 登录、战斗……）。key 只能是 string 类型，且能够通过 JSON.stringify 序列化。若不传入 key 参数，上报使用默认 key 'default'。 |
| value | Object/Array.<any>/number/string/boolean |  | 是 | 日志内容。value 可以是 string/number/boolean/array/object 类型，且能够通过 JSON.stringify 序列化。 |
| success | function |  | 否 | 上报成功后的回调。 |
| fail | function |  | 否 | 上报失败后的回调。 |
| complete | function |  | 否 | 上报完成后的回调，成功、失败都会执行。 |


### Object GameLogManager.tag(string key)

基础库 3.7.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| info | function | 上报 info 级别的日志，仅支持传入日志内容。key 固定为 tag 传入的参数。 |
| warn | function | 上报 warn 级别的日志，仅支持传入日志内容。key 固定为 tag 传入的参数。 |
| error | function | 上报 error 级别的日志，仅支持传入日志内容。key 固定为 tag 传入的参数。 |
| debug | function | 上报 debug 级别的日志，仅支持传入日志内容。key 固定为 tag 传入的参数。 |


### GameRecorder

基础库 2.8.0 开始支持，低版本需做兼容处理。

| 错误码 | 错误信息 | 说明 |
| --- | --- | --- |
| 22002 | unknown error | 未知错误，没有被归纳到的错误 |
| 22012 | internal failed | 游戏画面录制 SDK 内部错误 |
| 22022 | frame not supported | 当前设备不支持录制游戏画面 |
| 22103 | duration invalid | duration 参数不合法 |
| 22113 | bitrate invalid | bitrate 参数不合法 |
| 22123 | fps invalid | fps 参数不合法 |
| 22133 | gop invalid | gop 参数不合法 |
| 22143 | start while already start recording | 在已经开始录制的情况下调用 start |
| 22153 | start while already paused | 在已经暂停录制的情况下调用 start，此时只能调用 resume 恢复录制 |
| 22203 | pause while not start recording | 在还没有开始录制的情况下调用 pause |
| 22213 | pause while already paused | 在已经暂停录制的情况下调用 pause |
| 22303 | resume while not start recording | 在还没有开始录制的情况下调用 resume |
| 22313 | resume while recording | 在录制中调用 resume，调用 resume 只能在暂停状态下 |
| 22403 | abort while not start recording | 在还没有开始录制的情况下调用 abort |
| 22503 | stop while not start recording | 在还没有开始录制的情况下调用 stop |
| 22603 | no recorded video | 在还没有一个录制好的对局回放的情况下发起分享 |
| 22613 | bgm not found | share.bgm 指定的额背景音乐不存在 |
| 22623 | time range invalid | share.timeRange 不合法 |
| 22633 | duration out of limit | share.timeRange 的所有片段的总和超出上限 |
| 22643 | time range too short.It should be longer than 2s | share.timeRange 太短 |


### GameRecorderShareButton

基础库 2.8.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| left | number | 左上角横坐标，单位 逻辑像素 |
| top | number | 左上角纵坐标，单位 逻辑像素 |
| height | number | 按钮的高度，最小 40 逻辑像素 |
| iconMarginRight | number | 图标和文本之间的距离，最小 8 逻辑像素 |
| fontSize | number | 文本的字体大小。最小 17，最大 22。 |
| color | string | 文本的颜色。 |
| paddingLeft | number | 按钮的左内边距，最小 16 逻辑像素。 |
| paddingRight | number | 按钮的右内边距，最小 16 逻辑像素。 |
| backgroundColor | string | 按钮背景颜色，十六进制颜色值，'transparent'为透明背景。 |
| borderRadius | number | 按钮圆角大小，单位为逻辑像素。 |


### Promise GameRecorder.abort()

基础库 2.8.0 开始支持，低版本需做兼容处理。

| 错误码 | 错误信息 | 说明 |
| --- | --- | --- |
| 22002 | unknown error | 未知错误，没有被归纳到的错误 |
| 22012 | internal failed | 游戏画面录制 SDK 内部错误 |
| 22022 | frame not supported | 当前设备不支持录制游戏画面 |
| 22103 | duration invalid | duration 参数不合法 |
| 22113 | bitrate invalid | bitrate 参数不合法 |
| 22123 | fps invalid | fps 参数不合法 |
| 22133 | gop invalid | gop 参数不合法 |
| 22143 | start while already start recording | 在已经开始录制的情况下调用 start |
| 22153 | start while already paused | 在已经暂停录制的情况下调用 start，此时只能调用 resume 恢复录制 |
| 22203 | pause while not start recording | 在还没有开始录制的情况下调用 pause |
| 22213 | pause while already paused | 在已经暂停录制的情况下调用 pause |
| 22303 | resume while not start recording | 在还没有开始录制的情况下调用 resume |
| 22313 | resume while recording | 在录制中调用 resume，调用 resume 只能在暂停状态下 |
| 22403 | abort while not start recording | 在还没有开始录制的情况下调用 abort |
| 22503 | stop while not start recording | 在还没有开始录制的情况下调用 stop |
| 22603 | no recorded video | 在还没有一个录制好的对局回放的情况下发起分享 |
| 22613 | bgm not found | share.bgm 指定的额背景音乐不存在 |
| 22623 | time range invalid | share.timeRange 不合法 |
| 22633 | duration out of limit | share.timeRange 的所有片段的总和超出上限 |
| 22643 | time range too short.It should be longer than 2s | share.timeRange 太短 |


### GameRecorder.off(string event, function callback)

基础库 2.8.0 开始支持，低版本需做兼容处理。

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| start | 录制开始事件。当调用 GameRecorder.start() 且客户端真正开始了对游戏画面录制时触发该事件。 |  |
| stop | 录制结束事件。当调用 GameRecorder.stop() 且客户端真正停止了对游戏画面录制时触发该事件。 |  |
| pause | 录制暂停事件。当调用 GameRecorder.pause() 且客户端真正暂停了对游戏画面录制时触发该事件。 |  |
| resume | 录制恢复事件。当调用 GameRecorder.resume() 且客户端真正恢复了对游戏画面录制时触发该事件。 |  |
| abort | 录制取消事件。当调用 GameRecorder.abort() 且客户端真正取消了对游戏画面录制时触发该事件。 |  |
| timeUpdate | 录制时间更新事件。在录制过程中触发该事件。 |  |
| error | 错误事件。当录制和分享过程中发生错误时触发该事件。录制是指当调用 GameRecorder 的接口进行录制；分享是指用户点击 GameRecorderShareButton 发起编辑界面并进行分享的过程。 |  |


### GameRecorder.on(string event, function callback)

基础库 2.8.0 开始支持，低版本需做兼容处理。

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| start | 录制开始事件。当调用 GameRecorder.start() 且客户端真正开始了对游戏画面录制时触发该事件。 |  |
| stop | 录制结束事件。当调用 GameRecorder.stop() 且客户端真正停止了对游戏画面录制时触发该事件。 |  |
| pause | 录制暂停事件。当调用 GameRecorder.pause() 且客户端真正暂停了对游戏画面录制时触发该事件。 |  |
| resume | 录制恢复事件。当调用 GameRecorder.resume() 且客户端真正恢复了对游戏画面录制时触发该事件。 |  |
| abort | 录制取消事件。当调用 GameRecorder.abort() 且客户端真正取消了对游戏画面录制时触发该事件。 |  |
| timeUpdate | 录制时间更新事件。在录制过程中触发该事件。 |  |
| error | 错误事件。当录制和分享过程中发生错误时触发该事件。录制是指当调用 GameRecorder 的接口进行录制；分享是指用户点击 GameRecorderShareButton 发起编辑界面并进行分享的过程。 |  |


### Promise GameRecorder.pause()

基础库 2.8.0 开始支持，低版本需做兼容处理。

| 错误码 | 错误信息 | 说明 |
| --- | --- | --- |
| 22002 | unknown error | 未知错误，没有被归纳到的错误 |
| 22012 | internal failed | 游戏画面录制 SDK 内部错误 |
| 22022 | frame not supported | 当前设备不支持录制游戏画面 |
| 22103 | duration invalid | duration 参数不合法 |
| 22113 | bitrate invalid | bitrate 参数不合法 |
| 22123 | fps invalid | fps 参数不合法 |
| 22133 | gop invalid | gop 参数不合法 |
| 22143 | start while already start recording | 在已经开始录制的情况下调用 start |
| 22153 | start while already paused | 在已经暂停录制的情况下调用 start，此时只能调用 resume 恢复录制 |
| 22203 | pause while not start recording | 在还没有开始录制的情况下调用 pause |
| 22213 | pause while already paused | 在已经暂停录制的情况下调用 pause |
| 22303 | resume while not start recording | 在还没有开始录制的情况下调用 resume |
| 22313 | resume while recording | 在录制中调用 resume，调用 resume 只能在暂停状态下 |
| 22403 | abort while not start recording | 在还没有开始录制的情况下调用 abort |
| 22503 | stop while not start recording | 在还没有开始录制的情况下调用 stop |
| 22603 | no recorded video | 在还没有一个录制好的对局回放的情况下发起分享 |
| 22613 | bgm not found | share.bgm 指定的额背景音乐不存在 |
| 22623 | time range invalid | share.timeRange 不合法 |
| 22633 | duration out of limit | share.timeRange 的所有片段的总和超出上限 |
| 22643 | time range too short.It should be longer than 2s | share.timeRange 太短 |


### Promise GameRecorder.resume()

基础库 2.8.0 开始支持，低版本需做兼容处理。

| 错误码 | 错误信息 | 说明 |
| --- | --- | --- |
| 22002 | unknown error | 未知错误，没有被归纳到的错误 |
| 22012 | internal failed | 游戏画面录制 SDK 内部错误 |
| 22022 | frame not supported | 当前设备不支持录制游戏画面 |
| 22103 | duration invalid | duration 参数不合法 |
| 22113 | bitrate invalid | bitrate 参数不合法 |
| 22123 | fps invalid | fps 参数不合法 |
| 22133 | gop invalid | gop 参数不合法 |
| 22143 | start while already start recording | 在已经开始录制的情况下调用 start |
| 22153 | start while already paused | 在已经暂停录制的情况下调用 start，此时只能调用 resume 恢复录制 |
| 22203 | pause while not start recording | 在还没有开始录制的情况下调用 pause |
| 22213 | pause while already paused | 在已经暂停录制的情况下调用 pause |
| 22303 | resume while not start recording | 在还没有开始录制的情况下调用 resume |
| 22313 | resume while recording | 在录制中调用 resume，调用 resume 只能在暂停状态下 |
| 22403 | abort while not start recording | 在还没有开始录制的情况下调用 abort |
| 22503 | stop while not start recording | 在还没有开始录制的情况下调用 stop |
| 22603 | no recorded video | 在还没有一个录制好的对局回放的情况下发起分享 |
| 22613 | bgm not found | share.bgm 指定的额背景音乐不存在 |
| 22623 | time range invalid | share.timeRange 不合法 |
| 22633 | duration out of limit | share.timeRange 的所有片段的总和超出上限 |
| 22643 | time range too short.It should be longer than 2s | share.timeRange 太短 |


### GameRecorder.start(Object object)

基础库 2.8.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| fps | number | 24 | 否 | 视频 fps |  |
| duration | number | 7200 | 否 | 视频的时长限制，单位为秒（s）。最大值 7200，最小值 5，到达指定时长后不会再录入。但还需要手动调用 GameRecorder.stop() 来结束录制。 |  |
| bitrate | number | 1000 | 否 | 视频比特率（kbps），默认值1000，最大值 3000，最小值 600 |  |
| gop | number | 12 | 否 | 视频关键帧间隔 |  |
| hookBgm | boolean | true | 否 | 是否录制游戏音效（仅iOS支持） | 2.10.0 |


### Promise GameRecorder.stop()

基础库 2.8.0 开始支持，低版本需做兼容处理。

| 错误码 | 错误信息 | 说明 |
| --- | --- | --- |
| 22002 | unknown error | 未知错误，没有被归纳到的错误 |
| 22012 | internal failed | 游戏画面录制 SDK 内部错误 |
| 22022 | frame not supported | 当前设备不支持录制游戏画面 |
| 22103 | duration invalid | duration 参数不合法 |
| 22113 | bitrate invalid | bitrate 参数不合法 |
| 22123 | fps invalid | fps 参数不合法 |
| 22133 | gop invalid | gop 参数不合法 |
| 22143 | start while already start recording | 在已经开始录制的情况下调用 start |
| 22153 | start while already paused | 在已经暂停录制的情况下调用 start，此时只能调用 resume 恢复录制 |
| 22203 | pause while not start recording | 在还没有开始录制的情况下调用 pause |
| 22213 | pause while already paused | 在已经暂停录制的情况下调用 pause |
| 22303 | resume while not start recording | 在还没有开始录制的情况下调用 resume |
| 22313 | resume while recording | 在录制中调用 resume，调用 resume 只能在暂停状态下 |
| 22403 | abort while not start recording | 在还没有开始录制的情况下调用 abort |
| 22503 | stop while not start recording | 在还没有开始录制的情况下调用 stop |
| 22603 | no recorded video | 在还没有一个录制好的对局回放的情况下发起分享 |
| 22613 | bgm not found | share.bgm 指定的额背景音乐不存在 |
| 22623 | time range invalid | share.timeRange 不合法 |
| 22633 | duration out of limit | share.timeRange 的所有片段的总和超出上限 |
| 22643 | time range too short.It should be longer than 2s | share.timeRange 太短 |


### Promise GameServerManager.broadcastInRoom(object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| msg | string |  | 是 | 广播内容 |
| toPosNumList | Array.<number> |  | 是 | 给座位号为哪些的玩家发送信息，不填代表给房间所有人发送 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise GameServerManager.cancelMatch(object object)

基础库 2.14.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| matchId | string |  | 是 | 需要取消匹配的matchId |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise GameServerManager.changeSeat(object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| posNum | number |  | 是 | 座位号，从 0 开始 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise GameServerManager.createRoom(object object)

以 Promise 风格 调用：不支持

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | maxMemberNum | number |  | 是 | 房间最大人数 |
|  | startPercent | number | 0 | 否 | 需要满足百分比的玩家都发送了开始指令才能启动游戏。有效范围 0~100，0 表示只要有一个人调用开始就启动，100 表示要求所有人都开始才能启动。 |
|  | needUserInfo | boolean | false | 否 | 是否需要用户头像和昵称 |
|  | 合法值 说明 true 需要用户头像和昵称，则每个加入房间的人必须授权过用户信息，MemberInfo 中会有 headimage 和 nickname false 不需要用户头像和昵称，MemberInfo 中不会有 headimage 和 nickname | 合法值 | 说明 | true | 需要用户头像和昵称，则每个加入房间的人必须授权过用户信息，MemberInfo 中会有 headimage 和 nickname | false | 不需要用户头像和昵称，MemberInfo 中不会有 headimage 和 nickname |
| 合法值 | 说明 |
| true | 需要用户头像和昵称，则每个加入房间的人必须授权过用户信息，MemberInfo 中会有 headimage 和 nickname |
| false | 不需要用户头像和昵称，MemberInfo 中不会有 headimage 和 nickname |
|  | gameLastTime | number | 1200 | 否 | 游戏对局时长，到达指定时长时游戏会结束，最大值 3600。 |
|  | roomExtInfo | string |  | 否 | 游戏自定义的关于房间扩展信息，其他人可在 RoomInfo 中读取到最多 32 个字节 |
|  | memberExtInfo | string |  | 否 | 游戏自定义的关于个人的扩展信息，其他人可在 MemberInfo 中读取到，最多 32 个字节 |
|  | needGameSeed | boolean | false | 否 | 是否需要生成游戏随机种子，设置为 true，房间信息会携带 gameSeed 属性 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise GameServerManager.endGame(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise GameServerManager.endStateService(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### GameServerManager.getFriendsStateData(Object object)

基础库 2.9.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise GameServerManager.getLastRoomInfo(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise GameServerManager.getLostFrames(object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| beginFrameId | number |  | 是 | 起始帧号。不填或非法值默认从第 1 帧开始补 |
| endFrameId | number |  | 是 | 结尾帧号。不填或非法值默认补到当前最新帧 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise GameServerManager.getRoomInfo(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### GameServerManager.inviteFriend(object object)

基础库 2.9.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| openId | string |  | 是 | 被邀请玩家的 openId |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise GameServerManager.joinRoom(object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| accessInfo | string |  | 是 | 游戏房间访问凭证 |
| memberExtInfo | string |  | 否 | 游戏自定义的关于个人的扩展信息，其他人可在 MemberInfo 中读取到，最多 32 个字节 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise GameServerManager.kickoutMember(object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| kickoutPos | number |  | 是 | 欲踢除的玩家的座位号 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise GameServerManager.memberLeaveRoom(object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| accessInfo | string |  | 是 | 游戏房间访问凭证 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### GameServerManager.onBeKickedOut(function listener)

微信 鸿蒙 OS 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| res | Object |  |


### GameServerManager.onBroadcast(function listener)

微信 鸿蒙 OS 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| msg | string | 广播消息 |


### GameServerManager.onDisconnect(function listener)

# 功能描述

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | res | Object |  |
|  | 结构属性 类型 说明 type string 合法值 说明 room 房间服务断开连接，只有在进入房间后有机会收到。房间服务断开连接后，将无法进行房间相关的操作，以及无法收到房间信息变化事件。 game 游戏服务断开连接，只有在游戏开始后有机会收到。游戏服务断开连接后，将无法收发帧。 |  | 结构属性 | 类型 | 说明 |  | type | string |  |  | 合法值 说明 room 房间服务断开连接，只有在进入房间后有机会收到。房间服务断开连接后，将无法进行房间相关的操作，以及无法收到房间信息变化事件。 game 游戏服务断开连接，只有在游戏开始后有机会收到。游戏服务断开连接后，将无法收发帧。 | 合法值 | 说明 | room | 房间服务断开连接，只有在进入房间后有机会收到。房间服务断开连接后，将无法进行房间相关的操作，以及无法收到房间信息变化事件。 | game | 游戏服务断开连接，只有在游戏开始后有机会收到。游戏服务断开连接后，将无法收发帧。 |
|  | 结构属性 | 类型 | 说明 |
|  | type | string |  |
|  | 合法值 说明 room 房间服务断开连接，只有在进入房间后有机会收到。房间服务断开连接后，将无法进行房间相关的操作，以及无法收到房间信息变化事件。 game 游戏服务断开连接，只有在游戏开始后有机会收到。游戏服务断开连接后，将无法收发帧。 | 合法值 | 说明 | room | 房间服务断开连接，只有在进入房间后有机会收到。房间服务断开连接后，将无法进行房间相关的操作，以及无法收到房间信息变化事件。 | game | 游戏服务断开连接，只有在游戏开始后有机会收到。游戏服务断开连接后，将无法收发帧。 |
| 合法值 | 说明 |
| room | 房间服务断开连接，只有在进入房间后有机会收到。房间服务断开连接后，将无法进行房间相关的操作，以及无法收到房间信息变化事件。 |
| game | 游戏服务断开连接，只有在游戏开始后有机会收到。游戏服务断开连接后，将无法收发帧。 |


### GameServerManager.onGameEnd(function listener)

# 功能描述

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| gameAccessInfo | string | 游戏唯一标识，用于后台接口拉取对局记录 |


### GameServerManager.onInvite(function listener)

基础库 2.9.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| res | Object |  |
| openId | string | 邀请者的 openId |
| data | string | 邀请者附带的额外信息 |


### GameServerManager.onLockStepError(function listener)

基础库 2.11.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| errCode | number | 错误码 |
| errMsg | string | 错误原因 |


### GameServerManager.onMatch(function listener)

基础库 2.14.4 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | res | Object |  |
|  | 结构属性 类型 说明 matchId string 与 startMatch 一致的 matchId openId string 自己的 openId roomServiceAccessInfo string 房间服务的accessinfo，如果matchid中指定需要匹配完成时创建房间服务，则会携带下来，后续调用房间服务相关接口加入房间即可 raceId string 唯一的本次对局id groupInfoList Array.<Object> 匹配到的队伍信息 结构属性 类型 说明 groupIndex number 队伍的序号 memberInfoList Array.<Object> 队伍中成员信息 结构属性 类型 说明 memberIndex number 成员的序号 openId string 队伍中成员的openid nickName string 队伍中成员的昵称 avatarUrl string 队伍中成员的头像 |  | 结构属性 | 类型 | 说明 |  | matchId | string | 与 startMatch 一致的 matchId |  | openId | string | 自己的 openId |  | roomServiceAccessInfo | string | 房间服务的accessinfo，如果matchid中指定需要匹配完成时创建房间服务，则会携带下来，后续调用房间服务相关接口加入房间即可 |  | raceId | string | 唯一的本次对局id |  | groupInfoList | Array.<Object> | 匹配到的队伍信息 |  | 结构属性 类型 说明 groupIndex number 队伍的序号 memberInfoList Array.<Object> 队伍中成员信息 结构属性 类型 说明 memberIndex number 成员的序号 openId string 队伍中成员的openid nickName string 队伍中成员的昵称 avatarUrl string 队伍中成员的头像 |  | 结构属性 | 类型 | 说明 |  | groupIndex | number | 队伍的序号 |  | memberInfoList | Array.<Object> | 队伍中成员信息 |  | 结构属性 类型 说明 memberIndex number 成员的序号 openId string 队伍中成员的openid nickName string 队伍中成员的昵称 avatarUrl string 队伍中成员的头像 |  | 结构属性 | 类型 | 说明 |  | memberIndex | number | 成员的序号 |  | openId | string | 队伍中成员的openid |  | nickName | string | 队伍中成员的昵称 |  | avatarUrl | string | 队伍中成员的头像 |
|  | 结构属性 | 类型 | 说明 |
|  | matchId | string | 与 startMatch 一致的 matchId |
|  | openId | string | 自己的 openId |
|  | roomServiceAccessInfo | string | 房间服务的accessinfo，如果matchid中指定需要匹配完成时创建房间服务，则会携带下来，后续调用房间服务相关接口加入房间即可 |
|  | raceId | string | 唯一的本次对局id |
|  | groupInfoList | Array.<Object> | 匹配到的队伍信息 |
|  | 结构属性 类型 说明 groupIndex number 队伍的序号 memberInfoList Array.<Object> 队伍中成员信息 结构属性 类型 说明 memberIndex number 成员的序号 openId string 队伍中成员的openid nickName string 队伍中成员的昵称 avatarUrl string 队伍中成员的头像 |  | 结构属性 | 类型 | 说明 |  | groupIndex | number | 队伍的序号 |  | memberInfoList | Array.<Object> | 队伍中成员信息 |  | 结构属性 类型 说明 memberIndex number 成员的序号 openId string 队伍中成员的openid nickName string 队伍中成员的昵称 avatarUrl string 队伍中成员的头像 |  | 结构属性 | 类型 | 说明 |  | memberIndex | number | 成员的序号 |  | openId | string | 队伍中成员的openid |  | nickName | string | 队伍中成员的昵称 |  | avatarUrl | string | 队伍中成员的头像 |
|  | 结构属性 | 类型 | 说明 |
|  | groupIndex | number | 队伍的序号 |
|  | memberInfoList | Array.<Object> | 队伍中成员信息 |
|  | 结构属性 类型 说明 memberIndex number 成员的序号 openId string 队伍中成员的openid nickName string 队伍中成员的昵称 avatarUrl string 队伍中成员的头像 |  | 结构属性 | 类型 | 说明 |  | memberIndex | number | 成员的序号 |  | openId | string | 队伍中成员的openid |  | nickName | string | 队伍中成员的昵称 |  | avatarUrl | string | 队伍中成员的头像 |
|  | 结构属性 | 类型 | 说明 |
|  | memberIndex | number | 成员的序号 |
|  | openId | string | 队伍中成员的openid |
|  | nickName | string | 队伍中成员的昵称 |
|  | avatarUrl | string | 队伍中成员的头像 |


### GameServerManager.onRoomInfoChange(function listener)

微信 鸿蒙 OS 版：支持

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | res | Object |  |
|  | 结构属性 类型 说明 appId string 小游戏 appId roomIdStr number 房间 ID roomState number 房间状态 合法值 说明 1 组队中 2 该房间的对局游戏已开始 3 该房间的对局游戏已结束 4 房间已销毁 5 房间连接已建立，等待对战连接建立 maxMemberNum number 房间最多可容纳人数 createTimestamp number 创建时间 updateTimestamp number 最近更新时间 gameTick number 游戏下发帧的时间间隔，单位 ms startPercent number 需要满足百分比的玩家都发送了开始指令才能启动游戏。有效范围 0~100，0 表示只要有一个人调用开始就启动，100 表示要求所有人都开始才能启动。 roomExtInfo string 游戏自定义的关于房间的扩展信息 gameLastTime number 游戏对局时长，单位 s udpReliabilityStrategy number UDP可靠性策略， 0：全冗余 N：固定冗余N帧 memberList Array.<Object> 成员列表 结构属性 类型 说明 isReady boolean 玩家准备状态 role number 角色 合法值 说明 0 普通成员 1 房主 posNum number 座位号，从 0 开始 headimg string 头像 URL（房间 needUserInfo 为 true 时才会有） nickname string 用户昵称（房间 needUserInfo 为 true 时才会有） clientId number 用户在房间内的唯一标识 enableToStart boolean 是否已做好游戏开始准备（调用过 startGame） memberExtInfo string 游戏自定义的关于成员的扩展信息 seed string 游戏随机种子 |  | 结构属性 | 类型 | 说明 |  | appId | string | 小游戏 appId |  | roomIdStr | number | 房间 ID |  | roomState | number | 房间状态 |  | 合法值 说明 1 组队中 2 该房间的对局游戏已开始 3 该房间的对局游戏已结束 4 房间已销毁 5 房间连接已建立，等待对战连接建立 | 合法值 | 说明 | 1 | 组队中 | 2 | 该房间的对局游戏已开始 | 3 | 该房间的对局游戏已结束 | 4 | 房间已销毁 | 5 | 房间连接已建立，等待对战连接建立 |  | maxMemberNum | number | 房间最多可容纳人数 |  | createTimestamp | number | 创建时间 |  | updateTimestamp | number | 最近更新时间 |  | gameTick | number | 游戏下发帧的时间间隔，单位 ms |  | startPercent | number | 需要满足百分比的玩家都发送了开始指令才能启动游戏。有效范围 0~100，0 表示只要有一个人调用开始就启动，100 表示要求所有人都开始才能启动。 |  | roomExtInfo | string | 游戏自定义的关于房间的扩展信息 |  | gameLastTime | number | 游戏对局时长，单位 s |  | udpReliabilityStrategy | number | UDP可靠性策略， 0：全冗余 N：固定冗余N帧 |  | memberList | Array.<Object> | 成员列表 |  | 结构属性 类型 说明 isReady boolean 玩家准备状态 role number 角色 合法值 说明 0 普通成员 1 房主 posNum number 座位号，从 0 开始 headimg string 头像 URL（房间 needUserInfo 为 true 时才会有） nickname string 用户昵称（房间 needUserInfo 为 true 时才会有） clientId number 用户在房间内的唯一标识 enableToStart boolean 是否已做好游戏开始准备（调用过 startGame） memberExtInfo string 游戏自定义的关于成员的扩展信息 |  | 结构属性 | 类型 | 说明 |  | isReady | boolean | 玩家准备状态 |  | role | number | 角色 |  | 合法值 说明 0 普通成员 1 房主 | 合法值 | 说明 | 0 | 普通成员 | 1 | 房主 |  | posNum | number | 座位号，从 0 开始 |  | headimg | string | 头像 URL（房间 needUserInfo 为 true 时才会有） |  | nickname | string | 用户昵称（房间 needUserInfo 为 true 时才会有） |  | clientId | number | 用户在房间内的唯一标识 |  | enableToStart | boolean | 是否已做好游戏开始准备（调用过 startGame） |  | memberExtInfo | string | 游戏自定义的关于成员的扩展信息 |  | seed | string | 游戏随机种子 |
|  | 结构属性 | 类型 | 说明 |
|  | appId | string | 小游戏 appId |
|  | roomIdStr | number | 房间 ID |
|  | roomState | number | 房间状态 |
|  | 合法值 说明 1 组队中 2 该房间的对局游戏已开始 3 该房间的对局游戏已结束 4 房间已销毁 5 房间连接已建立，等待对战连接建立 | 合法值 | 说明 | 1 | 组队中 | 2 | 该房间的对局游戏已开始 | 3 | 该房间的对局游戏已结束 | 4 | 房间已销毁 | 5 | 房间连接已建立，等待对战连接建立 |
| 合法值 | 说明 |
| 1 | 组队中 |
| 2 | 该房间的对局游戏已开始 |
| 3 | 该房间的对局游戏已结束 |
| 4 | 房间已销毁 |
| 5 | 房间连接已建立，等待对战连接建立 |
|  | maxMemberNum | number | 房间最多可容纳人数 |
|  | createTimestamp | number | 创建时间 |
|  | updateTimestamp | number | 最近更新时间 |
|  | gameTick | number | 游戏下发帧的时间间隔，单位 ms |
|  | startPercent | number | 需要满足百分比的玩家都发送了开始指令才能启动游戏。有效范围 0~100，0 表示只要有一个人调用开始就启动，100 表示要求所有人都开始才能启动。 |
|  | roomExtInfo | string | 游戏自定义的关于房间的扩展信息 |
|  | gameLastTime | number | 游戏对局时长，单位 s |
|  | udpReliabilityStrategy | number | UDP可靠性策略， 0：全冗余 N：固定冗余N帧 |
|  | memberList | Array.<Object> | 成员列表 |
|  | 结构属性 类型 说明 isReady boolean 玩家准备状态 role number 角色 合法值 说明 0 普通成员 1 房主 posNum number 座位号，从 0 开始 headimg string 头像 URL（房间 needUserInfo 为 true 时才会有） nickname string 用户昵称（房间 needUserInfo 为 true 时才会有） clientId number 用户在房间内的唯一标识 enableToStart boolean 是否已做好游戏开始准备（调用过 startGame） memberExtInfo string 游戏自定义的关于成员的扩展信息 |  | 结构属性 | 类型 | 说明 |  | isReady | boolean | 玩家准备状态 |  | role | number | 角色 |  | 合法值 说明 0 普通成员 1 房主 | 合法值 | 说明 | 0 | 普通成员 | 1 | 房主 |  | posNum | number | 座位号，从 0 开始 |  | headimg | string | 头像 URL（房间 needUserInfo 为 true 时才会有） |  | nickname | string | 用户昵称（房间 needUserInfo 为 true 时才会有） |  | clientId | number | 用户在房间内的唯一标识 |  | enableToStart | boolean | 是否已做好游戏开始准备（调用过 startGame） |  | memberExtInfo | string | 游戏自定义的关于成员的扩展信息 |
|  | 结构属性 | 类型 | 说明 |
|  | isReady | boolean | 玩家准备状态 |
|  | role | number | 角色 |
|  | 合法值 说明 0 普通成员 1 房主 | 合法值 | 说明 | 0 | 普通成员 | 1 | 房主 |
| 合法值 | 说明 |
| 0 | 普通成员 |
| 1 | 房主 |
|  | posNum | number | 座位号，从 0 开始 |
|  | headimg | string | 头像 URL（房间 needUserInfo 为 true 时才会有） |
|  | nickname | string | 用户昵称（房间 needUserInfo 为 true 时才会有） |
|  | clientId | number | 用户在房间内的唯一标识 |
|  | enableToStart | boolean | 是否已做好游戏开始准备（调用过 startGame） |
|  | memberExtInfo | string | 游戏自定义的关于成员的扩展信息 |
|  | seed | string | 游戏随机种子 |


### GameServerManager.onStateUpdate(function listener)

基础库 2.9.4 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | res | Object |  |
|  | 结构属性 类型 说明 userState string 该玩家的自定义状态信息 sysState number 系统状态，0 掉线 1 在线 openId string 好友 openId |  | 结构属性 | 类型 | 说明 |  | userState | string | 该玩家的自定义状态信息 |  | sysState | number | 系统状态，0 掉线 1 在线 |  | openId | string | 好友 openId |
|  | 结构属性 | 类型 | 说明 |
|  | userState | string | 该玩家的自定义状态信息 |
|  | sysState | number | 系统状态，0 掉线 1 在线 |
|  | openId | string | 好友 openId |


### GameServerManager.onSyncFrame(function listener)

# 功能描述

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| frameId | number | 帧号，从 1 开始递增 |
| actionList | Array.<string>/Array.<ArrayBuffer> | 帧数据列表，如果为空则说明该帧是空帧，每一项的类型与配置项 lockStepOption.dataType 一致 |


### Promise GameServerManager.ownerLeaveRoom(object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| accessInfo | string |  | 是 | 游戏房间访问凭证 |
| assignOwnerToPosNum | boolean |  | 否 | 指定座位号的玩家接任房主角色，优先级高于 assignToMinPosNum |
| assignToMinPosNum | boolean |  | 否 | 自动指定最小座位号玩家作为新房主 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise<ReconnectSuccessRes> GameServerManager.reconnect(object object)

# 功能描述

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| accessInfo | string |  | 是 | 需要重连的对局房间唯一标识 |


### Promise GameServerManager.restart(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise GameServerManager.setState(object object)

基础库 2.9.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| userState | string |  | 是 | 该玩家的自定义状态信息，长度限制为 256 个字符 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### GameServerManager.startGame(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise GameServerManager.startMatch(object object)

基础库 2.14.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| matchId | string |  | 是 | 通过后台接口申请的matchId |
| fillType | number | 0 | 否 | 补充类型，0:自动补充队友 1:不补充队友 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise GameServerManager.startStateService(object object)

基础库 2.9.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| userState | string |  | 是 | 该玩家的自定义状态信息，长度限制为 256 个字符 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise GameServerManager.updateReadyStatus(object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| accessInfo | string |  | 是 | 游戏房间访问凭证 |
| isReady | boolean |  | 是 | 是否准备完成 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise GameServerManager.uploadFrame(object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| actionList | Array.<string>/Array.<ArrayBuffer> |  | 是 | 指令数组，每一项的类型必须与配置项 lockStepOption.dataType 一致 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### GridAd

grid(格子) 广告组件。grid(格子) 广告组件是一个原生组件，层级比普通组件高。grid(格子) 广告组件默认是隐藏的，需要调用 GridAd.show() 将其显示。grid(格子) 广告会根据开发者设置的宽度进行等比缩放，缩放后的尺寸将通过 GridAd.onResize() 事件中提供。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| left | number | grid(格子) 广告广告组件的左上角横坐标 |
| top | number | grid(格子) 广告组件的左上角纵坐标 |
| width | number | grid(格子) 广告组件的宽度。最小 300，最大至 屏幕宽度（屏幕宽度可以通过 wx.getSystemInfoSync() 获取）。 |
| height | number | grid(格子) 广告组件的高度 |
| realWidth | number | grid(格子) 广告组件经过缩放后真实的宽度 |
| realHeight | number | grid(格子) 广告组件经过缩放后真实的高度 |


### GridAd.onError(function listener)

从基础库 2.30.2 开始，本接口停止维护

|  | 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- |
|  | errMsg | string | 错误信息 |  |
|  | errCode | number | 错误码 | 2.2.2 |
|  | 合法值 说明 1000 后端接口调用失败 1001 参数错误 1002 广告单元无效 1003 内部错误 1004 无合适的广告 1005 广告组件审核中 1006 广告组件被驳回 1007 广告组件被封禁 1008 广告单元已关闭 | 合法值 | 说明 | 1000 | 后端接口调用失败 | 1001 | 参数错误 | 1002 | 广告单元无效 | 1003 | 内部错误 | 1004 | 无合适的广告 | 1005 | 广告组件审核中 | 1006 | 广告组件被驳回 | 1007 | 广告组件被封禁 | 1008 | 广告单元已关闭 |
| 合法值 | 说明 |
| 1000 | 后端接口调用失败 |
| 1001 | 参数错误 |
| 1002 | 广告单元无效 |
| 1003 | 内部错误 |
| 1004 | 无合适的广告 |
| 1005 | 广告组件审核中 |
| 1006 | 广告组件被驳回 |
| 1007 | 广告组件被封禁 |
| 1008 | 广告单元已关闭 |


### GridAd.onResize(function listener)

从基础库 2.30.2 开始，本接口停止维护

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| width | number | 缩放后的宽度 |
| height | number | 缩放后的高度 |


### InnerAudioContext

InnerAudioContext 实例，可通过 wx.createInnerAudioContext 接口获取实例。注意，音频播放过程中，可能被系统中断，可通过 wx.onAudioInterruptionBegin、wx.onAudioInterruptionEnd事件来处理这种情况。

| 格式 | iOS | Android |
| --- | --- | --- |
| flac | x | √ |
| m4a | √ | √ |
| ogg | x | √ |
| ape | x | √ |
| amr | x | √ |
| wma | x | √ |
| wav | √ | √ |
| mp3 | √ | √ |
| mp4 | x | √ |
| aac | √ | √ |
| aiff | √ | x |
| caf | √ | x |


### InnerAudioContext.onError(function listener)

# 功能描述

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | errMsg | string |  |
|  | errCode | number |  |
|  | 合法值 说明 10001 系统错误 10002 网络错误 10003 文件错误 10004 格式错误 -1 未知错误 | 合法值 | 说明 | 10001 | 系统错误 | 10002 | 网络错误 | 10003 | 文件错误 | 10004 | 格式错误 | -1 | 未知错误 |
| 合法值 | 说明 |
| 10001 | 系统错误 |
| 10002 | 网络错误 |
| 10003 | 文件错误 |
| 10004 | 格式错误 |
| -1 | 未知错误 |


### InterstitialAd.onError(function listener)

# 功能描述

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | errMsg | string | 错误信息 |
|  | errCode | number | 错误码 |
|  | 合法值 说明 1000 后端接口调用失败 1001 参数错误 1002 广告单元无效 1003 内部错误 1004 无合适的广告 1005 广告组件审核中 1006 广告组件被驳回 1007 广告组件被封禁 1008 广告单元已关闭 | 合法值 | 说明 | 1000 | 后端接口调用失败 | 1001 | 参数错误 | 1002 | 广告单元无效 | 1003 | 内部错误 | 1004 | 无合适的广告 | 1005 | 广告组件审核中 | 1006 | 广告组件被驳回 | 1007 | 广告组件被封禁 | 1008 | 广告单元已关闭 |
| 合法值 | 说明 |
| 1000 | 后端接口调用失败 |
| 1001 | 参数错误 |
| 1002 | 广告单元无效 |
| 1003 | 内部错误 |
| 1004 | 无合适的广告 |
| 1005 | 广告组件审核中 |
| 1006 | 广告组件被驳回 |
| 1007 | 广告组件被封禁 |
| 1008 | 广告单元已关闭 |


### Promise InterstitialAd.show()

# 功能描述

| 代码 | 异常情况 | 理由 |
| --- | --- | --- |
| 2001 | 触发频率限制 | 小程序启动一定时间内不允许展示插屏广告 |
| 2002 | 触发频率限制 | 距离小程序插屏广告或者激励视频广告上次播放时间间隔不足，不允许展示插屏广告 |
| 2003 | 触发频率限制 | 当前正在播放激励视频广告或者插屏广告，不允许再次展示插屏广告 |
| 2004 | 广告渲染失败 | 该项错误不是开发者的异常情况，或因小程序页面切换导致广告渲染失败 |
| 2005 | 广告调用异常 | 插屏广告实例不允许跨页面调用 |


### KVData

托管的 KV 数据

| 属性名 | 类型 | 必填 | 说明 |
| --- | --- | --- | --- |
| score | Int32 | 是 | 该榜单对应分数值 |
| update_time | Int64 | 是 | 该分数最后更新时间，Unix时间戳 |


### LoadSubpackageTask.onProgressUpdate(function listener)

基础库 2.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| progress | number | 分包下载进度百分比 |
| totalBytesWritten | number | 已经下载的数据长度，单位 Bytes |
| totalBytesExpectedToWrite | number | 预期需要下载的数据总长度，单位 Bytes |


### MiniReportManager.report(Object param)

基础库 3.8.12 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| eventID | string |  | 是 | 关卡事件 ID，在 小游戏管理后台->统计-> 收入诊断调优->分析调优->事件上报中配置 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getUserInfo(Object object)

以 Promise 风格 调用：不支持

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | openIdList | Array.<string> | [] | 否 | 要获取信息的用户的 openId 数组，如果要获取当前用户信息，则将数组中的一个元素设为 'selfOpenId' |
|  | lang | string | en | 否 | 显示用户信息的语言 |
|  | 合法值 说明 en 英文 zh_CN 简体中文 zh_TW 繁体中文 | 合法值 | 说明 | en | 英文 | zh_CN | 简体中文 | zh_TW | 繁体中文 |
| 合法值 | 说明 |
| en | 英文 |
| zh_CN | 简体中文 |
| zh_TW | 繁体中文 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### OpenSettingButton

用户点击后打开设置页面的按钮

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| text | 可以设置背景色和文本的按钮 |  |
| image | 只能设置背景贴图的按钮，背景贴图会直接拉伸到按钮的宽高 |  |


### Promise PageManager.load(Object object)

基础库 3.6.7 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| openlink | string |  | 是 | 从不同渠道获得的OPENLINK字符串 |
| query | Object |  | 否 | 选填，部分活动、功能允许接收自定义query参数，请参阅渠道说明，默认可不填 |
| extraData | Object |  | 否 | 选填，部分活动、功能允许额外提供参数数据，具体使用请根据渠道说明，默认可不填 |


### Promise PageManager.show(Object object)

基础库 3.6.7 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| openlink | string |  | 否 | 从不同渠道获得的OPENLINK字符串 |
| query | Object |  | 否 | 选填，部分活动、功能允许接收自定义query参数，请参阅渠道说明，默认可不填 |
| extraData | Object |  | 否 | 选填，部分活动、功能允许额外提供参数数据，具体使用请根据渠道说明，默认可不填 |


### PreDownloadSubpackageTask.onProgressUpdate(function listener)

基础库 2.27.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| progress | number | 分包下载进度百分比 |
| totalBytesWritten | number | 已经下载的数据长度，单位 Bytes |
| totalBytesExpectedToWrite | number | 预期需要下载的数据总长度，单位 Bytes |


### RankManager.abort(Object params)

基础库 3.10.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### RankManager.createChallenge(Object params)

基础库 3.10.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| scoreKey | string |  | 是 | 玩法唯一标识，用于区分不同的擂台赛玩法。可以在 MP后台-运营功能管理-基础配置-游戏玩法ID 中配置 |
| subScoreKey | number |  | 否 | 可选子 key，正整数，取值范围1-1000。该参数可用于游戏同一玩法的关卡区分，从基础库版本3.12.1开始支持 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### RankManager.getScore(Object params)

基础库 3.10.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| scoreKeys | Array |  | 是 | 玩法唯一标识数组 |
| subScoreKeys | Array |  | 否 | 可选子 key 数组，从基础库版本3.12.1开始支持 |
| periodType | number |  | 是 | 查询的周期：1：自然日最高分；2：自然周最高分；3：自然月最高分；4：历史最高分；5 最新得分 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### RankManager.middleUpdate(Object params)

基础库 3.10.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| scoreKey | string |  | 是 | 玩法唯一标识，用于区分不同的擂台赛玩法。可以在 MP后台-运营功能管理-基础配置-游戏玩法ID 中配置 |
| score | number |  | 是 | 用户得分 |
| subScoreKey | number |  | 否 | 可选子 key，正整数，取值范围1-1000。该参数可用于游戏同一玩法的关卡区分，从基础库版本3.12.1开始支持 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### RankManager.offChallengeStart(function callback)

基础库 3.10.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| scoreKey | string | 玩法唯一标识 |
| subScoreKey | number | 可选子 key |


### RankManager.onChallengeStart(function callback)

基础库 3.10.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| scoreKey | string | 玩法唯一标识 |
| subScoreKey | number | 可选子 key |


### RankManager.update(Object params)

基础库 3.10.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| scoreKey | string |  | 是 | 玩法唯一标识，用于区分不同的擂台赛玩法。可以在 MP后台-运营功能管理-基础配置-游戏玩法ID 中配置 |
| score | number |  | 是 | 分数值 |
| subScoreKey | number |  | 否 | 可选子 key，正整数，取值范围1-1000。该参数可用于游戏同一玩法的关卡区分，从基础库版本3.12.1开始支持 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### ReconnectSuccessRes

GameServerManager.reconnect 接口 resolve 后的返回值

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | data | Object |  |
|  | 结构属性 类型 说明 maxFrameId Array.<Frame> 此时服务器的最大帧号。 |  | 结构属性 | 类型 | 说明 |  | maxFrameId | Array.<Frame> | 此时服务器的最大帧号。 |
|  | 结构属性 | 类型 | 说明 |
|  | maxFrameId | Array.<Frame> | 此时服务器的最大帧号。 |


### RecorderManager.onError(function listener)

微信 Windows 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| errMsg | string | 错误信息 |


### RecorderManager.onFrameRecorded(function listener)

微信 Windows 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| frameBuffer | ArrayBuffer | 录音分片数据 |
| isLastFrame | boolean | 当前帧是否正常录音结束前的最后一帧 |


### RecorderManager.onStop(function listener)

微信 Windows 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| tempFilePath | string | 录音文件的临时路径 (本地路径) |
| duration | number | 录音总时长，单位：ms |
| fileSize | number | 录音文件大小，单位：Byte |


### RecorderManager.start(Object object)

微信 Windows 版：支持

|  | 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- | --- |
|  | duration | number | 60000 | 否 | 录音的时长，单位 ms，最大值 600000（10 分钟） |  |
|  | sampleRate | number | 8000 | 否 | 采样率（pc不支持） |  |
|  | 合法值 说明 8000 8000 采样率 11025 11025 采样率 12000 12000 采样率 16000 16000 采样率 22050 22050 采样率 24000 24000 采样率 32000 32000 采样率 44100 44100 采样率 48000 48000 采样率 | 合法值 | 说明 | 8000 | 8000 采样率 | 11025 | 11025 采样率 | 12000 | 12000 采样率 | 16000 | 16000 采样率 | 22050 | 22050 采样率 | 24000 | 24000 采样率 | 32000 | 32000 采样率 | 44100 | 44100 采样率 | 48000 | 48000 采样率 |
| 合法值 | 说明 |
| 8000 | 8000 采样率 |
| 11025 | 11025 采样率 |
| 12000 | 12000 采样率 |
| 16000 | 16000 采样率 |
| 22050 | 22050 采样率 |
| 24000 | 24000 采样率 |
| 32000 | 32000 采样率 |
| 44100 | 44100 采样率 |
| 48000 | 48000 采样率 |
|  | numberOfChannels | number | 2 | 否 | 录音通道数 |  |
|  | 合法值 说明 1 1 个通道 2 2 个通道 | 合法值 | 说明 | 1 | 1 个通道 | 2 | 2 个通道 |
| 合法值 | 说明 |
| 1 | 1 个通道 |
| 2 | 2 个通道 |
|  | encodeBitRate | number | 48000 | 否 | 编码码率，有效值见下表格 |  |
|  | format | string | aac | 否 | 音频格式 |  |
|  | 合法值 说明 mp3 mp3 格式 aac aac 格式 wav wav 格式 PCM pcm 格式 | 合法值 | 说明 | mp3 | mp3 格式 | aac | aac 格式 | wav | wav 格式 | PCM | pcm 格式 |
| 合法值 | 说明 |
| mp3 | mp3 格式 |
| aac | aac 格式 |
| wav | wav 格式 |
| PCM | pcm 格式 |
|  | frameSize | number |  | 否 | 指定帧大小，单位 KB。传入 frameSize 后，每录制指定帧大小的内容后，会回调录制的文件内容，不指定则不会回调。暂仅支持 mp3、pcm 格式。 |  |
|  | audioSource | string | auto | 否 | 指定录音的音频输入源，可通过 wx.getAvailableAudioSources() 获取当前可用的音频源 | 2.1.0 |
|  | 合法值 说明 auto 自动设置，默认使用手机麦克风，插上耳麦后自动切换使用耳机麦克风，所有平台适用 buildInMic 手机麦克风，仅限 iOS headsetMic 有线耳机麦克风，仅限 iOS mic 麦克风（没插耳麦时是手机麦克风，插耳麦时是耳机麦克风），仅限 Android camcorder 同 mic，适用于录制音视频内容，仅限 Android voice_communication 同 mic，适用于实时沟通，仅限 Android voice_recognition 同 mic，适用于语音识别，仅限 Android | 合法值 | 说明 | auto | 自动设置，默认使用手机麦克风，插上耳麦后自动切换使用耳机麦克风，所有平台适用 | buildInMic | 手机麦克风，仅限 iOS | headsetMic | 有线耳机麦克风，仅限 iOS | mic | 麦克风（没插耳麦时是手机麦克风，插耳麦时是耳机麦克风），仅限 Android | camcorder | 同 mic，适用于录制音视频内容，仅限 Android | voice_communication | 同 mic，适用于实时沟通，仅限 Android | voice_recognition | 同 mic，适用于语音识别，仅限 Android |
| 合法值 | 说明 |
| auto | 自动设置，默认使用手机麦克风，插上耳麦后自动切换使用耳机麦克风，所有平台适用 |
| buildInMic | 手机麦克风，仅限 iOS |
| headsetMic | 有线耳机麦克风，仅限 iOS |
| mic | 麦克风（没插耳麦时是手机麦克风，插耳麦时是耳机麦克风），仅限 Android |
| camcorder | 同 mic，适用于录制音视频内容，仅限 Android |
| voice_communication | 同 mic，适用于实时沟通，仅限 Android |
| voice_recognition | 同 mic，适用于语音识别，仅限 Android |


### RequestTask.onChunkReceived(function listener)

基础库 2.20.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| data | ArrayBuffer | 返回的chunk buffer |


### RequestTask.onHeadersReceived(function listener)

基础库 2.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| header | Object | 开发者服务器返回的 HTTP Response Header |
| statusCode | Number | 开发者服务器返回的 HTTP 状态码 （目前开发者工具上不会返回 statusCode 字段，可用真机查看该字段，后续将会支持） |
| cookies | Array.<string> | 开发者服务器返回的 cookies，格式为字符串数组 |


### RewardedVideoAd.onClose(function listener)

# 功能描述

| 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- |
| isEnded | boolean | 视频是否是在用户完整观看的情况下被关闭的 | 2.1.0 |


### RewardedVideoAd.onError(function listener)

# 功能描述

|  | 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- |
|  | errMsg | string | 错误信息 |  |
|  | errCode | number | 错误码 | 2.2.2 |
|  | 合法值 说明 1000 后端接口调用失败 1001 参数错误 1002 广告单元无效 1003 内部错误 1004 无合适的广告 1005 广告组件审核中 1006 广告组件被驳回 1007 广告组件被封禁 1008 广告单元已关闭 | 合法值 | 说明 | 1000 | 后端接口调用失败 | 1001 | 参数错误 | 1002 | 广告单元无效 | 1003 | 内部错误 | 1004 | 无合适的广告 | 1005 | 广告组件审核中 | 1006 | 广告组件被驳回 | 1007 | 广告组件被封禁 | 1008 | 广告单元已关闭 |
| 合法值 | 说明 |
| 1000 | 后端接口调用失败 |
| 1001 | 参数错误 |
| 1002 | 广告单元无效 |
| 1003 | 内部错误 |
| 1004 | 无合适的广告 |
| 1005 | 广告组件审核中 |
| 1006 | 广告组件被驳回 |
| 1007 | 广告组件被封禁 |
| 1008 | 广告单元已关闭 |


### RewardedVideoAd.onLoad(function listener)

# 功能描述

| 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- |
| useFallbackSharePage | boolean | 仅小游戏支持，本次展示使用激励广告分享页 | 3.7.7 |


### SocketTask.close(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| code | number | 1000（表示正常关闭连接） | 否 | 一个数字值表示关闭连接的状态号，表示连接被关闭的原因。 |
| reason | string |  | 否 | 一个可读的字符串，表示连接被关闭的原因。这个字符串必须是不长于 123 字节的 UTF-8 文本（不是字符）。 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### SocketTask.onClose(function listener)

微信 Windows 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| code | number | 一个数字值表示关闭连接的状态号，表示连接被关闭的原因。 |
| reason | string | 一个可读的字符串，表示连接被关闭的原因。 |


### SocketTask.onError(function listener)

微信 Windows 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| errMsg | string | 错误信息 |


### SocketTask.onMessage(function listener)

微信 Windows 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| data | string/ArrayBuffer | 服务器返回的消息 |


### SocketTask.onOpen(function listener)

微信 Windows 版：支持

|  | 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- |
|  | header | object | 连接成功的 HTTP 响应 Header | 2.0.0 |
|  | profile | Object | 网络请求过程中一些调试信息 | 2.10.4 |
|  | 结构属性 类型 说明 fetchStart number 组件准备好使用 SOCKET 建立请求的时间，这发生在检查本地缓存之前 domainLookUpStart number DNS 域名查询开始的时间，如果使用了本地缓存（即无 DNS 查询）或持久连接，则与 fetchStart 值相等 domainLookUpEnd number DNS 域名查询完成的时间，如果使用了本地缓存（即无 DNS 查询）或持久连接，则与 fetchStart 值相等 connectStart number 开始建立连接的时间，如果是持久连接，则与 fetchStart 值相等。注意如果在传输层发生了错误且重新建立连接，则这里显示的是新建立的连接开始的时间 connectEnd number 完成建立连接的时间（完成握手），如果是持久连接，则与 fetchStart 值相等。注意如果在传输层发生了错误且重新建立连接，则这里显示的是新建立的连接完成的时间。注意这里握手结束，包括安全连接建立完成、SOCKS 授权通过 rtt number 单次连接的耗时，包括 connect ，tls handshakeCost number 握手耗时 cost number 上层请求到返回的耗时 |  | 结构属性 | 类型 | 说明 |  | fetchStart | number | 组件准备好使用 SOCKET 建立请求的时间，这发生在检查本地缓存之前 |  | domainLookUpStart | number | DNS 域名查询开始的时间，如果使用了本地缓存（即无 DNS 查询）或持久连接，则与 fetchStart 值相等 |  | domainLookUpEnd | number | DNS 域名查询完成的时间，如果使用了本地缓存（即无 DNS 查询）或持久连接，则与 fetchStart 值相等 |  | connectStart | number | 开始建立连接的时间，如果是持久连接，则与 fetchStart 值相等。注意如果在传输层发生了错误且重新建立连接，则这里显示的是新建立的连接开始的时间 |  | connectEnd | number | 完成建立连接的时间（完成握手），如果是持久连接，则与 fetchStart 值相等。注意如果在传输层发生了错误且重新建立连接，则这里显示的是新建立的连接完成的时间。注意这里握手结束，包括安全连接建立完成、SOCKS 授权通过 |  | rtt | number | 单次连接的耗时，包括 connect ，tls |  | handshakeCost | number | 握手耗时 |  | cost | number | 上层请求到返回的耗时 |
|  | 结构属性 | 类型 | 说明 |
|  | fetchStart | number | 组件准备好使用 SOCKET 建立请求的时间，这发生在检查本地缓存之前 |
|  | domainLookUpStart | number | DNS 域名查询开始的时间，如果使用了本地缓存（即无 DNS 查询）或持久连接，则与 fetchStart 值相等 |
|  | domainLookUpEnd | number | DNS 域名查询完成的时间，如果使用了本地缓存（即无 DNS 查询）或持久连接，则与 fetchStart 值相等 |
|  | connectStart | number | 开始建立连接的时间，如果是持久连接，则与 fetchStart 值相等。注意如果在传输层发生了错误且重新建立连接，则这里显示的是新建立的连接开始的时间 |
|  | connectEnd | number | 完成建立连接的时间（完成握手），如果是持久连接，则与 fetchStart 值相等。注意如果在传输层发生了错误且重新建立连接，则这里显示的是新建立的连接完成的时间。注意这里握手结束，包括安全连接建立完成、SOCKS 授权通过 |
|  | rtt | number | 单次连接的耗时，包括 connect ，tls |
|  | handshakeCost | number | 握手耗时 |
|  | cost | number | 上层请求到返回的耗时 |


### SocketTask.send(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| data | string/ArrayBuffer |  | 是 | 需要发送的内容 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Promise StoreGift.getOrderInfo()

基础库 3.8.12 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| orderStatus | number | 当前订单对应的状态码 |
| wishMessage | string | 当前订单对应的祝福语 |


### Promise StoreGift.open()

基础库 3.8.12 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| errCode | number | 错误码 |
| errMsg | string | 错误信息 |


### TCPSocket

基础库 3.1.1 开始支持，低版本需做兼容处理。

| 错误码 | 错误信息 | 说明 |
| --- | --- | --- |
| -1 |  | 系统错误 |
| -2 |  | socket接口错误，可参考系统的socket错误码 |
| -3 |  | 发送失败，无接口权限 |
| -4 |  | 链接失败 |
| 1 |  | 发送失败，参数错误，address不合法 |
| 2 |  | 发送失败，参数错误，port不合法 |
| 3 |  | 绑定wifi网络失败，BSSID不合法 |
| 4 |  | 绑定wifi网络失败，系统错误 |
| 5 |  | 绑定wifi网络失败，该接口仅在安卓平台支持 |
| 6 |  | 绑定wifi网络失败，低版本安卓不支持该接口 |


### TCPSocket.bindWifi(Object options)

基础库 3.1.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| BSSID | string |  | 是 | 当前 wifi 网络的 BSSID ，可通过 wx.getConnectedWifi 获取 |


### TCPSocket.connect(Object options)

微信 Windows 版：支持

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| address | string |  | 是 | 套接字要连接的地址 |  |
| port | number |  | 是 | 套接字要连接的端口 |  |
| timeout | number | 2 | 否 | 套接字要连接的超时时间，默认为 2s |  |
| enableHttpDNS | boolean | false | 否 | 是否开启 HttpDNS 服务。如开启，需要同时填入 httpDNSServiceId 。 HttpDNS 用法详见 移动解析HttpDNS | 3.4.0 |
| httpDNSServiceId | string |  | 否 | HttpDNS 服务商 Id。 HttpDNS 用法详见 移动解析HttpDNS | 3.4.0 |


### TCPSocket.onConnect(function listener)

微信 Windows 版：支持

|  | 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- |
|  | useHttpDNS | boolean | 本次连接是否使用了 HttpDNS | 3.4.0 |
|  | exception | Object | 网络请求过程中的一些异常信息（例如：TCPSocket.connect 传了 enableHttpDNS: true，但最终未使用 HttpDNS 时，exception 就会说明未使用 HttpDNS 的原因） | 3.4.0 |
|  | 结构属性 类型 说明 最低版本 reasons Array.<Object> 异常信息 3.4.0 结构属性 类型 说明 errMsg string 错误原因 errno string 错误码 |  | 结构属性 | 类型 | 说明 | 最低版本 |  | reasons | Array.<Object> | 异常信息 | 3.4.0 |  | 结构属性 类型 说明 errMsg string 错误原因 errno string 错误码 |  | 结构属性 | 类型 | 说明 |  | errMsg | string | 错误原因 |  | errno | string | 错误码 |
|  | 结构属性 | 类型 | 说明 | 最低版本 |
|  | reasons | Array.<Object> | 异常信息 | 3.4.0 |
|  | 结构属性 类型 说明 errMsg string 错误原因 errno string 错误码 |  | 结构属性 | 类型 | 说明 |  | errMsg | string | 错误原因 |  | errno | string | 错误码 |
|  | 结构属性 | 类型 | 说明 |
|  | errMsg | string | 错误原因 |
|  | errno | string | 错误码 |
|  | remoteInfo | Object | 发送端地址信息（目前仅iOS和Android端支持） | 3.4.1 |
|  | 结构属性 类型 说明 最低版本 address string 发送消息的 socket 的地址 3.4.1 family string 使用的协议族，为 IPv4 或者 IPv6 3.4.1 port number 端口号 3.4.1 |  | 结构属性 | 类型 | 说明 | 最低版本 |  | address | string | 发送消息的 socket 的地址 | 3.4.1 |  | family | string | 使用的协议族，为 IPv4 或者 IPv6 | 3.4.1 |  | port | number | 端口号 | 3.4.1 |
|  | 结构属性 | 类型 | 说明 | 最低版本 |
|  | address | string | 发送消息的 socket 的地址 | 3.4.1 |
|  | family | string | 使用的协议族，为 IPv4 或者 IPv6 | 3.4.1 |
|  | port | number | 端口号 | 3.4.1 |
|  | localInfo | Object | 接收端地址信息（目前仅iOS和Android端支持） | 3.4.1 |
|  | 结构属性 类型 说明 最低版本 address string 接收消息的 socket 的地址 3.4.1 family string 使用的协议族，为 IPv4 或者 IPv6 3.4.1 port number 端口号 3.4.1 |  | 结构属性 | 类型 | 说明 | 最低版本 |  | address | string | 接收消息的 socket 的地址 | 3.4.1 |  | family | string | 使用的协议族，为 IPv4 或者 IPv6 | 3.4.1 |  | port | number | 端口号 | 3.4.1 |
|  | 结构属性 | 类型 | 说明 | 最低版本 |
|  | address | string | 接收消息的 socket 的地址 | 3.4.1 |
|  | family | string | 使用的协议族，为 IPv4 或者 IPv6 | 3.4.1 |
|  | port | number | 端口号 | 3.4.1 |


### TCPSocket.onError(function listener)

微信 Windows 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| errMsg | string | 错误信息 |


### TCPSocket.onMessage(function listener)

微信 Windows 版：支持

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | message | ArrayBuffer | 收到的消息 |
|  | remoteInfo | Object | 发送端地址信息 |
|  | 结构属性 类型 说明 address string 发送消息的 socket 的地址 family string 使用的协议族，为 IPv4 或者 IPv6 port number 端口号 |  | 结构属性 | 类型 | 说明 |  | address | string | 发送消息的 socket 的地址 |  | family | string | 使用的协议族，为 IPv4 或者 IPv6 |  | port | number | 端口号 |
|  | 结构属性 | 类型 | 说明 |
|  | address | string | 发送消息的 socket 的地址 |
|  | family | string | 使用的协议族，为 IPv4 或者 IPv6 |
|  | port | number | 端口号 |
|  | localInfo | Object | 接收端地址信息 |
|  | 结构属性 类型 说明 address string 接收消息的 socket 的地址 family string 使用的协议族，为 IPv4 或者 IPv6 port number 端口号 |  | 结构属性 | 类型 | 说明 |  | address | string | 接收消息的 socket 的地址 |  | family | string | 使用的协议族，为 IPv4 或者 IPv6 |  | port | number | 端口号 |
|  | 结构属性 | 类型 | 说明 |
|  | address | string | 接收消息的 socket 的地址 |
|  | family | string | 使用的协议族，为 IPv4 或者 IPv6 |
|  | port | number | 端口号 |


### UDPSocket

基础库 2.7.0 开始支持，低版本需做兼容处理。

| 错误码 | 错误信息 | 说明 |
| --- | --- | --- |
| -1 |  | 系统错误 |
| -2 |  | socket接口错误，可参考系统的socket错误码 |
| -3 |  | 发送失败，无接口权限 |
| 1 |  | 发送失败，参数错误，address不合法 |
| 2 |  | 发送失败，参数错误，port不合法 |


### UDPSocket.connect(Object object)

基础库 2.15.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| address | string |  | 是 | 要发消息的地址 |
| port | number |  | 是 | 要发送消息的端口号 |


### UDPSocket.onError(function listener)

微信 Windows 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| errMsg | string | 错误信息 |


### UDPSocket.onMessage(function listener)

微信 Windows 版：支持

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | message | ArrayBuffer | 收到的消息。消息长度需要小于4096。 |
|  | remoteInfo | Object | 发送端地址信息 |
|  | 结构属性 类型 说明 address string 发送消息的 socket 的地址 family string 使用的协议族，为 IPv4 或者 IPv6 port number 端口号 size number message 的大小，单位：字节 |  | 结构属性 | 类型 | 说明 |  | address | string | 发送消息的 socket 的地址 |  | family | string | 使用的协议族，为 IPv4 或者 IPv6 |  | port | number | 端口号 |  | size | number | message 的大小，单位：字节 |
|  | 结构属性 | 类型 | 说明 |
|  | address | string | 发送消息的 socket 的地址 |
|  | family | string | 使用的协议族，为 IPv4 或者 IPv6 |
|  | port | number | 端口号 |
|  | size | number | message 的大小，单位：字节 |
|  | localInfo | Object | 接收端地址信息，2.18.0 起支持 |
|  | 结构属性 类型 说明 address string 接收消息的 socket 的地址 family string 使用的协议族，为 IPv4 或者 IPv6 port number 端口号 |  | 结构属性 | 类型 | 说明 |  | address | string | 接收消息的 socket 的地址 |  | family | string | 使用的协议族，为 IPv4 或者 IPv6 |  | port | number | 端口号 |
|  | 结构属性 | 类型 | 说明 |
|  | address | string | 接收消息的 socket 的地址 |
|  | family | string | 使用的协议族，为 IPv4 或者 IPv6 |
|  | port | number | 端口号 |


### UDPSocket.send(Object object)

微信 Windows 版：支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| address | string |  | 是 | 要发消息的地址。在基础库 <= 2.9.3 版本必须是和本机同网段的 IP 地址，或安全域名列表内的域名地址；之后版本可以是任意 IP 和域名 |
| port | number |  | 是 | 要发送消息的端口号 |
| message | string/ArrayBuffer |  | 是 | 要发送的数据 |
| offset | number | 0 | 否 | 发送数据的偏移量，仅当 message 为 ArrayBuffer 类型时有效 |
| length | number | message.byteLength | 否 | 发送数据的长度，仅当 message 为 ArrayBuffer 类型时有效 |
| setBroadcast | boolean | false | 否 | 向指定地址发消息时，是否要开启广播，基础库 2.24.0 开始支持 |


### UDPSocket.write(Object object)

基础库 2.15.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| address | string |  | 是 | 要发消息的地址。在基础库 <= 2.9.3 版本必须是和本机同网段的 IP 地址，或安全域名列表内的域名地址；之后版本可以是任意 IP 和域名 |
| port | number |  | 是 | 要发送消息的端口号 |
| message | string/ArrayBuffer |  | 是 | 要发送的数据 |
| offset | number | 0 | 否 | 发送数据的偏移量，仅当 message 为 ArrayBuffer 类型时有效 |
| length | number | message.byteLength | 否 | 发送数据的长度，仅当 message 为 ArrayBuffer 类型时有效 |
| setBroadcast | boolean | false | 否 | 向指定地址发消息时，是否要开启广播，基础库 2.24.0 开始支持 |


### UpdateManager.onCheckForUpdate(function listener)

# 功能描述

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| hasUpdate | boolean | 是否有新版本 |


### UploadTask.onHeadersReceived(function listener)

基础库 2.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| header | Object | 开发者服务器返回的 HTTP Response Header |


### UploadTask.onProgressUpdate(function listener)

基础库 1.4.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| progress | number | 上传进度百分比 |
| totalBytesSent | number | 已经上传的数据长度，单位 Bytes |
| totalBytesExpectedToSend | number | 预期需要上传的数据总长度，单位 Bytes |


### UserCryptoManager.getLatestUserKey(Object object)

基础库 2.17.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### UserCryptoManager.getRandomValues(Object object)

基础库 2.17.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| length | number |  | 是 | 整数，生成随机数的字节数，最大 1048576 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### UserInfo

用户头像昵称获取规则已调整，参考 用户信息接口调整说明、小程序用户头像昵称获取规则调整公告

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| 0 | 未知 |  |
| 1 | 男性 |  |
| 2 | 女性 |  |


### UserInfoButton

用户信息按钮

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| text | 可以设置背景色和文本的按钮 |  |
| image | 只能设置背景贴图的按钮，背景贴图会直接拉伸到按钮的宽高 |  |


### UserInfoButton.onTap(function listener)

微信 鸿蒙 OS 版：支持

| 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- |
| userInfo | UserInfo | 用户信息对象，不包含 openid 等敏感信息 |  |
| rawData | string | 不包括敏感信息的原始数据字符串，用于计算签名 |  |
| signature | string | 使用 sha1( rawData + sessionkey ) 得到字符串，用于校验用户信息，参考文档signature |  |
| encryptedData | string | 包括敏感数据在内的完整用户信息的加密数据，详细见加密数据解密算法 |  |
| iv | string | 加密算法的初始向量，详细见加密数据解密算法 |  |
| cloudID | string | 敏感数据对应的云 ID，开通云开发的小程序才会返回，可通过云调用直接获取开放数据，详细见云调用直接获取开放数据 | 2.7.0 |
| errMsg | string | 调用结果（错误原因） |  |


### Object VideoDecoder.getFrameData()

基础库 2.11.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| width | number | 帧数据宽度 |
| height | number | 帧数据高度 |
| data | ArrayBuffer | 帧数据 |
| pkPts | number | 帧原始 pts |
| pkDts | number | 帧原始 dts |


### VideoDecoder.on(string eventName, function callback)

基础库 2.11.1 开始支持，低版本需做兼容处理。

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| start | 开始事件。返回 {width, height} |  |
| stop | 结束事件。 |  |
| seek | seek 完成事件。 |  |
| bufferchange | 缓冲区变化事件。 |  |
| ended | 解码结束事件。 |  |


### Promise VideoDecoder.start(Object object)

基础库 2.11.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| source | string |  | 是 | 需要解码的视频源文件。基础库 2.13.0 以下的版本只支持本地路径。 2.13.0 开始支持 http:// 和 https:// 协议的远程路径。 |  |
| mode | number | 1 | 否 | 解码模式。0：按 pts 解码；1：以最快速度解码 |  |
| abortAudio | boolean | false | 否 | 是否不需要音频轨道 | 2.15.0 |
| abortVideo | boolean | false | 否 | 是否不需要视频轨道 | 2.15.0 |


### Video.onError(function listener)

微信 鸿蒙 OS 版：支持

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | errMsg | string | 错误信息 |
|  | 合法值 说明 MEDIA_ERR_NETWORK 当下载时发生错误 MEDIA_ERR_DECODE 当解码时发生错误 MEDIA_ERR_SRC_NOT_SUPPORTED video 的 src 属性是不支持的资源类型 | 合法值 | 说明 | MEDIA_ERR_NETWORK | 当下载时发生错误 | MEDIA_ERR_DECODE | 当解码时发生错误 | MEDIA_ERR_SRC_NOT_SUPPORTED | video 的 src 属性是不支持的资源类型 |
| 合法值 | 说明 |
| MEDIA_ERR_NETWORK | 当下载时发生错误 |
| MEDIA_ERR_DECODE | 当解码时发生错误 |
| MEDIA_ERR_SRC_NOT_SUPPORTED | video 的 src 属性是不支持的资源类型 |


### Video.onProgress(function listener)

微信 鸿蒙 OS 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| buffered | number | 当前的缓冲进度，缓冲进度区间为 (0~100]，100表示缓冲完成 |
| duration | number | 视频的总时长，单位为秒 |


### Video.onTimeUpdate(function listener)

微信 鸿蒙 OS 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| position | number | 当前的播放位置，单位为秒 |
| duration | number | 视频的总时长，单位为秒 |


### Promise Video.requestFullScreen(number direction)

微信 鸿蒙 OS 版：支持

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| 0 | 正常竖向 |  |
| 90 | 屏幕逆时针90度 |  |
| -90 | 屏幕顺时针90度 |  |


### VKBodyAnchor

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| 5 | 人体 |  |


### VKDepthAnchor

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| 8 | DEPTH |  |


### VKFaceAnchor

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| 3 | 人脸 |  |


### Object VKFrame.getCameraTexture(WebGLRenderingContext gl)

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| yTexture | WebGLTexture | Y 分量纹理 |
| uvTexture | WebGLTexture | UV 分量纹理 |


### Object VKFrame.getDepthBuffer()

基础库 3.0.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| width | number | 深度纹理宽 |
| height | number | 深度纹理高 |
| DepthAddress | ArrayBuffer | 深度纹理buffer |


### Object VKFrame.getLegSegmentBuffer()

基础库 3.2.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| width | number | 腿部分割纹理宽 |
| height | number | 腿部分割纹理高 |
| DepthAddress | ArrayBuffer | 腿部分割纹理buffer，width * height 大小的 裁剪值（0 为不是脚，越靠近 255 越接近腿部区域）（uint8） |


### VKHandAnchor

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| 7 | 手势 |  |


### VKMarkerAnchor

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| 1 | marker |  |


### VKOCRAnchor

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| 6 | OCR |  |


### VKOSDAnchor

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| 2 | OSD |  |


### VKPlaneAnchor

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| 0 | 平面 |  |


### VKSession

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| 0 | 不可用 |  |
| 1 | 运行中 |  |
| 2 | 暂停中 |  |
| 3 | 初始化中 | 2.29.0 |


### VKSession.detectBody(Object object)

基础库 2.32.1 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | frameBuffer | ArrayBuffer |  | 是 | 人脸图像像素点数据，每四项表示一个像素点的 RGBA |
|  | width | number |  | 是 | 图像宽度 |
|  | height | number |  | 是 | 图像高度 |
|  | scoreThreshold | number | 0.8 | 否 | 评分阈值。正常情况传入 0.8 即可。 |
|  | sourceType | number | 1 | 否 | 图像源类型。正常情况传入 1 即可。当输入的图片是来自一个连续视频的每一帧图像时，sourceType 传入 0 会得到更优的效果 |
|  | 合法值 说明 1 表示输入的图片是随机的图片 0 表示输入的图片是来自一个连续视频的每一帧图像 | 合法值 | 说明 | 1 | 表示输入的图片是随机的图片 | 0 | 表示输入的图片是来自一个连续视频的每一帧图像 |
| 合法值 | 说明 |
| 1 | 表示输入的图片是随机的图片 |
| 0 | 表示输入的图片是来自一个连续视频的每一帧图像 |


### VKSession.detectDepth(Object object)

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| frameBuffer | ArrayBuffer |  | 是 | 需要识别深度的图像像素点数据，每四项表示一个像素点的 RGBA |
| width | number |  | 是 | 图像宽度 |
| height | number |  | 是 | 图像高度 |


### VKSession.detectFace(Object object)

基础库 2.32.1 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | frameBuffer | ArrayBuffer |  | 是 | 人脸图像像素点数据，每四项表示一个像素点的 RGBA |
|  | width | number |  | 是 | 图像宽度 |
|  | height | number |  | 是 | 图像高度 |
|  | scoreThreshold | number | 0.8 | 否 | 评分阈值。正常情况传入 0.8 即可。 |
|  | sourceType | number | 1 | 否 | 图像源类型。正常情况传入 1 即可。当输入的图片是来自一个连续视频的每一帧图像时，sourceType 传入 0 会得到更优的效果 |
|  | 合法值 说明 1 表示输入的图片是随机的图片 0 表示输入的图片是来自一个连续视频的每一帧图像 | 合法值 | 说明 | 1 | 表示输入的图片是随机的图片 | 0 | 表示输入的图片是来自一个连续视频的每一帧图像 |
| 合法值 | 说明 |
| 1 | 表示输入的图片是随机的图片 |
| 0 | 表示输入的图片是来自一个连续视频的每一帧图像 |
|  | modelModel | number | 1 | 否 | 算法模型类型。正常情况传入 1 即可。0、1、2 分别表示小、中、大模型，模型越大识别准确率越高，但资源占用也越高。建议根据用户设备性能进行选择。 |
|  | 合法值 说明 0 小模型 1 中模型 2 大模型 | 合法值 | 说明 | 0 | 小模型 | 1 | 中模型 | 2 | 大模型 |
| 合法值 | 说明 |
| 0 | 小模型 |
| 1 | 中模型 |
| 2 | 大模型 |
|  | pupilInfo | boolean | false | 否 | 是否返回瞳孔周围点信息，默认为 false。 |


### VKSession.detectHand(Object object)

基础库 2.32.1 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | frameBuffer | ArrayBuffer |  | 是 | 人脸图像像素点数据，每四项表示一个像素点的 RGBA |
|  | width | number |  | 是 | 图像宽度 |
|  | height | number |  | 是 | 图像高度 |
|  | scoreThreshold | number | 0.8 | 否 | 评分阈值。正常情况传入 0.8 即可。 |
|  | algoMode | number |  | 否 | 算法检测模式 |
|  | 合法值 说明 0 检测模式，输出框和点 1 手势模式，输出框和手势分类 2 结合0和1模式，输出框、点、手势分类 | 合法值 | 说明 | 0 | 检测模式，输出框和点 | 1 | 手势模式，输出框和手势分类 | 2 | 结合0和1模式，输出框、点、手势分类 |
| 合法值 | 说明 |
| 0 | 检测模式，输出框和点 |
| 1 | 手势模式，输出框和手势分类 |
| 2 | 结合0和1模式，输出框、点、手势分类 |


### Array.<Object> VKSession.getAllMarker()

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| markerId | number | marker id |
| path | string | 图片路径 |


### Array.<Object> VKSession.getAllOSDMarker()

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| markerId | number | marker id |
| path | string | 图片路径 |


### Array.<Object> VKSession.hitTest(number x, number y, Object reset)

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| transform | Float32Array | 包含位置、旋转、放缩信息的矩阵，以列为主序 |


### VKSession.on(string eventName, function fn)

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| resize | 相机尺寸变化事件，回调参数为相机尺寸 |  |
| addAnchors | 增加 anchor 事件，回调参数为 VKPlaneAnchor/VKMarkerAnchor/VKOSDAnchor 列表（只有v2版本支持） 或 VKFaceAnchor/VKOCRAnchor/VKHandAnchor/VKBodyAnchor列表（v1、v2都支持） | 2.22.0 |
| updateAnchors | 更新 anchor 事件，回调参数为 VKPlaneAnchor/VKMarkerAnchor/VKOSDAnchor 列表（只有v2版本支持） 或 VKFaceAnchor/VKOCRAnchor/VKHandAnchor/VKBodyAnchor列表（v1、v2都支持） | 2.22.0 |
| removeAnchors | 删除 anchor 事件，回调参数为 VKPlaneAnchor/VKMarkerAnchor/VKOSDAnchor 列表（只有v2版本支持） 或 VKFaceAnchor/VKOCRAnchor/VKHandAnchor/VKBodyAnchor 列表（v1、v2都支持） | 2.22.0 |


### VKSession.runOCR(Object object)

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| frameBuffer | ArrayBuffer |  | 是 | 待识别图像的像素点数据，每四项表示一个像素点的 RGBA |
| width | number |  | 是 | 图像宽度 |
| height | number |  | 是 | 图像高度 |


### VKSession.start(function callback)

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| 0 | 成功 |  |
| 104 | 用户取消授权 |  |
| 112 | 接口未在隐私协议中声明 |  |
| 1025 | 小程序隐私接口被封禁，解决方案参考链接 |  |
| 1026 | 小游戏隐私接口被封禁，解决方案参考链接 |  |
| 2000001 | 参数错误 |  |
| 2003000 | 会话不可用 |  |
| 2000000 | 系统错误 |  |
| 2000002 | 设备不支持 |  |
| 2000003 | 系统不支持 |  |
| 2000004 | 设备不支持 |  |
| 2003001 | 未开启系统相机权限 |  |
| 2003002 | 未开启小程序相机权限 |  |


### VKSession.update3DMode(Object object)

基础库 2.32.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| open3d | boolean |  | 是 | 是否开启三维识别 |


### VKSession.updateMaskMode(Object object)

基础库 3.2.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| useMask | boolean |  | 是 | 设置是否开启试鞋，返回腿部遮挡纹理 |


### PeriodicWaveNode WebAudioContext.createPeriodicWave(Float32Array real, Float32Array imag, object constraints)

# 功能描述

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| disableNormalization | boolean |  | 否 | 如果指定为true则禁用标准化，默认为false |


### Worker

相关文档: 多线程 Worker

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| USER_DATA_PATH | string | 文件系统中的用户目录路径 (本地路径) |


### Worker.onError(function listener)

相关文档: 多线程 Worker

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| error | Object | 错误对象 |


### Worker.onMessage(function listener)

相关文档: 多线程 Worker

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| message | Object | 主线程/Worker 线程向当前线程发送的消息 |


### wx.addCard(Object object)

基础库 2.5.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | cardList | Array.<Object> |  | 是 | 需要添加的卡券列表 |
|  | 结构属性 类型 默认值 必填 说明 cardId string 是 卡券 ID cardExt string 是 卡券的扩展参数。需将 CardExt 对象 JSON 序列化为**字符串**传入 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | cardId | string |  | 是 | 卡券 ID |  | cardExt | string |  | 是 | 卡券的扩展参数。需将 CardExt 对象 JSON 序列化为**字符串**传入 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | cardId | string |  | 是 | 卡券 ID |
|  | cardExt | string |  | 是 | 卡券的扩展参数。需将 CardExt 对象 JSON 序列化为**字符串**传入 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.authorize(Object object)

基础库 1.2.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| scope | string |  | 是 | 需要获取权限的 scope，详见 scope 列表 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.authPrivateMessage(Object object)

基础库 2.13.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| shareTicket | string |  | 是 | shareTicket。可以从 wx.getEnterOptionsSync 中获取。详情 shareTicket |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.checkHandoffEnabled(Object object)

基础库 2.14.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.checkIsAddedToMyMiniProgram(Object object)

基础库 2.30.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.checkSession(Object object)

以 Promise 风格 调用：支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.chooseImage(Object object)

从基础库 2.21.0 开始，本接口停止维护，请使用 wx.chooseMedia 代替

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | count | number | 9 | 否 | 最多可以选择的图片张数 |
|  | sizeType | Array.<string> | ['original', 'compressed'] | 否 | 所选的图片的尺寸 |
|  | 合法值 说明 original 原图 compressed 压缩图 | 合法值 | 说明 | original | 原图 | compressed | 压缩图 |
| 合法值 | 说明 |
| original | 原图 |
| compressed | 压缩图 |
|  | sourceType | Array.<string> | ['album', 'camera'] | 否 | 选择图片的来源 |
|  | 合法值 说明 album 从相册选图 camera 使用相机 | 合法值 | 说明 | album | 从相册选图 | camera | 使用相机 |
| 合法值 | 说明 |
| album | 从相册选图 |
| camera | 使用相机 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.chooseMedia(Object object)

基础库 2.23.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | count | number | 9 | 否 | 最多可以选择的文件个数，基础库2.25.0前，最多可支持9个文件，2.25.0及以后最多可支持20个文件 |
|  | mediaType | Array.<string> | ['image', 'video'] | 否 | 文件类型 |
|  | 合法值 说明 image 只能拍摄图片或从相册选择图片 video 只能拍摄视频或从相册选择视频 mix 可同时选择图片和视频 | 合法值 | 说明 | image | 只能拍摄图片或从相册选择图片 | video | 只能拍摄视频或从相册选择视频 | mix | 可同时选择图片和视频 |
| 合法值 | 说明 |
| image | 只能拍摄图片或从相册选择图片 |
| video | 只能拍摄视频或从相册选择视频 |
| mix | 可同时选择图片和视频 |
|  | sourceType | Array.<string> | ['album', 'camera'] | 否 | 图片和视频选择的来源 |
|  | 合法值 说明 album 从相册选择 camera 使用相机拍摄 | 合法值 | 说明 | album | 从相册选择 | camera | 使用相机拍摄 |
| 合法值 | 说明 |
| album | 从相册选择 |
| camera | 使用相机拍摄 |
|  | maxDuration | number | 10 | 否 | 拍摄视频最长拍摄时间，单位秒。时间范围为 3s 至 60s 之间。不限制相册。 |
|  | sizeType | Array.<string> | ['original', 'compressed'] | 否 | 是否压缩所选文件，基础库2.25.0前仅对 mediaType 为 image 时有效，2.25.0及以后对全量 mediaType 有效 |
|  | camera | string | 'back' | 否 | 仅在 sourceType 为 camera 时生效，使用前置或后置摄像头 |
|  | 合法值 说明 back 使用后置摄像头 front 使用前置摄像头 | 合法值 | 说明 | back | 使用后置摄像头 | front | 使用前置摄像头 |
| 合法值 | 说明 |
| back | 使用后置摄像头 |
| front | 使用前置摄像头 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.chooseMessageFile(Object object)

基础库 2.23.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- | --- |
|  | count | number |  | 是 | 最多可以选择的文件个数，可以 0～100 |  |
|  | type | string | 'all' | 否 | 所选的文件的类型 |  |
|  | 合法值 说明 all 从所有文件选择 video 只能选择视频文件 image 只能选择图片文件 file 可以选择除了图片和视频之外的其它的文件 | 合法值 | 说明 | all | 从所有文件选择 | video | 只能选择视频文件 | image | 只能选择图片文件 | file | 可以选择除了图片和视频之外的其它的文件 |
| 合法值 | 说明 |
| all | 从所有文件选择 |
| video | 只能选择视频文件 |
| image | 只能选择图片文件 |
| file | 可以选择除了图片和视频之外的其它的文件 |
|  | extension | Array.<string> |  | 否 | 根据文件拓展名过滤，仅 type==file 时有效。每一项都不能是空字符串。默认不过滤。 | 2.6.0 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |  |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |  |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.clearStorage(Object object)

以 Promise 风格 调用：支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.closeBLEConnection(Object object)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| deviceId | string |  | 是 | 蓝牙设备 id |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.closeBluetoothAdapter(Object object)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.closeSocket(Object object)

推荐使用 SocketTask 的方式去管理 webSocket 链接，每一条链路的生命周期都更加可控，同时存在多个 webSocket 的链接的情况下使用 wx 前缀的方法可能会带来一些和预期不一致的情况。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| code | number | 1000（表示正常关闭连接） | 否 | 一个数字值表示关闭连接的状态号，表示连接被关闭的原因。 |
| reason | string |  | 否 | 一个可读的字符串，表示连接被关闭的原因。这个字符串必须是不长于 123 字节的 UTF-8 文本（不是字符）。 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.compressImage(Object object)

基础库 3.0.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| src | string |  | 是 | 图片路径，图片的路径，支持本地路径、代码包路径 |  |
| quality | number | 80 | 否 | 压缩质量，范围0～100，数值越小，质量越低，压缩率越高（仅对jpg有效）。 |  |
| compressedWidth | number |  | 否 | 压缩后图片的宽度，单位为px，若不填写则默认以compressedHeight为准等比缩放。 | 2.26.0 |
| compressedHeight | number |  | 否 | 压缩后图片的高度，单位为px，若不填写则默认以compressedWidth为准等比缩放 | 2.26.0 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### SocketTask wx.connectSocket(Object object)

推荐使用 SocketTask 的方式去管理 webSocket 链接，每一条链路的生命周期都更加可控，同时存在多个 webSocket 的链接的情况下使用 wx 前缀的方法可能会带来一些和预期不一致的情况。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| url | string |  | 是 | 开发者服务器 wss 接口地址 |  |
| header | Object |  | 否 | HTTP Header，Header 中不能设置 Referer |  |
| protocols | Array.<string> |  | 否 | 子协议数组 | 1.4.0 |
| tcpNoDelay | boolean | false | 否 | 建立 TCP 连接的时候的 TCP_NODELAY 设置 | 2.4.0 |
| perMessageDeflate | boolean | false | 否 | 是否开启压缩扩展 | 2.8.0 |
| timeout | number |  | 否 | 超时时间，单位为毫秒 | 2.10.0 |
| forceCellularNetwork | boolean | false | 否 | 强制使用蜂窝网络发送请求 | 2.29.0 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### BannerAd wx.createBannerAd(Object object)

从基础库 3.5.5 开始，本接口停止维护，请使用 wx.createCustomAd 代替

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | adUnitId | string |  | 是 | 广告单元 id |
|  | adIntervals | number |  | 否 | 广告自动刷新的间隔时间，单位为秒，参数值必须大于等于30（该参数不传入时 Banner 广告不会自动刷新） |
|  | style | Object |  | 是 | banner 广告组件的样式 |
|  | 结构属性 类型 默认值 必填 说明 left number 是 banner 广告组件的左上角横坐标 top number 是 banner 广告组件的左上角纵坐标 width number 是 banner 广告组件的宽度 height number 是 banner 广告组件的高度 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | left | number |  | 是 | banner 广告组件的左上角横坐标 |  | top | number |  | 是 | banner 广告组件的左上角纵坐标 |  | width | number |  | 是 | banner 广告组件的宽度 |  | height | number |  | 是 | banner 广告组件的高度 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | left | number |  | 是 | banner 广告组件的左上角横坐标 |
|  | top | number |  | 是 | banner 广告组件的左上角纵坐标 |
|  | width | number |  | 是 | banner 广告组件的宽度 |
|  | height | number |  | 是 | banner 广告组件的高度 |


### wx.createBLEConnection(Object object)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| deviceId | string |  | 是 | 蓝牙设备 id |
| timeout | number |  | 否 | 超时时间，单位 ms，不填表示不会超时 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.createBLEPeripheralServer(Object object)

基础库 2.10.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Camera wx.createCamera(Object object)

基础库 2.9.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| x | number | 0 | 否 | 相机的左上角横坐标 |
| y | number | 0 | 否 | 相机的左上角纵坐标 |
| width | number | 300 | 否 | 相机的宽度 |
| height | number | 150 | 否 | 相机的高度 |
| devicePosition | string | back | 否 | 摄像头朝向，值为 front, back |
| flash | string | auto | 否 | 闪光灯，值为 auto, on, off |
| size | string | small | 否 | 帧数据图像尺寸，值为 small, medium, large |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### CustomAd wx.createCustomAd(Object object)

基础库 2.11.1 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | adUnitId | string |  | 是 | 广告单元 id |
|  | adIntervals | number |  | 是 | 广告自动刷新的间隔时间，单位为秒，参数值必须大于等于30（仅对支持自动刷新的模板生效） |
|  | style | Object |  | 是 | 原生模板广告组件的样式 |
|  | 结构属性 类型 默认值 必填 说明 left number 是 原生模板广告组件的左上角横坐标 top number 是 原生模板广告组件的左上角纵坐标 width number 是 原生模板广告组件的宽度（仅在某些模板生效，如矩阵格子） fixed boolean 是 (只对小程序适用) 原生模板广告组件是否固定屏幕位置（不跟随屏幕滚动） |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | left | number |  | 是 | 原生模板广告组件的左上角横坐标 |  | top | number |  | 是 | 原生模板广告组件的左上角纵坐标 |  | width | number |  | 是 | 原生模板广告组件的宽度（仅在某些模板生效，如矩阵格子） |  | fixed | boolean |  | 是 | (只对小程序适用) 原生模板广告组件是否固定屏幕位置（不跟随屏幕滚动） |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | left | number |  | 是 | 原生模板广告组件的左上角横坐标 |
|  | top | number |  | 是 | 原生模板广告组件的左上角纵坐标 |
|  | width | number |  | 是 | 原生模板广告组件的宽度（仅在某些模板生效，如矩阵格子） |
|  | fixed | boolean |  | 是 | (只对小程序适用) 原生模板广告组件是否固定屏幕位置（不跟随屏幕滚动） |


### FeedbackButton wx.createFeedbackButton(Object object)

基础库 2.1.2 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | type | string |  | 是 | 按钮的类型。 |
|  | 合法值 说明 text 可以设置背景色和文本的按钮 image 只能设置背景贴图的按钮，背景贴图会直接拉伸到按钮的宽高 | 合法值 | 说明 | text | 可以设置背景色和文本的按钮 | image | 只能设置背景贴图的按钮，背景贴图会直接拉伸到按钮的宽高 |
| 合法值 | 说明 |
| text | 可以设置背景色和文本的按钮 |
| image | 只能设置背景贴图的按钮，背景贴图会直接拉伸到按钮的宽高 |
|  | text | string |  | 否 | 按钮上的文本，仅当 type 为 text 时有效 |
|  | image | string |  | 否 | 按钮的背景图片，仅当 type 为 image 时有效 |
|  | style | Object |  | 是 | 按钮的样式 |
|  | 结构属性 类型 默认值 必填 说明 left number 是 左上角横坐标 top number 是 左上角纵坐标 width number 是 宽度 height number 是 高度 backgroundColor string 是 背景颜色 borderColor string 否 边框颜色 borderWidth number 否 边框宽度 borderRadius number 否 边框圆角 color string 否 文本的颜色。格式为 6 位 16 进制数。 textAlign string 否 文本的水平居中方式 合法值 说明 left 居左 center 居中 right 居右 fontSize number 否 字号 lineHeight number 否 文本的行高 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | left | number |  | 是 | 左上角横坐标 |  | top | number |  | 是 | 左上角纵坐标 |  | width | number |  | 是 | 宽度 |  | height | number |  | 是 | 高度 |  | backgroundColor | string |  | 是 | 背景颜色 |  | borderColor | string |  | 否 | 边框颜色 |  | borderWidth | number |  | 否 | 边框宽度 |  | borderRadius | number |  | 否 | 边框圆角 |  | color | string |  | 否 | 文本的颜色。格式为 6 位 16 进制数。 |  | textAlign | string |  | 否 | 文本的水平居中方式 |  | 合法值 说明 left 居左 center 居中 right 居右 | 合法值 | 说明 | left | 居左 | center | 居中 | right | 居右 |  | fontSize | number |  | 否 | 字号 |  | lineHeight | number |  | 否 | 文本的行高 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | left | number |  | 是 | 左上角横坐标 |
|  | top | number |  | 是 | 左上角纵坐标 |
|  | width | number |  | 是 | 宽度 |
|  | height | number |  | 是 | 高度 |
|  | backgroundColor | string |  | 是 | 背景颜色 |
|  | borderColor | string |  | 否 | 边框颜色 |
|  | borderWidth | number |  | 否 | 边框宽度 |
|  | borderRadius | number |  | 否 | 边框圆角 |
|  | color | string |  | 否 | 文本的颜色。格式为 6 位 16 进制数。 |
|  | textAlign | string |  | 否 | 文本的水平居中方式 |
|  | 合法值 说明 left 居左 center 居中 right 居右 | 合法值 | 说明 | left | 居左 | center | 居中 | right | 居右 |
| 合法值 | 说明 |
| left | 居左 |
| center | 居中 |
| right | 居右 |
|  | fontSize | number |  | 否 | 字号 |
|  | lineHeight | number |  | 否 | 文本的行高 |


### GameClubButton wx.createGameClubButton(Object object)

基础库 2.0.3 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- | --- |
|  | type | string |  | 是 | 按钮的类型。 |  |
|  | 合法值 说明 text 可以设置背景色和文本的按钮 image 只能设置背景贴图的按钮，背景贴图会直接拉伸到按钮的宽高 | 合法值 | 说明 | text | 可以设置背景色和文本的按钮 | image | 只能设置背景贴图的按钮，背景贴图会直接拉伸到按钮的宽高 |
| 合法值 | 说明 |
| text | 可以设置背景色和文本的按钮 |
| image | 只能设置背景贴图的按钮，背景贴图会直接拉伸到按钮的宽高 |
|  | text | string |  | 否 | 按钮上的文本，仅当 type 为 text 时有效 |  |
|  | image | string |  | 否 | 按钮的背景图片，仅当 type 为 image 时有效 |  |
|  | style | Object |  | 是 | 按钮的样式 |  |
|  | 结构属性 类型 默认值 必填 说明 left number 是 左上角横坐标 top number 是 左上角纵坐标 width number 是 宽度 height number 是 高度 backgroundColor string 是 背景颜色 borderColor string 否 边框颜色 borderWidth number 否 边框宽度 borderRadius number 否 边框圆角 color string 否 文本的颜色。格式为 6 位 16 进制数。 textAlign string 否 文本的水平居中方式 合法值 说明 left 居左 center 居中 right 居右 fontSize number 否 字号 lineHeight number 否 文本的行高 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | left | number |  | 是 | 左上角横坐标 |  | top | number |  | 是 | 左上角纵坐标 |  | width | number |  | 是 | 宽度 |  | height | number |  | 是 | 高度 |  | backgroundColor | string |  | 是 | 背景颜色 |  | borderColor | string |  | 否 | 边框颜色 |  | borderWidth | number |  | 否 | 边框宽度 |  | borderRadius | number |  | 否 | 边框圆角 |  | color | string |  | 否 | 文本的颜色。格式为 6 位 16 进制数。 |  | textAlign | string |  | 否 | 文本的水平居中方式 |  | 合法值 说明 left 居左 center 居中 right 居右 | 合法值 | 说明 | left | 居左 | center | 居中 | right | 居右 |  | fontSize | number |  | 否 | 字号 |  | lineHeight | number |  | 否 | 文本的行高 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | left | number |  | 是 | 左上角横坐标 |
|  | top | number |  | 是 | 左上角纵坐标 |
|  | width | number |  | 是 | 宽度 |
|  | height | number |  | 是 | 高度 |
|  | backgroundColor | string |  | 是 | 背景颜色 |
|  | borderColor | string |  | 否 | 边框颜色 |
|  | borderWidth | number |  | 否 | 边框宽度 |
|  | borderRadius | number |  | 否 | 边框圆角 |
|  | color | string |  | 否 | 文本的颜色。格式为 6 位 16 进制数。 |
|  | textAlign | string |  | 否 | 文本的水平居中方式 |
|  | 合法值 说明 left 居左 center 居中 right 居右 | 合法值 | 说明 | left | 居左 | center | 居中 | right | 居右 |
| 合法值 | 说明 |
| left | 居左 |
| center | 居中 |
| right | 居右 |
|  | fontSize | number |  | 否 | 字号 |
|  | lineHeight | number |  | 否 | 文本的行高 |
|  | icon | string |  | 是 | 游戏圈按钮的图标，仅当 object.type 参数为 image 时有效。 |  |
|  | 合法值 说明 green 绿色的图标 white 白色的图标 dark 有黑色圆角背景的白色图标 light 有白色圆角背景的绿色图标 | 合法值 | 说明 | green | 绿色的图标 | white | 白色的图标 | dark | 有黑色圆角背景的白色图标 | light | 有白色圆角背景的绿色图标 |
| 合法值 | 说明 |
| green | 绿色的图标 |
| white | 白色的图标 |
| dark | 有黑色圆角背景的白色图标 |
| light | 有白色圆角背景的绿色图标 |
|  | openlink | string |  | 否 | 设置后可以跳到对应的活动页面，具体进入「MP后台-能力地图-游戏圈」-由帖子的"游戏内跳转ID"生成 | 2.30.3 |
|  | hasRedDot | boolean | true | 否 | 当传递了openlink值时，此字段生效，决定创建的按钮是否需要拥有红点，默认为true | 2.30.3 |


### GameRecorderShareButton wx.createGameRecorderShareButton(Object object)

基础库 2.8.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | style | Object |  | 是 | 按钮的样式 |
|  | 结构属性 类型 默认值 必填 说明 left number 0 否 左上角横坐标，单位 逻辑像素 top number 0 否 左上角纵坐标，单位 逻辑像素 height number 40 否 按钮的高度，最小 40 逻辑像素 iconMarginRight number 8 否 图标和文本之间的距离，最小 8 逻辑像素 fontSize number 17 否 文本的字体大小。最小 17，最大 22。 color string #ffffff 否 文本的颜色。 paddingLeft number 16 否 按钮的左内边距，最小 16 逻辑像素。 paddingRight number 16 否 按钮的右内边距，最小 16 逻辑像素。 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | left | number | 0 | 否 | 左上角横坐标，单位 逻辑像素 |  | top | number | 0 | 否 | 左上角纵坐标，单位 逻辑像素 |  | height | number | 40 | 否 | 按钮的高度，最小 40 逻辑像素 |  | iconMarginRight | number | 8 | 否 | 图标和文本之间的距离，最小 8 逻辑像素 |  | fontSize | number | 17 | 否 | 文本的字体大小。最小 17，最大 22。 |  | color | string | #ffffff | 否 | 文本的颜色。 |  | paddingLeft | number | 16 | 否 | 按钮的左内边距，最小 16 逻辑像素。 |  | paddingRight | number | 16 | 否 | 按钮的右内边距，最小 16 逻辑像素。 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | left | number | 0 | 否 | 左上角横坐标，单位 逻辑像素 |
|  | top | number | 0 | 否 | 左上角纵坐标，单位 逻辑像素 |
|  | height | number | 40 | 否 | 按钮的高度，最小 40 逻辑像素 |
|  | iconMarginRight | number | 8 | 否 | 图标和文本之间的距离，最小 8 逻辑像素 |
|  | fontSize | number | 17 | 否 | 文本的字体大小。最小 17，最大 22。 |
|  | color | string | #ffffff | 否 | 文本的颜色。 |
|  | paddingLeft | number | 16 | 否 | 按钮的左内边距，最小 16 逻辑像素。 |
|  | paddingRight | number | 16 | 否 | 按钮的右内边距，最小 16 逻辑像素。 |
|  | icon | string |  | 否 | 图标的 url。支持 http/https 开头的网络资源和 wxfile:// 开头的本地资源。如果不设置则使用默认图标。 |
|  | image | string |  | 否 | 按钮的背景图片的 url。支持 http/https 开头的网络资源和 wxfile:// 开头的本地资源。如果不设置则使用默认图标。 |
|  | text | string |  | 否 | 按钮的文本。 |
|  | share | Object |  | 是 | 对局回放的分享参数。 |
|  | 结构属性 类型 默认值 必填 说明 最低版本 query string 否 分享的对局回放打开后跳转小游戏的 query。 path string 否 分享的对局回放打开后跳转小游戏的 path （独立分包路径）。详见 小游戏独立分包指南 2.13.2 bgm string 是 对局回放背景音乐的地址。必须是一个代码包文件路径或者 wxfile:// 文件路径，不支持 http/https 开头的 url。 timeRange Array.<Array.<number>> 是 对局回放的剪辑区间，是一个二维数组，单位 ms（毫秒）。[[1000, 3000], [4000, 5000]] 表示剪辑已录制对局回放的 1-3 秒和 4-5 秒最终合成为一个 3 秒的对局回放。对局回放剪辑后的总时长最多 60 秒，即 1 分钟。 volume number 1 否 对局回放的音量大小，最小 0，最大 1。 2.9.2 atempo number 1 否 对局回放的播放速率，只能设置以下几个值：0.3，0.5，1，1.5，2，2.5，3。其中1表示原速播放，小于1表示减速播放，大于1表示加速播放。 2.9.2 audioMix boolean false 否 如果原始视频文件中有音频，是否与新传入的bgm混音，默认为false，表示不混音，只保留一个音轨，值为true时表示原始音频与传入的bgm混音。 2.10.0 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | query | string |  | 否 | 分享的对局回放打开后跳转小游戏的 query。 |  |  | path | string |  | 否 | 分享的对局回放打开后跳转小游戏的 path （独立分包路径）。详见 小游戏独立分包指南 | 2.13.2 |  | bgm | string |  | 是 | 对局回放背景音乐的地址。必须是一个代码包文件路径或者 wxfile:// 文件路径，不支持 http/https 开头的 url。 |  |  | timeRange | Array.<Array.<number>> |  | 是 | 对局回放的剪辑区间，是一个二维数组，单位 ms（毫秒）。[[1000, 3000], [4000, 5000]] 表示剪辑已录制对局回放的 1-3 秒和 4-5 秒最终合成为一个 3 秒的对局回放。对局回放剪辑后的总时长最多 60 秒，即 1 分钟。 |  |  | volume | number | 1 | 否 | 对局回放的音量大小，最小 0，最大 1。 | 2.9.2 |  | atempo | number | 1 | 否 | 对局回放的播放速率，只能设置以下几个值：0.3，0.5，1，1.5，2，2.5，3。其中1表示原速播放，小于1表示减速播放，大于1表示加速播放。 | 2.9.2 |  | audioMix | boolean | false | 否 | 如果原始视频文件中有音频，是否与新传入的bgm混音，默认为false，表示不混音，只保留一个音轨，值为true时表示原始音频与传入的bgm混音。 | 2.10.0 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
|  | query | string |  | 否 | 分享的对局回放打开后跳转小游戏的 query。 |  |
|  | path | string |  | 否 | 分享的对局回放打开后跳转小游戏的 path （独立分包路径）。详见 小游戏独立分包指南 | 2.13.2 |
|  | bgm | string |  | 是 | 对局回放背景音乐的地址。必须是一个代码包文件路径或者 wxfile:// 文件路径，不支持 http/https 开头的 url。 |  |
|  | timeRange | Array.<Array.<number>> |  | 是 | 对局回放的剪辑区间，是一个二维数组，单位 ms（毫秒）。[[1000, 3000], [4000, 5000]] 表示剪辑已录制对局回放的 1-3 秒和 4-5 秒最终合成为一个 3 秒的对局回放。对局回放剪辑后的总时长最多 60 秒，即 1 分钟。 |  |
|  | volume | number | 1 | 否 | 对局回放的音量大小，最小 0，最大 1。 | 2.9.2 |
|  | atempo | number | 1 | 否 | 对局回放的播放速率，只能设置以下几个值：0.3，0.5，1，1.5，2，2.5，3。其中1表示原速播放，小于1表示减速播放，大于1表示加速播放。 | 2.9.2 |
|  | audioMix | boolean | false | 否 | 如果原始视频文件中有音频，是否与新传入的bgm混音，默认为false，表示不混音，只保留一个音轨，值为true时表示原始音频与传入的bgm混音。 | 2.10.0 |


### GridAd wx.createGridAd(Object object)

从基础库 2.30.2 开始，本接口停止维护

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | adUnitId | string |  | 是 | 广告单元 id |
|  | adIntervals | number |  | 否 | 广告自动刷新的间隔时间，单位为秒，参数值必须大于等于30（该参数不传入时 grid(格子) 广告不会自动刷新） |
|  | style | Object |  | 是 | grid(格子) 广告组件的样式 |
|  | 结构属性 类型 默认值 必填 说明 left number 是 grid(格子) 广告组件的左上角横坐标 top number 是 grid(格子) 广告组件的左上角纵坐标 width number 是 grid(格子) 广告组件的宽度 height number 是 grid(格子) 广告组件的高度 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | left | number |  | 是 | grid(格子) 广告组件的左上角横坐标 |  | top | number |  | 是 | grid(格子) 广告组件的左上角纵坐标 |  | width | number |  | 是 | grid(格子) 广告组件的宽度 |  | height | number |  | 是 | grid(格子) 广告组件的高度 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | left | number |  | 是 | grid(格子) 广告组件的左上角横坐标 |
|  | top | number |  | 是 | grid(格子) 广告组件的左上角纵坐标 |
|  | width | number |  | 是 | grid(格子) 广告组件的宽度 |
|  | height | number |  | 是 | grid(格子) 广告组件的高度 |
|  | adTheme | string |  | 是 | grid(格子) 广告广告组件的主题，提供 `white` `black` 两种主题选择。 |
|  | gridCount | number |  | 是 | grid(格子) 广告组件的格子个数，可设置爱5，8两种格子个数样式，默认值为5 |


### InferenceSession wx.createInferenceSession(Object object)

基础库 2.30.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | model | string |  | 是 | 模型文件路径，目前只执行后缀为.onnx格式(支持代码包路径，和本地文件系统路径） |
|  | precisionLevel | number | 4 | 否 | 推理精度，有效值为 0 - 4。一般来说，使用的precisionLevel等级越低，推理速度越快，但可能会损失精度。推荐开发者在开发时，在效果满足需求时优先使用更低精度以提高推理速度，节约能耗。 |
|  | 合法值 说明 0 使用fp16 存储浮点，fp16计算，Winograd 算法也采取fp16 计算，开启近似math计算 1 使用fp16 存储浮点，fp16计算，禁用 Winograd 算法，开启近似math计算 2 使用fp16 存储浮点，fp32计算，开启 Winograd，开启近似math计算 3 使用fp32 存储浮点，fp32计算，开启 Winograd，开启近似math计算 4 使用fp32 存储浮点，fp32计算，开启 Winograd，关闭近似math计算 | 合法值 | 说明 | 0 | 使用fp16 存储浮点，fp16计算，Winograd 算法也采取fp16 计算，开启近似math计算 | 1 | 使用fp16 存储浮点，fp16计算，禁用 Winograd 算法，开启近似math计算 | 2 | 使用fp16 存储浮点，fp32计算，开启 Winograd，开启近似math计算 | 3 | 使用fp32 存储浮点，fp32计算，开启 Winograd，开启近似math计算 | 4 | 使用fp32 存储浮点，fp32计算，开启 Winograd，关闭近似math计算 |
| 合法值 | 说明 |
| 0 | 使用fp16 存储浮点，fp16计算，Winograd 算法也采取fp16 计算，开启近似math计算 |
| 1 | 使用fp16 存储浮点，fp16计算，禁用 Winograd 算法，开启近似math计算 |
| 2 | 使用fp16 存储浮点，fp32计算，开启 Winograd，开启近似math计算 |
| 3 | 使用fp32 存储浮点，fp32计算，开启 Winograd，开启近似math计算 |
| 4 | 使用fp32 存储浮点，fp32计算，开启 Winograd，关闭近似math计算 |
|  | allowQuantize | boolean | false | 否 | 是否生成量化模型推理 |
|  | allowNPU | boolean | false | 否 | 是否使用NPU推理，仅对IOS有效 |
|  | typicalShape | Object |  | 否 | 输入典型分辨率 |


### InnerAudioContext wx.createInnerAudioContext(Object object)

基础库 1.6.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| useWebAudioImplement | boolean | false | 否 | 是否使用 WebAudio 作为底层音频驱动，默认关闭。对于短音频、播放频繁的音频建议开启此选项，开启后将获得更优的性能表现。由于开启此选项后也会带来一定的内存增长，因此对于长音频建议关闭此选项。 | 2.19.0 |


### InterstitialAd wx.createInterstitialAd(Object object)

基础库 2.6.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| adUnitId | string |  | 是 | 广告单元 id |


### OpenSettingButton wx.createOpenSettingButton(Object object)

从基础库 3.0.0 开始，本接口停止维护，请使用 wx.openSetting 代替

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | type | string |  | 是 | 按钮的类型。 |
|  | 合法值 说明 text 可以设置背景色和文本的按钮 image 只能设置背景贴图的按钮，背景贴图会直接拉伸到按钮的宽高 | 合法值 | 说明 | text | 可以设置背景色和文本的按钮 | image | 只能设置背景贴图的按钮，背景贴图会直接拉伸到按钮的宽高 |
| 合法值 | 说明 |
| text | 可以设置背景色和文本的按钮 |
| image | 只能设置背景贴图的按钮，背景贴图会直接拉伸到按钮的宽高 |
|  | text | string |  | 否 | 按钮上的文本，仅当 type 为 text 时有效 |
|  | image | string |  | 否 | 按钮的背景图片，仅当 type 为 image 时有效 |
|  | style | Object |  | 是 | 按钮的样式 |
|  | 结构属性 类型 默认值 必填 说明 left number 是 左上角横坐标 top number 是 左上角纵坐标 width number 是 宽度 height number 是 高度 backgroundColor string 是 背景颜色 borderColor string 否 边框颜色 borderWidth number 否 边框宽度 borderRadius number 否 边框圆角 color string 否 文本的颜色。格式为 6 位 16 进制数。 textAlign string 否 文本的水平居中方式 合法值 说明 left 居左 center 居中 right 居右 fontSize number 否 字号 lineHeight number 否 文本的行高 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | left | number |  | 是 | 左上角横坐标 |  | top | number |  | 是 | 左上角纵坐标 |  | width | number |  | 是 | 宽度 |  | height | number |  | 是 | 高度 |  | backgroundColor | string |  | 是 | 背景颜色 |  | borderColor | string |  | 否 | 边框颜色 |  | borderWidth | number |  | 否 | 边框宽度 |  | borderRadius | number |  | 否 | 边框圆角 |  | color | string |  | 否 | 文本的颜色。格式为 6 位 16 进制数。 |  | textAlign | string |  | 否 | 文本的水平居中方式 |  | 合法值 说明 left 居左 center 居中 right 居右 | 合法值 | 说明 | left | 居左 | center | 居中 | right | 居右 |  | fontSize | number |  | 否 | 字号 |  | lineHeight | number |  | 否 | 文本的行高 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | left | number |  | 是 | 左上角横坐标 |
|  | top | number |  | 是 | 左上角纵坐标 |
|  | width | number |  | 是 | 宽度 |
|  | height | number |  | 是 | 高度 |
|  | backgroundColor | string |  | 是 | 背景颜色 |
|  | borderColor | string |  | 否 | 边框颜色 |
|  | borderWidth | number |  | 否 | 边框宽度 |
|  | borderRadius | number |  | 否 | 边框圆角 |
|  | color | string |  | 否 | 文本的颜色。格式为 6 位 16 进制数。 |
|  | textAlign | string |  | 否 | 文本的水平居中方式 |
|  | 合法值 说明 left 居左 center 居中 right 居右 | 合法值 | 说明 | left | 居左 | center | 居中 | right | 居右 |
| 合法值 | 说明 |
| left | 居左 |
| center | 居中 |
| right | 居右 |
|  | fontSize | number |  | 否 | 字号 |
|  | lineHeight | number |  | 否 | 文本的行高 |


### PageManager wx.createPageManager()

基础库 3.6.7 开始支持，低版本需做兼容处理。

| 代码 | 原因 | 解决方案 |
| --- | --- | --- |
| 0 | 无异常 | - |
| -1 | openlink异常 | 请确认openlink填写完整且正确。 |
| -2 | 基础库版本不支持 | 基础库版本较低引起，受平台灰度等策略影响。 |
| -3 | 当前设备暂不支持 | 通常受活动、能力本身对平台限制引起。 |
| -4 | 业务渠道方报错 | 由openlink业务方提供的错误信息，具体错误信息请详见 errInfo 字段。 |
| -5 | 其他错误 | 其他原因引发的错误，具体错误信息请详见 errInfo 字段。 |
| -6 | 网络错误 | 网络异常引发的错误，检查网络环境。 |
| -7 | 频繁错误 | 请勿高频发起load请求。 |
| -8 | 小游戏版本错误 | 小游戏版本与openlink不匹配，需正确使用openlink对应生效的 开发版、体验版、正式版。 |


### RewardedVideoAd wx.createRewardedVideoAd(Object object)

基础库 2.0.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| adUnitId | string |  | 是 | 广告单元 id |  |
| multiton | boolean |  | 否 | 是否启用多例模式，默认为false | 2.8.0 |
| disableFallbackSharePage | boolean |  | 否 | 是否禁用分享页，默认为false | 3.7.7 |


### StoreGift wx.createStoreGift(Object object)

基础库 3.8.12 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| presentOrderId | boolean |  | 否 | 礼物订单id，调用“创建并发送礼物”或通过“查询礼物订单列表”open api拿到，open api文档链接。 |
| openid | string |  | 否 | 用户 openid |


### TCPSocket wx.createTCPSocket(Object object)

基础库 3.1.1 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- | --- |
|  | type | string | ipv4 | 否 | 套接字族，必须是 IPv4 或者 IPv6，默认是 IPv4 | 3.6.4 |
|  | 合法值 说明 ipv4 IPv4 ipv6 IPv6 | 合法值 | 说明 | ipv4 | IPv4 | ipv6 | IPv6 |
| 合法值 | 说明 |
| ipv4 | IPv4 |
| ipv6 | IPv6 |


### UserInfoButton wx.createUserInfoButton(Object object)

基础库 2.0.1 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | type | string |  | 是 | 按钮的类型。 |
|  | 合法值 说明 text 可以设置背景色和文本的按钮 image 只能设置背景贴图的按钮，背景贴图会直接拉伸到按钮的宽高 | 合法值 | 说明 | text | 可以设置背景色和文本的按钮 | image | 只能设置背景贴图的按钮，背景贴图会直接拉伸到按钮的宽高 |
| 合法值 | 说明 |
| text | 可以设置背景色和文本的按钮 |
| image | 只能设置背景贴图的按钮，背景贴图会直接拉伸到按钮的宽高 |
|  | text | string |  | 否 | 按钮上的文本，仅当 type 为 text 时有效 |
|  | image | string |  | 否 | 按钮的背景图片，仅当 type 为 image 时有效 |
|  | style | Object |  | 是 | 按钮的样式 |
|  | 结构属性 类型 默认值 必填 说明 left number 是 左上角横坐标 top number 是 左上角纵坐标 width number 是 宽度 height number 是 高度 backgroundColor string 是 背景颜色 borderColor string 否 边框颜色 borderWidth number 否 边框宽度 borderRadius number 否 边框圆角 color string 否 文本的颜色。格式为 6 位 16 进制数。 textAlign string 否 文本的水平居中方式 合法值 说明 left 居左 center 居中 right 居右 fontSize number 否 字号 lineHeight number 否 文本的行高 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | left | number |  | 是 | 左上角横坐标 |  | top | number |  | 是 | 左上角纵坐标 |  | width | number |  | 是 | 宽度 |  | height | number |  | 是 | 高度 |  | backgroundColor | string |  | 是 | 背景颜色 |  | borderColor | string |  | 否 | 边框颜色 |  | borderWidth | number |  | 否 | 边框宽度 |  | borderRadius | number |  | 否 | 边框圆角 |  | color | string |  | 否 | 文本的颜色。格式为 6 位 16 进制数。 |  | textAlign | string |  | 否 | 文本的水平居中方式 |  | 合法值 说明 left 居左 center 居中 right 居右 | 合法值 | 说明 | left | 居左 | center | 居中 | right | 居右 |  | fontSize | number |  | 否 | 字号 |  | lineHeight | number |  | 否 | 文本的行高 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | left | number |  | 是 | 左上角横坐标 |
|  | top | number |  | 是 | 左上角纵坐标 |
|  | width | number |  | 是 | 宽度 |
|  | height | number |  | 是 | 高度 |
|  | backgroundColor | string |  | 是 | 背景颜色 |
|  | borderColor | string |  | 否 | 边框颜色 |
|  | borderWidth | number |  | 否 | 边框宽度 |
|  | borderRadius | number |  | 否 | 边框圆角 |
|  | color | string |  | 否 | 文本的颜色。格式为 6 位 16 进制数。 |
|  | textAlign | string |  | 否 | 文本的水平居中方式 |
|  | 合法值 说明 left 居左 center 居中 right 居右 | 合法值 | 说明 | left | 居左 | center | 居中 | right | 居右 |
| 合法值 | 说明 |
| left | 居左 |
| center | 居中 |
| right | 居右 |
|  | fontSize | number |  | 否 | 字号 |
|  | lineHeight | number |  | 否 | 文本的行高 |
|  | withCredentials | boolean | true | 否 | 是否带上登录态信息。当 withCredentials 为 true 时，要求此前有调用过 wx.login 且登录态尚未过期，此时返回的数据会包含 encryptedData, iv 等敏感信息；当 withCredentials 为 false 时，不要求有登录态，返回的数据不包含 encryptedData, iv 等敏感信息。 |
|  | lang | string | en | 否 | 描述用户信息的语言 |
|  | 合法值 说明 en 英文 zh_CN 简体中文 zh_TW 繁体中文 | 合法值 | 说明 | en | 英文 | zh_CN | 简体中文 | zh_TW | 繁体中文 |
| 合法值 | 说明 |
| en | 英文 |
| zh_CN | 简体中文 |
| zh_TW | 繁体中文 |


### Video wx.createVideo(Object object)

微信 Windows 版：支持

|  | 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- | --- |
|  | x | number | 0 | 否 | 视频的左上角横坐标 |  |
|  | y | number | 0 | 否 | 视频的左上角纵坐标 |  |
|  | width | number | 300 | 否 | 视频的宽度 |  |
|  | height | number | 150 | 否 | 视频的高度 |  |
|  | src | string |  | 是 | 视频的资源地址 |  |
|  | poster | string |  | 否 | 视频的封面 |  |
|  | initialTime | number | 0 | 否 | 视频的初始播放位置，单位为 s 秒 |  |
|  | playbackRate | number | 1.0 | 否 | 视频的播放速率，有效值有 0.5、0.8、1.0、1.25、1.5 |  |
|  | live | boolean | false | 否 | 视频是否为直播 |  |
|  | objectFit | string | 'contain' | 否 | 视频的缩放模式 |  |
|  | 合法值 说明 fill 填充，视频拉伸填满整个容器，不保证保持原有长宽比例 contain 包含，保持原有长宽比例。保证视频尺寸一定可以在容器里面放得下。因此，可能会有部分空白 cover 覆盖，保持原有长宽比例。保证视频尺寸一定大于容器尺寸，宽度和高度至少有一个和容器一致。因此，视频有部分会看不见 | 合法值 | 说明 | fill | 填充，视频拉伸填满整个容器，不保证保持原有长宽比例 | contain | 包含，保持原有长宽比例。保证视频尺寸一定可以在容器里面放得下。因此，可能会有部分空白 | cover | 覆盖，保持原有长宽比例。保证视频尺寸一定大于容器尺寸，宽度和高度至少有一个和容器一致。因此，视频有部分会看不见 |
| 合法值 | 说明 |
| fill | 填充，视频拉伸填满整个容器，不保证保持原有长宽比例 |
| contain | 包含，保持原有长宽比例。保证视频尺寸一定可以在容器里面放得下。因此，可能会有部分空白 |
| cover | 覆盖，保持原有长宽比例。保证视频尺寸一定大于容器尺寸，宽度和高度至少有一个和容器一致。因此，视频有部分会看不见 |
|  | controls | boolean | true | 否 | 视频是否显示控件 |  |
|  | showProgress | boolean | true | 否 | 是否显示视频底部进度条 | 2.12.0 |
|  | showProgressInControlMode | boolean | true | 否 | 是否显示控制栏的进度条 | 2.12.0 |
|  | backgroundColor | string | '#000000' | 否 | 视频背景颜色 | 2.12.0 |
|  | autoplay | boolean | false | 否 | 视频是否自动播放 |  |
|  | loop | boolean | false | 否 | 视频是否是否循环播放 |  |
|  | muted | boolean | false | 否 | 视频是否禁音播放 |  |
|  | obeyMuteSwitch | boolean | false | 否 | 视频是否遵循系统静音开关设置（仅iOS） | 2.4.0 |
|  | enableProgressGesture | boolean | true | 否 | 是否启用手势控制播放进度 |  |
|  | enablePlayGesture | boolean | false | 否 | 是否开启双击播放的手势 |  |
|  | showCenterPlayBtn | boolean | true | 否 | 是否显示视频中央的播放按钮 |  |
|  | underGameView | boolean | false | 否 | 视频是否显示在游戏画布之下（配合 Canvas.getContext('webgl', {alpha: true}) 使主屏canvas实现透明效果） | 2.11.0 |
|  | autoPauseIfNavigate | boolean | true | 否 | 视频跳转后自动暂停播放 |  |
|  | autoPauseIfOpenNative | boolean | true | 否 | 视频跳转原生页后自动暂停播放 |  |


### VKSession wx.createVKSession(Object object)

基础库 2.32.1 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- | --- |
|  | version | string |  | 否 | vision kit 版本。 | 2.22.0 |
|  | 合法值 说明 v1 v1适用于用户在平面场景下，例如桌面，地面，泛平面场景，放置虚拟物体，不提供真实世界距离。用户放置物体时，手机相机倾斜向下对着目标平面点击即可，具有广泛的机型支持 v2 v2提供真实物理距离的 ar 定位功能，提供平面识别功能，用户在平面范围点击放置虚拟物体的功能，具有有限的机型支持。iOS 设备在基础库 2.22.0 开始支持v2。安卓设备在基础库 2.25.1 开始支持v2，另外，安卓v2不支持竖直平面。**使用v2算法需要初始化，移动手机进行左右平移初始化效果最佳。** | 合法值 | 说明 | v1 | v1适用于用户在平面场景下，例如桌面，地面，泛平面场景，放置虚拟物体，不提供真实世界距离。用户放置物体时，手机相机倾斜向下对着目标平面点击即可，具有广泛的机型支持 | v2 | v2提供真实物理距离的 ar 定位功能，提供平面识别功能，用户在平面范围点击放置虚拟物体的功能，具有有限的机型支持。iOS 设备在基础库 2.22.0 开始支持v2。安卓设备在基础库 2.25.1 开始支持v2，另外，安卓v2不支持竖直平面。**使用v2算法需要初始化，移动手机进行左右平移初始化效果最佳。** |
| 合法值 | 说明 |
| v1 | v1适用于用户在平面场景下，例如桌面，地面，泛平面场景，放置虚拟物体，不提供真实世界距离。用户放置物体时，手机相机倾斜向下对着目标平面点击即可，具有广泛的机型支持 |
| v2 | v2提供真实物理距离的 ar 定位功能，提供平面识别功能，用户在平面范围点击放置虚拟物体的功能，具有有限的机型支持。iOS 设备在基础库 2.22.0 开始支持v2。安卓设备在基础库 2.25.1 开始支持v2，另外，安卓v2不支持竖直平面。**使用v2算法需要初始化，移动手机进行左右平移初始化效果最佳。** |
|  | track | Object |  | 是 | 跟踪能力配置，目前不同的跟踪能力之间是互斥的，默认使用平面跟踪能力。需要注意目前 track 中不同的跟踪配置存在互斥关系（比如 marker 跟踪配置和 OSD 跟踪配置不能同时存在），请按需配置。 |  |
|  | 结构属性 类型 默认值 必填 说明 最低版本 plane Object 是 平面跟踪配置 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 平面跟踪配置模式 合法值 说明 最低版本 1 检测横向平面 2 检测纵向平面，只有 v2 版本支持 2.22.0 3 检测横向和纵向平面，只有 v2 版本支持 2.22.0 force boolean false 否 是否开启强制使用V2的模式，只有 v2 版本支持 3.6.5 marker boolean 否 marker 跟踪配置，基础库(3.0.0)开始允许同时支持v2的水平面检测能力 2.24.5 OSD boolean 否 OSD 跟踪配置 2.24.5 depth Object 否 深度识别配置。用法详情指南文档。 3.0.0 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 深度识别模式 3.0.0 合法值 说明 最低版本 1 通过摄像头实时检测 3.0.0 2 静态图片检测 3.0.0 face Object 否 人脸检测配置。用法详情指南文档。安卓微信8.0.25开始支持，iOS微信8.0.24开始支持。 2.25.0 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 人脸检测模式 2.25.0 合法值 说明 最低版本 1 通过摄像头实时检测 2.25.0 2 静态图片检测 2.25.0 OCR Object 否 OCR检测配置。用法详情指南文档。 2.27.0 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 OCR检测模式 2.27.0 合法值 说明 最低版本 1 通过摄像头实时检测 2.27.0 2 静态图片检测 2.27.0 IDCard Object 否 身份证检测配置。用法详情指南文档。 3.3.0 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 身份证检测模式 3.3.0 合法值 说明 最低版本 2 静态图片检测 3.3.0 body Object 否 人体检测配置。用法详情指南文档。 2.28.0 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 人体检测模式 2.28.0 合法值 说明 最低版本 1 通过摄像头实时检测 2.28.0 2 静态图片检测 2.28.0 hand Object 否 手势检测配置。用法详情指南文档。 2.28.0 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 手势检测模式 2.28.0 合法值 说明 最低版本 1 通过摄像头实时检测 2.28.0 2 静态图片检测 2.28.0 shoe Object 否 鞋部检测配置。用法详情指南文档。 3.2.1 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 鞋部检测模式 3.2.1 合法值 说明 最低版本 1 通过摄像头实时检测 3.2.1 threeDof boolean 否 提供基础AR功能，输出相机旋转的3个自由度的位姿，利用手机陀螺仪传感器，实现快速稳定的AR定位能力，适用于简单AR场景。 2.28.0 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | plane | Object |  | 是 | 平面跟踪配置 |  |  | 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 平面跟踪配置模式 合法值 说明 最低版本 1 检测横向平面 2 检测纵向平面，只有 v2 版本支持 2.22.0 3 检测横向和纵向平面，只有 v2 版本支持 2.22.0 force boolean false 否 是否开启强制使用V2的模式，只有 v2 版本支持 3.6.5 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | mode | number |  | 是 | 平面跟踪配置模式 |  |  | 合法值 说明 最低版本 1 检测横向平面 2 检测纵向平面，只有 v2 版本支持 2.22.0 3 检测横向和纵向平面，只有 v2 版本支持 2.22.0 | 合法值 | 说明 | 最低版本 | 1 | 检测横向平面 |  | 2 | 检测纵向平面，只有 v2 版本支持 | 2.22.0 | 3 | 检测横向和纵向平面，只有 v2 版本支持 | 2.22.0 |  | force | boolean | false | 否 | 是否开启强制使用V2的模式，只有 v2 版本支持 | 3.6.5 |  | marker | boolean |  | 否 | marker 跟踪配置，基础库(3.0.0)开始允许同时支持v2的水平面检测能力 | 2.24.5 |  | OSD | boolean |  | 否 | OSD 跟踪配置 | 2.24.5 |  | depth | Object |  | 否 | 深度识别配置。用法详情指南文档。 | 3.0.0 |  | 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 深度识别模式 3.0.0 合法值 说明 最低版本 1 通过摄像头实时检测 3.0.0 2 静态图片检测 3.0.0 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | mode | number |  | 是 | 深度识别模式 | 3.0.0 |  | 合法值 说明 最低版本 1 通过摄像头实时检测 3.0.0 2 静态图片检测 3.0.0 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 3.0.0 | 2 | 静态图片检测 | 3.0.0 |  | face | Object |  | 否 | 人脸检测配置。用法详情指南文档。安卓微信8.0.25开始支持，iOS微信8.0.24开始支持。 | 2.25.0 |  | 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 人脸检测模式 2.25.0 合法值 说明 最低版本 1 通过摄像头实时检测 2.25.0 2 静态图片检测 2.25.0 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | mode | number |  | 是 | 人脸检测模式 | 2.25.0 |  | 合法值 说明 最低版本 1 通过摄像头实时检测 2.25.0 2 静态图片检测 2.25.0 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 2.25.0 | 2 | 静态图片检测 | 2.25.0 |  | OCR | Object |  | 否 | OCR检测配置。用法详情指南文档。 | 2.27.0 |  | 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 OCR检测模式 2.27.0 合法值 说明 最低版本 1 通过摄像头实时检测 2.27.0 2 静态图片检测 2.27.0 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | mode | number |  | 是 | OCR检测模式 | 2.27.0 |  | 合法值 说明 最低版本 1 通过摄像头实时检测 2.27.0 2 静态图片检测 2.27.0 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 2.27.0 | 2 | 静态图片检测 | 2.27.0 |  | IDCard | Object |  | 否 | 身份证检测配置。用法详情指南文档。 | 3.3.0 |  | 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 身份证检测模式 3.3.0 合法值 说明 最低版本 2 静态图片检测 3.3.0 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | mode | number |  | 是 | 身份证检测模式 | 3.3.0 |  | 合法值 说明 最低版本 2 静态图片检测 3.3.0 | 合法值 | 说明 | 最低版本 | 2 | 静态图片检测 | 3.3.0 |  | body | Object |  | 否 | 人体检测配置。用法详情指南文档。 | 2.28.0 |  | 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 人体检测模式 2.28.0 合法值 说明 最低版本 1 通过摄像头实时检测 2.28.0 2 静态图片检测 2.28.0 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | mode | number |  | 是 | 人体检测模式 | 2.28.0 |  | 合法值 说明 最低版本 1 通过摄像头实时检测 2.28.0 2 静态图片检测 2.28.0 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 2.28.0 | 2 | 静态图片检测 | 2.28.0 |  | hand | Object |  | 否 | 手势检测配置。用法详情指南文档。 | 2.28.0 |  | 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 手势检测模式 2.28.0 合法值 说明 最低版本 1 通过摄像头实时检测 2.28.0 2 静态图片检测 2.28.0 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | mode | number |  | 是 | 手势检测模式 | 2.28.0 |  | 合法值 说明 最低版本 1 通过摄像头实时检测 2.28.0 2 静态图片检测 2.28.0 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 2.28.0 | 2 | 静态图片检测 | 2.28.0 |  | shoe | Object |  | 否 | 鞋部检测配置。用法详情指南文档。 | 3.2.1 |  | 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 鞋部检测模式 3.2.1 合法值 说明 最低版本 1 通过摄像头实时检测 3.2.1 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | mode | number |  | 是 | 鞋部检测模式 | 3.2.1 |  | 合法值 说明 最低版本 1 通过摄像头实时检测 3.2.1 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 3.2.1 |  | threeDof | boolean |  | 否 | 提供基础AR功能，输出相机旋转的3个自由度的位姿，利用手机陀螺仪传感器，实现快速稳定的AR定位能力，适用于简单AR场景。 | 2.28.0 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
|  | plane | Object |  | 是 | 平面跟踪配置 |  |
|  | 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 平面跟踪配置模式 合法值 说明 最低版本 1 检测横向平面 2 检测纵向平面，只有 v2 版本支持 2.22.0 3 检测横向和纵向平面，只有 v2 版本支持 2.22.0 force boolean false 否 是否开启强制使用V2的模式，只有 v2 版本支持 3.6.5 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | mode | number |  | 是 | 平面跟踪配置模式 |  |  | 合法值 说明 最低版本 1 检测横向平面 2 检测纵向平面，只有 v2 版本支持 2.22.0 3 检测横向和纵向平面，只有 v2 版本支持 2.22.0 | 合法值 | 说明 | 最低版本 | 1 | 检测横向平面 |  | 2 | 检测纵向平面，只有 v2 版本支持 | 2.22.0 | 3 | 检测横向和纵向平面，只有 v2 版本支持 | 2.22.0 |  | force | boolean | false | 否 | 是否开启强制使用V2的模式，只有 v2 版本支持 | 3.6.5 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
|  | mode | number |  | 是 | 平面跟踪配置模式 |  |
|  | 合法值 说明 最低版本 1 检测横向平面 2 检测纵向平面，只有 v2 版本支持 2.22.0 3 检测横向和纵向平面，只有 v2 版本支持 2.22.0 | 合法值 | 说明 | 最低版本 | 1 | 检测横向平面 |  | 2 | 检测纵向平面，只有 v2 版本支持 | 2.22.0 | 3 | 检测横向和纵向平面，只有 v2 版本支持 | 2.22.0 |
| 合法值 | 说明 | 最低版本 |
| 1 | 检测横向平面 |  |
| 2 | 检测纵向平面，只有 v2 版本支持 | 2.22.0 |
| 3 | 检测横向和纵向平面，只有 v2 版本支持 | 2.22.0 |
|  | force | boolean | false | 否 | 是否开启强制使用V2的模式，只有 v2 版本支持 | 3.6.5 |
|  | marker | boolean |  | 否 | marker 跟踪配置，基础库(3.0.0)开始允许同时支持v2的水平面检测能力 | 2.24.5 |
|  | OSD | boolean |  | 否 | OSD 跟踪配置 | 2.24.5 |
|  | depth | Object |  | 否 | 深度识别配置。用法详情指南文档。 | 3.0.0 |
|  | 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 深度识别模式 3.0.0 合法值 说明 最低版本 1 通过摄像头实时检测 3.0.0 2 静态图片检测 3.0.0 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | mode | number |  | 是 | 深度识别模式 | 3.0.0 |  | 合法值 说明 最低版本 1 通过摄像头实时检测 3.0.0 2 静态图片检测 3.0.0 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 3.0.0 | 2 | 静态图片检测 | 3.0.0 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
|  | mode | number |  | 是 | 深度识别模式 | 3.0.0 |
|  | 合法值 说明 最低版本 1 通过摄像头实时检测 3.0.0 2 静态图片检测 3.0.0 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 3.0.0 | 2 | 静态图片检测 | 3.0.0 |
| 合法值 | 说明 | 最低版本 |
| 1 | 通过摄像头实时检测 | 3.0.0 |
| 2 | 静态图片检测 | 3.0.0 |
|  | face | Object |  | 否 | 人脸检测配置。用法详情指南文档。安卓微信8.0.25开始支持，iOS微信8.0.24开始支持。 | 2.25.0 |
|  | 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 人脸检测模式 2.25.0 合法值 说明 最低版本 1 通过摄像头实时检测 2.25.0 2 静态图片检测 2.25.0 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | mode | number |  | 是 | 人脸检测模式 | 2.25.0 |  | 合法值 说明 最低版本 1 通过摄像头实时检测 2.25.0 2 静态图片检测 2.25.0 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 2.25.0 | 2 | 静态图片检测 | 2.25.0 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
|  | mode | number |  | 是 | 人脸检测模式 | 2.25.0 |
|  | 合法值 说明 最低版本 1 通过摄像头实时检测 2.25.0 2 静态图片检测 2.25.0 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 2.25.0 | 2 | 静态图片检测 | 2.25.0 |
| 合法值 | 说明 | 最低版本 |
| 1 | 通过摄像头实时检测 | 2.25.0 |
| 2 | 静态图片检测 | 2.25.0 |
|  | OCR | Object |  | 否 | OCR检测配置。用法详情指南文档。 | 2.27.0 |
|  | 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 OCR检测模式 2.27.0 合法值 说明 最低版本 1 通过摄像头实时检测 2.27.0 2 静态图片检测 2.27.0 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | mode | number |  | 是 | OCR检测模式 | 2.27.0 |  | 合法值 说明 最低版本 1 通过摄像头实时检测 2.27.0 2 静态图片检测 2.27.0 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 2.27.0 | 2 | 静态图片检测 | 2.27.0 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
|  | mode | number |  | 是 | OCR检测模式 | 2.27.0 |
|  | 合法值 说明 最低版本 1 通过摄像头实时检测 2.27.0 2 静态图片检测 2.27.0 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 2.27.0 | 2 | 静态图片检测 | 2.27.0 |
| 合法值 | 说明 | 最低版本 |
| 1 | 通过摄像头实时检测 | 2.27.0 |
| 2 | 静态图片检测 | 2.27.0 |
|  | IDCard | Object |  | 否 | 身份证检测配置。用法详情指南文档。 | 3.3.0 |
|  | 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 身份证检测模式 3.3.0 合法值 说明 最低版本 2 静态图片检测 3.3.0 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | mode | number |  | 是 | 身份证检测模式 | 3.3.0 |  | 合法值 说明 最低版本 2 静态图片检测 3.3.0 | 合法值 | 说明 | 最低版本 | 2 | 静态图片检测 | 3.3.0 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
|  | mode | number |  | 是 | 身份证检测模式 | 3.3.0 |
|  | 合法值 说明 最低版本 2 静态图片检测 3.3.0 | 合法值 | 说明 | 最低版本 | 2 | 静态图片检测 | 3.3.0 |
| 合法值 | 说明 | 最低版本 |
| 2 | 静态图片检测 | 3.3.0 |
|  | body | Object |  | 否 | 人体检测配置。用法详情指南文档。 | 2.28.0 |
|  | 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 人体检测模式 2.28.0 合法值 说明 最低版本 1 通过摄像头实时检测 2.28.0 2 静态图片检测 2.28.0 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | mode | number |  | 是 | 人体检测模式 | 2.28.0 |  | 合法值 说明 最低版本 1 通过摄像头实时检测 2.28.0 2 静态图片检测 2.28.0 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 2.28.0 | 2 | 静态图片检测 | 2.28.0 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
|  | mode | number |  | 是 | 人体检测模式 | 2.28.0 |
|  | 合法值 说明 最低版本 1 通过摄像头实时检测 2.28.0 2 静态图片检测 2.28.0 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 2.28.0 | 2 | 静态图片检测 | 2.28.0 |
| 合法值 | 说明 | 最低版本 |
| 1 | 通过摄像头实时检测 | 2.28.0 |
| 2 | 静态图片检测 | 2.28.0 |
|  | hand | Object |  | 否 | 手势检测配置。用法详情指南文档。 | 2.28.0 |
|  | 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 手势检测模式 2.28.0 合法值 说明 最低版本 1 通过摄像头实时检测 2.28.0 2 静态图片检测 2.28.0 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | mode | number |  | 是 | 手势检测模式 | 2.28.0 |  | 合法值 说明 最低版本 1 通过摄像头实时检测 2.28.0 2 静态图片检测 2.28.0 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 2.28.0 | 2 | 静态图片检测 | 2.28.0 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
|  | mode | number |  | 是 | 手势检测模式 | 2.28.0 |
|  | 合法值 说明 最低版本 1 通过摄像头实时检测 2.28.0 2 静态图片检测 2.28.0 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 2.28.0 | 2 | 静态图片检测 | 2.28.0 |
| 合法值 | 说明 | 最低版本 |
| 1 | 通过摄像头实时检测 | 2.28.0 |
| 2 | 静态图片检测 | 2.28.0 |
|  | shoe | Object |  | 否 | 鞋部检测配置。用法详情指南文档。 | 3.2.1 |
|  | 结构属性 类型 默认值 必填 说明 最低版本 mode number 是 鞋部检测模式 3.2.1 合法值 说明 最低版本 1 通过摄像头实时检测 3.2.1 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |  | mode | number |  | 是 | 鞋部检测模式 | 3.2.1 |  | 合法值 说明 最低版本 1 通过摄像头实时检测 3.2.1 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 3.2.1 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
|  | mode | number |  | 是 | 鞋部检测模式 | 3.2.1 |
|  | 合法值 说明 最低版本 1 通过摄像头实时检测 3.2.1 | 合法值 | 说明 | 最低版本 | 1 | 通过摄像头实时检测 | 3.2.1 |
| 合法值 | 说明 | 最低版本 |
| 1 | 通过摄像头实时检测 | 3.2.1 |
|  | threeDof | boolean |  | 否 | 提供基础AR功能，输出相机旋转的3个自由度的位姿，利用手机陀螺仪传感器，实现快速稳定的AR定位能力，适用于简单AR场景。 | 2.28.0 |
|  | gl | WebGLRenderingContext |  | 否 | 绑定的 WebGLRenderingContext 对象 | 2.23.0 |


### Worker wx.createWorker(string scriptPath, object options)

基础库 1.9.90 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| useExperimentalWorker | boolean | false | 否 | 是否使用实验worker。在iOS下，实验worker的JS运行效率比非实验worker提升数倍，如需在worker内进行重度计算的建议开启此选项。同时，实验worker存在极小概率会在系统资源紧张时被系统回收，因此建议配合 worker.onProcessKilled 事件使用，在worker被回收后可重新创建一个。 | 2.13.0 |


### string wx.decode(Object object)

# 功能描述

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | data | ArrayBuffer |  | 是 | 要解码的 ArrayBuffer |
|  | format | string | utf8 | 否 | 编码的格式 |
|  | 合法值 说明 utf8 utf-8 ucs2 以小端序读取 ucs-2 以小端序读取 utf16le 以小端序读取 utf-16le 以小端序读取 latin1 gbk | 合法值 | 说明 | utf8 |  | utf-8 |  | ucs2 | 以小端序读取 | ucs-2 | 以小端序读取 | utf16le | 以小端序读取 | utf-16le | 以小端序读取 | latin1 |  | gbk |  |
| 合法值 | 说明 |
| utf8 |  |
| utf-8 |  |
| ucs2 | 以小端序读取 |
| ucs-2 | 以小端序读取 |
| utf16le | 以小端序读取 |
| utf-16le | 以小端序读取 |
| latin1 |  |
| gbk |  |


### DownloadTask wx.downloadFile(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| url | string |  | 是 | 下载资源的 url |  |
| header | Object |  | 否 | HTTP 请求的 Header，Header 中不能设置 Referer |  |
| timeout | number | 60000 | 否 | 超时时间，单位为毫秒，默认值为 60000 即一分钟。 | 2.10.0 |
| filePath | string |  | 否 | 指定文件下载后存储的路径 (本地路径) | 1.8.0 |
| enableProfile | boolean | true | 否 | 是否开启 profile。iOS 和 Android 端默认开启，其他端暂不支持。开启后可在接口回调的 res.profile 中查看性能调试信息。 |  |
| enableHttp2 | boolean | false | 否 | 是否开启 http2 | 2.10.4 |
| enableQuic | boolean | false | 否 | 是否开启 Quic/h3 协议（iOS 微信目前使用 gQUIC-Q43；Android 微信在 v8.0.54 前使用 gQUIC-Q43，v8.0.54 开始使用 IETF QUIC，即 h3 协议；PC微信使用 IETF QUIC，即 h3 协议） | 2.10.4 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### ArrayBuffer wx.encode(Object object)

# 功能描述

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | data | string |  | 是 | 要编码的字符串 |
|  | format | string | utf8 | 否 | 编码的格式。注意：iOS高性能模式和iOS高性能+模式下，仅支持utf-8格式 |
|  | 合法值 说明 utf8 utf-8 ucs2 以小端序读取 ucs-2 以小端序读取 utf16le 以小端序读取 utf-16le 以小端序读取 latin1 gbk | 合法值 | 说明 | utf8 |  | utf-8 |  | ucs2 | 以小端序读取 | ucs-2 | 以小端序读取 | utf16le | 以小端序读取 | utf-16le | 以小端序读取 | latin1 |  | gbk |  |
| 合法值 | 说明 |
| utf8 |  |
| utf-8 |  |
| ucs2 | 以小端序读取 |
| ucs-2 | 以小端序读取 |
| utf16le | 以小端序读取 |
| utf-16le | 以小端序读取 |
| latin1 |  |
| gbk |  |


### wx.exitChatTool(Object object)

基础库 3.7.12 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.exitMiniProgram(Object object)

基础库 2.17.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.exitVoIPChat(Object object)

基础库 2.7.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.faceDetect(Object object)

该接口已停止维护，推荐使用 wx.createVKSession 代替

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| frameBuffer | ArrayBuffer |  | 是 | 图像像素点数据，每四项表示一个像素点的 RGBA |
| width | number |  | 是 | 图像宽度 |
| height | number |  | 是 | 图像高度 |
| enablePoint | boolean | false | 否 | 是否返回当前图像的人脸（106 个点） |
| enableConf | boolean | false | 否 | 是否返回当前图像的人脸的置信度（可表示器官遮挡情况） |
| enableAngle | boolean | false | 否 | 是否返回当前图像的人脸角度信息 |
| enableMultiFace | boolean | false | 否 | 是否返回多张人脸的信息 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Object wx.getAccountInfoSync()

基础库 2.11.2 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | miniProgram | Object | 小程序账号信息 |
|  | 结构属性 类型 说明 最低版本 appId string 小程序 appId envVersion string 小程序版本 2.10.0 合法值 说明 develop 开发版，提交代码审核时默认使用开发版进行审核。 trial 体验版 release 正式版 version string 线上小程序版本号 2.10.2 |  | 结构属性 | 类型 | 说明 | 最低版本 |  | appId | string | 小程序 appId |  |  | envVersion | string | 小程序版本 | 2.10.0 |  | 合法值 说明 develop 开发版，提交代码审核时默认使用开发版进行审核。 trial 体验版 release 正式版 | 合法值 | 说明 | develop | 开发版，提交代码审核时默认使用开发版进行审核。 | trial | 体验版 | release | 正式版 |  | version | string | 线上小程序版本号 | 2.10.2 |
|  | 结构属性 | 类型 | 说明 | 最低版本 |
|  | appId | string | 小程序 appId |  |
|  | envVersion | string | 小程序版本 | 2.10.0 |
|  | 合法值 说明 develop 开发版，提交代码审核时默认使用开发版进行审核。 trial 体验版 release 正式版 | 合法值 | 说明 | develop | 开发版，提交代码审核时默认使用开发版进行审核。 | trial | 体验版 | release | 正式版 |
| 合法值 | 说明 |
| develop | 开发版，提交代码审核时默认使用开发版进行审核。 |
| trial | 体验版 |
| release | 正式版 |
|  | version | string | 线上小程序版本号 | 2.10.2 |
|  | plugin | Object | 插件账号信息（仅在插件中调用时包含这一项） |
|  | 结构属性 类型 说明 appId string 插件 appId version string 插件版本号 |  | 结构属性 | 类型 | 说明 |  | appId | string | 插件 appId |  | version | string | 插件版本号 |
|  | 结构属性 | 类型 | 说明 |
|  | appId | string | 插件 appId |
|  | version | string | 插件版本号 |


### Object wx.getAppAuthorizeSetting()

基础库 2.25.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| albumAuthorized | 'authorized'/'denied'/'not determined' | 允许微信使用相册的开关（仅 iOS 有效） |
| bluetoothAuthorized | 'authorized'/'denied'/'not determined' | 允许微信使用蓝牙的开关（安卓基础库 3.5.0 以上有效） |
| cameraAuthorized | 'authorized'/'denied'/'not determined' | 允许微信使用摄像头的开关 |
| locationAuthorized | 'authorized'/'denied'/'not determined' | 允许微信使用定位的开关 |
| locationReducedAccuracy | boolean | 定位准确度。true 表示模糊定位，false 表示精确定位（仅 iOS 有效） |
| microphoneAuthorized | 'authorized'/'denied'/'not determined' | 允许微信使用麦克风的开关 |
| notificationAuthorized | 'authorized'/'denied'/'not determined' | 允许微信通知的开关 |
| notificationAlertAuthorized | 'authorized'/'denied'/'not determined' | 允许微信通知带有提醒的开关（仅 iOS 有效） |
| notificationBadgeAuthorized | 'authorized'/'denied'/'not determined' | 允许微信通知带有标记的开关（仅 iOS 有效） |
| notificationSoundAuthorized | 'authorized'/'denied'/'not determined' | 允许微信通知带有声音的开关（仅 iOS 有效） |
| phoneCalendarAuthorized | 'authorized'/'denied'/'not determined' | 允许微信读写日历的开关 |


### Object wx.getAppBaseInfo()

基础库 2.25.3 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- |
|  | SDKVersion | string | 客户端基础库版本 |  |
|  | enableDebug | boolean | 是否已打开调试。可通过右上角菜单或 wx.setEnableDebug 打开调试。 |  |
|  | host | Object | 当前小程序运行的宿主环境 |  |
|  | 结构属性 类型 说明 appId string 宿主 app（第三方App） 对应的 appId （当小程序运行在第三方App环境时才返回） |  | 结构属性 | 类型 | 说明 |  | appId | string | 宿主 app（第三方App） 对应的 appId （当小程序运行在第三方App环境时才返回） |
|  | 结构属性 | 类型 | 说明 |
|  | appId | string | 宿主 app（第三方App） 对应的 appId （当小程序运行在第三方App环境时才返回） |
|  | language | string | 微信设置的语言 |  |
|  | version | string | 微信版本号 |  |
|  | PCKernelVersion | string | PC 内核版本号，仅在 PC 端存在该值 |  |
|  | theme | string | 系统当前主题，取值为`light`或`dark`，全局配置`"darkmode":true`时才能获取，否则为 undefined （不支持小游戏） |  |
|  | 合法值 说明 dark 深色主题 light 浅色主题 | 合法值 | 说明 | dark | 深色主题 | light | 浅色主题 |
| 合法值 | 说明 |
| dark | 深色主题 |
| light | 浅色主题 |
|  | fontSizeScaleFactor | number | 微信字体大小缩放比例 |  |
|  | fontSizeSetting | number | 微信字体大小，单位px | 2.23.4 |


### wx.getAvailableAudioSources(Object object)

基础库 2.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getBackgroundFetchData(object object)

基础库 3.0.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| fetchType | String |  | 是 | 缓存数据类别，取值为 periodic 或 pre |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getBackgroundFetchToken(Object object)

基础库 3.0.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getBatteryInfo(Object object)

以 Promise 风格 调用：支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Object wx.getBatteryInfoSync()

以 Promise 风格 调用：支持

| 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- |
| level | number | 设备电量，范围 1 - 100 |  |
| isCharging | boolean | 是否正在充电中 |  |
| isLowPowerModeEnabled | boolean | 是否处于省电模式 | 3.5.0 |


### wx.getBeacons(Object object)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getBLEDeviceCharacteristics(Object object)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| deviceId | string |  | 是 | 蓝牙设备 id。需要已经通过 wx.createBLEConnection 建立连接 |
| serviceId | string |  | 是 | 蓝牙服务 UUID。需要先调用 wx.getBLEDeviceServices 获取 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getBLEDeviceRSSI(Object object)

基础库 2.11.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| deviceId | string |  | 是 | 蓝牙设备 id |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getBLEDeviceServices(Object object)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| deviceId | string |  | 是 | 蓝牙设备 id。需要已经通过 wx.createBLEConnection 建立连接 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getBLEMTU(Object object)

基础库 2.20.1 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | deviceId | string |  | 是 | 蓝牙设备 id |
|  | writeType | string | write | 否 | 写模式 （iOS 特有参数） |
|  | 合法值 说明 write 有回复写 writeNoResponse 无回复写 | 合法值 | 说明 | write | 有回复写 | writeNoResponse | 无回复写 |
| 合法值 | 说明 |
| write | 有回复写 |
| writeNoResponse | 无回复写 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getBluetoothAdapterState(Object object)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getBluetoothDevices(Object object)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getChannelsLiveInfo(Object object)

基础库 2.15.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| finderUserName | string |  | 是 | 视频号 id，以“sph”开头的id，可在视频号助手获取 |  |
| startTime | number |  | 否 | 起始时间，筛选指定时间段的直播。若上传了endTime，未上传startTime，则startTime默认为0 | 2.29.0 |
| endTime | number |  | 否 | 结束时间，筛选指定时间段的直播。若上传了startTime，未上传endTime，则endTime默认取当前时间 | 2.29.0 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.getChannelsLiveNoticeInfo(Object object)

基础库 2.19.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| finderUserName | string |  | 是 | 视频号 id，以“sph”开头的id，可在视频号助手获取 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getChatToolInfo(Object object)

基础库 3.7.12 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getClipboardData(Object object)

基础库 1.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getConnectedBluetoothDevices(Object object)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| services | Array.<string> |  | 是 | 蓝牙设备主服务的 UUID 列表（支持 16/32/128 位 UUID） |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getDeviceBenchmarkInfo(Object object)

基础库 3.4.5 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Object wx.getDeviceInfo()

基础库 2.25.3 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- |
|  | abi | string | 应用（微信APP）二进制接口类型（仅 Android 支持） |  |
|  | deviceAbi | string | 设备二进制接口类型（仅 Android 支持） | 2.25.1 |
|  | benchmarkLevel | number | 设备性能等级（仅 Android 支持）。取值为：-2 或 0（该设备无法运行小游戏），-1（性能未知），>=1（设备性能值，该值越高，设备性能越好，目前最高不到50） 注意：从基础库3.4.5开始，本返回值停止维护，请使用wx.getDeviceBenchmarkInfo获取设备性能等级 |  |
|  | brand | string | 设备品牌 |  |
|  | model | string | 设备型号。新机型刚推出一段时间会显示unknown，微信会尽快进行适配。 |  |
|  | system | string | 操作系统及版本 |  |
|  | platform | string | 客户端平台 |  |
|  | 合法值 说明 ios iOS微信（包含 iPhone、iPad） android Android微信 ohos HarmonyOS 手机端微信 ohos_pc HarmonyOS PC微信 windows Windows微信 mac macOS微信 devtools 微信开发者工具 | 合法值 | 说明 | ios | iOS微信（包含 iPhone、iPad） | android | Android微信 | ohos | HarmonyOS 手机端微信 | ohos_pc | HarmonyOS PC微信 | windows | Windows微信 | mac | macOS微信 | devtools | 微信开发者工具 |
| 合法值 | 说明 |
| ios | iOS微信（包含 iPhone、iPad） |
| android | Android微信 |
| ohos | HarmonyOS 手机端微信 |
| ohos_pc | HarmonyOS PC微信 |
| windows | Windows微信 |
| mac | macOS微信 |
| devtools | 微信开发者工具 |
|  | cpuType | string | 设备 CPU 型号（仅 Android 支持）（Tips: GPU 型号可通过 WebGLRenderingContext.getExtension('WEBGL_debug_renderer_info') 来获取） | 2.29.0 |
|  | memorySize | string | 设备内存大小，单位为 MB | 2.30.0 |


### Object wx.getDirectAdStatusSync()

基础库 3.11.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| isInMask | boolean | 当前是否处于蒙层阶段 |
| isInDirectGameAd | boolean | 当前是否处于直接广告中 |


### Object wx.getEnterOptionsSync()

基础库 2.13.2 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- |
|  | scene | number | 启动小游戏的场景值 |  |
|  | query | Record.<string, string> | 启动小游戏的 query 参数 |  |
|  | shareTicket | string | shareTicket，详见获取更多转发信息 |  |
|  | referrerInfo | object | 来源信息。从另一个小程序、公众号或 App 进入小程序时返回。否则返回 {}。(参见后文注意) |  |
|  | 结构属性 类型 说明 appId string 来源小程序、公众号或 App 的 appId extraData object 来源小程序传过来的数据，scene=1037或1038时支持 |  | 结构属性 | 类型 | 说明 |  | appId | string | 来源小程序、公众号或 App 的 appId |  | extraData | object | 来源小程序传过来的数据，scene=1037或1038时支持 |
|  | 结构属性 | 类型 | 说明 |
|  | appId | string | 来源小程序、公众号或 App 的 appId |
|  | extraData | object | 来源小程序传过来的数据，scene=1037或1038时支持 |
|  | chatType | number | 从微信群聊/单聊打开小程序时，chatType 表示具体微信群聊/单聊类型 |  |
|  | 合法值 说明 1 微信联系人单聊 2 企业微信联系人单聊 3 普通微信群聊 4 企业微信互通群聊 | 合法值 | 说明 | 1 | 微信联系人单聊 | 2 | 企业微信联系人单聊 | 3 | 普通微信群聊 | 4 | 企业微信互通群聊 |
| 合法值 | 说明 |
| 1 | 微信联系人单聊 |
| 2 | 企业微信联系人单聊 |
| 3 | 普通微信群聊 |
| 4 | 企业微信互通群聊 |
|  | apiCategory | string | API 类别 | 2.20.0 |
|  | 合法值 说明 default 默认类别 nativeFunctionalized 原生功能化，视频号直播商品、商品橱窗等场景打开的小程序 browseOnly 仅浏览，朋友圈快照页等场景打开的小程序 embedded 内嵌，通过打开半屏小程序能力打开的小程序 | 合法值 | 说明 | default | 默认类别 | nativeFunctionalized | 原生功能化，视频号直播商品、商品橱窗等场景打开的小程序 | browseOnly | 仅浏览，朋友圈快照页等场景打开的小程序 | embedded | 内嵌，通过打开半屏小程序能力打开的小程序 |
| 合法值 | 说明 |
| default | 默认类别 |
| nativeFunctionalized | 原生功能化，视频号直播商品、商品橱窗等场景打开的小程序 |
| browseOnly | 仅浏览，朋友圈快照页等场景打开的小程序 |
| embedded | 内嵌，通过打开半屏小程序能力打开的小程序 |


### wx.getExtConfig(Object object)

基础库 2.8.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getFriendCloudStorage(Object object)

基础库 1.9.92 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| keyList | Array.<string> |  | 是 | 要拉取的 key 列表 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getFriendSendGiftStatus(Object object)

基础库 3.11.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| giftId | string |  | 是 | 礼包 id |
| openidList | Array.<string> |  | 是 | 要查询的 openid 列表 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getFuzzyLocation(Object object)

基础库 2.25.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | type | string | wgs84 | 否 | 返回的坐标类型 |
|  | 合法值 说明 wgs84 返回 gps 坐标 gcj02 返回 gcj02 坐标 | 合法值 | 说明 | wgs84 | 返回 gps 坐标 | gcj02 | 返回 gcj02 坐标 |
| 合法值 | 说明 |
| wgs84 | 返回 gps 坐标 |
| gcj02 | 返回 gcj02 坐标 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getGameClubData(Object object)

基础库 2.25.4 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | dataTypeList | Array.<Object> |  | 是 | 需要获取的数据指标的对象数组 |
|  | 结构属性 类型 默认值 必填 说明 type number 是 见type表格说明 subKey string 否 部分type需要传，见type表格说明 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | type | number |  | 是 | 见type表格说明 |  | subKey | string |  | 否 | 部分type需要传，见type表格说明 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | type | number |  | 是 | 见type表格说明 |
|  | subKey | string |  | 否 | 部分type需要传，见type表格说明 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getGameExptInfo(Object options)

基础库 3.8.8 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| keyList | Array.<string> |  | 是 | 实验参数数组，不填则获取所有实验参数 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### GameLogManager wx.getGameLogManager(Object param)

基础库 3.7.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| commonInfo | Object |  | 否 | 自定义全局日志信息。该信息会包含在每条日志的基础信息中。数据类型为 object，且能够通过 JSON.stringify 序列化。 |
| debug | boolean | false | 否 | 是否开启调试模式，调试模式下每次上报成功都会在控制台输出上报内容。调试模式仅在开发版和体验版小游戏中生效。 |
| success | function |  | 否 | 初始化成功后的回调。 |
| fail | function |  | 否 | 初始化失败后的回调。 |
| complete | function |  | 否 | 初始化完成后的回调（成功、失败都会执行）。 |


### Array.<Object> wx.getGamepads()

基础库 3.6.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| id | string | 一个包含着控制器标识信息的 string |
| index | string | 一个自增的整形数字，对于当前连接到系统的每一个设备是唯一的 |
| connected | boolean | 控制器是否仍然连接着系统. |
| axes | Array.<object> | 一个表示控制器设备上存在的坐标轴的数组 (比如控制器摇杆)。 |
| buttons | Array.<object> | 设备上的按键的数组。 |


### GameServerManager wx.getGameServerManager()

基础库 2.8.0 开始支持，低版本需做兼容处理。

| 错误码 | 错误信息 | 说明 |
| --- | --- | --- |
| 1001 | has not logged in to server | 未登录到服务器就调用接口 |
| 2100 |  | 登录帧同步服务器超时 |
| 2101 |  | 重连帧同步服务器超时 |
| 2200 |  | 登录帧同步服务器错误或失败导致的disconnect |
| 2201 |  | 长期未收到帧导致的disconnect |
| 2202 |  | 长期未收到心跳导致的disconnect |
| 2203 |  | 断线过久，无法重连导致的disconnect |
| 2204 |  | UDPconnectionfail导致的disconnect |
| 2300 |  | UDPsocketerror |
| 2301 |  | UDPsystemerror |
| 2303 |  | UDPaddresserror |
| 2304 |  | UDPporterror |
| 2305 |  | UDPsenderror |
| 2401 |  | 登录帧同步服务器成功之前发送帧 |
| 2402 |  | frame长度超过MTU |
| 4001 | system error | 系统错误 |
| 4002 | record not exist | 访问记录不存在 |
| 4003 | invalid req | 非法请求 |
| 4005 | invalid room state | 房间状态异常 |
| 4006 | reach room member limit | 房间到达人数上限，无法加入 |
| 4009 | headimg and nickname is not authorized by the user | 该房间需要用户头像昵称，但用户未授权 |
| 4010 | fail to start game | 启动游戏失败 |
| 4011 | fail to broadcast | 广播消息失败 |
| 4013 | buffer overflow | 自定义 buffer 超过指定大小（matchInfo 和 extInfo） |
| 200000 |  | 无效的请求参数 |
| 200006 |  | matchid此时为未打开状态 |
| 500001 |  | 用户已经在匹配队列中 |
| 500003 |  | 用户未在匹配队列中 |
| 500005 |  | 无效的match_id |
| 500009 |  | 路由到错误的服务器 |


### wx.getGroupCloudStorage(Object object)

基础库 1.9.92 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| shareTicket | string |  | 否 | 群分享对应的 shareTicket。shareTicket 与 groupid 只需要传其中一个，建议使用 groupid |  |
| groupid | string |  | 否 | 对应群的 opengid。可通过主域中的 wx.getGroupEnterInfo 接口获取。shareTicket 与 groupid 只需要传其中一个，建议使用 groupid | 3.8.8 |
| keyList | Array.<string> |  | 是 | 要拉取的 key 列表 |  |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.getGroupEnterInfo(Object object)

基础库 2.10.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| allowSingleChat | boolean | false | 否 | 开启后单聊下返回 open_single_roomid | 3.7.8 |
| needGroupOpenID | boolean | false | 否 | 开启后返回用户在群(含单聊)下的 group_openid | 3.7.8 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.getGroupInfo(Object object)

基础库 2.10.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| openGId | string |  | 是 | 群 openGId，可通过 wx.getGroupEnterInfo 或 wx.getShareInfo 获取 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getGroupMembersInfo(Object object)

基础库 3.7.12 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| members | Array.<string> |  | 是 | 需要获取的群用户的 groupOpenId 列表 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getInferenceEnvInfo(Object object)

基础库 2.30.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Object wx.getLaunchOptionsSync()

微信 Windows 版：支持

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | scene | number | 启动小游戏的场景值 |
|  | query | Record.<string, string> | 启动小游戏的 query 参数 |
|  | shareTicket | string | shareTicket，详见获取更多转发信息 |
|  | referrerInfo | object | 来源信息。从另一个小程序、公众号或 App 进入小程序时返回。否则返回 {}。(参见后文注意) |
|  | 结构属性 类型 说明 appId string 来源小程序、公众号或 App 的 appId extraData object 来源小程序传过来的数据，scene=1037或1038时支持 |  | 结构属性 | 类型 | 说明 |  | appId | string | 来源小程序、公众号或 App 的 appId |  | extraData | object | 来源小程序传过来的数据，scene=1037或1038时支持 |
|  | 结构属性 | 类型 | 说明 |
|  | appId | string | 来源小程序、公众号或 App 的 appId |
|  | extraData | object | 来源小程序传过来的数据，scene=1037或1038时支持 |
|  | hostExtraData | Object | 宿主传递的数据，第三方 app 中运行小游戏时返回 |
|  | 结构属性 类型 说明 host_scene string 宿主app对应的场景值 |  | 结构属性 | 类型 | 说明 |  | host_scene | string | 宿主app对应的场景值 |
|  | 结构属性 | 类型 | 说明 |
|  | host_scene | string | 宿主app对应的场景值 |
|  | chatType | number | 从微信群聊/单聊打开小程序时，chatType 表示具体微信群聊/单聊类型 |
|  | 合法值 说明 1 微信联系人单聊 2 企业微信联系人单聊 3 普通微信群聊 4 企业微信互通群聊 | 合法值 | 说明 | 1 | 微信联系人单聊 | 2 | 企业微信联系人单聊 | 3 | 普通微信群聊 | 4 | 企业微信互通群聊 |
| 合法值 | 说明 |
| 1 | 微信联系人单聊 |
| 2 | 企业微信联系人单聊 |
| 3 | 普通微信群聊 |
| 4 | 企业微信互通群聊 |


### wx.getLocalIPAddress(Object object)

基础库 2.20.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getLocation(Object object)

从基础库 3.0.1 开始，本接口停止维护，请使用 wx.getFuzzyLocation 代替

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| type | string | wgs84 | 否 | wgs84 返回 gps 坐标，gcj02 返回可用于 wx.openLocation 的坐标 |  |
| altitude | boolean | false | 否 | 传入 true 会返回高度信息，由于获取高度需要较高精确度，会减慢接口返回速度 | 1.6.0 |
| isHighAccuracy | boolean | false | 否 | 开启高精度定位 | 2.9.0 |
| highAccuracyExpireTime | number |  | 否 | 高精度定位超时时间(ms)，指定时间内返回最高精度，该值3000ms以上高精度定位才有效果 | 2.9.0 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### LogManager wx.getLogManager(Object object)

基础库 2.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| level | number | 0 | 否 | 取值为0/1，取值为0表示会把 App、Page 的生命周期函数和 wx 命名空间下的函数调用写入日志，取值为1则不会。默认值是 0 | 2.3.2 |


### Object wx.getMenuButtonBoundingClientRect()

基础库 2.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| width | number | 宽度，单位：px |
| height | number | 高度，单位：px |
| top | number | 上边界坐标，单位：px |
| right | number | 右边界坐标，单位：px |
| bottom | number | 下边界坐标，单位：px |
| left | number | 左边界坐标，单位：px |


### MiniReportManager wx.getMiniReportManager(Object param)

基础库 3.8.12 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| eventList | Array | [] | 否 | 需要上报的事件ID列表 |
| debug | boolean | false | 否 | 是否开启调试模式，调试模式下每次上报成功都会在控制台输出上报内容。调试模式仅在开发版和体验版小游戏中生效。 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getNetworkType(Object object)

以 Promise 风格 调用：支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Object wx.getOfficialComponentsInfo()

基础库 3.7.12 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | notificationComponentInfo | Object | 通知组件信息 |
|  | 结构属性 类型 说明 name string 组件的名称 isVisible boolean 组件是否显示 boundingClientRect Object 组件的布局位置信息 结构属性 类型 说明 width number 宽度，单位：px height number 高度，单位：px top number 上边界坐标，单位：px right number 右边界坐标，单位：px bottom number 下边界坐标，单位：px left number 左边界坐标，单位：px |  | 结构属性 | 类型 | 说明 |  | name | string | 组件的名称 |  | isVisible | boolean | 组件是否显示 |  | boundingClientRect | Object | 组件的布局位置信息 |  | 结构属性 类型 说明 width number 宽度，单位：px height number 高度，单位：px top number 上边界坐标，单位：px right number 右边界坐标，单位：px bottom number 下边界坐标，单位：px left number 左边界坐标，单位：px |  | 结构属性 | 类型 | 说明 |  | width | number | 宽度，单位：px |  | height | number | 高度，单位：px |  | top | number | 上边界坐标，单位：px |  | right | number | 右边界坐标，单位：px |  | bottom | number | 下边界坐标，单位：px |  | left | number | 左边界坐标，单位：px |
|  | 结构属性 | 类型 | 说明 |
|  | name | string | 组件的名称 |
|  | isVisible | boolean | 组件是否显示 |
|  | boundingClientRect | Object | 组件的布局位置信息 |
|  | 结构属性 类型 说明 width number 宽度，单位：px height number 高度，单位：px top number 上边界坐标，单位：px right number 右边界坐标，单位：px bottom number 下边界坐标，单位：px left number 左边界坐标，单位：px |  | 结构属性 | 类型 | 说明 |  | width | number | 宽度，单位：px |  | height | number | 高度，单位：px |  | top | number | 上边界坐标，单位：px |  | right | number | 右边界坐标，单位：px |  | bottom | number | 下边界坐标，单位：px |  | left | number | 左边界坐标，单位：px |
|  | 结构属性 | 类型 | 说明 |
|  | width | number | 宽度，单位：px |
|  | height | number | 高度，单位：px |
|  | top | number | 上边界坐标，单位：px |
|  | right | number | 右边界坐标，单位：px |
|  | bottom | number | 下边界坐标，单位：px |
|  | left | number | 左边界坐标，单位：px |
|  | rewardsComponentInfo | Object | 福利组件信息 |
|  | 结构属性 类型 说明 name string 组件的名称 canReceiveGiftCount number 可领取的礼包数量 canReceiveFriendGiftCount number 可领取的好友礼包数量 receiveDetail Object 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） 结构属性 类型 说明 type string gift: 礼包, friendGift: 好友礼包 name string 礼包名称，只有 gift 类型才有 desc string 礼包描述，只有 gift 类型才有 icon string 礼包图标，只有 gift 类型才有 |  | 结构属性 | 类型 | 说明 |  | name | string | 组件的名称 |  | canReceiveGiftCount | number | 可领取的礼包数量 |  | canReceiveFriendGiftCount | number | 可领取的好友礼包数量 |  | receiveDetail | Object | 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） |  | 结构属性 类型 说明 type string gift: 礼包, friendGift: 好友礼包 name string 礼包名称，只有 gift 类型才有 desc string 礼包描述，只有 gift 类型才有 icon string 礼包图标，只有 gift 类型才有 |  | 结构属性 | 类型 | 说明 |  | type | string | gift: 礼包, friendGift: 好友礼包 |  | name | string | 礼包名称，只有 gift 类型才有 |  | desc | string | 礼包描述，只有 gift 类型才有 |  | icon | string | 礼包图标，只有 gift 类型才有 |
|  | 结构属性 | 类型 | 说明 |
|  | name | string | 组件的名称 |
|  | canReceiveGiftCount | number | 可领取的礼包数量 |
|  | canReceiveFriendGiftCount | number | 可领取的好友礼包数量 |
|  | receiveDetail | Object | 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） |
|  | 结构属性 类型 说明 type string gift: 礼包, friendGift: 好友礼包 name string 礼包名称，只有 gift 类型才有 desc string 礼包描述，只有 gift 类型才有 icon string 礼包图标，只有 gift 类型才有 |  | 结构属性 | 类型 | 说明 |  | type | string | gift: 礼包, friendGift: 好友礼包 |  | name | string | 礼包名称，只有 gift 类型才有 |  | desc | string | 礼包描述，只有 gift 类型才有 |  | icon | string | 礼包图标，只有 gift 类型才有 |
|  | 结构属性 | 类型 | 说明 |
|  | type | string | gift: 礼包, friendGift: 好友礼包 |
|  | name | string | 礼包名称，只有 gift 类型才有 |
|  | desc | string | 礼包描述，只有 gift 类型才有 |
|  | icon | string | 礼包图标，只有 gift 类型才有 |
|  | challengeRewardsComponentInfo | Object | 擂台赛组件领奖信息 |
|  | 结构属性 类型 说明 name string 组件的名称 receiveDetail Object 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） 结构属性 类型 说明 userSourceList Array.<Object> 用户领取的奖励列表 结构属性 类型 说明 source Object 奖励来源信息 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 sourceNum number 获取的奖励数量 sourceType number 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 awardResult number 奖励领取结果：1-全部成功, 2-部分成功（礼物达到领取上限）, 3-领奖失败 receivedRareReward boolean 是否收到了稀有奖励 |  | 结构属性 | 类型 | 说明 |  | name | string | 组件的名称 |  | receiveDetail | Object | 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） |  | 结构属性 类型 说明 userSourceList Array.<Object> 用户领取的奖励列表 结构属性 类型 说明 source Object 奖励来源信息 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 sourceNum number 获取的奖励数量 sourceType number 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 awardResult number 奖励领取结果：1-全部成功, 2-部分成功（礼物达到领取上限）, 3-领奖失败 receivedRareReward boolean 是否收到了稀有奖励 |  | 结构属性 | 类型 | 说明 |  | userSourceList | Array.<Object> | 用户领取的奖励列表 |  | 结构属性 类型 说明 source Object 奖励来源信息 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 sourceNum number 获取的奖励数量 sourceType number 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 |  | 结构属性 | 类型 | 说明 |  | source | Object | 奖励来源信息 |  | 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 |  | 结构属性 | 类型 | 说明 |  | propList | Array.<Object> | 道具列表 |  | 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 |  | 结构属性 | 类型 | 说明 |  | propName | string | 道具名称 |  | propNum | number | 道具数量 |  | sourceName | string | 礼包名称 |  | type | number | 奖励类型：1-普通奖励, 2-稀有奖励 |  | sourceNum | number | 获取的奖励数量 |  | sourceType | number | 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 |  | awardResult | number | 奖励领取结果：1-全部成功, 2-部分成功（礼物达到领取上限）, 3-领奖失败 |  | receivedRareReward | boolean | 是否收到了稀有奖励 |
|  | 结构属性 | 类型 | 说明 |
|  | name | string | 组件的名称 |
|  | receiveDetail | Object | 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） |
|  | 结构属性 类型 说明 userSourceList Array.<Object> 用户领取的奖励列表 结构属性 类型 说明 source Object 奖励来源信息 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 sourceNum number 获取的奖励数量 sourceType number 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 awardResult number 奖励领取结果：1-全部成功, 2-部分成功（礼物达到领取上限）, 3-领奖失败 receivedRareReward boolean 是否收到了稀有奖励 |  | 结构属性 | 类型 | 说明 |  | userSourceList | Array.<Object> | 用户领取的奖励列表 |  | 结构属性 类型 说明 source Object 奖励来源信息 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 sourceNum number 获取的奖励数量 sourceType number 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 |  | 结构属性 | 类型 | 说明 |  | source | Object | 奖励来源信息 |  | 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 |  | 结构属性 | 类型 | 说明 |  | propList | Array.<Object> | 道具列表 |  | 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 |  | 结构属性 | 类型 | 说明 |  | propName | string | 道具名称 |  | propNum | number | 道具数量 |  | sourceName | string | 礼包名称 |  | type | number | 奖励类型：1-普通奖励, 2-稀有奖励 |  | sourceNum | number | 获取的奖励数量 |  | sourceType | number | 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 |  | awardResult | number | 奖励领取结果：1-全部成功, 2-部分成功（礼物达到领取上限）, 3-领奖失败 |  | receivedRareReward | boolean | 是否收到了稀有奖励 |
|  | 结构属性 | 类型 | 说明 |
|  | userSourceList | Array.<Object> | 用户领取的奖励列表 |
|  | 结构属性 类型 说明 source Object 奖励来源信息 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 sourceNum number 获取的奖励数量 sourceType number 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 |  | 结构属性 | 类型 | 说明 |  | source | Object | 奖励来源信息 |  | 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 |  | 结构属性 | 类型 | 说明 |  | propList | Array.<Object> | 道具列表 |  | 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 |  | 结构属性 | 类型 | 说明 |  | propName | string | 道具名称 |  | propNum | number | 道具数量 |  | sourceName | string | 礼包名称 |  | type | number | 奖励类型：1-普通奖励, 2-稀有奖励 |  | sourceNum | number | 获取的奖励数量 |  | sourceType | number | 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 |
|  | 结构属性 | 类型 | 说明 |
|  | source | Object | 奖励来源信息 |
|  | 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 |  | 结构属性 | 类型 | 说明 |  | propList | Array.<Object> | 道具列表 |  | 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 |  | 结构属性 | 类型 | 说明 |  | propName | string | 道具名称 |  | propNum | number | 道具数量 |  | sourceName | string | 礼包名称 |  | type | number | 奖励类型：1-普通奖励, 2-稀有奖励 |
|  | 结构属性 | 类型 | 说明 |
|  | propList | Array.<Object> | 道具列表 |
|  | 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 |  | 结构属性 | 类型 | 说明 |  | propName | string | 道具名称 |  | propNum | number | 道具数量 |
|  | 结构属性 | 类型 | 说明 |
|  | propName | string | 道具名称 |
|  | propNum | number | 道具数量 |
|  | sourceName | string | 礼包名称 |
|  | type | number | 奖励类型：1-普通奖励, 2-稀有奖励 |
|  | sourceNum | number | 获取的奖励数量 |
|  | sourceType | number | 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 |
|  | awardResult | number | 奖励领取结果：1-全部成功, 2-部分成功（礼物达到领取上限）, 3-领奖失败 |
|  | receivedRareReward | boolean | 是否收到了稀有奖励 |


### OpenDataContext wx.getOpenDataContext(Object object)

基础库 1.9.92 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | sharedCanvasMode | String | offscreenCanvas | 否 | 共享画布类型，有效值为 offscreenCanvas 和 screenCanvas，默认为 offscreenCanvas。区别： offscreenCanvas 模式下，sharedCanvas 绘制完后需要渲染到主屏；screenCanvas 模式下，sharedCanvas 为独立渲染，并且本身已经上屏。 |
|  | 合法值 说明 offscreenCanvas sharedCanvas 绘制完后需要渲染到主屏 screenCanvas sharedCanvas 独立渲染，并且本身已经上屏 | 合法值 | 说明 | offscreenCanvas | sharedCanvas 绘制完后需要渲染到主屏 | screenCanvas | sharedCanvas 独立渲染，并且本身已经上屏 |
| 合法值 | 说明 |
| offscreenCanvas | sharedCanvas 绘制完后需要渲染到主屏 |
| screenCanvas | sharedCanvas 独立渲染，并且本身已经上屏 |


### wx.getPhoneNumber(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| isRealtime | boolean | false | 否 | 手机号实时验证，向用户申请，并在用户同意后，快速填写和实时验证手机号 具体说明。 |
| phoneNumberNoQuotaToast | boolean | true | 否 | 当手机号快速验证或手机号实时验证额度用尽时，是否对用户展示“申请获取你的手机号，但该功能使用次数已达当前小程序上限，暂时无法使用”的提示，默认展示。 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getPotentialFriendList(Object object)

基础库 2.9.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getPrivacySetting(Object object)

基础库 2.32.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getScreenBrightness(Object object)

基础库 1.2.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getScreenRecordingState(Object object)

基础库 3.1.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getSetting(Object object)

基础库 1.2.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| withSubscriptions | Boolean | false | 否 | 是否同时获取用户订阅消息的订阅状态，默认不获取。注意：withSubscriptions 只返回用户勾选过订阅面板中的“总是保持以上选择，不再询问”的订阅消息。 | 2.10.1 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.getShareInfo(Object object)

从基础库 2.17.3 开始，本接口停止维护，请使用 wx.getGroupEnterInfo 代替

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| shareTicket | string |  | 是 | shareTicket，详见获取更多转发信息 |  |
| timeout | number |  | 否 | 超时时间，单位 ms | 1.9.90 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.getShowSplashAdStatus(Object object)

基础库 3.7.8 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getStorage(Object object)

以 Promise 风格 调用：支持

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| key | string |  | 是 | 本地缓存中指定的 key |  |
| encrypt | Boolean | false | 否 | 是否开启加密存储。只有异步的 getStorage 接口支持开启加密存储。开启后，将会对 data 使用 AES128 解密，接口回调耗时将会增加。若开启加密存储，setStorage 和 getStorage 需要同时声明 encrypt 的值为 true | 2.21.3 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.getStorageInfo(Object object)

以 Promise 风格 调用：支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Object wx.getStorageInfoSync()

以 Promise 风格 调用：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| keys | Array.<string> | 当前 storage 中所有的 key |
| currentSize | number | 当前占用的空间大小, 单位 KB |
| limitSize | number | 限制的空间大小，单位 KB |


### wx.getSystemInfo(Object object)

从基础库 2.20.1 开始，本接口停止维护，请使用 wx.getSystemSetting、wx.getAppAuthorizeSetting、wx.getDeviceInfo、wx.getWindowInfo、wx.getAppBaseInfo 代替

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getSystemInfoAsync(Object object)

从基础库 2.20.1 开始，本接口停止维护，请使用 wx.getSystemSetting、wx.getAppAuthorizeSetting、wx.getDeviceInfo、wx.getWindowInfo、wx.getAppBaseInfo 代替

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Object wx.getSystemInfoSync()

从基础库 2.20.1 开始，本接口停止维护，请使用 wx.getSystemSetting、wx.getAppAuthorizeSetting、wx.getDeviceInfo、wx.getWindowInfo、wx.getAppBaseInfo 代替

|  | 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- |
|  | brand | string | 设备品牌 | 1.5.0 |
|  | model | string | 设备型号。新机型刚推出一段时间会显示unknown，微信会尽快进行适配。 |  |
|  | pixelRatio | number | 设备像素比 |  |
|  | screenWidth | number | 屏幕宽度，单位px | 1.1.0 |
|  | screenHeight | number | 屏幕高度，单位px | 1.1.0 |
|  | windowWidth | number | 可使用窗口宽度，单位px |  |
|  | windowHeight | number | 可使用窗口高度，单位px |  |
|  | statusBarHeight | number | 状态栏的高度，单位px | 1.9.0 |
|  | language | string | 微信设置的语言 |  |
|  | version | string | 微信版本号 |  |
|  | system | string | 操作系统及版本 |  |
|  | platform | string | 客户端平台 |  |
|  | 合法值 说明 ios iOS微信（包含 iPhone、iPad） android Android微信 ohos HarmonyOS 手机端微信 ohos_pc HarmonyOS PC微信 windows Windows微信 mac macOS微信 devtools 微信开发者工具 | 合法值 | 说明 | ios | iOS微信（包含 iPhone、iPad） | android | Android微信 | ohos | HarmonyOS 手机端微信 | ohos_pc | HarmonyOS PC微信 | windows | Windows微信 | mac | macOS微信 | devtools | 微信开发者工具 |
| 合法值 | 说明 |
| ios | iOS微信（包含 iPhone、iPad） |
| android | Android微信 |
| ohos | HarmonyOS 手机端微信 |
| ohos_pc | HarmonyOS PC微信 |
| windows | Windows微信 |
| mac | macOS微信 |
| devtools | 微信开发者工具 |
|  | fontSizeSetting | number | 用户字体大小（单位px）。以微信客户端「我-设置-通用-字体大小」中的设置为准 | 1.5.0 |
|  | SDKVersion | string | 客户端基础库版本 | 1.1.0 |
|  | benchmarkLevel | number | 设备性能等级（仅 Android）。取值为：-2 或 0（该设备无法运行小游戏），-1（性能未知），>=1（设备性能值，该值越高，设备性能越好） 注意：性能等级当前仅反馈真机机型，暂不支持 IDE 模拟器机型 | 1.8.0 |
|  | albumAuthorized | boolean | 允许微信使用相册的开关（仅 iOS 有效） | 2.6.0 |
|  | cameraAuthorized | boolean | 允许微信使用摄像头的开关 | 2.6.0 |
|  | locationAuthorized | boolean | 允许微信使用定位的开关 | 2.6.0 |
|  | microphoneAuthorized | boolean | 允许微信使用麦克风的开关 | 2.6.0 |
|  | notificationAuthorized | boolean | 允许微信通知的开关 | 2.6.0 |
|  | notificationAlertAuthorized | boolean | 允许微信通知带有提醒的开关（仅 iOS 有效） | 2.6.0 |
|  | notificationBadgeAuthorized | boolean | 允许微信通知带有标记的开关（仅 iOS 有效） | 2.6.0 |
|  | notificationSoundAuthorized | boolean | 允许微信通知带有声音的开关（仅 iOS 有效） | 2.6.0 |
|  | phoneCalendarAuthorized | boolean | 允许微信使用日历的开关 | 2.19.3 |
|  | bluetoothEnabled | boolean | 蓝牙的系统开关 | 2.6.0 |
|  | locationEnabled | boolean | 地理位置的系统开关 | 2.6.0 |
|  | wifiEnabled | boolean | Wi-Fi 的系统开关 | 2.6.0 |
|  | safeArea | Object | 在竖屏正方向下的安全区域。部分机型没有安全区域概念，也不会返回 safeArea 字段，开发者需自行兼容。 | 2.7.0 |
|  | 结构属性 类型 说明 left number 安全区域左上角横坐标 right number 安全区域右下角横坐标 top number 安全区域左上角纵坐标 bottom number 安全区域右下角纵坐标 width number 安全区域的宽度，单位逻辑像素 height number 安全区域的高度，单位逻辑像素 |  | 结构属性 | 类型 | 说明 |  | left | number | 安全区域左上角横坐标 |  | right | number | 安全区域右下角横坐标 |  | top | number | 安全区域左上角纵坐标 |  | bottom | number | 安全区域右下角纵坐标 |  | width | number | 安全区域的宽度，单位逻辑像素 |  | height | number | 安全区域的高度，单位逻辑像素 |
|  | 结构属性 | 类型 | 说明 |
|  | left | number | 安全区域左上角横坐标 |
|  | right | number | 安全区域右下角横坐标 |
|  | top | number | 安全区域左上角纵坐标 |
|  | bottom | number | 安全区域右下角纵坐标 |
|  | width | number | 安全区域的宽度，单位逻辑像素 |
|  | height | number | 安全区域的高度，单位逻辑像素 |
|  | locationReducedAccuracy | boolean | `true` 表示模糊定位，`false` 表示精确定位，仅 iOS 支持 |  |
|  | theme | string | 系统当前主题，取值为`light`或`dark`，全局配置`"darkmode":true`时才能获取，否则为 undefined （不支持小游戏） | 2.11.0 |
|  | 合法值 说明 dark 深色主题 light 浅色主题 | 合法值 | 说明 | dark | 深色主题 | light | 浅色主题 |
| 合法值 | 说明 |
| dark | 深色主题 |
| light | 浅色主题 |
|  | host | Object | 当前小程序运行的宿主环境 | 2.12.3 |
|  | 结构属性 类型 说明 appId string 宿主 app 对应的 appId |  | 结构属性 | 类型 | 说明 |  | appId | string | 宿主 app 对应的 appId |
|  | 结构属性 | 类型 | 说明 |
|  | appId | string | 宿主 app 对应的 appId |
|  | enableDebug | boolean | 是否已打开调试。可通过右上角菜单或 wx.setEnableDebug 打开调试。 | 2.15.0 |
|  | deviceOrientation | string | 设备方向（注意：IOS客户端横屏游戏获取deviceOrientation可能不准，建议以屏幕宽高为准） |  |
|  | 合法值 说明 portrait 竖屏 landscape 横屏 | 合法值 | 说明 | portrait | 竖屏 | landscape | 横屏 |
| 合法值 | 说明 |
| portrait | 竖屏 |
| landscape | 横屏 |


### Object wx.getSystemSetting()

基础库 2.25.3 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | bluetoothEnabled | boolean | 蓝牙的系统开关 |
|  | locationEnabled | boolean | 地理位置的系统开关 |
|  | wifiEnabled | boolean | Wi-Fi 的系统开关 |
|  | deviceOrientation | string | 设备方向（注意：IOS客户端横屏游戏获取deviceOrientation可能不准，建议以屏幕宽高为准） |
|  | 合法值 说明 portrait 竖屏 landscape 横屏 | 合法值 | 说明 | portrait | 竖屏 | landscape | 横屏 |
| 合法值 | 说明 |
| portrait | 竖屏 |
| landscape | 横屏 |


### number wx.getTextLineHeight(Object object)

以 Promise 风格 调用：不支持

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | fontStyle | string | normal | 否 | 字体样式 |
|  | 合法值 说明 normal 正常 italic 斜体 | 合法值 | 说明 | normal | 正常 | italic | 斜体 |
| 合法值 | 说明 |
| normal | 正常 |
| italic | 斜体 |
|  | fontWeight | string | normal | 否 | 字重 |
|  | 合法值 说明 normal 正常 bold 粗体 | 合法值 | 说明 | normal | 正常 | bold | 粗体 |
| 合法值 | 说明 |
| normal | 正常 |
| bold | 粗体 |
|  | fontSize | number | 16 | 否 | 字号 |
|  | fontFamily | string |  | 是 | 字体名称 |
|  | text | string |  | 是 | 文本的内容 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getUserCloudStorage(Object object)

基础库 1.9.92 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| keyList | Array.<string> |  | 是 | 要获取的 key 列表 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getUserCloudStorageKeys(Object object)

基础库 2.16.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getUserInfo(Object object)

以 Promise 风格 调用：不支持

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | withCredentials | boolean |  | 否 | 是否带上登录态信息。当 withCredentials 为 true 时，要求此前有调用过 wx.login 且登录态尚未过期，此时返回的数据会包含 encryptedData, iv 等敏感信息；当 withCredentials 为 false 时，不要求有登录态，返回的数据不包含 encryptedData, iv 等敏感信息。 |
|  | lang | string | en | 否 | 显示用户信息的语言 |
|  | 合法值 说明 en 英文 zh_CN 简体中文 zh_TW 繁体中文 | 合法值 | 说明 | en | 英文 | zh_CN | 简体中文 | zh_TW | 繁体中文 |
| 合法值 | 说明 |
| en | 英文 |
| zh_CN | 简体中文 |
| zh_TW | 繁体中文 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getUserInteractiveStorage(Object object)

基础库 2.7.7 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| keyList | Array.<string> |  | 是 | 要获取的 key 列表 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.getWeRunData(Object object)

基础库 1.2.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### Object wx.getWindowInfo()

基础库 2.25.3 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | pixelRatio | number | 设备像素比 |
|  | screenWidth | number | 屏幕宽度，单位px |
|  | screenHeight | number | 屏幕高度，单位px |
|  | windowWidth | number | 可使用窗口宽度，单位px |
|  | windowHeight | number | 可使用窗口高度，单位px |
|  | statusBarHeight | number | 状态栏的高度，单位px |
|  | safeArea | Object | 在竖屏正方向下的安全区域。部分机型没有安全区域概念，也不会返回 safeArea 字段，开发者需自行兼容。 |
|  | 结构属性 类型 说明 left number 安全区域左上角横坐标 right number 安全区域右下角横坐标 top number 安全区域左上角纵坐标 bottom number 安全区域右下角纵坐标 width number 安全区域的宽度，单位逻辑像素 height number 安全区域的高度，单位逻辑像素 |  | 结构属性 | 类型 | 说明 |  | left | number | 安全区域左上角横坐标 |  | right | number | 安全区域右下角横坐标 |  | top | number | 安全区域左上角纵坐标 |  | bottom | number | 安全区域右下角纵坐标 |  | width | number | 安全区域的宽度，单位逻辑像素 |  | height | number | 安全区域的高度，单位逻辑像素 |
|  | 结构属性 | 类型 | 说明 |
|  | left | number | 安全区域左上角横坐标 |
|  | right | number | 安全区域右下角横坐标 |
|  | top | number | 安全区域左上角纵坐标 |
|  | bottom | number | 安全区域右下角纵坐标 |
|  | width | number | 安全区域的宽度，单位逻辑像素 |
|  | height | number | 安全区域的高度，单位逻辑像素 |
|  | screenTop | number | 窗口上边缘的y值 |


### wx.hideKeyboard(Object object)

以 Promise 风格 调用：支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.hideLoading(Object object)

基础库 1.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| noConflict | boolean | false | 否 | 目前 toast 和 loading 相关接口可以相互混用，此参数可用于取消混用特性 | 2.22.1 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.hideShareMenu(Object object)

基础库 1.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| menus | Array.<string> |  | 否 | 本接口为 Beta 版本，暂只在 Android 平台支持。需要隐藏的转发按钮名称列表，默认['shareAppMessage', 'shareTimeline']。按钮名称合法值包含 "shareAppMessage"、"shareTimeline" 两种 | 2.11.3 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.hideToast(Object object)

以 Promise 风格 调用：支持

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| noConflict | boolean | false | 否 | 目前 toast 和 loading 相关接口可以相互混用，此参数可用于取消混用特性 | 2.22.1 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.initFaceDetect(Object object)

该接口已停止维护，推荐使用 wx.createVKSession 代替

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.isBluetoothDevicePaired(Object object)

基础库 2.20.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| deviceId | string |  | 是 | 蓝牙设备 id |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### boolean wx.isVKSupport(string version)

基础库 2.22.0 开始支持，低版本需做兼容处理。

| 值 | 说明 | 最低版本 |
| --- | --- | --- |
| v1 | 旧版本 |  |
| v2 | v2 版本，目前只有 iOS 基础库 2.22.0 以上支持 |  |


### wx.joinVoIPChat(Object object)

基础库 2.7.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- | --- |
|  | roomType | String | voice | 否 | 房间类型 |  |
|  | 合法值 说明 voice 音频房间，用于语音通话 video 视频房间，结合 voip-room 组件可显示成员画面 | 合法值 | 说明 | voice | 音频房间，用于语音通话 | video | 视频房间，结合 voip-room 组件可显示成员画面 |
| 合法值 | 说明 |
| voice | 音频房间，用于语音通话 |
| video | 视频房间，结合 voip-room 组件可显示成员画面 |
|  | signature | String |  | 是 | 签名，用于验证小游戏的身份 |  |
|  | nonceStr | String |  | 是 | 验证所需的随机字符串 |  |
|  | timeStamp | Number |  | 是 | 验证所需的时间戳 |  |
|  | groupId | String |  | 是 | 小游戏内此房间/群聊的 ID。同一时刻传入相同 groupId 的用户会进入到同个实时语音房间。 |  |
|  | muteConfig | Object |  | 否 | 静音设置 |  |
|  | 结构属性 类型 默认值 必填 说明 muteMicrophone Boolean false 否 是否静音麦克风 muteEarphone Boolean false 否 是否静音耳机 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | muteMicrophone | Boolean | false | 否 | 是否静音麦克风 |  | muteEarphone | Boolean | false | 否 | 是否静音耳机 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | muteMicrophone | Boolean | false | 否 | 是否静音麦克风 |
|  | muteEarphone | Boolean | false | 否 | 是否静音耳机 |
|  | forceCellularNetwork | boolean | false | 否 | 开启后，joinVoIPChat 会同时走 Wi-Fi 和蜂窝网络2种网络模式，保证实时通话体验。 | 2.29.0 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |  |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |  |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### LoadSubpackageTask wx.loadSubpackage(Object object)

基础库 2.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| name | string |  | 是 | 分包的名字，可以填 name 或者 root。在独立分包内，填 __GAME__ 表示加载主包，详见 小游戏独立分包指南 |
| success | function |  | 是 | 分包加载成功回调事件 |
| fail | function |  | 是 | 分包加载失败回调事件 |
| complete | function |  | 是 | 分包加载结束回调事件(加载成功、失败都会执行） |


### wx.login(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| timeout | number |  | 否 | 超时时间，单位ms | 1.9.90 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.makeBluetoothPair(Object object)

基础库 2.12.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| deviceId | string |  | 是 | 蓝牙设备 id |
| pin | string |  | 是 | pin 码，Base64 格式。 |
| timeout | number | 20000 | 否 | 超时时间，单位 ms |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.modifyFriendInteractiveStorage(Object object)

基础库 2.7.7 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- | --- |
|  | key | string |  | 是 | 需要修改的数据的 key，目前可以为 '1' - '50' |  |
|  | opNum | number |  | 是 | 需要修改的数值，目前只能为 1 |  |
|  | operation | string |  | 是 | 修改类型 |  |
|  | 合法值 说明 add 加 | 合法值 | 说明 | add | 加 |
| 合法值 | 说明 |
| add | 加 |
|  | toUser | string |  | 否 | 目标好友的 openId |  |
|  | title | string |  | 否 | 分享标题，如果设置了这个值，则在交互成功后自动询问用户是否分享给好友（需要配置模板规则） | 2.9.0 |
|  | imageUrl | string |  | 否 | 分享图片地址，详见 wx.shareMessageToFriend 同名参数（需要配置模板规则） | 2.9.0 |
|  | imageUrlId | string |  | 否 | 分享图片编号，详见 wx.shareMessageToFriend 同名参数（需要配置模板规则） | 2.9.0 |
|  | quiet | boolean | false | 否 | 是否静默修改（不弹框）。当进入场景是好友 定向分享 的卡片时有效，代表分享反馈操作，此时 toUser 默认为原分享者的 openId | 2.9.0 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |  |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |  |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.navigateBackMiniProgram(Object object)

基础库 3.5.6 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| extraData | Object | {} | 否 | 需要返回给上一个小程序的数据，上一个小程序可在 App.onShow 中获取到这份数据。 详情。 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.navigateToMiniProgram(Object object)

基础库 2.2.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- | --- |
|  | appId | string |  | 否 | 要打开的小程序 appId |  |
|  | path | string |  | 否 | 打开的页面路径，如果为空则打开首页。path 中 ? 后面的部分会成为 query，在小程序的 App.onLaunch、App.onShow 和 Page.onLoad 的回调函数或小游戏的 wx.onShow 回调函数、wx.getLaunchOptionsSync 中可以获取到 query 数据。对于小游戏，可以只传入 query 部分，来实现传参效果，如：传入 "?foo=bar"。 |  |
|  | extraData | object |  | 否 | 需要传递给目标小程序的数据，目标小程序可在 App.onLaunch，App.onShow 中获取到这份数据。如果跳转的是小游戏，可以在 wx.onShow、wx.getLaunchOptionsSync 中可以获取到这份数据。 |  |
|  | envVersion | string | release | 否 | 要打开的小程序版本。仅在当前小程序为开发版或体验版时此参数有效。如果当前小程序是正式版，则打开的小程序必定是正式版。 |  |
|  | 合法值 说明 develop 开发版 trial 体验版 release 正式版 | 合法值 | 说明 | develop | 开发版 | trial | 体验版 | release | 正式版 |
| 合法值 | 说明 |
| develop | 开发版 |
| trial | 体验版 |
| release | 正式版 |
|  | shortLink | string |  | 否 | 小程序链接，当传递该参数后，可以不传 appId 和 path。链接可以通过【小程序菜单】->【复制链接】获取。 | 2.18.1 |
|  | noRelaunchIfPathUnchanged | boolean | false | 否 | 不reLaunch目标小程序，直接打开目标跳转的小程序退后台时的页面，需满足以下条件：1. 目标跳转的小程序生命周期未被销毁；2. 且目标当次启动的path、query与上次启动相同，apiCategory以wx.getApiCategory接口的返回结果为准。 | 2.24.0 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |  |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |  |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.notifyBLECharacteristicValueChange(Object object)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| deviceId | string |  | 是 | 蓝牙设备 id |  |
| serviceId | string |  | 是 | 蓝牙特征对应服务的 UUID |  |
| characteristicId | string |  | 是 | 蓝牙特征的 UUID |  |
| state | boolean |  | 是 | 是否启用 notify |  |
| type | string | indication | 否 | 设置特征订阅类型，有效值有 notification 和 indication | 2.4.0 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.notifyGroupMembers(Object object)

基础库 3.7.12 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | title | string |  | 是 | 文字链标题，发送的内容将由微信拼接为：@的成员列表+“请完成：”/"请参与："+打开小程序的文字链，如「@alex @cindy 请完成：团建报名统计」。 |
|  | members | Array.<string> |  | 是 | 需要提醒的用户 group_openid 列表 |
|  | entrancePath | string |  | 是 | 如需传参，只传 query 即可，query 形如 ?a=1&b=2 |
|  | type | string | complete | 否 | 展示的动词 |
|  | 合法值 说明 participate 请参与 complete 请完成 | 合法值 | 说明 | participate | 请参与 | complete | 请完成 |
| 合法值 | 说明 |
| participate | 请参与 |
| complete | 请完成 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.onAccelerometerChange(function listener)

微信 鸿蒙 OS 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| x | number | X 轴 |
| y | number | Y 轴 |
| z | number | Z 轴 |


### wx.onAddToFavorites(function listener)

基础库 2.10.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| title | string | 收藏标题，不传则默认使用当前小游戏的昵称。 |
| query | string | 查询字符串，必须是 key1=val1&key2=val2 的格式。从收藏进入后，可通过 wx.getLaunchOptionsSync() 或 wx.onShow() 获取启动参数中的 query。 |
| imageUrl | string | 转发显示图片的链接，可以是网络图片路径或本地图片文件路径或相对代码包根目录的图片文件路径。显示图片长宽比是 5:4 |
| disableForward | boolean | 禁止收藏后长按转发，默认 false |


### wx.onBackgroundFetchData(function listener)

基础库 3.0.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| fetchType | string | 缓存数据类别，取值为 periodic 或 pre |
| fetchedData | string | 缓存数据 |
| timeStamp | number | 客户端拿到缓存数据的时间戳 |
| path | String | 小游戏页面路径（一般不需要传，除非使用到小游戏独立分包） |
| query | String | 传给页面的 query 参数 |
| scene | Number | 进入小游戏的场景值 |


### wx.onBeaconServiceChange(function listener)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| available | boolean | 服务目前是否可用 |
| discovering | boolean | 目前是否处于搜索状态 |


### wx.onBeaconUpdate(function listener)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| beacons | Array.<BeaconInfo> | 当前搜寻到的所有 Beacon 设备列表 |


### wx.onBLECharacteristicValueChange(function listener)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| deviceId | string | 蓝牙设备 id |
| serviceId | string | 蓝牙特征对应服务的 UUID |
| characteristicId | string | 蓝牙特征的 UUID |
| value | ArrayBuffer | 特征最新的值 |


### wx.onBLEConnectionStateChange(function listener)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| deviceId | string | 蓝牙设备 id |
| connected | boolean | 是否处于已连接状态 |


### wx.onBLEMTUChange(function listener)

基础库 2.20.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| deviceId | string | 蓝牙设备 id |
| mtu | number | 最大传输单元 |


### wx.onBLEPeripheralConnectionStateChanged(function listener)

基础库 2.10.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| deviceId | String | 连接状态变化的设备 id |
| serverId | String | server 的 UUID |
| connected | Boolean | 连接目前状态 |


### wx.onBluetoothAdapterStateChange(function listener)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| available | boolean | 蓝牙适配器是否可用 |
| discovering | boolean | 蓝牙适配器是否处于搜索状态 |


### wx.onBluetoothDeviceFound(function listener)

基础库 2.9.2 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | devices | Array.<Object> | 新搜索到的设备列表 |
|  | 结构属性 类型 说明 name string 蓝牙设备名称，某些设备可能没有 deviceId string 蓝牙设备 id RSSI number 当前蓝牙设备的信号强度，单位 dBm advertisData ArrayBuffer 当前蓝牙设备的广播数据段中的 ManufacturerData 数据段。 advertisServiceUUIDs Array.<string> 当前蓝牙设备的广播数据段中的 ServiceUUIDs 数据段 localName string 当前蓝牙设备的广播数据段中的 LocalName 数据段 serviceData Object 当前蓝牙设备的广播数据段中的 ServiceData 数据段 connectable boolean 当前蓝牙设备是否可连接（ Android 8.0 以下不支持返回该值 ） |  | 结构属性 | 类型 | 说明 |  | name | string | 蓝牙设备名称，某些设备可能没有 |  | deviceId | string | 蓝牙设备 id |  | RSSI | number | 当前蓝牙设备的信号强度，单位 dBm |  | advertisData | ArrayBuffer | 当前蓝牙设备的广播数据段中的 ManufacturerData 数据段。 |  | advertisServiceUUIDs | Array.<string> | 当前蓝牙设备的广播数据段中的 ServiceUUIDs 数据段 |  | localName | string | 当前蓝牙设备的广播数据段中的 LocalName 数据段 |  | serviceData | Object | 当前蓝牙设备的广播数据段中的 ServiceData 数据段 |  | connectable | boolean | 当前蓝牙设备是否可连接（ Android 8.0 以下不支持返回该值 ） |
|  | 结构属性 | 类型 | 说明 |
|  | name | string | 蓝牙设备名称，某些设备可能没有 |
|  | deviceId | string | 蓝牙设备 id |
|  | RSSI | number | 当前蓝牙设备的信号强度，单位 dBm |
|  | advertisData | ArrayBuffer | 当前蓝牙设备的广播数据段中的 ManufacturerData 数据段。 |
|  | advertisServiceUUIDs | Array.<string> | 当前蓝牙设备的广播数据段中的 ServiceUUIDs 数据段 |
|  | localName | string | 当前蓝牙设备的广播数据段中的 LocalName 数据段 |
|  | serviceData | Object | 当前蓝牙设备的广播数据段中的 ServiceData 数据段 |
|  | connectable | boolean | 当前蓝牙设备是否可连接（ Android 8.0 以下不支持返回该值 ） |


### wx.onCompassChange(function listener)

微信 鸿蒙 OS 版：支持

| 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- |
| direction | number | 面对的方向度数 |  |
| accuracy | number/string | 精度 | 2.4.0 |


### wx.onCopyUrl(function listener)

基础库 2.14.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| query | string | 用短链打开小程序时当前页面携带的查询字符串。小程序中使用时，应在进入页面时调用 wx.onCopyUrl 自定义 query，退出页面时调用 wx.offCopyUrl，防止影响其它页面。 |


### wx.onDeviceMotionChange(function listener)

基础库 2.3.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| alpha | number | 当 手机坐标 X/Y 和 地球 X/Y 重合时，绕着 Z 轴转动的夹角为 alpha，范围值为 [0, 2*PI)。逆时针转动为正。 |
| beta | number | 当手机坐标 Y/Z 和地球 Y/Z 重合时，绕着 X 轴转动的夹角为 beta。范围值为 [-1*PI, PI) 。顶部朝着地球表面转动为正。也有可能朝着用户为正。 |
| gamma | number | 当手机 X/Z 和地球 X/Z 重合时，绕着 Y 轴转动的夹角为 gamma。范围值为 [-1*PI/2, PI/2)。右边朝着地球表面转动为正。 |


### wx.onDeviceOrientationChange(function listener)

基础库 2.1.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | value | string | 切换后的屏幕方向。 |
|  | 合法值 说明 landscape 横屏正方向，以 HOME 键在屏幕右侧为正方向 landscapeReverse 横屏反方向，以 HOME 键在屏幕左侧为反方向 | 合法值 | 说明 | landscape | 横屏正方向，以 HOME 键在屏幕右侧为正方向 | landscapeReverse | 横屏反方向，以 HOME 键在屏幕左侧为反方向 |
| 合法值 | 说明 |
| landscape | 横屏正方向，以 HOME 键在屏幕右侧为正方向 |
| landscapeReverse | 横屏反方向，以 HOME 键在屏幕左侧为反方向 |


### wx.onDirectAdStatusChange(function listener)

基础库 3.11.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| isInMask | boolean | 当前是否处于蒙层阶段 |
| isInDirectGameAd | boolean | 当前是否处于直接广告中 |
| isEndByAbnormal | boolean | 当前直玩广告是否由于异常流程而结束（如 下拉/搜索 进入正在直玩广告流程中的游戏） |


### wx.onError(function listener)

微信 鸿蒙 OS 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| message | string | 错误信息，包含堆栈 |


### wx.onGamepadConnected(function listener)

基础库 3.6.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| gamepad | string | 本次连接到的 Gamepad 实例。 |


### wx.onGamepadDisconnected(function listener)

基础库 3.6.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| gamepad | string | 本次断开的 Gamepad 实例。 |


### wx.onGyroscopeChange(function listener)

基础库 2.3.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| x | number | x 轴的角速度 |
| y | number | y 轴的角速度 |
| z | number | z 轴的角速度 |


### wx.onHandoff(function listener)

基础库 2.14.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| query | string | 需要传递给接力客户端的 query |


### wx.onKeyboardComplete(function listener)

微信 鸿蒙 OS 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| value | string | 键盘输入的当前值 |


### wx.onKeyboardConfirm(function listener)

微信 鸿蒙 OS 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| value | string | 键盘输入的当前值 |


### wx.onKeyboardHeightChange(function listener)

基础库 2.21.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| height | number | 键盘高度 |


### wx.onKeyboardInput(function listener)

微信 鸿蒙 OS 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| value | string | 键盘输入的当前值 |


### wx.onKeyDown(function listener)

基础库 2.10.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| key | string | 同 Web 规范 KeyEvent key 属性 |
| code | string | 同 Web 规范 KeyEvent code 属性 |
| timeStamp | number | 事件触发时的时间戳 |


### wx.onKeyUp(function listener)

基础库 2.10.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| key | string | 同 Web 规范 KeyEvent key 属性 |
| code | string | 同 Web 规范 KeyEvent code 属性 |
| timeStamp | number | 事件触发时的时间戳 |


### wx.onMemoryWarning(function listener)

基础库 2.0.2 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | level | number | 内存告警等级，只有 Android 才有，对应系统宏定义 |
|  | 合法值 说明 5 TRIM_MEMORY_RUNNING_MODERATE 10 TRIM_MEMORY_RUNNING_LOW 15 TRIM_MEMORY_RUNNING_CRITICAL | 合法值 | 说明 | 5 | TRIM_MEMORY_RUNNING_MODERATE | 10 | TRIM_MEMORY_RUNNING_LOW | 15 | TRIM_MEMORY_RUNNING_CRITICAL |
| 合法值 | 说明 |
| 5 | TRIM_MEMORY_RUNNING_MODERATE |
| 10 | TRIM_MEMORY_RUNNING_LOW |
| 15 | TRIM_MEMORY_RUNNING_CRITICAL |


### wx.onMouseDown(function listener)

# 功能描述

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| x | number | 事件触发时鼠标所在的位置横坐标 |
| y | number | 事件触发时鼠标所在的位置纵坐标 |
| button | number | 按键类型，0左键，1中键，2右键 |
| timeStamp | number | 事件触发时的时间戳 |


### wx.onMouseMove(function listener)

# 功能描述

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| x | number | 事件触发时鼠标所在的位置横坐标 |
| y | number | 事件触发时鼠标所在的位置纵坐标 |
| movementX | number | 鼠标横坐标偏移量 |
| movementY | number | 鼠标纵坐标偏移量 |
| timeStamp | number | 事件触发时的时间戳 |


### wx.onMouseUp(function listener)

# 功能描述

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| x | number | 事件触发时鼠标所在的位置横坐标 |
| y | number | 事件触发时鼠标所在的位置纵坐标 |
| button | number | 按键类型，0左键，1中键，2右键 |
| timeStamp | number | 事件触发时的时间戳 |


### wx.onNeedPrivacyAuthorization(function listener)

基础库 2.32.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| referrer | string | 触发本次 onNeedPrivacyAuthorization 事件的接口或组件名（例如："getUserInfo", "UserInfoButton.onTap"） |


### wx.onNetworkStatusChange(function listener)

基础库 1.1.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | isConnected | boolean | 当前是否有网络连接 |
|  | networkType | string | 网络类型 |
|  | 合法值 说明 wifi wifi 网络 2g 2g 网络 3g 3g 网络 4g 4g 网络 5g 5g 网络 unknown Android 下不常见的网络类型 none 无网络 | 合法值 | 说明 | wifi | wifi 网络 | 2g | 2g 网络 | 3g | 3g 网络 | 4g | 4g 网络 | 5g | 5g 网络 | unknown | Android 下不常见的网络类型 | none | 无网络 |
| 合法值 | 说明 |
| wifi | wifi 网络 |
| 2g | 2g 网络 |
| 3g | 3g 网络 |
| 4g | 4g 网络 |
| 5g | 5g 网络 |
| unknown | Android 下不常见的网络类型 |
| none | 无网络 |


### wx.onNetworkWeakChange(function listener)

基础库 2.21.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| weakNet | boolean | 当前是否处于弱网状态 |
| networkType | string | 当前网络类型 |


### wx.onOfficialComponentsInfoChange(function listener)

基础库 3.7.12 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | OfficialComponentsInfo | Object | 全部组件的信息 |
|  | 结构属性 类型 说明 notificationComponentInfo Object 通知组件信息 结构属性 类型 说明 name string 组件的名称 isVisible boolean 组件是否显示 boundingClientRect Object 组件的布局位置信息 结构属性 类型 说明 width number 宽度，单位：px height number 高度，单位：px top number 上边界坐标，单位：px right number 右边界坐标，单位：px bottom number 下边界坐标，单位：px left number 左边界坐标，单位：px rewardsComponentInfo Object 福利组件信息 结构属性 类型 说明 name string 组件的名称 canReceiveGiftCount number 可领取的礼包数量 canReceiveFriendGiftCount number 可领取的好友礼包数量 receiveDetail Object 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） 结构属性 类型 说明 type string gift: 礼包, friendGift: 好友礼包 name string 礼包名称，只有 gift 类型才有 desc string 礼包描述，只有 gift 类型才有 icon string 礼包图标，只有 gift 类型才有 challengeRewardsComponentInfo Object 擂台赛组件领奖信息 结构属性 类型 说明 name string 组件的名称 receiveDetail Object 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） 结构属性 类型 说明 userSourceList Array.<Object> 用户领取的奖励列表 结构属性 类型 说明 source Object 奖励来源信息 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 sourceNum number 获取的奖励数量 sourceType number 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 awardResult number 奖励领取结果：1-全部成功, 2-部分成功（礼物达到领取上限）, 3-领奖失败 receivedRareReward boolean 是否收到了稀有奖励 |  | 结构属性 | 类型 | 说明 |  | notificationComponentInfo | Object | 通知组件信息 |  | 结构属性 类型 说明 name string 组件的名称 isVisible boolean 组件是否显示 boundingClientRect Object 组件的布局位置信息 结构属性 类型 说明 width number 宽度，单位：px height number 高度，单位：px top number 上边界坐标，单位：px right number 右边界坐标，单位：px bottom number 下边界坐标，单位：px left number 左边界坐标，单位：px |  | 结构属性 | 类型 | 说明 |  | name | string | 组件的名称 |  | isVisible | boolean | 组件是否显示 |  | boundingClientRect | Object | 组件的布局位置信息 |  | 结构属性 类型 说明 width number 宽度，单位：px height number 高度，单位：px top number 上边界坐标，单位：px right number 右边界坐标，单位：px bottom number 下边界坐标，单位：px left number 左边界坐标，单位：px |  | 结构属性 | 类型 | 说明 |  | width | number | 宽度，单位：px |  | height | number | 高度，单位：px |  | top | number | 上边界坐标，单位：px |  | right | number | 右边界坐标，单位：px |  | bottom | number | 下边界坐标，单位：px |  | left | number | 左边界坐标，单位：px |  | rewardsComponentInfo | Object | 福利组件信息 |  | 结构属性 类型 说明 name string 组件的名称 canReceiveGiftCount number 可领取的礼包数量 canReceiveFriendGiftCount number 可领取的好友礼包数量 receiveDetail Object 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） 结构属性 类型 说明 type string gift: 礼包, friendGift: 好友礼包 name string 礼包名称，只有 gift 类型才有 desc string 礼包描述，只有 gift 类型才有 icon string 礼包图标，只有 gift 类型才有 |  | 结构属性 | 类型 | 说明 |  | name | string | 组件的名称 |  | canReceiveGiftCount | number | 可领取的礼包数量 |  | canReceiveFriendGiftCount | number | 可领取的好友礼包数量 |  | receiveDetail | Object | 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） |  | 结构属性 类型 说明 type string gift: 礼包, friendGift: 好友礼包 name string 礼包名称，只有 gift 类型才有 desc string 礼包描述，只有 gift 类型才有 icon string 礼包图标，只有 gift 类型才有 |  | 结构属性 | 类型 | 说明 |  | type | string | gift: 礼包, friendGift: 好友礼包 |  | name | string | 礼包名称，只有 gift 类型才有 |  | desc | string | 礼包描述，只有 gift 类型才有 |  | icon | string | 礼包图标，只有 gift 类型才有 |  | challengeRewardsComponentInfo | Object | 擂台赛组件领奖信息 |  | 结构属性 类型 说明 name string 组件的名称 receiveDetail Object 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） 结构属性 类型 说明 userSourceList Array.<Object> 用户领取的奖励列表 结构属性 类型 说明 source Object 奖励来源信息 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 sourceNum number 获取的奖励数量 sourceType number 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 awardResult number 奖励领取结果：1-全部成功, 2-部分成功（礼物达到领取上限）, 3-领奖失败 receivedRareReward boolean 是否收到了稀有奖励 |  | 结构属性 | 类型 | 说明 |  | name | string | 组件的名称 |  | receiveDetail | Object | 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） |  | 结构属性 类型 说明 userSourceList Array.<Object> 用户领取的奖励列表 结构属性 类型 说明 source Object 奖励来源信息 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 sourceNum number 获取的奖励数量 sourceType number 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 awardResult number 奖励领取结果：1-全部成功, 2-部分成功（礼物达到领取上限）, 3-领奖失败 receivedRareReward boolean 是否收到了稀有奖励 |  | 结构属性 | 类型 | 说明 |  | userSourceList | Array.<Object> | 用户领取的奖励列表 |  | 结构属性 类型 说明 source Object 奖励来源信息 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 sourceNum number 获取的奖励数量 sourceType number 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 |  | 结构属性 | 类型 | 说明 |  | source | Object | 奖励来源信息 |  | 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 |  | 结构属性 | 类型 | 说明 |  | propList | Array.<Object> | 道具列表 |  | 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 |  | 结构属性 | 类型 | 说明 |  | propName | string | 道具名称 |  | propNum | number | 道具数量 |  | sourceName | string | 礼包名称 |  | type | number | 奖励类型：1-普通奖励, 2-稀有奖励 |  | sourceNum | number | 获取的奖励数量 |  | sourceType | number | 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 |  | awardResult | number | 奖励领取结果：1-全部成功, 2-部分成功（礼物达到领取上限）, 3-领奖失败 |  | receivedRareReward | boolean | 是否收到了稀有奖励 |
|  | 结构属性 | 类型 | 说明 |
|  | notificationComponentInfo | Object | 通知组件信息 |
|  | 结构属性 类型 说明 name string 组件的名称 isVisible boolean 组件是否显示 boundingClientRect Object 组件的布局位置信息 结构属性 类型 说明 width number 宽度，单位：px height number 高度，单位：px top number 上边界坐标，单位：px right number 右边界坐标，单位：px bottom number 下边界坐标，单位：px left number 左边界坐标，单位：px |  | 结构属性 | 类型 | 说明 |  | name | string | 组件的名称 |  | isVisible | boolean | 组件是否显示 |  | boundingClientRect | Object | 组件的布局位置信息 |  | 结构属性 类型 说明 width number 宽度，单位：px height number 高度，单位：px top number 上边界坐标，单位：px right number 右边界坐标，单位：px bottom number 下边界坐标，单位：px left number 左边界坐标，单位：px |  | 结构属性 | 类型 | 说明 |  | width | number | 宽度，单位：px |  | height | number | 高度，单位：px |  | top | number | 上边界坐标，单位：px |  | right | number | 右边界坐标，单位：px |  | bottom | number | 下边界坐标，单位：px |  | left | number | 左边界坐标，单位：px |
|  | 结构属性 | 类型 | 说明 |
|  | name | string | 组件的名称 |
|  | isVisible | boolean | 组件是否显示 |
|  | boundingClientRect | Object | 组件的布局位置信息 |
|  | 结构属性 类型 说明 width number 宽度，单位：px height number 高度，单位：px top number 上边界坐标，单位：px right number 右边界坐标，单位：px bottom number 下边界坐标，单位：px left number 左边界坐标，单位：px |  | 结构属性 | 类型 | 说明 |  | width | number | 宽度，单位：px |  | height | number | 高度，单位：px |  | top | number | 上边界坐标，单位：px |  | right | number | 右边界坐标，单位：px |  | bottom | number | 下边界坐标，单位：px |  | left | number | 左边界坐标，单位：px |
|  | 结构属性 | 类型 | 说明 |
|  | width | number | 宽度，单位：px |
|  | height | number | 高度，单位：px |
|  | top | number | 上边界坐标，单位：px |
|  | right | number | 右边界坐标，单位：px |
|  | bottom | number | 下边界坐标，单位：px |
|  | left | number | 左边界坐标，单位：px |
|  | rewardsComponentInfo | Object | 福利组件信息 |
|  | 结构属性 类型 说明 name string 组件的名称 canReceiveGiftCount number 可领取的礼包数量 canReceiveFriendGiftCount number 可领取的好友礼包数量 receiveDetail Object 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） 结构属性 类型 说明 type string gift: 礼包, friendGift: 好友礼包 name string 礼包名称，只有 gift 类型才有 desc string 礼包描述，只有 gift 类型才有 icon string 礼包图标，只有 gift 类型才有 |  | 结构属性 | 类型 | 说明 |  | name | string | 组件的名称 |  | canReceiveGiftCount | number | 可领取的礼包数量 |  | canReceiveFriendGiftCount | number | 可领取的好友礼包数量 |  | receiveDetail | Object | 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） |  | 结构属性 类型 说明 type string gift: 礼包, friendGift: 好友礼包 name string 礼包名称，只有 gift 类型才有 desc string 礼包描述，只有 gift 类型才有 icon string 礼包图标，只有 gift 类型才有 |  | 结构属性 | 类型 | 说明 |  | type | string | gift: 礼包, friendGift: 好友礼包 |  | name | string | 礼包名称，只有 gift 类型才有 |  | desc | string | 礼包描述，只有 gift 类型才有 |  | icon | string | 礼包图标，只有 gift 类型才有 |
|  | 结构属性 | 类型 | 说明 |
|  | name | string | 组件的名称 |
|  | canReceiveGiftCount | number | 可领取的礼包数量 |
|  | canReceiveFriendGiftCount | number | 可领取的好友礼包数量 |
|  | receiveDetail | Object | 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） |
|  | 结构属性 类型 说明 type string gift: 礼包, friendGift: 好友礼包 name string 礼包名称，只有 gift 类型才有 desc string 礼包描述，只有 gift 类型才有 icon string 礼包图标，只有 gift 类型才有 |  | 结构属性 | 类型 | 说明 |  | type | string | gift: 礼包, friendGift: 好友礼包 |  | name | string | 礼包名称，只有 gift 类型才有 |  | desc | string | 礼包描述，只有 gift 类型才有 |  | icon | string | 礼包图标，只有 gift 类型才有 |
|  | 结构属性 | 类型 | 说明 |
|  | type | string | gift: 礼包, friendGift: 好友礼包 |
|  | name | string | 礼包名称，只有 gift 类型才有 |
|  | desc | string | 礼包描述，只有 gift 类型才有 |
|  | icon | string | 礼包图标，只有 gift 类型才有 |
|  | challengeRewardsComponentInfo | Object | 擂台赛组件领奖信息 |
|  | 结构属性 类型 说明 name string 组件的名称 receiveDetail Object 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） 结构属性 类型 说明 userSourceList Array.<Object> 用户领取的奖励列表 结构属性 类型 说明 source Object 奖励来源信息 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 sourceNum number 获取的奖励数量 sourceType number 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 awardResult number 奖励领取结果：1-全部成功, 2-部分成功（礼物达到领取上限）, 3-领奖失败 receivedRareReward boolean 是否收到了稀有奖励 |  | 结构属性 | 类型 | 说明 |  | name | string | 组件的名称 |  | receiveDetail | Object | 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） |  | 结构属性 类型 说明 userSourceList Array.<Object> 用户领取的奖励列表 结构属性 类型 说明 source Object 奖励来源信息 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 sourceNum number 获取的奖励数量 sourceType number 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 awardResult number 奖励领取结果：1-全部成功, 2-部分成功（礼物达到领取上限）, 3-领奖失败 receivedRareReward boolean 是否收到了稀有奖励 |  | 结构属性 | 类型 | 说明 |  | userSourceList | Array.<Object> | 用户领取的奖励列表 |  | 结构属性 类型 说明 source Object 奖励来源信息 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 sourceNum number 获取的奖励数量 sourceType number 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 |  | 结构属性 | 类型 | 说明 |  | source | Object | 奖励来源信息 |  | 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 |  | 结构属性 | 类型 | 说明 |  | propList | Array.<Object> | 道具列表 |  | 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 |  | 结构属性 | 类型 | 说明 |  | propName | string | 道具名称 |  | propNum | number | 道具数量 |  | sourceName | string | 礼包名称 |  | type | number | 奖励类型：1-普通奖励, 2-稀有奖励 |  | sourceNum | number | 获取的奖励数量 |  | sourceType | number | 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 |  | awardResult | number | 奖励领取结果：1-全部成功, 2-部分成功（礼物达到领取上限）, 3-领奖失败 |  | receivedRareReward | boolean | 是否收到了稀有奖励 |
|  | 结构属性 | 类型 | 说明 |
|  | name | string | 组件的名称 |
|  | receiveDetail | Object | 领取事件详情（只在onOfficialComponentsInfoChange回调中返回） |
|  | 结构属性 类型 说明 userSourceList Array.<Object> 用户领取的奖励列表 结构属性 类型 说明 source Object 奖励来源信息 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 sourceNum number 获取的奖励数量 sourceType number 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 awardResult number 奖励领取结果：1-全部成功, 2-部分成功（礼物达到领取上限）, 3-领奖失败 receivedRareReward boolean 是否收到了稀有奖励 |  | 结构属性 | 类型 | 说明 |  | userSourceList | Array.<Object> | 用户领取的奖励列表 |  | 结构属性 类型 说明 source Object 奖励来源信息 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 sourceNum number 获取的奖励数量 sourceType number 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 |  | 结构属性 | 类型 | 说明 |  | source | Object | 奖励来源信息 |  | 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 |  | 结构属性 | 类型 | 说明 |  | propList | Array.<Object> | 道具列表 |  | 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 |  | 结构属性 | 类型 | 说明 |  | propName | string | 道具名称 |  | propNum | number | 道具数量 |  | sourceName | string | 礼包名称 |  | type | number | 奖励类型：1-普通奖励, 2-稀有奖励 |  | sourceNum | number | 获取的奖励数量 |  | sourceType | number | 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 |  | awardResult | number | 奖励领取结果：1-全部成功, 2-部分成功（礼物达到领取上限）, 3-领奖失败 |  | receivedRareReward | boolean | 是否收到了稀有奖励 |
|  | 结构属性 | 类型 | 说明 |
|  | userSourceList | Array.<Object> | 用户领取的奖励列表 |
|  | 结构属性 类型 说明 source Object 奖励来源信息 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 sourceNum number 获取的奖励数量 sourceType number 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 |  | 结构属性 | 类型 | 说明 |  | source | Object | 奖励来源信息 |  | 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 |  | 结构属性 | 类型 | 说明 |  | propList | Array.<Object> | 道具列表 |  | 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 |  | 结构属性 | 类型 | 说明 |  | propName | string | 道具名称 |  | propNum | number | 道具数量 |  | sourceName | string | 礼包名称 |  | type | number | 奖励类型：1-普通奖励, 2-稀有奖励 |  | sourceNum | number | 获取的奖励数量 |  | sourceType | number | 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 |
|  | 结构属性 | 类型 | 说明 |
|  | source | Object | 奖励来源信息 |
|  | 结构属性 类型 说明 propList Array.<Object> 道具列表 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 sourceName string 礼包名称 type number 奖励类型：1-普通奖励, 2-稀有奖励 |  | 结构属性 | 类型 | 说明 |  | propList | Array.<Object> | 道具列表 |  | 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 |  | 结构属性 | 类型 | 说明 |  | propName | string | 道具名称 |  | propNum | number | 道具数量 |  | sourceName | string | 礼包名称 |  | type | number | 奖励类型：1-普通奖励, 2-稀有奖励 |
|  | 结构属性 | 类型 | 说明 |
|  | propList | Array.<Object> | 道具列表 |
|  | 结构属性 类型 说明 propName string 道具名称 propNum number 道具数量 |  | 结构属性 | 类型 | 说明 |  | propName | string | 道具名称 |  | propNum | number | 道具数量 |
|  | 结构属性 | 类型 | 说明 |
|  | propName | string | 道具名称 |
|  | propNum | number | 道具数量 |
|  | sourceName | string | 礼包名称 |
|  | type | number | 奖励类型：1-普通奖励, 2-稀有奖励 |
|  | sourceNum | number | 获取的奖励数量 |
|  | sourceType | number | 奖励类型：0-道具礼包, 1-微信蓝包, 2-h5商家券, 3-现金红包, 4-小程序券, 5-盲盒 |
|  | awardResult | number | 奖励领取结果：1-全部成功, 2-部分成功（礼物达到领取上限）, 3-领奖失败 |
|  | receivedRareReward | boolean | 是否收到了稀有奖励 |


### wx.onScreenRecordingStateChanged(function listener)

基础库 3.1.4 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | state | string | 录屏状态 |
|  | 合法值 说明 start 开始录屏 stop 结束录屏 | 合法值 | 说明 | start | 开始录屏 | stop | 结束录屏 |
| 合法值 | 说明 |
| start | 开始录屏 |
| stop | 结束录屏 |


### wx.onShareAppMessage(function listener)

微信 鸿蒙 OS 版：支持

| 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- |
| title | string | 转发标题，不传则默认使用当前小游戏的昵称。 |  |
| imageUrl | string | 转发显示图片的链接，可以是网络图片路径或本地图片文件路径或相对代码包根目录的图片文件路径。显示图片长宽比是 5:4 |  |
| query | string | 查询字符串，必须是 key1=val1&key2=val2 的格式。从这条转发消息进入后，可通过 wx.getLaunchOptionsSync() 或 wx.onShow() 获取启动参数中的 query。 |  |
| imageUrlId | string | 审核通过的图片编号，详见 使用审核通过的转发图片 | 2.4.3 |
| promise | promise | 如果该参数存在，则其它的参数将会以 resolve 结果为准，如果三秒内不 resolve，分享会使用上面传入的默认参数 | 2.12.0 |
| toCurrentGroup | boolean | 是否转发到当前群。该参数只对从群工具栏打开的场景下生效，默认转发到当前群，填入false时可转发到其他会话。 | 2.12.2 |
| path | string | 独立分包路径。详见 小游戏独立分包指南 | 2.12.2 |


### wx.onShareMessageToFriend(function listener)

基础库 2.9.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| success | boolean | 是否成功 |
| errMsg | string | 错误信息 |


### wx.onShareTimeline(function listener)

基础库 2.11.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- |
| title | string | 转发标题，不传则默认使用当前小游戏的昵称。 |  |
| imageUrl | string | 转发显示图片的链接，可以是网络图片路径或本地图片文件路径或相对代码包根目录的图片文件路径。（该图片用于分享到朋友圈的卡片以及从朋友圈转发到会话消息的卡片展示） |  |
| imageUrlId | string | 审核通过的图片编号，详见 使用审核通过的转发图片 |  |
| imagePreviewUrl | string | 朋友圈预览图链接，不传则默认使用当前游戏画面截图 | 2.14.3 |
| imagePreviewUrlId | string | 审核通过的朋友圈预览图图片编号，详见 使用审核通过的转发图片 | 2.14.3 |
| query | string | 查询字符串，必须是 key1=val1&key2=val2 的格式。从这条转发消息进入后，可通过 wx.getLaunchOptionsSync() 或 wx.onShow() 获取启动参数中的 query。不传则默认使用当前页面query。 |  |
| path | string | 独立分包路径。详见 小游戏独立分包指南 | 2.12.2 |


### wx.onShow(function listener)

微信 Windows 版：支持

|  | 属性 | 类型 | 说明 |
| --- | --- | --- | --- |
|  | scene | number | 场景值 |
|  | query | Record.<string, string> | 查询参数 |
|  | shareTicket | string | shareTicket |
|  | referrerInfo | object | 当场景为由从另一个小程序或公众号或App打开时，返回此字段 |
|  | 结构属性 类型 说明 appId string 来源小程序或公众号或App的 appId extraData object 来源小程序传过来的数据，scene=1037或1038时支持 |  | 结构属性 | 类型 | 说明 |  | appId | string | 来源小程序或公众号或App的 appId |  | extraData | object | 来源小程序传过来的数据，scene=1037或1038时支持 |
|  | 结构属性 | 类型 | 说明 |
|  | appId | string | 来源小程序或公众号或App的 appId |
|  | extraData | object | 来源小程序传过来的数据，scene=1037或1038时支持 |
|  | chatType | number | 从微信群聊/单聊打开小程序时，chatType 表示具体微信群聊/单聊类型 |
|  | 合法值 说明 1 微信联系人单聊 2 企业微信联系人单聊 3 普通微信群聊 4 企业微信互通群聊 | 合法值 | 说明 | 1 | 微信联系人单聊 | 2 | 企业微信联系人单聊 | 3 | 普通微信群聊 | 4 | 企业微信互通群聊 |
| 合法值 | 说明 |
| 1 | 微信联系人单聊 |
| 2 | 企业微信联系人单聊 |
| 3 | 普通微信群聊 |
| 4 | 企业微信互通群聊 |


### wx.onSocketClose(function listener)

推荐使用 SocketTask 的方式去管理 webSocket 链接，每一条链路的生命周期都更加可控，同时存在多个 webSocket 的链接的情况下使用 wx 前缀的方法可能会带来一些和预期不一致的情况。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| code | number | 一个数字值表示关闭连接的状态号，表示连接被关闭的原因。 |
| reason | string | 一个可读的字符串，表示连接被关闭的原因。 |


### wx.onSocketError(function listener)

推荐使用 SocketTask 的方式去管理 webSocket 链接，每一条链路的生命周期都更加可控，同时存在多个 webSocket 的链接的情况下使用 wx 前缀的方法可能会带来一些和预期不一致的情况。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| errMsg | string | 错误信息 |


### wx.onSocketMessage(function listener)

推荐使用 SocketTask 的方式去管理 webSocket 链接，每一条链路的生命周期都更加可控，同时存在多个 webSocket 的链接的情况下使用 wx 前缀的方法可能会带来一些和预期不一致的情况。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| data | string/ArrayBuffer | 服务器返回的消息 |


### wx.onSocketOpen(function listener)

推荐使用 SocketTask 的方式去管理 webSocket 链接，每一条链路的生命周期都更加可控，同时存在多个 webSocket 的链接的情况下使用 wx 前缀的方法可能会带来一些和预期不一致的情况。

| 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- |
| header | object | 连接成功的 HTTP 响应 Header | 2.0.0 |


### wx.onTouchCancel(function listener)

微信 鸿蒙 OS 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| touches | Array.<Touch> | 当前所有触摸点的列表 |
| changedTouches | Array.<Touch> | 触发此次事件的触摸点列表 |
| timeStamp | number | 事件触发时的时间戳 |


### wx.onTouchEnd(function listener)

微信 鸿蒙 OS 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| touches | Array.<Touch> | 当前所有触摸点的列表 |
| changedTouches | Array.<Touch> | 触发此次事件的触摸点列表 |
| timeStamp | number | 事件触发时的时间戳 |


### wx.onTouchMove(function listener)

微信 鸿蒙 OS 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| touches | Array.<Touch> | 当前所有触摸点的列表 |
| changedTouches | Array.<Touch> | 触发此次事件的触摸点列表 |
| timeStamp | number | 事件触发时的时间戳 |


### wx.onTouchStart(function listener)

微信 鸿蒙 OS 版：支持

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| touches | Array.<Touch> | 当前所有触摸点的列表 |
| changedTouches | Array.<Touch> | 触发此次事件的触摸点列表 |
| timeStamp | number | 事件触发时的时间戳 |


### wx.onUnhandledRejection(function listener)

基础库 2.10.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| reason | string | 拒绝原因，一般是一个 Error 对象 |
| promise | string | 被拒绝的 promise 对象 |


### wx.onUserCaptureScreen(function listener)

基础库 2.8.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 | 最低版本 |
| --- | --- | --- | --- |
| query | string | 支持开发者自定义一键打开小程序时的 query | 3.3.0 |
| promise | promise | 如果该参数存在，则其它的参数将会以 resolve 结果为准，如果一秒内不 resolve，分享会使用上面传入的默认参数 | 3.3.0 |


### wx.onVoIPChatInterrupted(function listener)

基础库 2.7.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| errCode | Number | 错误码 |
| errMsg | String | 调用结果（错误原因） |


### wx.onVoIPChatMembersChanged(function listener)

基础库 2.7.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| openIdList | Array.<String> | 还在实时语音通话中的成员 openId 名单 |
| errCode | Number | 错误码 |
| errMsg | String | 调用结果 |


### wx.onVoIPChatSpeakersChanged(function listener)

基础库 2.7.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| openIdList | Array.<String> | 还在实时语音通话中的成员 openId 名单 |
| errCode | Number | 错误码 |
| errMsg | String | 调用结果（错误原因） |


### wx.onVoIPChatStateChanged(function listener)

基础库 2.16.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| code | Number | 事件码 |
| data | object | 附加信息 |
| errCode | Number | 错误码 |
| errMsg | String | 调用结果 |


### wx.onWheel(function listener)

# 功能描述

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| deltaX | number | 滚轮 x 轴方向滚动量 |
| deltaY | number | 滚轮 y 轴方向滚动量 |
| deltaZ | number | 滚轮 z 轴方向滚动量 |
| x | number | 事件触发时鼠标所在的位置横坐标 |
| y | number | 事件触发时鼠标所在的位置纵坐标 |
| timeStamp | number | 事件触发时的时间戳 |


### wx.onWindowResize(function listener)

# 功能描述

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| windowWidth | number | 变化后的窗口宽度，单位 px |
| windowHeight | number | 变化后的窗口高度，单位 px |


### wx.onWindowStateChange(function listener)

基础库 3.8.8 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| state | string | 改变的窗口状态，可能的值为： |


### wx.openAppAuthorizeSetting(Object object)

基础库 2.25.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.openBluetoothAdapter(Object object)

基础库 2.9.2 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- | --- |
|  | mode | string | central | 否 | 蓝牙模式，可作为主/从设备，仅 iOS 需要。 | 2.10.0 |
|  | 合法值 说明 central 主机模式 peripheral 从机（外围设备）模式 | 合法值 | 说明 | central | 主机模式 | peripheral | 从机（外围设备）模式 |
| 合法值 | 说明 |
| central | 主机模式 |
| peripheral | 从机（外围设备）模式 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |  |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |  |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.openCard(Object object)

基础库 2.5.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | cardList | Array.<Object> |  | 是 | 需要打开的卡券列表 |
|  | 结构属性 类型 默认值 必填 说明 cardId string 是 卡券 ID code string 是 由 wx.addCard 的返回对象中的加密 code 通过解密后得到，解密请参照：code 解码接口 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | cardId | string |  | 是 | 卡券 ID |  | code | string |  | 是 | 由 wx.addCard 的返回对象中的加密 code 通过解密后得到，解密请参照：code 解码接口 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | cardId | string |  | 是 | 卡券 ID |
|  | code | string |  | 是 | 由 wx.addCard 的返回对象中的加密 code 通过解密后得到，解密请参照：code 解码接口 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.openChannelsActivity(Object object)

基础库 2.19.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| finderUserName | string |  | 是 | 视频号 id，以“sph”开头的id，可在视频号助手获取 |
| feedId | string |  | 是 | 视频 feedId |
| nonceId | string |  | 是 | 视频号的Feed的nonceId，必填 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.openChannelsEvent(Object object)

基础库 2.21.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| finderUserName | string |  | 是 | 视频号 id，以“sph”开头的id，可在视频号助手获取 |
| eventId | string |  | 是 | 活动 id |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.openChannelsLive(Object object)

基础库 2.15.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| finderUserName | string |  | 是 | 视频号 id，以“sph”开头的id，可在视频号助手获取 |
| feedId | string |  | 否 | 直播 feedId，通过 getChannelsLiveInfo 接口获取（基础库 v2.19.2 之前的版本需要填写） |
| nonceId | string |  | 否 | 直播 nonceId，通过 getChannelsLiveInfo 接口获取（基础库 v2.19.2 之前的版本需要填写） |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.openChannelsUserProfile(Object object)

基础库 2.21.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| finderUserName | string |  | 是 | 视频号id（参考格式为：sphcqO59YEPCvoe；查看路径为：微信客户端->我tab->视频号->右上角.-＞视频号名字-视频号ID） |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.openChatTool(Object object)

基础库 3.7.12 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | roomid | string |  | 否 | 聊天室 id，不传则拉起群选择框，可以传入多聊群的 opengid 值，或者单聊群的 open_single_roomid 值 |
|  | chatType | number |  | 否 | 群聊类型 |
|  | 合法值 说明 1 微信联系人单聊 2 企业微信联系人单聊 3 普通微信群聊 4 企业微信互通群聊 | 合法值 | 说明 | 1 | 微信联系人单聊 | 2 | 企业微信联系人单聊 | 3 | 普通微信群聊 | 4 | 企业微信互通群聊 |
| 合法值 | 说明 |
| 1 | 微信联系人单聊 |
| 2 | 企业微信联系人单聊 |
| 3 | 普通微信群聊 |
| 4 | 企业微信互通群聊 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.openCustomerServiceChat(Object object)

基础库 2.30.4 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | extInfo | Object |  | 是 | 客服信息 |
|  | 结构属性 类型 默认值 必填 说明 url String 是 客服链接 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | url | String |  | 是 | 客服链接 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | url | String |  | 是 | 客服链接 |
|  | corpId | String |  | 是 | 企业ID |
|  | showMessageCard | Boolean | false | 否 | 是否发送小程序气泡消息 |
|  | sendMessageTitle | String |  | 否 | 气泡消息标题 |
|  | sendMessagePath | String |  | 否 | 气泡消息小程序路径 |
|  | sendMessageImg | String |  | 否 | 气泡消息图片 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.openCustomerServiceConversation(Object object)

基础库 2.0.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| sessionFrom | string | '' | 否 | 会话来源。该字段会在进入客服会话时透传给开发者配置好的后台服务。该字段（utf-8编码）最长不得超过 1000 个字节（不是字符串长度），超过将被截断。 |
| showMessageCard | boolean | false | 否 | 是否显示会话内消息卡片，设置此参数为 true，用户进入客服会话会在右下角显示"可能要发送的小程序"提示，用户点击后可以快速发送小程序消息 |
| sendMessageTitle | string | '' | 否 | 会话内消息卡片标题 |
| sendMessagePath | string | '' | 否 | 会话内消息卡片路径 |
| sendMessageImg | string | '' | 否 | 会话内消息卡片图片路径 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.openPrivacyContract(Object object)

基础库 2.32.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.openSetting(Object object)

基础库 1.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| withSubscriptions | Boolean | false | 否 | 是否同时获取用户订阅消息的订阅状态，默认不获取。注意：withSubscriptions 只返回用户勾选过订阅面板中的“总是保持以上选择，不再询问”的订阅消息。 | 2.10.3 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.openSystemBluetoothSetting(Object object)

基础库 2.25.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.operateGameRecorderVideo(Object object)

基础库 2.26.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| title | string |  | 否 | 分享的对局回放打开后的标题内容 |
| desc | string |  | 否 | 分享的对局回放打开后的描述内容 |
| query | string |  | 否 | 分享的对局回放打开后跳转小游戏的 query |
| path | string |  | 否 | 分享的对局回放打开后跳转小游戏的 path （独立分包路径） |
| bgm | string |  | 否 | 对局回放背景音乐的地址 |
| timeRange | Array.<Array.<number>> |  | 否 | 对局回放的剪辑区间，是一个二维数组，单位 ms（毫秒）。[[1000, 3000], [4000, 5000]] 表示剪辑已录制对局回放的 1-3 秒和 4-5 秒最终合成为一个 3 秒的对局回放。对局回放剪辑后的总时长最多 60 秒，即 1 分钟 |
| volume | number | 1 | 否 | 对局回放的音量大小，最小0，最大1 |
| atempo | number | 1 | 否 | 对局回放的播放速率，只能设置以下几个值: 0.3, 0.5, 1, 1.5, 2, 2.5, 3.其中1表示元素播放，小于1表示减速播放，大于1表示加速播放 |
| audioMix | boolean | false | 否 | 如果原始视频文件中有音频，是否与新传入的bgm混音，默认为false，表示不混音，只保留一个音轨，值为true时表示原始音频与传入的bgm混音 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### PreDownloadSubpackageTask wx.preDownloadSubpackage(Object object)

基础库 2.27.3 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | packageType | string | 'normal' | 否 | 分包的类型 |
|  | 合法值 说明 workers worker 分包 normal 普通分包, 3.4.9及以上版本支持。下载普通分包，必须再传入 name 参数。 | 合法值 | 说明 | workers | worker 分包 | normal | 普通分包, 3.4.9及以上版本支持。下载普通分包，必须再传入 name 参数。 |
| 合法值 | 说明 |
| workers | worker 分包 |
| normal | 普通分包, 3.4.9及以上版本支持。下载普通分包，必须再传入 name 参数。 |
|  | name | string |  | 是 | 分包的名字，可以填分包配置中的 name 或者 root 字段的值。仅在 packageType="normal" 时生效。在独立分包内，填 __GAME__ 表示加载主包，详见 小游戏独立分包指南, 3.4.9及以上版本支持 |
|  | success | function |  | 是 | 分包加载成功回调事件 |
|  | fail | function |  | 是 | 分包加载失败回调事件 |
|  | complete | function |  | 是 | 分包加载结束回调事件(加载成功、失败都会执行） |


### wx.previewImage(Object object)

以 Promise 风格 调用：支持

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| urls | Array.<string> |  | 是 | 需要预览的图片链接列表。2.2.3 起支持云文件ID。 |  |
| showmenu | boolean | true | 否 | 是否显示长按菜单。 | 2.13.0 |
| current | string | urls 的第一张 | 否 | 当前显示图片的链接 |  |
| referrerPolicy | string | no-referrer | 否 | origin: 发送完整的referrer; no-referrer: 不发送。格式固定为 https://servicewechat.com/{appid}/{version}/page-frame.html，其中 {appid} 为小程序的 appid，{version} 为小程序的版本号，版本号为 0 表示为开发版、体验版以及审核版本，版本号为 devtools 表示为开发者工具，其余为正式版本； | 2.13.0 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.previewMedia(Object object)

基础库 2.12.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- | --- |
|  | sources | Array.<Object> |  | 是 | 需要预览的资源列表 |  |
|  | 结构属性 类型 默认值 必填 说明 url String 是 图片或视频的地址 type String image 否 资源的类型，默认为图片 合法值 说明 image 图片 video 视频 poster string 否 视频的封面图片 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | url | String |  | 是 | 图片或视频的地址 |  | type | String | image | 否 | 资源的类型，默认为图片 |  | 合法值 说明 image 图片 video 视频 | 合法值 | 说明 | image | 图片 | video | 视频 |  | poster | string |  | 否 | 视频的封面图片 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | url | String |  | 是 | 图片或视频的地址 |
|  | type | String | image | 否 | 资源的类型，默认为图片 |
|  | 合法值 说明 image 图片 video 视频 | 合法值 | 说明 | image | 图片 | video | 视频 |
| 合法值 | 说明 |
| image | 图片 |
| video | 视频 |
|  | poster | string |  | 否 | 视频的封面图片 |
|  | current | number | 0 | 否 | 当前显示的资源序号 |  |
|  | showmenu | boolean | true | 否 | 是否显示长按菜单。 | 2.13.0 |
|  | referrerPolicy | string | no-referrer | 否 | `origin`: 发送完整的referrer; `no-referrer`: 不发送。格式固定为 `https://servicewechat.com/{appid}/{version}/page-frame.html`，其中 {appid} 为小程序的 appid，{version} 为小程序的版本号，版本号为 0 表示为开发版、体验版以及审核版本，版本号为 devtools 表示为开发者工具，其余为正式版本； | 2.13.0 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |  |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |  |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.readBLECharacteristicValue(Object object)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| deviceId | string |  | 是 | 蓝牙设备 id |
| serviceId | string |  | 是 | 蓝牙特征对应服务的 UUID |
| characteristicId | string |  | 是 | 蓝牙特征的 UUID |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.removeStorage(Object object)

以 Promise 风格 调用：支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| key | string |  | 是 | 本地缓存中指定的 key |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.removeUserCloudStorage(Object object)

基础库 1.9.92 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| keyList | Array.<string> |  | 是 | 要删除掉 key 列表 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.reportScene(Object object)

基础库 2.26.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| sceneId | Number |  | 是 | 场景ID，在「小程序管理后台」获取 |
| costTime | Number | 0 | 否 | 此场景的耗时，单位 ms |
| dimension | Object |  | 否 | 自定义维度数据，key在「小程序管理后台」获取。只支持能够通过JSON.stringify序列化的对象，且序列化后长度不超过1024个字符 |
| metric | Object |  | 否 | 自定义指标数据，key在「小程序管理后台」获取。只支持能够通过JSON.stringify序列化的对象，且序列化后长度不超过1024个字符 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.reportUserBehaviorBranchAnalytics(Object object)

基础库 2.12.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| branchId | string |  | 是 | 分支ID，在「小程序管理后台」获取 |
| branchDim | string |  | 否 | 自定义维度，基础库 v2.14.0 开始支持可选 |
| eventType | number |  | 是 | 事件类型，1：曝光； 2：点击 |


### RequestTask wx.request(Object object)

以 Promise 风格 调用：不支持

|  | 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- | --- |
|  | url | string |  | 是 | 开发者服务器接口地址 |  |
|  | data | string/object/ArrayBuffer |  | 否 | 请求的参数 |  |
|  | header | Object |  | 否 | 设置请求的 header，header 中不能设置 Referer。content-type 默认为 application/json |  |
|  | timeout | number |  | 否 | 超时时间，单位为毫秒。默认值为 60000 | 2.10.0 |
|  | method | string | GET | 否 | HTTP 请求方法 |  |
|  | 合法值 说明 OPTIONS HTTP 请求 OPTIONS GET HTTP 请求 GET HEAD HTTP 请求 HEAD POST HTTP 请求 POST PUT HTTP 请求 PUT DELETE HTTP 请求 DELETE TRACE HTTP 请求 TRACE CONNECT HTTP 请求 CONNECT | 合法值 | 说明 | OPTIONS | HTTP 请求 OPTIONS | GET | HTTP 请求 GET | HEAD | HTTP 请求 HEAD | POST | HTTP 请求 POST | PUT | HTTP 请求 PUT | DELETE | HTTP 请求 DELETE | TRACE | HTTP 请求 TRACE | CONNECT | HTTP 请求 CONNECT |
| 合法值 | 说明 |
| OPTIONS | HTTP 请求 OPTIONS |
| GET | HTTP 请求 GET |
| HEAD | HTTP 请求 HEAD |
| POST | HTTP 请求 POST |
| PUT | HTTP 请求 PUT |
| DELETE | HTTP 请求 DELETE |
| TRACE | HTTP 请求 TRACE |
| CONNECT | HTTP 请求 CONNECT |
|  | dataType | string | json | 否 | 返回的数据格式。值为 json 时，返回的数据为 JSON，返回后会对返回的数据进行一次 JSON.parse；其他值则不对返回的内容进行 JSON.parse |  |
|  | responseType | string | text | 否 | 响应的数据类型 | 1.7.0 |
|  | 合法值 说明 text 响应的数据为文本 arraybuffer 响应的数据为 ArrayBuffer | 合法值 | 说明 | text | 响应的数据为文本 | arraybuffer | 响应的数据为 ArrayBuffer |
| 合法值 | 说明 |
| text | 响应的数据为文本 |
| arraybuffer | 响应的数据为 ArrayBuffer |
|  | useHighPerformanceMode | boolean | true | 否 | 使用高性能模式。从基础库 v3.5.0 开始在 Android 端默认开启，其他端暂不生效。该模式下有更优的网络性能表现，更多信息请查看下方说明。 | 3.3.3 |
|  | enableHttp2 | boolean | false | 否 | 开启 http2 | 2.10.4 |
|  | enableProfile | boolean | true | 否 | 是否开启 profile。iOS 和 Android 端默认开启，其他端暂不支持。开启后可在接口回调的 res.profile 中查看性能调试信息。 |  |
|  | enableQuic | boolean | false | 否 | 是否开启 Quic/h3 协议（iOS 微信目前使用 gQUIC-Q43；Android 微信在 v8.0.54 前使用 gQUIC-Q43，v8.0.54 开始使用 IETF QUIC，即 h3 协议；PC微信使用 IETF QUIC，即 h3 协议） | 2.10.4 |
|  | enableCache | boolean | false | 否 | 开启 Http 缓存 | 2.10.4 |
|  | enableHttpDNS | boolean | false | 否 | 是否开启 HttpDNS 服务。如开启，需要同时填入 httpDNSServiceId 。 HttpDNS 用法详见 移动解析HttpDNS | 2.19.1 |
|  | httpDNSServiceId | string |  | 否 | HttpDNS 服务商 Id。 HttpDNS 用法详见 移动解析HttpDNS | 2.19.1 |
|  | httpDNSTimeout | number | 60000 | 否 | HttpDNS 超时时间。HttpDNS解析时间超过该值时不再走HttpDNS，本次请求将回退到localDNS。默认为 60000 毫秒。 HttpDNS 用法详见 移动解析HttpDNS | 3.8.9 |
|  | enableChunked | boolean | false | 否 | 开启 transfer-encoding chunked。 | 2.20.2 |
|  | forceCellularNetwork | boolean | false | 否 | 强制使用蜂窝网络发送请求 | 2.21.0 |
|  | redirect | string | follow | 否 | 重定向拦截策略。（目前安卓、iOS、开发者工具已支持，PC端将在后续支持） | 3.2.2 |
|  | 合法值 说明 follow 不拦截重定向，即客户端自动处理重定向 manual 拦截重定向。开启后，当 http 状态码为 3xx 时客户端不再自动重定向，而是触发 onHeadersReceived 回调，并结束本次 request 请求。可通过 onHeadersReceived 回调中的 header.Location 获取重定向的 url | 合法值 | 说明 | follow | 不拦截重定向，即客户端自动处理重定向 | manual | 拦截重定向。开启后，当 http 状态码为 3xx 时客户端不再自动重定向，而是触发 onHeadersReceived 回调，并结束本次 request 请求。可通过 onHeadersReceived 回调中的 header.Location 获取重定向的 url |
| 合法值 | 说明 |
| follow | 不拦截重定向，即客户端自动处理重定向 |
| manual | 拦截重定向。开启后，当 http 状态码为 3xx 时客户端不再自动重定向，而是触发 onHeadersReceived 回调，并结束本次 request 请求。可通过 onHeadersReceived 回调中的 header.Location 获取重定向的 url |
|  | success | function |  | 否 | 接口调用成功的回调函数 |  |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |  |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.requestFacialRecognition(Object object)

基础库 3.11.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.requestMidasFriendPayment(Object object)

接口已废弃

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | mode | string |  | 是 | 支付的类型，不同的支付类型有各自额外要传的附加参数 |
|  | 合法值 说明 game 购买游戏币 | 合法值 | 说明 | game | 购买游戏币 |
| 合法值 | 说明 |
| game | 购买游戏币 |
|  | env | number |  | 是 | 环境配置 |
|  | 合法值 说明 0 米大师正式环境 1 米大师沙箱环境 | 合法值 | 说明 | 0 | 米大师正式环境 | 1 | 米大师沙箱环境 |
| 合法值 | 说明 |
| 0 | 米大师正式环境 |
| 1 | 米大师沙箱环境 |
|  | offerId | string |  | 是 | 在米大师侧申请的应用 id |
|  | currencyType | string |  | 是 | 币种 |
|  | 合法值 说明 CNY 人民币 | 合法值 | 说明 | CNY | 人民币 |
| 合法值 | 说明 |
| CNY | 人民币 |
|  | platform | string |  | 是 | 申请接入时的平台，platform 与应用id有关。 |
|  | 合法值 说明 android Android平台 | 合法值 | 说明 | android | Android平台 |
| 合法值 | 说明 |
| android | Android平台 |
|  | buyQuantity | number |  | 是 | 购买数量。mode=game 时必填。购买数量。详见 buyQuantity 限制说明。 |
|  | zoneId | string |  | 是 | 分区 ID |
|  | outTradeNo | string |  | 是 | 开发者业务订单号，每个订单号只能使用一次，重复使用会失败。要求32个字符内，只能是数字、大小写字母、符号 _-|*@ |
|  | nonceStr | string |  | 是 | 随机字符串，长度应小于 128 |
|  | timeStamp | number |  | 是 | 生成这个随机字符串的 UNIX 时间戳（精确到秒） |
|  | signature | string |  | 是 | 签名 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.requestMidasPayment(Object object)

基础库 2.19.2 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | mode | string |  | 是 | 支付的类型，不同的支付类型有各自额外要传的附加参数。 |
|  | 合法值 说明 game 购买游戏币 | 合法值 | 说明 | game | 购买游戏币 |
| 合法值 | 说明 |
| game | 购买游戏币 |
|  | env | number | 0 | 否 | 环境配置 |
|  | 合法值 说明 0 米大师正式环境 1 米大师沙箱环境 | 合法值 | 说明 | 0 | 米大师正式环境 | 1 | 米大师沙箱环境 |
| 合法值 | 说明 |
| 0 | 米大师正式环境 |
| 1 | 米大师沙箱环境 |
|  | offerId | string |  | 是 | 在米大师侧申请的应用 id |
|  | currencyType | string |  | 是 | 币种 |
|  | 合法值 说明 CNY 人民币 | 合法值 | 说明 | CNY | 人民币 |
| 合法值 | 说明 |
| CNY | 人民币 |
|  | platform | string |  | 否 | 申请接入时的平台，platform 与应用id有关。 |
|  | 合法值 说明 android android | 合法值 | 说明 | android | android |
| 合法值 | 说明 |
| android | android |
|  | buyQuantity | number |  | 否 | 购买数量。mode=game 时必填。购买数量。详见 buyQuantity 限制说明。 |
|  | zoneId | string | 1 | 否 | 分区 ID |
|  | outTradeNo | string |  | 是 | 业务订单号，每个订单号只能使用一次，重复使用会失败。开发者需要确保该订单号在对应游戏下的唯一性，平台会尽可能校验该唯一性约束，但极端情况下可能会跳过对该约束的校验。要求32个字符内，只能是数字、大小写字母、符号_-|*组成，不能以下划线（)开头。建议每次调用wx.requestMidasPayment都换新的outTradeNo。若没有传入，则平台会自动填充一个，并以下划线开头 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.requestMidasPaymentGameItem(Object object)

基础库 2.19.2 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | signData | Object |  | 是 | 支付原串具体支付参数见下面的signData，需要将数据以json格式传递signData例子:'{"mode":"goods","offerId":"123","buyQuantity":1,"env":0,"currencyType":"CNY","platform":"android","zoneId":"1","productId":"testproductId","goodsPrice":10,"outTradeNo":"xxxxxx","attach":"testdata"}' |
|  | 结构属性 类型 默认值 必填 说明 mode string 是 支付的类型不同的支付类型有各自额外要传的附加参数 offerId string 是 在米大师侧申请的应用idmp-支付基础配置中的offerid buyQuantity number 是 购买数量 env number 0 否 环境配置 合法值 说明 0 米大师正式环境 1 米大师沙箱环境 currencyType string 是 币种 合法值 说明 CNY 人民币 platform string android 否 平台 合法值 说明 android 安卓 zoneId string 1 否 分区ID productId string 是 道具ID goodsPrice number 是 道具单价（分）用来校验价格与后台道具价格是否一致，避免用户在业务商城页看到的价格与实际价格不一致导致投诉 outTradeNo string 是 业务订单号每个订单号只能使用一次，重复使用会失败（极端情况不保证唯一，不建议业务强依赖唯一性）。要求32个字符内，只能是数字、大小写字母、符号 _-|*@组成，不能以下划线(_)开头。若没有传入，则平台会自动填充一个，并以下划线开头。 attach string 否 透传数据发货通知时会透传给开发者 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | mode | string |  | 是 | 支付的类型不同的支付类型有各自额外要传的附加参数 |  | offerId | string |  | 是 | 在米大师侧申请的应用idmp-支付基础配置中的offerid |  | buyQuantity | number |  | 是 | 购买数量 |  | env | number | 0 | 否 | 环境配置 |  | 合法值 说明 0 米大师正式环境 1 米大师沙箱环境 | 合法值 | 说明 | 0 | 米大师正式环境 | 1 | 米大师沙箱环境 |  | currencyType | string |  | 是 | 币种 |  | 合法值 说明 CNY 人民币 | 合法值 | 说明 | CNY | 人民币 |  | platform | string | android | 否 | 平台 |  | 合法值 说明 android 安卓 | 合法值 | 说明 | android | 安卓 |  | zoneId | string | 1 | 否 | 分区ID |  | productId | string |  | 是 | 道具ID |  | goodsPrice | number |  | 是 | 道具单价（分）用来校验价格与后台道具价格是否一致，避免用户在业务商城页看到的价格与实际价格不一致导致投诉 |  | outTradeNo | string |  | 是 | 业务订单号每个订单号只能使用一次，重复使用会失败（极端情况不保证唯一，不建议业务强依赖唯一性）。要求32个字符内，只能是数字、大小写字母、符号 _-|*@组成，不能以下划线(_)开头。若没有传入，则平台会自动填充一个，并以下划线开头。 |  | attach | string |  | 否 | 透传数据发货通知时会透传给开发者 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | mode | string |  | 是 | 支付的类型不同的支付类型有各自额外要传的附加参数 |
|  | offerId | string |  | 是 | 在米大师侧申请的应用idmp-支付基础配置中的offerid |
|  | buyQuantity | number |  | 是 | 购买数量 |
|  | env | number | 0 | 否 | 环境配置 |
|  | 合法值 说明 0 米大师正式环境 1 米大师沙箱环境 | 合法值 | 说明 | 0 | 米大师正式环境 | 1 | 米大师沙箱环境 |
| 合法值 | 说明 |
| 0 | 米大师正式环境 |
| 1 | 米大师沙箱环境 |
|  | currencyType | string |  | 是 | 币种 |
|  | 合法值 说明 CNY 人民币 | 合法值 | 说明 | CNY | 人民币 |
| 合法值 | 说明 |
| CNY | 人民币 |
|  | platform | string | android | 否 | 平台 |
|  | 合法值 说明 android 安卓 | 合法值 | 说明 | android | 安卓 |
| 合法值 | 说明 |
| android | 安卓 |
|  | zoneId | string | 1 | 否 | 分区ID |
|  | productId | string |  | 是 | 道具ID |
|  | goodsPrice | number |  | 是 | 道具单价（分）用来校验价格与后台道具价格是否一致，避免用户在业务商城页看到的价格与实际价格不一致导致投诉 |
|  | outTradeNo | string |  | 是 | 业务订单号每个订单号只能使用一次，重复使用会失败（极端情况不保证唯一，不建议业务强依赖唯一性）。要求32个字符内，只能是数字、大小写字母、符号 _-|*@组成，不能以下划线(_)开头。若没有传入，则平台会自动填充一个，并以下划线开头。 |
|  | attach | string |  | 否 | 透传数据发货通知时会透传给开发者 |
|  | paySig | string |  | 是 | 支付签名pay_sig参数的签名算法，使用“mp-支付基础配置”中的AppKey对支付的请求进行签名，代表请求经过开发者服务端的支付模块发起。签名算法伪代码为：paySig = to_hex(hmac_sha256(appKey,'requestMidasPaymentGameItem' + '&' + signData))具体可见代码示例中的支付签名代码实现 |
|  | signature | string |  | 是 | 用户态签名signature参数签名算法参考用户态签名可参考calc_signature |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.requestSubscribeMessage(Object object)

基础库 2.4.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| tmplIds | Array |  | 是 | 需要订阅的消息模板的id的集合，一次调用最多可订阅3条消息（注意：iOS客户端7.0.6版本、Android客户端7.0.7版本之后的一次性订阅/长期订阅才支持多个模板消息，iOS客户端7.0.5版本、Android客户端7.0.6版本之前的一次订阅只支持一个模板消息）消息模板id在[微信公众平台(mp.weixin.qq.com)-功能-订阅消息]中配置。每个tmplId对应的模板标题需要不相同，否则会被过滤。 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.requestSubscribeSystemMessage(Object object)

基础库 2.9.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| msgTypeList | Array.<string> |  | 是 | 系统订阅消息类型列表，一次调用最多可订阅3种类型的消息，目前支持："SYS_MSG_TYPE_INTERACTIVE"（好友互动提醒）、"SYS_MSG_TYPE_RANK"（排行榜超越提醒）、"SYS_MSG_TYPE_WHATS_NEW"（游戏更新提醒） |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.requirePrivacyAuthorize(Object object)

基础库 2.32.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.reserveChannelsLive(Object object)

基础库 2.19.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| noticeId | string |  | 是 | 预告 id，通过 getChannelsLiveNoticeInfo 接口获取 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.restartMiniProgram(Object object)

基础库 2.22.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| path | string |  | 否 | 打开的页面路径，path 中 ? 后面的部分会成为 query |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.saveFileToDisk(Object object)

基础库 2.11.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| filePath | string |  | 是 | 待保存文件路径 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.saveImageToPhotosAlbum(Object object)

基础库 1.2.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| filePath | string |  | 是 | 图片文件路径，可以是临时文件路径或永久文件路径 (本地路径) ，不支持网络路径 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.scanCode(Object object)

基础库 2.16.1 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- | --- |
|  | onlyFromCamera | boolean | false | 否 | 是否只能从相机扫码，不允许从相册选择图片 | 1.2.0 |
|  | scanType | Array.<string> | ['barCode', 'qrCode', 'wxCode'] | 否 | 扫码类型 | 1.7.0 |
|  | 合法值 说明 barCode 一维码 qrCode 二维码 wxCode 小程序码 datamatrix Data Matrix 码 pdf417 PDF417 条码 | 合法值 | 说明 | barCode | 一维码 | qrCode | 二维码 | wxCode | 小程序码 | datamatrix | Data Matrix 码 | pdf417 | PDF417 条码 |
| 合法值 | 说明 |
| barCode | 一维码 |
| qrCode | 二维码 |
| wxCode | 小程序码 |
| datamatrix | Data Matrix 码 |
| pdf417 | PDF417 条码 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |  |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |  |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.selectGroupMembers(Object object)

基础库 3.7.12 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| maxSelectCount | number |  | 否 | 最多可选人数 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.sendGiftToFriend(Object object)

基础库 3.11.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| giftId | string |  | 是 | 礼包 id |
| openid | string |  | 是 | 好友的 openid |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.sendSocketMessage(Object object)

推荐使用 SocketTask 的方式去管理 webSocket 链接，每一条链路的生命周期都更加可控，同时存在多个 webSocket 的链接的情况下使用 wx 前缀的方法可能会带来一些和预期不一致的情况。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| data | string/ArrayBuffer |  | 是 | 需要发送的内容 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.setBackgroundFetchToken(object object)

基础库 3.0.1 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| token | String |  | 是 | 自定义的登录态。上限 1024 字符。 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.setBLEMTU(Object object)

基础库 2.11.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| deviceId | string |  | 是 | 蓝牙设备 id |
| mtu | number |  | 是 | 最大传输单元。设置范围为 (22,512) 区间内，单位 bytes |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.setClipboardData(Object object)

基础库 1.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| data | string |  | 是 | 剪贴板的内容 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.setDeviceOrientation(Object object)

基础库 2.26.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | value | string |  | 是 | 表示切换为横屏还是竖屏 |
|  | 合法值 说明 landscape 横屏 portrait 竖屏 | 合法值 | 说明 | landscape | 横屏 | portrait | 竖屏 |
| 合法值 | 说明 |
| landscape | 横屏 |
| portrait | 竖屏 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.setEnableDebug(Object object)

基础库 1.4.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| enableDebug | boolean |  | 是 | 是否打开调试 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.setInnerAudioOption(Object object)

基础库 2.3.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| mixWithOther | boolean | true | 否 | 是否与其他音频混播，设置为 true 之后，不会终止其他应用或微信内的音乐 |
| obeyMuteSwitch | boolean | true | 否 | （仅在 iOS 生效）是否遵循静音开关，设置为 false 之后，即使是在静音模式下，也能播放声音 |
| speakerOn | boolean | true | 否 | true 代表用扬声器播放，false 代表听筒播放，默认值为 true。 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.setKeepScreenOn(Object object)

基础库 1.4.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| keepScreenOn | boolean |  | 是 | 是否保持屏幕常亮 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.setMenuStyle(Object object)

以 Promise 风格 调用：支持

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | style | string |  | 是 | 样式风格 |
|  | 合法值 说明 light 浅色 dark 深色 | 合法值 | 说明 | light | 浅色 | dark | 深色 |
| 合法值 | 说明 |
| light | 浅色 |
| dark | 深色 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### boolean wx.setMessageToFriendQuery(Object object)

微信 Windows 版：支持

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| shareMessageToFriendScene | number |  | 是 | 需要传递的代表场景的数字，需要在 0 - 50 之间 |
| query | string |  | 是 | 需要传递的字符串数据，长度需要在 128 之内 |


### wx.setScreenBrightness(Object object)

基础库 1.2.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| value | number |  | 是 | 屏幕亮度值，范围 0 ~ 1，0 最暗，1 最亮。在安卓端支持传入特殊值 -1，表示屏幕亮度跟随系统变化 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.setStatusBarStyle(Object object)

以 Promise 风格 调用：支持

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | style | string |  | 是 | 样式风格 |
|  | 合法值 说明 white 白色 black 浅色 | 合法值 | 说明 | white | 白色 | black | 浅色 |
| 合法值 | 说明 |
| white | 白色 |
| black | 浅色 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.setStorage(Object object)

以 Promise 风格 调用：支持

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| key | string |  | 是 | 本地缓存中指定的 key |  |
| data | any |  | 是 | 需要存储的内容。只支持原生类型、Date、及能够通过JSON.stringify序列化的对象。 |  |
| encrypt | Boolean | false | 否 | 是否开启加密存储。只有异步的 setStorage 接口支持开启加密存储。开启后，将会对 data 使用 AES128 加密，接口回调耗时将会增加。若开启加密存储，setStorage 和 getStorage 需要同时声明 encrypt 的值为 true。此外，由于加密后的数据会比原始数据膨胀1.4倍，因此开启 encrypt 的情况下，单个 key 允许存储的最大数据长度为 0.7MB，所有数据存储上限为 7.1MB | 2.21.3 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.setUserCloudStorage(Object object)

基础库 1.9.92 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| KVDataList | Array.<KVData> |  | 是 | 要修改的 KV 数据列表 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.setVisualEffectOnCapture(Object object)

基础库 3.1.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| visualEffect | string | none | 否 | 截屏/录屏时的表现，仅支持 none / hidden，传入 hidden 则表示在截屏/录屏时隐藏屏幕 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.setWindowSize(Object object)

从基础库 2.11.0 开始，本接口停止维护

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| width | number |  | 是 | 窗口宽度，以像素为单位 |
| height | number |  | 是 | 窗口高度，以像素为单位 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.shareAppMessage(Object object)

微信 Windows 版：支持

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| title | string |  | 否 | 转发标题，不传则默认使用当前小游戏的昵称。 |  |
| imageUrl | string |  | 否 | 转发显示图片的链接，可以是网络图片路径或本地图片文件路径或相对代码包根目录的图片文件路径。显示图片长宽比是 5:4 |  |
| query | string |  | 否 | 查询字符串，从这条转发消息进入后，可通过 wx.getLaunchOptionsSync() 或 wx.onShow() 获取启动参数中的 query。必须是 key1=val1&key2=val2 的格式。 |  |
| imageUrlId | string |  | 否 | 审核通过的图片编号，详见 使用审核通过的转发图片 | 2.4.3 |
| toCurrentGroup | boolean | true | 否 | 是否转发到当前群。该参数只对从群工具栏打开的场景下生效，默认转发到当前群，填入false时可转发到其他会话。 | 2.12.2 |
| path | string |  | 否 | 独立分包路径。详见 小游戏独立分包指南 | 2.12.2 |


### wx.shareAppMessageToGroup(Object object)

基础库 3.7.12 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| title | string |  | 是 | 转发标题 |
| path | string | '' | 否 | 如需传递参数，只传 query 即可，query 形如 ?a=1&b=2 |
| imageUrl | string | '' | 否 | 自定义图片路径，支持PNG及JPG，显示图片长宽比是 5:4，默认使用截图 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.shareEmojiToGroup(Object object)

基础库 3.7.12 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| imagePath | string |  | 是 | 要分享的表情地址，必须为本地路径或临时路径 |
| needShowEntrance | boolean | true | 否 | 分享的表情消息是否要带小程序入口 |
| entrancePath | string | '' | 否 | 如需传递参数，只传 query 即可，query 形如 ?a=1&b=2 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.shareImageToGroup(Object object)

基础库 3.7.12 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| imagePath | string |  | 是 | 要分享的图片地址，必须为本地路径或临时路径 |
| needShowEntrance | boolean | true | 否 | 分享的图片消息是否要带小程序入口 |
| entrancePath | string | '' | 否 | 如需传递参数，只传 query 即可，query 形如 ?a=1&b=2 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.shareMessageToFriend(Object object)

基础库 2.9.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| openId | string |  | 是 | 发送对象的 openId |
| title | string |  | 否 | 转发标题，不传则默认使用当前小游戏的昵称。 |
| imageUrl | string |  | 否 | 转发显示图片的链接，可使用本地图片文件路径或相对代码包根目录的图片文件路径，不可使用网络图片。如需使用网络图片，可先在游戏域调用 wx.downloadFile 下载到本地后，调用 OpenDataContext.postMessage 发送本地图片路径到开放数据域使用。显示图片长宽比是 5:4 |
| imageUrlId | string |  | 否 | 审核通过的图片编号，详见 使用审核通过的转发图片 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.shareTextToGroup(Object object)

基础库 3.7.12 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| content | string |  | 是 | 要分享的文本内容 |
| needShowEntrance | boolean | true | 否 | 分享的表情消息是否要带小程序入口 |
| entrancePath | string | '' | 否 | 如需传递参数，只传 query 即可，query 形如 ?a=1&b=2 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.shareVideoToGroup(Object object)

基础库 3.7.12 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| videoPath | string |  | 是 | 要分享的视频地址，必须为本地路径或临时路径 |
| thumbPath | string |  | 否 | 缩略图路径，若留空则使用视频首帧 |
| needShowEntrance | boolean | true | 否 | 分享的图片消息是否要带小程序入口 |
| entrancePath | string | '' | 否 | 如需传递参数，只传 query 即可，query 形如 ?a=1&b=2 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.showActionSheet(Object object)

以 Promise 风格 调用：支持

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| alertText | string |  | 否 | 警示文案 | 2.14.0 |
| itemList | Array.<string> |  | 是 | 按钮的文字数组，数组长度最大为 6 |  |
| itemColor | string | #000000 | 否 | 按钮的文字颜色 |  |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.showKeyboard(Object object)

以 Promise 风格 调用：支持

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | defaultValue | string |  | 是 | 键盘输入框显示的默认值 |
|  | maxLength | number |  | 是 | 键盘中文本的最大长度 |
|  | multiple | boolean |  | 是 | 是否为多行输入 |
|  | confirmHold | boolean |  | 是 | 当点击完成时键盘是否保持显示 |
|  | confirmType | string |  | 是 | 键盘右下角 confirm 按钮的类型，只影响按钮的文本内容 |
|  | 合法值 说明 done 完成 next 下一个 search 搜索 go 前往 send 发送 | 合法值 | 说明 | done | 完成 | next | 下一个 | search | 搜索 | go | 前往 | send | 发送 |
| 合法值 | 说明 |
| done | 完成 |
| next | 下一个 |
| search | 搜索 |
| go | 前往 |
| send | 发送 |
|  | keyboardType | string |  | 是 | 键盘类型，默认为文本类型，客户端8.0.57以上支持数字键盘 |
|  | 合法值 说明 text 文本 number 数字 | 合法值 | 说明 | text | 文本 | number | 数字 |
| 合法值 | 说明 |
| text | 文本 |
| number | 数字 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.showLoading(Object object)

基础库 1.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| title | string |  | 是 | 提示的内容 |
| mask | boolean | false | 否 | 是否显示透明蒙层，防止触摸穿透 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.showModal(Object object)

以 Promise 风格 调用：支持

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| title | string |  | 否 | 提示的标题 |  |
| content | string |  | 否 | 提示的内容 |  |
| showCancel | boolean | true | 否 | 是否显示取消按钮 |  |
| cancelText | string | 取消 | 否 | 取消按钮的文字，最多 4 个字符 |  |
| cancelColor | string | #000000 | 否 | 取消按钮的文字颜色，必须是 16 进制格式的颜色字符串 |  |
| confirmText | string | 确定 | 否 | 确认按钮的文字，最多 4 个字符 |  |
| confirmColor | string | #576B95 | 否 | 确认按钮的文字颜色，必须是 16 进制格式的颜色字符串 |  |
| editable | boolean | false | 否 | 是否显示输入框 | 2.17.1 |
| placeholderText | string |  | 否 | 显示输入框时的提示文本 | 2.17.1 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.showShareImageMenu(Object object)

基础库 2.14.3 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| path | string |  | 是 | 要分享的图片地址，必须为本地路径或临时路径 |  |
| needShowEntrance | boolean | false | 否 | 分享的图片消息是否要带小程序入口 (仅部分小程序类目可用) | 3.2.0 |
| entrancePath | string | '' | 否 | 从消息小程序入口打开小程序的路径，如果当前页面允许分享给朋友，则默认为当前页面路径，否则默认为小程序首页 | 3.2.0 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.showShareMenu(Object object)

基础库 1.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| withShareTicket | boolean | false | 否 | 是否使用带 shareTicket 的转发详情 |  |
| menus | Array.<string> |  | 否 | 本接口为 Beta 版本，暂只在 Android 平台支持。需要显示的转发按钮名称列表，默认['shareAppMessage']。按钮名称合法值包含 "shareAppMessage"、"shareTimeline" 两种 | 2.11.3 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.showToast(Object object)

以 Promise 风格 调用：支持

|  | 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- | --- |
|  | title | string |  | 是 | 提示的内容 |  |
|  | icon | string | success | 否 | 图标 |  |
|  | 合法值 说明 最低版本 success 显示成功图标，此时 title 文本最多显示 7 个汉字长度 error 显示失败图标，此时 title 文本最多显示 7 个汉字长度 2.14.1 loading 显示加载图标，此时 title 文本最多显示 7 个汉字长度 none 不显示图标，此时 title 文本最多可显示两行，1.9.0及以上版本支持 | 合法值 | 说明 | 最低版本 | success | 显示成功图标，此时 title 文本最多显示 7 个汉字长度 |  | error | 显示失败图标，此时 title 文本最多显示 7 个汉字长度 | 2.14.1 | loading | 显示加载图标，此时 title 文本最多显示 7 个汉字长度 |  | none | 不显示图标，此时 title 文本最多可显示两行，1.9.0及以上版本支持 |  |
| 合法值 | 说明 | 最低版本 |
| success | 显示成功图标，此时 title 文本最多显示 7 个汉字长度 |  |
| error | 显示失败图标，此时 title 文本最多显示 7 个汉字长度 | 2.14.1 |
| loading | 显示加载图标，此时 title 文本最多显示 7 个汉字长度 |  |
| none | 不显示图标，此时 title 文本最多可显示两行，1.9.0及以上版本支持 |  |
|  | image | string |  | 否 | 自定义图标的本地路径，image 的优先级高于 icon | 1.1.0 |
|  | duration | number | 1500 | 否 | 提示的延迟时间 |  |
|  | mask | boolean | false | 否 | 是否显示透明蒙层，防止触摸穿透 |  |
|  | success | function |  | 否 | 接口调用成功的回调函数 |  |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |  |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.startAccelerometer(Object object)

基础库 1.1.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- | --- |
|  | interval | string | normal | 否 | 监听加速度数据回调函数的执行频率 | 2.1.0 |
|  | 合法值 说明 game 适用于更新游戏的回调频率，在 20ms/次 左右 ui 适用于更新 UI 的回调频率，在 60ms/次 左右 normal 普通的回调频率，在 200ms/次 左右 | 合法值 | 说明 | game | 适用于更新游戏的回调频率，在 20ms/次 左右 | ui | 适用于更新 UI 的回调频率，在 60ms/次 左右 | normal | 普通的回调频率，在 200ms/次 左右 |
| 合法值 | 说明 |
| game | 适用于更新游戏的回调频率，在 20ms/次 左右 |
| ui | 适用于更新 UI 的回调频率，在 60ms/次 左右 |
| normal | 普通的回调频率，在 200ms/次 左右 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |  |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |  |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.startBeaconDiscovery(Object object)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| uuids | Array.<string> |  | 是 | Beacon 设备广播的 UUID 列表 |
| ignoreBluetoothAvailable | boolean | false | 否 | 是否校验蓝牙开关，仅在 iOS 下有效。iOS 11 起，控制面板里关掉蓝牙，还是能继续使用 Beacon 服务。 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.startBluetoothDevicesDiscovery(Object object)

基础库 2.9.2 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | services | Array.<string> |  | 否 | 要搜索的蓝牙设备主服务的 UUID 列表（支持 16/32/128 位 UUID）。某些蓝牙设备会广播自己的主 service 的 UUID。如果设置此参数，则只搜索广播包有对应 UUID 的主服务的蓝牙设备。建议通过该参数过滤掉周边不需要处理的其他蓝牙设备。 |
|  | allowDuplicatesKey | boolean | false | 否 | 是否允许重复上报同一设备。如果允许重复上报，则 wx.onBlueToothDeviceFound 方法会多次上报同一设备，但是 RSSI 值会有不同。 |
|  | interval | number | 0 | 否 | 上报设备的间隔，单位 ms。0 表示找到新设备立即上报，其他数值根据传入的间隔上报。 |
|  | powerLevel | string | medium | 否 | 扫描模式，越高扫描越快，也越耗电。仅安卓微信客户端 7.0.12 及以上支持。 |
|  | 合法值 说明 low 低 medium 中 high 高 | 合法值 | 说明 | low | 低 | medium | 中 | high | 高 |
| 合法值 | 说明 |
| low | 低 |
| medium | 中 |
| high | 高 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.startCompass(Object object)

基础库 1.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.startDeviceMotionListening(Object object)

基础库 2.3.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | interval | string | normal | 否 | 监听设备方向的变化回调函数的执行频率 |
|  | 合法值 说明 game 适用于更新游戏的回调频率，在 20ms/次 左右 ui 适用于更新 UI 的回调频率，在 60ms/次 左右 normal 普通的回调频率，在 200ms/次 左右 | 合法值 | 说明 | game | 适用于更新游戏的回调频率，在 20ms/次 左右 | ui | 适用于更新 UI 的回调频率，在 60ms/次 左右 | normal | 普通的回调频率，在 200ms/次 左右 |
| 合法值 | 说明 |
| game | 适用于更新游戏的回调频率，在 20ms/次 左右 |
| ui | 适用于更新 UI 的回调频率，在 60ms/次 左右 |
| normal | 普通的回调频率，在 200ms/次 左右 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.startGyroscope(Object object)

基础库 2.3.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | interval | string | normal | 否 | 监听陀螺仪数据回调函数的执行频率 |
|  | 合法值 说明 game 适用于更新游戏的回调频率，在 20ms/次 左右 ui 适用于更新 UI 的回调频率，在 60ms/次 左右 normal 普通的回调频率，在 200ms/次 左右 | 合法值 | 说明 | game | 适用于更新游戏的回调频率，在 20ms/次 左右 | ui | 适用于更新 UI 的回调频率，在 60ms/次 左右 | normal | 普通的回调频率，在 200ms/次 左右 |
| 合法值 | 说明 |
| game | 适用于更新游戏的回调频率，在 20ms/次 左右 |
| ui | 适用于更新 UI 的回调频率，在 60ms/次 左右 |
| normal | 普通的回调频率，在 200ms/次 左右 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.startHandoff(Object object)

基础库 2.14.4 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.stopAccelerometer(Object object)

基础库 1.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.stopBeaconDiscovery(Object object)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.stopBluetoothDevicesDiscovery(Object object)

基础库 2.9.2 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.stopCompass(Object object)

基础库 1.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.stopDeviceMotionListening(Object object)

基础库 2.3.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.stopFaceDetect(Object object)

该接口已停止维护，推荐使用 wx.createVKSession 代替

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.stopGyroscope(Object object)

基础库 2.3.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.updateKeyboard(Object object)

基础库 2.1.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| value | string |  | 是 | 键盘输入框的当前值 |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.updateShareMenu(Object object)

基础库 1.2.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- | --- |
|  | withShareTicket | boolean | false | 否 | 是否使用带 shareTicket 的转发详情 |  |
|  | isUpdatableMessage | boolean | false | 否 | 是否是动态消息，详见动态消息 | 2.4.0 |
|  | activityId | string |  | 否 | 动态消息的 activityId。通过 updatableMessage.createActivityId 接口获取 | 2.4.0 |
|  | toDoActivityId | string |  | 否 | 群待办消息的id，通过toDoActivityId可以把多个群待办消息聚合为同一个。通过 updatableMessage.createActivityId 接口获取。详见群待办消息 | 2.11.0 |
|  | templateInfo | Object |  | 否 | 动态消息的模板信息 | 2.4.0 |
|  | 结构属性 类型 默认值 必填 说明 parameterList Array.<Object> 是 参数列表 结构属性 类型 默认值 必填 说明 name string 是 参数名 value string 是 参数值 templateId string 是 模板ID |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | parameterList | Array.<Object> |  | 是 | 参数列表 |  | 结构属性 类型 默认值 必填 说明 name string 是 参数名 value string 是 参数值 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | name | string |  | 是 | 参数名 |  | value | string |  | 是 | 参数值 |  | templateId | string |  | 是 | 模板ID |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | parameterList | Array.<Object> |  | 是 | 参数列表 |
|  | 结构属性 类型 默认值 必填 说明 name string 是 参数名 value string 是 参数值 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | name | string |  | 是 | 参数名 |  | value | string |  | 是 | 参数值 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | name | string |  | 是 | 参数名 |
|  | value | string |  | 是 | 参数值 |
|  | templateId | string |  | 是 | 模板ID |
|  | isPrivateMessage | boolean |  | 否 | 是否是私密消息。详见 小程序私密消息 | 2.13.0 |
|  | participant | Array.<string> | [] | 否 | 参与用户此聊天室下的 group_openid 列表 |  |
|  | useForChatTool | boolean | false | 否 | 聊天工具模式特殊动态消息 | 3.7.8 |
|  | chooseType | number | 1 | 否 | 指定成员的方式 | 3.7.8 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |  |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |  |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.updateVoIPChatMuteConfig(Object object)

基础库 2.7.0 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | muteConfig | Object |  | 是 | 静音设置 |
|  | 结构属性 类型 默认值 必填 说明 muteMicrophone Boolean false 否 是否静音麦克风 muteEarphone Boolean false 否 是否静音耳机 |  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |  | muteMicrophone | Boolean | false | 否 | 是否静音麦克风 |  | muteEarphone | Boolean | false | 否 | 是否静音耳机 |
|  | 结构属性 | 类型 | 默认值 | 必填 | 说明 |
|  | muteMicrophone | Boolean | false | 否 | 是否静音麦克风 |
|  | muteEarphone | Boolean | false | 否 | 是否静音耳机 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.updateWeChatApp(Object object)

基础库 2.12.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### UploadTask wx.uploadFile(Object object)

以 Promise 风格 调用：不支持

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| url | string |  | 是 | 开发者服务器地址 |  |
| filePath | string |  | 是 | 要上传文件资源的路径 (本地路径) |  |
| name | string |  | 是 | 文件对应的 key，开发者在服务端可以通过这个 key 获取文件的二进制内容 |  |
| header | Object |  | 否 | HTTP 请求 Header，Header 中不能设置 Referer |  |
| formData | Object |  | 否 | HTTP 请求中其他额外的 form data |  |
| timeout | number |  | 否 | 超时时间，单位为毫秒 | 2.10.0 |
| enableProfile | boolean | true | 否 | 是否开启 profile。iOS 和 Android 端默认开启，其他端暂不支持。开启后可在接口回调的 res.profile 中查看性能调试信息。 | 3.5.0 |
| enableHttp2 | boolean | false | 否 | 是否开启 http2 | 2.10.4 |
| enableQuic | boolean | false | 否 | 是否开启 Quic/h3 协议（iOS 微信目前使用 gQUIC-Q43；Android 微信在 v8.0.54 前使用 gQUIC-Q43，v8.0.54 开始使用 IETF QUIC，即 h3 协议；PC微信使用 IETF QUIC，即 h3 协议） | 2.10.4 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.vibrateLong(Object object)

基础库 1.2.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- |
| success | function |  | 否 | 接口调用成功的回调函数 |
| fail | function |  | 否 | 接口调用失败的回调函数 |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |


### wx.vibrateShort(Object object)

基础库 1.2.0 开始支持，低版本需做兼容处理。

| 属性 | 类型 | 默认值 | 必填 | 说明 | 最低版本 |
| --- | --- | --- | --- | --- | --- |
| type | string |  | 是 | 震动强度类型，有效值为：heavy、medium、light | 2.13.0 |
| success | function |  | 否 | 接口调用成功的回调函数 |  |
| fail | function |  | 否 | 接口调用失败的回调函数 |  |
| complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |  |


### wx.writeBLECharacteristicValue(Object object)

基础库 2.9.2 开始支持，低版本需做兼容处理。

|  | 属性 | 类型 | 默认值 | 必填 | 说明 |
| --- | --- | --- | --- | --- | --- |
|  | deviceId | string |  | 是 | 蓝牙设备 id |
|  | serviceId | string |  | 是 | 蓝牙特征对应服务的 UUID |
|  | characteristicId | string |  | 是 | 蓝牙特征的 UUID |
|  | value | ArrayBuffer |  | 是 | 蓝牙设备特征对应的二进制值 |
|  | writeType | string |  | 否 | 蓝牙特征值的写模式设置，有两种模式，iOS 优先 write，安卓优先 writeNoResponse 。（基础库 2.22.0 开始支持） |
|  | 合法值 说明 write 强制回复写，不支持时报错 writeNoResponse 强制无回复写，不支持时报错 | 合法值 | 说明 | write | 强制回复写，不支持时报错 | writeNoResponse | 强制无回复写，不支持时报错 |
| 合法值 | 说明 |
| write | 强制回复写，不支持时报错 |
| writeNoResponse | 强制无回复写，不支持时报错 |
|  | success | function |  | 否 | 接口调用成功的回调函数 |
|  | fail | function |  | 否 | 接口调用失败的回调函数 |
|  | complete | function |  | 否 | 接口调用结束的回调函数（调用成功、失败都会执行） |

