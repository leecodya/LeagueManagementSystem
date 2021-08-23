using LeagueManagementSystem.DAL;
using LeagueManagementSystem.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LeageManagementSystem.DAL
{
    /// <summary>
    /// Class to interact with LeaguePlayers table in the LeagueDatabase
    /// </summary>
    class LeaguePlayersDAL
    {
        /// <summary>
        /// Retrieves list of players that are registered for that particular league
        /// </summary>
        /// <param name="leagueID">IS of league to retrieve players from</param>
        /// <returns>Returns a list of players that are registered for that particular league</returns>
        public List<Player> GetLeaguePlayers(int leagueID)
        {
            List<Player> _leaguePlayers = new List<Player>();
            string selectStatement = "select id, firstName, lastName, pdgaNum from Player p " +
                                        "join LeaguePlayers lp " +
                                        "on p.id = lp.playerID " +
                                        "where lp.leagueID = @leagueID;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@leagueID", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@leagueID"].Value = leagueID;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Player _player = new Player();
                            _player.ID = (int)reader["id"];
                            _player.FirstName = reader["firstName"].ToString();
                            _player.LastName = reader["lastName"].ToString();
                            _player.PDGANumber = reader["pdgaNum"].ToString();
                            _leaguePlayers.Add(_player);
                        }
                    }
                }
            }
            return _leaguePlayers;
        }

        /// <summary>
        /// Adds selected player to selected league
        /// </summary>
        /// <param name="leagueID">Id of selected league to add player</param>
        /// <param name="playerID">Id of selected player to add to the league</param>
        /// <returns>Returns if insertion was successful</returns>
        public bool AddLeaguePlayer(int leagueID, int playerID)
        {
            string insertStatement =
                "INSERT INTO LeaguePlayers " +
                "(leagueID, playerID) " +
                "VALUES (@LeagueID, @PlayerID);";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    cmd.Parameters.Add("@LeagueID", System.Data.SqlDbType.Int);
                    cmd.Parameters["@LeagueID"].Value = leagueID;

                    cmd.Parameters.Add("@PlayerID", System.Data.SqlDbType.Int);
                    cmd.Parameters["@PlayerID"].Value = playerID;

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
