using LeageManagementSystem.DAL;
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
        /// <param name="selectedLeagueID">ID of the selected league</param>
        /// <param name="selectedPlayerID">ID of the select player</param>
        /// <param name="dateOfRound">Date the round took place</param>
        /// <param name="score">Score of round played by the particular player for the league</param>
        /// <returns>Returns if the round wass successfully added</returns>
        public bool AddRoundScore(int selectedLeagueID, int selectedPlayerID, string dateOfRound, int score)
        {
            return roundDAL.AddRound(selectedLeagueID, selectedPlayerID, dateOfRound, score);
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
    }
}
