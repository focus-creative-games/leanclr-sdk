using System.Runtime.InteropServices;
using System.Runtime.Remoting;

namespace WxSdk
{

    public class RealtimeLogManager : WxObject
    {
        public RealtimeLogManager(ObjectHandle handle) : base(handle)
        {
        }
    }

    public class LogManager: WxObject
    {
        public LogManager(ObjectHandle handle) : base(handle)
        {
        }

        public void Debug()
        {
            DebugInternal(_handle);
        }

        public void Info()
        {
            InfoInternal(_handle);
        }

        public void Log()
        {
            LogInternal(_handle);
        }

        public void Warn()
        {
            WarnInternal(_handle);
        }

        [DllImport("wx", EntryPoint = "wxsdk_log_manager_debug")]
        private static extern void DebugInternal(ObjectHandle handle);

        [DllImport("wx", EntryPoint = "wxsdk_log_manager_info")]
        private static extern void InfoInternal(ObjectHandle handle);


        [DllImport("wx", EntryPoint = "wxsdk_log_manager_log")]
        private static extern void LogInternal(ObjectHandle handle);

        [DllImport("wx", EntryPoint = "wxsdk_log_manager_warn")]
        private static extern void WarnInternal(ObjectHandle handle);
    }

    public static class SubPackage
    {
        public static void SetEnableDebug(bool enableDebug, Action onSucc, Action onFail, Action onComplete)
        {

            var onSuccHandle = MarshalHelper.ToDelegateHandle(new Action(() =>
            {
                onSucc?.Invoke();
            }));

            var onFailHandle = MarshalHelper.ToDelegateHandle(new Action(() =>
            {
                onFail?.Invoke();
            }));

            var onCompleteHandle = MarshalHelper.ToDelegateHandle(new Action(() =>
            {
                onComplete?.Invoke();
            }));

            SetEnableDebugInternal(enableDebug, onSuccHandle, onFailHandle, onCompleteHandle);
        }

        private static RealtimeLogManager s_realtimeLogManager;

        public static RealtimeLogManager GetRealtimeLogManager()
        {
            if (s_realtimeLogManager == null)
            {
                s_realtimeLogManager = new RealtimeLogManager(GetRealtimeLogManagerInternal());
            }
            return s_realtimeLogManager;
        }

        private static LogManager s_logManager;
        public static LogManager GetLogManager()
        {
            if (s_logManager == null)
            {
                s_logManager = new LogManager(GetLogManagerInternal());
            }
            return s_logManager;
        }

        [DllImport("wx", EntryPoint = "wxsdk_set_enable_debug")]
        private static extern void SetEnableDebugInternal(bool enableDebug, DelegateHandle onSucc, DelegateHandle onFail, DelegateHandle onComplete);

        [DllImport("wx", EntryPoint = "wxsdk_get_realtime_log_manager")]
        private static extern ObjectHandle GetRealtimeLogManagerInternal();

        [DllImport("wx", EntryPoint = "wxsdk_get_log_manager")]
        public static extern ObjectHandle GetLogManagerInternal();
    }
}