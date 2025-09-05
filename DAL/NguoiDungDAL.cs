using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    public class NguoiDungDAL
    {
        public NguoiDung DangNhap(string tenDangNhap, string matKhau)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM NGUOIDUNG WHERE TenDangNhap = @username AND MatKhau = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", tenDangNhap);
                cmd.Parameters.AddWithValue("@password", matKhau);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new NguoiDung
                    {
                        TenDangNhap = reader["TenDangNhap"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                        VaiTro = reader["VaiTro"].ToString()
                    };
                }
            }
            return null;
        }

        public List<NguoiDung> LayTatCa()
        {
            var list = new List<NguoiDung>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM NGUOIDUNG";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new NguoiDung
                    {
                        TenDangNhap = reader["TenDangNhap"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                        VaiTro = reader["VaiTro"].ToString()
                    });
                }
            }
            return list;
        }

        public bool Them(NguoiDung nd)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO NGUOIDUNG (TenDangNhap, MatKhau, HoTen, VaiTro) VALUES (@Ten, @MatKhau, @HoTen, @VaiTro)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ten", nd.TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", nd.MatKhau);
                cmd.Parameters.AddWithValue("@HoTen", nd.HoTen);
                cmd.Parameters.AddWithValue("@VaiTro", nd.VaiTro);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(NguoiDung nd)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE NGUOIDUNG SET MatKhau = @MatKhau, HoTen = @HoTen, VaiTro = @VaiTro WHERE TenDangNhap = @Ten";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ten", nd.TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", nd.MatKhau);
                cmd.Parameters.AddWithValue("@HoTen", nd.HoTen);
                cmd.Parameters.AddWithValue("@VaiTro", nd.VaiTro);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string tenDangNhap)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM NGUOIDUNG WHERE TenDangNhap = @Ten";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ten", tenDangNhap);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
