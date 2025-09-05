using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QuanLyThuVien.DAL
{
    public class DocGiaDAL
    {
        public List<DocGia> LayTatCa()
        {
            var ds = new List<DocGia>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM DOCGIA";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new DocGia
                    {
                        MaDocGia = Convert.ToInt32(reader["MaDocGia"]),
                        HoTen = reader["HoTen"].ToString(),
                        NgaySinh = reader["NgaySinh"] as DateTime?,
                        GioiTinh = reader["GioiTinh"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        Email = reader["Email"].ToString(),
                        SoDienThoai = reader["SoDienThoai"].ToString(),
                        NgayDangKy = Convert.ToDateTime(reader["NgayDangKy"])
                    });
                }
            }
            return ds;
        }

        public bool Them(DocGia dg)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO DOCGIA (HoTen, NgaySinh, GioiTinh, DiaChi, Email, SoDienThoai, NgayDangKy)
                                 VALUES (@HoTen, @NgaySinh, @GioiTinh, @DiaChi, @Email, @SoDienThoai, @NgayDangKy)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HoTen", dg.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", dg.NgaySinh ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", dg.GioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", dg.DiaChi);
                cmd.Parameters.AddWithValue("@Email", dg.Email);
                cmd.Parameters.AddWithValue("@SoDienThoai", dg.SoDienThoai);
                cmd.Parameters.AddWithValue("@NgayDangKy", dg.NgayDangKy);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(DocGia dg)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE DOCGIA SET 
                                    HoTen = @HoTen,
                                    NgaySinh = @NgaySinh,
                                    GioiTinh = @GioiTinh,
                                    DiaChi = @DiaChi,
                                    Email = @Email,
                                    SoDienThoai = @SoDienThoai,
                                    NgayDangKy = @NgayDangKy
                                 WHERE MaDocGia = @MaDocGia";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDocGia", dg.MaDocGia);
                cmd.Parameters.AddWithValue("@HoTen", dg.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", dg.NgaySinh ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", dg.GioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", dg.DiaChi);
                cmd.Parameters.AddWithValue("@Email", dg.Email);
                cmd.Parameters.AddWithValue("@SoDienThoai", dg.SoDienThoai);
                cmd.Parameters.AddWithValue("@NgayDangKy", dg.NgayDangKy);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(int maDocGia)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM DOCGIA WHERE MaDocGia = @MaDocGia";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
