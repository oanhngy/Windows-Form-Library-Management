﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    public class PhieuMuon
    {
        public int MaPhieuMuon { get; set; }
        public int? MaDocGia { get; set; }
        public DateTime? NgayMuon { get; set; }
        public DateTime? NgayTra { get; set; }
        public string TrangThai { get; set; }
        public int? TongGia { get; set; }
    }
}
