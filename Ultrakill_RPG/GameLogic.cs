using System;
using System.Collections.Generic;
using System.Text;

namespace Ultrakill_RPG
{
    public class GameLogic
    {
        private static GameObject enemyPlayerSelection;
        private static AttackType enemyAttackSelection;
        public static string AttackMassage(GameObject attackerObject, GameObject selectedObject, AttackType selectedAttack)
        {
            return $"{attackerObject.GetName()} used {selectedAttack.GetAttackName()} and dealt {selectedObject.damageTaken} dmg to {selectedObject.GetName()}\n";
        }
        /// <summary>
        /// Checks if the attack coming from the platers is correct.
        /// </summary>
        public static void PlayerAttackLogic(GameObject selectedPlayer, GameObject selectedEnemy, AttackType selectedAttack)
        {
            selectedPlayer.DealDamage(selectedPlayer, selectedEnemy, selectedAttack);
            Console.WriteLine(AttackMassage(selectedPlayer, selectedEnemy, selectedAttack));
            Console.WriteLine($"The enemy is at to {selectedEnemy.GetHealth()} health");
            EnemyDeadChecker(selectedEnemy, selectedPlayer);
        }
        public static void EnemyAttackLogic(GameObject selectedEnemy, GameObject selectedPlayer)
        {
            EnemyRandomTargetAndAttack(selectedEnemy);
            selectedEnemy.DealDamage(selectedEnemy, enemyPlayerSelection, enemyAttackSelection);
            Console.WriteLine(AttackMassage(selectedEnemy, enemyPlayerSelection, enemyAttackSelection));
            Console.WriteLine($"The Player is at to {enemyPlayerSelection.GetHealth()} health");
            PlayerDeadChecker(enemyPlayerSelection);
            GameEndedCheck();
        }
        public static void EnemyRandomTargetAndAttack(GameObject selectedEnemy)
        {
            //attack choise rng
            Random rng = new Random();

            int EnemyPlayerSelectionInt = rng.Next(0, PlayerList.players.Count());
            enemyPlayerSelection = PlayerList.players[EnemyPlayerSelectionInt];
            //player choise rng
            int EnemyAttackSelectionInt = rng.Next(0, selectedEnemy.attackList.Count());
            enemyAttackSelection = selectedEnemy.attackList[EnemyPlayerSelectionInt];
        }
        public static void GameEndedCheck()
        {
            if (PlayerList.players.Count() == 0)
            {
                Console.WriteLine("You have lost");
            }
            else if (EnemyList.enemies.Count() == 0)
            {
                Console.WriteLine("You have won");
            }
            else
            {
                Texterer.PlayerSelectionMenu();
            }
        }
        public static void PlayerDeadChecker(GameObject player)
        {
            if (player.GetHealth() <= 0)
            {
                PlayerList.RemovePlayer(player);
            }
        }
        public static void EnemyDeadChecker(GameObject enemy, GameObject player)
        {
            if (enemy.GetHealth() <= 0)
            {
                EnemyList.RemoveEnemy(enemy);   
            }
            else
            {
                EnemyAttackLogic(enemy, player);
            }
        }
    }
}
