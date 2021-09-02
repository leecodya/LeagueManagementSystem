using System;
using System.Windows.Forms;
using LeageManagementSystem.Controller;
using LeagueManagementSystem.Model;

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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int selectedLeagueID = (int)leagueNameComboBox.SelectedValue;
            League selectedLeague = leagueController.GetLeagueByID(selectedLeagueID);

            if (selectedLeague.StartDate == null)
            {
                startDateTextBox.Text = "";
            }
            else
            {
                startDateTextBox.Text = selectedLeague.StartDate.ToString().Substring(0, 10);
            }

            if (selectedLeague.EndDate == null)
            {
                endDateTextBox.Text = "";
            }
            else
            {
                endDateTextBox.Text = selectedLeague.EndDate.ToString().Substring(0, 10);
            }

            if (selectedLeague.CourseName == "")
            {
                courseNameTextBox.Text = "";
            }
            else
            {
                courseNameTextBox.Text = selectedLeague.CourseName;
            }
        }

        public void ResetFields()
        {
            this.leagueNameComboBox.DataSource = leagueController.GetLeagues();
            this.leagueNameComboBox.DisplayMember = "name";
            this.leagueNameComboBox.ValueMember = "id";
            this.leagueNameComboBox.SelectedIndex = -1;

            startDateTextBox.Text = "";
            endDateTextBox.Text = "";
            courseNameTextBox.Text = "";
        }
    }
}
