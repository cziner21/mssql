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
    public partial class modify : Form
    {
        public modify() {
            InitializeComponent();
        }

        private void modify_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'beadandoDataSet.isk_varos' table. You can move, or remove it, as needed.
            this.isk_varosTableAdapter.Fill(this.beadandoDataSet.isk_varos);
            this.isk_diak2TableAdapter.Fill(this.beadandoDataSet.isk_diak2);
            this.diakIdCbx.DataSource = this.beadandoDataSet.isk_diak2;
            this.diakIdCbx.ValueMember = "id";


            /*
             Táblakapcsolatokat master-detail kapcsolattal is meg lehet oldani, azzaz fent van listázva a tanuló tábla pl és ha rákattolunk 
             * egy névre, akkor alatta egy táblába a kapcsolótábla alapján a hozzá kapcsolt dolgokat is látod, pl
             * diáknévre katt-> nyelvizsga is látszódik
             */
            
        }

        private void modifyBtn_Click(object sender, EventArgs e) {
            try {

                SqlConnection connection = new SqlConnection(@"Data Source=ADAMLT\SQLEXPRESS;Initial Catalog=beadando;Integrated Security=True");
                connection.Open();

                /*tárolt eljárás hívása*/
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_updiak2";

                cmd.Parameters.AddWithValue("@nev", nevTbx.Text);
                
                cmd.Parameters.AddWithValue("@cim", cimTbx.Text);
                cmd.Parameters.AddWithValue("@tel_szam", telszamTbx.Text);
                cmd.Parameters.AddWithValue("@anyja_neve", anyjaTbx.Text);
                cmd.Parameters.AddWithValue("@zsebpenz", int.Parse(zsebpenzTbx.Text));
                cmd.Parameters.AddWithValue("@varos_id", varodIdTbx.Text);
                cmd.Parameters.AddWithValue("@diak_id", diakIdCbx.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Az adatok módosítása sikeresen megtörtént!", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fillAllTbx() {                     
            nevTbx.Text = dataGridView1.Rows[diakIdCbx.SelectedIndex].Cells[1].Value.ToString();
            cimTbx.Text = dataGridView1.Rows[diakIdCbx.SelectedIndex].Cells[2].Value.ToString();
            telszamTbx.Text = dataGridView1.Rows[diakIdCbx.SelectedIndex].Cells[3].Value.ToString();
            anyjaTbx.Text = dataGridView1.Rows[diakIdCbx.SelectedIndex].Cells[4].Value.ToString();
            zsebpenzTbx.Text = dataGridView1.Rows[diakIdCbx.SelectedIndex].Cells[5].Value.ToString();
            varodIdTbx.Text = dataGridView1.Rows[diakIdCbx.SelectedIndex].Cells[6].Value.ToString();         
        }

        public void selectTab(string szoveg){
            switch (szoveg) {
                case "diak":
                    tabControl1.SelectedTab = modifyDiak;
                    break;
                case "varos":
                    tabControl1.SelectedTab = modifyVaros;
                    break;
                case "nyelvvizsga":
                    tabControl1.SelectedTab = modifyNyelvvizsga;
                    break;
                case "szak":
                    tabControl1.SelectedTab = modifySzak;
                    break;
                default:
                    tabControl1.SelectedTab = modifyDiak;
                    break;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)  //to disable the row and column headers
            {
                diakIdCbx.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value;
                nevTbx.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                cimTbx.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex+1].Value.ToString();
                telszamTbx.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex+2].Value.ToString();
                anyjaTbx.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex+3].Value.ToString();
            }

            
        }

        private void diakIdCbx_SelectedIndexChanged(object sender, EventArgs e) {            
            fillAllTbx();
        }

        

        private void button2_Click(object sender, EventArgs e) {
            try {

                SqlConnection connection = new SqlConnection(@"Data Source=ADAMLT\SQLEXPRESS;Initial Catalog=beadando;Integrated Security=True");
                connection.Open();

                /*tárolt eljárás hívása*/
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_upvaros";
                int selectedRow = dataGridView1.CurrentRow.Index;
                //MessageBox.Show(selectedRow.ToString());
                cmd.Parameters.AddWithValue("@nev", dataGridView1[0, selectedRow].Value);
                //MessageBox.Show(dataGridView1[0, selectedRow].ToString());
                cmd.Parameters.AddWithValue("@megye", dataGridView1[1, selectedRow]);
                cmd.Parameters.AddWithValue("@orszag", dataGridView1[2, selectedRow]);
                cmd.Parameters.AddWithValue("@varos_id", dataGridView1[3, selectedRow]);
/*
                cmd.Parameters.AddWithValue("@cim", cimTbx.Text);
                cmd.Parameters.AddWithValue("@tel_szam", telszamTbx.Text);
                cmd.Parameters.AddWithValue("@anyja_neve", anyjaTbx.Text);
                cmd.Parameters.AddWithValue("@zsebpenz", int.Parse(zsebpenzTbx.Text));
                cmd.Parameters.AddWithValue("@varos_id", varodIdTbx.Text);
                cmd.Parameters.AddWithValue("@diak_id", diakIdCbx.SelectedValue);
                */
                cmd.ExecuteNonQuery();
                MessageBox.Show("Az adatok módosítása sikeresen megtörtént!", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);




            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
