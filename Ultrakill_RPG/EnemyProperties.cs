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
        public Filth() : base(name: "Filth", resistance: 1, health: 0.5, maxHealth: 0.5, attackList : new List<AttackType> { new AttackType("leap", 30, $"leaps and deals dmg"), new AttackType("bite", 30, $"bites and deals dmg")})
        {
        }
    }
    /// <summary>
    /// Defines the Stray enemy and its properties.
    /// </summary>
    internal class Stray : GameObject
    {

        public Stray() : base(name: "Stray", resistance: 1, health: 1.5, maxHealth: 1.5, attackList : new List<AttackType> { new AttackType("hellorb", 25, $"throws hellorb and deals dmg")})
        {
        }
    }
    /// <summary>
    /// Defines the Schism enemy and its properties.
    /// </summary>

    internal class Schism : GameObject
    {
        public Schism() : base(name: "Schism", resistance: 1, health: 5, maxHealth: 5, attackList : new List<AttackType> { new AttackType("vertical beam", 25, $"shoots vertical beam and deals dmg"), new AttackType("horizontal beam", 25, $"shoots horizontal beam and deals dmg")})
        {
        }
    }
    /// <summary>
    /// Defines the Cerberus enemy and its properties.
    /// </summary>
    internal class Cerberus : GameObject
    {
        public Cerberus() : base(name: "Cererus", resistance: 1, health: 22, maxHealth: 22, attackList : new List<AttackType> { new AttackType("stomp", 25, $"stomps on the ground and deals dmg"), new AttackType("explosive orb", 20, $"throws explosive orb and deals dmg"), new AttackType("Dash", 25, $"dashes and deals dmg")})
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
    }
}
