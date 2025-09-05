namespace QuanLyThuVien.GUI
{
    partial class frmQuanlyPhieuMuon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanlyPhieuMuon));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.btnDeletePM = new System.Windows.Forms.Button();
            this.btnUpdatePM = new System.Windows.Forms.Button();
            this.btnExitPM = new System.Windows.Forms.Button();
            this.btnAddPM = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTongGiaPM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrangThaiPM = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.dtpNgayTraPM = new System.Windows.Forms.DateTimePicker();
            this.txtMaDocGiaPM = new System.Windows.Forms.TextBox();
            this.dtpNgayMuonPM = new System.Windows.Forms.DateTimePicker();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCTPhieuMuon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGiaCTPM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoNgayThueCTPM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuongCTPM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSachCTPM = new System.Windows.Forms.TextBox();
            this.txtMaCTPM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDeleteCTPM = new System.Windows.Forms.Button();
            this.btnUpdateCTPM = new System.Windows.Forms.Button();
            this.btnAddCTPM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuMuon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(964, 25);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(0, 26);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.Size = new System.Drawing.Size(524, 200);
            this.dgvPhieuMuon.TabIndex = 2;
            this.dgvPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellContentClick);
            this.dgvPhieuMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellContentClick);
            // 
            // btnDeletePM
            // 
            this.btnDeletePM.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btnDeletePM.Location = new System.Drawing.Point(332, 341);
            this.btnDeletePM.Name = "btnDeletePM";
            this.btnDeletePM.Size = new System.Drawing.Size(80, 30);
            this.btnDeletePM.TabIndex = 11;
            this.btnDeletePM.Text = "Delete";
            this.btnDeletePM.UseVisualStyleBackColor = true;
            this.btnDeletePM.Click += new System.EventHandler(this.btnDeletePM_Click);
            // 
            // btnUpdatePM
            // 
            this.btnUpdatePM.Location = new System.Drawing.Point(332, 303);
            this.btnUpdatePM.Name = "btnUpdatePM";
            this.btnUpdatePM.Size = new System.Drawing.Size(80, 30);
            this.btnUpdatePM.TabIndex = 10;
            this.btnUpdatePM.Text = "Update";
            this.btnUpdatePM.UseVisualStyleBackColor = true;
            this.btnUpdatePM.Click += new System.EventHandler(this.btnUpdatePM_Click);
            // 
            // btnExitPM
            // 
            this.btnExitPM.BackColor = System.Drawing.Color.IndianRed;
            this.btnExitPM.Location = new System.Drawing.Point(875, 439);
            this.btnExitPM.Name = "btnExitPM";
            this.btnExitPM.Size = new System.Drawing.Size(80, 30);
            this.btnExitPM.TabIndex = 9;
            this.btnExitPM.Text = "Exit";
            this.btnExitPM.UseVisualStyleBackColor = false;
            this.btnExitPM.Click += new System.EventHandler(this.btnExitPM_Click);
            // 
            // btnAddPM
            // 
            this.btnAddPM.Location = new System.Drawing.Point(332, 265);
            this.btnAddPM.Name = "btnAddPM";
            this.btnAddPM.Size = new System.Drawing.Size(80, 30);
            this.btnAddPM.TabIndex = 8;
            this.btnAddPM.Text = "Add";
            this.btnAddPM.UseVisualStyleBackColor = true;
            this.btnAddPM.Click += new System.EventHandler(this.btnAddPM_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTongGiaPM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTrangThaiPM);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.dtpNgayTraPM);
            this.groupBox1.Controls.Add(this.txtMaDocGiaPM);
            this.groupBox1.Controls.Add(this.dtpNgayMuonPM);
            this.groupBox1.Controls.Add(this.txtMaPM);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 215);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN PHIẾU MƯỢN";
            // 
            // txtTongGiaPM
            // 
            this.txtTongGiaPM.Location = new System.Drawing.Point(92, 182);
            this.txtTongGiaPM.Name = "txtTongGiaPM";
            this.txtTongGiaPM.Size = new System.Drawing.Size(180, 20);
            this.txtTongGiaPM.TabIndex = 20;
            this.txtTongGiaPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTongGiaPM_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tổng Giá";
            // 
            // txtTrangThaiPM
            // 
            this.txtTrangThaiPM.Location = new System.Drawing.Point(92, 87);
            this.txtTrangThaiPM.Name = "txtTrangThaiPM";
            this.txtTrangThaiPM.Size = new System.Drawing.Size(180, 20);
            this.txtTrangThaiPM.TabIndex = 18;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(10, 90);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 13);
            this.label.TabIndex = 17;
            this.label.Text = "Trạng Thái";
            // 
            // dtpNgayTraPM
            // 
            this.dtpNgayTraPM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTraPM.Location = new System.Drawing.Point(92, 152);
            this.dtpNgayTraPM.Name = "dtpNgayTraPM";
            this.dtpNgayTraPM.Size = new System.Drawing.Size(180, 20);
            this.dtpNgayTraPM.TabIndex = 16;
            // 
            // txtMaDocGiaPM
            // 
            this.txtMaDocGiaPM.Location = new System.Drawing.Point(92, 57);
            this.txtMaDocGiaPM.Name = "txtMaDocGiaPM";
            this.txtMaDocGiaPM.Size = new System.Drawing.Size(180, 20);
            this.txtMaDocGiaPM.TabIndex = 13;
            // 
            // dtpNgayMuonPM
            // 
            this.dtpNgayMuonPM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuonPM.Location = new System.Drawing.Point(92, 120);
            this.dtpNgayMuonPM.Name = "dtpNgayMuonPM";
            this.dtpNgayMuonPM.Size = new System.Drawing.Size(180, 20);
            this.dtpNgayMuonPM.TabIndex = 12;
            // 
            // txtMaPM
            // 
            this.txtMaPM.Location = new System.Drawing.Point(92, 28);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(180, 20);
            this.txtMaPM.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngày Trả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã Độc Giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Mượn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu Mượn";
            // 
            // dgvCTPhieuMuon
            // 
            this.dgvCTPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPhieuMuon.Location = new System.Drawing.Point(540, 26);
            this.dgvCTPhieuMuon.Name = "dgvCTPhieuMuon";
            this.dgvCTPhieuMuon.Size = new System.Drawing.Size(424, 200);
            this.dgvCTPhieuMuon.TabIndex = 12;
            this.dgvCTPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPhieuMuon_CellContentClick);
            this.dgvCTPhieuMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPhieuMuon_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGiaCTPM);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSoNgayThueCTPM);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSoLuongCTPM);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMaSachCTPM);
            this.groupBox2.Controls.Add(this.txtMaCTPM);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(540, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 215);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN CHI TIẾT PHIẾU MƯỢN";
            // 
            // txtGiaCTPM
            // 
            this.txtGiaCTPM.Location = new System.Drawing.Point(92, 145);
            this.txtGiaCTPM.Name = "txtGiaCTPM";
            this.txtGiaCTPM.Size = new System.Drawing.Size(180, 20);
            this.txtGiaCTPM.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Giá";
            // 
            // txtSoNgayThueCTPM
            // 
            this.txtSoNgayThueCTPM.Location = new System.Drawing.Point(92, 116);
            this.txtSoNgayThueCTPM.Name = "txtSoNgayThueCTPM";
            this.txtSoNgayThueCTPM.Size = new System.Drawing.Size(180, 20);
            this.txtSoNgayThueCTPM.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số Ngày Thuê";
            // 
            // txtSoLuongCTPM
            // 
            this.txtSoLuongCTPM.Location = new System.Drawing.Point(92, 87);
            this.txtSoLuongCTPM.Name = "txtSoLuongCTPM";
            this.txtSoLuongCTPM.Size = new System.Drawing.Size(180, 20);
            this.txtSoLuongCTPM.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Số Lượng";
            // 
            // txtMaSachCTPM
            // 
            this.txtMaSachCTPM.Location = new System.Drawing.Point(92, 57);
            this.txtMaSachCTPM.Name = "txtMaSachCTPM";
            this.txtMaSachCTPM.Size = new System.Drawing.Size(180, 20);
            this.txtMaSachCTPM.TabIndex = 13;
            // 
            // txtMaCTPM
            // 
            this.txtMaCTPM.Location = new System.Drawing.Point(92, 28);
            this.txtMaCTPM.Name = "txtMaCTPM";
            this.txtMaCTPM.Size = new System.Drawing.Size(180, 20);
            this.txtMaCTPM.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mã Sách";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã Phiếu Mượn";
            // 
            // btnDeleteCTPM
            // 
            this.btnDeleteCTPM.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btnDeleteCTPM.Location = new System.Drawing.Point(875, 341);
            this.btnDeleteCTPM.Name = "btnDeleteCTPM";
            this.btnDeleteCTPM.Size = new System.Drawing.Size(80, 30);
            this.btnDeleteCTPM.TabIndex = 25;
            this.btnDeleteCTPM.Text = "Delete";
            this.btnDeleteCTPM.UseVisualStyleBackColor = true;
            this.btnDeleteCTPM.Click += new System.EventHandler(this.btnDeleteCTPM_Click);
            // 
            // btnUpdateCTPM
            // 
            this.btnUpdateCTPM.Location = new System.Drawing.Point(875, 303);
            this.btnUpdateCTPM.Name = "btnUpdateCTPM";
            this.btnUpdateCTPM.Size = new System.Drawing.Size(80, 30);
            this.btnUpdateCTPM.TabIndex = 24;
            this.btnUpdateCTPM.Text = "Update";
            this.btnUpdateCTPM.UseVisualStyleBackColor = true;
            this.btnUpdateCTPM.Click += new System.EventHandler(this.btnUpdateCTPM_Click);
            // 
            // btnAddCTPM
            // 
            this.btnAddCTPM.Location = new System.Drawing.Point(875, 265);
            this.btnAddCTPM.Name = "btnAddCTPM";
            this.btnAddCTPM.Size = new System.Drawing.Size(80, 30);
            this.btnAddCTPM.TabIndex = 22;
            this.btnAddCTPM.Text = "Add";
            this.btnAddCTPM.UseVisualStyleBackColor = true;
            this.btnAddCTPM.Click += new System.EventHandler(this.btnAddCTPM_Click);
            // 
            // frmQuanlyPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 481);
            this.Controls.Add(this.btnDeleteCTPM);
            this.Controls.Add(this.btnUpdateCTPM);
            this.Controls.Add(this.btnAddCTPM);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvCTPhieuMuon);
            this.Controls.Add(this.btnDeletePM);
            this.Controls.Add(this.btnUpdatePM);
            this.Controls.Add(this.btnExitPM);
            this.Controls.Add(this.btnAddPM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dgvPhieuMuon);
            this.Name = "frmQuanlyPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhieuMuon";
            this.Load += new System.EventHandler(this.frmQuanlyPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuMuon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        public System.Windows.Forms.Button btnDeletePM;
        private System.Windows.Forms.Button btnUpdatePM;
        private System.Windows.Forms.Button btnExitPM;
        private System.Windows.Forms.Button btnAddPM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayTraPM;
        private System.Windows.Forms.TextBox txtMaDocGiaPM;
        private System.Windows.Forms.DateTimePicker dtpNgayMuonPM;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrangThaiPM;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtTongGiaPM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCTPhieuMuon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSoLuongCTPM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSachCTPM;
        private System.Windows.Forms.TextBox txtMaCTPM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button btnDeleteCTPM;
        private System.Windows.Forms.Button btnUpdateCTPM;
        private System.Windows.Forms.Button btnAddCTPM;
        private System.Windows.Forms.TextBox txtGiaCTPM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoNgayThueCTPM;
        private System.Windows.Forms.Label label4;
    }
}