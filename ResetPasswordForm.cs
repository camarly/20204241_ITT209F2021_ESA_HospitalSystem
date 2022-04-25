using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20204241_ITT209F2021_ESA {
    public partial class ResetPasswordForm : Form {
        public ResetPasswordForm() {
            InitializeComponent();
            this.passwordField1TxtBox.AutoSize = false;
            this.passwordField1TxtBox.PasswordChar = '*';
            this.passwordField1TxtBox.MaxLength = 16;

            this.passwordField2TxtBox.AutoSize = false;
            this.passwordField2TxtBox.PasswordChar = '*';
            this.passwordField2TxtBox.MaxLength = 16;

            MessageBox.Show("Please enter an alphanumeric character up to 16 digits", "Password Requirement");
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e) {
            var connectionString = ConfigurationManager.ConnectionStrings["MYSQL"].ConnectionString;
            var connection = new MySqlConnection(connectionString);

            connection.Open();
            //string sql_string = "SELECT (Username, PASSWORD) FROM Employee;";
            string sql_string = "SELECT * FROM Employee WHERE username ='" + usernameTxtBox.Text + "' and pwd ='" + passwordField1TxtBox.Text + "';";
            MySqlCommand command = new MySqlCommand(sql_string, connection);
            DataTable table = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = command;
            mySqlDataAdapter.Fill(table);


            //check if user exists/

            if (table.Rows.Count > 0) {
                MessageBox.Show("User Successfully Logged in.", "SUCCESS");
                this.Hide();
                new MainMenuForm(usernameTxtBox.Text).Show();

            } else {
                MessageBox.Show("Login Failed.", "Error");
            }

            //try {
            //    //MySqlDataReader readData = command.ExecuteReader();

            //    //while (readData.Read()) {
            //    //    MessageBox.Show(readData.GetString("Username"));
            //    //    //if (readData.GetString("Username") == usernameTxtBox.Text && readData.GetString("Pwd") == passwordTxtBox.Text) {
            //    //    //    MessageBox.Show("Successful login");
            //    //    //} else {
            //    //    //    MessageBox.Show("Invalid login");
            //    //    //}
            //    //}
            //    //readData.Close();
            //    command.Dispose();
            //} catch (Exception ex) {
            //    MessageBox.Show(ex.Message);
            //} finally {

            //    if (connection.State == ConnectionState.Open) {
            //        connection.Close();
            //    }
            //}

            connection.Close();
        }

        private void button1_Click_1(object sender, EventArgs e) {
            this.usernameTxtBox.Text = "";
            this.passwordField1TxtBox.Text = "";
            this.passwordField2TxtBox.Text = "";

        }

        private void passwordField1TxtBox_TextChanged(object sender, EventArgs e) {
           
        }
    }
}
