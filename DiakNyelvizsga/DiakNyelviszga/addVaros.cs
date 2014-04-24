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
    public partial class addVaros : Form
    {
        public addVaros() {
            InitializeComponent();
        }

        private void addVarosBtn_Click(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            try {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_insvaros";

                cmd.Parameters.AddWithValue("@varos_id", iszTbx.Text);
                cmd.Parameters.AddWithValue("@nev", telepulesTbx.Text);
                cmd.Parameters.AddWithValue("@megye", megyeTbx.Text);
                cmd.Parameters.AddWithValue("@orszag", orszagTbx.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally {
                connection.Close();
                MessageBox.Show("Sikeres felvitel!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                iszTbx.Clear();
                telepulesTbx.Clear();
                megyeTbx.Clear();
                orszagTbx.Clear();
            }
        }
    }
}
