using System.Collections.Generic;
using QuanLyThuVien.DTO;
using QuanLyThuVien.DAL;

namespace QuanLyThuVien.BUS
{
    public class PhieuMuonBUS
    {
        private PhieuMuonDAL dal = new PhieuMuonDAL();

        public List<PhieuMuon> GetAll()
        {
            return dal.LayTatCa();
        }

        public bool AddPhieuMuon(PhieuMuon pm)
        {
            return dal.Them(pm);
        }

        public bool UpdatePhieuMuon(PhieuMuon pm)
        {
            return dal.CapNhat(pm);
        }

        public bool DeletePhieuMuon(int maPhieuMuon)
        {
            return dal.Xoa(maPhieuMuon);
        }
    }
}
