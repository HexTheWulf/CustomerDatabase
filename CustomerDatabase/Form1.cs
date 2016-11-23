using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace CustomerDatabase {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void addACustomerToolStripMenuItem_Click(object sender, EventArgs e) {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            f2.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }
    }
}
