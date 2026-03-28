using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Ultrakill_RPG
{
    /// <summary>
    /// Defined the player and its properties.
    /// </summary>
    public class Player
    {
        protected string name;
        protected double resistance;
        protected double health;

        public List<AttackType> attackList;

        public string UI_statusPlayerName;
        /// <summary>
        /// Updated the player name and enterpolates the health for display in the UI.
        /// </summary>
        public void UI_nameAndStatus_Update()
        {
            this.UI_statusPlayerName = $"{name} Health: {health}";
        }
        /// <summary>
        /// Constructor for the Player class.
        /// </summary>
        /// <param name="name">Name of the player.</param>
        /// <param name="resistance">Resistance value of the player.</param>
        /// <param name="health">Health value of the player.</param>
        /// <param name="attackList">List of attacks available to the player.</param>
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
        /// <summary>
        /// Gets the player's name.
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return this.name;
        }
        /// <summary>
        /// Gets the player's resistance.
        /// </summary>
        /// <returns></returns>
        public double GetResistance()
        {
            return this.resistance;
        }
        /// <summary>
        /// Gets the player's health.
        /// </summary>
        /// <returns></returns>
        public double GetHealth()
        {
            return this.health;
        }
        /// <summary>
        /// Gets the player's stats in a string format for display in the UI.
        /// </summary>
        /// <returns></returns>
        public string GetStats()
        {
            return $"Health: {this.health}\nResistance: {this.resistance}\n";
        }
        /// <summary>
        /// Gets the player's name and health in a string format for display in the UI.
        /// </summary>
        /// <returns></returns>
        public string GetUIStatusPlayerName()
        {
            return this.UI_statusPlayerName;
        }
        /// <summary>
        /// Gets the player's list of attacks.
        /// </summary>
        /// <returns></returns>
        public List<AttackType> GetAttackList()
        {
            return attackList;
        }
    }
    /// <summary>
    /// Defines the stats and parameters of V1.
    /// </summary>
    public class V1 : Player
    {
        public V1() : base(name: "V1", resistance: 0, health: 100, attackList : new List<AttackType> { new AttackType("Piercer", 7.5), new AttackType("Projectile Boost", 3.5), new AttackType("Projectile Boost", 3.5), new AttackType("Railcannon", 8)})
        {

        }
    }
    /// <summary>
    /// Defines the stats and parameters of V2.
    /// </summary>
    public class V2 : Player
    {
        public V2() : base(name: "V2", resistance: 65, health: 100, attackList : new List<AttackType> { new AttackType("Piercer", 7.5), new AttackType("Projectile Boost", 3.5), new AttackType("Projectile Boost", 3.5), new AttackType("Railcannon", 8)})
        {

        }
    }
    /// <summary>
    /// Defines the stats and parameters of Gutterman.
    /// </summary>

    public class Gutterman : Player
    {
        public Gutterman() : base(name: "Gutterman", resistance: 75, health: 25, attackList : new List<AttackType> {new AttackType("Minigun", 20), new AttackType("Melle Attack", 35)} )
        {

        }
    }
    /// <summary>
    /// Defines the stats and parameters of Guttertank.
    /// </summary>
    public class Guttertank : Player
    {
        public Guttertank() : base(name: "Guttertank", resistance: 0, health: 23, attackList : new List<AttackType> {new AttackType("Rocket", 35), new AttackType("Melle Attack", 35)})
        {

        }
    }
    /// <summary>
    /// Class for player object creation.
    /// </summary>
    public class PlayerCreator
    {
        /// <summary>
        /// Creates the appropriate players based on a name or numerical input based on the menu.
        /// </summary>
        /// <param name="PlayerNameInput">Player name or numerical id.</param>
        /// <param name="timesRepeated">How many players of that type to create.</param>
        public static void PlayerDeclarator(string PlayerNameInput,int timesRepeated)
        {
            if (PlayerNameInput.ToLower() == "v1" || PlayerNameInput.ToLower() == "1")
            {
                PlayerList.AddPlayer(new V1(),timesRepeated);
            }
            else if (PlayerNameInput.ToLower() == "v2" || PlayerNameInput.ToLower() == "2")
            {
                PlayerList.AddPlayer(new V2(),timesRepeated);
            }
            else if (PlayerNameInput.ToLower() == "gutterman" || PlayerNameInput.ToLower() == "3")
            {
                PlayerList.AddPlayer(new Gutterman(),timesRepeated);
            }
            else if (PlayerNameInput.ToLower() == "guttertank" || PlayerNameInput.ToLower() == "4")
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
