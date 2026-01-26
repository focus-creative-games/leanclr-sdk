using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WxSdk
{

    public class RefererInfo
    {
        public string AppId { get; set; }

        public JSObject ExtraData { get; set; }
    }

    public enum ChatType
    {
        Personal, // one-on-one chat
        Enterprise, // enterprise
        PersonalGroup,
        EnterpriseGroup,
    }

    public class OnShowResult
    {
        public int Scene { get; set; }

        public JSObject Query { get; set; }

        public string ShareTicket { get; set; }

        public RefererInfo ReferrerInfo { get; set; }

        public ChatType ChatType { get; set; }
    }

    public class HostExtraData
    {
        public string HostScene { get; set; }
    }

    public class LaunchOptions
    {
        public int Scene { get; set; }
        public JSObject Query { get; set; }
        public string ShareTicket { get; set; }
        public RefererInfo ReferrerInfo { get; set; }
        public HostExtraData HostExtraData { get; set; }
        public ChatType ChatType { get; set; }
    }

    public enum ApiCategory
    {
        Default,
        NativeFunctionalized,
        BrowseOnly,
        Embedded,
    }

    public class EnterOptions
    {
        public int Scene { get; set; }
        public JSObject Query { get; set; }
        public string ShareTicket { get; set; }
        public RefererInfo ReferrerInfo { get; set; }
        public ChatType ChatType { get; set; }
        public ApiCategory ApiCategory { get; set; }
    }

    public static class LifeCycle
    {

        public static void OnShow(Action<OnShowResult> callback)
        {
            OnShow(MarshalHelper.ToDelegateHandle(callback));
        }

        public static void OnHide(Action callback)
        {
            OnHide(MarshalHelper.ToDelegateHandle(callback));
        }

        public static void OffShow(Action<OnShowResult> callback)
        {
            OffShow(MarshalHelper.ToDelegateHandle(callback));
        }

        public static void OffHide(Action callback)
        {
            OffHide(MarshalHelper.ToDelegateHandle(callback));
        }

        public static LaunchOptions GetLaunchOptions()
        {
            var jsObj = GetLaunchOptionsSync();
            var referrerInfoObj = jsObj.GetJSObject("referrerInfo");
            var hostExtraDataObj = jsObj.GetJSObject("hostExtraData");
            return new LaunchOptions
            {
                Scene = jsObj.GetInt("scene"),
                Query = jsObj.GetJSObject("query"),
                ShareTicket = jsObj.GetString("shareTicket"),
                ReferrerInfo = new RefererInfo
                {
                    AppId = referrerInfoObj.GetString("appId"),
                    ExtraData = referrerInfoObj.GetJSObject("extraData"),
                },
                HostExtraData = new HostExtraData
                {
                    HostScene = hostExtraDataObj.GetString("hostScene"),
                },
                ChatType = (ChatType)jsObj.GetInt("chatType"),
            };
        }

        public static EnterOptions GetEnterOptions()
        {
            var jsObj = GetEnterOptionsSync();
            var referrerInfoObj = jsObj.GetJSObject("referrerInfo");
            return new EnterOptions
            {
                Scene = jsObj.GetInt("scene"),
                Query = jsObj.GetJSObject("query"),
                ShareTicket = jsObj.GetString("shareTicket"),
                ReferrerInfo = new RefererInfo
                {
                    AppId = referrerInfoObj.GetString("appId"),
                    ExtraData = referrerInfoObj.GetJSObject("extraData"),
                },
                ChatType = (ChatType)jsObj.GetInt("chatType"),
                ApiCategory = (ApiCategory)jsObj.GetInt("apiCategory"),
            };
        }

        [DllImport("wx", EntryPoint = "wxsdk_on_show")]
        public static extern void OnShow(DelegateHandle callbackHandle);
        [DllImport("wx", EntryPoint = "wxsdk_on_hide")]
        public static extern void OnHide(DelegateHandle callbackHandle);

        [DllImport("wx", EntryPoint = "wxsdk_off_show")]
        public static extern void OffShow(DelegateHandle callbackHandle);

        [DllImport("wx", EntryPoint = "wxsdk_off_hide")]
        public static extern void OffHide(DelegateHandle callbackHandle);

        [DllImport("wx", EntryPoint = "wxsdk_get_launch_options_sync")]
        public static extern JSObject GetLaunchOptionsSync();
        [DllImport("wx", EntryPoint = "wxsdk_get_enter_options_sync")]
        public static extern JSObject GetEnterOptionsSync();
    }
}