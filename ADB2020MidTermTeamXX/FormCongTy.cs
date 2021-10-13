using MidTerm2020;
using System;
using System.Linq;
using Db4objects.Db4o.Linq;
using System.Windows.Forms;

namespace ADB2020MidTermTeamXX
{
    public partial class FormCongTy : Form
    {
        public FormCongTy()
        {
            InitializeComponent();
        }

        private void ButtonThem_Click(object sender, EventArgs e)
        {
            var congty = new CongTy
            {
                MaCongTy = Guid.NewGuid(),
                TenCongTy = TenCongTy.Text,
                MaSoThue = MaSoThue.Text,
                SoNha = SoNha.Text,
                DuongPho = DuongPho.Text,
                QuanHuyen = Quan.Text
            };

            Database.Store<CongTy>(congty);

            LayDanhSachCongTy();
        }

        private void LayDanhSachCongTy()
        {
            var danhSach = from CongTy cty in Database.DB
                           select cty;

            dgvCongTy.DataSource = danhSach.ToList();
        }

        private void FormCongTy_Load(object sender, EventArgs e)
        {
            LayDanhSachCongTy();
        }
    }
}
