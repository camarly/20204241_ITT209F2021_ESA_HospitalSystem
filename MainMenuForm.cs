using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20204241_ITT209F2021_ESA {
    public partial class MainMenuForm : Form {
        public MainMenuForm(string name) {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToString();
            userLoggedInLabel.Text = name;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void label18_Click(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            new ManagePatientForm().Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e) {
            new ManagePatientForm().ShowDialog();
        }

        private void label26_Click(object sender, EventArgs e) {
            new ManageDoctorNurseForm().ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e) {
            new ManagePatientForm().ShowDialog();
        }

        private void invoicelabel_Click(object sender, EventArgs e) {
            new BillForm().ShowDialog();
        }

        private void recordslabel_Click(object sender, EventArgs e) {
            //new MedicalInformationForm().Showdialog();
        }

        private void label20_Click(object sender, EventArgs e) {
            new RoomForm().ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e) {
            new Inpatient1Form().ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e) {
            new OutpatientForm().ShowDialog();  
        }

        private void ManageNurseLabel_Click(object sender, EventArgs e) {
            new ManageDoctorNurseForm().ShowDialog();
        }

        private void ManageEmployeeLabel_Click(object sender, EventArgs e) {
            new ManageEmployeeForm().ShowDialog();  
        }

        private void ManageMedicineLabel_Click(object sender, EventArgs e) {
            
        }

        private void ManagePrescriptionLabel_Click(object sender, EventArgs e) {
            new PrescriptionForm().ShowDialog();
        }
    }
}
