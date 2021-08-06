namespace LeageManagementSystem.UserControls
{
    partial class AddRoundScoredUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.leagueLabel = new System.Windows.Forms.Label();
            this.leagueComboBox = new System.Windows.Forms.ComboBox();
            this.playerComboBox = new System.Windows.Forms.ComboBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.dateOfRoundTextBox = new System.Windows.Forms.TextBox();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.addRoundScoredButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(233, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(178, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Add Round Scored";
            // 
            // leagueLabel
            // 
            this.leagueLabel.AutoSize = true;
            this.leagueLabel.Location = new System.Drawing.Point(198, 71);
            this.leagueLabel.Name = "leagueLabel";
            this.leagueLabel.Size = new System.Drawing.Size(65, 17);
            this.leagueLabel.TabIndex = 1;
            this.leagueLabel.Text = "*League:";
            // 
            // leagueComboBox
            // 
            this.leagueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leagueComboBox.FormattingEnabled = true;
            this.leagueComboBox.Location = new System.Drawing.Point(271, 68);
            this.leagueComboBox.Name = "leagueComboBox";
            this.leagueComboBox.Size = new System.Drawing.Size(184, 24);
            this.leagueComboBox.TabIndex = 1;
            this.leagueComboBox.SelectedIndexChanged += new System.EventHandler(this.LeagueComboBox_SelectedIndexChanged);
            // 
            // playerComboBox
            // 
            this.playerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerComboBox.FormattingEnabled = true;
            this.playerComboBox.Location = new System.Drawing.Point(271, 117);
            this.playerComboBox.Name = "playerComboBox";
            this.playerComboBox.Size = new System.Drawing.Size(184, 24);
            this.playerComboBox.TabIndex = 2;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(206, 120);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(57, 17);
            this.playerLabel.TabIndex = 3;
            this.playerLabel.Text = "*Player:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(154, 169);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(109, 17);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "*Date of Round:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(209, 216);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(54, 17);
            this.scoreLabel.TabIndex = 7;
            this.scoreLabel.Text = "*Score:";
            // 
            // dateOfRoundTextBox
            // 
            this.dateOfRoundTextBox.Location = new System.Drawing.Point(271, 166);
            this.dateOfRoundTextBox.Name = "dateOfRoundTextBox";
            this.dateOfRoundTextBox.Size = new System.Drawing.Size(148, 22);
            this.dateOfRoundTextBox.TabIndex = 3;
            this.dateOfRoundTextBox.Enter += new System.EventHandler(this.DateOfRoundTextBox_Enter_1);
            this.dateOfRoundTextBox.Leave += new System.EventHandler(this.DateOfRoundTextBox_Leave);
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(271, 213);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(73, 22);
            this.scoreTextBox.TabIndex = 4;
            // 
            // addRoundScoredButton
            // 
            this.addRoundScoredButton.Location = new System.Drawing.Point(271, 266);
            this.addRoundScoredButton.Name = "addRoundScoredButton";
            this.addRoundScoredButton.Size = new System.Drawing.Size(94, 28);
            this.addRoundScoredButton.TabIndex = 5;
            this.addRoundScoredButton.Text = "Add";
            this.addRoundScoredButton.UseVisualStyleBackColor = true;
            this.addRoundScoredButton.Click += new System.EventHandler(this.AddRoundScoredButton_Click);
            // 
            // AddRoundScoredUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addRoundScoredButton);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.dateOfRoundTextBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.playerComboBox);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.leagueComboBox);
            this.Controls.Add(this.leagueLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "AddRoundScoredUserControl";
            this.Size = new System.Drawing.Size(628, 438);
            this.Load += new System.EventHandler(this.AddRoundScoredUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label leagueLabel;
        private System.Windows.Forms.ComboBox leagueComboBox;
        private System.Windows.Forms.ComboBox playerComboBox;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox dateOfRoundTextBox;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Button addRoundScoredButton;
    }
}
