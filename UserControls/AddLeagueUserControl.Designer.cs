namespace LeageManagementSystem.UserControls
{
    partial class AddLeagueUserControl
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
            this.createLeagueButton = new System.Windows.Forms.Button();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.leagueNameTextBox = new System.Windows.Forms.TextBox();
            this.leagueNameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createLeagueButton
            // 
            this.createLeagueButton.Location = new System.Drawing.Point(124, 195);
            this.createLeagueButton.Margin = new System.Windows.Forms.Padding(2);
            this.createLeagueButton.Name = "createLeagueButton";
            this.createLeagueButton.Size = new System.Drawing.Size(75, 26);
            this.createLeagueButton.TabIndex = 15;
            this.createLeagueButton.Text = "Create";
            this.createLeagueButton.UseVisualStyleBackColor = true;
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(124, 118);
            this.endDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(109, 20);
            this.endDateTextBox.TabIndex = 14;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(53, 121);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(59, 13);
            this.endDateLabel.TabIndex = 13;
            this.endDateLabel.Text = "*End Date:";
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(124, 79);
            this.startDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(109, 20);
            this.startDateTextBox.TabIndex = 12;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(50, 82);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(62, 13);
            this.startDateLabel.TabIndex = 11;
            this.startDateLabel.Text = "*Start Date:";
            // 
            // leagueNameTextBox
            // 
            this.leagueNameTextBox.Location = new System.Drawing.Point(124, 42);
            this.leagueNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.leagueNameTextBox.Name = "leagueNameTextBox";
            this.leagueNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.leagueNameTextBox.TabIndex = 10;
            // 
            // leagueNameLabel
            // 
            this.leagueNameLabel.AutoSize = true;
            this.leagueNameLabel.Location = new System.Drawing.Point(31, 45);
            this.leagueNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.leagueNameLabel.Name = "leagueNameLabel";
            this.leagueNameLabel.Size = new System.Drawing.Size(81, 13);
            this.leagueNameLabel.TabIndex = 9;
            this.leagueNameLabel.Text = "*League Name:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(103, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(96, 20);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Add League";
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(124, 156);
            this.courseNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.courseNameTextBox.TabIndex = 17;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(34, 159);
            this.courseNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(78, 13);
            this.courseNameLabel.TabIndex = 16;
            this.courseNameLabel.Text = "*Course Name:";
            // 
            // AddLeagueUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.courseNameTextBox);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.createLeagueButton);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.leagueNameTextBox);
            this.Controls.Add(this.leagueNameLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "AddLeagueUserControl";
            this.Size = new System.Drawing.Size(302, 280);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createLeagueButton;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.TextBox leagueNameTextBox;
        private System.Windows.Forms.Label leagueNameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.Label courseNameLabel;
    }
}
