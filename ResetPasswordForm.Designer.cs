namespace _20204241_ITT209F2021_ESA {
    partial class ResetPasswordForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordField1TxtBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.passwordField2TxtBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLbl2 = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.passwordLbl);
            this.panel1.Controls.Add(this.passwordLbl2);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.passwordField2TxtBox);
            this.panel1.Controls.Add(this.submitButton);
            this.panel1.Controls.Add(this.passwordField1TxtBox);
            this.panel1.Controls.Add(this.usernameTxtBox);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 697);
            this.panel1.TabIndex = 0;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(307, 125);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(252, 22);
            this.usernameTxtBox.TabIndex = 1;
            // 
            // passwordField1TxtBox
            // 
            this.passwordField1TxtBox.Location = new System.Drawing.Point(307, 174);
            this.passwordField1TxtBox.Name = "passwordField1TxtBox";
            this.passwordField1TxtBox.Size = new System.Drawing.Size(252, 22);
            this.passwordField1TxtBox.TabIndex = 2;
            this.passwordField1TxtBox.TextChanged += new System.EventHandler(this.passwordField1TxtBox_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(307, 276);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(124, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // passwordField2TxtBox
            // 
            this.passwordField2TxtBox.Location = new System.Drawing.Point(307, 218);
            this.passwordField2TxtBox.Name = "passwordField2TxtBox";
            this.passwordField2TxtBox.Size = new System.Drawing.Size(252, 22);
            this.passwordField2TxtBox.TabIndex = 4;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(136, 130);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(84, 16);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "USERNAME";
            // 
            // passwordLbl2
            // 
            this.passwordLbl2.AutoSize = true;
            this.passwordLbl2.Location = new System.Drawing.Point(136, 224);
            this.passwordLbl2.Name = "passwordLbl2";
            this.passwordLbl2.Size = new System.Drawing.Size(150, 16);
            this.passwordLbl2.TabIndex = 6;
            this.passwordLbl2.Text = "CONFIRM PASSWORD";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(136, 180);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(86, 16);
            this.passwordLbl.TabIndex = 7;
            this.passwordLbl.Text = "PASSWORD";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(437, 276);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(122, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 696);
            this.Controls.Add(this.panel1);
            this.Name = "ResetPasswordForm";
            this.Text = "ResetPasswordForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label passwordLbl2;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordField2TxtBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox passwordField1TxtBox;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Button clearButton;
    }
}