
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Wx
{
    public class Canvas
    {
        private static Canvas _default;

        public static Canvas Default
        {
            get
            {
                if (_default == null)
                {
                    return CreateCanvas();
                }
                return _default;
            }
        }

        public static Canvas CreateCanvas()
        {
            IntPtr canvasHandle = CreateCanvasInternal();
            if (canvasHandle == IntPtr.Zero)
            {
                throw new Exception("Failed to create canvas");
            }
            var canvas = new Canvas(canvasHandle);
            if (_default == null)
            {
                _default = canvas;
            }
            return canvas;
        }


        private readonly Dictionary<string, CanvasContext> _contexts = new Dictionary<string, CanvasContext>();

        public CanvasContext GetContext(string ctxName)
        {
            if (string.IsNullOrEmpty(ctxName))
            {
                throw new ArgumentException("Context name cannot be null or empty", nameof(ctxName));
            }
            if (_contexts.TryGetValue(ctxName, out var existingCtx))
            {
                return existingCtx;
            }
            IntPtr ctxHandle = GetContextInternal(_canvasHandle, ctxName);
            if (ctxHandle == IntPtr.Zero)
            {
                throw new Exception($"Failed to get canvas context: {ctxName}");
            }
            var ctx = new CanvasContext(this, ctxHandle);
            if (_ctx2d == null && ctxName == "2d")
            {
                _ctx2d = ctx;
            }
            _contexts[ctxName] = ctx;
            return ctx;
        }

        private readonly IntPtr _canvasHandle;
        private CanvasContext _ctx2d;

        public CanvasContext Context2D
        {
            get
            {
                if (_ctx2d == null)
                {
                    return GetContext("2d");
                }
                return _ctx2d;
            }
        }



        public int Width
        {
            get => GetWidthInternal(_canvasHandle);
            set => SetWidthInternal(_canvasHandle, value);
        }

        public int Height
        {
            get => GetHeightInternal(_canvasHandle);
            set => SetHeightInternal(_canvasHandle, value);
        }

        private Canvas(IntPtr canvasHandle)
        {
            _canvasHandle = canvasHandle;
        }

        [DllImport("wx", EntryPoint = "canvas.createCanvas")]
        private static extern IntPtr CreateCanvasInternal();

        [DllImport("wx", EntryPoint = "canvas.getContext")]
        private static extern IntPtr GetContextInternal(IntPtr canvasHandle, string ctxName);

        [DllImport("wx", EntryPoint = "canvas.getWidth")]
        private static extern int GetWidthInternal(IntPtr canvasHandle);
        [DllImport("wx", EntryPoint = "canvas.setWidth")]
        private static extern void SetWidthInternal(IntPtr canvasHandle, int width);
        [DllImport("wx", EntryPoint = "canvas.getHeight")]
        private static extern int GetHeightInternal(IntPtr canvasHandle);
        [DllImport("wx", EntryPoint = "canvas.setHeight")]
        private static extern void SetHeightInternal(IntPtr canvasHandle, int height);
    }
}