using System;
using System.Windows.Forms;
using LeageManagementSystem.Controller;

namespace LeageManagementSystem.UserControls
{
    /// <summary>
    /// User control to updated the round score
    /// </summary>
    public partial class EditRoundUserControl : UserControl
    {
        private RoundController roundController;
        private LeagueController leagueController;
        private LeaguePlayersController leaguePlayersController;

        /// <summary>
        /// 0 parameter constructor
        /// </summary>
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
            string dateOfRound = "";
            int score = 0;
            bool result = false;

            try
            {
                selectedLeagueID = (int)this.leagueComboBox.SelectedValue;
                selectedPlayerID = (int)this.playerComboBox.SelectedValue;
                dateOfRound = this.datesOfRoundsComboBox.SelectedValue.ToString();

                try
                {               
                    if (this.scoreTextBox.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Please make sure to enter an updated score");
                    }
                    else
                    {
                        score = Convert.ToInt32(this.scoreTextBox.Text.Trim());

                        result = roundController.UpdateRoundScore(selectedLeagueID, selectedPlayerID, dateOfRound, score);

                        if (result)
                        {
                            MessageBox.Show("Round has been successfully updated");
                            ClearForm();
                        }
                    }
                    
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
