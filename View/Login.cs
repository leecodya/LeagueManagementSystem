using LeageManagementSystem.Controller;
using LeageManagementSystem.Model;
using LeageManagementSystem.View;
using System;
using System.Windows.Forms;

namespace LeagueManagementSystem
{
    public partial class Login : Form
    {
        private LoginController loginController;
        private AdminDashboard adminDashboard;
        private RegularDashboard regularDashboard;
        private GuestDashboard guestDashboard;

        /// <summary>
        /// 0 parameter Login constructor
        /// </summary>
        public Login()
        {
            InitializeComponent();
            loginController = new LoginController();
            adminDashboard = new AdminDashboard();
            regularDashboard = new RegularDashboard();
            guestDashboard = new GuestDashboard();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string privileges = "";
            User newUser = new User();
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                newUser = loginController.GetLoginInformation(username, password);
                privileges = newUser.Privileges;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            if (privileges == null)
            {
                errorLabel.Text = "That user doesn't exist. Please double check username and password";
            }
            else if (privileges.Equals("admin"))
            {
                adminDashboard.SetUser(newUser);
                Hide();
                adminDashboard.ShowDialog();
                ClearForm();
                Show();
            }
            else if (privileges.Equals("regular"))
            {
                regularDashboard.SetUser(newUser);
                Hide();
                regularDashboard.ShowDialog();
                ClearForm();
                Show();
            }
            else
            {
                errorLabel.Text = "Sorry, that user isn't registered.";
            }
        }

        private void ClearForm()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            errorLabel.Text = "";
        }

        private void GuestLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            guestDashboard.ShowDialog();
            ClearForm();
            Show();
        }
    }
}
