namespace WxSdk
{
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
}