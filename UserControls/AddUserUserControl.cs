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
    }
}
