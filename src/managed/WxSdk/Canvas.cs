
using System;
using System.Runtime.InteropServices;

namespace Wx
{
    public class Canvas
    {
        public static CanvasContext GetContext(string ctxName)
        {
            if (string.IsNullOrEmpty(ctxName))
            {
                throw new ArgumentException("Context name cannot be null or empty", nameof(ctxName));
            }
            IntPtr ctxHandle = GetContextInternal(ctxName);
            if (ctxHandle == IntPtr.Zero)
            {
                throw new Exception($"Failed to get canvas context: {ctxName}");
            }
            return new CanvasContext(ctxHandle);
        }

        [DllImport("wx", EntryPoint = "canvas.getContext")]
        private static extern IntPtr GetContextInternal(string ctxName);
    }
}