using System;
using System.Windows.Forms;
using LeagueManagementSystem.Model;
using LeageManagementSystem.Controller;
using System.Data.SqlClient;

namespace LeageManagementSystem.UserControls
{
    /// <summary>
    /// User Control to add a new league to the system
    /// </summary>
    public partial class AddLeagueUserControl : UserControl
    {
        private League _league;
        private LeagueController leagueController;

        /// <summary>
        /// Add League 0 parameter constructor
        /// </summary>
        public AddLeagueUserControl()
        {
            InitializeComponent();
            _league = new League();
            leagueController = new LeagueController();
        }

        private void CreateLeagueButton_Click(object sender, EventArgs e)
        {
            if (leagueNameTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please make sure the league name is filled out");
            }
            else
            {
                _league.Name = leagueNameTextBox.Text;

                try
                {
                    if (startDateTextBox.Text.Trim().Equals(""))
                    {
                        _league.StartDate = null;
                    }
                    else
                    {
                        _league.StartDate = Convert.ToDateTime(startDateTextBox.Text);
                    }

                    if (endDateTextBox.Text.Trim().Equals(""))
                    {
                        _league.EndDate = null;
                    }
                    else
                    {
                        _league.EndDate = Convert.ToDateTime(endDateTextBox.Text);
                    }

                    _league.CourseName = courseNameTextBox.Text;

                    bool result = leagueController.AddLeague(_league);

                    if (result)
                    {
                        MessageBox.Show("League has been successfully added!");
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong when adding league");
                    }
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Please make sure you have a proper date format", fe.GetType().ToString());
                }
                catch (SqlException sqle)
                {
                    MessageBox.Show("A league with that name already exists. Please try re-entering another name for the league", sqle.GetType().ToString());
                }

            }            
        }

        /// <summary>
        /// Resets all the fields to a blank state
        /// </summary>
        public void ClearForm()
        {
            leagueNameTextBox.Text = "";
            startDateTextBox.Text = "";
            endDateTextBox.Text = "";
            courseNameTextBox.Text = "";
        }
    }
}
