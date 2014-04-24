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
    public partial class addSzak : Form
    {
        public addSzak() {
            InitializeComponent();
        }

        private void addSzakBtn_Click(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            try {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_insszak";

                cmd.Parameters.AddWithValue("@neve", szakNevTbx.Text);     
                cmd.Parameters.AddWithValue("@felevek_szama", int.Parse(felevekTbx.Text));

                cmd.ExecuteNonQuery();
                

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally {
                connection.Close();
                MessageBox.Show("Sikeres felvitel!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                szakNevTbx.Clear();
                felevekTbx.Clear();
            }
        }
    }
}
