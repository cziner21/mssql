using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;



namespace mssqlteszt
{
    public partial class mainForm : Form
    {
        public mainForm() {
            InitializeComponent();
            
               
        }

        private void összesDiákLekéréseToolStripMenuItem_Click(object sender, EventArgs e) {
            getDiak gD = new getDiak();
            gD.Show();
        }

        private void diákToolStripMenuItem_Click(object sender, EventArgs e) {
            addDiak aD = new addDiak();
            aD.Show();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void nyelvizsgaToolStripMenuItem_Click(object sender, EventArgs e) {
            addNyelvizsga aNy = new addNyelvizsga();
            aNy.Show();
        }

        private void szakToolStripMenuItem_Click(object sender, EventArgs e) {
            addSzak aSz = new addSzak();
            aSz.Show();
        }

        private void városToolStripMenuItem_Click(object sender, EventArgs e) {
            addVaros aV = new addVaros();
            aV.Show();
        }

        private void diákokModosításaToolStripMenuItem_Click(object sender, EventArgs e) {
            modify m = new modify();
            m.selectTab("diak");
            m.Show();
        }

        private void városokMódosításaToolStripMenuItem_Click(object sender, EventArgs e) {
            modify m = new modify();
            m.selectTab("varos");
            m.Show();
        }

        private void nyelviszgákMódosításaToolStripMenuItem_Click(object sender, EventArgs e) {
            modify m = new modify();
            m.selectTab("nyelvvizsga");
            m.Show();
        }

        private void szakokMódosításaToolStripMenuItem1_Click(object sender, EventArgs e) {
            modify m = new modify();
            m.selectTab("szak");
            m.Show();
        }

        private void diákokTörléseToolStripMenuItem_Click(object sender, EventArgs e) {
            deleteForm d = new deleteForm();
            d.selectTab("diak");
            d.Show();
        }

        private void városokTörléseToolStripMenuItem_Click(object sender, EventArgs e) {
            deleteForm d = new deleteForm();
            d.selectTab("varos");
            d.Show();
        }

        private void nyelvizsgákTörléseToolStripMenuItem_Click(object sender, EventArgs e) {
            deleteForm d = new deleteForm();
            d.selectTab("nyelvvizsga");
            d.Show();
        }

        private void szakokTörléseToolStripMenuItem_Click(object sender, EventArgs e) {
            deleteForm d = new deleteForm();
            d.selectTab("szak");
            d.Show();
        }

        

        
    }
}
