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
using DiakNyelvizsga;

namespace DiakNyelviszga
{
    public partial class varos : Form
    {
        public string id;
        public varos() {
            InitializeComponent();
           
        }

        private void refreshBtn_Click(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from isk_varos";

            try {
                connection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(command.CommandText, connection);
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

        private void varos_Load(object sender, EventArgs e) {
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e) {
            int i = e.RowIndex;
            //itt adom át, hogy melyik nyelvizsgát akarom mádosítani/törölni
            this.id = dataGridView1[0, i].Value.ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e) {
            if (this.id != null) {

                editVaros ev = new editVaros(id);
                ev.Show();
            }
        }

        private void delBtn_Click(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();
            try {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_delvaros";
                cmd.Parameters.AddWithValue("@ID", int.Parse(id));
                DialogResult dialogResult = MessageBox.Show("Biztosan törölni szeretné az adott várost?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes) {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Az adatok törlése sikeresen megtörtént!", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
