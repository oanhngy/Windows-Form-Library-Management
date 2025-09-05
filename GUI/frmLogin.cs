using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;
using QuanLyThuVien.Helpers;

namespace QuanLyThuVien.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "User Name";
            txtUserName.ForeColor = Color.Gray;

            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.UseSystemPasswordChar = false;
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "User Name")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.Text = "User Name";
                txtUserName.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "User Name" || password == "Password")
            {
                MessageBox.Show("Please enter your username and password!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NguoiDungBUS bus = new NguoiDungBUS();
            NguoiDung nd = bus.DangNhap(username, password);

            if (nd != null)
            {
                Session.TenDangNhap = nd.TenDangNhap;
                Session.HoTen = nd.HoTen;
                Session.VaiTro = nd.VaiTro;

                MessageBox.Show($"Role: {nd.VaiTro}", "Login successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                frmMain main = new frmMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
