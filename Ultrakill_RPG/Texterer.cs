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
        public static string[] enemyOptions = {"attack?", "show stats", "back"};

        public static int selectedEnemyOption;
        public static int selectedPlayerAction;
        //Player to be used in all checks
        public static Player selectedPlayer;
        public static AttackType selectedAttack;
        public static Enemy selectedEnemy;
        //Temporary ones to be used in defining the Player type ones
        public static int selectedPlayerInt;
        public static int selectedAttackInt;
        public static int selectedEnemyInt;

        internal static int enemyCount;
        //Integare containing the number of players we have.
        internal static int playerCount;
        // String list of player actions.
        internal static string[] menuActions = {"attacks", "stats", "back"};
        internal bool playerCountRenderer = true;
        //Limit is set and is used in the loop for player object decloration
        /// <summary>
        /// Method InputPlayerCount, asks the user how many players characters they want in their game
        /// </summary>
        public static void InputPlayerCount()
        {
            Console.WriteLine("How many players?");
            playerCount = int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Method InputPlayerNaming, asks the user what player character they want to have in the squad.
        /// it has a loop in it that will create new player objects of the coresponding type and add them
        /// to the list with players
        /// </summary>
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
        /// <summary>
        /// Method InputEnemyCount, asks the user how many enemies characters they want in their game
        /// </summary>
        public static void InputEnemyCount()
        {
            Console.WriteLine("How many enemies?");
            enemyCount = int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Method InputEnemyNaming, asks the user what enemy character they want to have in the squad.
        /// it has a loop in it that will create new enemy objects of the coresponding type and add them
        /// to the list with enemies
        /// </summary>
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
        /// <summary>
        /// Printed to let us now that the game has started
        /// </summary>
        public static void GameStartText()
        {
            Console.Clear();
            Console.WriteLine("LET THE GAME START!!!\n\nSelect options by typing in their coresponding number");
        }
        /// <summary>
        /// Selects a player to act with.
        /// </summary>
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
            selectedPlayerInt = int.Parse(Console.ReadLine());
            if (selectedPlayerInt - 1 < 0 || selectedPlayerInt > PlayerList.players.Count())
            {
                Console.Clear();
                Console.WriteLine("Select an actual player");
                PlayerSelectionMenu();
            }
            else
            {
                Console.Clear();
                selectedPlayer = PlayerList.players[selectedPlayerInt - 1];
                PlayerActionsMenu();
            }
        }
        /// <summary>
        /// Action selection menu for the players. Choose between attacks, stats and going back into the previous menu.
        /// </summary>
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
            if (selectedPlayerAction - 1 < 0 || selectedPlayerAction > menuActions.Length)
            {
                Console.Clear();
                Console.WriteLine("not a valid option");
                PlayerActionsMenu();
            }
            else
            {
                if (menuActions[selectedPlayerAction - 1].ToLower() == "attacks")
                {
                    Console.Clear();
                    PlayerAttacksMenu();
                }
                else if (menuActions[selectedPlayerAction - 1].ToLower() == "stats")
                {
                    Console.Clear();
                    Console.WriteLine(selectedPlayer.GetStats() + "type 1 to get back to the action list");
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
                else if (menuActions[selectedPlayerAction - 1].ToLower() == "back")
                {
                    Console.Clear();
                    PlayerSelectionMenu();
                }
            }
        }
        /// <summary>
        /// Shows attacks menu avalible for selected player character (For example Piercer for V1)
        /// </summary>
        public static void PlayerAttacksMenu()
        {
            Console.Clear();
            int i = 1;

            if (selectedPlayer.GetName() == "v1")
            {
                foreach (AttackType attackType in selectedPlayer.GetAttackList())
                {
                    Console.WriteLine($"{i}) {attackType.GetAttackName()}");
                    i++;
                }
                i = 1;
            }
            else if (selectedPlayer.GetName() == "v2")
            {
                foreach (AttackType attackType in selectedPlayer.GetAttackList())
                {
                    Console.WriteLine($"{i}) {attackType.GetAttackName()}");
                    i++;
                }
                i = 1;
            }
            else if (selectedPlayer .GetName() == "gutterman")
            {
                foreach (AttackType attackType in selectedPlayer.GetAttackList())
                {
                    Console.WriteLine($"{i}) {attackType.GetAttackName()}");
                    i++;
                }
                i = 1;
            }
            else if (selectedPlayer.GetName() == "guttertank")
            {
                foreach (AttackType attackType in selectedPlayer.GetAttackList())
                {
                    Console.WriteLine($"{i}) {attackType.GetAttackName()}");
                    i++;
                }
                i = 1;
            }
            selectedAttackInt = int.Parse(Console.ReadLine());
            if (selectedAttackInt - 1 < 0 || selectedAttackInt > selectedPlayer.attackList.Count())
            {
                Console.Clear();
                Console.WriteLine("Not a valid option");
                Texterer.PlayerAttacksMenu();
            }
            else
            { }
        }
        /// <summary>
        /// Select the enemy which the selected player is going to attack.
        /// </summary>
        public static void EnemySelectionMenu()
        {
            int i = 1;

            Console.WriteLine();
            foreach (Enemy enemy in EnemyList.enemies)
            {
                enemy.UI_nameAndStatus_Update();
                Console.WriteLine($"{i}) {enemy.GetUIStatusEnemyName()}");
                i++;
            }
            i = 1;
            Console.WriteLine();
            Console.Write("Select Player: ");
            selectedEnemyInt = int.Parse(Console.ReadLine());
            if (selectedEnemyInt - 1 < 0 || selectedEnemyInt > EnemyList.enemies.Count())
            {
                Console.Clear();
                Console.WriteLine("Select an actual Enemy");
                EnemySelectionMenu();
            }
            else
            {
                Console.Clear();
                selectedEnemy = EnemyList.enemies[selectedEnemyInt - 1];
                
            }
        }
        public static void enemyActionMenu()
        {
            int i = 1;
            int GetBackToOptions = 0;

            foreach (string option in enemyOptions)
            {
                Console.WriteLine($"{i} {option}");
            }
            selectedEnemyOption = int.Parse(Console.ReadLine());
            if (selectedEnemyOption - 1 < 0 || selectedEnemyOption > selectedEnemy.attackList.Count())
            {
                Console.Clear();
                Console.WriteLine("Selecet propper option");
            }
        }
    }
}