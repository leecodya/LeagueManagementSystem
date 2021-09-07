using System;
using System.Windows.Forms;
using LeagueManagementSystem.Controller;
using LeageManagementSystem.Model;

namespace LeagueManagementSystem.UserControls
{
    public partial class EditUserUserControl : UserControl
    {
        private UserController userController;
        private User currentUser;

        public EditUserUserControl()
        {
            InitializeComponent();
            userController = new UserController();
            currentUser = new User();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please provide a username");
            }
            else
            {
                string username = usernameTextBox.Text;
                currentUser = userController.GetUserByUsername(username);

                if(currentUser.ID == 0)
                {
                    MessageBox.Show("Please make sure the username entered is valid");
                }
                else
                {
                    passwordTextBox.Text = currentUser.Password;
                    privilegesComboBox.SelectedIndex = privilegesComboBox.FindStringExact(currentUser.Privileges.Trim());
                    playerIDTextBox.Text = currentUser.PlayerID.ToString();
                }
                
            }
        }

        /// <summary>
        /// Resets all of the fields on the form
        /// </summary>
        public void ResetFields()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            privilegesComboBox.SelectedIndex = -1;
            playerIDTextBox.Text = "";
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                User newUser = new User();
                newUser.ID = currentUser.ID;
                newUser.UserName = usernameTextBox.Text;
                newUser.Password = passwordTextBox.Text;
                newUser.Privileges = privilegesComboBox.SelectedItem.ToString();
                newUser.PlayerID = Convert.ToInt32(playerIDTextBox.Text);

                bool result = userController.UpdateUser(currentUser, newUser);

                if (result)
                {
                    MessageBox.Show("User was successfully updated");
                    currentUser = newUser;
                }
                else
                {
                    MessageBox.Show("Something went wrong when updating the user");
                }
            }
            catch(NullReferenceException nre)
            {
                MessageBox.Show("Please make sure all of the fields have a valid entry", nre.GetType().ToString());
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Please make sure all of the fields have a valid entry", fe.GetType().ToString());
            }
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (currentUser.ID == 0)
            {
                MessageBox.Show("Please enter a proper username and search for the user first before deleting");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Delete Confirmation", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int userID = currentUser.ID;
                        bool result = userController.DeleteUser(userID);

                        if (result)
                        {
                            MessageBox.Show("User was deleted");
                            ResetFields();
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong with deleting the user.");
                        }
                    }
                    catch (NullReferenceException nre)
                    {
                        MessageBox.Show("Please enter a proper username", nre.GetType().ToString());
                    }
                }
            }
            
        }
    }
}
