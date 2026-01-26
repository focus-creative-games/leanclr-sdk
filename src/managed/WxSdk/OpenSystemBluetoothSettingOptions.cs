using System;

namespace WxSdk
{
    public class OpenSystemBluetoothSettingOptions
    {
        public Action<SystemBluetoothSetting> onSuccess;

        public Action onFail;

        public Action onComplete;
    }
}