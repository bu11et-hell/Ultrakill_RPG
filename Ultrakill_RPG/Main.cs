using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ultrakill_RPG
{
    internal class Program
    {
        public static void Main()
        {
            string loopGameQuiestion;

            do
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
            while (loopGameQuiestion is "yes" or "y" or "1");
        }
    }
}
