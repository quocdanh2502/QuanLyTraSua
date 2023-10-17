using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTraSua
{
    public class SanPham_Mod
    {
        public string IdSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string  GiaSanPham { get; set; }
        public string IdHoaDon { get; set; }
        public int SoLuong { get; set; }
    }

    public class HoaDon_Mod
    {
        public string IdHoaDon { get; set; }
        public DateTime NgayTao { get; set; }
        public int SoLuongSP { get; set; }
        public int TongTien { get; set; }
        public string MaNV { get; set; }
    }
}
