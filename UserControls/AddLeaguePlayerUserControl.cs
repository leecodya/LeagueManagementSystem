using System;
using System.Windows.Forms;
using LeageManagementSystem.Controller;
using LeagueManagementSystem.Controller;

namespace LeageManagementSystem.UserControls
{
    /// <summary>
    /// User control to add a player to a specific league
    /// </summary>
    public partial class AddLeaguePlayerUserControl : UserControl
    {
        private LeagueController leagueController;
        private PlayerController playerController;
        private LeaguePlayersController leaguePlayersController;

        public AddLeaguePlayerUserControl()
        {
            InitializeComponent();
            leagueController = new LeagueController();
            playerController = new PlayerController();
            leaguePlayersController = new LeaguePlayersController();

            ResetForm();
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            int selectedLeagueID = 0;
            int selectedPlayerID = 0;
            bool result = false;

            try
            {
                selectedLeagueID = (int)this.leagueComboBox.SelectedValue;
                selectedPlayerID = (int)this.playerComboBox.SelectedValue;

                try
                {
                    result = leaguePlayersController.AddPlayerToLeague(selectedLeagueID, selectedPlayerID);

                    if (result)
                    {
                        MessageBox.Show("Player has been successfully added to the league");
                        ResetForm();
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

        /// <summary>
        /// Resets the comboboxes by retrieving a fresh list of leagues and players and set them back to -1 index
        /// </summary>
        public void ResetForm()
        {
            this.leagueComboBox.DataSource = leagueController.GetLeagues();
            this.leagueComboBox.DisplayMember = "name";
            this.leagueComboBox.ValueMember = "id";
            this.leagueComboBox.SelectedIndex = -1;

            this.playerComboBox.DataSource = playerController.GetSystemPlayers();
            this.playerComboBox.DisplayMember = "FullName";
            this.playerComboBox.ValueMember = "id";
            this.playerComboBox.SelectedIndex = -1;
        }
    }
}
