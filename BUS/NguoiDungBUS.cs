using QuanLyThuVien.DTO;
using QuanLyThuVien.DAL;
using System.Collections.Generic;

namespace QuanLyThuVien.BUS
{
    public class NguoiDungBUS
    {
        private NguoiDungDAL dal = new NguoiDungDAL();

        public NguoiDung DangNhap(string tenDangNhap, string matKhau)
        {
            return dal.DangNhap(tenDangNhap, matKhau);
        }

        public List<NguoiDung> GetAll()
        {
            return dal.LayTatCa();
        }

        public bool AddNguoiDung(NguoiDung nd)
        {
            return dal.Them(nd);
        }

        public bool UpdateNguoiDung(NguoiDung nd)
        {
            return dal.CapNhat(nd);
        }

        public bool DeleteNguoiDung(string tenDangNhap)
        {
            return dal.Xoa(tenDangNhap);
        }
    }
}
