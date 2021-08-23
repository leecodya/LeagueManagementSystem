namespace LeageManagementSystem.UserControls
{
    partial class AddLeaguePlayerUserControl
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
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.playerComboBox = new System.Windows.Forms.ComboBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.leagueComboBox = new System.Windows.Forms.ComboBox();
            this.leagueLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(139, 145);
            this.addPlayerButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(100, 28);
            this.addPlayerButton.TabIndex = 16;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // playerComboBox
            // 
            this.playerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerComboBox.FormattingEnabled = true;
            this.playerComboBox.Location = new System.Drawing.Point(139, 105);
            this.playerComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.playerComboBox.Name = "playerComboBox";
            this.playerComboBox.Size = new System.Drawing.Size(139, 21);
            this.playerComboBox.TabIndex = 15;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(90, 107);
            this.playerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(43, 13);
            this.playerLabel.TabIndex = 19;
            this.playerLabel.Text = "*Player:";
            // 
            // leagueComboBox
            // 
            this.leagueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leagueComboBox.FormattingEnabled = true;
            this.leagueComboBox.Location = new System.Drawing.Point(139, 65);
            this.leagueComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.leagueComboBox.Name = "leagueComboBox";
            this.leagueComboBox.Size = new System.Drawing.Size(139, 21);
            this.leagueComboBox.TabIndex = 14;
            // 
            // leagueLabel
            // 
            this.leagueLabel.AutoSize = true;
            this.leagueLabel.Location = new System.Drawing.Point(84, 67);
            this.leagueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.leagueLabel.Name = "leagueLabel";
            this.leagueLabel.Size = new System.Drawing.Size(50, 13);
            this.leagueLabel.TabIndex = 18;
            this.leagueLabel.Text = "*League:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(116, 18);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(161, 20);
            this.titleLabel.TabIndex = 17;
            this.titleLabel.Text = "Add Player to League";
            // 
            // AddLeaguePlayerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.playerComboBox);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.leagueComboBox);
            this.Controls.Add(this.leagueLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "AddLeaguePlayerUserControl";
            this.Size = new System.Drawing.Size(377, 331);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.ComboBox playerComboBox;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.ComboBox leagueComboBox;
        private System.Windows.Forms.Label leagueLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}
