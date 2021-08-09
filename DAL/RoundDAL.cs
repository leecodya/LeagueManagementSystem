using LeagueManagementSystem.DAL;
using System.Data.SqlClient;

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

                    cmd.Parameters.Add("@DateOfRound", System.Data.SqlDbType.DateTime);
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
    }
}
