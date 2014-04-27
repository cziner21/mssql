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
    public partial class nyelvizsgaSearch : Form
    {
        public nyelvizsgaSearch() {
            InitializeComponent();

            idTbx.Hide();
            szintTbx.Hide();
            tipusTbx.Hide();
            nyelvTbx.Hide();
            iskolaTbx.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            try {

                SqlCommand command = connection.CreateCommand();

                string query = "Select * From isk_nyelvizsga where";
                query = query + " 1=1";

                if (idCbx.Checked) {
                    if (idTbx.TextLength == 0)
                        throw new Exception("Nem adta meg melyik ID-ra keressünk!");
                    query = query + " AND id LIKE('" + idTbx.Text + "%') ";
                }
                if (szintCbx.Checked) {
                    if (szintTbx.TextLength == 0) throw new Exception("Nem adta meg milyen szintre keressünk!");
                    query = query + " AND szint LIKE('" + szintTbx.Text + "%') ";
                }
                if (tipusCbx.Checked) {
                    if (tipusTbx.TextLength == 0) throw new Exception("Nem adta meg a típust!");
                    query = query + " AND tipus LIKE('" + tipusTbx.Text + "%') ";
                }
                if (nyelvCbx.Checked) {
                    if (nyelvTbx.TextLength == 0) throw new Exception("Nem adta meg milyen nyelvre keressünk!");
                    query = query + " AND nyelv LIKE('" + nyelvTbx.Text + "%') ";
                }
                if (iskolaCbx.Checked) {
                    if (iskolaTbx.TextLength == 0) throw new Exception("Nem adta meg az iskolát!");
                    query = query + " AND iskola LIKE('" + iskolaTbx.Text + "%') ";
                }


                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(command.CommandText, connection);
                DataSet ds = new DataSet();
                adp.Fill(ds, "isk_nyelvizsga");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "isk_nyelvizsga";

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally {
                connection.Close();
            }
        }

        private void nyelvizsgaSearch_Load(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from isk_nyelvizsga";
            try {
                connection.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from isk_nyelvizsga", connection);
                DataSet ds = new DataSet();
                adp.Fill(ds, "isk_nyelvizsga");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "isk_nyelvizsga";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally {
                connection.Close();
            }
        }

        private void idCbx_CheckedChanged(object sender, EventArgs e) {
            if (idCbx.Checked) idTbx.Show();
            else {
                idTbx.Clear();
                idTbx.Hide();
            }
        }

        private void szintCbx_CheckedChanged(object sender, EventArgs e) {
            if (szintCbx.Checked) szintTbx.Show();
            else {
                szintTbx.Clear();
                szintTbx.Hide();
            }
        }

        private void tipusCbx_CheckedChanged(object sender, EventArgs e) {
            if (tipusCbx.Checked) tipusTbx.Show();
            else {
                tipusTbx.Clear();
                tipusTbx.Hide();
            }
        }

        private void nyelvCbx_CheckedChanged(object sender, EventArgs e) {
            if (nyelvCbx.Checked) nyelvTbx.Show();
            else {
                nyelvTbx.Clear();
                nyelvTbx.Hide();
            }
        }

        private void iskolaCbx_CheckedChanged(object sender, EventArgs e) {
            if (iskolaCbx.Checked) iskolaTbx.Show();
            else {
                iskolaTbx.Clear();
                iskolaTbx.Hide();
            }
        }
    }
}
