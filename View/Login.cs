using LeageManagementSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueManagementSystem
{
    public partial class Login : Form
    {
        private LeagueController leagueController;
        public Login()
        {
            InitializeComponent();
            leagueController = new LeagueController();

            // Move this code to any user control that needs combo box of leagues
            //this.leagueComboBox.DataSource = leagueController.GetLeagues();
            //this.leagueComboBox.DisplayMember = "name";
            // DropDownStyle = DropDownList
        }
    }
}
