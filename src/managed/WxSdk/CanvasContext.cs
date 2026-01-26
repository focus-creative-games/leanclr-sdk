
using System;
using System.Runtime.InteropServices;

namespace WxSdk
{

    public class CanvasContext
    {
        private readonly Canvas _canvas;
        private readonly IntPtr _ctxHandle;
        public CanvasContext(Canvas canvas, IntPtr ctxHandle)
        {
            _canvas = canvas;
            _ctxHandle = ctxHandle;
        }

        public void ClearRect(double x, double y, double width, double height)
        {
            ClearRectInternal(_ctxHandle, x, y, width, height);
        }

        public void DrawImage(Image img, double dx, double dy, double dWidth, double dHeight)
        {
            DrawImageInternal(_ctxHandle, img.Handle, dx, dy, dWidth, dHeight);
        }

        public void DrawImage(Image img, double dx, double dy, double dWidth, double dHeight, double screenX, double screenY, double screenWidth, double screenHeight)
        {
            DrawImageInternal2(_ctxHandle, img.Handle, dx, dy, dWidth, dHeight, screenX, screenY, screenWidth, screenHeight);
        }

        public string Font
        {
            set => SetFontInternal(_ctxHandle, value);
        }

        public string FillStyle
        {
            set => SetFillStyleInternal(_ctxHandle, value);
        }

        public void FillText(string text, double x, double y)
        {
            FillTextInternal(_ctxHandle, text, x, y);
        }

        [DllImport("wx", EntryPoint = "canvas.clearRect")]
        private static extern void ClearRectInternal(IntPtr ctxHandle, double x, double y, double width, double height);


        [DllImport("wx", EntryPoint = "canvas.drawImage")]
        private static extern void DrawImageInternal(IntPtr ctxHandle, IntPtr imgHandle, double dx, double dy, double dWidth, double dHeight);




        [DllImport("wx", EntryPoint = "canvas.drawImage2")]
        private static extern void DrawImageInternal2(IntPtr ctxHandle, IntPtr imgHandle, double dx, double dy, double dWidth, double dHeight, double screenX, double screenY, double screenWidth, double sceenHeight);

        [DllImport("wx", EntryPoint = "canvas.setFont")]
        private static extern void SetFontInternal(IntPtr ctxHandle, string font);

        [DllImport("wx", EntryPoint = "canvas.setFillStyle")]
        private static extern void SetFillStyleInternal(IntPtr ctxHandle, string fillStyle);

        [DllImport("wx", EntryPoint = "canvas.fillText")]
        private static extern void FillTextInternal(IntPtr ctxHandle, string text, double x, double y);
    }
}