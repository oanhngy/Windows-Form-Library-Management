namespace QuanLyThuVien.GUI
{
    partial class frmXemBaoCao
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.cboReport = new System.Windows.Forms.ComboBox();
            this.reportViewerDoanhThu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerLuotMuon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerSoLuongSach = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn tháng";
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(493, 12);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(121, 46);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Hiển thị Báo Cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cboReport
            // 
            this.cboReport.FormattingEnabled = true;
            this.cboReport.Location = new System.Drawing.Point(353, 37);
            this.cboReport.Name = "cboReport";
            this.cboReport.Size = new System.Drawing.Size(121, 21);
            this.cboReport.TabIndex = 3;
            // 
            // reportViewerDoanhThu
            // 
            this.reportViewerDoanhThu.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.Report.ReportTheoThang.rdlc";
            this.reportViewerDoanhThu.Location = new System.Drawing.Point(10, 73);
            this.reportViewerDoanhThu.Name = "reportViewerDoanhThu";
            this.reportViewerDoanhThu.ServerReport.BearerToken = null;
            this.reportViewerDoanhThu.Size = new System.Drawing.Size(281, 408);
            this.reportViewerDoanhThu.TabIndex = 4;
            // 
            // reportViewerLuotMuon
            // 
            this.reportViewerLuotMuon.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.Report.ReportLuotMuon.rdlc";
            this.reportViewerLuotMuon.Location = new System.Drawing.Point(297, 73);
            this.reportViewerLuotMuon.Name = "reportViewerLuotMuon";
            this.reportViewerLuotMuon.ServerReport.BearerToken = null;
            this.reportViewerLuotMuon.Size = new System.Drawing.Size(264, 408);
            this.reportViewerLuotMuon.TabIndex = 5;
            // 
            // reportViewerSoLuongSach
            // 
            this.reportViewerSoLuongSach.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.Report.ReportSoLuongSach.rdlc";
            this.reportViewerSoLuongSach.Location = new System.Drawing.Point(567, 73);
            this.reportViewerSoLuongSach.Name = "reportViewerSoLuongSach";
            this.reportViewerSoLuongSach.ServerReport.BearerToken = null;
            this.reportViewerSoLuongSach.Size = new System.Drawing.Size(384, 408);
            this.reportViewerSoLuongSach.TabIndex = 6;
            // 
            // frmXemBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 481);
            this.Controls.Add(this.reportViewerSoLuongSach);
            this.Controls.Add(this.reportViewerLuotMuon);
            this.Controls.Add(this.reportViewerDoanhThu);
            this.Controls.Add(this.cboReport);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label1);
            this.Name = "frmXemBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXemBaoCao";
            this.Load += new System.EventHandler(this.frmXemBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ComboBox cboReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDoanhThu;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerLuotMuon;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSoLuongSach;
    }
}