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

        /// <summary>
        /// Retrieves user object based on username given
        /// </summary>
        /// <param name="username">Username of user</param>
        /// <returns>Returns user retrieved from the database</returns>
        public User GetUserByUsername(string username)
        {
            return userDAL.GetUserByUsername(username);
        }

        /// <summary>
        /// Updates only the password and privileges for the user
        /// </summary>
        /// <param name="oldUser">User info to be updated</param>
        /// <param name="newUser">New user info to replace the old user info</param>
        /// <returns>Returns if query was successful</returns>
        public bool UpdateUser(User oldUser, User newUser)
        {
            return userDAL.UpdateUser(oldUser, newUser);
        }

        /// <summary>
        /// Deletes user from the database
        /// </summary>
        /// <param name="userID">ID of user to be removed</param>
        /// <returns>Returns if the deletion was successful</returns>
        public bool DeleteUser(int userID)
        {
            return userDAL.DeleteUser(userID);
        }
    }
}
