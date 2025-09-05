using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    public class PhieuMuonDAL
    {
        public List<PhieuMuon> LayTatCa()
        {
            var ds = new List<PhieuMuon>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM PHIEUMUON";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new PhieuMuon
                    {
                        MaPhieuMuon = Convert.ToInt32(reader["MaPhieuMuon"]),
                        MaDocGia = reader["MaDocGia"] as int?,
                        NgayMuon = reader["NgayMuon"] as DateTime?,
                        NgayTra = reader["NgayTra"] as DateTime?,
                        TrangThai = reader["TrangThai"].ToString(),
                        TongGia = reader["TongGia"] as int?
                    });
                }
            }
            return ds;
        }

        public bool Them(PhieuMuon pm)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO PHIEUMUON (MaDocGia, NgayMuon, NgayTra, TrangThai)
                                 VALUES (@MaDocGia, @NgayMuon, @NgayTra, @TrangThai)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDocGia", pm.MaDocGia);
                cmd.Parameters.AddWithValue("@NgayMuon", pm.NgayMuon);
                cmd.Parameters.AddWithValue("@NgayTra", pm.NgayTra);
                cmd.Parameters.AddWithValue("@TrangThai", pm.TrangThai);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(PhieuMuon pm)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE PHIEUMUON SET 
                                    MaDocGia = @MaDocGia,
                                    NgayMuon = @NgayMuon,
                                    NgayTra = @NgayTra,
                                    TrangThai = @TrangThai
                                 WHERE MaPhieuMuon = @MaPM";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPM", pm.MaPhieuMuon);
                cmd.Parameters.AddWithValue("@MaDocGia", pm.MaDocGia);
                cmd.Parameters.AddWithValue("@NgayMuon", pm.NgayMuon);
                cmd.Parameters.AddWithValue("@NgayTra", pm.NgayTra);
                cmd.Parameters.AddWithValue("@TrangThai", pm.TrangThai);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(int maPM)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM PHIEUMUON WHERE MaPhieuMuon = @MaPM";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPM", maPM);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
