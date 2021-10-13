using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm2020
{
    [Serializable]
    public class NhanVien
    {
        [Key]
        public Guid ID { get; set; }
        public string HoTen { get; set; }
        public string Skill { get; set; }
        public CongTy HomeBase { get; set; }
        public double Luong { get; set; }

        //relationships
        public NhanVien QuanLy { get; set; }
        public List<NhanVien> NhanViens { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} ({2})", HoTen, Skill, Luong);
        }
    }
}
