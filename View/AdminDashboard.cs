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

            addLeagueUserControl1.Visible = true;
            addLeaguePlayerUserControl1.Visible = false;
            editLeagueUserControl1.Visible = false;

            addRoundScoredUserControl1.Visible = true;
            editRoundUserControl1.Visible = false;
        }

        public void SetUser(User newUser)
        {
            user = newUser;

            Player _player = playerController.GetPlayerByID(newUser.PlayerID);

            welcomeLabel.Text = "Welcome " + _player.FullName + "!";
        }

        private void AddPlayersToLeagueButton_Click(object sender, EventArgs e)
        {
            addLeaguePlayerUserControl1.ResetForm();
            addLeaguePlayerUserControl1.Visible = true;
            editLeagueUserControl1.Visible = false;
            addLeagueUserControl1.Visible = false;
        }

        private void AddLeagueButton_Click(object sender, EventArgs e)
        {
            addLeagueUserControl1.ClearForm();
            addLeaguePlayerUserControl1.Visible = false;
            editLeagueUserControl1.Visible = false;
            addLeagueUserControl1.Visible = true;
        }

        private void EditLeagueButton_Click(object sender, EventArgs e)
        {
            editLeagueUserControl1.ResetFields();
            addLeaguePlayerUserControl1.Visible = false;
            editLeagueUserControl1.Visible = true;
            addLeagueUserControl1.Visible = false;
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
