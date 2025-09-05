namespace QuanLyThuVien.GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hêThôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docGiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phieuMuonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguoiDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timKiêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sachToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemBaoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxWelcome = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hêThôngToolStripMenuItem,
            this.quanLyToolStripMenuItem,
            this.timKiêmToolStripMenuItem,
            this.baoCaoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hêThôngToolStripMenuItem
            // 
            this.hêThôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangXuatToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.hêThôngToolStripMenuItem.Name = "hêThôngToolStripMenuItem";
            this.hêThôngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hêThôngToolStripMenuItem.Text = "Hệ thống";
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.dangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sachToolStripMenuItem,
            this.docGiaToolStripMenuItem,
            this.phieuMuonToolStripMenuItem,
            this.nguoiDungToolStripMenuItem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quanLyToolStripMenuItem.Text = "Quản lý";
            // 
            // sachToolStripMenuItem
            // 
            this.sachToolStripMenuItem.Name = "sachToolStripMenuItem";
            this.sachToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sachToolStripMenuItem.Text = "Sách";
            this.sachToolStripMenuItem.Click += new System.EventHandler(this.sachToolStripMenuItem_Click);
            // 
            // docGiaToolStripMenuItem
            // 
            this.docGiaToolStripMenuItem.Name = "docGiaToolStripMenuItem";
            this.docGiaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.docGiaToolStripMenuItem.Text = "Độc giả";
            this.docGiaToolStripMenuItem.Click += new System.EventHandler(this.docGiaToolStripMenuItem_Click);
            // 
            // phieuMuonToolStripMenuItem
            // 
            this.phieuMuonToolStripMenuItem.Name = "phieuMuonToolStripMenuItem";
            this.phieuMuonToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.phieuMuonToolStripMenuItem.Text = "Phiếu mượn";
            this.phieuMuonToolStripMenuItem.Click += new System.EventHandler(this.phieuMuonToolStripMenuItem_Click);
            // 
            // nguoiDungToolStripMenuItem
            // 
            this.nguoiDungToolStripMenuItem.Name = "nguoiDungToolStripMenuItem";
            this.nguoiDungToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.nguoiDungToolStripMenuItem.Text = "Người dùng";
            this.nguoiDungToolStripMenuItem.Click += new System.EventHandler(this.nguoiDungToolStripMenuItem_Click);
            // 
            // timKiêmToolStripMenuItem
            // 
            this.timKiêmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sachToolStripMenuItem1});
            this.timKiêmToolStripMenuItem.Name = "timKiêmToolStripMenuItem";
            this.timKiêmToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.timKiêmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // sachToolStripMenuItem1
            // 
            this.sachToolStripMenuItem1.Name = "sachToolStripMenuItem1";
            this.sachToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.sachToolStripMenuItem1.Text = "Sách";
            this.sachToolStripMenuItem1.Click += new System.EventHandler(this.timSachToolStripMenuItem_Click);
            // 
            // baoCaoToolStripMenuItem
            // 
            this.baoCaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemBaoCaoToolStripMenuItem});
            this.baoCaoToolStripMenuItem.Name = "baoCaoToolStripMenuItem";
            this.baoCaoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.baoCaoToolStripMenuItem.Text = "Báo cáo";
            // 
            // xemBaoCaoToolStripMenuItem
            // 
            this.xemBaoCaoToolStripMenuItem.Name = "xemBaoCaoToolStripMenuItem";
            this.xemBaoCaoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.xemBaoCaoToolStripMenuItem.Text = "Xem báo cáo";
            this.xemBaoCaoToolStripMenuItem.Click += new System.EventHandler(this.xemBaoCaoToolStripMenuItem_Click);
            // 
            // pictureBoxWelcome
            // 
            this.pictureBoxWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxWelcome.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxWelcome.Name = "pictureBoxWelcome";
            this.pictureBoxWelcome.Size = new System.Drawing.Size(984, 537);
            this.pictureBoxWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWelcome.TabIndex = 1;
            this.pictureBoxWelcome.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pictureBoxWelcome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hêThôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timKiêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docGiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phieuMuonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sachToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xemBaoCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguoiDungToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxWelcome;
    }
}