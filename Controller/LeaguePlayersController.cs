using LeageManagementSystem.DAL;
using LeagueManagementSystem.Model;
using System.Collections.Generic;

namespace LeageManagementSystem.Controller
{
    class LeaguePlayersController
    {
        private LeaguePlayersDAL leaguePlayersDAL;

        public LeaguePlayersController()
        {
            leaguePlayersDAL = new LeaguePlayersDAL();
        }

        /// <summary>
        /// Retrieves list of players that are registered for that particular league
        /// </summary>
        /// <param name="leagueID">IS of league to retrieve players from</param>
        /// <returns>Returns a list of players that are registered for that particular league</returns>
        public List<Player> GetLeaguePlayers(int leagueID)
        {
            return leaguePlayersDAL.GetLeaguePlayers(leagueID);
        }

        /// <summary>
        /// Adds selected player to selected league
        /// </summary>
        /// <param name="leagueID">Id of selected league to add player</param>
        /// <param name="playerID">Id of selected player to add to the league</param>
        /// <returns>Returns if insertion was successful</returns>
        public bool AddPlayerToLeague(int leagueID, int playerID)
        {
            return leaguePlayersDAL.AddLeaguePlayer(leagueID, playerID);
        }
    }
}
