﻿namespace LeageManagementSystem.UserControls
{
    partial class MyInformationUserControl
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
            this.updatePlayerButton = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.pdgaNumTextBox = new System.Windows.Forms.TextBox();
            this.pdgaNumLabel = new System.Windows.Forms.Label();
            this.playerComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updatePlayerButton
            // 
            this.updatePlayerButton.Location = new System.Drawing.Point(148, 228);
            this.updatePlayerButton.Margin = new System.Windows.Forms.Padding(2);
            this.updatePlayerButton.Name = "updatePlayerButton";
            this.updatePlayerButton.Size = new System.Drawing.Size(84, 28);
            this.updatePlayerButton.TabIndex = 22;
            this.updatePlayerButton.Text = "Update";
            this.updatePlayerButton.UseVisualStyleBackColor = true;
            this.updatePlayerButton.Click += new System.EventHandler(this.UpdatePlayerButton_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(82, 152);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 25;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(83, 112);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 24;
            this.firstNameLabel.Text = "First Name:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(115, 18);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(114, 20);
            this.titleLabel.TabIndex = 23;
            this.titleLabel.Text = "My Information";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(148, 109);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(109, 20);
            this.firstNameTextBox.TabIndex = 26;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(148, 149);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(109, 20);
            this.lastNameTextBox.TabIndex = 27;
            // 
            // pdgaNumTextBox
            // 
            this.pdgaNumTextBox.Location = new System.Drawing.Point(148, 189);
            this.pdgaNumTextBox.Name = "pdgaNumTextBox";
            this.pdgaNumTextBox.Size = new System.Drawing.Size(109, 20);
            this.pdgaNumTextBox.TabIndex = 29;
            // 
            // pdgaNumLabel
            // 
            this.pdgaNumLabel.AutoSize = true;
            this.pdgaNumLabel.Location = new System.Drawing.Point(63, 192);
            this.pdgaNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pdgaNumLabel.Name = "pdgaNumLabel";
            this.pdgaNumLabel.Size = new System.Drawing.Size(80, 13);
            this.pdgaNumLabel.TabIndex = 28;
            this.pdgaNumLabel.Text = "PDGA Number:";
            // 
            // playerComboBox
            // 
            this.playerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerComboBox.FormattingEnabled = true;
            this.playerComboBox.Location = new System.Drawing.Point(66, 58);
            this.playerComboBox.Name = "playerComboBox";
            this.playerComboBox.Size = new System.Drawing.Size(140, 21);
            this.playerComboBox.TabIndex = 30;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(212, 56);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MyInformationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.playerComboBox);
            this.Controls.Add(this.pdgaNumTextBox);
            this.Controls.Add(this.pdgaNumLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.updatePlayerButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "MyInformationUserControl";
            this.Size = new System.Drawing.Size(342, 318);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatePlayerButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox pdgaNumTextBox;
        private System.Windows.Forms.Label pdgaNumLabel;
        private System.Windows.Forms.ComboBox playerComboBox;
        private System.Windows.Forms.Button searchButton;
    }
}
