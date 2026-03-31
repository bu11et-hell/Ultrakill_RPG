using System;
using System.Collections.Generic;
using System.Text;

namespace Ultrakill_RPG
{
    /// <summary>
    /// Defines the list of all active players and appropriate methods for modifying it.
    /// </summary>
    public class PlayerList
    {
        public static List<GameObject> players = new List<GameObject>();

        /// <summary>
        /// Adds a player to the list.
        /// </summary>
        /// <param name="playerObject">The player object to add.</param>
        /// <param name="timesRepeated">The index at which to insert the player.</param>
        public static void AddPlayer(GameObject playerObject)
        {
            players.Add(playerObject);
        }
        /// <summary>
        ///  Removes a player from the list.
        /// </summary>
        /// <param name="playerObject"></param>
        public static void RemovePlayer(GameObject playerObject)
        {
            players.Remove(playerObject);
        }
    }
}
