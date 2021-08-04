using LeageManagementSystem.DAL;
using LeageManagementSystem.Model;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;

namespace LeageManagementSystem.Controller
{
    /// <summary>
    /// Class to interact with the LoginDAL
    /// </summary>
    class LoginController
    {
        private LoginDAL loginDAL;

        /// <summary>
        /// 0 parameter constructor for LoginController
        /// </summary>
        public LoginController()
        {
            loginDAL = new LoginDAL();
        }

        /// <summary>
        /// Method to get the login information from the LoginDAL
        /// </summary>
        /// <param name = "user">the user's given username</param> 
        /// <param name = "password">the users password</param> 
        /// <returns>A new User with a username and privileges</returns>
        public User GetLoginInformation(string user, string password)
        {
            if (user == null || password == null)
            {
                throw new ArgumentNullException("Please enter valid credentials");
            }

            // Commenting out for now until i can figure out how to compare hash password to plain text in db
            // or figure out how to convert the plain text in db to hash version
            //string hashedPassword = HashPassword(user, password);

            User information = loginDAL.GetLoginInformation(user, password);

            return information;
        }

        /// <summary>
        /// Method to create a hashed password
        /// </summary>
        /// <param name = "user">the user's given username</param> 
        /// <param name = "password">the users plain-text password</param> 
        /// <returns>A string with a hash to be stored as a password</returns>
        public string HashPassword(string user, string password)
        {
            byte[] salt = new byte[31 / 8];

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                            password: user + password,
                            salt: salt,
                            prf: KeyDerivationPrf.HMACSHA256,
                            iterationCount: 10000,
                            numBytesRequested: 256 / 8));

            return hashed;
        }
    }
}
