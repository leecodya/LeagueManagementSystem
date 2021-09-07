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
            string selectStatement = "SELECT id, name, startDate, endDate, courseName " +
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
                            myLeague.ID = Convert.ToInt32(reader["id"]);
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

        /// <summary>
        /// Updates old league information with new league information
        /// </summary>
        /// <param name="oldLeague">League information already in the system</param>
        /// <param name="newLeague">New league information to be saved over the old league information</param>
        /// <returns>Returns if the query is successful</returns>
        public bool UpdateLeague(League oldLeague, League newLeague)
        {
            string updateStatement = "UPDATE League " +
                "SET startDate = @NewStartDate," +
                "endDate = @NewEndDate, " +
                "courseName = @NewCourseName " +
                "WHERE id = @OldLeagueID " +
                "AND (startDate = @OldStartDate " +
                    "OR startDate IS NULL and @OldStartDate IS NULL) " +
                "AND (endDate = @OldEndDate " +
                    "OR endDate IS NULL and @OldEndDate IS NULL) " +
                "AND (courseName = @OldCourseName " +
                    "OR courseName IS NULL and @OldCourseName IS NULL)";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    if (newLeague.StartDate == null)
                    {
                        cmd.Parameters.AddWithValue("@NewStartDate", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@NewStartDate", newLeague.StartDate);
                    }

                    if (newLeague.EndDate == null)
                    {
                        cmd.Parameters.AddWithValue("@NewEndDate", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@NewEndDate", newLeague.EndDate);
                    }

                    if (newLeague.CourseName == "")
                    {
                        cmd.Parameters.AddWithValue("@NewCourseName", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@NewCourseName", newLeague.CourseName);
                    }

                    cmd.Parameters.AddWithValue("@OldLeagueID", oldLeague.ID);

                    if (oldLeague.StartDate == null)
                    {
                        cmd.Parameters.AddWithValue("@OldStartDate", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@OldStartDate", oldLeague.StartDate);
                    }

                    if (oldLeague.EndDate == null)
                    {
                        cmd.Parameters.AddWithValue("@OldEndDate", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@OldEndDate", oldLeague.EndDate);
                    }

                    if (oldLeague.CourseName == "")
                    {
                        cmd.Parameters.AddWithValue("@OldCourseName", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@OldCourseName", oldLeague.CourseName);
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
        /// Deletes league from the database
        /// </summary>
        /// <param name="leagueID">ID of league to be removed</param>
        /// <returns>Returns if the deletion was successful</returns>
        public bool DeleteLeague(int leagueID)
        {
            string deleteStatement = "DELETE FROM League " +
                                        "WHERE id = @LeagueID;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@LeagueID", leagueID);

                    int count = deleteCommand.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
    }
}
