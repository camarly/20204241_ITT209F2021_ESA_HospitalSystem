using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//using MySqlConnector;

namespace _20204241_ITT209F2021_ESA {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
            this.passwordTxtBox.AutoSize = false;
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.MaxLength = 16;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void loginButton_Click(object sender, EventArgs e) {
            var connectionString = ConfigurationManager.ConnectionStrings["MYSQL"].ConnectionString;
            var connection = new MySqlConnection(connectionString);
            
            connection.Open();
            //string sql_string = "SELECT (Username, PASSWORD) FROM Employee;";
            string sql_string = "SELECT * FROM Employee WHERE username ='" + usernameTxtBox.Text + "' and pwd ='" + passwordTxtBox.Text + "';";
            MySqlCommand command = new MySqlCommand(sql_string, connection);
            DataTable table = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = command;
            mySqlDataAdapter.Fill(table);


            //check if user exists/

            if (table.Rows.Count > 0) {
                MessageBox.Show("User Successfully Logged in.", "SUCCESS");
                this.Hide();
                new MainMenuForm().Show();

            }
            else {
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

        private void clearButton_Click(object sender, EventArgs e) {
            usernameTxtBox.Text = "";
            passwordTxtBox.Text = "";

        }

        private void clearButton_Click_MouseHover(object sender, EventArgs e) {
            this.BackColor = Color.Black;

        }

        private void clearButton_Click_MouseLeave(object sender, EventArgs e) {


        }

        private void closeButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void forgetpwdButton_Click(object sender, EventArgs e) {
            ResetPasswordForm myResetForm = new ResetPasswordForm();
            myResetForm.ShowDialog();
            
        }
    }
}
