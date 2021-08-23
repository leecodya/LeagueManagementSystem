using LeagueManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LeagueManagementSystem.DAL
{
    /// <summary>
    /// Class to interact directly with the Player table in the LeagueDatabase
    /// </summary>
    class PlayerDAL
    {
        /// <summary>
        /// Registers player into the system. It does NOT add the player to a league
        /// </summary>
        /// <param name="firstName">First name of player to be registered</param>
        /// <param name="lastName">Last name of player to be registered</param>
        /// <param name="pdgaNum">PDGA number of player to be registered if applicable</param>
        /// <returns>Returns if the player was successfully added to the database or not</returns>
        public bool AddPlayerToSystem(string firstName, string lastName, string pdgaNum)
        {
            string insertStatement =
                "INSERT INTO Player " +
                "(firstName, lastName, pdgaNum) " +
                "VALUES (@FirstName, @LastName, @PDGANum);";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    cmd.Parameters.Add("@FirstName", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@FirstName"].Value = firstName;

                    cmd.Parameters.Add("@LastName", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@LastName"].Value = lastName;

                    cmd.Parameters.Add("@PDGANum", System.Data.SqlDbType.Char);                    

                    if (String.IsNullOrEmpty(pdgaNum))
                    {
                        cmd.Parameters["@PDGANum"].Value = DBNull.Value;
                    }
                    else
                    {
                        cmd.Parameters["@PDGANum"].Value = pdgaNum;
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
        /// Retrieves all the players that are within the system, aka in the Player table
        /// </summary>
        /// <returns>Returns list of players within the Player table</returns>
        public List<Player> GetSystemPlayers()
        {
            List<Player> _players = new List<Player>();
            string selectStatement = "SELECT id, firstName, lastName FROM Player;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Player _player = new Player();
                            _player.ID = (int)reader["id"];
                            _player.FirstName = Convert.ToString(reader["firstName"]);
                            _player.LastName = Convert.ToString(reader["lastName"]);
                            _players.Add(_player);
                        }
                    }
                }
            }
            return _players;
        }
    }
}
