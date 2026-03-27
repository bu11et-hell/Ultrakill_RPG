using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Ultrakill_RPG
{
    public class Player
    {
        protected string name;
        protected double resistance;
        protected double health;

        List<AttackType> attackList;
        

        public string UI_statusPlayerName;
        public void UI_nameAndStatus_Update()
        {
            this.UI_statusPlayerName = $"{name} Health: {health}";
        }
        public Player(string name, double resistance, double health, List<AttackType> attackList)
        {
            this.name = name;
            this.resistance = resistance;
            this.healt = health;
            this.attackList = new attackList;
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
        public string GetUIStatusPlayerName()
        {
            return this.UI_statusPlayerName;
        }
    }
    public class V1 : Player
    {
        public static List<string> avavableAttackTypes = new List<string> {"Piercer (7.5 dmg)", "Projectile Boost (3.5 dmg)", "Railcannon (8 dmg)"};
        public V1() : base(name: "V1", resistance: 0, health: 100)
        {

        }
    }
    public class V2 : Player
    {
        public static List<string> avavableAttackTypes = new List<string> { "Piercer (7.5 dmg)", "Projectile Boost (3.5 dmg)", "Railcannon (8 dmg)" };
        public V2() : base(name: "V2", resistance: 65, health: 100)
        {

        }
    }
    public class Gutterman : Player
    {
        public static List<string> avavableAttackTypes = new List<string> {"Minigun (20 dmg)", "Melle Attack(35 dmg)"};
        public Gutterman() : base(name: "Gutterman", resistance: 75, health: 25)
        {
        }
    }
    public class Guttertank : Player
    {
        public static List<string> avavableAttackTypes = new List<string> {"Rocket (35 dmg)", "Melle Attack/Faust Panzer(35 dmg)" };
        public Guttertank() : base(name: "Guttertank", resistance: 0, health: 23)
        {
        }
    }
    public class PlayerCreator
    {
        public static void PlayerDeclarator(string PlayerNameInput,int timesRepeated)
        {
            if (PlayerNameInput.ToLower() == "v1")
            {
                PlayerList.AddPlayer(new V1(),timesRepeated);
            }
            else if (PlayerNameInput.ToLower() == "v2")
            {
                PlayerList.AddPlayer(new V2(),timesRepeated);
            }
            else if (PlayerNameInput.ToLower() == "gutterman")
            {
                PlayerList.AddPlayer(new Gutterman(),timesRepeated);
            }
            else if (PlayerNameInput.ToLower() == "guttertank")
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
