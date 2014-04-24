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
    public partial class editVaros : Form
    {
        int id;
        public editVaros(string id) {
            InitializeComponent();
            this.id = int.Parse(id);
        }

        private void editVaros_Load(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from isk_varos where id=" + id;

            try {
                connection.Open();
                SqlDataReader sqlReader = command.ExecuteReader();
                string isz = null;
                string nev = null;
                string megye = null;
                string orszag = null;
                while (sqlReader.Read()) {
                    isz = sqlReader["id"].ToString();
                    nev = sqlReader["nev"].ToString();
                    megye = sqlReader["megye"].ToString();
                    orszag = sqlReader["orszag"].ToString();                   
                }

                iszTbx.Text = megtisztit(isz);
                varosNevTbx.Text = megtisztit(nev);
                varosMegyeTbx.Text = megtisztit(megye);
                varosOrszagTbx.Text = megtisztit(orszag);

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

        private void varosModifyBtn_Click(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            connection.Open();

            try {

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_upvaros";

                cmd.Parameters.AddWithValue("@nev", varosNevTbx.Text);             
                cmd.Parameters.AddWithValue("@megye", varosMegyeTbx.Text);
                cmd.Parameters.AddWithValue("@orszag", varosOrszagTbx.Text);
                cmd.Parameters.AddWithValue("@varos_id", iszTbx.Text);

                cmd.ExecuteNonQuery();

                DialogResult dialogResult = MessageBox.Show("Biztosan módosítani szeretné az adott várost?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
