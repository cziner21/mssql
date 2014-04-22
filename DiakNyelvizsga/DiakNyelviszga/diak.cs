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

namespace DiakNyelviszga
{
    public partial class diak : Form
    {
        public diak() {
            InitializeComponent();
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e) {
            int i = e.RowIndex;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command2 = connection.CreateCommand();
            command2.CommandText = "SELECT szint, tipus, nyelv, iskola from isk_nyelvizsga ny inner join isk_diak_nyelvizsga dny on dny.nyelvizsga_id = ny.id inner join isk_diak2 d2 on dny.diak_id = d2.id where d2.id=" + dataGridView1[0, i].Value;
            try {
                connection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(command2.CommandText, connection);
                DataSet ds = new DataSet();
                adp.Fill(ds, "isk_nyelvizsga");
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "isk_nyelvizsga";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
            }
        }

        

        
    }
}
