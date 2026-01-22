using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class App
    {
        public static void Start()
        {
            Debugger.Log(0, "Game", "Game Started");
        }

        public static void Update()
        {
            Debugger.Log(0, "Game", "Game Updated");
        }
    }
}
