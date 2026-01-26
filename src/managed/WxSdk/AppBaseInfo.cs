namespace WxSdk
{
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
}