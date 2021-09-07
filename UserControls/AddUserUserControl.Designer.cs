namespace LeagueManagementSystem.UserControls
{
    partial class AddUserUserControl
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
            this.playerIDTextBox = new System.Windows.Forms.TextBox();
            this.playerIDLabel = new System.Windows.Forms.Label();
            this.createLeagueButton = new System.Windows.Forms.Button();
            this.privilegesLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.privilegesComboBox = new System.Windows.Forms.ComboBox();
            this.playerComboBox = new System.Windows.Forms.ComboBox();
            this.getPlayerIDButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerIDTextBox
            // 
            this.playerIDTextBox.Location = new System.Drawing.Point(118, 219);
            this.playerIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.playerIDTextBox.Name = "playerIDTextBox";
            this.playerIDTextBox.ReadOnly = true;
            this.playerIDTextBox.Size = new System.Drawing.Size(140, 20);
            this.playerIDTextBox.TabIndex = 6;
            // 
            // playerIDLabel
            // 
            this.playerIDLabel.AutoSize = true;
            this.playerIDLabel.Location = new System.Drawing.Point(49, 222);
            this.playerIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerIDLabel.Name = "playerIDLabel";
            this.playerIDLabel.Size = new System.Drawing.Size(57, 13);
            this.playerIDLabel.TabIndex = 26;
            this.playerIDLabel.Text = "*Player ID:";
            // 
            // createLeagueButton
            // 
            this.createLeagueButton.Location = new System.Drawing.Point(118, 258);
            this.createLeagueButton.Margin = new System.Windows.Forms.Padding(2);
            this.createLeagueButton.Name = "createLeagueButton";
            this.createLeagueButton.Size = new System.Drawing.Size(75, 26);
            this.createLeagueButton.TabIndex = 7;
            this.createLeagueButton.Text = "Create";
            this.createLeagueButton.UseVisualStyleBackColor = true;
            this.createLeagueButton.Click += new System.EventHandler(this.CreateLeagueButton_Click);
            // 
            // privilegesLabel
            // 
            this.privilegesLabel.AutoSize = true;
            this.privilegesLabel.Location = new System.Drawing.Point(47, 123);
            this.privilegesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.privilegesLabel.Name = "privilegesLabel";
            this.privilegesLabel.Size = new System.Drawing.Size(59, 13);
            this.privilegesLabel.TabIndex = 25;
            this.privilegesLabel.Text = "*Privileges:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(118, 81);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(140, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(46, 84);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 13);
            this.passwordLabel.TabIndex = 24;
            this.passwordLabel.Text = "*Password:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(118, 44);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(140, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(44, 47);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(62, 13);
            this.usernameLabel.TabIndex = 23;
            this.usernameLabel.Text = "*Username:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(114, 10);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(76, 20);
            this.titleLabel.TabIndex = 22;
            this.titleLabel.Text = "Add User";
            // 
            // privilegesComboBox
            // 
            this.privilegesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.privilegesComboBox.FormattingEnabled = true;
            this.privilegesComboBox.Items.AddRange(new object[] {
            "admin",
            "regular"});
            this.privilegesComboBox.Location = new System.Drawing.Point(118, 120);
            this.privilegesComboBox.Name = "privilegesComboBox";
            this.privilegesComboBox.Size = new System.Drawing.Size(140, 21);
            this.privilegesComboBox.TabIndex = 3;
            // 
            // playerComboBox
            // 
            this.playerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerComboBox.FormattingEnabled = true;
            this.playerComboBox.Location = new System.Drawing.Point(56, 184);
            this.playerComboBox.Name = "playerComboBox";
            this.playerComboBox.Size = new System.Drawing.Size(137, 21);
            this.playerComboBox.TabIndex = 4;
            // 
            // getPlayerIDButton
            // 
            this.getPlayerIDButton.Location = new System.Drawing.Point(207, 182);
            this.getPlayerIDButton.Name = "getPlayerIDButton";
            this.getPlayerIDButton.Size = new System.Drawing.Size(104, 23);
            this.getPlayerIDButton.TabIndex = 5;
            this.getPlayerIDButton.Text = "Get Player ID";
            this.getPlayerIDButton.UseVisualStyleBackColor = true;
            this.getPlayerIDButton.Click += new System.EventHandler(this.GetPlayerIDButton_Click);
            // 
            // AddUserUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.getPlayerIDButton);
            this.Controls.Add(this.playerComboBox);
            this.Controls.Add(this.privilegesComboBox);
            this.Controls.Add(this.playerIDTextBox);
            this.Controls.Add(this.playerIDLabel);
            this.Controls.Add(this.createLeagueButton);
            this.Controls.Add(this.privilegesLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "AddUserUserControl";
            this.Size = new System.Drawing.Size(330, 321);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerIDTextBox;
        private System.Windows.Forms.Label playerIDLabel;
        private System.Windows.Forms.Button createLeagueButton;
        private System.Windows.Forms.Label privilegesLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox privilegesComboBox;
        private System.Windows.Forms.ComboBox playerComboBox;
        private System.Windows.Forms.Button getPlayerIDButton;
    }
}
