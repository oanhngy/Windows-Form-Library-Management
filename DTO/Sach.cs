using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    public class Sach
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public int? MaTheLoai { get; set; }
        public int? MaTacGia { get; set; }
        public int? NamXuatBan { get; set; }
        public string NhaXuatBan { get; set; }
        public int? SoLuong { get; set; }
        public double GiaSach { get; set; }
        public int? GiaThue { get; set; }

        public string TenTacGia { get; set; }
        public string TenTheLoai { get; set; }
    }
}
