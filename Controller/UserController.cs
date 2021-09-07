using LeageManagementSystem.Model;
using LeagueManagementSystem.DAL;

namespace LeagueManagementSystem.Controller
{
    /// <summary>
    /// Conrolle to interact with the user DAL
    /// </summary>
    class UserController
    {
        private UserDAL userDAL;

        /// <summary>
        /// 0-parameter constructor
        /// </summary>
        public UserController()
        {
            userDAL = new UserDAL();
        }

        /// <summary>
        /// Adds new user to LMSUser table
        /// </summary>
        /// <param name="newUser">New user to be added</param>
        /// <returns>Returns if the insertion was successful</returns>
        public bool AddUser(User newUser)
        {
            return userDAL.AddUser(newUser);
        }
    }
}
