using System.Runtime.InteropServices;

namespace LeanCLRSdk
{
    public class ScreenInfo
    {
        public static int Width => GetScreenWidthInternal();

        public static int Height => GetScreenHeightInternal();

        [DllImport("wx", EntryPoint = "screen.getScreenWidth")]
        private extern static int GetScreenWidthInternal();

        [DllImport("wx", EntryPoint = "screen.getScreenHeight")]
        private extern static int GetScreenHeightInternal();
    }
}