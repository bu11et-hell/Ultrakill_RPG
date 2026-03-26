using System;
using System.Collections.Generic;
using System.Text;

namespace Ultrakill_RPG
{
    public class PlayerList
    {
        public static List<Player> players = new List<Player>();

        public static void AddPlayer(Player playerObject,int timesRepeated)
        {
            players.Insert(timesRepeated, playerObject);
        }
        public static void RemovePlayer(Player playerObject)
        {
            players.Remove(playerObject);
        }
    }
}
