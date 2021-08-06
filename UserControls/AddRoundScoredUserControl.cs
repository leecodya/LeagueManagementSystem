﻿using System;
using System.Windows.Forms;
using LeagueManagementSystem.Model;
using LeagueManagementSystem.Controller;
using LeageManagementSystem.Controller;
using System.Globalization;
using System.Drawing;

namespace LeageManagementSystem.UserControls
{
    public partial class AddRoundScoredUserControl : UserControl
    {
        private LeagueController leagueController;
        private LeaguePlayersController leaguePlayersController;

        public AddRoundScoredUserControl()
        {
            InitializeComponent();
            leagueController = new LeagueController();
            leaguePlayersController = new LeaguePlayersController();

            this.leagueComboBox.DataSource = leagueController.GetLeagues();
            this.leagueComboBox.DisplayMember = "name";
            this.leagueComboBox.ValueMember = "id";
            this.leagueComboBox.SelectedIndex = -1;
        }

        private void LeagueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedLeague = this.leagueComboBox.SelectedIndex + 1;
            int leagueID = Convert.ToInt32(selectedLeague);
            this.playerComboBox.DataSource = leaguePlayersController.GetLeaguePlayers(leagueID);
            this.playerComboBox.DisplayMember = "FullName";
            this.playerComboBox.ValueMember = "id";
        }

        private void AddRoundScoredButton_Click(object sender, EventArgs e)
        {
            int selectedLeagueID = (int)this.leagueComboBox.SelectedValue;
            int selectedPlayerID = (int)this.playerComboBox.SelectedValue;
            string date = this.dateOfRoundTextBox.Text;
            string dateOfRound = "";
            int score = 0;
            try
            {
                DateTime dt = DateTime.ParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                dateOfRound = dt.ToString("yyyy-MM-dd");
                score = Convert.ToInt32(this.scoreTextBox.Text);

                string concatStatement = selectedLeagueID.ToString() + "\n" +
                                     selectedPlayerID.ToString() + "\n" +
                                     dateOfRound.ToString() + "\n" +
                                     score.ToString();
                MessageBox.Show(concatStatement);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Please make sure that your round date is formatted as mm/dd/yyyy" +
                    " and that the score entered is a number");
            }
            
            // roundController.AddRoundScore(selectedLeagueID, selectedPlayerID, dateOfRound, score);
        }

        private void AddRoundScoredUserControl_Load(object sender, EventArgs e)
        {
            dateOfRoundTextBox.Text = "mm/dd/yyyy";
        }

        private void DateOfRoundTextBox_Enter_1(object sender, EventArgs e)
        {
            if (dateOfRoundTextBox.Text == "mm/dd/yyyy")
            {
                dateOfRoundTextBox.Text = "";
            }
        }

        private void DateOfRoundTextBox_Leave(object sender, EventArgs e)
        {
            if (dateOfRoundTextBox.Text == "")
            {
                dateOfRoundTextBox.Text = "mm/dd/yyyy";
                dateOfRoundTextBox.ForeColor = Color.Gray;
            }
        }
    }
}
