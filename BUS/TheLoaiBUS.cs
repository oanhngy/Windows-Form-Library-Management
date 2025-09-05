using System.Collections.Generic;
using QuanLyThuVien.DTO;
using QuanLyThuVien.DAL;

namespace QuanLyThuVien.BUS
{
    public class TheLoaiBUS
    {
        private TheLoaiDAL dal = new TheLoaiDAL();

        public List<TheLoai> GetAll()
        {
            return dal.LayTatCa();
        }
    }
}
