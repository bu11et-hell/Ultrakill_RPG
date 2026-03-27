using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Ultrakill_RPG
{
    public class Texterer
    {
        public static int selectedPlayerAction;

        public static int selectedPlayer;
        public static int selectedAttack;
        public static int selectedEnemy;

        internal static int enemyCount;
        internal static int playerCount;
        internal static string[] menuActions = {"attacks", "stats", "back"};
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
                player.UI_nameAndStatus_Update();
                Console.WriteLine($"{i}) {player.GetUIStatusPlayerName()}");
                i++;
            }
            i = 1;
            Console.WriteLine();
            Console.Write("Select Player: ");
            selectedPlayer = int.Parse(Console.ReadLine());
            if (selectedPlayer-1 < 0 || selectedPlayer > PlayerList.players.Count())
            {
                Console.Clear();
                Console.WriteLine("Select an actual player");
                PlayerSelectionMenu();
            }
            else
            {
                Console.Clear();
                PlayerActionsMenu();
            }
        }
        public static void PlayerActionsMenu()
        {
            int i = 1;
            int getBackToActionMenu;

            foreach (string actions in menuActions)
            {
                Console.WriteLine($"{i}) {actions}");
                i++;
            }
            i = 1;
            selectedPlayerAction = int.Parse(Console.ReadLine());
            if (menuActions[selectedPlayerAction-1].ToLower() == "attacks")
            {
                Console.Clear();
                PlayerAttacksMenu();
            }
            else if (menuActions[selectedPlayerAction-1].ToLower() == "stats")
            {
                Console.Clear();
                Console.WriteLine(PlayerList.players[selectedPlayer-1].GetStats()+"type 1 to get back to the action list");
                getBackToActionMenu = int.Parse(Console.ReadLine());
                if (getBackToActionMenu == 1)
                {
                    Console.Clear();
                    getBackToActionMenu = 0;
                    PlayerActionsMenu();
                }
                else
                {
                    Console.WriteLine("type 1 to get back");
                }
            }
            else if (menuActions[selectedPlayerAction-1].ToLower() == "back")
            {
                Console.Clear();
                PlayerSelectionMenu();
            }
        }
        public static void PlayerAttacksMenu()
        {
            Console.Clear();
            int i = 1;

            if (PlayerList.players[selectedPlayer-1].GetName() == "v1")
            {
                foreach (string attackType in V1.avavableAttackTypes)
                {
                    Console.WriteLine($"{i}) {attackType}");
                    i++;
                }
                i = 1;
            }
            else if (PlayerList.players[selectedPlayer-1].GetName() == "v2")
            {
                foreach (string attackType in V2.avavableAttackTypes)
                {
                    Console.WriteLine($"{i}) {attackType}");
                    i++;
                }
                i = 1;
            }
            else if (PlayerList.players[selectedPlayer-1].GetName() == "gutterman")
            {
                foreach (string attackType in Gutterman.avavableAttackTypes)
                {
                    Console.WriteLine($"{i}) {attackType}");
                    i++;
                }
                i = 1;
            }
            else if (PlayerList.players[selectedPlayer-1].GetName() == "guttertank")
            {
                foreach (string attackType in Guttertank.avavableAttackTypes)
                {
                    Console.WriteLine($"{i}) {attackType}");
                    i++;
                }
                i = 1;
            }
            selectedAttack = int.Parse(Console.ReadLine());
            if (selectedAttack - 1 < 0 )
            {

            }
        }
        public static void EnemySelectMenu()
        {
            
        }
    }
}