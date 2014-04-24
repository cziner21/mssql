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
            nyVDbLbl.Hide();
            lessChx.Hide();
            moreCbx.Hide();
            equalCbx.Hide();
            numericUpDown1.Hide();
        }

        private void serachBtn_Click(object sender, EventArgs e) {
            dataGridView1.Update();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();
            try {

                string query = "SELECT isk_diak2.id, isk_diak2.nev, isk_diak2.cim, isk_diak2.tel_szam, isk_diak2.anyja_neve, isk_diak2.zsebpenz, isk_varos.nev AS Város from isk_diak2 INNER JOIN isk_varos ON isk_diak2.varos_id = isk_varos.id where"; //"Select * From isk_diak2 where";
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

        private void nyelvizsgaCbx_CheckedChanged(object sender, EventArgs e) {
            if (nyelvizsgaCbx.Checked) {
                nyVDbLbl.Show();
                lessChx.Show();
                moreCbx.Show();
                equalCbx.Show();
                numericUpDown1.Show();
            }
            else {
                nyVDbLbl.Hide();
                lessChx.Hide();
                moreCbx.Hide();
                equalCbx.Hide();
                numericUpDown1.Hide();
            }
        }

        private string varosId() {
            string result;
            //MessageBox.Show(searchVarosCbx.SelectedItem.ToString());
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
            command.CommandText = "SELECT nev from isk_varos";

            try {
                List<string> beolvasottVarosok = new List<string>();
                connection.Open();
                SqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read()) {                    
                    beolvasottVarosok.Add(sqlReader["nev"].ToString());
                }

                List<string> joVarosok = megtisztit(beolvasottVarosok);
                foreach (var item in joVarosok) {
                    searchVarosCbx.Items.Add(item);
                }
                
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
    }
}
