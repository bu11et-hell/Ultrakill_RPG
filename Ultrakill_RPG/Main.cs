using System;
using System.Collections.Generic;
using System.Text;

namespace Ultrakill_RPG
{
    internal class Program
    {
        public static void Main()
        {
            Texterer.InputEnemyCount();
            Texterer.InputEnemyNaming();
            Texterer.InputPlayerCount();
            Texterer.InputPlayerNaming();
            //Game starts here
            Texterer.GameStartText();
        }
    }
}
