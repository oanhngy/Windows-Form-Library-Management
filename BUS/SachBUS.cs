using System.Collections.Generic;
using QuanLyThuVien.DTO;
using QuanLyThuVien.DAL;

namespace QuanLyThuVien.BUS
{
    public class SachBUS
    {
        private SachDAL dal = new SachDAL();

        public List<Sach> GetAll()
        {
            return dal.LayTatCa();
        }

        public bool AddSach(Sach s)
        {
            return dal.Them(s);
        }

        public bool UpdateSach(Sach s)
        {
            return dal.CapNhat(s);
        }

        public bool DeleteSach(int maSach)
        {
            return dal.Xoa(maSach);
        }

        public List<Sach> SearchSach(string tenSach, string tacGia, string nhaXuatBan, int? maTheLoai)
        {
            return dal.TimSach(tenSach, tacGia, nhaXuatBan, maTheLoai);
        }

        public List<Sach> GetAllNhaXuatBan()
        {
            return dal.LayTatCa();
        }

        public List<TheLoai> GetAllTheLoai()
        {
            return dal.LayTatCaTheLoai();
        }
    }
}
