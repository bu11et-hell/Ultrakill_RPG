using System;
using System.Collections.Generic;
using System.Text;

namespace Ultrakill_RPG
{
    public class GameLogic
    {
        /// <summary>
        /// Checks if the attack coming from the platers is correct.
        /// </summary>
        public static void PlayerAttackLogic(GameObject selectedPlayer, GameObject selectedEnemy, AttackType selectedAttack)
        {
            selectedEnemy.TakeDamage();
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
    }
}
