using System.Diagnostics;
using Wx;

namespace Game
{

    class Background
    {
        const string src = "images/bg.jpg";
        const int screenWidth = 512;
        const int screenHeight = 512;
        const int speed = 2;

        private readonly Wx.Image _bg;
        private int _width;
        private int _height;
        private int _top;

        public static Background Ins = new Background();

        Background()
        {
            _bg = new Image(src);
            _width = screenWidth;
            _height = screenHeight;
            _top = 0;
        }

        public void Update()
        {
            _top += speed;
            if (_top >= screenHeight)
            {
                _top = 0;
            }
        }

        public void Render(CanvasContext c)
        {
            c.DrawImage2(_bg, 0.0, 0.0, (double)_width, (double)_height, 0.0, -screenHeight + _top, screenWidth, screenHeight);
            c.DrawImage2(_bg, 0, 0, _width, _height, 0, _top, screenWidth, screenHeight);
        }
    }

    public class App
    {
        public static void Start()
        {
            Debugger.Log(0, "Game", "Game Started");
            Wx.Console.Log("Hello from Wx.Console!");
            Wx.Console.Err("This is an error message from Wx.Console.");
            Wx.Console.Log($"Screen Width: {Wx.ScreenInfo.Width}, Height: {Wx.ScreenInfo.Height}");
            Wx.Canvas canvas = Wx.Canvas.Default;
            var ctx2d = canvas.Context2D;
        }

        public static void Update()
        {
            Background.Ins.Update();
        }

        public static void Render()
        {
            var ctx2d = Wx.Canvas.Default.Context2D;
            ctx2d.ClearRect(0, 0, Wx.ScreenInfo.Width, Wx.ScreenInfo.Height);
            Background.Ins.Render(ctx2d);
        }
    }
}
