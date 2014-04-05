using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace mssqlteszt
{
    public partial class addVaros : Form
    {
        public addVaros() {
            InitializeComponent();
            try {
                StreamReader reader = new StreamReader(File.OpenRead("iranyitoszam1.txt"),Encoding.UTF8);
                List<Iranyitoszam> isz = new List<Iranyitoszam>();
                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    string[] resz = line.Split(';');
                    isz.Add(new Iranyitoszam(resz[0],resz[1],resz[2],resz[3]));

                }
                reader.Close();
                SqlConnection connection = new SqlConnection(@"Data Source=ADAMLT\SQLEXPRESS;Initial Catalog=beadando;Integrated Security=True");
                connection.Open();

                /*tárolt eljárás hívása*/
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_insvaros";
                //MessageBox.Show(isz[10].id);
                //MessageBox.Show(isz[10].nev);
                //MessageBox.Show(isz[10].megye);
                //MessageBox.Show(isz[10].orszag);
                foreach (Iranyitoszam item in isz) {
                    cmd.Parameters.AddWithValue("@varos_id", item.id);
                    cmd.Parameters.AddWithValue("@nev", item.nev);
                    cmd.Parameters.AddWithValue("@megye", item.megye);
                    cmd.Parameters.AddWithValue("@orszag", item.orszag);
                    
                }
                for (int i = 0; i < isz.Count; i++) {
                    cmd.Parameters.AddWithValue("@varos_id", isz[i].id);
                    cmd.Parameters.AddWithValue("@nev", isz[i].nev);
                    cmd.Parameters.AddWithValue("@megye", isz[i].megye);
                    cmd.Parameters.AddWithValue("@orszag", isz[i].orszag);
                    cmd.ExecuteNonQuery();
                }
                /*cmd.Parameters.AddWithValue("@varos_id", isz[16].id.ToString());
                cmd.Parameters.AddWithValue("@nev", isz[16].nev.ToString());
                cmd.Parameters.AddWithValue("@megye", isz[16].megye.ToString());
                cmd.Parameters.AddWithValue("@orszag", isz[16].orszag.ToString());*/

                
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
