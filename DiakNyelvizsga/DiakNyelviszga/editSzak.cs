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
    public partial class editSzak : Form
    {
        int id;
        public editSzak(string id) {
            InitializeComponent();
            this.BackColor = Color.MintCream;
            this.MaximizeBox = false;
            this.id = int.Parse(id);
        }

        private void szakModifyBtn_Click(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            connection.Open();

            try {

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_upszak";


                cmd.Parameters.AddWithValue("@neve", szakNevTbx.Text);
                cmd.Parameters.AddWithValue("@felevek_szama", szakFelevTbx.Text);
                cmd.Parameters.AddWithValue("@szak_id", this.id);

                cmd.ExecuteNonQuery();


                DialogResult dialogResult = MessageBox.Show("Biztosan módosítani szeretné az adott szakot?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes) {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Az adatok módosítása sikeresen megtörtént!", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally {
                connection.Close();
            }
        }

        private void editSzak_Load(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from isk_szak where id=" + id;

            try {
                connection.Open();
                SqlDataReader sqlReader = command.ExecuteReader();
                string nev = null;
                string felevek = null;
                while (sqlReader.Read()) {
                    nev = sqlReader["neve"].ToString();
                    felevek = sqlReader["felevek_szama"].ToString();
                }

                szakNevTbx.Text = megtisztit(nev);
                szakFelevTbx.Text = megtisztit(felevek);
                

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally {
                connection.Close();
            }
        }

        private string megtisztit(string szoveg) {
            string jo = "";
            int db = 0;
            for (int i = 0; i < szoveg.Length; i++) {
                if (!char.IsWhiteSpace(szoveg[i]))
                    jo += szoveg[i];
                if (char.IsWhiteSpace(szoveg[i]) && db < 2) {
                    jo += szoveg[i];
                    db++;
                }
            }
            return jo;
        }
    }
}
