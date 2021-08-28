using LeagueManagementSystem.Controller;
using LeagueManagementSystem.Model;
using System.Windows.Forms;

namespace LeageManagementSystem.UserControls
{
    public partial class MyInformationUserControl : UserControl
    {
        private Player currentPlayer;
        private Player newPlayer;
        private PlayerController playerController;

        public MyInformationUserControl()
        {
            InitializeComponent();
            currentPlayer = new Player();
            newPlayer = new Player();
            playerController = new PlayerController();
        }

        /// <summary>
        /// Set values of the textboxes within the user control to the values passed in
        /// </summary>
        /// <param name="firstName">First Name of Player</param>
        /// <param name="lastName">Last Name of player</param>
        /// <param name="pdgaNum">Player's PDGA Number</param>
        public void SetValues(string firstName, string lastName, string pdgaNum, int playerID)
        {
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            pdgaNumTextBox.Text = pdgaNum;

            currentPlayer.FirstName = firstName;
            currentPlayer.LastName = lastName;
            currentPlayer.PDGANumber = pdgaNum;
            currentPlayer.ID = playerID;
        }

        private void UpdatePlayerButton_Click(object sender, System.EventArgs e)
        {
            if (firstNameTextBox.Text.Trim() == "" || lastNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Plase make sure the first and last name fields are filled out");
            }
            else
            {
                newPlayer.FirstName = firstNameTextBox.Text;
                newPlayer.LastName = lastNameTextBox.Text;
                newPlayer.PDGANumber = pdgaNumTextBox.Text;

                bool result = playerController.UpdatePlayerInformation(currentPlayer, newPlayer);

                if (result)
                {
                    MessageBox.Show("Player has been successfully updated");
                }
                else
                {
                    MessageBox.Show("Something went wrong with the updates");
                }

                currentPlayer.FirstName = newPlayer.FirstName;
                currentPlayer.LastName = newPlayer.LastName;
                currentPlayer.PDGANumber = newPlayer.PDGANumber;
            }            
        }
    }
}
