using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using Ultrakill_RPG;

namespace Ultrakill_RPG
{
    /// <summary>
    /// Defines the Filth enemy and its properties.
    /// </summary>
    internal class Filth : GameObject
    {
        public Filth() : base(name: "Filth", resistance: 0, health: 0.5, attackList : new List<AttackType> { new AttackType("leap", 30), new AttackType("bite", 30)})
        {
        }
    }
    /// <summary>
    /// Defines the Stray enemy and its properties.
    /// </summary>
    internal class Stray : GameObject
    {

        public Stray() : base(name: "Stray", resistance: 0, health: 1.5, attackList : new List<AttackType> { new AttackType("hellorb", 25)})
        {
        }
    }
    /// <summary>
    /// Defines the Schism enemy and its properties.
    /// </summary>

    internal class Schism : GameObject
    {
        public Schism() : base(name: "Schism", resistance: 0, health: 5, attackList : new List<AttackType> { new AttackType("vertical beam", 25), new AttackType("horizontal beam", 25)})
        {
        }
    }
    /// <summary>
    /// Defines the Cerberus enemy and its properties.
    /// </summary>
    internal class Cerberus : GameObject
    {
        public Cerberus() : base(name: "Cererus", resistance: 0, health: 22, attackList : new List<AttackType> { new AttackType("stomp", 25), new AttackType("explosive orb", 20), new AttackType("Dash", 25)})
        {
        }
    }
    public class EnemyCreator
    {
        /// <summary>
        /// Creates an enemy based on the name input and adds it to the enemy list.
        /// <param name="enemyNameInput">The name of the enemy to create.</param>
        /// <param name="timesRepeated">The number of times to create the enemy.</param>
        public static void EnemyDeclarator(string enemyNameInput, int timesRepeated)
        {
            if (enemyNameInput.ToLower() == "filth" || enemyNameInput.ToLower() == "1")
            {
                EnemyList.AddEnemy(new Filth(), timesRepeated);
            }
            else if (enemyNameInput.ToLower() == "stray" || enemyNameInput.ToLower() == "2")
            {
                EnemyList.AddEnemy(new Stray(), timesRepeated);
            }
            else if (enemyNameInput.ToLower() == "schism" || enemyNameInput.ToLower() == "3")
            {
                EnemyList.AddEnemy(new Schism(), timesRepeated);
            }
            else if (enemyNameInput.ToLower() == "cerberus" || enemyNameInput.ToLower() == "4")
            {
                EnemyList.AddEnemy(new Cerberus(), timesRepeated);
            }
            else
            {
                Console.WriteLine("you made a mistake try again");
                timesRepeated--;
                Texterer.InputEnemyNaming();
            }
        }
        /// <summary>
        /// Creates a random enemy and adds it to the enemy list a specified number of times.
        /// </summary>
        /// <param name="timesRepeated">How many enemies to add.</param>
        public void EnemyCreatorRandom(int timesRepeated)
        {
            for (int i = 0; i < timesRepeated; i++)
            {
                Random rnd = new Random();

                int enemyInt = rnd.Next(1, 4);

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
    }
}
