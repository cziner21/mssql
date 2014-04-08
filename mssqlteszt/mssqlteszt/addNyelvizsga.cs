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
using System.Text.RegularExpressions;

namespace mssqlteszt
{
    public partial class addNyelvizsga : Form
    {
        public addNyelvizsga() {
            InitializeComponent();
        }

        private void addNyelvizsga_Load(object sender, EventArgs e) {

        }

        private void addNyelvizsgaBtn_Click(object sender, EventArgs e) {
            try {
                SqlConnection connection = new SqlConnection(@"Data Source=ADAMLT\SQLEXPRESS;Initial Catalog=beadando;Integrated Security=True");
                connection.Open();

                /*tárolt eljárás hívása*/
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_insnyelvizsga";


                if (Regex.IsMatch(szintTbx.Text, @"^[A-Za-zÁ-ű]+ $") && Regex.IsMatch(tipusTbx.Text, @"^[A-Za-zÁ-ű]+ $") &&
                    Regex.IsMatch(nyelvTbx.Text, @"^[A-Za-zÁ-ű]+ $") && Regex.IsMatch(iskolaTbx.Text, @"^[A-Za-zÁ-ű]+ $")) {
                    cmd.Parameters.AddWithValue("@szint", szintTbx.Text);
                    cmd.Parameters.AddWithValue("@tipus", tipusTbx.Text);
                    cmd.Parameters.AddWithValue("@nyelv", nyelvTbx.Text);
                    cmd.Parameters.AddWithValue("@iskola", iskolaTbx.Text);
                }
                else {
                    throw new Exception("Egyik mező sem lehet üres, illetve csak betűket írhat be!");
                }
                //connection.Close();
                MessageBox.Show("Sikeres felvitel!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                szintTbx.Clear();
                tipusTbx.Clear();
                nyelvTbx.Clear();
                iskolaTbx.Clear();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message,"Hiba!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
    }
}
