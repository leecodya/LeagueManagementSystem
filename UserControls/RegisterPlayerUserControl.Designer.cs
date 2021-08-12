namespace LeageManagementSystem.UserControls
{
    partial class RegisterPlayerUserControl
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.pdgaNumTextBox = new System.Windows.Forms.TextBox();
            this.pdgaNumLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(208, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(143, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Register Player";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(150, 62);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(85, 17);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "*First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(251, 59);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(144, 22);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(251, 105);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(144, 22);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(150, 108);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(85, 17);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "*Last Name:";
            // 
            // pdgaNumTextBox
            // 
            this.pdgaNumTextBox.Location = new System.Drawing.Point(251, 153);
            this.pdgaNumTextBox.Name = "pdgaNumTextBox";
            this.pdgaNumTextBox.Size = new System.Drawing.Size(144, 22);
            this.pdgaNumTextBox.TabIndex = 6;
            // 
            // pdgaNumLabel
            // 
            this.pdgaNumLabel.AutoSize = true;
            this.pdgaNumLabel.Location = new System.Drawing.Point(130, 156);
            this.pdgaNumLabel.Name = "pdgaNumLabel";
            this.pdgaNumLabel.Size = new System.Drawing.Size(105, 17);
            this.pdgaNumLabel.TabIndex = 5;
            this.pdgaNumLabel.Text = "PDGA Number:";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(251, 202);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(100, 32);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterPlayerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.pdgaNumTextBox);
            this.Controls.Add(this.pdgaNumLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "RegisterPlayerUserControl";
            this.Size = new System.Drawing.Size(588, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox pdgaNumTextBox;
        private System.Windows.Forms.Label pdgaNumLabel;
        private System.Windows.Forms.Button registerButton;
    }
}
