using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm2020
{
    [Serializable]
    public class CongTy
    {
        [Key]
        public Guid MaCongTy { get; set; }
		public string MaSoThue { get; set; }
        public string TenCongTy { get; set; }
        public string SoNha { get; set; }
        public string DuongPho { get; set; }
        public string QuanHuyen { get; set; }
        public int SoLuongNhanVien => NhanViens != null ? NhanViens.Count : 0;

        //relationships
        public NhanVien GiamDoc { get; set; }
        public List<NhanVien> NhanViens { get; set; }

        public override string ToString()
        {
            return TenCongTy;
        }
    }
}
