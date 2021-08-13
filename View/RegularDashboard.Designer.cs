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
            this.editRoundButon = new System.Windows.Forms.Button();
            this.addRoundButton = new System.Windows.Forms.Button();
            this.addPlayerToLeagueTabPage = new System.Windows.Forms.TabPage();
            this.myInformationTabPage = new System.Windows.Forms.TabPage();
            this.titleLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.registerPlayerUserControl1 = new LeageManagementSystem.UserControls.RegisterPlayerUserControl();
            this.addRoundScoredUserControl1 = new LeageManagementSystem.UserControls.AddRoundScoredUserControl();
            this.editRoundUserControl1 = new LeageManagementSystem.UserControls.EditRoundUserControl();
            this.mainTabControl.SuspendLayout();
            this.registerPlayerTabPage.SuspendLayout();
            this.addRoundScoredTabPage.SuspendLayout();
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
            this.registerPlayerTabPage.Controls.Add(this.registerPlayerUserControl1);
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
            this.addRoundScoredTabPage.Controls.Add(this.addRoundScoredUserControl1);
            this.addRoundScoredTabPage.Controls.Add(this.editRoundUserControl1);
            this.addRoundScoredTabPage.Controls.Add(this.editRoundButon);
            this.addRoundScoredTabPage.Controls.Add(this.addRoundButton);
            this.addRoundScoredTabPage.Location = new System.Drawing.Point(4, 25);
            this.addRoundScoredTabPage.Name = "addRoundScoredTabPage";
            this.addRoundScoredTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addRoundScoredTabPage.Size = new System.Drawing.Size(1016, 446);
            this.addRoundScoredTabPage.TabIndex = 1;
            this.addRoundScoredTabPage.Text = "Add Round Scored";
            this.addRoundScoredTabPage.UseVisualStyleBackColor = true;
            // 
            // editRoundButon
            // 
            this.editRoundButon.Location = new System.Drawing.Point(29, 121);
            this.editRoundButon.Name = "editRoundButon";
            this.editRoundButon.Size = new System.Drawing.Size(111, 40);
            this.editRoundButon.TabIndex = 2;
            this.editRoundButon.Text = "Edit Round";
            this.editRoundButon.UseVisualStyleBackColor = true;
            this.editRoundButon.Click += new System.EventHandler(this.EditRoundButon_Click);
            // 
            // addRoundButton
            // 
            this.addRoundButton.Location = new System.Drawing.Point(29, 44);
            this.addRoundButton.Name = "addRoundButton";
            this.addRoundButton.Size = new System.Drawing.Size(111, 38);
            this.addRoundButton.TabIndex = 1;
            this.addRoundButton.Text = "Add Round";
            this.addRoundButton.UseVisualStyleBackColor = true;
            this.addRoundButton.Click += new System.EventHandler(this.AddRoundButton_Click);
            // 
            // addPlayerToLeagueTabPage
            // 
            this.addPlayerToLeagueTabPage.Location = new System.Drawing.Point(4, 25);
            this.addPlayerToLeagueTabPage.Name = "addPlayerToLeagueTabPage";
            this.addPlayerToLeagueTabPage.Size = new System.Drawing.Size(1016, 446);
            this.addPlayerToLeagueTabPage.TabIndex = 2;
            this.addPlayerToLeagueTabPage.Text = "Add Player to League";
            this.addPlayerToLeagueTabPage.UseVisualStyleBackColor = true;
            // 
            // myInformationTabPage
            // 
            this.myInformationTabPage.Location = new System.Drawing.Point(4, 25);
            this.myInformationTabPage.Name = "myInformationTabPage";
            this.myInformationTabPage.Size = new System.Drawing.Size(1016, 446);
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
            // registerPlayerUserControl1
            // 
            this.registerPlayerUserControl1.Location = new System.Drawing.Point(213, 32);
            this.registerPlayerUserControl1.Name = "registerPlayerUserControl1";
            this.registerPlayerUserControl1.Size = new System.Drawing.Size(559, 334);
            this.registerPlayerUserControl1.TabIndex = 0;
            // 
            // addRoundScoredUserControl1
            // 
            this.addRoundScoredUserControl1.Location = new System.Drawing.Point(204, 26);
            this.addRoundScoredUserControl1.Name = "addRoundScoredUserControl1";
            this.addRoundScoredUserControl1.Size = new System.Drawing.Size(628, 398);
            this.addRoundScoredUserControl1.TabIndex = 4;
            // 
            // editRoundUserControl1
            // 
            this.editRoundUserControl1.Location = new System.Drawing.Point(249, 16);
            this.editRoundUserControl1.Name = "editRoundUserControl1";
            this.editRoundUserControl1.Size = new System.Drawing.Size(551, 395);
            this.editRoundUserControl1.TabIndex = 3;
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
            this.registerPlayerTabPage.ResumeLayout(false);
            this.addRoundScoredTabPage.ResumeLayout(false);
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
        private UserControls.RegisterPlayerUserControl registerPlayerUserControl1;
        private System.Windows.Forms.Button editRoundButon;
        private System.Windows.Forms.Button addRoundButton;
        private UserControls.EditRoundUserControl editRoundUserControl1;
        private UserControls.AddRoundScoredUserControl addRoundScoredUserControl1;
    }
}