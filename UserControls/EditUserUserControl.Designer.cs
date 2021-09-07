namespace LeagueManagementSystem.UserControls
{
    partial class EditUserUserControl
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
            this.searchButton = new System.Windows.Forms.Button();
            this.privilegesComboBox = new System.Windows.Forms.ComboBox();
            this.playerIDTextBox = new System.Windows.Forms.TextBox();
            this.playerIDLabel = new System.Windows.Forms.Label();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.privilegesLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(239, 43);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(69, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // privilegesComboBox
            // 
            this.privilegesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.privilegesComboBox.FormattingEnabled = true;
            this.privilegesComboBox.Items.AddRange(new object[] {
            "admin",
            "regular"});
            this.privilegesComboBox.Location = new System.Drawing.Point(112, 145);
            this.privilegesComboBox.Name = "privilegesComboBox";
            this.privilegesComboBox.Size = new System.Drawing.Size(140, 21);
            this.privilegesComboBox.TabIndex = 4;
            // 
            // playerIDTextBox
            // 
            this.playerIDTextBox.Location = new System.Drawing.Point(112, 183);
            this.playerIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.playerIDTextBox.Name = "playerIDTextBox";
            this.playerIDTextBox.ReadOnly = true;
            this.playerIDTextBox.Size = new System.Drawing.Size(140, 20);
            this.playerIDTextBox.TabIndex = 5;
            // 
            // playerIDLabel
            // 
            this.playerIDLabel.AutoSize = true;
            this.playerIDLabel.Location = new System.Drawing.Point(43, 186);
            this.playerIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerIDLabel.Name = "playerIDLabel";
            this.playerIDLabel.Size = new System.Drawing.Size(57, 13);
            this.playerIDLabel.TabIndex = 38;
            this.playerIDLabel.Text = "*Player ID:";
            // 
            // updateUserButton
            // 
            this.updateUserButton.Location = new System.Drawing.Point(112, 228);
            this.updateUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(75, 26);
            this.updateUserButton.TabIndex = 6;
            this.updateUserButton.Text = "Update";
            this.updateUserButton.UseVisualStyleBackColor = true;
            this.updateUserButton.Click += new System.EventHandler(this.UpdateUserButton_Click);
            // 
            // privilegesLabel
            // 
            this.privilegesLabel.AutoSize = true;
            this.privilegesLabel.Location = new System.Drawing.Point(41, 148);
            this.privilegesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.privilegesLabel.Name = "privilegesLabel";
            this.privilegesLabel.Size = new System.Drawing.Size(59, 13);
            this.privilegesLabel.TabIndex = 37;
            this.privilegesLabel.Text = "*Privileges:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(112, 109);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(140, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(40, 112);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 13);
            this.passwordLabel.TabIndex = 36;
            this.passwordLabel.Text = "*Password:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(112, 45);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(110, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(38, 48);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(62, 13);
            this.usernameLabel.TabIndex = 35;
            this.usernameLabel.Text = "*Username:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(125, 11);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(75, 20);
            this.titleLabel.TabIndex = 34;
            this.titleLabel.Text = "Edit User";
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(214, 228);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(75, 26);
            this.deleteUserButton.TabIndex = 7;
            this.deleteUserButton.Text = "Delete";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            // 
            // EditUserUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.privilegesComboBox);
            this.Controls.Add(this.playerIDTextBox);
            this.Controls.Add(this.playerIDLabel);
            this.Controls.Add(this.updateUserButton);
            this.Controls.Add(this.privilegesLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "EditUserUserControl";
            this.Size = new System.Drawing.Size(326, 311);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox privilegesComboBox;
        private System.Windows.Forms.TextBox playerIDTextBox;
        private System.Windows.Forms.Label playerIDLabel;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.Label privilegesLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button deleteUserButton;
    }
}
