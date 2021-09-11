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

            SetEditPlayer();

            addLeagueUserControl1.Visible = true;
            addLeaguePlayerUserControl1.Visible = false;
            editLeagueUserControl1.Visible = false;

            addRoundScoredUserControl1.Visible = true;
            editRoundUserControl1.Visible = false;

            addUserUserControl1.Visible = true;
            editUserUserControl1.Visible = false;

            registerPlayerUserControl1.Visible = true;
            myInformationUserControl1.Visible = false;
        }

        public void SetUser(User newUser)
        {
            user = newUser;

            Player _player = playerController.GetPlayerByID(newUser.PlayerID);

            welcomeLabel.Text = "Welcome " + _player.FullName + "!";
        }

        public void SetEditPlayer()
        {
            myInformationUserControl1.isAdminUser();
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
            registerPlayerUserControl1.ClearForm();
            registerPlayerUserControl1.Visible = true;
            myInformationUserControl1.Visible = false;
        }

        private void EditPlayerButton_Click(object sender, EventArgs e)
        {
            myInformationUserControl1.ResetFields();
            registerPlayerUserControl1.Visible = false;
            myInformationUserControl1.Visible = true;
        }

        private void AddRoundButton_Click(object sender, EventArgs e)
        {
            addRoundScoredUserControl1.ClearForm();
            addRoundScoredUserControl1.Visible = true;
            editRoundUserControl1.Visible = false;
        }

        private void EditRoundButton_Click(object sender, EventArgs e)
        {
            editRoundUserControl1.ClearForm();
            addRoundScoredUserControl1.Visible = false;
            editRoundUserControl1.Visible = true;
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            addUserUserControl1.ResetFields();
            addUserUserControl1.Visible = true;
            editUserUserControl1.Visible = false;
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            editUserUserControl1.ResetFields();
            addUserUserControl1.Visible = false;
            editUserUserControl1.Visible = true;
        }
    }
}
