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
    public partial class szakSeacrh : Form
    {
        public szakSeacrh() {
            InitializeComponent();
            this.BackColor = Color.MintCream;
            this.MaximizeBox = false;

            idTbx.Hide();
            nevTbx.Hide();
            felevTbx.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            try {

                SqlCommand command = connection.CreateCommand();

                string query = "Select * From isk_szak where";
                query = query + " 1=1";

                if (idCbx.Checked) {
                    if (idTbx.TextLength == 0)
                        throw new Exception("Nem adta meg melyik ID-ra keressünk!");
                    query = query + " AND id LIKE('" + idTbx.Text + "%') ";
                }
                if (nevCbx.Checked) {
                    if (nevTbx.TextLength == 0) throw new Exception("Nem adta meg melyik szakra keressünk!");
                    query = query + " AND neve LIKE('" + nevTbx.Text + "%') ";
                }
                if (felevCbx.Checked) {
                    if (felevTbx.TextLength == 0) throw new Exception("Nem adta meg a félévek számát!");
                    query = query + " AND felevek_szama LIKE('" + felevTbx.Text + "%') ";
                }
                

                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(command.CommandText, connection);
                DataSet ds = new DataSet();
                adp.Fill(ds, "isk_szak");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "isk_szak";

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally {
                connection.Close();
            }
        }

        private void szakSeacrh_Load(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from isk_szak";
            try {
                connection.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from isk_szak", connection);
                DataSet ds = new DataSet();
                adp.Fill(ds, "isk_szak");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "isk_szak";
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

        private void nevCbx_CheckedChanged(object sender, EventArgs e) {
            if (nevCbx.Checked) nevTbx.Show();
            else {
                nevTbx.Clear();
                nevTbx.Hide();
            }
        }

        private void felevCbx_CheckedChanged(object sender, EventArgs e) {
            if (felevCbx.Checked) felevTbx.Show();
            else {
                felevTbx.Clear();
                felevTbx.Hide();
            }
        }
    }
}
