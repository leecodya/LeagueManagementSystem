using System;
using System.Windows.Forms;
using LeageManagementSystem.Controller;
using System.Globalization;

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

        /// <summary>
        /// 0 parameter contructor
        /// </summary>
        public AddRoundScoredUserControl()
        {
            InitializeComponent();
            leagueController = new LeagueController();
            leaguePlayersController = new LeaguePlayersController();
            roundController = new RoundController();

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
            int selectedLeagueID = 0;
            int selectedPlayerID = 0;
            string dateOfRound = "";
            int score = 0;
            bool result = false;
            try
            {
                selectedLeagueID = (int)this.leagueComboBox.SelectedValue;
                selectedPlayerID = (int)this.playerComboBox.SelectedValue;
                string date = this.dateOfRoundTextBox.Text;
                
                try
                {
                    DateTime dt = DateTime.ParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                    dateOfRound = dt.ToString("yyyy-MM-dd");
                    score = Convert.ToInt32(this.scoreTextBox.Text);

                    result = roundController.AddRoundScore(selectedLeagueID, selectedPlayerID, dateOfRound, score);

                    if (result)
                    {
                        MessageBox.Show("Round has been successfully added");
                        ClearForm();
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

        private void ClearForm()
        {
            leagueComboBox.SelectedIndex = -1;
            playerComboBox.SelectedIndex = -1;
            dateOfRoundTextBox.Text = "";
            scoreTextBox.Text = "";
        }
    }
}
