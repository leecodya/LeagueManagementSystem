﻿using LeagueManagementSystem.DAL;
using LeagueManagementSystem.Model;
using System.Collections.Generic;

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

        /// <summary>
        /// Adds new league to the database
        /// </summary>
        /// <param name="newLeague">New league object to be added to the database</param>
        /// <returns>Returns if insertion was successful or not</returns>
        public bool AddLeague(League newLeague)
        {
            return leagueDAL.AddLeague(newLeague);
        }

        /// <summary>
        /// Returns league object from leagueDAL with the given leagueID
        /// </summary>
        /// <param name="leagueID">ID of league to retrieve info about</param>
        /// <returns>Returns league object from leagueDAL</returns>
        public League GetLeagueByID(int leagueID)
        {
            return leagueDAL.GetLeagueByID(leagueID);
        }

        public bool UpdateLeague(League oldLeague, League newLeague)
        {
            return leagueDAL.UpdateLeague(oldLeague, newLeague);
        }
    }
}
