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
    public partial class addSzak : Form
    {
        public addSzak() {
            InitializeComponent();
        }

        private void addSzakBtn_Click(object sender, EventArgs e) {
            try {
                SqlConnection connection = new SqlConnection(@"Data Source=ADAMLT\SQLEXPRESS;Initial Catalog=beadando;Integrated Security=True");
                connection.Open();

                /*tárolt eljárás hívása*/
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_insszak";


                if (Regex.IsMatch(szakNevTbx.Text, @"^[A-Za-zÁ-ű]+$")) {
                    cmd.Parameters.AddWithValue("@neve", szakNevTbx.Text);                    
                }
                else {
                    throw new Exception("A név mező nem lehet üres, illetve csak betűket írhat be!");
                }
                if (felevekTbx.Text != null && int.Parse(felevekTbx.Text) <= 10 && int.Parse(felevekTbx.Text) > 1) {
                    cmd.Parameters.AddWithValue("@felevek_szama", int.Parse(felevekTbx.Text));
                }
                else {
                    throw new Exception("A félévek száma nem lehet üres, illetve 2 és 10 közötti szmnak kell lennie!");
                }
                cmd.ExecuteNonQuery();
                //connection.Close();
                MessageBox.Show("Sikeres felvitel!", "Siker!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                szakNevTbx.Clear();
                felevekTbx.Clear();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
