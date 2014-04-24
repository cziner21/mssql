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
    public partial class tarsitNyelvizsga : Form
    {
        public tarsitNyelvizsga() {
            InitializeComponent();
        }

        private void tarsitNyelvizsga_Load(object sender, EventArgs e) {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["diakNyelvizsga"];
            SqlConnection connection = new SqlConnection(settings.ConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from isk_nyelvizsga";
            try {
                connection.Open();
                SqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read()) {
                    checkedListBox1.Items.Add(sqlReader["id"].ToString() + "   " + sqlReader["nyelv"].ToString());
                }
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
