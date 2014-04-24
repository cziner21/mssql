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

namespace DiakNyelvizsga
{
    public partial class addNyelvizsga : Form
    {
        public addNyelvizsga() {
            InitializeComponent();
        }

        private void addNyelvizsgaBtn_Click(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            try {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_insnyelvizsga";

                cmd.Parameters.AddWithValue("@szint", szintTbx.Text);
                cmd.Parameters.AddWithValue("@tipus", tipusTbx.Text);
                cmd.Parameters.AddWithValue("@nyelv", nyelvTbx.Text);
                cmd.Parameters.AddWithValue("@iskola", iskolaTbx.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally {
                connection.Close();
                MessageBox.Show("Sikeres felvitel!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                szintTbx.Clear();
                tipusTbx.Clear();
                nyelvTbx.Clear();
                iskolaTbx.Clear();
            }
        }
    }
}
