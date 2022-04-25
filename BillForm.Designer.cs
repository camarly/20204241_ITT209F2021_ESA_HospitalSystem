namespace _20204241_ITT209F2021_ESA {
    partial class BillForm {
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
            this.HospitalName = new System.Windows.Forms.TextBox();
            this.HospitalAddres = new System.Windows.Forms.TextBox();
            this.PhoneNumberTxtBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PatientPhoneNumber = new System.Windows.Forms.TextBox();
            this.PatientAddressTxtBox = new System.Windows.Forms.TextBox();
            this.PatientNameTxtBox = new System.Windows.Forms.TextBox();
            this.HospitalEmail = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalAmntDueTXTBox = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TotalAmntDueTXTBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.HospitalEmail);
            this.panel1.Controls.Add(this.PatientPhoneNumber);
            this.panel1.Controls.Add(this.PatientAddressTxtBox);
            this.panel1.Controls.Add(this.PatientNameTxtBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.PhoneNumberTxtBox);
            this.panel1.Controls.Add(this.HospitalAddres);
            this.panel1.Controls.Add(this.HospitalName);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 764);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // HospitalName
            // 
            this.HospitalName.Location = new System.Drawing.Point(4, 113);
            this.HospitalName.Name = "HospitalName";
            this.HospitalName.Size = new System.Drawing.Size(217, 22);
            this.HospitalName.TabIndex = 0;
            // 
            // HospitalAddres
            // 
            this.HospitalAddres.Location = new System.Drawing.Point(4, 141);
            this.HospitalAddres.Name = "HospitalAddres";
            this.HospitalAddres.Size = new System.Drawing.Size(217, 22);
            this.HospitalAddres.TabIndex = 1;
            // 
            // PhoneNumberTxtBox
            // 
            this.PhoneNumberTxtBox.Location = new System.Drawing.Point(4, 169);
            this.PhoneNumberTxtBox.Name = "PhoneNumberTxtBox";
            this.PhoneNumberTxtBox.Size = new System.Drawing.Size(217, 22);
            this.PhoneNumberTxtBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Item,
            this.Summary,
            this.Charge,
            this.Insurance,
            this.Balance});
            this.dataGridView1.Location = new System.Drawing.Point(4, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(792, 524);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 93);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // PatientPhoneNumber
            // 
            this.PatientPhoneNumber.Location = new System.Drawing.Point(461, 70);
            this.PatientPhoneNumber.Name = "PatientPhoneNumber";
            this.PatientPhoneNumber.Size = new System.Drawing.Size(325, 22);
            this.PatientPhoneNumber.TabIndex = 35;
            // 
            // PatientAddressTxtBox
            // 
            this.PatientAddressTxtBox.Location = new System.Drawing.Point(461, 42);
            this.PatientAddressTxtBox.Name = "PatientAddressTxtBox";
            this.PatientAddressTxtBox.Size = new System.Drawing.Size(325, 22);
            this.PatientAddressTxtBox.TabIndex = 34;
            // 
            // PatientNameTxtBox
            // 
            this.PatientNameTxtBox.Location = new System.Drawing.Point(461, 13);
            this.PatientNameTxtBox.Name = "PatientNameTxtBox";
            this.PatientNameTxtBox.Size = new System.Drawing.Size(325, 22);
            this.PatientNameTxtBox.TabIndex = 33;
            // 
            // HospitalEmail
            // 
            this.HospitalEmail.Location = new System.Drawing.Point(4, 197);
            this.HospitalEmail.Name = "HospitalEmail";
            this.HospitalEmail.Size = new System.Drawing.Size(217, 22);
            this.HospitalEmail.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 22);
            this.textBox1.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(241, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 22);
            this.textBox2.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "STATEMENT DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "DUE DATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "TOTAL AMOUNT DUE";
            // 
            // TotalAmntDueTXTBox
            // 
            this.TotalAmntDueTXTBox.Location = new System.Drawing.Point(569, 138);
            this.TotalAmntDueTXTBox.Name = "TotalAmntDueTXTBox";
            this.TotalAmntDueTXTBox.Size = new System.Drawing.Size(217, 22);
            this.TotalAmntDueTXTBox.TabIndex = 41;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date of Visit";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.Width = 125;
            // 
            // Summary
            // 
            this.Summary.HeaderText = "Summary";
            this.Summary.MinimumWidth = 6;
            this.Summary.Name = "Summary";
            this.Summary.Width = 125;
            // 
            // Charge
            // 
            this.Charge.HeaderText = "Charge";
            this.Charge.MinimumWidth = 6;
            this.Charge.Name = "Charge";
            this.Charge.Width = 125;
            // 
            // Insurance
            // 
            this.Insurance.HeaderText = "Insurance";
            this.Insurance.MinimumWidth = 6;
            this.Insurance.Name = "Insurance";
            this.Insurance.Width = 125;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.MinimumWidth = 6;
            this.Balance.Name = "Balance";
            this.Balance.Width = 125;
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 760);
            this.Controls.Add(this.panel1);
            this.Name = "BillForm";
            this.Text = "BillForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox PhoneNumberTxtBox;
        private System.Windows.Forms.TextBox HospitalAddres;
        private System.Windows.Forms.TextBox HospitalName;
        private System.Windows.Forms.TextBox PatientPhoneNumber;
        private System.Windows.Forms.TextBox PatientAddressTxtBox;
        private System.Windows.Forms.TextBox PatientNameTxtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox HospitalEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalAmntDueTXTBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    }
}