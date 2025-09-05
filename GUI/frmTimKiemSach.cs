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
    public partial class frmTimKiemSach : Form
    {
        private SachBUS bus = new SachBUS();
        private TacGiaBUS tacGiaBus = new TacGiaBUS();
        private TheLoaiBUS theLoaiBus = new TheLoaiBUS();
        public frmTimKiemSach()
        {
            InitializeComponent();
        }

        private void frmTimKiemSach_Load(object sender, EventArgs e)
        {
            var sachList = bus.GetAll();
            var tacGiaList = tacGiaBus.GetAll();
            var theLoaiList = theLoaiBus.GetAll();

            foreach (var sach in sachList)
            {
                var tacGia = tacGiaList.FirstOrDefault(t => t.MaTacGia == sach.MaTacGia);
                var theLoai = theLoaiList.FirstOrDefault(t => t.MaTheLoai == sach.MaTheLoai);

                sach.TenTacGia = tacGia?.TenTacGia ?? "Không rõ";
                sach.TenTheLoai = theLoai?.TenTheLoai ?? "Không rõ";
            }

            dgvTimSach.DataSource = sachList;

            var nhaXuatBanList = sachList.Select(s => s.NhaXuatBan).Distinct().ToList();
            nhaXuatBanList.Insert(0, "Tất cả");
            cboTimNhaXuatBanS.DataSource = nhaXuatBanList;

            var theLoaiCboList = theLoaiList.ToList();
            theLoaiCboList.Insert(0, new TheLoai { MaTheLoai = 0, TenTheLoai = "Tất cả" });

            cboTimTheLoaiS.DataSource = theLoaiCboList;
            cboTimTheLoaiS.DisplayMember = "TenTheLoai";
            cboTimTheLoaiS.ValueMember = "MaTheLoai";

            //column
            dgvTimSach.Columns["MaSach"].Visible = false;
            dgvTimSach.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvTimSach.Columns["TenSach"].Width = 250;
            dgvTimSach.Columns["MaTheLoai"].Visible = false;
            dgvTimSach.Columns["MaTacGia"].Visible = false;
            dgvTimSach.Columns["NamXuatBan"].HeaderText = "Năm Xuất Bản";
            dgvTimSach.Columns["NhaXuatBan"].HeaderText = "Nhà Xuất Bản";
            dgvTimSach.Columns["SoLuong"].Visible = false;
            dgvTimSach.Columns["GiaSach"].HeaderText = "Giá Sách";
            dgvTimSach.Columns["GiaThue"].HeaderText = "Giá Thuê";
            dgvTimSach.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
            dgvTimSach.Columns["TenTacGia"].Width = 150;
            dgvTimSach.Columns["TenTheLoai"].HeaderText = "Tên Thể loại";
        }

        private void btnSearchTimS_Click(object sender, EventArgs e)
        {
            string tenSach = txtTimTenS.Text.Trim();
            string tacGia = txtTimTacGiaS.Text.Trim();
            string nhaXuatBan = cboTimNhaXuatBanS.SelectedItem as string;
            int? maTheLoai = cboTimTheLoaiS.SelectedValue as int?;

            if (nhaXuatBan == "Tất cả") nhaXuatBan = null;
            if (maTheLoai == 0) maTheLoai = null;

            var result = bus.SearchSach(tenSach, tacGia, nhaXuatBan, maTheLoai);
            var tacGiaList = tacGiaBus.GetAll();
            var theLoaiList = theLoaiBus.GetAll();

            foreach (var sach in result)
            {
                sach.TenTacGia = tacGiaList.FirstOrDefault(t => t.MaTacGia == sach.MaTacGia)?.TenTacGia ?? "Không rõ";
                sach.TenTheLoai = theLoaiList.FirstOrDefault(t => t.MaTheLoai == sach.MaTheLoai)?.TenTheLoai ?? "Không rõ";
            }

            if (result.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sách theo tiêu chí tìm kiếm.");
                return;
            }

            dgvTimSach.DataSource = result;
            dgvTimSach.AutoGenerateColumns = false;   
        }

        private void btnExitTimS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
