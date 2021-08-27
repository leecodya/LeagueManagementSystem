using LeagueManagementSystem.DAL;
using LeagueManagementSystem.Model;
using System.Collections.Generic;

namespace LeagueManagementSystem.Controller
{
    /// <summary>
    /// Controller to interact with the player DAL
    /// </summary>
    class PlayerController
    {
        private PlayerDAL playerDAL;

        /// <summary>
        /// 0 parameter constructor
        /// </summary>
        public PlayerController()
        {
            playerDAL = new PlayerDAL();
        }

        /// <summary>
        /// Uses the playerDAL to add a player into the system
        /// </summary>
        /// <param name="firstName">First name of player to be registered</param>
        /// <param name="lastName">Last name of player to be registered</param>
        /// <param name="pdgaNum">PDGA number of player to be registered if applicable</param>
        /// <returns>Returns if the player was successfully added to the database or not</returns>
        public bool AddPlayerToSystem(string firstName, string lastName, string pdgaNum)
        {
            return playerDAL.AddPlayerToSystem(firstName, lastName, pdgaNum);
        }

        /// <summary>
        /// Retrieves all the players that are within the system, aka in the Player table
        /// </summary>
        /// <returns>Returns list of players within the Player table</returns>
        public List<Player> GetSystemPlayers()
        {
            return playerDAL.GetSystemPlayers();
        }

        /// <summary>
        /// Retrieves player from DB with the player ID passed in
        /// </summary>
        /// <param name="playerID">Player ID passed in order to retrieve the proper player from the DB</param>
        /// <returns>Returns player with given playerID</returns>
        public Player GetPlayerByID(int playerID)
        {
            return playerDAL.GetPlayerByID(playerID);
        }
    }
}
