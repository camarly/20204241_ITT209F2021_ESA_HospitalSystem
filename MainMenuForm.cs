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
        public MainMenuForm() {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void label18_Click(object sender, EventArgs e) {

        }
    }
}
