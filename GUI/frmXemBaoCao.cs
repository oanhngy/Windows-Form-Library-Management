using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace QuanLyThuVien.GUI
{
    public partial class frmXemBaoCao : Form
    {
        private string connectionString = "Data Source=OA;Initial Catalog=PTPMUD_QuanLyThuVien;Integrated Security=True";
        public frmXemBaoCao()
        {
            InitializeComponent();
        }

        private void frmXemBaoCao_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=OA;Initial Catalog=PTPMUD_QuanLyThuVien;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT FORMAT(NgayMuon, 'MM/yyyy') AS Thang FROM PHIEUMUON ORDER BY Thang", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboReport.Items.Add(reader["Thang"].ToString());
                }

                if (cboReport.Items.Count > 0)
                    cboReport.SelectedIndex = 0;
            }

            reportViewerDoanhThu.RefreshReport();
            reportViewerLuotMuon.RefreshReport();
            reportViewerSoLuongSach.RefreshReport();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string selectedThang = cboReport.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedThang)) return;

            LoadReportDoanhThu(selectedThang);
            LoadReportLuotMuon(selectedThang);
            LoadReportSoLuongSach(selectedThang);
        }

        private void LoadReportDoanhThu(string thang)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        FORMAT(PM.NgayMuon, 'MM/yyyy') AS Thang, 
                        PM.MaPhieuMuon, 
                        CTPM.Gia AS DoanhThuPhieu
                    FROM PHIEUMUON PM
                    JOIN CT_PHIEUMUON CTPM ON PM.MaPhieuMuon = CTPM.MaPhieuMuon
                    WHERE FORMAT(PM.NgayMuon, 'MM/yyyy') = @Thang";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Thang", thang);
                da.Fill(dt);
            }

            ReportDataSource rds = new ReportDataSource("DS_Report", dt);
            reportViewerDoanhThu.LocalReport.DataSources.Clear();
            reportViewerDoanhThu.LocalReport.DataSources.Add(rds);
            reportViewerDoanhThu.LocalReport.ReportPath = "ReportDoanhThu.rdlc";
            reportViewerDoanhThu.RefreshReport();
        }

        private void LoadReportLuotMuon(string thang)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM ReportLuotMuon WHERE Thang = @Thang";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Thang", thang);
                da.Fill(dt);
            }

            ReportDataSource rds = new ReportDataSource("DS_Report2", dt);
            reportViewerLuotMuon.LocalReport.DataSources.Clear();
            reportViewerLuotMuon.LocalReport.DataSources.Add(rds);
            reportViewerLuotMuon.LocalReport.ReportPath = "ReportLuotMuon.rdlc";
            reportViewerLuotMuon.RefreshReport();
        }

        private void LoadReportSoLuongSach(string thang)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM ReportSoLuongSach WHERE Thang = @Thang";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Thang", thang);
                da.Fill(dt);
            }

            ReportDataSource rds = new ReportDataSource("DS_Report3", dt);
            reportViewerSoLuongSach.LocalReport.DataSources.Clear();
            reportViewerSoLuongSach.LocalReport.DataSources.Add(rds);
            reportViewerSoLuongSach.LocalReport.ReportPath = "ReportSoLuongSach.rdlc";
            reportViewerSoLuongSach.RefreshReport();
        }
    }
}
