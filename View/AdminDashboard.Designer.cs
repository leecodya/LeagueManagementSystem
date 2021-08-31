﻿namespace LeageManagementSystem.View
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.manageLeaguesTabPage = new System.Windows.Forms.TabPage();
            this.manageUsersTabPage = new System.Windows.Forms.TabPage();
            this.managePlayersTabPage = new System.Windows.Forms.TabPage();
            this.manageRoundsTabPage = new System.Windows.Forms.TabPage();
            this.titleLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.addPlayersToLeagueButton = new System.Windows.Forms.Button();
            this.addLeagueButton = new System.Windows.Forms.Button();
            this.registerPlayerButton = new System.Windows.Forms.Button();
            this.editPlayerButton = new System.Windows.Forms.Button();
            this.addRoundButton = new System.Windows.Forms.Button();
            this.editRoundButton = new System.Windows.Forms.Button();
            this.editLeagueButton = new System.Windows.Forms.Button();
            this.addLeagueUserControl1 = new LeageManagementSystem.UserControls.AddLeagueUserControl();
            this.addLeaguePlayerUserControl1 = new LeageManagementSystem.UserControls.AddLeaguePlayerUserControl();
            this.registerPlayerUserControl1 = new LeageManagementSystem.UserControls.RegisterPlayerUserControl();
            this.editRoundUserControl1 = new LeageManagementSystem.UserControls.EditRoundUserControl();
            this.addRoundScoredUserControl1 = new LeageManagementSystem.UserControls.AddRoundScoredUserControl();
            this.adminTabControl.SuspendLayout();
            this.manageLeaguesTabPage.SuspendLayout();
            this.managePlayersTabPage.SuspendLayout();
            this.manageRoundsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.manageLeaguesTabPage);
            this.adminTabControl.Controls.Add(this.manageUsersTabPage);
            this.adminTabControl.Controls.Add(this.managePlayersTabPage);
            this.adminTabControl.Controls.Add(this.manageRoundsTabPage);
            this.adminTabControl.Location = new System.Drawing.Point(2, 67);
            this.adminTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(766, 386);
            this.adminTabControl.TabIndex = 0;
            // 
            // manageLeaguesTabPage
            // 
            this.manageLeaguesTabPage.Controls.Add(this.addLeagueUserControl1);
            this.manageLeaguesTabPage.Controls.Add(this.editLeagueButton);
            this.manageLeaguesTabPage.Controls.Add(this.addLeagueButton);
            this.manageLeaguesTabPage.Controls.Add(this.addLeaguePlayerUserControl1);
            this.manageLeaguesTabPage.Controls.Add(this.addPlayersToLeagueButton);
            this.manageLeaguesTabPage.Location = new System.Drawing.Point(4, 22);
            this.manageLeaguesTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageLeaguesTabPage.Name = "manageLeaguesTabPage";
            this.manageLeaguesTabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageLeaguesTabPage.Size = new System.Drawing.Size(758, 360);
            this.manageLeaguesTabPage.TabIndex = 0;
            this.manageLeaguesTabPage.Text = "Manage Leagues";
            this.manageLeaguesTabPage.UseVisualStyleBackColor = true;
            // 
            // manageUsersTabPage
            // 
            this.manageUsersTabPage.Location = new System.Drawing.Point(4, 22);
            this.manageUsersTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageUsersTabPage.Name = "manageUsersTabPage";
            this.manageUsersTabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageUsersTabPage.Size = new System.Drawing.Size(758, 360);
            this.manageUsersTabPage.TabIndex = 1;
            this.manageUsersTabPage.Text = "Manage Users";
            this.manageUsersTabPage.UseVisualStyleBackColor = true;
            // 
            // managePlayersTabPage
            // 
            this.managePlayersTabPage.Controls.Add(this.registerPlayerUserControl1);
            this.managePlayersTabPage.Controls.Add(this.editPlayerButton);
            this.managePlayersTabPage.Controls.Add(this.registerPlayerButton);
            this.managePlayersTabPage.Location = new System.Drawing.Point(4, 22);
            this.managePlayersTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.managePlayersTabPage.Name = "managePlayersTabPage";
            this.managePlayersTabPage.Size = new System.Drawing.Size(758, 360);
            this.managePlayersTabPage.TabIndex = 2;
            this.managePlayersTabPage.Text = "Manage Players";
            this.managePlayersTabPage.UseVisualStyleBackColor = true;
            // 
            // manageRoundsTabPage
            // 
            this.manageRoundsTabPage.Controls.Add(this.editRoundUserControl1);
            this.manageRoundsTabPage.Controls.Add(this.addRoundScoredUserControl1);
            this.manageRoundsTabPage.Controls.Add(this.editRoundButton);
            this.manageRoundsTabPage.Controls.Add(this.addRoundButton);
            this.manageRoundsTabPage.Location = new System.Drawing.Point(4, 22);
            this.manageRoundsTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageRoundsTabPage.Name = "manageRoundsTabPage";
            this.manageRoundsTabPage.Size = new System.Drawing.Size(758, 360);
            this.manageRoundsTabPage.TabIndex = 3;
            this.manageRoundsTabPage.Text = "Manage Rounds";
            this.manageRoundsTabPage.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(566, 27);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(162, 24);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Admin Dashboard";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(38, 27);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 13);
            this.welcomeLabel.TabIndex = 2;
            // 
            // addPlayersToLeagueButton
            // 
            this.addPlayersToLeagueButton.Location = new System.Drawing.Point(26, 303);
            this.addPlayersToLeagueButton.Name = "addPlayersToLeagueButton";
            this.addPlayersToLeagueButton.Size = new System.Drawing.Size(148, 28);
            this.addPlayersToLeagueButton.TabIndex = 0;
            this.addPlayersToLeagueButton.Text = "Add Players to League";
            this.addPlayersToLeagueButton.UseVisualStyleBackColor = true;
            this.addPlayersToLeagueButton.Click += new System.EventHandler(this.AddPlayersToLeagueButton_Click);
            // 
            // addLeagueButton
            // 
            this.addLeagueButton.Location = new System.Drawing.Point(26, 34);
            this.addLeagueButton.Name = "addLeagueButton";
            this.addLeagueButton.Size = new System.Drawing.Size(92, 27);
            this.addLeagueButton.TabIndex = 2;
            this.addLeagueButton.Text = "Add League";
            this.addLeagueButton.UseVisualStyleBackColor = true;
            this.addLeagueButton.Click += new System.EventHandler(this.AddLeagueButton_Click);
            // 
            // registerPlayerButton
            // 
            this.registerPlayerButton.Location = new System.Drawing.Point(24, 27);
            this.registerPlayerButton.Name = "registerPlayerButton";
            this.registerPlayerButton.Size = new System.Drawing.Size(100, 27);
            this.registerPlayerButton.TabIndex = 0;
            this.registerPlayerButton.Text = "Register Player";
            this.registerPlayerButton.UseVisualStyleBackColor = true;
            this.registerPlayerButton.Click += new System.EventHandler(this.RegisterPlayerButton_Click);
            // 
            // editPlayerButton
            // 
            this.editPlayerButton.Location = new System.Drawing.Point(24, 82);
            this.editPlayerButton.Name = "editPlayerButton";
            this.editPlayerButton.Size = new System.Drawing.Size(100, 29);
            this.editPlayerButton.TabIndex = 1;
            this.editPlayerButton.Text = "Edit Player";
            this.editPlayerButton.UseVisualStyleBackColor = true;
            this.editPlayerButton.Click += new System.EventHandler(this.EditPlayerButton_Click);
            // 
            // addRoundButton
            // 
            this.addRoundButton.Location = new System.Drawing.Point(17, 37);
            this.addRoundButton.Name = "addRoundButton";
            this.addRoundButton.Size = new System.Drawing.Size(97, 26);
            this.addRoundButton.TabIndex = 0;
            this.addRoundButton.Text = "Add Round";
            this.addRoundButton.UseVisualStyleBackColor = true;
            this.addRoundButton.Click += new System.EventHandler(this.AddRoundButton_Click);
            // 
            // editRoundButton
            // 
            this.editRoundButton.Location = new System.Drawing.Point(17, 92);
            this.editRoundButton.Name = "editRoundButton";
            this.editRoundButton.Size = new System.Drawing.Size(97, 30);
            this.editRoundButton.TabIndex = 1;
            this.editRoundButton.Text = "Edit Round";
            this.editRoundButton.UseVisualStyleBackColor = true;
            this.editRoundButton.Click += new System.EventHandler(this.EditRoundButton_Click);
            // 
            // editLeagueButton
            // 
            this.editLeagueButton.Location = new System.Drawing.Point(26, 87);
            this.editLeagueButton.Name = "editLeagueButton";
            this.editLeagueButton.Size = new System.Drawing.Size(92, 27);
            this.editLeagueButton.TabIndex = 3;
            this.editLeagueButton.Text = "Edit League";
            this.editLeagueButton.UseVisualStyleBackColor = true;
            this.editLeagueButton.Click += new System.EventHandler(this.EditLeagueButton_Click);
            // 
            // addLeagueUserControl1
            // 
            this.addLeagueUserControl1.Location = new System.Drawing.Point(237, 16);
            this.addLeagueUserControl1.Name = "addLeagueUserControl1";
            this.addLeagueUserControl1.Size = new System.Drawing.Size(302, 280);
            this.addLeagueUserControl1.TabIndex = 4;
            // 
            // addLeaguePlayerUserControl1
            // 
            this.addLeaguePlayerUserControl1.Location = new System.Drawing.Point(195, 5);
            this.addLeaguePlayerUserControl1.Name = "addLeaguePlayerUserControl1";
            this.addLeaguePlayerUserControl1.Size = new System.Drawing.Size(377, 331);
            this.addLeaguePlayerUserControl1.TabIndex = 1;
            // 
            // registerPlayerUserControl1
            // 
            this.registerPlayerUserControl1.Location = new System.Drawing.Point(166, 11);
            this.registerPlayerUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerPlayerUserControl1.Name = "registerPlayerUserControl1";
            this.registerPlayerUserControl1.Size = new System.Drawing.Size(441, 292);
            this.registerPlayerUserControl1.TabIndex = 2;
            // 
            // editRoundUserControl1
            // 
            this.editRoundUserControl1.Location = new System.Drawing.Point(166, 4);
            this.editRoundUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.editRoundUserControl1.Name = "editRoundUserControl1";
            this.editRoundUserControl1.Size = new System.Drawing.Size(413, 321);
            this.editRoundUserControl1.TabIndex = 3;
            // 
            // addRoundScoredUserControl1
            // 
            this.addRoundScoredUserControl1.Location = new System.Drawing.Point(132, 4);
            this.addRoundScoredUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addRoundScoredUserControl1.Name = "addRoundScoredUserControl1";
            this.addRoundScoredUserControl1.Size = new System.Drawing.Size(471, 356);
            this.addRoundScoredUserControl1.TabIndex = 2;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 453);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.adminTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.adminTabControl.ResumeLayout(false);
            this.manageLeaguesTabPage.ResumeLayout(false);
            this.managePlayersTabPage.ResumeLayout(false);
            this.manageRoundsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage manageLeaguesTabPage;
        private System.Windows.Forms.TabPage manageUsersTabPage;
        private System.Windows.Forms.TabPage managePlayersTabPage;
        private System.Windows.Forms.TabPage manageRoundsTabPage;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private UserControls.AddLeaguePlayerUserControl addLeaguePlayerUserControl1;
        private System.Windows.Forms.Button addPlayersToLeagueButton;
        private System.Windows.Forms.Button addLeagueButton;
        private UserControls.RegisterPlayerUserControl registerPlayerUserControl1;
        private System.Windows.Forms.Button editPlayerButton;
        private System.Windows.Forms.Button registerPlayerButton;
        private UserControls.EditRoundUserControl editRoundUserControl1;
        private UserControls.AddRoundScoredUserControl addRoundScoredUserControl1;
        private System.Windows.Forms.Button editRoundButton;
        private System.Windows.Forms.Button addRoundButton;
        private System.Windows.Forms.Button editLeagueButton;
        private UserControls.AddLeagueUserControl addLeagueUserControl1;
    }
}