using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeagueManagementSystem.Model;
using LeagueManagementSystem.Controller;
using LeageManagementSystem.Controller;

namespace LeageManagementSystem.UserControls
{
    public partial class AddRoundScoredUserControl : UserControl
    {
        private LeagueController leagueController;
        private LeaguePlayersController leaguePlayersController;

        public AddRoundScoredUserControl()
        {
            InitializeComponent();
            leagueController = new LeagueController();
            leaguePlayersController = new LeaguePlayersController();

            this.leagueComboBox.DataSource = leagueController.GetLeagues();
            this.leagueComboBox.DisplayMember = "name";
            this.leagueComboBox.ValueMember = "id";
            this.leagueComboBox.SelectedIndex = -1;
        }

        private void LeagueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedLeague = leagueComboBox.SelectedIndex + 1;
            int leagueID = Convert.ToInt32(selectedLeague);
            this.playerComboBox.DataSource = leaguePlayersController.GetLeaguePlayers(leagueID);
            this.playerComboBox.DisplayMember = "FullName";
        }
    }
}
