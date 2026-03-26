using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ultrakill_RPG
{
    public class Enemy
    {

        protected string name;
        protected double resistance;
        protected double health;
        protected double damage;

        protected string UI_statusEnemyName;
        public void UI_NameAndStatus_Update()
        {
            this.UI_statusEnemyName = $"{name} {health}";
        }
        public void TakingDamage(double damage)
        {
            this.health = this.health - damage;
        }
        public Enemy(string name, double resistance, double health, double damage)
        {
            this.name = name;
            this.resistance = resistance;
            this.health = health;
            this.damage = damage;
        }
        public string GetName()
        {
            return this.name;
        }
        public double GetResistance() 
        {
            return this.resistance;
        }
        public double GetHealth() 
        {
            return this.health;
        }
        public double GetDamage() 
        {
            return this.damage;
        }
    }
    internal class Filth : Enemy
    {
        public Filth() : base(name : "Filth", resistance : 0, health : 0.5, damage : 30)
        {
        }

        public void AttackMassage()
        {
            Console.WriteLine($"{name} Leaps and bites dealing {damage} damage");
        }
    }
    internal class Stray : Enemy
    {

        public Stray() : base(name : "Stray", resistance : 0, health : 1.5, damage: 25)
        {
        }

        public void AttackMassage()
        {
            Console.WriteLine($"Throws a hellorb and {damage} deals");
        }
    }
    internal class Schism : Enemy
    {

        public Schism() : base(name: "Schism", resistance: 0, health: 5, damage: 25)
        {
        }

        public void AttackMassage()
        {
            Console.WriteLine($"Throws a hellorb and {damage} deals");
        }
    }
    internal class Cerberus : Enemy
    {

        public Cerberus() : base(name: "Cererus", resistance: 0, health: 22, damage: 25)
        {
        }

        public void AttackMassage()
        {
            Console.WriteLine($"Throws a hellorb and {damage} deals");
        }
    }

    public class EnemyCreator
    {
        public static void EnemyDeclorator(string enemyNameInput,int timesRepeated)
        {
            if (enemyNameInput.ToLower() == "filth")
            {
                EnemyList.AddEnemy(new Filth(),timesRepeated);
            }
            else if (enemyNameInput.ToLower() == "stray")
            {
                EnemyList.AddEnemy(new Stray(),timesRepeated);
            }
            else if (enemyNameInput.ToLower() == "schism")
            {
                EnemyList.AddEnemy(new Schism(),timesRepeated);
            }
            else if (enemyNameInput.ToLower() == "Cerberus")
            {
                EnemyList.AddEnemy(new Cerberus(),timesRepeated);
            }
            else
            {
                Console.WriteLine("you made a mistake try again");
                timesRepeated--;
                Texterer.InputEnemyNaming();
            }
        }
        

        /*public void Creator(string nameInput, int enemyCount)
        {
            switch (nameInput.ToLower())
            {

                case "filth":
                    new Filth();
                    EnemyList.EnemyListAdder();
                    break;
                case "filth":
                    new Filth();
                    EnemyList.EnemyListAdder();
                    break;
                case "filth":
                    new Filth();
                    EnemyList.EnemyListAdder();
                    break;
                default:
                    Console.WriteLine("you miss spelled");
                    break;
            }
        }*/
    }
}
