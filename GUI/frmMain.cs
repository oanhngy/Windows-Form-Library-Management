using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.Helpers;
using QuanLyThuVien.GUI;

namespace QuanLyThuVien.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            //ảnh nền
            pictureBoxWelcome.Visible = true;
            pictureBoxWelcome.BringToFront();
            pictureBoxWelcome.Image = Image.FromFile(Application.StartupPath + @"\library.png");


            if (Session.VaiTro == "ThuThu")
            {
                nguoiDungToolStripMenuItem.Visible = false;
            }
        }

        //HỆ THỐNG
        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //QUẢN LÝ
        private void sachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxWelcome.Visible = false;
            frmQuanLySach f = new frmQuanLySach();
            f.MdiParent = this;
            if (Session.VaiTro == "ThuThu")
            {
                f.btnDeleteS.Visible = false;
            }
            f.Show();
        }

        private void docGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxWelcome.Visible = false;
            frmQuanLyDocGia f = new frmQuanLyDocGia();
            f.MdiParent = this;
            if (Session.VaiTro == "ThuThu")
            {
                f.btnDeleteDG.Visible = false;
            }
            f.Show();
        }

        private void phieuMuonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxWelcome.Visible = false;
            frmQuanlyPhieuMuon f = new frmQuanlyPhieuMuon();
            f.MdiParent = this;

            if (Session.VaiTro == "ThuThu")
            {
                f.btnDeletePM.Visible = false;
                f.btnDeleteCTPM.Visible = false;
            }
            f.Show();
        }

        private void nguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxWelcome.Visible = false;
            frmQuanLyNguoiDung f = new frmQuanLyNguoiDung();
            f.MdiParent = this;
            f.Show();
        }

        //TÌM KIẾM
        private void timSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxWelcome.Visible = false;
            frmTimKiemSach f = new frmTimKiemSach();
            f.MdiParent = this;
            f.Show();
        }

        //BÁO CÁO
        private void xemBaoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxWelcome.Visible = false;
            frmXemBaoCao f = new frmXemBaoCao();
            f.MdiParent = this;
            f.Show();
        }
    }
}
