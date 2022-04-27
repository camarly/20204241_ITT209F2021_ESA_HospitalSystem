using MySql.Data.MySqlClient;
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
    public partial class ManagePatientForm : Form {
        public ManagePatientForm() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void searchbutton_Click(object sender, EventArgs e) {

            List<string> list = new List<string>();
            list.Add(TRNtxtBox.Text);
            list.Add(lnameTextBox.Text);
            list.Add(fnametxtBox.Text);
            list.Add(patienttextBox.Text);

            /*           if (string.IsNullOrEmpty(patienttextBox.Text)) {
                           MessageBox.Show($"Required field {PatientIDLabel} cannot be empty", "Field Error!");
                       }
            */
            if (string.IsNullOrEmpty(fnametxtBox.Text)) {
                MessageBox.Show($"Required field {fnameLabel.Text} cannot be empty", "Field Error!");
            } else if (string.IsNullOrEmpty(lnameTextBox.Text)) {
                MessageBox.Show($"Required field {lnameLabel.Text} cannot be empty", "Field Error!");
            } 
            else {

                //foreach (var item in list) {
                //    if (string.IsNullOrEmpty(item)) {
                //        list.Remove(item);
                //    }
                //}
                

                var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MYSQL"].ConnectionString;
                var connection = new MySqlConnection(connectionString);

                connection.Open();
                //string sql_string = "SELECT (Username, PASSWORD) FROM Employee;";
                string sql_string = "SELECT * FROM Patient WHERE FirstName ='" + fnametxtBox.Text + "' and LastName ='" + lnameTextBox.Text + "';";
                MySqlCommand command = new MySqlCommand(sql_string, connection);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                //dataGridView1 = new DataGridView();
                dataGridView1.DataSource = table;
                
                //if (table.Rows.Count > 0) {

                //} else {
                //    MessageBox.Show("No patient found.", "Error");
                //}
                connection.Close();

            }
    
        }
    }
}
