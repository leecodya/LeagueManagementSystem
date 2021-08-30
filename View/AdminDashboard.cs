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

            addLeaguePlayerUserControl1.Visible = false;

            addRoundScoredUserControl1.Visible = true;
            editRoundUserControl1.Visible = false;
        }

        public void SetUser(User newUser)
        {
            user = newUser;
            welcomeLabel.Text = "Welcome " + user.UserName + "!";

            Player _player = playerController.GetPlayerByID(newUser.PlayerID);
        }

        private void AddPlayersToLeagueButton_Click(object sender, EventArgs e)
        {
            addLeaguePlayerUserControl1.Visible = true;
        }

        private void AddLeagueButton_Click(object sender, EventArgs e)
        {
            addLeaguePlayerUserControl1.Visible = false;
        }

        private void RegisterPlayerButton_Click(object sender, EventArgs e)
        {
            registerPlayerUserControl1.Visible = true;
        }

        private void EditPlayerButton_Click(object sender, EventArgs e)
        {
            registerPlayerUserControl1.Visible = false;
        }

        private void AddRoundButton_Click(object sender, EventArgs e)
        {
            addRoundScoredUserControl1.Visible = true;
            editRoundUserControl1.Visible = false;
        }

        private void EditRoundButton_Click(object sender, EventArgs e)
        {
            addRoundScoredUserControl1.Visible = false;
            editRoundUserControl1.Visible = true;
        }
    }
}
