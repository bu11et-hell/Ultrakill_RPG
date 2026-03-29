using System;
using System.Collections.Generic;
using System.Text;

namespace Ultrakill_RPG
{
    public class GameLogic
    {
        private 
        
        public static string AttackMassage(GameObject attackerObject, GameObject selectedObject, AttackType selectedAttack)
        {
            return $"{attackerObject.GetName()} used {selectedAttack.GetAttackName()} and dealt {selectedObject.damageTaken} dmg to {selectedObject.GetName()}";
        }
        /// <summary>
        /// Checks if the attack coming from the platers is correct.
        /// </summary>
        public static void PlayerAttackLogic(GameObject selectedPlayer, GameObject selectedEnemy, AttackType selectedAttack)
        {
            selectedPlayer.DealDamage(selectedPlayer, selectedEnemy, selectedAttack);
            AttackMassage(selectedPlayer, selectedEnemy, selectedAttack);
            Console.WriteLine($"The enemy is down to {selectedEnemy.GetHealth()} health");
            EnemyDeadChecker(selectedEnemy);
            EnemyRandomTargetAndAttack();
        }
        public static void EnemyRandomTargetAndAttack()
        {
            //attack choise rng
            Random rng = new Random();

            //player choise rng
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
        }
        public static void EnemyDeadChecker(GameObject enemy)
        {
            if (enemy.GetHealth() <= 0)
                EnemyList.RemoveEnemy(enemy);
        }
    }
}
