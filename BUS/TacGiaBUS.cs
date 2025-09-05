using System.Collections.Generic;
using QuanLyThuVien.DTO;
using QuanLyThuVien.DAL;

namespace QuanLyThuVien.BUS
{
    public class TacGiaBUS
    {
        private TacGiaDAL dal = new TacGiaDAL();

        public List<TacGia> GetAll()
        {
            return dal.LayTatCa();
        }
    }
}
