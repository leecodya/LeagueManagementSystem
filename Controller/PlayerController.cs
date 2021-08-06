using LeagueManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueManagementSystem.Controller
{
    class PlayerController
    {
        private PlayerDAL playerDAL;

        public PlayerController()
        {
            playerDAL = new PlayerDAL();
        }
    }
}
