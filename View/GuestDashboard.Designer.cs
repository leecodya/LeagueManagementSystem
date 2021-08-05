namespace LeageManagementSystem.View
{
    partial class GuestDashboard
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.addRoundScoredTabPage = new System.Windows.Forms.TabPage();
            this.guestTabControl = new System.Windows.Forms.TabControl();
            this.addRoundScoredUserControl1 = new LeageManagementSystem.UserControls.AddRoundScoredUserControl();
            this.addRoundScoredTabPage.SuspendLayout();
            this.guestTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(738, 45);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(200, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Guest Dashboard";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(40, 45);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(130, 20);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome guest!";
            // 
            // addRoundScoredTabPage
            // 
            this.addRoundScoredTabPage.Controls.Add(this.addRoundScoredUserControl1);
            this.addRoundScoredTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoundScoredTabPage.Location = new System.Drawing.Point(4, 27);
            this.addRoundScoredTabPage.Name = "addRoundScoredTabPage";
            this.addRoundScoredTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addRoundScoredTabPage.Size = new System.Drawing.Size(1012, 421);
            this.addRoundScoredTabPage.TabIndex = 0;
            this.addRoundScoredTabPage.Text = "Add Round Scored";
            this.addRoundScoredTabPage.UseVisualStyleBackColor = true;
            // 
            // guestTabControl
            // 
            this.guestTabControl.Controls.Add(this.addRoundScoredTabPage);
            this.guestTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestTabControl.Location = new System.Drawing.Point(1, 104);
            this.guestTabControl.Name = "guestTabControl";
            this.guestTabControl.SelectedIndex = 0;
            this.guestTabControl.Size = new System.Drawing.Size(1020, 452);
            this.guestTabControl.TabIndex = 2;
            // 
            // addRoundScoredUserControl1
            // 
            this.addRoundScoredUserControl1.Location = new System.Drawing.Point(138, 6);
            this.addRoundScoredUserControl1.Name = "addRoundScoredUserControl1";
            this.addRoundScoredUserControl1.Size = new System.Drawing.Size(628, 438);
            this.addRoundScoredUserControl1.TabIndex = 0;
            // 
            // GuestDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 558);
            this.Controls.Add(this.guestTabControl);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuestDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest Dashboard";
            this.addRoundScoredTabPage.ResumeLayout(false);
            this.guestTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TabPage addRoundScoredTabPage;
        private System.Windows.Forms.TabControl guestTabControl;
        private UserControls.AddRoundScoredUserControl addRoundScoredUserControl1;
    }
}