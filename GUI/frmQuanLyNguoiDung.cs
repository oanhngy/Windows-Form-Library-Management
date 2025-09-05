using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class frmQuanLyNguoiDung : Form
    {
        private NguoiDungBUS bus = new NguoiDungBUS();
        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void frmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            dgvNguoiDung.DataSource = bus.GetAll();

        }

        private void dgvNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNguoiDung.Rows[e.RowIndex];

                txtTenDangNhapND.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtTenDangNhapND.ReadOnly = true;

                txtMatKhauND.Text = row.Cells["MatKhau"].Value.ToString();
                txtHoTenND.Text = row.Cells["HoTen"].Value.ToString();
                txtVaiTroND.Text = row.Cells["VaiTro"].Value.ToString();
            }
        }

        private void btnAddND_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhapND.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhauND.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            NguoiDung nd = new NguoiDung
            {
                TenDangNhap = txtTenDangNhapND.Text.Trim(),
                MatKhau = txtMatKhauND.Text.Trim(),
                HoTen = txtHoTenND.Text.Trim(),
                VaiTro = txtVaiTroND.Text.Trim()
            };

            if (bus.AddNguoiDung(nd))
            {
                MessageBox.Show("Thêm người dùng thành công!");
                dgvNguoiDung.DataSource = bus.GetAll();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnUpdateND_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhapND.Text))
            {
                MessageBox.Show("Vui lòng chọn người dùng để cập nhật!");
                return;
            }

            NguoiDung nd = new NguoiDung
            {
                TenDangNhap = txtTenDangNhapND.Text.Trim(),
                MatKhau = txtMatKhauND.Text.Trim(),
                HoTen = txtHoTenND.Text.Trim(),
                VaiTro = txtVaiTroND.Text.Trim()
            };

            if (bus.UpdateNguoiDung(nd))
            {
                MessageBox.Show("Cập nhật thành công!");
                dgvNguoiDung.DataSource = bus.GetAll();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnDeleteND_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhapND.Text))
            {
                MessageBox.Show("Vui lòng chọn người dùng để xoá!");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xoá người dùng này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (bus.DeleteNguoiDung(txtTenDangNhapND.Text.Trim()))
                {
                    MessageBox.Show("Xoá thành công!");
                    dgvNguoiDung.DataSource = bus.GetAll();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại!");
                }
            }
        }

        private void btnExitND_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
