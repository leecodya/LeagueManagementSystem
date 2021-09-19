using LeageManagementSystem.DAL;
using LeageManagementSystem.Model;
using System;
using System.Collections.Generic;

namespace LeageManagementSystem.Controller
{
    /// <summary>
    /// RoundController to interact with the RoundDAL
    /// </summary>
    class RoundController
    {
        private RoundDAL roundDAL;

        /// <summary>
        /// 0 parameter constructor for the RoundController
        /// </summary>
        public RoundController()
        {
            roundDAL = new RoundDAL();
        }

        /// <summary>
        /// Method to use AddRound method in roundDAL to add a new scored round
        /// </summary>
        /// <param name="newRound">Round to be added</param>
        /// <returns>Returns if the round wass successfully added</returns>
        public bool AddRoundScore(Round newRound)
        {
            return roundDAL.AddRound(newRound);
        }

        /// <summary>
        /// Returns list of dates based on league and player selected
        /// </summary>
        /// <param name="selectedLeagueID">Selected League ID</param>
        /// <param name="selectedPlayerID">Selected Player ID</param>
        /// <returns>Returns list of dates based on league and player selected</returns>
        public List<string> GetDates(int selectedLeagueID, int selectedPlayerID)
        {
            return roundDAL.GetDates(selectedLeagueID, selectedPlayerID);
        }

        /// <summary>
        /// Updates the score of a round
        /// </summary>
        /// <param name="leagueID">Selected league id</param>
        /// <param name="playerID">Selected player id</param>
        /// <param name="dateOfRound">Selected round date</param>
        /// <param name="updatedScore">Updated round score</param>
        /// <returns>Returns if the score was successfully updated or not</returns>
        public bool UpdateRoundScore(int leagueID, int playerID, string dateOfRound, int updatedScore)
        {
            return roundDAL.UpdateRoundScore(leagueID, playerID, dateOfRound, updatedScore);
        }
    }
}
