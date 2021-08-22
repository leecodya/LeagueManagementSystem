namespace LeageManagementSystem.UserControls
{
    partial class EditRoundUserControl
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
            this.editRoundButton = new System.Windows.Forms.Button();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.playerComboBox = new System.Windows.Forms.ComboBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.leagueComboBox = new System.Windows.Forms.ComboBox();
            this.leagueLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.datesOfRoundsComboBox = new System.Windows.Forms.ComboBox();
            this.searchDatesButton = new System.Windows.Forms.Button();
            this.clearnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editRoundButton
            // 
            this.editRoundButton.Location = new System.Drawing.Point(170, 262);
            this.editRoundButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editRoundButton.Name = "editRoundButton";
            this.editRoundButton.Size = new System.Drawing.Size(70, 23);
            this.editRoundButton.TabIndex = 6;
            this.editRoundButton.Text = "Update";
            this.editRoundButton.UseVisualStyleBackColor = true;
            this.editRoundButton.Click += new System.EventHandler(this.EditRoundButton_Click);
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(170, 219);
            this.scoreTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(56, 20);
            this.scoreTextBox.TabIndex = 5;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(123, 221);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(42, 13);
            this.scoreLabel.TabIndex = 17;
            this.scoreLabel.Text = "*Score:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(82, 183);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(84, 13);
            this.dateLabel.TabIndex = 16;
            this.dateLabel.Text = "*Date of Round:";
            // 
            // playerComboBox
            // 
            this.playerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerComboBox.FormattingEnabled = true;
            this.playerComboBox.Location = new System.Drawing.Point(170, 102);
            this.playerComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playerComboBox.Name = "playerComboBox";
            this.playerComboBox.Size = new System.Drawing.Size(139, 21);
            this.playerComboBox.TabIndex = 2;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(121, 104);
            this.playerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(43, 13);
            this.playerLabel.TabIndex = 13;
            this.playerLabel.Text = "*Player:";
            // 
            // leagueComboBox
            // 
            this.leagueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leagueComboBox.FormattingEnabled = true;
            this.leagueComboBox.Location = new System.Drawing.Point(170, 62);
            this.leagueComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leagueComboBox.Name = "leagueComboBox";
            this.leagueComboBox.Size = new System.Drawing.Size(139, 21);
            this.leagueComboBox.TabIndex = 1;
            this.leagueComboBox.SelectedIndexChanged += new System.EventHandler(this.LeagueComboBox_SelectedIndexChanged);
            // 
            // leagueLabel
            // 
            this.leagueLabel.AutoSize = true;
            this.leagueLabel.Location = new System.Drawing.Point(115, 64);
            this.leagueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.leagueLabel.Name = "leagueLabel";
            this.leagueLabel.Size = new System.Drawing.Size(50, 13);
            this.leagueLabel.TabIndex = 10;
            this.leagueLabel.Text = "*League:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(147, 15);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(135, 20);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Edit Round Score";
            // 
            // datesOfRoundsComboBox
            // 
            this.datesOfRoundsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datesOfRoundsComboBox.FormattingEnabled = true;
            this.datesOfRoundsComboBox.Location = new System.Drawing.Point(170, 183);
            this.datesOfRoundsComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datesOfRoundsComboBox.Name = "datesOfRoundsComboBox";
            this.datesOfRoundsComboBox.Size = new System.Drawing.Size(139, 21);
            this.datesOfRoundsComboBox.TabIndex = 4;
            // 
            // searchDatesButton
            // 
            this.searchDatesButton.Location = new System.Drawing.Point(170, 133);
            this.searchDatesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchDatesButton.Name = "searchDatesButton";
            this.searchDatesButton.Size = new System.Drawing.Size(100, 28);
            this.searchDatesButton.TabIndex = 3;
            this.searchDatesButton.Text = "Search Dates";
            this.searchDatesButton.UseVisualStyleBackColor = true;
            this.searchDatesButton.Click += new System.EventHandler(this.SearchDatesButton_Click);
            // 
            // clearnButton
            // 
            this.clearnButton.Location = new System.Drawing.Point(275, 262);
            this.clearnButton.Name = "clearnButton";
            this.clearnButton.Size = new System.Drawing.Size(75, 23);
            this.clearnButton.TabIndex = 7;
            this.clearnButton.Text = "Clear";
            this.clearnButton.UseVisualStyleBackColor = true;
            this.clearnButton.Click += new System.EventHandler(this.ClearnButton_Click);
            // 
            // EditRoundUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearnButton);
            this.Controls.Add(this.searchDatesButton);
            this.Controls.Add(this.datesOfRoundsComboBox);
            this.Controls.Add(this.editRoundButton);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.playerComboBox);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.leagueComboBox);
            this.Controls.Add(this.leagueLabel);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditRoundUserControl";
            this.Size = new System.Drawing.Size(413, 321);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editRoundButton;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ComboBox playerComboBox;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.ComboBox leagueComboBox;
        private System.Windows.Forms.Label leagueLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox datesOfRoundsComboBox;
        private System.Windows.Forms.Button searchDatesButton;
        private System.Windows.Forms.Button clearnButton;
    }
}
