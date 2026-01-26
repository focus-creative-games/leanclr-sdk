using System;
using System.Runtime.InteropServices;

namespace WxSdk
{
    public class SystemBluetoothSetting
    {

    }


    public class OpenSystemBluetoothSettingOptions
    {
        public Action<SystemBluetoothSetting> onSuccess;

        public Action onFail;

        public Action onComplete;
    }

    public enum AppAuthStatus
    {
        Authorized,
        Denied,
        NotDetermined
    }

    public class AppAuthorizeSetting
    {
        public AppAuthStatus AlbumAuthorized { get; set; }

        public AppAuthStatus BluetoothAuthorized { get; set; }

        public AppAuthStatus CameraAuthorized { get; set; }
        public AppAuthStatus LocationAuthorized { get; set; }

        public bool LocationReduceAccuracy { get; set; }

        public AppAuthStatus MicrophoneAuthorized { get; set; }

        public AppAuthStatus NotificationAuthorized { get; set; }

        public AppAuthStatus NotificationAlertAuthorized { get; set; }

        public AppAuthStatus NotificationBadgeAuthorized { get; set; }

        public AppAuthStatus NotificationSoundAuthorized { get; set; }

        public AppAuthStatus PhoneCalendarAuthorized { get; set; }
    }


    public class AppAuthorizeSettingOptions
    {
        public Action onSuccess;

        public Action onFail;

        public Action onComplete;
    }

    public class SafeArea
    {
        public int Left { get; set; }

        public int Right { get; set; }

        public int Top { get; set; }

        public int Bottom { get; set; }

        public int Width => Right - Left;

        public int Height => Bottom - Top;
    }

    public class WindowsInfo
    {
        public float PixelRatio { get; set; }

        public int ScreenWidth { get; set; }

        public int ScreenHeight { get; set; }

        public int WindowsWidth { get; set; }

        public int WindowsHeight { get; set; }

        public int StatusBarHeight { get; set; }

        public SafeArea SafeArea { get; set; }
    }

    public class SystemSetting
    {
        public bool BluetoothEnabled { get; set; }

        public bool LocationEnabled { get; set; }

        public bool WifiEnabled { get; set; }

        public DeviceOrientation DeviceOrientation { get; set; }
    }

    public enum DeviceOrientation
    {
        Portrait,
        Landscape,
    }

    public enum Platform
    {
        iOS,
        Android,
        Ohos,
        OhosPC,
        Windows,
        Mac,
        DevTools,
    }

    public class DeviceInfo
    {
        public string Abi { get; set; }

        public string DeviceAbi { get; set; }

        public int BenchmarkLevel { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string System { get; set; }

        public Platform Platform { get; set; }

        public string CpuType { get; set; }

        /// <summary>
        /// Unit is MB
        /// </summary>
        public int MemorySize { get; set; }
    }

    public class DeviceBenchmarkInfo
    {
        public int BenchmarkLevel { get; set; }

        public int ModelLevel { get; set; }
    }

    public class GetDeviceBenchmarkOptions
    {
        public Action<DeviceBenchmarkInfo> onSuccess;

        public Action onFail;

        public Action onComplete;
    }


    public class HostInfo
    {
        public string AppId { get; set; }
    }

    public class AppBaseInfo
    {
        public string SDKVersion { get; set; }

        public bool EnableDebug { get; set; }

        public HostInfo Host { get; set; }

        public string Language { get; set; }

        public string Version { get; set; }

        public string PCKernelVersion { get; set; }

        public string Theme { get; set; }

        public float FontSizeScaleFactor { get; set; }

        public float FontSizeSetting { get; set; }
    }

    public static class SystemInfo
    {
        public static string Env => GetEnvInternal();

        [ApiCompatible("2.25.3")]
        public static void OpenSystemBluetoothSetting(OpenSystemBluetoothSettingOptions options)
        {
            OpenSystemBluetoothSettingInternal(MarshalHelper.ToDelegateHandle(options.onSuccess), MarshalHelper.ToDelegateHandle(options.onFail), MarshalHelper.ToDelegateHandle(options.onComplete));
        }

        [ApiCompatible("2.25.3")]
        public static void OpenAppAuthorizeSetting(AppAuthorizeSettingOptions options)
        {
            OpenAppAuthorizeSettingInternal(MarshalHelper.ToDelegateHandle(options.onSuccess), MarshalHelper.ToDelegateHandle(options.onFail), MarshalHelper.ToDelegateHandle(options.onComplete));
        }

        [ApiCompatible("2.25.3")]
        public static WindowsInfo GetWindowInfo()
        {
            JSObject jsObj = GetWindowInfoInternal();
            JSObject safeArea = jsObj.GetJSObject("safeArea");
            return new WindowsInfo
            {
                PixelRatio = jsObj.GetFloat("pixelRatio"),
                ScreenWidth = jsObj.GetInt("screenWidth"),
                ScreenHeight = jsObj.GetInt("screenHeight"),
                WindowsWidth = jsObj.GetInt("windowWidth"),
                WindowsHeight = jsObj.GetInt("windowHeight"),
                StatusBarHeight = jsObj.GetInt("statusBarHeight"),
                SafeArea = new SafeArea
                {
                    Left = safeArea.GetInt("left"),
                    Right = safeArea.GetInt("right"),
                    Top = safeArea.GetInt("top"),
                    Bottom = safeArea.GetInt("bottom"),
                }
            };
        }

        private static DeviceOrientation ParseDeviceOrientation(string orientation)
        {
            switch (orientation.ToLower())
            {
                case "portrait": return DeviceOrientation.Portrait;
                case "landscape": return DeviceOrientation.Landscape;
                default: throw new ArgumentException($"Invalid device orientation string:{orientation}");
            }
        }

        [ApiCompatible("2.25.3")]
        public static SystemSetting GetSystemSetting()
        {
            JSObject jsObj = GetSystemSettingInternal();
            return new SystemSetting
            {
                BluetoothEnabled = jsObj.GetBool("bluetoothEnabled"),
                LocationEnabled = jsObj.GetBool("locationEnabled"),
                WifiEnabled = jsObj.GetBool("wifiEnabled"),
                DeviceOrientation = ParseDeviceOrientation(jsObj.GetString("deviceOrientation")),
            };
        }

        private static Platform ParsePlatform(string platform)
        {
            switch (platform.ToLower())
            {
                case "android": return Platform.Android;
                case "ios": return Platform.iOS;
                case "windows": return Platform.Windows;
                case "mac": return Platform.Mac;
                case "ohos": return Platform.Ohos;
                case "ohos_pc": return Platform.OhosPC;
                case "devtools": return Platform.DevTools;
                default: throw new ArgumentException($"Invalid platform string:{platform}");
            }
        }

        [ApiCompatible("2.25.3")]
        public static DeviceInfo GetDeviceInfo()
        {
            JSObject jsObj = GetDeviceInfoInternal();
            return new DeviceInfo
            {
                Abi = jsObj.GetString("abi"),
                DeviceAbi = jsObj.GetString("deviceAbi"),
                BenchmarkLevel = int.Parse(jsObj.GetString("benchmarkLevel")),
                Brand = jsObj.GetString("brand"),
                Model = jsObj.GetString("model"),
                System = jsObj.GetString("system"),
                Platform = ParsePlatform(jsObj.GetString("platform")),
                CpuType = jsObj.GetString("cpuType"),
                MemorySize = int.Parse(jsObj.GetString("memorySize")),
            };
        }

        [ApiCompatible("3.4.5")]
        public static void GetDeviceBenchmarkInfo(GetDeviceBenchmarkOptions options)
        {
            GetDeviceBenchmarkInfoInternal(MarshalHelper.ToDelegateHandle(options.onSuccess), MarshalHelper.ToDelegateHandle(options.onFail), MarshalHelper.ToDelegateHandle(options.onComplete));
        }

        [ApiCompatible("2.25.3")]
        public static AppBaseInfo GetAppBaseInfo()
        {
            JSObject jsObj = GetAppBaseInfoInternal();

            JSObject host = jsObj.GetJSObject("host");
            return new AppBaseInfo
            {
                SDKVersion = jsObj.GetString("SDKVersion"),
                EnableDebug = jsObj.GetBool("enableDebug"),
                Host = new HostInfo
                {
                    AppId = host.GetString("appId"),
                },
                Language = jsObj.GetString("language"),
                Version = jsObj.GetString("version"),
                PCKernelVersion = jsObj.GetString("pckernelVersion"),
                Theme = jsObj.GetString("theme"),
                FontSizeScaleFactor = jsObj.GetFloat("fontSizeScaleFactor"),
                FontSizeSetting = jsObj.GetFloat("fontSizeSetting"),
            };
        }


        private static AppAuthStatus ParseAppAuthStatus(string status)
        {
            switch (status.ToLower())
            {
                case "authorized": return AppAuthStatus.Authorized;
                case "denied": return AppAuthStatus.Denied;
                case "not determined": return AppAuthStatus.NotDetermined;
                default: throw new ArgumentException($"Invalid app auth status string:{status}");
            }
        }

        [ApiCompatible("2.25.3")]
        public static AppAuthorizeSetting GetAppAuthorizeSetting()
        {
            JSObject jsObj = GetAppAuthorizeSettingInternal();
            return new AppAuthorizeSetting
            {

                AlbumAuthorized = ParseAppAuthStatus(jsObj.GetString("albumAuthorized")),
                BluetoothAuthorized = ParseAppAuthStatus(jsObj.GetString("bluetoothAuthorized")),
                CameraAuthorized = ParseAppAuthStatus(jsObj.GetString("cameraAuthorized")),
                LocationAuthorized = ParseAppAuthStatus(jsObj.GetString("locationAuthorized")),
                LocationReduceAccuracy = jsObj.GetBool("locationReduceAccuracy"),
                MicrophoneAuthorized = ParseAppAuthStatus(jsObj.GetString("microphoneAuthorized")),
                NotificationAuthorized = ParseAppAuthStatus(jsObj.GetString("notificationAuthorized")),
                NotificationAlertAuthorized = ParseAppAuthStatus(jsObj.GetString("notificationAlertAuthorized")),
                NotificationBadgeAuthorized = ParseAppAuthStatus(jsObj.GetString("notificationBadgeAuthorized")),
                NotificationSoundAuthorized = ParseAppAuthStatus(jsObj.GetString("notificationSoundAuthorized")),
                PhoneCalendarAuthorized = ParseAppAuthStatus(jsObj.GetString("phoneCalendarAuthorized")),
            };
        }

        [DllImport("wx", EntryPoint = "wxsdk_get_env")]
        private static extern string GetEnvInternal();

        [DllImport("wx", EntryPoint = "wxsdk_open_system_bluetooth_setting")]
        private static extern void OpenSystemBluetoothSettingInternal(DelegateHandle onSuccess, DelegateHandle onFail, DelegateHandle onComplete);

        [DllImport("wx", EntryPoint = "wxsdk_open_app_authorize_setting")]
        private static extern void OpenAppAuthorizeSettingInternal(DelegateHandle onSuccess, DelegateHandle onFail, DelegateHandle onComplete);

        [DllImport("wx", EntryPoint = "wxsdk_get_window_info")]
        private static extern JSObject GetWindowInfoInternal();

        [DllImport("wx", EntryPoint = "wxsdk_get_system_setting")]
        private static extern JSObject GetSystemSettingInternal();

        [DllImport("wx", EntryPoint = "wxsdk_get_device_info")]
        private static extern JSObject GetDeviceInfoInternal();

        [DllImport("wx", EntryPoint = "wxsdk_get_device_benchmark_info")]
        private static extern void GetDeviceBenchmarkInfoInternal(DelegateHandle onSuccess, DelegateHandle onFail, DelegateHandle onComplete);

        [DllImport("wx", EntryPoint = "wxsdk_get_app_base_info")]
        private static extern JSObject GetAppBaseInfoInternal();

        [DllImport("wx", EntryPoint = "wxsdk_get_app_authorize_setting")]
        private static extern JSObject GetAppAuthorizeSettingInternal();
    }
}