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
    public partial class editNyelvizsga : Form
    {
        int id;
        public editNyelvizsga(string id) {
            InitializeComponent();
            this.id = int.Parse(id);
        }

        private void editNyelvizsga_Load(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from isk_nyelvizsga where id=" + id;

            try {
                connection.Open();
                SqlDataReader sqlReader = command.ExecuteReader();
                string szint = null;
                string tipus = null;
                string nyelv = null;
                string iskola = null;
                while (sqlReader.Read()) {
                    szint = sqlReader["szint"].ToString();
                    tipus = sqlReader["tipus"].ToString();
                    nyelv = sqlReader["nyelv"].ToString();
                    iskola = sqlReader["iskola"].ToString();
                   

                }

                nyvSzintTbx.Text = megtisztit(szint);
                nyvTipusTbx.Text = megtisztit(tipus);
                nyvNyelvTbx.Text = megtisztit(nyelv);
                nyvIskolaTbx.Text = megtisztit(iskola);

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
                if (char.IsWhiteSpace(szoveg[i]) && db < 3) {
                    jo += szoveg[i];
                    db++;
                }
            }
            return jo;
        }

        private void nyvModifyBtn_Click(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            connection.Open();

            try {

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_upnyelvizsga";

                
                cmd.Parameters.AddWithValue("@szint", nyvSzintTbx.Text);
                cmd.Parameters.AddWithValue("@tipus", nyvTipusTbx.Text);
                cmd.Parameters.AddWithValue("@nyelv", nyvNyelvTbx.Text);
                cmd.Parameters.AddWithValue("@iskola", nyvIskolaTbx.Text);
                cmd.Parameters.AddWithValue("@nyelvizsga_id", this.id);

                cmd.ExecuteNonQuery();


                DialogResult dialogResult = MessageBox.Show("Biztosan módosítani szeretné az adott nyelvizsgát?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
    }
}
