namespace QuanLyThuVien.GUI
{
    partial class frmQuanLySach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLySach));
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
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.btnDeleteS = new System.Windows.Forms.Button();
            this.btnUpdateS = new System.Windows.Forms.Button();
            this.btnExitS = new System.Windows.Forms.Button();
            this.btnAddS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiaThueS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaTacGiaS = new System.Windows.Forms.TextBox();
            this.txtMaTheLoaiS = new System.Windows.Forms.TextBox();
            this.txtTenS = new System.Windows.Forms.TextBox();
            this.txtMaS = new System.Windows.Forms.TextBox();
            this.txtGiaS = new System.Windows.Forms.TextBox();
            this.txtSoLuongS = new System.Windows.Forms.TextBox();
            this.txtNamXuatBanS = new System.Windows.Forms.TextBox();
            this.txtNhaXuatBanS = new System.Windows.Forms.TextBox();
            this.label111 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelsl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(0, 26);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.Size = new System.Drawing.Size(964, 250);
            this.dgvSach.TabIndex = 2;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellContentClick);
            this.dgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellContentClick);
            // 
            // btnDeleteS
            // 
            this.btnDeleteS.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btnDeleteS.Location = new System.Drawing.Point(771, 381);
            this.btnDeleteS.Name = "btnDeleteS";
            this.btnDeleteS.Size = new System.Drawing.Size(80, 30);
            this.btnDeleteS.TabIndex = 11;
            this.btnDeleteS.Text = "Delete";
            this.btnDeleteS.UseVisualStyleBackColor = true;
            this.btnDeleteS.Click += new System.EventHandler(this.btnDeleteS_Click);
            // 
            // btnUpdateS
            // 
            this.btnUpdateS.Location = new System.Drawing.Point(771, 343);
            this.btnUpdateS.Name = "btnUpdateS";
            this.btnUpdateS.Size = new System.Drawing.Size(80, 30);
            this.btnUpdateS.TabIndex = 10;
            this.btnUpdateS.Text = "Update";
            this.btnUpdateS.UseVisualStyleBackColor = true;
            this.btnUpdateS.Click += new System.EventHandler(this.btnUpdateS_Click);
            // 
            // btnExitS
            // 
            this.btnExitS.BackColor = System.Drawing.Color.IndianRed;
            this.btnExitS.Location = new System.Drawing.Point(771, 418);
            this.btnExitS.Name = "btnExitS";
            this.btnExitS.Size = new System.Drawing.Size(80, 30);
            this.btnExitS.TabIndex = 9;
            this.btnExitS.Text = "Exit";
            this.btnExitS.UseVisualStyleBackColor = false;
            this.btnExitS.Click += new System.EventHandler(this.btnExitS_Click);
            // 
            // btnAddS
            // 
            this.btnAddS.Location = new System.Drawing.Point(771, 305);
            this.btnAddS.Name = "btnAddS";
            this.btnAddS.Size = new System.Drawing.Size(80, 30);
            this.btnAddS.TabIndex = 8;
            this.btnAddS.Text = "Add";
            this.btnAddS.UseVisualStyleBackColor = true;
            this.btnAddS.Click += new System.EventHandler(this.btnAddS_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGiaThueS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaTacGiaS);
            this.groupBox1.Controls.Add(this.txtMaTheLoaiS);
            this.groupBox1.Controls.Add(this.txtTenS);
            this.groupBox1.Controls.Add(this.txtMaS);
            this.groupBox1.Controls.Add(this.txtGiaS);
            this.groupBox1.Controls.Add(this.txtSoLuongS);
            this.groupBox1.Controls.Add(this.txtNamXuatBanS);
            this.groupBox1.Controls.Add(this.txtNhaXuatBanS);
            this.groupBox1.Controls.Add(this.label111);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelsl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(113, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 156);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN SÁCH";
            // 
            // txtGiaThueS
            // 
            this.txtGiaThueS.Location = new System.Drawing.Point(394, 126);
            this.txtGiaThueS.Name = "txtGiaThueS";
            this.txtGiaThueS.Size = new System.Drawing.Size(180, 20);
            this.txtGiaThueS.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Giá Thuê Sách";
            // 
            // txtMaTacGiaS
            // 
            this.txtMaTacGiaS.Location = new System.Drawing.Point(84, 126);
            this.txtMaTacGiaS.Name = "txtMaTacGiaS";
            this.txtMaTacGiaS.Size = new System.Drawing.Size(180, 20);
            this.txtMaTacGiaS.TabIndex = 20;
            // 
            // txtMaTheLoaiS
            // 
            this.txtMaTheLoaiS.Location = new System.Drawing.Point(84, 98);
            this.txtMaTheLoaiS.Name = "txtMaTheLoaiS";
            this.txtMaTheLoaiS.Size = new System.Drawing.Size(180, 20);
            this.txtMaTheLoaiS.TabIndex = 19;
            // 
            // txtTenS
            // 
            this.txtTenS.Location = new System.Drawing.Point(84, 71);
            this.txtTenS.Name = "txtTenS";
            this.txtTenS.Size = new System.Drawing.Size(180, 20);
            this.txtTenS.TabIndex = 18;
            // 
            // txtMaS
            // 
            this.txtMaS.Location = new System.Drawing.Point(84, 42);
            this.txtMaS.Name = "txtMaS";
            this.txtMaS.Size = new System.Drawing.Size(180, 20);
            this.txtMaS.TabIndex = 17;
            // 
            // txtGiaS
            // 
            this.txtGiaS.Location = new System.Drawing.Point(394, 99);
            this.txtGiaS.Name = "txtGiaS";
            this.txtGiaS.Size = new System.Drawing.Size(180, 20);
            this.txtGiaS.TabIndex = 16;
            // 
            // txtSoLuongS
            // 
            this.txtSoLuongS.Location = new System.Drawing.Point(394, 71);
            this.txtSoLuongS.Name = "txtSoLuongS";
            this.txtSoLuongS.Size = new System.Drawing.Size(180, 20);
            this.txtSoLuongS.TabIndex = 15;
            // 
            // txtNamXuatBanS
            // 
            this.txtNamXuatBanS.Location = new System.Drawing.Point(394, 44);
            this.txtNamXuatBanS.Name = "txtNamXuatBanS";
            this.txtNamXuatBanS.Size = new System.Drawing.Size(180, 20);
            this.txtNamXuatBanS.TabIndex = 14;
            // 
            // txtNhaXuatBanS
            // 
            this.txtNhaXuatBanS.Location = new System.Drawing.Point(394, 15);
            this.txtNhaXuatBanS.Name = "txtNhaXuatBanS";
            this.txtNhaXuatBanS.Size = new System.Drawing.Size(180, 20);
            this.txtNhaXuatBanS.TabIndex = 13;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(313, 102);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(51, 13);
            this.label111.TabIndex = 7;
            this.label111.Text = "Giá Sách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Mã Tác Giả";
            // 
            // labelsl
            // 
            this.labelsl.AutoSize = true;
            this.labelsl.Location = new System.Drawing.Point(313, 73);
            this.labelsl.Name = "labelsl";
            this.labelsl.Size = new System.Drawing.Size(53, 13);
            this.labelsl.TabIndex = 5;
            this.labelsl.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Năm Xuất Bản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nhà Xuất Bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Thể Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách";
            // 
            // frmQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 481);
            this.Controls.Add(this.btnDeleteS);
            this.Controls.Add(this.btnUpdateS);
            this.Controls.Add(this.btnExitS);
            this.Controls.Add(this.btnAddS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dgvSach);
            this.Name = "frmQuanLySach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLySach";
            this.Load += new System.EventHandler(this.frmQuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvSach;
        public System.Windows.Forms.Button btnDeleteS;
        private System.Windows.Forms.Button btnUpdateS;
        private System.Windows.Forms.Button btnExitS;
        private System.Windows.Forms.Button btnAddS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaTacGiaS;
        private System.Windows.Forms.TextBox txtMaTheLoaiS;
        private System.Windows.Forms.TextBox txtTenS;
        private System.Windows.Forms.TextBox txtMaS;
        private System.Windows.Forms.TextBox txtGiaS;
        private System.Windows.Forms.TextBox txtSoLuongS;
        private System.Windows.Forms.TextBox txtNamXuatBanS;
        private System.Windows.Forms.TextBox txtNhaXuatBanS;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelsl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaThueS;
        private System.Windows.Forms.Label label4;
    }
}