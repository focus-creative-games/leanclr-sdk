using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;

namespace WxSdk
{
    public class OnProgressUpdateEventArgs
    {
        public int Progress { get; internal set; }

        public int TotalBytesWritten { get; internal set; }

        public int TotalBytesExpectedToWrite { get; internal set; }
    }

    public class PreDownloadSubpackageTask
    {
        public void OnProgressUpdate(Action<OnProgressUpdateEventArgs> callback)
        {
            OnProgressUpdateInternal(MarshalHelper.ToDelegateHandle(new Action<JSObject>((res) =>
            {
                var args = new OnProgressUpdateEventArgs
                {
                    Progress = res.GetInt("progress"),
                    TotalBytesWritten = res.GetInt("totalBytesWritten"),
                    TotalBytesExpectedToWrite = res.GetInt("totalBytesExpectedToWrite"),
                };
                callback?.Invoke(args);
            })));
        }


        [DllImport("wx", EntryPoint = "wxsdk_pre_download_subpackage_on_progress_update")]
        private static extern void OnProgressUpdateInternal(DelegateHandle callback);
    }

    public class LoadSubpackageTask
    {
        public void OnProgressUpdate(Action<OnProgressUpdateEventArgs> callback)
        {
            OnProgressUpdateInternal(MarshalHelper.ToDelegateHandle(new Action<JSObject>((res) =>
            {
                var args = new OnProgressUpdateEventArgs
                {
                    Progress = res.GetInt("progress"),
                    TotalBytesWritten = res.GetInt("totalBytesWritten"),
                    TotalBytesExpectedToWrite = res.GetInt("totalBytesExpectedToWrite"),
                };
                callback?.Invoke(args);
            })));
        }

        [DllImport("wx", EntryPoint = "wxsdk_load_subpackage_on_progress_update")]
        private static extern void OnProgressUpdateInternal(DelegateHandle callback);
    }

    public static class SubPackage
    {

        public static PreDownloadSubpackageTask PreDownloadSubpackage(string name)
        {
            var arg = new JSObject();
            var ret = PreDownloadSubpackageInternal(arg);

            return null;
        }

        public static LoadSubpackageTask LoadSubpackage(string name)
        {
            var arg = new JSObject();
            var ret = LoadSubpackageInternal(arg);

            return null;
        }

        [DllImport("wx", EntryPoint = "wxsdk_pre_download_subpackage")]
        private static extern ObjectHandle PreDownloadSubpackageInternal(JSObject arg);

        [DllImport("wx", EntryPoint = "wxsdk_load_subpackage")]
        private static extern ObjectHandle LoadSubpackageInternal(JSObject arg);
    }
}