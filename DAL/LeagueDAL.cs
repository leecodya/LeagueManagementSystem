using LeagueManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LeagueManagementSystem.DAL
{
    /// <summary>
    /// Class to interact with the DB directly for the League table
    /// </summary>
    class LeagueDAL
    {
        /// <summary>
        /// Retrieves list of all Leagues from the DB
        /// </summary>
        /// <returns>Returns list of all leagues from the DB</returns>
        public List<League> GetLeagues()
        {
            List<League> _leagues = new List<League>();
            string selectStatement = "SELECT id, name, startDate, endDate, courseName FROM League;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            League _league = new League();
                            _league.ID = (int)reader["id"];
                            _league.Name = Convert.ToString(reader["name"]);
                            if (reader["startDate"].GetType() != typeof(DBNull))
                            {
                                _league.StartDate = Convert.ToDateTime(reader["startDate"]);
                            }
                            if (reader["endDate"].GetType() != typeof(DBNull))
                            {
                                _league.EndDate = Convert.ToDateTime(reader["endDate"]);
                            }
                            if (reader["courseName"].GetType() != typeof(DBNull))
                            {
                                _league.CourseName = Convert.ToString(reader["courseName"]);
                            }
                            _leagues.Add(_league);
                        }
                    }
                }
            }
            return _leagues;
        }
    }
}
