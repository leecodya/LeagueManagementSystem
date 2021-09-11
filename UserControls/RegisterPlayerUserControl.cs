using System;
using System.Windows.Forms;
using LeagueManagementSystem.Controller;

namespace LeageManagementSystem.UserControls
{
    /// <summary>
    /// User control used to add a player into the system
    /// </summary>
    public partial class RegisterPlayerUserControl : UserControl
    {
        private PlayerController playerController;

        /// <summary>
        /// 0 parameter constructor
        /// </summary>
        public RegisterPlayerUserControl()
        {
            InitializeComponent();
            playerController = new PlayerController();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string firstName = "";
            string lastName = ""; 
            string pdgaNum = "";
            bool result = false;

            if (firstNameTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("First name is required");
            }
            else
            {
                firstName = firstNameTextBox.Text.Trim();
            }

            if (lastNameTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Last name is required");
            }
            else
            {
                lastName = lastNameTextBox.Text.Trim();
            }

            pdgaNum = pdgaNumTextBox.Text.Trim();

            if (firstNameTextBox.Text.Trim() != "" && lastNameTextBox.Text.Trim() != "")
            {
                result = playerController.AddPlayerToSystem(firstName, lastName, pdgaNum);
            }
            
            if (result)
            {
                MessageBox.Show("Player has been successfully added");
                ClearForm();
            }
        }

        public void ClearForm()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            pdgaNumTextBox.Text = "";
        }
    }
}
