using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeagueManagementSystem.Controller;
using LeagueManagementSystem.Model;
using LeageManagementSystem.Model;
using System.Data.SqlClient;

namespace LeagueManagementSystem.UserControls
{
    public partial class AddUserUserControl : UserControl
    {
        private UserController userController;
        private PlayerController playerController;
        public AddUserUserControl()
        {
            InitializeComponent();
            userController = new UserController();
            playerController = new PlayerController();

            playerComboBox.DataSource = playerController.GetSystemPlayers();
            playerComboBox.DisplayMember = "FullNameAndPDGANumber";
            playerComboBox.ValueMember = "id";
            playerComboBox.SelectedIndex = -1;
        }

        private void GetPlayerIDButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedPlayerID = (int)playerComboBox.SelectedValue;
                Player myPlayer = playerController.GetPlayerByID(selectedPlayerID);
                playerIDTextBox.Text = Convert.ToString(myPlayer.ID);
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show("Please select a player", nre.GetType().ToString());
            }
            
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (usernameTextBox.Text.Trim() == "" || passwordTextBox.Text.Trim() == "" || playerIDTextBox.Text == "")
                {
                    MessageBox.Show("Please make sure all required fields are properly filled out");
                }
                else
                {
                    User newUser = new User();
                    string username = usernameTextBox.Text;
                    string password = passwordTextBox.Text;
                    string privileges = privilegesComboBox.SelectedItem.ToString();
                    int playerID = Convert.ToInt32(playerIDTextBox.Text);

                    newUser.UserName = username;
                    newUser.Password = password;
                    newUser.Privileges = privileges;
                    newUser.PlayerID = playerID;

                    bool result = userController.AddUser(newUser);

                    if (result)
                    {
                        MessageBox.Show("User was successfully added");
                        ResetFields();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong when added the user");
                    }
                }
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show("Please select a privilege for this user", nre.GetType().ToString());
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("That username already exists. Please try another username", sqle.GetType().ToString());
            }
        }

        public void ResetFields()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            privilegesComboBox.SelectedIndex = -1;
            playerComboBox.SelectedIndex = -1;
            playerIDTextBox.Text = "";
        }
    }
}
