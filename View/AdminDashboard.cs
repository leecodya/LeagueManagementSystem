using System;
using System.Windows.Forms;
using LeageManagementSystem.Model;
using LeagueManagementSystem.Controller;
using LeagueManagementSystem.Model;

namespace LeageManagementSystem.View
{
    public partial class AdminDashboard : Form
    {
        private User user;
        private PlayerController playerController;
        public AdminDashboard()
        {
            InitializeComponent();
            user = new User();
            playerController = new PlayerController();
        }

        public void SetUser(User newUser)
        {
            user = newUser;
            welcomeLabel.Text = "Welcome " + user.UserName + "!";

            Player _player = playerController.GetPlayerByID(newUser.PlayerID);
        }
    }
}
