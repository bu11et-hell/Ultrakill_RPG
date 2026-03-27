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

        protected string UI_statusEnemyName;
        public void UI_NameAndStatus_Update()
        {
            this.UI_statusEnemyName = $"{name} {health}";
        }
        public void TakingDamage(double damage)
        {
            this.health = this.health - damage;
        }
        public Enemy(string name, double resistance, double health)
        {
            this.name = name;
            this.resistance = resistance;
            this.health = health;
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
    }
    internal class Filth : Enemy
    {
        public Filth() : base(name : "Filth", resistance : 0, health : 0.5)
        {
        }

        public void AttackMassage()
        {
            Console.WriteLine($"{name} Leaps and bites dealing  damage");
        }
    }
    internal class Stray : Enemy
    {

        public Stray() : base(name : "Stray", resistance : 0, health : 1.5)
        {
        }

        public void AttackMassage()
        {
            Console.WriteLine($"Throws a hellorb and  deals");
        }
    }
    internal class Schism : Enemy
    {

        public Schism() : base(name: "Schism", resistance: 0, health: 5)
        {
        }

        public void AttackMassage()
        {
            Console.WriteLine($"Throws a hellorb and  deals");
        }
    }
    internal class Cerberus : Enemy
    {

        public Cerberus() : base(name: "Cererus", resistance: 0, health: 22)
        {
        }

        public void AttackMassage()
        {
            Console.WriteLine($"Throws a hellorb and  deals");
        }
    }

    public class EnemyCreator
    {
        public static void EnemyDeclarator(string enemyNameInput,int timesRepeated)
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
            else if (enemyNameInput.ToLower() == "cerberus")
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

        public class voic EnemyCreatorRandom(int timesRepeated){
        for (int i = 0; i < enemies; i ++){
            Random rnd = new Random();
            
            int enemyInt = rnd.Next(1, 4);
            
            if (enemyInt == 1)
            {
                EnemyList.AddEnemy(new Filth(),timesRepeated);
            }
            else if (enemyInt == 2)
            {
                EnemyList.AddEnemy(new Stray(),timesRepeated);
            }
            else if (enemyInt == 3)
            {
                EnemyList.AddEnemy(new Schism(),timesRepeated);
            }
            else if (enemyInt == 4)
            {
                EnemyList.AddEnemy(new Cerberus(),timesRepeated);
            }
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
