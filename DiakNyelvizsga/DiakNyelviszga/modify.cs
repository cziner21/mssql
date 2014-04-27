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
    public partial class modify : Form
    {
        int id;
        public modify(string id) {
            InitializeComponent();
            this.BackColor = Color.MintCream;
            this.MaximizeBox = false;
            this.id = int.Parse(id);

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT nev from isk_varos";

            try {
                List<string> beolvasottVarosok = new List<string>();
                connection.Open();
                SqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read()) {
                    beolvasottVarosok.Add(sqlReader["nev"].ToString());
                }

                List<string> joVarosok = megtisztitVaros(beolvasottVarosok);
                foreach (var item in joVarosok) {
                    varosCbx.Items.Add(item);
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
            }
            
        }

        private void modify_Load(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from isk_diak2 where id="+id;

            try {
                connection.Open();
                SqlDataReader sqlReader = command.ExecuteReader();
                string nev = null;
                string cim = null;
                string telszam = null;
                string anyjaneve = null;
                while(sqlReader.Read()){
                    nev = sqlReader["nev"].ToString();
                    cim = sqlReader["cim"].ToString();
                    telszam = sqlReader["tel_szam"].ToString();
                    anyjaneve = sqlReader["anyja_neve"].ToString();
                    zsebpenzTbx.Text = sqlReader["zsebpenz"].ToString();
                    
                }
                
                    nevTbx.Text = megtisztit(nev);
                    cimTbx.Text = megtisztit(cim);
                    telTbx.Text = megtisztit(telszam);
                    anyjaTbx.Text = megtisztit(anyjaneve);

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
                    if(!char.IsWhiteSpace(szoveg[i]))
                        jo += szoveg[i];
                    if (char.IsWhiteSpace(szoveg[i]) && db < 5) {
                        jo += szoveg[i];
                        db++;
                    }             
            }
            return jo;
        }

        private List<string> megtisztitVaros(List<string> bv) {
            List<string> varosok = new List<string>();
            foreach (var item in bv) {
                string varos = "";
                for (int i = 0; i < item.Length; i++) {
                    if (!char.IsWhiteSpace(item[i])) {
                        varos += item[i];
                    }
                }
                varosok.Add(varos);
            }
            return varosok;
        }

        private void updateBtn_Click(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            connection.Open();
            try {
                
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_updiak2";

                string vID = varosId();

                cmd.Parameters.AddWithValue("@nev", nevTbx.Text);
                cmd.Parameters.AddWithValue("@cim", cimTbx.Text);
                cmd.Parameters.AddWithValue("@tel_szam", telTbx.Text);
                cmd.Parameters.AddWithValue("@anyja_neve", anyjaTbx.Text);
                cmd.Parameters.AddWithValue("@zsebpenz", int.Parse(zsebpenzTbx.Text));
                cmd.Parameters.AddWithValue("@varos_id", int.Parse(vID));
                cmd.Parameters.AddWithValue("@diak_id", this.id);

                cmd.ExecuteNonQuery();


                DialogResult dialogResult = MessageBox.Show("Biztosan módosítani szeretné az adott diákot?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes) {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Az adatok módosítása sikeresen megtörtént!", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally{
                connection.Close();
            }
            
        }

        private string varosId() {
            string result;
            //MessageBox.Show(searchVarosCbx.SelectedItem.ToString());
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT id FROM isk_varos WHERE isk_varos.nev =('" + varosCbx.SelectedItem + "')";
            connection.Open();
            result = command.ExecuteScalar().ToString();

            return result;
        }

        
    }
}
