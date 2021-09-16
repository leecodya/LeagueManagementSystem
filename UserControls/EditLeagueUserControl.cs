using System;
using System.Windows.Forms;
using LeageManagementSystem.Controller;
using LeagueManagementSystem.Model;

namespace LeageManagementSystem.UserControls
{
    public partial class EditLeagueUserControl : UserControl
    {
        private LeagueController leagueController;
        private League newLeague;

        public EditLeagueUserControl()
        {
            InitializeComponent();
            leagueController = new LeagueController();
            newLeague = new League();

            ResetFields();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedLeagueID = (int)leagueNameComboBox.SelectedValue;
                League selectedLeague = leagueController.GetLeagueByID(selectedLeagueID);
                string[] startDateInfo = selectedLeague.StartDate.ToString().Split(' ');
                string[] endDateInfo = selectedLeague.EndDate.ToString().Split(' ');

                if (selectedLeague.StartDate == null)
                {
                    startDateTextBox.Text = "";
                }
                else
                {
                    startDateTextBox.Text = startDateInfo[0];
                }

                if (selectedLeague.EndDate == null)
                {
                    endDateTextBox.Text = "";
                }
                else
                {
                    endDateTextBox.Text = endDateInfo[0];
                }

                if (selectedLeague.CourseName == "")
                {
                    courseNameTextBox.Text = "";
                }
                else
                {
                    courseNameTextBox.Text = selectedLeague.CourseName;
                }
            }
            catch(NullReferenceException nre)
            {
                MessageBox.Show("Please select a league", nre.GetType().ToString());
            }
        }

        /// <summary>
        /// Method used to reset the league combo box by retrieves a fresh list of leagues and set the textboxes to an empty string
        /// </summary>
        public void ResetFields()
        {
            this.leagueNameComboBox.DataSource = leagueController.GetLeagues();
            this.leagueNameComboBox.DisplayMember = "name";
            this.leagueNameComboBox.ValueMember = "id";
            this.leagueNameComboBox.SelectedIndex = -1;

            startDateTextBox.Text = "";
            endDateTextBox.Text = "";
            courseNameTextBox.Text = "";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                League oldLeague = new League();
                int selectedLeagueID = (int)leagueNameComboBox.SelectedValue;
                oldLeague = leagueController.GetLeagueByID(selectedLeagueID);

                try
                {
                    if (startDateTextBox.Text.Trim().Equals(""))
                    {
                        newLeague.StartDate = null;
                    }
                    else
                    {
                        newLeague.StartDate = Convert.ToDateTime(startDateTextBox.Text);
                    }

                    if (endDateTextBox.Text.Trim().Equals(""))
                    {
                        newLeague.EndDate = null;
                    }
                    else
                    {
                        newLeague.EndDate = Convert.ToDateTime(endDateTextBox.Text);
                    }

                    if (courseNameTextBox.Text.Trim().Equals(""))
                    {
                        newLeague.CourseName = "";
                    }
                    else
                    {
                        newLeague.CourseName = courseNameTextBox.Text;
                    }

                    bool result = leagueController.UpdateLeague(oldLeague, newLeague);

                    if (result)
                    {
                        MessageBox.Show("League has been successfully updated!");
                        ResetFields();

                    }
                    else
                    {
                        MessageBox.Show("Something went wrong when updating the league");
                    }

                    oldLeague.StartDate = newLeague.StartDate;
                    oldLeague.EndDate = newLeague.EndDate;
                    oldLeague.CourseName = newLeague.CourseName;
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Please make sure you have a proper date format", fe.GetType().ToString());
                }
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show("Please select a league", nre.GetType().ToString());
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this league?", "Delete Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int selectedLeagueID = (int)leagueNameComboBox.SelectedValue;
                    bool result = leagueController.DeleteLeague(selectedLeagueID);

                    if (result)
                    {
                        MessageBox.Show("League was deleted");
                        ResetFields();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong with deleting the league.");
                    }
                }
                catch (NullReferenceException nre)
                {
                    MessageBox.Show("Please select a league", nre.GetType().ToString());
                }
            }
        }
    }
}
