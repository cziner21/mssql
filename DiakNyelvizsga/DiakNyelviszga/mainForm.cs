using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiakNyelviszga
{
    public partial class mainForm : Form
    {
        public mainForm() {
            InitializeComponent();
        }

        private void diakPbx_Click(object sender, EventArgs e) {
            diak d = new diak();
            d.Show();
        }

        private void varosPbx_Click(object sender, EventArgs e) {
            varos v = new varos();
            v.Show();
        }

        private void nyelvizsgaPbx_Click(object sender, EventArgs e) {
            nyelvizsga ny = new nyelvizsga();
            ny.Show();
        }

        private void szakPbx_Click(object sender, EventArgs e) {
            szak sz = new szak();
            sz.Show();
        }

        
    }
}
