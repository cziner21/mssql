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

namespace DiakNyelviszga
{
    public partial class addDiak : Form
    {
        public addDiak() {
            InitializeComponent();
            this.BackColor = Color.MintCream;
            this.MaximizeBox = false;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT nev from isk_varos";

            try {
                connection.Open();
                SqlDataReader sqlReader = command.ExecuteReader();
                List<string> beolvasottVarosok = new List<string>();
                while (sqlReader.Read()) {
                    beolvasottVarosok.Add(sqlReader["nev"].ToString());
                }
                List<string> joVarosok = megtisztit(beolvasottVarosok);
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

        private void addBtn_Click(object sender, EventArgs e) {
            try {
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
                SqlConnection connection = new SqlConnection(settings.ConnectionString);
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_insdiak2";
                string nev;
                string cim;
                string telefon;
                string anyja;
                int zsebpenz;


                //if (Regex.IsMatch(nevTbx.Text, @"^[A-Za-zÁ-Űá-ű ]+$")) {
                nev = nevTbx.Text;
                //}
                //else throw new Exception("Nem megfelelő névformátum!");
                //if (Regex.IsMatch(cimTbx.Text, @"[A-Za-z ]+ $")) {
                cim = cimTbx.Text;
                //}
                //else throw new Exception("Nem megfelelő a cím formátuma!");
                //if (Regex.IsMatch(telTbx.Text, @"[0-9+]$")) {
                telefon = telTbx.Text;
                //}
                //else throw new Exception("Ne megfelelő a telefonszám fromátuma!");
                //if (Regex.IsMatch(anyjaTbx.Text, @"[A-Za-zÁ-Űá-ű ]+ $")) {
                anyja = anyjaTbx.Text;
                //}
                //else throw new Exception("Nem megfelő az anyja neve mező formátuma!");
                zsebpenz = int.Parse(penzTbx.Text);




                string vID = varosId();

                cmd.Parameters.AddWithValue("@nev", nev);
                cmd.Parameters.AddWithValue("@cim", cim);
                cmd.Parameters.AddWithValue("@tel_szam", telefon);
                cmd.Parameters.AddWithValue("@anyja_neve", anyja);
                cmd.Parameters.AddWithValue("@zsebpenz", zsebpenz);
                cmd.Parameters.AddWithValue("@varos_id", vID);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally {
                
                MessageBox.Show("Sikeres felvitel!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            /*
            string teljesNev = null;
            if (Regex.IsMatch(vezeteknevTbx.Text, @"^[A-Za-zÁ-ű]+ $") && Regex.IsMatch(keresztnev1Tbx.Text, @"^[A-Za-zÁ-ű]+$")
                && (keresztnev2Tbx.Text != "" && Regex.IsMatch(keresztnev2Tbx.Text, @"^[A-Za-zÁ-ű]+$"))) {
                teljesNev = vezeteknevTbx.Text + " " + keresztnev1Tbx.Text + " " + keresztnev2Tbx.Text;
            }
            else if (Regex.IsMatch(vezeteknevTbx.Text, @"^[A-Za-zÁ-ű]+$") && Regex.IsMatch(keresztnev1Tbx.Text, @"^[A-Za-zÁ-ű]+$")
                && keresztnev2Tbx.Text == "") {
                teljesNev = vezeteknevTbx.Text + " " + keresztnev1Tbx.Text;
            }
            else
                throw new Exception("Nem megfelelő a név formátuma!");


            cmd.Parameters.AddWithValue("@nev", teljesNev);
            cmd.Parameters.AddWithValue("@cim", cimTbx.Text);
            cmd.Parameters.AddWithValue("@tel_szam", telefonTbx.Text);
            cmd.Parameters.AddWithValue("@anyja_neve", anyjaTbx.Text);
            cmd.Parameters.AddWithValue("@zsebpenz", int.Parse(zsebpenzTbx.Text));
            cmd.Parameters.AddWithValue("@varos_id", varosIdCbx.Text);
            cmd.ExecuteNonQuery();





            connection.Close();
            MessageBox.Show("Sikeres felvitel!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */
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

        private List<string> megtisztit(List<string> bv) {
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
    }
}
