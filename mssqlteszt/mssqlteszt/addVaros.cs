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
using System.Text.RegularExpressions;

namespace mssqlteszt
{
    public partial class addVaros : Form
    {
        public addVaros() {
            InitializeComponent();
            
            
        }

        private void addVarosBtn_Click(object sender, EventArgs e) {
            try {

                SqlConnection connection = new SqlConnection(@"Data Source=ADAMLT\SQLEXPRESS;Initial Catalog=beadando;Integrated Security=True");
                connection.Open();

                /*tárolt eljárás hívása*/
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_insvaros";

                Iranyitoszam iszam = new Iranyitoszam(iszTbx.Text,telepulesTbx.Text,megyeTbx.Text,orszagTbx.Text);


                cmd.Parameters.AddWithValue("@varos_id", iszam.id);
                cmd.Parameters.AddWithValue("@nev", iszam.nev);
                cmd.Parameters.AddWithValue("@megye", iszam.megye);
                cmd.Parameters.AddWithValue("@orszag", iszam.orszag);



                cmd.ExecuteNonQuery();

                MessageBox.Show("A város hozzáadása sikeresen végrehajtódott!", "Sikeres hozzáadás!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    class Iranyitoszam
    {
        public string id;
        public string nev;
        public string megye;
        public string orszag;

        public Iranyitoszam(string id, string nev, string megye, string orszag) {
            this.id = id;
            this.nev = nev;
            this.megye = megye;
            this.orszag = orszag;
        }
    }
}
