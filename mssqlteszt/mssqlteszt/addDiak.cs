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
    public partial class addDiak : Form
    {
        public addDiak() {
            InitializeComponent();
            
           
            
                
        }

        private void hozzaadBtn_Click(object sender, EventArgs e) {
            try {               
                SqlConnection connection = new SqlConnection(@"Data Source=ADAMLT\SQLEXPRESS;Initial Catalog=beadando;Integrated Security=True");
                connection.Open();
         
                /*tárolt eljárás hívása*/
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_insdiak2";

                string teljesNev = null;
                if (Regex.IsMatch(vezeteknevTbx.Text, @"^[A-Za-zÁ-ű]+ $") && Regex.IsMatch(keresztnev1Tbx.Text, @"^[A-Za-zÁ-ű]+$")
                    && (keresztnev2Tbx.Text != "" && Regex.IsMatch(keresztnev2Tbx.Text, @"^[A-Za-zÁ-ű]+$"))){
                    teljesNev = vezeteknevTbx.Text + " " + keresztnev1Tbx.Text + " " + keresztnev2Tbx.Text;
                }
                else if(Regex.IsMatch(vezeteknevTbx.Text, @"^[A-Za-zÁ-ű]+$") && Regex.IsMatch(keresztnev1Tbx.Text, @"^[A-Za-zÁ-ű]+$")
                    && keresztnev2Tbx.Text == ""){
                    teljesNev = vezeteknevTbx.Text + " " + keresztnev1Tbx.Text;
                }
                else
                    throw new Exception("Nem megfelelő a név formátuma!");
                

                cmd.Parameters.AddWithValue("@nev", teljesNev);
                cmd.Parameters.AddWithValue("@cim", cimTbx.Text);
                cmd.Parameters.AddWithValue("@tel_szam", telefonTbx.Text);
                cmd.Parameters.AddWithValue("@anyja_neve", anyjaTbx.Text);
                cmd.Parameters.AddWithValue("@zsebpenz", int.Parse(zsebpenzTbx.Text));
                cmd.Parameters.AddWithValue("@varos_id", varosIdTbx.Text);
                cmd.ExecuteNonQuery();





                connection.Close();
                MessageBox.Show("Sikeres felvitel!", "Siker!");

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
