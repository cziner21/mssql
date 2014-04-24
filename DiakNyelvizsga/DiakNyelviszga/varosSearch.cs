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
    public partial class varosSearch : Form
    {
        public varosSearch() {
            InitializeComponent();
            searchBtn.Hide();
            idLbl.Hide();
            nevLbl.Hide();
            megyeLbl.Hide();
            orszagLbl.Hide();
            idTbx.Hide();
            nevTbx.Hide();
            megyeTbx.Hide();
            orszagTbx.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e) {
            try {
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
                SqlConnection connection = new SqlConnection(settings.ConnectionString);
                SqlCommand command = connection.CreateCommand();
                
                string query = "Select * From isk_varos where";
                query = query + " 1=1";

                if (idCbx.Checked) {
                    if (idTbx.TextLength == 0)
                        throw new Exception("Nem adta meg melyik ID-ra keressünk!");
                    query = query + " AND id LIKE('" + idTbx.Text + "%') ";
                }
                if (nevCbx.Checked) {
                    if(nevTbx.TextLength == 0) throw new Exception("Nem adta meg melyik városra keressünk!");
                    query = query + " AND nev LIKE('" + nevTbx.Text + "%') ";
                }
                if (megyeCbx.Checked) {
                    if (megyeTbx.TextLength == 0) throw new Exception("Nem adta meg melyik megyére keressünk!");
                    query = query + " AND megye LIKE('" + megyeTbx.Text + "%') ";
                }
                if (orszagCbx.Checked) {
                    if (orszagTbx.TextLength == 0) throw new Exception("Nem adta meg melyik országra keressünk!");
                    query = query + " AND orszag LIKE('" + orszagTbx.Text + "%') ";
                }

                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(command.CommandText, connection);
                DataSet ds = new DataSet();
                adp.Fill(ds, "isk_varos");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "isk_varos";

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void searchVaros_Load(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from isk_varos";
            try {
                connection.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from isk_varos", connection);
                DataSet ds = new DataSet();
                adp.Fill(ds, "isk_varos");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "isk_varos";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
            }
        }

        private void idCbx_CheckedChanged(object sender, EventArgs e) {
            if (idCbx.Checked) {
                idLbl.Show();
                idTbx.Show();
                searchBtn.Show();
            }
            else {
                idLbl.Hide();
                idTbx.Hide();
                
            }
        }

        private void nevCbx_CheckedChanged(object sender, EventArgs e) {
            if (nevCbx.Checked) {
                nevLbl.Show();
                nevTbx.Show();
                searchBtn.Show();
            }
            else {
                nevLbl.Hide();
                nevTbx.Hide();
                
            }
        }

        private void megyeCbx_CheckedChanged(object sender, EventArgs e) {
            if (megyeCbx.Checked) {
                megyeLbl.Show();
                megyeTbx.Show();
                searchBtn.Show();
            }
            else {
                megyeLbl.Hide();
                megyeTbx.Hide();
                
            }
        }

        private void orszagCbx_CheckedChanged(object sender, EventArgs e) {
            if (orszagCbx.Checked) {
                orszagLbl.Show();
                orszagTbx.Show();
                searchBtn.Show();
            }
            else {
                orszagLbl.Hide();
                orszagTbx.Hide();
                
            }
        }

        private void idTbx_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                try {
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
                SqlConnection connection = new SqlConnection(settings.ConnectionString);
                SqlCommand command = connection.CreateCommand();
                
                string query = "Select * From isk_varos where";
                query = query + " 1=1";
                    if (idTbx.TextLength == 0)
                        throw new Exception("Nem adta meg melyik ID-ra keressünk!");
                    query = query + " AND id LIKE('" + idTbx.Text + "%') ";
                    command.CommandText = query;
                    connection.Open();
                    command.ExecuteNonQuery();
                    SqlDataAdapter adp = new SqlDataAdapter(command.CommandText, connection);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "isk_varos");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "isk_varos";

                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
