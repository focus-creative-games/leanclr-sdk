
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
                SetImageSrcInternal(_imgHandle, src);
            }
        }

        public IntPtr Handle => _imgHandle;

        public int Width => GetImageWidthInternal(_imgHandle);
        public int Height => GetImageHeightInternal(_imgHandle);

        [DllImport("wx", EntryPoint = "wx.createImage")]
        private static extern IntPtr CreateImageInternal();

        [DllImport("wx", EntryPoint = "image.set_src")]
        private static extern void SetImageSrcInternal(IntPtr imgHandle, string src);

        [DllImport("wx", EntryPoint = "image.get_width")]
        private static extern int GetImageWidthInternal(IntPtr imgHandle);
        [DllImport("wx", EntryPoint = "image.get_height")]
        private static extern int GetImageHeightInternal(IntPtr imgHandle);
    }
}