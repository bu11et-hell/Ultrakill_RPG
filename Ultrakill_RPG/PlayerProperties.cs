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
            this.health = health;
            this.attackList = attackList;
        }
        /*
        public Player(string name, double resistance, double health)
        {
            this.name = name;
            this.resistance = resistance;
            this.health = health;
        }
        */
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

        public List<AttackType> GetAttackList()
        {
            return attackList;
        }
    }
    public class V1 : Player
    {
        public V1() : base(name: "V1", resistance: 0, health: 100, attackList : new List<AttackType> { new AttackType("Piercer", 7.5), new AttackType("Projectile Boost", 3.5), new AttackType("Projectile Boost", 3.5), new AttackType("Railcannon", 8)})
        {

        }
    }
    public class V2 : Player
    {
        public V2() : base(name: "V2", resistance: 65, health: 100, attackList : new List<AttackType> { new AttackType("Piercer", 7.5), new AttackType("Projectile Boost", 3.5), new AttackType("Projectile Boost", 3.5), new AttackType("Railcannon", 8)})
        {

        }
    }
    public class Gutterman : Player
    {
        public Gutterman() : base(name: "Gutterman", resistance: 75, health: 25, attackList : new List<AttackType> {new AttackType("Minigun", 20), new AttackType("Melle Attack", 35)} )
        {
        }
    }
    public class Guttertank : Player
    {
        public Guttertank() : base(name: "Guttertank", resistance: 0, health: 23, attackList : new List<AttackType> {new AttackType("Rocket", 35), new AttackType("Melle Attack", 35)})
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
