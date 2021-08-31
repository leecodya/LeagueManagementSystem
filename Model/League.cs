using System;

namespace LeagueManagementSystem.Model
{
    /// <summary>
    /// League model class
    /// </summary>
    class League
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string CourseName { get; set; }
    }
}
