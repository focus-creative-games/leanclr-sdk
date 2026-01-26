using System;
using System.Runtime.InteropServices;

namespace WxSdk
{
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
}