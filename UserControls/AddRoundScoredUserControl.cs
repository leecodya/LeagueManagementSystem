using System;
using System.Windows.Forms;
using LeageManagementSystem.Controller;
using System.Globalization;
using System.Data.SqlClient;
using LeagueManagementSystem.Model;
using LeageManagementSystem.Model;

namespace LeageManagementSystem.UserControls
{
    /// <summary>
    /// User control to add a scored round
    /// </summary>
    public partial class AddRoundScoredUserControl : UserControl
    {
        private LeagueController leagueController;
        private LeaguePlayersController leaguePlayersController;
        private RoundController roundController;
        private Round _round;

        /// <summary>
        /// 0 parameter contructor
        /// </summary>
        public AddRoundScoredUserControl()
        {
            InitializeComponent();
            leagueController = new LeagueController();
            leaguePlayersController = new LeaguePlayersController();
            roundController = new RoundController();
            _round = new Round();

            this.leagueComboBox.DataSource = leagueController.GetLeagues();
            this.leagueComboBox.DisplayMember = "name";
            this.leagueComboBox.ValueMember = "id";
            this.leagueComboBox.SelectedIndex = -1;
        }

        private void LeagueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedLeague = this.leagueComboBox.SelectedIndex + 1;
            int leagueID = Convert.ToInt32(selectedLeague);
            this.playerComboBox.DataSource = leaguePlayersController.GetLeaguePlayers(leagueID);
            this.playerComboBox.DisplayMember = "FullName";
            this.playerComboBox.ValueMember = "id";
        }

        private void AddRoundScoredButton_Click(object sender, EventArgs e)
        {
            DateTime dateOfRound;
            bool result = false;
            try
            {
                int selectedLeagueID = (int)this.leagueComboBox.SelectedValue;
                int selectedPlayerID = (int)this.playerComboBox.SelectedValue;
                
                try
                {
                    dateOfRound = Convert.ToDateTime(this.dateOfRoundTextBox.Text);
                    League myLeague = leagueController.GetLeagueByID(selectedLeagueID);
                    DateTime startDate = Convert.ToDateTime(myLeague.StartDate);
                    DateTime endDate = Convert.ToDateTime(myLeague.EndDate);

                    if (dateOfRound >= startDate && dateOfRound <= endDate)
                    {                        
                        int score = Convert.ToInt32(this.scoreTextBox.Text);
                        _round.LeagueID = selectedLeagueID;
                        _round.PlayerID = selectedPlayerID;
                        _round.DateOfRound = dateOfRound;
                        _round.Score = score;
                        result = roundController.AddRoundScore(_round);

                        if (result)
                        {
                            MessageBox.Show("Round has been successfully added");
                            ClearForm();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The date entered for the round does not fall within the start and end dates of the selected league. Please enter a new date");
                    }
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Please make sure that your round date is formatted properly" +
                        " and that the score entered is a number", fe.GetType().ToString());
                }
                catch (SqlException sqle)
                {
                    MessageBox.Show("There has already been a round scored for that player for the selected league on the entered date. Please try again", sqle.GetType().ToString());
                }
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show("Please make sure all fields have a value", nre.GetType().ToString());
            }            
        }

        private void AddRoundScoredUserControl_Load(object sender, EventArgs e)
        {
            dateOfRoundTextBox.Text = "mm/dd/yyyy";
        }

        private void DateOfRoundTextBox_Enter_1(object sender, EventArgs e)
        {
            if (dateOfRoundTextBox.Text == "mm/dd/yyyy")
            {
                dateOfRoundTextBox.Text = "";
            }
        }

        private void DateOfRoundTextBox_Leave(object sender, EventArgs e)
        {
            if (dateOfRoundTextBox.Text == "")
            {
                dateOfRoundTextBox.Text = "mm/dd/yyyy";
            }
        }

        public void ClearForm()
        {
            leagueComboBox.SelectedIndex = -1;
            playerComboBox.SelectedIndex = -1;
            dateOfRoundTextBox.Text = "";
            scoreTextBox.Text = "";
        }
    }
}
