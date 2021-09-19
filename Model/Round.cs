using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageManagementSystem.Model
{
    class Round
    {
        public int LeagueID { get; set; }

        public int PlayerID { get; set; }

        public DateTime DateOfRound { get; set; }

        public int Score { get; set; }
    }
}
