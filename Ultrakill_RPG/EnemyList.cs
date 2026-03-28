using System;
using System.Collections.Generic;
using System.Text;

namespace Ultrakill_RPG
{
    public class EnemyList
    {
        /// <summary>
        /// List of all enemies in the current game.
        /// </summary>
        public static List<GameObject> enemies = new List<GameObject>();

        /// <summary>
        /// Adds an enemy to the list.
        /// </summary>
        /// <param name="enemyObject">The enemy object to add.</param>
        /// <param name="timesDeclared">How many times the enemy is to be created.</param>
        public static void AddEnemy(GameObject enemyObject, int timesDeclared)
        {
            enemies.Insert(timesDeclared, enemyObject);
        }
        /// <summary>
        /// Removes an enemy from the list.
        /// </summary>
        /// <param name="enemyObject">The enemy object to remove.</param>
        public static void RemoveEnemy(GameObject enemyObject) 
        { 
            enemies.Remove(enemyObject); 
        }
    }
}
