using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiakNyelvizsga;

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

        private void diákToolStripMenuItem_Click(object sender, EventArgs e) {
            addDiak ad = new addDiak();
            ad.Show();
        }

        private void infóToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox1 abx = new AboutBox1();
            abx.Show();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void diákToolStripMenuItem1_Click(object sender, EventArgs e) {
            diakSearch sd = new diakSearch();
            sd.Show();
        }

        private void városToolStripMenuItem1_Click(object sender, EventArgs e) {
            varosSearch sv = new varosSearch();
            sv.Show();
        }

        
    }
}
