using System.Runtime.InteropServices;

namespace LeanCLRSdk
{
    public class Console
    {
        [DllImport("wx", EntryPoint = "console.log")]
        public static extern void Log(string message);

        [DllImport("wx", EntryPoint = "console.err")]
        public static extern void Err(string message);
    }
}