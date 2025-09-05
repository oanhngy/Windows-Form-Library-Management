using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    public class TacGiaDAL
    {
        public List<TacGia> LayTatCa()
        {
            var ds = new List<TacGia>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM TACGIA";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new TacGia
                    {
                        MaTacGia = Convert.ToInt32(reader["MaTacGia"]),
                        TenTacGia = reader["TenTacGia"].ToString()
                    });
                }
            }
            return ds;
        }

    }
}
