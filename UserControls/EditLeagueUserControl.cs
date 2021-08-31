using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
