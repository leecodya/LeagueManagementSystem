using System.Data.SqlClient;

namespace LeageManagementSystem.DAL
{
    /// <summary>
    /// Class to establish a connection directly to the DB (LeagueDatabase)
    /// </summary>
    class DBConnection
    {
        /// <summary>
        /// Method to establish a connection to the League Management DB
        /// </summary>
        /// <returns>Returns the connection to the database</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog= LeageDatabase;" + 
                "Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
