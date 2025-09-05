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
    public partial class frmQuanLySach : Form
    {
        private SachBUS bus = new SachBUS();
        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            dgvSach.DataSource = bus.GetAll();

            txtMaS.Text = "Hệ thống tự động điền";
            txtMaS.ReadOnly = true;
            txtMaS.ForeColor = Color.LightGray;
            txtMaS.Font = new Font(txtMaS.Font, FontStyle.Italic);

            txtGiaThueS.Text = "Hệ thống tự động điền";
            txtGiaThueS.ReadOnly = true;
            txtGiaThueS.ForeColor = Color.LightGray;
            txtGiaThueS.Font = new Font(txtGiaThueS.Font, FontStyle.Italic);
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSach.Rows[e.RowIndex].Cells["MaSach"].Value != null)
            {
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];

                txtMaS.Text = row.Cells["MaSach"].Value.ToString();
                txtMaS.ReadOnly = true;
                txtMaS.ForeColor = Color.Black;
                txtMaS.Font = new Font(txtMaS.Font, FontStyle.Regular);

                txtTenS.Text = row.Cells["TenSach"].Value.ToString();
                txtMaTheLoaiS.Text = row.Cells["MaTheLoai"].Value.ToString();
                txtMaTacGiaS.Text = row.Cells["MaTacGia"].Value.ToString();
                txtNhaXuatBanS.Text = row.Cells["NhaXuatBan"].Value.ToString();
                txtNamXuatBanS.Text = row.Cells["NamXuatBan"].Value.ToString();
                txtSoLuongS.Text = row.Cells["SoLuong"].Value.ToString();
                txtGiaS.Text = row.Cells["GiaSach"].Value.ToString();
                txtGiaThueS.Text = row.Cells["GiaThue"].Value.ToString();
            }
        }

        private void btnAddS_Click(object sender, EventArgs e)
        {
            double giaSach = double.Parse(txtGiaS.Text.Trim());
            int giaThue;

            if (giaSach > 200000)
                giaThue = 20000;
            else if (giaSach > 100000)
                giaThue = 10000;
            else if (giaSach > 80000)
                giaThue = 5000;
            else
                giaThue = 3000;

            Sach s = new Sach
            {
                TenSach = txtTenS.Text.Trim(),
                MaTheLoai = int.Parse(txtMaTheLoaiS.Text.Trim()),
                MaTacGia = int.Parse(txtMaTacGiaS.Text.Trim()),
                NhaXuatBan = txtNhaXuatBanS.Text.Trim(),
                NamXuatBan = int.Parse(txtNamXuatBanS.Text.Trim()),
                SoLuong = int.Parse(txtSoLuongS.Text.Trim()),
                GiaSach = giaSach,
                GiaThue = giaThue
            };

            if (bus.AddSach(s))
            {
                MessageBox.Show("Thêm sách thành công!");
                dgvSach.DataSource = null;
                dgvSach.DataSource = bus.GetAll();

                // Hiển thị lại giá thuê đã tính
                txtGiaThueS.Text = giaThue.ToString();
                txtGiaThueS.ForeColor = Color.Black;
                txtGiaThueS.Font = new Font(txtGiaThueS.Font, FontStyle.Regular);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnUpdateS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaS.Text)) return;

            double giaSach = double.Parse(txtGiaS.Text.Trim());
            int giaThue;

            if (giaSach > 200000)
                giaThue = 20000;
            else if (giaSach > 100000)
                giaThue = 10000;
            else if (giaSach > 80000)
                giaThue = 5000;
            else
                giaThue = 3000;

            Sach s = new Sach
            {
                MaSach = int.Parse(txtMaS.Text),
                TenSach = txtTenS.Text.Trim(),
                MaTheLoai = int.Parse(txtMaTheLoaiS.Text.Trim()),
                MaTacGia = int.Parse(txtMaTacGiaS.Text.Trim()),
                NhaXuatBan = txtNhaXuatBanS.Text.Trim(),
                NamXuatBan = int.Parse(txtNamXuatBanS.Text.Trim()),
                SoLuong = int.Parse(txtSoLuongS.Text.Trim()),
                GiaSach = giaSach,
                GiaThue = giaThue
            };

            if (bus.UpdateSach(s))
            {
                MessageBox.Show("Cập nhật thành công!");
                dgvSach.DataSource = bus.GetAll();
                txtGiaThueS.Text = giaThue.ToString();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnDeleteS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaS.Text)) return;

            int ma = int.Parse(txtMaS.Text);
            if (bus.DeleteSach(ma))
            {
                MessageBox.Show("Xoá thành công!");
                dgvSach.DataSource = bus.GetAll();
            }
            else
            {
                MessageBox.Show("Xoá thất bại!");
            }
        }

        private void btnExitS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
