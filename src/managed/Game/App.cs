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
        }

        public static void Update()
        {

        }
    }
}
