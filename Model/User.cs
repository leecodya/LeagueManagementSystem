﻿namespace LeageManagementSystem.Model
{
    /// <summary>
    /// User model class
    /// </summary>
    class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Privileges { get; set; }
        public int PlayerID { get; set; }
    }
}
