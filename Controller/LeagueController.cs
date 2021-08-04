using LeagueManagementSystem.DAL;
using LeagueManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageManagementSystem.Controller
{
    /// <summary>
    /// LeagueController to interact with the LeagueDAL
    /// </summary>
    class LeagueController
    {
        private LeagueDAL leagueDAL;

        /// <summary>
        /// 0 parameter constructor for the LeagueController
        /// </summary>
        public LeagueController()
        {
            leagueDAL = new LeagueDAL();
        }

        /// <summary>
        /// Used to retrieve list of leagues from leagueDAL
        /// </summary>
        /// <returns>Returns list of leagues from LeagueDAL</returns>
        public List<League> GetLeagues()
        {
            return leagueDAL.GetLeagues();
        }
    }
}
