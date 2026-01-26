using System.Runtime.InteropServices;

namespace WxSdk
{
    public class Console
    {
        public static void Debug(string message)
        {
            DebugInternal(message);
        }

        public static void Log(string message)
        {
            LogInternal(message);
        }

        public static void Info(string message)
        {
            InfoInternal(message);
        }

        public static void Warn(string message)
        {
            WarnInternal(message);
        }

        public static void Err(string message)
        {
            ErrInternal(message);
        }

        public static void Group(string label)
        {
            GroupInternal(label);
        }

        public static void GroupEnd()
        {
            GroupEndInternal();
        }

        [DllImport("wx", EntryPoint = "wxsdk_console_debug")]
        private static extern void DebugInternal(string message);

        [DllImport("wx", EntryPoint = "wxsdk_console_log")]
        private static extern void LogInternal(string message);

        [DllImport("wx", EntryPoint = "wxsdk_console_info")]
        private static extern void InfoInternal(string message);

        [DllImport("wx", EntryPoint = "wxsdk_console_warn")]
        private static extern void WarnInternal(string message);

        [DllImport("wx", EntryPoint = "wxsdk_console_err")]
        private static extern void ErrInternal(string message);

        [DllImport("wx", EntryPoint = "wxsdk_console_group")]
        private static extern void GroupInternal(string label);

        [DllImport("wx", EntryPoint = "wxsdk_console_group_end")]
        private static extern void GroupEndInternal();
    }
}