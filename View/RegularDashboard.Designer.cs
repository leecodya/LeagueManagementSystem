namespace LeageManagementSystem.View
{
    partial class RegularDashboard
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.registerPlayerTabPage = new System.Windows.Forms.TabPage();
            this.addRoundScoredTabPage = new System.Windows.Forms.TabPage();
            this.addPlayerToLeagueTabPage = new System.Windows.Forms.TabPage();
            this.myInformationTabPage = new System.Windows.Forms.TabPage();
            this.titleLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.registerPlayerTabPage);
            this.mainTabControl.Controls.Add(this.addRoundScoredTabPage);
            this.mainTabControl.Controls.Add(this.addPlayerToLeagueTabPage);
            this.mainTabControl.Controls.Add(this.myInformationTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(2, 84);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1024, 475);
            this.mainTabControl.TabIndex = 0;
            // 
            // registerPlayerTabPage
            // 
            this.registerPlayerTabPage.Location = new System.Drawing.Point(4, 25);
            this.registerPlayerTabPage.Name = "registerPlayerTabPage";
            this.registerPlayerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.registerPlayerTabPage.Size = new System.Drawing.Size(1016, 446);
            this.registerPlayerTabPage.TabIndex = 0;
            this.registerPlayerTabPage.Text = "Register Player";
            this.registerPlayerTabPage.UseVisualStyleBackColor = true;
            // 
            // addRoundScoredTabPage
            // 
            this.addRoundScoredTabPage.Location = new System.Drawing.Point(4, 25);
            this.addRoundScoredTabPage.Name = "addRoundScoredTabPage";
            this.addRoundScoredTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addRoundScoredTabPage.Size = new System.Drawing.Size(1016, 446);
            this.addRoundScoredTabPage.TabIndex = 1;
            this.addRoundScoredTabPage.Text = "Add Round Scored";
            this.addRoundScoredTabPage.UseVisualStyleBackColor = true;
            // 
            // addPlayerToLeagueTabPage
            // 
            this.addPlayerToLeagueTabPage.Location = new System.Drawing.Point(4, 25);
            this.addPlayerToLeagueTabPage.Name = "addPlayerToLeagueTabPage";
            this.addPlayerToLeagueTabPage.Size = new System.Drawing.Size(1016, 408);
            this.addPlayerToLeagueTabPage.TabIndex = 2;
            this.addPlayerToLeagueTabPage.Text = "Add Player to League";
            this.addPlayerToLeagueTabPage.UseVisualStyleBackColor = true;
            // 
            // myInformationTabPage
            // 
            this.myInformationTabPage.Location = new System.Drawing.Point(4, 25);
            this.myInformationTabPage.Name = "myInformationTabPage";
            this.myInformationTabPage.Size = new System.Drawing.Size(1016, 408);
            this.myInformationTabPage.TabIndex = 3;
            this.myInformationTabPage.Text = "My Information";
            this.myInformationTabPage.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(759, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(189, 29);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Main Dashboard";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(68, 42);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 17);
            this.welcomeLabel.TabIndex = 2;
            // 
            // RegularDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 558);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegularDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Dashboard";
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage registerPlayerTabPage;
        private System.Windows.Forms.TabPage addRoundScoredTabPage;
        private System.Windows.Forms.TabPage addPlayerToLeagueTabPage;
        private System.Windows.Forms.TabPage myInformationTabPage;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label welcomeLabel;
    }
}