
using System;
using System.Runtime.InteropServices;

namespace Wx
{
    public class Image
    {
        private readonly IntPtr _imgHandle;

        public Image(string src)
        {
            _imgHandle = CreateImageInternal();
            if (_imgHandle == IntPtr.Zero)
            {
                throw new Exception("Failed to create image");
            }
            if (!string.IsNullOrEmpty(src))
            {
                SetSrc(_imgHandle, src);
            }
        }

        public IntPtr Handle => _imgHandle;

        [DllImport("wx", EntryPoint = "wx.createImage")]
        private static extern IntPtr CreateImageInternal();

        [DllImport("wx", EntryPoint = "image.set_src")]
        private static extern void SetSrc(IntPtr imgHandle, string src);
    }
}