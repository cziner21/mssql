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
    public partial class diakSearch : Form
    {
        public diakSearch() {
            InitializeComponent();
            this.BackColor = Color.MintCream;
            this.MaximizeBox = false;

            /*lbl1.Hide();
            lbl2.Hide();
            lbl3.Hide();
            lbl4.Hide();
            lbl5.Hide();
            lbl6.Hide();
            lbl7.Hide();
            lbl8.Hide();*/
            
            idTbx.Hide();
            cimTbx.Hide();
            nevTbx.Hide();
            telTbx.Hide();
            anyjaTbx.Hide();
            zsebpenzTbx.Hide();
            searchVarosCbx.Hide();
            
            
        }

        private void serachBtn_Click(object sender, EventArgs e) {
            dataGridView1.Update();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();

            /*
             isk_nyelvizsga.nyelv AS Nyelvizsga, isk_szak.neve AS Szak
             INNER JOIN isk_diak_nyelvizsga dny ON isk_diak2.id = dny.diak_id INNER JOIN isk_nyelvizsga ON dny.nyelvizsga_id = isk_nyelvizsga.id , INNER JOIN isk_diak_szak dsz ON isk_diak2.id = dsz.diak_id INNER JOIN isk_szak ON dsz.szak_id = isk_szak.id
             */

            try {

                string query = "SELECT isk_diak2.id, isk_diak2.nev AS NÉV, isk_diak2.cim AS CÍM, isk_diak2.tel_szam AS Telefon, isk_diak2.anyja_neve AS Anyja_neve, isk_diak2.zsebpenz AS Zsebpénz, isk_varos.nev AS Város from isk_diak2 " +
                               "INNER JOIN isk_varos ON isk_diak2.varos_id = isk_varos.id  where";
                query = query + " 1=1";
                if (idCbx.Checked) {
                    if (idTbx.TextLength == 0) throw new Exception("Nem adott meg diák ID-t!");
                    query = query + "AND isk_diak2.id LIKE('" + int.Parse(idTbx.Text) + "%') ";
                }
                if (nevCbx.Checked) {
                    if (nevTbx.TextLength == 0) throw new Exception("Nem adott meg nevet!");
                    query = query + "AND isk_diak2.nev LIKE('" + nevTbx.Text + "%') ";
                }
                if (cimCbx.Checked) {
                    if (cimTbx.TextLength == 0) throw new Exception("Nem adott meg címet'");
                    query = query + "AND cim LIKE('" + cimTbx.Text + "%') ";
                }
                if (telefonCbx.Checked) {
                    if (telTbx.TextLength == 0) throw new Exception("Nem adott meg telefonszámot!");
                    query = query + "AND tel_szam LIKE('" + telTbx.Text + "%') ";
                }
                if (anyjaCbx.Checked) {
                    if (anyjaTbx.TextLength == 0) throw new Exception("Nem adta meg az anyja neve mező értékét!");
                    query = query + "AND anyja_neve LIKE('" + anyjaTbx.Text + "%') ";
                }
                if (zsebpenzCbx.Checked) {
                    if (zsebpenzTbx.TextLength == 0) throw new Exception("Nem adott értéket a zsebpénz mezőnek!");
                    query = query + "AND zsebpenz LIKE('" + int.Parse(zsebpenzTbx.Text) + "%') ";
                }
                if (varosCbx.Checked) {
                    string vID = varosId();

                    query = query + "AND varos_id LIKE('" + vID + "%') ";
                }
                
                
                

                command.CommandText = query;
                connection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(command.CommandText, connection);
                DataSet ds = new DataSet();
                adp.Fill(ds, "isk_diak2");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "isk_diak2";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally {
                connection.Close();
            }
        }

        
        private string varosId() {
            string result;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT id FROM isk_varos WHERE isk_varos.nev =('" + searchVarosCbx.SelectedItem+ "')";
            connection.Open();
            result = command.ExecuteScalar().ToString();
            
            return result;
        }

        private void diakSearch_Load(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();
            SqlCommand command2 = connection.CreateCommand();
            command.CommandText = "SELECT nev from isk_varos";
            
            try {
                List<string> beolvasottVarosok = new List<string>();
                List<string> beolvasottSzakok = new List<string>();
                connection.Open();
                SqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read()) {                    
                    beolvasottVarosok.Add(sqlReader["nev"].ToString());
                }

                List<string> joVarosok = megtisztit(beolvasottVarosok);
                foreach (var item in joVarosok) {
                    searchVarosCbx.Items.Add(item);
                }
                sqlReader.Close();

                
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally {
                connection.Close();
            }
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

        private void idCbx_CheckedChanged(object sender, EventArgs e) {
            if (idCbx.Checked) {
                idTbx.Show();
            }
            else {
                idTbx.Clear();
                idTbx.Hide();
            }
            
        }

        private void nevCbx_CheckedChanged(object sender, EventArgs e) {
            if (nevCbx.Checked) nevTbx.Show();
            else {
                nevTbx.Clear();
                nevTbx.Hide();
            }
        }

        private void cimCbx_CheckedChanged(object sender, EventArgs e) {
            if (cimCbx.Checked) cimTbx.Show();
            else {
                cimTbx.Clear();
                cimTbx.Hide();
            }
        }

        private void telefonCbx_CheckedChanged(object sender, EventArgs e) {
            if (telefonCbx.Checked) telTbx.Show();
            else {
                telTbx.Clear();
                telTbx.Hide();
            }
        }

        private void anyjaCbx_CheckedChanged(object sender, EventArgs e) {
            if (anyjaCbx.Checked) anyjaTbx.Show();
            else {
                anyjaTbx.Clear();
                anyjaTbx.Hide();
            }
        }

        private void zsebpenzCbx_CheckedChanged(object sender, EventArgs e) {
            if (zsebpenzCbx.Checked) zsebpenzTbx.Show();
            else {
                zsebpenzTbx.Clear();
                zsebpenzTbx.Hide();
            }
        }

        private void varosCbx_CheckedChanged(object sender, EventArgs e) {
            if (varosCbx.Checked) searchVarosCbx.Show();
            else {
                searchVarosCbx.Hide();
            }
        }

        
    }
}
