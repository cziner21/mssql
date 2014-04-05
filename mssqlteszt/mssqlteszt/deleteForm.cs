using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}
