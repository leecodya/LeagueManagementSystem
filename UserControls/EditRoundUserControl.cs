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
using System.Globalization;

namespace LeageManagementSystem.UserControls
{
    public partial class EditRoundUserControl : UserControl
    {
        private RoundController roundController;
        private LeagueController leagueController;
        private LeaguePlayersController leaguePlayersController;

        public EditRoundUserControl()
        {
            InitializeComponent();
            roundController = new RoundController();
            leagueController = new LeagueController();
            leaguePlayersController = new LeaguePlayersController();

            this.leagueComboBox.DataSource = leagueController.GetLeagues();
            this.leagueComboBox.DisplayMember = "name";
            this.leagueComboBox.ValueMember = "id";
            this.leagueComboBox.SelectedIndex = -1;
        }

        private void EditRoundButton_Click(object sender, EventArgs e)
        {
            int selectedLeagueID = 0;
            int selectedPlayerID = 0;
            string date = "";
            int score = 0;
            bool result = false;

            try
            {
                selectedLeagueID = (int)this.leagueComboBox.SelectedValue;
                selectedPlayerID = (int)this.playerComboBox.SelectedValue;
                date = this.datesOfRoundsComboBox.SelectedValue.ToString();

                try
                {
                    DateTime dt = DateTime.ParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                    string dateOfRound = dt.ToString("yyyy-MM-dd");
                    score = Convert.ToInt32(this.scoreTextBox.Text);

                    //result = roundController.EditRoundScore(selectedLeagueID, selectedPlayerID, dateOfRound, score);

                    /*if (result)
                    {
                        MessageBox.Show("Round has been successfully updated");
                        ClearForm();
                    }*/
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Please make sure that your round date is formatted as mm/dd/yyyy" +
                        " and that the score entered is a number", fe.GetType().ToString());
                }
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show("Please make sure all fields have a value", nre.GetType().ToString());
            }
        }

        private void ClearForm()
        {
            leagueComboBox.SelectedIndex = -1;
            playerComboBox.SelectedIndex = -1;
            datesOfRoundsComboBox.SelectedIndex = -1;
            scoreTextBox.Text = "";
        }

        private void LeagueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedLeague = this.leagueComboBox.SelectedIndex + 1;
            int leagueID = Convert.ToInt32(selectedLeague);
            this.playerComboBox.DataSource = leaguePlayersController.GetLeaguePlayers(leagueID);
            this.playerComboBox.DisplayMember = "FullName";
            this.playerComboBox.ValueMember = "id";
        }

        private void SearchDatesButton_Click(object sender, EventArgs e)
        {
            int selectedLeagueID = (int)this.leagueComboBox.SelectedValue;
            int selectedPlayerID = (int)this.playerComboBox.SelectedValue;
            this.datesOfRoundsComboBox.DataSource = roundController.GetDates(selectedLeagueID, selectedPlayerID);
        }
    }
}
