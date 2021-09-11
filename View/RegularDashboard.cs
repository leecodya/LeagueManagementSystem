using LeageManagementSystem.Model;
using LeagueManagementSystem.Controller;
using LeagueManagementSystem.Model;
using System;
using System.Windows.Forms;

namespace LeageManagementSystem.View
{
    public partial class RegularDashboard : Form
    {
        private User user;
        private PlayerController playerController;

        public RegularDashboard()
        {
            InitializeComponent();
            playerController = new PlayerController();
            user = new User();

            SetMyInfoTitle();
        }

        public void SetUser(User newUser)
        {
            user = newUser;
            
            Player _player = playerController.GetPlayerByID(newUser.PlayerID);
            myInformationUserControl1.SetValues(_player.FirstName, _player.LastName, _player.PDGANumber, newUser.PlayerID);

            welcomeLabel.Text = "Welcome " + _player.FullName + "!";
        }

        private void EditRoundButon_Click(object sender, EventArgs e)
        {
            addRoundScoredUserControl1.Visible = false;
            editRoundUserControl1.Visible = true;
        }

        private void AddRoundButton_Click(object sender, EventArgs e)
        {
            addRoundScoredUserControl1.Visible = true;
            editRoundUserControl1.Visible = false;
        }

        private void SetMyInfoTitle()
        {
            myInformationUserControl1.isRegularUser();
        }
    }
}
