using System.Dynamic;

namespace Ultrakill_RPG
{
    public class Player
    {
        protected string name;
        protected double resistance;
        protected double healt;
        protected double damage;

        public string UI_statusPlayerName;
        public void UI_nameAndStatus_Update()
        {
            this.UI_statusPlayerName = $"{name} {healt}";
        }
        public Player(string name, double resistance, double healt, double damage)
        {

            this.name = name;
            this.resistance = resistance;
            this.healt = healt;
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
            return this.healt;
        }
        public double GetDamage()
        {
            return this.damage;
        }
        public string GetUIStatusPlayerName()
        {
            return this.UI_statusPlayerName;
        }
    }
    public class V1 : Player
    {
        public V1() : base(name: "V1", resistance: 0, healt: 100, damage: 4)
        {

        }
    }
    public class V2 : Player
    {
        public V2() : base(name: "V2", resistance: 65, healt: 100, damage: 4)
        {

        }
    }
    public class Gutterman : Player
    {
        public Gutterman() : base(name: "Gutterman", resistance: 75, healt: 25, damage: 10)
        {

        }
    }
    public class Guttertank : Player
    {
        public Guttertank() : base(name: "Guttertank", resistance: 0, healt: 23, damage: 35)
        {

        }
    }
    public class PlayerCreator
    {
        public static void PlayerDeclorator(string enemyNameInput,int timesRepeated)
        {
            if (enemyNameInput.ToLower() == "v1")
            {
                PlayerList.AddPlayer(new V1(),timesRepeated);
            }
            else if (enemyNameInput.ToLower() == "v2")
            {
                PlayerList.AddPlayer(new V2(),timesRepeated);
            }
            else if (enemyNameInput.ToLower() == "gutterman")
            {
                PlayerList.AddPlayer(new Gutterman(),timesRepeated);
            }
            else if (enemyNameInput.ToLower() == "guttertank")
            {
                PlayerList.AddPlayer(new Guttertank(),timesRepeated);
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