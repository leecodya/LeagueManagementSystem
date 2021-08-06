using LeageManagementSystem.Model;
using LeagueManagementSystem.DAL;
using LeagueManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageManagementSystem.DAL
{
    class LeaguePlayersDAL
    {
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
    }
}
