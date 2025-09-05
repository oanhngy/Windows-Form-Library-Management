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
    public partial class frmQuanlyPhieuMuon : Form
    {
        private PhieuMuonBUS bus = new PhieuMuonBUS();
        private ChiTietPhieuMuonBUS ctpmBus = new ChiTietPhieuMuonBUS();
        public frmQuanlyPhieuMuon()
        {
            InitializeComponent();
        }

        private void frmQuanlyPhieuMuon_Load(object sender, EventArgs e)
        {
            //PhieuMuon
            dgvPhieuMuon.DataSource = bus.GetAll();

            txtMaPM.Text = "Hệ thống tự động điền";
            txtMaPM.ReadOnly = true;
            txtMaPM.ForeColor = Color.LightGray;
            txtMaPM.Font = new Font(txtMaPM.Font, FontStyle.Italic);

            txtTongGiaPM.Text = "Hệ thống tự cập nhật";
            txtTongGiaPM.ReadOnly = true;
            txtTongGiaPM.ForeColor = Color.LightGray;
            txtTongGiaPM.Font = new Font(txtTongGiaPM.Font, FontStyle.Italic);

            //columnPhieuMuon
            dgvPhieuMuon.Columns["MaPhieuMuon"].HeaderText = "MÃ PHIẾU MƯỢN";
            dgvPhieuMuon.Columns["MaPhieuMuon"].Width = 50;
            dgvPhieuMuon.Columns["MaDocGia"].HeaderText = "MÃ ĐỘC GIẢ";
            dgvPhieuMuon.Columns["MaDocGia"].Width = 50;
            dgvPhieuMuon.Columns["NgayMuon"].HeaderText = "NGÀY MƯỢN";
            dgvPhieuMuon.Columns["NgayTra"].HeaderText = "NGÀY TRẢ";
            dgvPhieuMuon.Columns["TrangThai"].HeaderText = "TRẠNG THÁI";
            dgvPhieuMuon.Columns["TongGia"].HeaderText = "TỔNG GIÁ";
            dgvPhieuMuon.Columns["TongGia"].Width = 50;

            //CT_PhieuMuon
            txtMaCTPM.Text = "Hệ thống tự động điền";
            txtMaCTPM.ReadOnly = true;
            txtMaCTPM.ForeColor = Color.LightGray;
            txtMaCTPM.Font = new Font(txtMaCTPM.Font, FontStyle.Italic);

            txtGiaCTPM.Text = "Hệ thống tự cập nhật";
            txtGiaCTPM.ReadOnly = true;
            txtGiaCTPM.ForeColor = Color.LightGray;
            txtGiaCTPM.Font = new Font(txtGiaCTPM.Font, FontStyle.Italic);
        }

        private void dgvPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPhieuMuon.Rows[e.RowIndex].Cells["MaPhieuMuon"].Value != null)
            {
                DataGridViewRow row = dgvPhieuMuon.Rows[e.RowIndex];

                txtMaPM.Text = row.Cells["MaPhieuMuon"].Value.ToString();
                txtMaPM.ReadOnly = true;
                txtMaPM.ForeColor = Color.Black;
                txtMaPM.Font = new Font(txtMaPM.Font, FontStyle.Regular);

                txtMaDocGiaPM.Text = row.Cells["MaDocGia"].Value.ToString();
                dtpNgayMuonPM.Value = Convert.ToDateTime(row.Cells["NgayMuon"].Value);
                dtpNgayTraPM.Value = Convert.ToDateTime(row.Cells["NgayTra"].Value);
                txtTrangThaiPM.Text = row.Cells["TrangThai"].Value.ToString();

                int maPhieuMuon = Convert.ToInt32(row.Cells["MaPhieuMuon"].Value);
                var ctpmList = ctpmBus.GetByPhieuMuon(maPhieuMuon);
                dgvCTPhieuMuon.DataSource = ctpmList;

                if (row.Cells["TongGia"].Value != DBNull.Value && row.Cells["TongGia"].Value != null)
                {
                    txtTongGiaPM.Text = row.Cells["TongGia"].Value.ToString();
                }
                else
                {
                    txtTongGiaPM.Text = "0";
                }

                var ctpm = ctpmList[0];
                txtMaCTPM.Text = ctpm.MaPhieuMuon.ToString();
                txtMaSachCTPM.Text = ctpm.MaSach.ToString();
                txtSoLuongCTPM.Text = ctpm.SoLuong.ToString();
                txtSoNgayThueCTPM.Text = ctpm.SoNgayThue.ToString();
                txtGiaCTPM.Text = ctpm.Gia.ToString();

                //column CT_PhieuMuon
                dgvCTPhieuMuon.Columns["MaPhieuMuon"].HeaderText = "MÃ PHIẾU MƯỢN";
                dgvCTPhieuMuon.Columns["MaPhieuMuon"].Width = 70;
                dgvCTPhieuMuon.Columns["MaSach"].HeaderText = "MÃ SÁCH";
                dgvCTPhieuMuon.Columns["MaSach"].Width = 70;
                dgvCTPhieuMuon.Columns["SoLuong"].HeaderText = "SỐ LƯỢNG";
                dgvCTPhieuMuon.Columns["SoLuong"].Width = 70;
                dgvCTPhieuMuon.Columns["SoNgayThue"].HeaderText = "SỐ NGÀY THUÊ";
                dgvCTPhieuMuon.Columns["SoNgayThue"].Width = 70;
                dgvCTPhieuMuon.Columns["Gia"].HeaderText = "GIÁ";
            }
        }

        private void btnAddPM_Click(object sender, EventArgs e)
        {
            PhieuMuon pm = new PhieuMuon
            {
                MaDocGia = int.Parse(txtMaDocGiaPM.Text.Trim()),
                NgayMuon = dtpNgayMuonPM.Value,
                NgayTra = dtpNgayTraPM.Value,
                TrangThai = txtTrangThaiPM.Text.Trim()
            };
            pm.TongGia = 0;

            if (bus.AddPhieuMuon(pm))
            {
                MessageBox.Show("Thêm phiếu mượn thành công!");
                dgvPhieuMuon.DataSource = bus.GetAll();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnUpdatePM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPM.Text)) return;

            PhieuMuon pm = new PhieuMuon
            {
                MaPhieuMuon = int.Parse(txtMaPM.Text),
                MaDocGia = int.Parse(txtMaDocGiaPM.Text.Trim()),
                NgayMuon = dtpNgayMuonPM.Value,
                NgayTra = dtpNgayTraPM.Value,
                TrangThai = txtTrangThaiPM.Text.Trim()
            };
            pm.TongGia = Convert.ToInt32(txtTongGiaPM.Text);

            if (bus.UpdatePhieuMuon(pm))
            {
                MessageBox.Show("Cập nhật thành công!");
                dgvPhieuMuon.DataSource = bus.GetAll();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnDeletePM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPM.Text)) return;

            int ma = int.Parse(txtMaPM.Text);
            if (bus.DeletePhieuMuon(ma))
            {
                MessageBox.Show("Xoá thành công!");
                dgvPhieuMuon.DataSource = bus.GetAll();
            }
            else
            {
                MessageBox.Show("Xoá thất bại!");
            }
        }

        private void btnExitPM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTongGiaPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Tổng Giá không được chỉnh sửa. Hệ thống tự động cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.Handled = true;
        }

        //chi tiết phiếu mượn
        private void dgvCTPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCTPhieuMuon.Rows[e.RowIndex].Cells["MaPhieuMuon"].Value != null)
            {
                DataGridViewRow row = dgvCTPhieuMuon.Rows[e.RowIndex];

                txtMaCTPM.Text = row.Cells["MaPhieuMuon"].Value.ToString();
                txtMaSachCTPM.Text = row.Cells["MaSach"].Value.ToString();
                txtSoLuongCTPM.Text = row.Cells["SoLuong"].Value.ToString();
                txtSoNgayThueCTPM.Text = row.Cells["SoNgayThue"].Value.ToString();
                txtGiaCTPM.Text = row.Cells["Gia"].Value.ToString();
            }
        }

        private void btnAddCTPM_Click(object sender, EventArgs e)
        {
            ChiTietPhieuMuon ctpm = new ChiTietPhieuMuon
            {
                MaPhieuMuon = int.Parse(txtMaPM.Text),
                MaSach = int.Parse(txtMaSachCTPM.Text),
                SoLuong = int.Parse(txtSoLuongCTPM.Text),
                SoNgayThue = int.Parse(txtSoNgayThueCTPM.Text),
                Gia = int.Parse(txtGiaCTPM.Text)
            };

            if (ctpmBus.AddCTPM(ctpm))
            {
                MessageBox.Show("Thêm chi tiết phiếu mượn thành công!");
                dgvCTPhieuMuon.DataSource = null;
                dgvCTPhieuMuon.DataSource = ctpmBus.GetByPhieuMuon(ctpm.MaPhieuMuon);
                dgvPhieuMuon.DataSource = bus.GetAll();
            }
            else
            {
                MessageBox.Show("Thêm chi tiết thất bại!");
            }
        }

        private void btnUpdateCTPM_Click(object sender, EventArgs e)
        {
            ChiTietPhieuMuon ctpm = new ChiTietPhieuMuon
            {
                MaPhieuMuon = int.Parse(txtMaPM.Text),
                MaSach = int.Parse(txtMaSachCTPM.Text),
                SoLuong = int.Parse(txtSoLuongCTPM.Text),
                SoNgayThue = int.Parse(txtSoNgayThueCTPM.Text),
                Gia = int.Parse(txtGiaCTPM.Text)
            };

            if (ctpmBus.UpdateCTPM(ctpm))
            {
                MessageBox.Show("Cập nhật chi tiết phiếu mượn thành công!");
                dgvCTPhieuMuon.DataSource = null;
                dgvCTPhieuMuon.DataSource = ctpmBus.GetByPhieuMuon(ctpm.MaPhieuMuon);
                dgvPhieuMuon.DataSource = bus.GetAll();
            }
            else
            {
                MessageBox.Show("Cập nhật chi tiết thất bại!");
            }
        }

        private void btnDeleteCTPM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCTPM.Text) || string.IsNullOrWhiteSpace(txtMaSachCTPM.Text))
            {
                MessageBox.Show("Vui lòng chọn một chi tiết phiếu mượn để xoá.");
                return;
            }

            int maPM = int.Parse(txtMaCTPM.Text);
            int maSach = int.Parse(txtMaSachCTPM.Text);

            if (ctpmBus.DeleteCTPM(maPM, maSach))
            {
                MessageBox.Show("Xoá chi tiết phiếu mượn thành công!");
                dgvCTPhieuMuon.DataSource = null;
                dgvCTPhieuMuon.DataSource = ctpmBus.GetByPhieuMuon(maPM);
                dgvPhieuMuon.DataSource = bus.GetAll();
            }
            else
            {
                MessageBox.Show("Xoá chi tiết thất bại!");
            }
        }
    }
}
