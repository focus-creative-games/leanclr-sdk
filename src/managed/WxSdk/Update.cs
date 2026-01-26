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

    public class UpdateManager
    {
        private readonly ObjectHandle _handle;

        public UpdateManager(ObjectHandle handle)
        {
            _handle = handle;
        }

        public void ApplyUpdate()
        {
            ApplyUpdateInternal(_handle);
        }

        public void OnCheckForUpdate(Action<bool> onCheckForUpdate)
        {
            OnCheckForUpdateInternal(_handle, MarshalHelper.ToDelegateHandle(onCheckForUpdate));
        }

        public void OnUpdateReady(Action onUpdateReady)
        {
            OnUpdateReadyInternal(_handle, MarshalHelper.ToDelegateHandle(onUpdateReady));
        }

        public void OnUpdateFailed(Action onUpdateFailed)
        {
            OnUpdateFailedInternal(_handle, MarshalHelper.ToDelegateHandle(onUpdateFailed));
        }

        [DllImport("wx", EntryPoint = "wxsdk_apply_update")]
        private static extern void ApplyUpdateInternal(ObjectHandle handle);

        [DllImport("wx", EntryPoint = "wxsdk_on_check_for_update")]
        private static extern void OnCheckForUpdateInternal(ObjectHandle handle, DelegateHandle onCheckForUpdateHandle);

        [DllImport("wx", EntryPoint = "wxsdk_on_update_ready")]
        private static extern void OnUpdateReadyInternal(ObjectHandle handle, DelegateHandle onUpdateReadyHandle);

        [DllImport("wx", EntryPoint = "wxsdk_on_update_failed")]
        private static extern void OnUpdateFailedInternal(ObjectHandle handle, DelegateHandle onUpdateFailedHandle);
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