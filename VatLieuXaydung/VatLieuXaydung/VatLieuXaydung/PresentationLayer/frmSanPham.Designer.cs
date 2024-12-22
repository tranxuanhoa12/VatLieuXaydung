namespace VatLieuXaydung.PresentationLayer
{
    partial class frmSanPham
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFillGrid = new System.Windows.Forms.Button();
            this.tbPageSize = new System.Windows.Forms.TextBox();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.clSanPhamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoaiHangID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDanhMucHangID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHangSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiemGiaoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThongSoKhac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKhuVucID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNguonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonViTinhGiaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoaiTienTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVAT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clThoiDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonViTinhID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radNguonGia = new System.Windows.Forms.RadioButton();
            this.radHangSanXuat = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 29);
            this.label2.TabIndex = 55;
            this.label2.Text = "Quản Lý Sản Phẩm";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(871, 475);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 23);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "&Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFillGrid
            // 
            this.btnFillGrid.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFillGrid.Location = new System.Drawing.Point(554, 475);
            this.btnFillGrid.Name = "btnFillGrid";
            this.btnFillGrid.Size = new System.Drawing.Size(58, 23);
            this.btnFillGrid.TabIndex = 51;
            this.btnFillGrid.Text = "Lọc dữ liệu";
            this.btnFillGrid.UseVisualStyleBackColor = true;
            this.btnFillGrid.Click += new System.EventHandler(this.btnFillGrid_Click);
            // 
            // tbPageSize
            // 
            this.tbPageSize.Location = new System.Drawing.Point(492, 477);
            this.tbPageSize.Name = "tbPageSize";
            this.tbPageSize.Size = new System.Drawing.Size(56, 20);
            this.tbPageSize.TabIndex = 49;
            this.tbPageSize.Text = "10";
            this.tbPageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Location = new System.Drawing.Point(427, 478);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(52, 13);
            this.lblPageSize.TabIndex = 54;
            this.lblPageSize.Text = "&Số Dòng:";
            // 
            // btnLast
            // 
            this.btnLast.Enabled = false;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLast.Location = new System.Drawing.Point(397, 475);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(24, 23);
            this.btnLast.TabIndex = 48;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Enabled = false;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Location = new System.Drawing.Point(276, 478);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 20);
            this.lblStatus.TabIndex = 53;
            this.lblStatus.Text = "0 / 0";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNext.Location = new System.Drawing.Point(367, 475);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(24, 23);
            this.btnNext.TabIndex = 46;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrevious.Location = new System.Drawing.Point(246, 475);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(24, 23);
            this.btnPrevious.TabIndex = 43;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Enabled = false;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFirst.Location = new System.Drawing.Point(216, 475);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(24, 23);
            this.btnFirst.TabIndex = 41;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSanPhamID,
            this.clLoaiHangID,
            this.clTenLoaiHang,
            this.clDanhMucHangID,
            this.clTenHang,
            this.clHangSanXuat,
            this.clModel,
            this.clDiemGiaoHang,
            this.clThongSoKhac,
            this.clKhuVucID,
            this.clTenKhuVuc,
            this.clNguonGia,
            this.clGia,
            this.clDonViTinhGiaID,
            this.clLoaiTienTe,
            this.clVAT,
            this.clThoiDiem,
            this.clDonViTinhID,
            this.clTenDonViTinh,
            this.clGiaID});
            this.dgvSanPham.Location = new System.Drawing.Point(12, 130);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(919, 327);
            this.dgvSanPham.TabIndex = 39;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(790, 475);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 50;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(628, 475);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 44;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(384, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(77, 90);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(301, 20);
            this.txtSearch.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Từ khóa:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(709, 475);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 47;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // clSanPhamID
            // 
            this.clSanPhamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSanPhamID.DataPropertyName = "SanPhamID";
            this.clSanPhamID.HeaderText = "Mã Sản Phẩm";
            this.clSanPhamID.Name = "clSanPhamID";
            this.clSanPhamID.ReadOnly = true;
            this.clSanPhamID.Visible = false;
            // 
            // clLoaiHangID
            // 
            this.clLoaiHangID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clLoaiHangID.DataPropertyName = "LoaiHangID";
            this.clLoaiHangID.HeaderText = "Mã Loại Hàng";
            this.clLoaiHangID.Name = "clLoaiHangID";
            this.clLoaiHangID.ReadOnly = true;
            this.clLoaiHangID.Visible = false;
            // 
            // clTenLoaiHang
            // 
            this.clTenLoaiHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenLoaiHang.DataPropertyName = "TenLoaiHang";
            this.clTenLoaiHang.HeaderText = "Loại Hàng";
            this.clTenLoaiHang.Name = "clTenLoaiHang";
            this.clTenLoaiHang.ReadOnly = true;
            // 
            // clDanhMucHangID
            // 
            this.clDanhMucHangID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDanhMucHangID.DataPropertyName = "DanhMucHangID";
            this.clDanhMucHangID.HeaderText = "Mã DMH";
            this.clDanhMucHangID.Name = "clDanhMucHangID";
            this.clDanhMucHangID.ReadOnly = true;
            this.clDanhMucHangID.Visible = false;
            // 
            // clTenHang
            // 
            this.clTenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenHang.DataPropertyName = "TenHang";
            this.clTenHang.HeaderText = "Tên Hàng";
            this.clTenHang.Name = "clTenHang";
            this.clTenHang.ReadOnly = true;
            // 
            // clHangSanXuat
            // 
            this.clHangSanXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clHangSanXuat.DataPropertyName = "HangSanXuat";
            this.clHangSanXuat.HeaderText = "Hãng Sản Xuất";
            this.clHangSanXuat.Name = "clHangSanXuat";
            this.clHangSanXuat.ReadOnly = true;
            // 
            // clModel
            // 
            this.clModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clModel.DataPropertyName = "Model";
            this.clModel.HeaderText = "Model";
            this.clModel.Name = "clModel";
            this.clModel.ReadOnly = true;
            // 
            // clDiemGiaoHang
            // 
            this.clDiemGiaoHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDiemGiaoHang.DataPropertyName = "DiemGiaoHang";
            this.clDiemGiaoHang.HeaderText = "Điểm Giao Hàng";
            this.clDiemGiaoHang.Name = "clDiemGiaoHang";
            this.clDiemGiaoHang.ReadOnly = true;
            // 
            // clThongSoKhac
            // 
            this.clThongSoKhac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clThongSoKhac.DataPropertyName = "ThongSoKhac";
            this.clThongSoKhac.HeaderText = "Thông Số Khác";
            this.clThongSoKhac.Name = "clThongSoKhac";
            this.clThongSoKhac.ReadOnly = true;
            // 
            // clKhuVucID
            // 
            this.clKhuVucID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clKhuVucID.DataPropertyName = "KhuVucID";
            this.clKhuVucID.HeaderText = "Mã Khu Vực";
            this.clKhuVucID.Name = "clKhuVucID";
            this.clKhuVucID.ReadOnly = true;
            this.clKhuVucID.Visible = false;
            // 
            // clTenKhuVuc
            // 
            this.clTenKhuVuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenKhuVuc.DataPropertyName = "TenKhuVuc";
            this.clTenKhuVuc.HeaderText = "Khu Vực";
            this.clTenKhuVuc.Name = "clTenKhuVuc";
            this.clTenKhuVuc.ReadOnly = true;
            // 
            // clNguonGia
            // 
            this.clNguonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNguonGia.DataPropertyName = "NguonGia";
            this.clNguonGia.HeaderText = "Nguồn Giá";
            this.clNguonGia.Name = "clNguonGia";
            this.clNguonGia.ReadOnly = true;
            // 
            // clGia
            // 
            this.clGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGia.DataPropertyName = "Gia";
            this.clGia.HeaderText = "Giá";
            this.clGia.Name = "clGia";
            this.clGia.ReadOnly = true;
            // 
            // clDonViTinhGiaID
            // 
            this.clDonViTinhGiaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDonViTinhGiaID.DataPropertyName = "DonViTinhGiaID";
            this.clDonViTinhGiaID.HeaderText = "DVTGiaID";
            this.clDonViTinhGiaID.Name = "clDonViTinhGiaID";
            this.clDonViTinhGiaID.ReadOnly = true;
            this.clDonViTinhGiaID.Visible = false;
            // 
            // clLoaiTienTe
            // 
            this.clLoaiTienTe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clLoaiTienTe.DataPropertyName = "LoaiTienTe";
            this.clLoaiTienTe.HeaderText = "Loại Tiền";
            this.clLoaiTienTe.Name = "clLoaiTienTe";
            this.clLoaiTienTe.ReadOnly = true;
            // 
            // clVAT
            // 
            this.clVAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clVAT.DataPropertyName = "VAT";
            this.clVAT.HeaderText = "VAT";
            this.clVAT.Name = "clVAT";
            this.clVAT.ReadOnly = true;
            this.clVAT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clVAT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clThoiDiem
            // 
            this.clThoiDiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clThoiDiem.DataPropertyName = "ThoiDiem";
            this.clThoiDiem.HeaderText = "Thời Điểm";
            this.clThoiDiem.Name = "clThoiDiem";
            this.clThoiDiem.ReadOnly = true;
            // 
            // clDonViTinhID
            // 
            this.clDonViTinhID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDonViTinhID.DataPropertyName = "DonViTinhID";
            this.clDonViTinhID.HeaderText = "Mã ĐVT";
            this.clDonViTinhID.Name = "clDonViTinhID";
            this.clDonViTinhID.ReadOnly = true;
            this.clDonViTinhID.Visible = false;
            // 
            // clTenDonViTinh
            // 
            this.clTenDonViTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenDonViTinh.DataPropertyName = "TenDonViTinh";
            this.clTenDonViTinh.HeaderText = "Đơn Vị Tính";
            this.clTenDonViTinh.Name = "clTenDonViTinh";
            this.clTenDonViTinh.ReadOnly = true;
            // 
            // clGiaID
            // 
            this.clGiaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGiaID.DataPropertyName = "GiaID";
            this.clGiaID.HeaderText = "Giá ID";
            this.clGiaID.Name = "clGiaID";
            this.clGiaID.ReadOnly = true;
            this.clGiaID.Visible = false;
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Location = new System.Drawing.Point(321, 62);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(57, 17);
            this.radAll.TabIndex = 63;
            this.radAll.Text = "Tất Cả";
            this.radAll.UseVisualStyleBackColor = true;
            // 
            // radNguonGia
            // 
            this.radNguonGia.AutoSize = true;
            this.radNguonGia.Location = new System.Drawing.Point(384, 62);
            this.radNguonGia.Name = "radNguonGia";
            this.radNguonGia.Size = new System.Drawing.Size(76, 17);
            this.radNguonGia.TabIndex = 64;
            this.radNguonGia.Text = "Nguồn Giá";
            this.radNguonGia.UseVisualStyleBackColor = true;
            // 
            // radHangSanXuat
            // 
            this.radHangSanXuat.AutoSize = true;
            this.radHangSanXuat.Location = new System.Drawing.Point(466, 62);
            this.radHangSanXuat.Name = "radHangSanXuat";
            this.radHangSanXuat.Size = new System.Drawing.Size(98, 17);
            this.radHangSanXuat.TabIndex = 65;
            this.radHangSanXuat.Text = "Hãng Sản Xuất";
            this.radHangSanXuat.UseVisualStyleBackColor = true;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 513);
            this.Controls.Add(this.radHangSanXuat);
            this.Controls.Add(this.radNguonGia);
            this.Controls.Add(this.radAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFillGrid);
            this.Controls.Add(this.tbPageSize);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFillGrid;
        private System.Windows.Forms.TextBox tbPageSize;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSanPhamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoaiHangID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDanhMucHangID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHangSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiemGiaoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThongSoKhac;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKhuVucID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonViTinhGiaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoaiTienTe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoiDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonViTinhID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaID;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.RadioButton radNguonGia;
        private System.Windows.Forms.RadioButton radHangSanXuat;
    }
}