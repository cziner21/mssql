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
    public partial class getDiak : Form
    {
        public getDiak() {
            InitializeComponent();

           
        }

        private void getDiak_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'beadandoDataSet.isk_getalldiak' table. You can move, or remove it, as needed.
            try {
                this.isk_getalldiakTableAdapter.Fill(this.beadandoDataSet.isk_getalldiak);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
