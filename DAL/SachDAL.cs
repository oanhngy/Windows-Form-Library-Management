using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    public class SachDAL
    {
        public List<Sach> LayTatCa()
        {
            var ds = new List<Sach>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM SACH";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new Sach
                    {
                        MaSach = Convert.ToInt32(reader["MaSach"]),
                        TenSach = reader["TenSach"].ToString(),
                        MaTheLoai = reader["MaTheLoai"] as int?,
                        MaTacGia = reader["MaTacGia"] as int?,
                        NamXuatBan = reader["NamXuatBan"] as int?,
                        NhaXuatBan = reader["NhaXuatBan"].ToString(),
                        SoLuong = reader["SoLuong"] as int?,
                        GiaSach = Convert.ToDouble(reader["GiaSach"]),
                        GiaThue = reader["GiaThue"] as int?
                    });
                }
            }
            return ds;
        }

        public bool Them(Sach s)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO SACH (TenSach, MaTheLoai, MaTacGia, NhaXuatBan, NamXuatBan, SoLuong, GiaSach, GiaThue)
                                 VALUES (@Ten, @TheLoai, @TacGia, @NXB, @Nam, @SL, @Gia, @GiaThue)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ten", s.TenSach);
                cmd.Parameters.AddWithValue("@TheLoai", s.MaTheLoai);
                cmd.Parameters.AddWithValue("@TacGia", s.MaTacGia);
                cmd.Parameters.AddWithValue("@NXB", s.NhaXuatBan);
                cmd.Parameters.AddWithValue("@Nam", s.NamXuatBan);
                cmd.Parameters.AddWithValue("@SL", s.SoLuong);
                cmd.Parameters.AddWithValue("@Gia", s.GiaSach);
                cmd.Parameters.AddWithValue("@GiaThue", s.GiaThue);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(Sach s)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE SACH SET 
                                    TenSach = @Ten, MaTheLoai = @TheLoai, MaTacGia = @TacGia,
                                    NhaXuatBan = @NXB, NamXuatBan = @Nam, SoLuong = @SL, GiaSach = @Gia, GiaThue = @GiaThue
                                 WHERE MaSach = @Ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", s.MaSach);
                cmd.Parameters.AddWithValue("@Ten", s.TenSach);
                cmd.Parameters.AddWithValue("@TheLoai", s.MaTheLoai);
                cmd.Parameters.AddWithValue("@TacGia", s.MaTacGia);
                cmd.Parameters.AddWithValue("@NXB", s.NhaXuatBan);
                cmd.Parameters.AddWithValue("@Nam", s.NamXuatBan);
                cmd.Parameters.AddWithValue("@SL", s.SoLuong);
                cmd.Parameters.AddWithValue("@Gia", s.GiaSach);
                cmd.Parameters.AddWithValue("@GiaThue", s.GiaThue);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(int maSach)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM SACH WHERE MaSach = @Ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", maSach);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<Sach> TimSach(string tenSach, string tacGia, string nhaXuatBan, int? maTheLoai)
        {
            var ds = new List<Sach>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT S.MaSach, S.TenSach, S.MaTheLoai, S.MaTacGia, S.NhaXuatBan, S.NamXuatBan, S.SoLuong, S.GiaSach, S.GiaThue, 
                   T.TenTacGia, TL.TenTheLoai
            FROM SACH S
            LEFT JOIN TACGIA T ON S.MaTacGia = T.MaTacGia
            LEFT JOIN THELOAI TL ON S.MaTheLoai = TL.MaTheLoai
            WHERE 1 = 1";

                if (!string.IsNullOrEmpty(tenSach))
                {
                    query += " AND S.TenSach LIKE @TenSach";
                }

                if (!string.IsNullOrEmpty(tacGia))
                {
                    query += " AND T.TenTacGia LIKE @TacGia";
                }

                if (!string.IsNullOrEmpty(nhaXuatBan))
                {
                    query += " AND S.NhaXuatBan LIKE @NhaXuatBan";
                }

                if (maTheLoai.HasValue)
                {
                    query += " AND S.MaTheLoai = @MaTheLoai";
                }

                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(tenSach))
                {
                    cmd.Parameters.AddWithValue("@TenSach", "%" + tenSach + "%");
                }

                if (!string.IsNullOrEmpty(tacGia))
                {
                    cmd.Parameters.AddWithValue("@TacGia", "%" + tacGia + "%");
                }

                if (!string.IsNullOrEmpty(nhaXuatBan))
                {
                    cmd.Parameters.AddWithValue("@NhaXuatBan", "%" + nhaXuatBan + "%");
                }

                if (maTheLoai.HasValue)
                {
                    cmd.Parameters.AddWithValue("@MaTheLoai", maTheLoai.Value);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new Sach
                    {
                        MaSach = Convert.ToInt32(reader["MaSach"]),
                        TenSach = reader["TenSach"].ToString(),
                        MaTheLoai = reader["MaTheLoai"] as int?,
                        MaTacGia = reader["MaTacGia"] as int?,
                        NamXuatBan = reader["NamXuatBan"] as int?,
                        NhaXuatBan = reader["NhaXuatBan"].ToString(),
                        SoLuong = reader["SoLuong"] as int?,
                        GiaSach = Convert.ToDouble(reader["GiaSach"]),
                        GiaThue = reader["GiaThue"] as int ?,
                        TenTacGia = reader["TenTacGia"].ToString(),
                        TenTheLoai = reader["TenTheLoai"].ToString(),
                    });
                }
            }
            return ds;
        }

        public List<TheLoai> LayTatCaTheLoai()
        {
            var ds = new List<TheLoai>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM THELOAI";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new TheLoai
                    {
                        MaTheLoai = Convert.ToInt32(reader["MaTheLoai"]),
                        TenTheLoai = reader["TenTheLoai"].ToString()
                    });
                }
            }
            return ds;
        }
    }
}
