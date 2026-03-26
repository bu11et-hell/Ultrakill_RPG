using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ultrakill_RPG
{
    public class Texterer
    {
        internal static int enemyCount;
        internal static int playerCount;
        internal string[] menuActions = { "action", "Back", };
        internal bool playerCountRenderer = true;
        //Limit is set and is used in the loop for player object decloration
        public static void InputPlayerCount()
        {
            Console.WriteLine("How many players?");
            playerCount = int.Parse(Console.ReadLine());
        }
        public static void InputPlayerNaming()
        {
            Console.WriteLine("Enter players (V1/V2/Gutterman/Guttertank)");
            string playerNameInput;
            for (int i = 0; i < playerCount; i++)
            {
                playerNameInput = Console.ReadLine();
                PlayerCreator.PlayerDeclorator(playerNameInput, i);
            }
        }
        //Same but for the enemies
        public static void InputEnemyCount()
        {
            Console.WriteLine("How many enemies?");
            enemyCount = int.Parse(Console.ReadLine());
        }
        public static void InputEnemyNaming()
        {
            Console.WriteLine("Enter enemies (filth/stray/schism/cerberus)");
            string enemyNameInput;
            for (int i = 0; i < enemyCount; i++)
            {
                enemyNameInput = Console.ReadLine();
                EnemyCreator.EnemyDeclorator(enemyNameInput, i);
            }
        }
        public static void GameStartText()
        {
            Console.WriteLine("LET THE GAME START!!!\n\nSelect options by typing in their coresponding number");
        }
        public void PlayerSelectionMenu()
        {
            int i = 1;
            int selectedPlayer;
            foreach (Player player in PlayerList.players)
            {
                Console.WriteLine(i + player.GetUIStatusPlayerName());
                i++;
            }
            selectedPlayer = int.Parse(Console.ReadLine());
            if (selectedPlayer < 1)
            {
            }
        }
    }
}