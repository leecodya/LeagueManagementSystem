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
    }
}
