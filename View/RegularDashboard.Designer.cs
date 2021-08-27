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
            this.registerPlayerUserControl1 = new LeageManagementSystem.UserControls.RegisterPlayerUserControl();
            this.addRoundScoredTabPage = new System.Windows.Forms.TabPage();
            this.addRoundScoredUserControl1 = new LeageManagementSystem.UserControls.AddRoundScoredUserControl();
            this.editRoundUserControl1 = new LeageManagementSystem.UserControls.EditRoundUserControl();
            this.editRoundButon = new System.Windows.Forms.Button();
            this.addRoundButton = new System.Windows.Forms.Button();
            this.addPlayerToLeagueTabPage = new System.Windows.Forms.TabPage();
            this.addLeaguePlayerUserControl1 = new LeageManagementSystem.UserControls.AddLeaguePlayerUserControl();
            this.myInformationTabPage = new System.Windows.Forms.TabPage();
            this.titleLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.myInformationUserControl1 = new LeageManagementSystem.UserControls.MyInformationUserControl();
            this.mainTabControl.SuspendLayout();
            this.registerPlayerTabPage.SuspendLayout();
            this.addRoundScoredTabPage.SuspendLayout();
            this.addPlayerToLeagueTabPage.SuspendLayout();
            this.myInformationTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.registerPlayerTabPage);
            this.mainTabControl.Controls.Add(this.addRoundScoredTabPage);
            this.mainTabControl.Controls.Add(this.addPlayerToLeagueTabPage);
            this.mainTabControl.Controls.Add(this.myInformationTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(2, 68);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(768, 386);
            this.mainTabControl.TabIndex = 0;
            // 
            // registerPlayerTabPage
            // 
            this.registerPlayerTabPage.Controls.Add(this.registerPlayerUserControl1);
            this.registerPlayerTabPage.Location = new System.Drawing.Point(4, 22);
            this.registerPlayerTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.registerPlayerTabPage.Name = "registerPlayerTabPage";
            this.registerPlayerTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.registerPlayerTabPage.Size = new System.Drawing.Size(760, 360);
            this.registerPlayerTabPage.TabIndex = 0;
            this.registerPlayerTabPage.Text = "Register Player";
            this.registerPlayerTabPage.UseVisualStyleBackColor = true;
            // 
            // registerPlayerUserControl1
            // 
            this.registerPlayerUserControl1.Location = new System.Drawing.Point(160, 26);
            this.registerPlayerUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerPlayerUserControl1.Name = "registerPlayerUserControl1";
            this.registerPlayerUserControl1.Size = new System.Drawing.Size(419, 271);
            this.registerPlayerUserControl1.TabIndex = 0;
            // 
            // addRoundScoredTabPage
            // 
            this.addRoundScoredTabPage.Controls.Add(this.addRoundScoredUserControl1);
            this.addRoundScoredTabPage.Controls.Add(this.editRoundUserControl1);
            this.addRoundScoredTabPage.Controls.Add(this.editRoundButon);
            this.addRoundScoredTabPage.Controls.Add(this.addRoundButton);
            this.addRoundScoredTabPage.Location = new System.Drawing.Point(4, 22);
            this.addRoundScoredTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.addRoundScoredTabPage.Name = "addRoundScoredTabPage";
            this.addRoundScoredTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.addRoundScoredTabPage.Size = new System.Drawing.Size(760, 360);
            this.addRoundScoredTabPage.TabIndex = 1;
            this.addRoundScoredTabPage.Text = "Add Round Scored";
            this.addRoundScoredTabPage.UseVisualStyleBackColor = true;
            // 
            // addRoundScoredUserControl1
            // 
            this.addRoundScoredUserControl1.Location = new System.Drawing.Point(153, 21);
            this.addRoundScoredUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addRoundScoredUserControl1.Name = "addRoundScoredUserControl1";
            this.addRoundScoredUserControl1.Size = new System.Drawing.Size(471, 323);
            this.addRoundScoredUserControl1.TabIndex = 4;
            // 
            // editRoundUserControl1
            // 
            this.editRoundUserControl1.Location = new System.Drawing.Point(187, 13);
            this.editRoundUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.editRoundUserControl1.Name = "editRoundUserControl1";
            this.editRoundUserControl1.Size = new System.Drawing.Size(413, 321);
            this.editRoundUserControl1.TabIndex = 3;
            // 
            // editRoundButon
            // 
            this.editRoundButon.Location = new System.Drawing.Point(22, 98);
            this.editRoundButon.Margin = new System.Windows.Forms.Padding(2);
            this.editRoundButon.Name = "editRoundButon";
            this.editRoundButon.Size = new System.Drawing.Size(83, 32);
            this.editRoundButon.TabIndex = 2;
            this.editRoundButon.Text = "Edit Round";
            this.editRoundButon.UseVisualStyleBackColor = true;
            this.editRoundButon.Click += new System.EventHandler(this.EditRoundButon_Click);
            // 
            // addRoundButton
            // 
            this.addRoundButton.Location = new System.Drawing.Point(22, 36);
            this.addRoundButton.Margin = new System.Windows.Forms.Padding(2);
            this.addRoundButton.Name = "addRoundButton";
            this.addRoundButton.Size = new System.Drawing.Size(83, 31);
            this.addRoundButton.TabIndex = 1;
            this.addRoundButton.Text = "Add Round";
            this.addRoundButton.UseVisualStyleBackColor = true;
            this.addRoundButton.Click += new System.EventHandler(this.AddRoundButton_Click);
            // 
            // addPlayerToLeagueTabPage
            // 
            this.addPlayerToLeagueTabPage.Controls.Add(this.addLeaguePlayerUserControl1);
            this.addPlayerToLeagueTabPage.Location = new System.Drawing.Point(4, 22);
            this.addPlayerToLeagueTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.addPlayerToLeagueTabPage.Name = "addPlayerToLeagueTabPage";
            this.addPlayerToLeagueTabPage.Size = new System.Drawing.Size(760, 360);
            this.addPlayerToLeagueTabPage.TabIndex = 2;
            this.addPlayerToLeagueTabPage.Text = "Add Player to League";
            this.addPlayerToLeagueTabPage.UseVisualStyleBackColor = true;
            // 
            // addLeaguePlayerUserControl1
            // 
            this.addLeaguePlayerUserControl1.Location = new System.Drawing.Point(185, 3);
            this.addLeaguePlayerUserControl1.Name = "addLeaguePlayerUserControl1";
            this.addLeaguePlayerUserControl1.Size = new System.Drawing.Size(377, 331);
            this.addLeaguePlayerUserControl1.TabIndex = 0;
            // 
            // myInformationTabPage
            // 
            this.myInformationTabPage.Controls.Add(this.myInformationUserControl1);
            this.myInformationTabPage.Location = new System.Drawing.Point(4, 22);
            this.myInformationTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.myInformationTabPage.Name = "myInformationTabPage";
            this.myInformationTabPage.Size = new System.Drawing.Size(760, 360);
            this.myInformationTabPage.TabIndex = 3;
            this.myInformationTabPage.Text = "My Information";
            this.myInformationTabPage.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(569, 26);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(148, 24);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Main Dashboard";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(51, 34);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 13);
            this.welcomeLabel.TabIndex = 2;
            // 
            // myInformationUserControl1
            // 
            this.myInformationUserControl1.Location = new System.Drawing.Point(192, 12);
            this.myInformationUserControl1.Name = "myInformationUserControl1";
            this.myInformationUserControl1.Size = new System.Drawing.Size(342, 318);
            this.myInformationUserControl1.TabIndex = 0;
            // 
            // RegularDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 453);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegularDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Dashboard";
            this.mainTabControl.ResumeLayout(false);
            this.registerPlayerTabPage.ResumeLayout(false);
            this.addRoundScoredTabPage.ResumeLayout(false);
            this.addPlayerToLeagueTabPage.ResumeLayout(false);
            this.myInformationTabPage.ResumeLayout(false);
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
        private UserControls.AddLeaguePlayerUserControl addLeaguePlayerUserControl1;
        private UserControls.MyInformationUserControl myInformationUserControl1;
    }
}