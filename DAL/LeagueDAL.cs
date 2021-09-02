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

        /// <summary>
        /// Adds new league to the database
        /// </summary>
        /// <param name="newLeague">New league object to be added to the database</param>
        /// <returns>Returns if insertion was successful or not</returns>
        public bool AddLeague(League newLeague)
        {
            string insertStatement =
               "INSERT INTO League " +
               "(name, startDate, endDate, courseName) " +
               "VALUES (@Name, @StartDate, @EndDate, @CourseName);";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", newLeague.Name);

                    if (String.IsNullOrEmpty(newLeague.StartDate.ToString()))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@StartDate", newLeague.StartDate);
                    }

                    if (String.IsNullOrEmpty(newLeague.EndDate.ToString()))
                    {
                        cmd.Parameters.AddWithValue("@EndDate", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@EndDate", newLeague.EndDate);
                    }

                    if (String.IsNullOrEmpty(newLeague.CourseName.ToString()))
                    {
                        cmd.Parameters.AddWithValue("@CourseName", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@CourseName", newLeague.CourseName);
                    }

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        /// <summary>
        /// Returns league object from DB with the given leagueID
        /// </summary>
        /// <param name="leagueID">ID of league to retrieve info about</param>
        /// <returns>Returns league object from DB</returns>
        public League GetLeagueByID(int leagueID)
        {
            League myLeague = new League();
            string selectStatement = "SELECT name, startDate, endDate, courseName " +
                                        "FROM League " +
                                        "WHERE id = @ID;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@ID", leagueID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            myLeague.Name = reader["name"].ToString();
                            
                            if (reader["startDate"].GetType() == typeof(DBNull))
                            {
                                myLeague.StartDate = null;
                            }
                            else
                            {
                                myLeague.StartDate = Convert.ToDateTime(reader["startDate"]);
                            }

                            if (reader["endDate"].GetType() == typeof(DBNull))
                            {
                                myLeague.EndDate = null;
                            }
                            else
                            {
                                myLeague.EndDate = Convert.ToDateTime(reader["endDate"]);
                            }

                            if (reader["courseName"].GetType() == typeof(DBNull))
                            {
                                myLeague.CourseName = "";
                            }
                            else
                            {
                                myLeague.CourseName = reader["courseName"].ToString();
                            }
                        }
                    }
                }
            }
            return myLeague;
        }
    }
}
