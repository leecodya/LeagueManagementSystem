namespace LeageManagementSystem.UserControls
{
    partial class EditLeagueUserControl
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
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.leagueNameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.leagueNameComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(115, 179);
            this.courseNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.courseNameTextBox.TabIndex = 5;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(29, 182);
            this.courseNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(74, 13);
            this.courseNameLabel.TabIndex = 26;
            this.courseNameLabel.Text = "Course Name:";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(115, 218);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 26);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(115, 141);
            this.endDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(109, 20);
            this.endDateTextBox.TabIndex = 4;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(48, 144);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(55, 13);
            this.endDateLabel.TabIndex = 23;
            this.endDateLabel.Text = "End Date:";
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(115, 102);
            this.startDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(109, 20);
            this.startDateTextBox.TabIndex = 3;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(45, 105);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(58, 13);
            this.startDateLabel.TabIndex = 21;
            this.startDateLabel.Text = "Start Date:";
            // 
            // leagueNameLabel
            // 
            this.leagueNameLabel.AutoSize = true;
            this.leagueNameLabel.Location = new System.Drawing.Point(22, 50);
            this.leagueNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.leagueNameLabel.Name = "leagueNameLabel";
            this.leagueNameLabel.Size = new System.Drawing.Size(81, 13);
            this.leagueNameLabel.TabIndex = 19;
            this.leagueNameLabel.Text = "*League Name:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(141, 11);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(95, 20);
            this.titleLabel.TabIndex = 18;
            this.titleLabel.Text = "Edit League";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(272, 45);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(223, 218);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 26);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // leagueNameComboBox
            // 
            this.leagueNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leagueNameComboBox.FormattingEnabled = true;
            this.leagueNameComboBox.Location = new System.Drawing.Point(115, 46);
            this.leagueNameComboBox.Name = "leagueNameComboBox";
            this.leagueNameComboBox.Size = new System.Drawing.Size(151, 21);
            this.leagueNameComboBox.TabIndex = 1;
            // 
            // EditLeagueUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.leagueNameComboBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.courseNameTextBox);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.leagueNameLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "EditLeagueUserControl";
            this.Size = new System.Drawing.Size(386, 297);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label leagueNameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox leagueNameComboBox;
    }
}
