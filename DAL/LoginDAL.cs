using LeageManagementSystem.Model;
using LeagueManagementSystem.DAL;
using System;
using System.Data.SqlClient;

namespace LeageManagementSystem.DAL
{
    /// <summary>
    /// Class used to interact with the LMSUser table of the LeagueDatabase
    /// </summary>
    class LoginDAL
    {
        /// <summary>
        /// Method to get the login information from CS6232-g5 DB
        /// PASSWORD WILL NEED TO BE REWORKED IN THE FUTURE FOR IT TO BE HASHED SO PLAIN TEXT IS NOT STORED IN DB
        /// </summary>
        /// <param name = "user">the user's given username</param> 
        /// <param name = "password">the users password</param> 
        /// <returns>A new User with a username and privileges</returns>
        public User GetLoginInformation(string user, string password)
        {
            User newUser = new User();
            string selectStatement = "SELECT userName, privileges, playerID FROM LMSUser where userName = @user and password = @password;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@user", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@user"].Value = user;

                    selectCommand.Parameters.Add("@password", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@password"].Value = password;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            newUser.UserName = reader["userName"].ToString();
                            newUser.Privileges = reader["privileges"].ToString().Trim();
                            if (reader["playerID"].GetType() == typeof(DBNull))
                            {
                                newUser.PlayerID = 0;
                            }
                            else
                            {
                                newUser.PlayerID = Convert.ToInt32(reader["playerID"]);
                            }
                            
                        }
                    }
                }
            }
            return newUser;
        }
    }
}
