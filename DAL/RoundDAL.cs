using LeagueManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;

namespace LeageManagementSystem.DAL
{
    /// <summary>
    /// Class to interact directly with the Round table in the LeagueDatabase
    /// </summary>
    class RoundDAL
    {
        /// <summary>
        /// Adds a new record to the Round table
        /// </summary>
        /// <param name="selectedLeagueID">ID of the selected league</param>
        /// <param name="selectedPlayerID">ID of the select player</param>
        /// <param name="dateOfRound">Date the round took place</param>
        /// <param name="score">Score of round played by the particular player for the league</param>
        /// <returns>Returns if the round wass successfully added</returns>
        public bool AddRound(int selectedLeagueID, int selectedPlayerID, string dateOfRound, int score)
        {
            string insertStatement =
                "INSERT INTO Round " +
                "(leagueID, playerID, dateOfRound, score) " +
                "VALUES (@LeagueID, @PlayerID, @DateOfRound, @Score);";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    cmd.Parameters.Add("@LeagueID", System.Data.SqlDbType.Int);
                    cmd.Parameters["@LeagueID"].Value = selectedLeagueID;

                    cmd.Parameters.Add("@PlayerID", System.Data.SqlDbType.Int);
                    cmd.Parameters["@PlayerID"].Value = selectedPlayerID;

                    cmd.Parameters.Add("@DateOfRound", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@DateOfRound"].Value = dateOfRound;

                    cmd.Parameters.Add("@Score", System.Data.SqlDbType.Int);
                    cmd.Parameters["@Score"].Value = score;

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        /// <summary>
        /// Returns list of dates based on league and player selected
        /// </summary>
        /// <param name="selectedLeagueID">Selected League ID</param>
        /// <param name="selectedPlayerID">Selected Player ID</param>
        /// <returns>Returns list of dates based on league and player selected</returns>
        public List<string> GetDates(int selectedLeagueID, int selectedPlayerID)
        {
            List<string> _dates = new List<string>();
            string selectStatement = "SELECT dateOfRound " +
                                        "FROM Round " +
                                        "WHERE leagueID = @LeagueID " +
                                        "AND playerID = @PlayerID;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@LeagueID", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@LeagueID"].Value = selectedLeagueID;

                    selectCommand.Parameters.Add("@PlayerID", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@PlayerID"].Value = selectedPlayerID;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime dateOfRound = Convert.ToDateTime(reader["dateOfRound"]);
                            string _date = dateOfRound.ToString("yyyy-MM-dd");
                            _dates.Add(_date);
                        }
                    }
                }
            }
            return _dates;
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
            string updateStatement = "UPDATE Round " +
                "SET score = @UpdatedScore " +
                "WHERE leagueID = @LeagueID " +
                "AND playerID = @PlayerID " +
                "AND dateOfRound = @DateOfRound;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.Add("@LeagueID", System.Data.SqlDbType.Int);
                    cmd.Parameters["@LeagueID"].Value = leagueID;

                    cmd.Parameters.Add("@PlayerID", System.Data.SqlDbType.Int);
                    cmd.Parameters["@PlayerID"].Value = playerID;

                    cmd.Parameters.Add("@DateOfRound", System.Data.SqlDbType.Date);
                    cmd.Parameters["@DateOfRound"].Value = dateOfRound;

                    cmd.Parameters.Add("@UpdatedScore", System.Data.SqlDbType.Int);
                    cmd.Parameters["@UpdatedScore"].Value = updatedScore;

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
    }
}
