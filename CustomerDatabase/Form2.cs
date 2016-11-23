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
    public partial class Form2 : Form {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        public Form2() {
            InitializeComponent();
            NewNameBox.Focus();
            LocationCBox.SelectedIndex = 0;
        }

        private void Cancel_Click(object sender, EventArgs e) {
            NewNameBox.Clear();
            Close();
        }

        private void AddCustomer_Click(object sender, EventArgs e) {
            
            Close();
        }

        private void Form2_Load(object sender, EventArgs e) {
            try {
                Cursor = Cursors.WaitCursor;
                con.ConnectionString = "server=localhost;user id=mysqladmin;database=customers;persistsecurityinfo=True;password=password";
                con.Open();
                MessageBox.Show("Sucssessfully connected to database!", "Database");
                Cursor = Cursors.Default;
            }
            catch (Exception e1) {
                e1.ToString();
                MessageBox.Show("Connection to database failed!", "Error");
                Close();
            }
        }
    }
}
