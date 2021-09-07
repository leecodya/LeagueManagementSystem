using LeageManagementSystem.Model;
using System;
using System.Data.SqlClient;

namespace LeagueManagementSystem.DAL
{
    /// <summary>
    /// Class to interact directly with the LMSUser table in the LeagueDatabase
    /// </summary>
    class UserDAL
    {
        /// <summary>
        /// Adds new user to LMSUser table
        /// </summary>
        /// <param name="newUser">New user to be added</param>
        /// <returns>Returns if the insertion was successful</returns>
        public bool AddUser(User newUser)
        {
            string insertStatement =
                "INSERT INTO LMSUser " +
                "(userName, password, privileges, playerID) " +
                "VALUES (@UserName, @Password, @Privileges, @PlayerID);";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@UserName", newUser.UserName);
                    cmd.Parameters.AddWithValue("@Password", newUser.Password);
                    cmd.Parameters.AddWithValue("@Privileges", newUser.Privileges);
                    cmd.Parameters.AddWithValue("@PlayerID", newUser.PlayerID);
                  
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        /// <summary>
        /// Retrieves user object based on username given
        /// </summary>
        /// <param name="username">Username of user</param>
        /// <returns>Returns user retrieved from the database</returns>
        public User GetUserByUsername(string username)
        {
            User _user = new User();
            string selectStatement =
                "SELECT id, userName, password, privileges, playerID " +
                "FROM LMSUser " +
                "WHERE userName = @UserName;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@UserName", username);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _user.ID = (int)reader["id"];
                            _user.UserName = Convert.ToString(reader["userName"]);
                            _user.Password = Convert.ToString(reader["password"]);
                            _user.Privileges = Convert.ToString(reader["privileges"]);
                            _user.PlayerID = Convert.ToInt32(reader["playerID"]);
                        }
                    }
                }
            }
            return _user;
        }
    }
}
