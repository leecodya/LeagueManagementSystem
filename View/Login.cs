using LeageManagementSystem.Controller;
using LeageManagementSystem.Model;
using LeageManagementSystem.View;
using System;
using System.Windows.Forms;

namespace LeagueManagementSystem
{
    public partial class Login : Form
    {
        //private LeagueController leagueController;
        private LoginController loginController;
        private AdminDashboard adminDashboard;
        private RegularDashboard regularDashboard;

        /// <summary>
        /// 0 parameter Login constructor
        /// </summary>
        public Login()
        {
            InitializeComponent();
            loginController = new LoginController();
            adminDashboard = new AdminDashboard();
            regularDashboard = new RegularDashboard();
            //leagueController = new LeagueController();

            // Move this code to any user control that needs combo box of leagues
            //this.leagueComboBox.DataSource = leagueController.GetLeagues();
            //this.leagueComboBox.DisplayMember = "name";
            // DropDownStyle = DropDownList
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string privileges = "";
            User newUser = new User();
            string user = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                newUser = loginController.GetLoginInformation(user, password);
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
                /*nurseDashboard.SetNurse(newUser.Username);
                nurseDashboard.SetUser(newUser.Username);*/
                Hide();
                adminDashboard.ShowDialog();
                ClearForm();
                Show();
            }
            else if (privileges.Equals("regular"))
            {
                /*adminDashboard.SetUser(newUser.Username);*/
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
    }
}
