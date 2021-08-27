using System.Windows.Forms;

namespace LeageManagementSystem.UserControls
{
    public partial class MyInformationUserControl : UserControl
    {
        public MyInformationUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set values of the textboxes within the user control to the values passed in
        /// </summary>
        /// <param name="firstName">First Name of Player</param>
        /// <param name="lastName">Last Name of player</param>
        /// <param name="pdgaNum">Player's PDGA Number</param>
        public void SetTextValues(string firstName, string lastName, string pdgaNum)
        {
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            pdgaNumTextBox.Text = pdgaNum;
        }
    }
}
