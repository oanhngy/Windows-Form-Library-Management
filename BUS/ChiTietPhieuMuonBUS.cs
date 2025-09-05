using System.Collections.Generic;
using QuanLyThuVien.DTO;
using QuanLyThuVien.DAL;

namespace QuanLyThuVien.BUS
{
    public class ChiTietPhieuMuonBUS
    {
        private ChiTietPhieuMuonDAL dal = new ChiTietPhieuMuonDAL();

        public List<ChiTietPhieuMuon> GetByPhieuMuon(int maPhieuMuon)
        {
            return dal.LayChiTietTheoPhieu(maPhieuMuon);
        }

        public bool AddCTPM(ChiTietPhieuMuon ctpm)
        {
            return dal.ThemCTPM(ctpm);
        }

        public bool UpdateCTPM(ChiTietPhieuMuon ctpm)
        {
            return dal.CapNhatCTPM(ctpm);
        }

        public bool DeleteCTPM(int maPhieuMuon, int maSach)
        {
            return dal.XoaCTPM(maPhieuMuon, maSach);
        }
    }
}
