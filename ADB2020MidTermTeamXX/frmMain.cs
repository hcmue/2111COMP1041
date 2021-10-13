using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADB2020MidTermTeamXX
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void danhSáchCôngTyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCongTy();
            form.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Database.DbFileName = "EmployeeManager.db";
            Database.Open();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Database.Close();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormNhanVien();
            form.Show();
        }
    }
}
