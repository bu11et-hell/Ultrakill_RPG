using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using Ultrakill_RPG;

namespace Ultrakill_RPG
{

}
/// <summary>
/// Defines the stats and parameters of V1.
/// </summary>
public class V1 : GameObject
{
    public V1() : base(name: "V1", resistance: 0, health: 100, attackList: new List<AttackType> { new AttackType("Piercer", 7.5), new AttackType("Projectile Boost", 3.5), new AttackType("Projectile Boost", 3.5), new AttackType("Railcannon", 8) })
    {

    }
}
/// <summary>
/// Defines the stats and parameters of V2.
/// </summary>
public class V2 : GameObject
{
    public V2() : base(name: "V2", resistance: 65, health: 100, attackList: new List<AttackType> { new AttackType("Piercer", 7.5), new AttackType("Projectile Boost", 3.5), new AttackType("Projectile Boost", 3.5), new AttackType("Railcannon", 8) })
    {

    }
}
/// <summary>
/// Defines the stats and parameters of Gutterman.
/// </summary>

public class Gutterman : GameObject
{
    public Gutterman() : base(name: "Gutterman", resistance: 75, health: 25, attackList: new List<AttackType> { new AttackType("Minigun", 20), new AttackType("Melle Attack", 35) })
    {

    }
}
/// <summary>
/// Defines the stats and parameters of Guttertank.
/// </summary>
public class Guttertank : GameObject
{
    public Guttertank() : base(name: "Guttertank", resistance: 0, health: 23, attackList: new List<AttackType> { new AttackType("Rocket", 35), new AttackType("Melle Attack", 35) })
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
    public static void PlayerDeclarator(string PlayerNameInput, int timesRepeated)
    {
        if (PlayerNameInput.ToLower() == "v1" || PlayerNameInput.ToLower() == "1")
        {
            PlayerList.AddPlayer(new V1(), timesRepeated);
        }
        else if (PlayerNameInput.ToLower() == "v2" || PlayerNameInput.ToLower() == "2")
        {
            PlayerList.AddPlayer(new V2(), timesRepeated);
        }
        else if (PlayerNameInput.ToLower() == "gutterman" || PlayerNameInput.ToLower() == "3")
        {
            PlayerList.AddPlayer(new Gutterman(), timesRepeated);
        }
        else if (PlayerNameInput.ToLower() == "guttertank" || PlayerNameInput.ToLower() == "4")
        {
            PlayerList.AddPlayer(new Guttertank(), timesRepeated);
        }
        else
        {
            Console.WriteLine("you made a mistake try again");
            timesRepeated--;
            Texterer.InputEnemyNaming();
        }
    }
}
