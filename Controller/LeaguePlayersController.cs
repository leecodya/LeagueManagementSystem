using LeageManagementSystem.DAL;
using LeageManagementSystem.Model;
using LeagueManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageManagementSystem.Controller
{
    class LeaguePlayersController
    {
        private LeaguePlayersDAL leaguePlayersDAL;

        public LeaguePlayersController()
        {
            leaguePlayersDAL = new LeaguePlayersDAL();
        }

        public List<Player> GetLeaguePlayers(int leagueID)
        {
            return leaguePlayersDAL.GetLeaguePlayers(leagueID);
        }
    }
}
