using System;
using System.Windows.Forms;
using LeageManagementSystem.Controller;

namespace LeageManagementSystem.UserControls
{
    public partial class EditLeagueUserControl : UserControl
    {
        private LeagueController leagueController;

        public EditLeagueUserControl()
        {
            InitializeComponent();
            leagueController = new LeagueController();

            this.leagueNameComboBox.DataSource = leagueController.GetLeagues();
            this.leagueNameComboBox.DisplayMember = "name";
            this.leagueNameComboBox.ValueMember = "id";
            this.leagueNameComboBox.SelectedIndex = -1;
        }
    }
}
