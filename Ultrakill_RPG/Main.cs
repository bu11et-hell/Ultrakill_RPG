using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;
using Avalonia;

namespace Ultrakill_RPG
{
    /*
    internal class Program
    {
        public static void Main()
        {
            PlayerList.players.Clear();
            EnemyList.enemies.Clear();
            string loopGameQuiestion = "yes";

            while (loopGameQuiestion is "yes" or "y" or "1")
            {
                Console.Clear();
                Texterer.InputEnemyCount();
                Texterer.InputEnemyNaming();
                Texterer.InputPlayerCount();
                Texterer.InputPlayerNaming();
                //Game starts here
                Texterer.GameStartText();
                //Player selection
                Texterer.PlayerSelectionMenu();
                Console.WriteLine("loop?");
                loopGameQuiestion = Console.ReadLine();
            }
        }
    }
    */
    // Program.cs
    class Program
    {
        [STAThread]
        public static void Main(string[] args) =>
            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);

        public static AppBuilder BuildAvaloniaApp() =>
            AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace();
    }
}
