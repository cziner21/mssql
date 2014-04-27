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
    public partial class diak : Form
    {
        public string id;

        public diak() {
            InitializeComponent();
            this.BackColor = Color.MintCream;
            this.MaximizeBox = false;

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e) {
            int i = e.RowIndex;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            
            /*Nyelvizsgák lekérdezése*/
            SqlCommand command2 = connection.CreateCommand();
            command2.CommandText = "SELECT szint, tipus, nyelv, iskola from isk_nyelvizsga ny inner join isk_diak_nyelvizsga dny on dny.nyelvizsga_id = ny.id inner join isk_diak2 d2 on dny.diak_id = d2.id where d2.id=" + dataGridView1[0, i].Value;
            
            /*Szakok lekérdezése*/
            SqlCommand command3 = connection.CreateCommand();
            command3.CommandText = "SELECT neve AS Név, felevek_szama AS Felévek_száma from isk_szak sz inner join isk_diak_szak dsz on dsz.szak_id = sz.id inner join isk_diak2 d2 on dsz.diak_id = d2.id where d2.id=" + dataGridView1[0, i].Value;

            //itt adom át, hogy melyik diákot akarom mádosítani/törölni
            this.id = dataGridView1[0, i].Value.ToString();

            try {
                connection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(command2.CommandText, connection);
                DataSet ds = new DataSet();
                adp.Fill(ds, "isk_nyelvizsga");
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "isk_nyelvizsga";

                SqlDataAdapter adp2 = new SqlDataAdapter(command3.CommandText, connection);
                DataSet ds2 = new DataSet();
                adp2.Fill(ds2, "isk_szak");
                dataGridView3.DataSource = ds2;
                dataGridView3.DataMember = "isk_szak";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e) {
            if (this.id != null) {
                modify modosit = new modify(this.id);
                modosit.Show();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from isk_diak2";

            try {
                connection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(command.CommandText, connection);
                DataSet ds = new DataSet();
                adp.Fill(ds, "isk_diak2");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "isk_diak2";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
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
                cmd.CommandText = "isk_deldiak2";
                cmd.Parameters.AddWithValue("@ID", int.Parse(id));
                DialogResult dialogResult = MessageBox.Show("Biztosan törölni szeretné az adott diákot?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void diak_Load(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from isk_diak2";

            try {
                connection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(command.CommandText, connection);
                DataSet ds = new DataSet();
                adp.Fill(ds, "isk_diak2");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "isk_diak2";

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
            }
        }

        private void addBtn_Click(object sender, EventArgs e) {
            addDiak ad = new addDiak();
            ad.Show();
        }

        
       

        

        
    }
}
