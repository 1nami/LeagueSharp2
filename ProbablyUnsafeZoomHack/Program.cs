using System;

using LeagueSharp;
using LeagueSharp.Common;

namespace eoqqq
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        static void Game_OnGameLoad(EventArgs args)
        {
            Hacks.ZoomHack = true;
            Game.PrintChat("[1nami: eoqqq] eoqqq is Enabled");
        }
    }
}
