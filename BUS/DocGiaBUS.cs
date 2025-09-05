using System.Collections.Generic;
using QuanLyThuVien.DTO;
using QuanLyThuVien.DAL;

namespace QuanLyThuVien.BUS
{
    public class DocGiaBUS
    {
        private DocGiaDAL dal = new DocGiaDAL();

        public List<DocGia> GetAll()
        {
            return dal.LayTatCa();
        }

        public bool AddDocGia(DocGia dg)
        {
            return dal.Them(dg);
        }

        public bool UpdateDocGia(DocGia dg)
        {
            return dal.CapNhat(dg);
        }

        public bool DeleteDocGia(int maDocGia)
        {
            return dal.Xoa(maDocGia);
        }
    }
}
