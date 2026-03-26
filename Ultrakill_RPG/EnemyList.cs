using System;
using System.Collections.Generic;
using System.Text;

namespace Ultrakill_RPG
{
    public class EnemyList
    {
        public static List<Enemy> enemies = new List<Enemy>();

        public static void AddEnemy(Enemy enemyObject, int timesDeclared)
        {
            enemies.Insert(timesDeclared, enemyObject);
        }
        public static void RemoveEnemy(Enemy enemyObject) 
        { 
            enemies.Remove(enemyObject); 
        }
    }
}
