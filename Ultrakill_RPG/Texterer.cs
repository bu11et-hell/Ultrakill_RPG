using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Text;

namespace Ultrakill_RPG
{
    public class Texterer
    {
        public static int selectedPlayer;
        public static int selectedAttack;
        public static int selectedEnemy;

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
                PlayerCreator.PlayerDeclarator(playerNameInput, i);
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
                EnemyCreator.EnemyDeclarator(enemyNameInput, i);
            }
        }
        public static void GameStartText()
        {
            Console.Clear();
            Console.WriteLine("LET THE GAME START!!!\n\nSelect options by typing in their coresponding number");
        }
        public static void PlayerSelectionMenu()
        {
            int i = 1;

            Console.WriteLine();
            foreach (Player player in PlayerList.players)
            {
                Console.WriteLine($"{i} {player.GetUIStatusPlayerName()}");
                i++;
            }
            i = 1;
            selectedPlayer = int.Parse(Console.ReadLine());
            if (selectedPlayer-1 < 0 && selectedPlayer > PlayerList.players.Count())
            {
                Console.Clear();
                Console.WriteLine("Select an actual player");
                PlayerSelectionMenu();
            }
            else
            {
                Console.Clear();
            }
        }
        public static void PlayerActionsMenu()
        {
            int i = 1;

            if (PlayerList.players[selectedPlayer].GetName() == "V1")
            {
                foreach (string attackType in V1.avavableAttackTypes)
                {
                    Console.WriteLine($"{i} {attackType}");
                    i++;
                }
                i = 1;
            }
            else if (PlayerList.players[selectedPlayer].GetName() == "V2")
            {
                foreach (string attackType in V1.avavableAttackTypes)
                {
                    Console.WriteLine($"{i} {attackType}");
                    i++;
                }
                i = 1;
            }
            else if (PlayerList.players[selectedPlayer].GetName() == "Gutterman")
            {
                foreach (string attackType in V1.avavableAttackTypes)
                {
                    Console.WriteLine($"{i} {attackType}");
                    i++;
                }
                i = 1;
            }
            else if (PlayerList.players[selectedPlayer].GetName() == "Guttertank")
            {
                foreach (string attackType in V1.avavableAttackTypes)
                {
                    Console.WriteLine($"{i} {attackType}");
                    i++;
                }
                i = 1;
            }
        }
    }
}