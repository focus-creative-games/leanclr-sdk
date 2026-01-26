using System;
using System.Runtime.InteropServices;

namespace WxSdk
{
    public class UpdateWeChatAppOptions
    {
        public Action onSuccess;
        public Action onFail;
        public Action onComplete;
    }

    public static class Update
    {
        public static void UpdateWeChatApp(UpdateWeChatAppOptions options)
        {
            UpdateWeChatAppInternal(
                MarshalHelper.ToDelegateHandle(options.onSuccess),
                MarshalHelper.ToDelegateHandle(options.onFail),
                MarshalHelper.ToDelegateHandle(options.onComplete));
        }

        private static UpdateManager s_globalUpdateManager;

        public static UpdateManager GetUpdateManager()
        {
            if (s_globalUpdateManager == null)
            {
                ObjectHandle handle = GetUpdateManagerInternal();
                if (handle.IsNull())
                {
                    return null;
                }
                s_globalUpdateManager = new UpdateManager(handle);
            }
            return s_globalUpdateManager;
        }

        [DllImport("wx", EntryPoint = "wxsdk_update_wechat_app")]
        private static extern void UpdateWeChatAppInternal(DelegateHandle onSuccessHandle, DelegateHandle onFailHandle, DelegateHandle onCompleteHandle);


        [DllImport("wx", EntryPoint = "wxsdk_get_update_manager")]
        private static extern ObjectHandle GetUpdateManagerInternal();

    }
}