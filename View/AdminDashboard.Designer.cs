namespace LeageManagementSystem.View
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
            this.adminTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.manageLeaguesTabPage);
            this.adminTabControl.Controls.Add(this.manageUsersTabPage);
            this.adminTabControl.Controls.Add(this.managePlayersTabPage);
            this.adminTabControl.Controls.Add(this.manageRoundsTabPage);
            this.adminTabControl.Location = new System.Drawing.Point(2, 82);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(1022, 475);
            this.adminTabControl.TabIndex = 0;
            // 
            // manageLeaguesTabPage
            // 
            this.manageLeaguesTabPage.Location = new System.Drawing.Point(4, 25);
            this.manageLeaguesTabPage.Name = "manageLeaguesTabPage";
            this.manageLeaguesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.manageLeaguesTabPage.Size = new System.Drawing.Size(1014, 446);
            this.manageLeaguesTabPage.TabIndex = 0;
            this.manageLeaguesTabPage.Text = "Manage Leagues";
            this.manageLeaguesTabPage.UseVisualStyleBackColor = true;
            // 
            // manageUsersTabPage
            // 
            this.manageUsersTabPage.Location = new System.Drawing.Point(4, 25);
            this.manageUsersTabPage.Name = "manageUsersTabPage";
            this.manageUsersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.manageUsersTabPage.Size = new System.Drawing.Size(1014, 432);
            this.manageUsersTabPage.TabIndex = 1;
            this.manageUsersTabPage.Text = "Manage Users";
            this.manageUsersTabPage.UseVisualStyleBackColor = true;
            // 
            // managePlayersTabPage
            // 
            this.managePlayersTabPage.Location = new System.Drawing.Point(4, 25);
            this.managePlayersTabPage.Name = "managePlayersTabPage";
            this.managePlayersTabPage.Size = new System.Drawing.Size(1014, 432);
            this.managePlayersTabPage.TabIndex = 2;
            this.managePlayersTabPage.Text = "Manage Players";
            this.managePlayersTabPage.UseVisualStyleBackColor = true;
            // 
            // manageRoundsTabPage
            // 
            this.manageRoundsTabPage.Location = new System.Drawing.Point(4, 25);
            this.manageRoundsTabPage.Name = "manageRoundsTabPage";
            this.manageRoundsTabPage.Size = new System.Drawing.Size(1014, 432);
            this.manageRoundsTabPage.TabIndex = 3;
            this.manageRoundsTabPage.Text = "Manage Rounds";
            this.manageRoundsTabPage.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(755, 33);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(205, 29);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Admin Dashboard";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(51, 33);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 17);
            this.welcomeLabel.TabIndex = 2;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 558);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.adminTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.adminTabControl.ResumeLayout(false);
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
    }
}