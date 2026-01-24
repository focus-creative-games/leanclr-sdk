using System.Diagnostics;

namespace Game
{

    public class App
    {
        public static void Start()
        {
            Debugger.Log(0, "Game", "Game Started");
            Wx.Console.Log("Hello from Wx.Console!");
            Wx.Console.Err("This is an error message from Wx.Console.");
            Wx.Console.Log($"Screen Width: {Wx.ScreenInfo.Width}, Height: {Wx.ScreenInfo.Height}");
            Wx.Canvas canvas = Wx.Canvas.Default;
            canvas.Width = Wx.ScreenInfo.Width;
            canvas.Height = Wx.ScreenInfo.Height;

            var ctx2d = canvas.Context2D;

            Background.Ins.Start();
            Music.Ins.Start();
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
