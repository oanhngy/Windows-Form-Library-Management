using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    public class TheLoaiDAL
    {
        public List<TheLoai> LayTatCa()
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
