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
    public partial class szak : Form
    {
        public szak() {
            InitializeComponent();
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
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
            }
        }
    }
}
