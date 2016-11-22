using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerDatabase {
    public partial class Form2 : Form {
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
    }
}
