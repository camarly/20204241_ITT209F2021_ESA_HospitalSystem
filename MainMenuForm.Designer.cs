namespace _20204241_ITT209F2021_ESA {
    partial class MainMenuForm {
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
            this.closeButton2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeButton2);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 924);
            this.panel1.TabIndex = 0;
            // 
            // closeButton2
            // 
            this.closeButton2.BackColor = System.Drawing.Color.IndianRed;
            this.closeButton2.ForeColor = System.Drawing.Color.White;
            this.closeButton2.Location = new System.Drawing.Point(1029, 0);
            this.closeButton2.Name = "closeButton2";
            this.closeButton2.Size = new System.Drawing.Size(53, 37);
            this.closeButton2.TabIndex = 0;
            this.closeButton2.Text = "X";
            this.closeButton2.UseVisualStyleBackColor = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 922);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton2;
    }
}