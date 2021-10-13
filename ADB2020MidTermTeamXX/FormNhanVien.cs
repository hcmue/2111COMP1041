using MidTerm2020;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Db4objects.Db4o.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADB2020MidTermTeamXX
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            var result = from CongTy cty in Database.DB
                         select cty;

            CongTy.DataSource = result.ToList();
            CongTy.DisplayMember = "TenCongTy";
            CongTy.ValueMember = "MaCongTy";

            LoadNhanVien();
        }

        private void ButtonThem_Click(object sender, EventArgs e)
        {
            var congTy = from CongTy cty in Database.DB
                         where cty.MaCongTy == Guid.Parse(CongTy.SelectedValue.ToString())
                         select cty;
            var nhanVien = new NhanVien
            {
                ID = Guid.NewGuid(),
                HoTen = HoTen.Text,
                Luong = double.Parse(Luong.Text),
                Skill = Skill.Text,
                HomeBase = congTy.ToList()[0]
            };

            Database.Store(nhanVien);

            LoadNhanVien();
        }

        private void LoadNhanVien()
        {
            var danhSach = from NhanVien nv in Database.DB
                           select nv;

            GridNhanVien.DataSource = danhSach.ToList();
        }
    }
}
