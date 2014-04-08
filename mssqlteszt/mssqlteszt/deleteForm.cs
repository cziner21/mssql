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

namespace mssqlteszt
{
    public partial class deleteForm : Form
    {
        public deleteForm() {
            InitializeComponent();
        }

        public void selectTab(string szoveg) {
            switch (szoveg) {
                case "diak":
                    tabControl1.SelectedTab = deleteDiak;
                    break;
                case "varos":
                    tabControl1.SelectedTab = deleteVaros;
                    break;
                case "nyelvvizsga":
                    tabControl1.SelectedTab = deleteNyelvvizsga;
                    break;
                case "szak":
                    tabControl1.SelectedTab = deleteSzak;
                    break;
                default:
                    tabControl1.SelectedTab = deleteDiak;
                    break;
            }
        }

        private void deleteForm_Load(object sender, EventArgs e) {
            this.isk_diak2TableAdapter.Fill(this.beadandoDataSet.isk_diak2);
            this.diakIdCbx.DataSource = this.beadandoDataSet.isk_diak2;
            this.diakIdCbx.ValueMember = "id";

            this.isk_varosTableAdapter.Fill(this.beadandoDataSet.isk_varos);
            this.varosIdCbx.DataSource = this.beadandoDataSet.isk_varos;
            this.varosIdCbx.ValueMember = "id";

            this.isk_nyelvizsgaTableAdapter.Fill(this.beadandoDataSet.isk_nyelvizsga);
            this.nyelvizsgaIdCbx.DataSource = this.beadandoDataSet.isk_nyelvizsga;
            this.nyelvizsgaIdCbx.ValueMember = "id";

            this.isk_szakTableAdapter.Fill(this.beadandoDataSet.isk_szak);
            this.szakIdCbx.DataSource = this.beadandoDataSet.isk_szak;
            this.szakIdCbx.ValueMember = "id";
        }

        private void deleteBtn_Click(object sender, EventArgs e) {
            try {
                SqlConnection connection = new SqlConnection(@"Data Source=ADAMLT\SQLEXPRESS;Initial Catalog=beadando;Integrated Security=True");
                connection.Open();

                /*tárolt eljárás hívása*/
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_deldiak2";
                cmd.Parameters.AddWithValue("@ID", diakIdCbx.SelectedValue);
                DialogResult dialogResult = MessageBox.Show("Biztosan törölni szeretné az adott diákot?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes) {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Az adatok törlése sikeresen megtörtént!", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void delVarosBtn_Click(object sender, EventArgs e) {
            try{
                SqlConnection connection = new SqlConnection(@"Data Source=ADAMLT\SQLEXPRESS;Initial Catalog=beadando;Integrated Security=True");
                connection.Open();

                /*tárolt eljárás hívása*/
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_delvaros";
                cmd.Parameters.AddWithValue("@ID", varosIdCbx.SelectedValue);
                DialogResult dialogResult = MessageBox.Show("Biztosan törölni szeretné az adott várost?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes) {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Az adatok törlése sikeresen megtörtént!", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void delNyelvizsgaBtn_Click(object sender, EventArgs e) {
            try {
                SqlConnection connection = new SqlConnection(@"Data Source=ADAMLT\SQLEXPRESS;Initial Catalog=beadando;Integrated Security=True");
                connection.Open();

                /*tárolt eljárás hívása*/
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_delnyelvizsga";
                cmd.Parameters.AddWithValue("@ID", nyelvizsgaIdCbx.SelectedValue);
                DialogResult dialogResult = MessageBox.Show("Biztosan törölni szeretné az adott nyelvizsgát?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes) {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Az adatok törlése sikeresen megtörtént!", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void delSzakBtn_Click(object sender, EventArgs e) {
            try {
                SqlConnection connection = new SqlConnection(@"Data Source=ADAMLT\SQLEXPRESS;Initial Catalog=beadando;Integrated Security=True");
                connection.Open();

                /*tárolt eljárás hívása*/
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "isk_delszak";
                cmd.Parameters.AddWithValue("@ID", szakIdCbx.SelectedValue);
                DialogResult dialogResult = MessageBox.Show("Biztosan törölni szeretné az adott szakot?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes) {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Az adatok törlése sikeresen megtörtént!", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
