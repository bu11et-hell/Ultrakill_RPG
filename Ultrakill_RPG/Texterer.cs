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
        public static string[] enemyOptions = {"attack?", "view stats", "back"};

        public static int selectedEnemyOption;
        public static int selectedPlayerAction;
        //Player to be used in all checks
        public static GameObject selectedPlayer;
        public static AttackType selectedAttack;
        public static GameObject selectedEnemy;
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
        public static void RandomEnemiesQuestion()
        {
            string answer;
            Console.WriteLine("do you want random enemies?");
            answer = Console.ReadLine();
            if (answer is "yes" or "y" or "1")
            {
               // EnemyCreatorRandom(enemyCount);
            }
            else
            {
                InputEnemyNaming();
            }
        }
        /// <summary>
        /// Creates a random enemy and adds it to the enemy list a specified number of times.
        /// </summary>
        public static void EnemyCreatorRandom()
        {

            Random rnd = new Random();
            int timesRepeated = rnd.Next(1, 20);
            
            for (int i = 0; i < timesRepeated; i++)
            {
                int enemyInt = rnd.Next(1, 5);
                
                if (enemyInt == 1)
                {
                    EnemyList.AddEnemy(new Filth(), i);
                }
                else if (enemyInt == 2)
                {
                    EnemyList.AddEnemy(new Stray(), i);
                }
                else if (enemyInt == 3)
                {
                    EnemyList.AddEnemy(new Schism(), i);
                }
                else if (enemyInt == 4)
                {
                    EnemyList.AddEnemy(new Cerberus(), i);
                }
            }
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
            foreach (GameObject player in PlayerList.players)
            {
                player.UI_nameAndStatus_Update();
                Console.WriteLine($"{i}) {player.GetUIStatusName()}");
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
                if (PlayerList.players[selectedPlayerInt - 1].GetHealth() <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Player is dead, Please choose another one");
                    PlayerSelectionMenu();
                }
                else
                {
                    Console.Clear();
                    selectedPlayer = PlayerList.players[selectedPlayerInt - 1];
                    PlayerActionsMenu();
                }
            }
        }
        /// <summary>
        /// Action selection menu for the players. Choose between attacks, stats and going back into the previous menu.
        /// </summary>
        public static void PlayerActionsMenu()
        {
            int i = 1;

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
                    PlayerStatViewerMenu();
                }
                else if (menuActions[selectedPlayerAction - 1].ToLower() == "back")
                {
                    Console.Clear();
                    PlayerSelectionMenu();
                }
            }
        }
        public static void PlayerStatViewerMenu()
        {
            int getBackToActionMenu;

            
                Console.Clear();
                Console.WriteLine($"{selectedPlayer.GetStats()} type 1 to get back to the action list");
                getBackToActionMenu = int.Parse(Console.ReadLine());
                if (getBackToActionMenu == 1)
                {
                    Console.Clear();
                    getBackToActionMenu = 0;
                    PlayerActionsMenu();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("type 1 to get back");
                    PlayerStatViewerMenu();
                }
        }
        /// <summary>
        /// Shows attacks menu avalible for selected player character (For example Piercer for V1)
        /// </summary>
        public static void PlayerAttacksMenu()
        {
            Console.Clear();
            int i = 1;

            if (selectedPlayer.GetName().ToLower() == "v1")
            {
                foreach (AttackType attackType in selectedPlayer.GetAttackList())
                {
                    Console.WriteLine($"{i}) {attackType.GetAttackName()} ({attackType.GetAttackDamage()} dmg)");
                    i++;
                }
                i = 1;
            }
            else if (selectedPlayer.GetName().ToLower() == "v2")
            {
                foreach (AttackType attackType in selectedPlayer.GetAttackList())
                {
                    Console.WriteLine($"{i}) {attackType.GetAttackName()} ({attackType.GetAttackDamage()} dmg)");
                    i++;
                }
                i = 1;
            }
            else if (selectedPlayer .GetName().ToLower() == "gutterman")
            {
                foreach (AttackType attackType in selectedPlayer.GetAttackList())
                {
                    Console.WriteLine($"{i}) {attackType.GetAttackName()} ({attackType.GetAttackDamage()} dmg)");
                    i++;
                }
                i = 1;
            }
            else if (selectedPlayer.GetName().ToLower() == "guttertank")
            {
                foreach (AttackType attackType in selectedPlayer.GetAttackList())
                {
                    Console.WriteLine($"{i}) {attackType.GetAttackName()} ({attackType.GetAttackDamage()} dmg)");
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
            {
                selectedAttack = selectedPlayer.attackList[selectedAttackInt - 1];
                EnemySelectionMenu();
            }
        }
        /// <summary>
        /// Select the enemy which the selected player is going to attack.
        /// </summary>
        public static void EnemySelectionMenu()
        {
            Console.Clear();
            int i = 1;
            int getBackToPlayerAction;

            Console.WriteLine();
            foreach (GameObject enemy in EnemyList.enemies)
            {
                enemy.UI_nameAndStatus_Update();
                Console.WriteLine($"{i}) {enemy.GetUIStatusName()}");
                i++;
            }
            i = 1;
            Console.WriteLine();
            Console.Write("Select Enemy: ");
            selectedEnemyInt = int.Parse(Console.ReadLine());
            if (selectedEnemyInt - 1 < 0 || selectedEnemyInt > EnemyList.enemies.Count())
            {
                Console.Clear();
                Console.WriteLine("Select an actual Enemy");
                EnemySelectionMenu();
            }
            else
            {
                if (EnemyList.enemies[selectedEnemyInt - 1].GetHealth() <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Enemy is already dead. Please choose another option");
                    EnemySelectionMenu();
                }
                    Console.Clear();
                    selectedEnemy = EnemyList.enemies[selectedEnemyInt - 1];
                    EnemyActionMenu();
            }
        }
        public static void EnemyActionMenu()
        {
            int i = 1;
            int getBackToOptions = 0;

            foreach (string option in enemyOptions)
            {
                Console.WriteLine($"{i}) {option}");
                i++;
            }
            selectedEnemyOption = int.Parse(Console.ReadLine());
            if (selectedEnemyOption - 1 < 0 || selectedEnemyOption > enemyOptions.Length)
            {
                Console.Clear();
                Console.WriteLine("Selecet propper option");
            }
            else
            {
                if (enemyOptions[selectedEnemyOption - 1] == "attack?")
                {
                    Console.Clear();
                    GameLogic.PlayerAttackLogic(selectedPlayer, selectedEnemy, selectedAttack);
                }
                else if (enemyOptions[selectedEnemyOption - 1] == "view stats")
                {
                    EnemyStatViewerMenu();
                }
                else if (enemyOptions[selectedEnemyOption - 1] == "back")
                {
                    Console.Clear();
                    EnemySelectionMenu();
                }
            }
        }
        public static void EnemyStatViewerMenu()
        {
            int getBackToOptions = 0;
            
            Console.Clear();
            Console.WriteLine($"{selectedEnemy.GetStats()} type 1 to get back to the action list");
            getBackToOptions = int.Parse(Console.ReadLine());
            if (getBackToOptions == 1)
            {
                Console.Clear();
                getBackToOptions = 0;
                EnemyActionMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("type 1 to get back");
                EnemyStatViewerMenu();
            }
        }
    }
}