using QuanLyThuVien.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.GUI
{
    public partial class frmQuanLyDocGia : Form
    {
        private DocGiaBUS docGiaBUS = new DocGiaBUS();
        public frmQuanLyDocGia()
        {
            InitializeComponent();
        }

        private void frmQuanLyDocGia_Load(object sender, EventArgs e)
        {
            dgvDocGia.DataSource = docGiaBUS.GetAll();

            txtMaDG.Text = "Hệ thống tự động điền";
            txtMaDG.ReadOnly = true;
            txtMaDG.ForeColor = Color.LightGray;
            txtMaDG.Font = new Font(txtMaDG.Font, FontStyle.Italic);

            dgvDocGia.Columns["Email"].Width = 200;
        }

        private void dgvDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDocGia.Rows[e.RowIndex].Cells["MaDocGia"].Value != null)
            {
                DataGridViewRow row = dgvDocGia.Rows[e.RowIndex];

                txtMaDG.Text = row.Cells["MaDocGia"].Value.ToString();
                txtMaDG.ReadOnly = true;

                txtHoTenDG.Text = row.Cells["HoTen"].Value.ToString();
                dtpNgaySinhDG.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                txtGioiTinhDG.Text = row.Cells["GioiTinh"].Value.ToString();
                txtDiaChiDG.Text = row.Cells["DiaChi"].Value.ToString();
                txtEmailDG.Text = row.Cells["Email"].Value.ToString();
                txtDienThoaiDG.Text = row.Cells["SoDienThoai"].Value.ToString();
                dtpDangKyDG.Value = Convert.ToDateTime(row.Cells["NgayDangKy"].Value);
            }
        }

        private void btnAddDG_Click(object sender, EventArgs e)
        {
            DocGia dg = new DocGia
            {
                HoTen = txtHoTenDG.Text.Trim(),
                NgaySinh = dtpNgaySinhDG.Value,
                GioiTinh = txtGioiTinhDG.Text.Trim(),
                DiaChi = txtDiaChiDG.Text.Trim(),
                Email = txtEmailDG.Text.Trim(),
                SoDienThoai = txtDienThoaiDG.Text.Trim(),
                NgayDangKy = dtpDangKyDG.Value
            };

            if (docGiaBUS.AddDocGia(dg))
            {
                MessageBox.Show("Thêm độc giả thành công!");
                dgvDocGia.DataSource = docGiaBUS.GetAll();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnUpdateDG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDG.Text)) return;

            DocGia dg = new DocGia
            {
                MaDocGia = int.Parse(txtMaDG.Text),
                HoTen = txtHoTenDG.Text.Trim(),
                NgaySinh = dtpNgaySinhDG.Value,
                GioiTinh = txtGioiTinhDG.Text.Trim(),
                DiaChi = txtDiaChiDG.Text.Trim(),
                Email = txtEmailDG.Text.Trim(),
                SoDienThoai = txtDienThoaiDG.Text.Trim(),
                NgayDangKy = dtpDangKyDG.Value
            };

            if (docGiaBUS.UpdateDocGia(dg))
            {
                MessageBox.Show("Cập nhật thành công!");
                dgvDocGia.DataSource = docGiaBUS.GetAll();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnDeleteDG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDG.Text)) return;

            int ma = int.Parse(txtMaDG.Text);
            if (docGiaBUS.DeleteDocGia(ma))
            {
                MessageBox.Show("Xoá thành công!");
                dgvDocGia.DataSource = docGiaBUS.GetAll();
            }
            else
            {
                MessageBox.Show("Xoá thất bại!");
            }
        }

        private void btnExitDG_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
