using System.Diagnostics;
using WxSdk;

namespace Game
{

    public class App
    {
        public static void Start()
        {
            Debugger.Log(0, "Game", "Game Started");
            Console.Log("Hello from Wx.Console!");
            Console.Err("This is an error message from Wx.Console.");
            Console.Log($"Screen Width: {ScreenInfo.Width}, Height: {ScreenInfo.Height}");
            Canvas canvas = Canvas.Default;
            canvas.Width = ScreenInfo.Width;
            canvas.Height = ScreenInfo.Height;

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
            var ctx2d = Canvas.Default.Context2D;
            ctx2d.ClearRect(0, 0, ScreenInfo.Width, ScreenInfo.Height);
            Background.Ins.Render(ctx2d);
        }
    }
}
