using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QuanLyThuVien.DAL
{
    public class ChiTietPhieuMuonDAL
    {
        public List<ChiTietPhieuMuon> LayChiTietTheoPhieu(int maPhieuMuon)
        {
            List<ChiTietPhieuMuon> danhSach = new List<ChiTietPhieuMuon>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM CT_PHIEUMUON WHERE MaPhieuMuon = @maPM";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maPM", maPhieuMuon);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    danhSach.Add(new ChiTietPhieuMuon
                    {
                        MaPhieuMuon = Convert.ToInt32(reader["MaPhieuMuon"]),
                        MaSach = Convert.ToInt32(reader["MaSach"]),
                        SoLuong = reader["SoLuong"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["SoLuong"]),
                        SoNgayThue = reader["SoNgayThue"] as int?,
                        Gia = reader["Gia"] as int?
                    });
                }
            }

            return danhSach;
        }

        public bool ThemCTPM(ChiTietPhieuMuon ctpm)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO CT_PHIEUMUON (MaPhieuMuon, MaSach, SoLuong, SoNgayThue, Gia)
                                 VALUES (@MaPhieuMuon, @MaSach, @SoLuong, @SoNgayThue, @Gia)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuMuon", ctpm.MaPhieuMuon);
                cmd.Parameters.AddWithValue("@MaSach", ctpm.MaSach);
                cmd.Parameters.AddWithValue("@SoLuong", ctpm.SoLuong);
                cmd.Parameters.AddWithValue("@SoNgayThue", ctpm.SoNgayThue);
                cmd.Parameters.AddWithValue("@Gia", ctpm.Gia);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhatCTPM(ChiTietPhieuMuon ctpm)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE CT_PHIEUMUON 
                                 SET SoLuong = @SoLuong, SoNgayThue = @SoNgayThue, Gia = @Gia
                                 WHERE MaPhieuMuon = @MaPhieuMuon AND MaSach = @MaSach";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuMuon", ctpm.MaPhieuMuon);
                cmd.Parameters.AddWithValue("@MaSach", ctpm.MaSach);
                cmd.Parameters.AddWithValue("@SoLuong", ctpm.SoLuong);
                cmd.Parameters.AddWithValue("@SoNgayThue", ctpm.SoNgayThue);
                cmd.Parameters.AddWithValue("@Gia", ctpm.Gia);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaCTPM(int maPhieuMuon, int maSach)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM CT_PHIEUMUON WHERE MaPhieuMuon = @MaPhieuMuon AND MaSach = @MaSach";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);
                cmd.Parameters.AddWithValue("@MaSach", maSach);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
