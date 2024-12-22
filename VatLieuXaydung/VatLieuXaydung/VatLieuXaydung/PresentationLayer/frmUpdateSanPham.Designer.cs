namespace VatLieuXaydung.PresentationLayer
{
    partial class frmUpdateSanPham
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboDMH = new System.Windows.Forms.ComboBox();
            this.cboLH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDVT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.txtHSX = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiemGiaoHang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtThongSo = new System.Windows.Forms.RichTextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNguonGia = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboLoaiTienTe = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chkVAT = new System.Windows.Forms.CheckBox();
            this.dateTimePickerThoiDiem = new System.Windows.Forms.DateTimePicker();
            this.dgvGiaSanPham = new System.Windows.Forms.DataGridView();
            this.clGiaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDMHID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLHID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNguonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDVTGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoaiTienTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVAT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clThoiDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGiaID = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Thông Tin Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Danh Mục Hàng:";
            // 
            // cboDMH
            // 
            this.cboDMH.FormattingEnabled = true;
            this.cboDMH.Location = new System.Drawing.Point(136, 56);
            this.cboDMH.Name = "cboDMH";
            this.cboDMH.Size = new System.Drawing.Size(121, 21);
            this.cboDMH.TabIndex = 39;
            this.cboDMH.SelectionChangeCommitted += new System.EventHandler(this.cboDMH_SelectionChangeCommitted);
            // 
            // cboLH
            // 
            this.cboLH.FormattingEnabled = true;
            this.cboLH.Location = new System.Drawing.Point(136, 101);
            this.cboLH.Name = "cboLH";
            this.cboLH.Size = new System.Drawing.Size(121, 21);
            this.cboLH.TabIndex = 41;
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Loại Hàng:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(764, 59);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 42;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(926, 59);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 43;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Location = new System.Drawing.Point(136, 146);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(121, 21);
            this.cboKhuVuc.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Khu Vực:";
            // 
            // cboDVT
            // 
            this.cboDVT.FormattingEnabled = true;
            this.cboDVT.Location = new System.Drawing.Point(136, 195);
            this.cboDVT.Name = "cboDVT";
            this.cboDVT.Size = new System.Drawing.Size(121, 21);
            this.cboDVT.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Đơn Vị Tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Hãng Sản Xuất:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(845, 59);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 49;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // txtHSX
            // 
            this.txtHSX.Location = new System.Drawing.Point(136, 236);
            this.txtHSX.Name = "txtHSX";
            this.txtHSX.Size = new System.Drawing.Size(202, 20);
            this.txtHSX.TabIndex = 50;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(136, 282);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(202, 20);
            this.txtModel.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Model:";
            // 
            // txtDiemGiaoHang
            // 
            this.txtDiemGiaoHang.Location = new System.Drawing.Point(136, 327);
            this.txtDiemGiaoHang.Name = "txtDiemGiaoHang";
            this.txtDiemGiaoHang.Size = new System.Drawing.Size(202, 20);
            this.txtDiemGiaoHang.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Điểm Giao Hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Thông Số Khác:";
            // 
            // txtThongSo
            // 
            this.txtThongSo.Location = new System.Drawing.Point(136, 378);
            this.txtThongSo.Name = "txtThongSo";
            this.txtThongSo.Size = new System.Drawing.Size(202, 96);
            this.txtThongSo.TabIndex = 56;
            this.txtThongSo.Text = "";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(761, 94);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 57;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(41, 426);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 58;
            this.lblID.Visible = false;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(263, 56);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 23);
            this.btnLoc.TabIndex = 59;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 61;
            this.button2.Text = "Lọc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 62;
            this.button3.Text = "Lọc";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(406, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 63;
            this.label10.Text = "Nguồn Giá:";
            // 
            // txtNguonGia
            // 
            this.txtNguonGia.Location = new System.Drawing.Point(488, 56);
            this.txtNguonGia.Name = "txtNguonGia";
            this.txtNguonGia.Size = new System.Drawing.Size(202, 20);
            this.txtNguonGia.TabIndex = 64;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(488, 105);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(202, 20);
            this.txtGia.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(406, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Giá:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(406, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "Thời Điểm:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(406, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 69;
            this.label13.Text = "Loại Tiền Tệ:";
            // 
            // cboLoaiTienTe
            // 
            this.cboLoaiTienTe.FormattingEnabled = true;
            this.cboLoaiTienTe.Location = new System.Drawing.Point(488, 195);
            this.cboLoaiTienTe.Name = "cboLoaiTienTe";
            this.cboLoaiTienTe.Size = new System.Drawing.Size(121, 21);
            this.cboLoaiTienTe.TabIndex = 70;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(406, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 71;
            this.label14.Text = "VAT:";
            // 
            // chkVAT
            // 
            this.chkVAT.AutoSize = true;
            this.chkVAT.Location = new System.Drawing.Point(488, 246);
            this.chkVAT.Name = "chkVAT";
            this.chkVAT.Size = new System.Drawing.Size(15, 14);
            this.chkVAT.TabIndex = 72;
            this.chkVAT.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerThoiDiem
            // 
            this.dateTimePickerThoiDiem.CustomFormat = "\"dd mm yyyy\"";
            this.dateTimePickerThoiDiem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerThoiDiem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerThoiDiem.Location = new System.Drawing.Point(488, 146);
            this.dateTimePickerThoiDiem.Name = "dateTimePickerThoiDiem";
            this.dateTimePickerThoiDiem.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerThoiDiem.TabIndex = 20;
            // 
            // dgvGiaSanPham
            // 
            this.dgvGiaSanPham.AllowUserToAddRows = false;
            this.dgvGiaSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clGiaID,
            this.clSPID,
            this.clDMHID,
            this.clTenHang,
            this.clLHID,
            this.clTenLH,
            this.clNguonGia,
            this.clGia,
            this.clDVTGID,
            this.clLoaiTienTe,
            this.clVAT,
            this.clThoiDiem});
            this.dgvGiaSanPham.Location = new System.Drawing.Point(409, 294);
            this.dgvGiaSanPham.Name = "dgvGiaSanPham";
            this.dgvGiaSanPham.ReadOnly = true;
            this.dgvGiaSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaSanPham.Size = new System.Drawing.Size(735, 192);
            this.dgvGiaSanPham.TabIndex = 73;
            // 
            // clGiaID
            // 
            this.clGiaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGiaID.DataPropertyName = "GiaID";
            this.clGiaID.HeaderText = "Mã Giá";
            this.clGiaID.Name = "clGiaID";
            this.clGiaID.ReadOnly = true;
            this.clGiaID.Visible = false;
            // 
            // clSPID
            // 
            this.clSPID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSPID.DataPropertyName = "SanPhamID";
            this.clSPID.HeaderText = "SPID";
            this.clSPID.Name = "clSPID";
            this.clSPID.ReadOnly = true;
            this.clSPID.Visible = false;
            // 
            // clDMHID
            // 
            this.clDMHID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDMHID.DataPropertyName = "DanhMucHangID";
            this.clDMHID.HeaderText = "DMHID";
            this.clDMHID.Name = "clDMHID";
            this.clDMHID.ReadOnly = true;
            this.clDMHID.Visible = false;
            // 
            // clTenHang
            // 
            this.clTenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenHang.DataPropertyName = "TenHang";
            this.clTenHang.HeaderText = "Tên Hàng";
            this.clTenHang.Name = "clTenHang";
            this.clTenHang.ReadOnly = true;
            // 
            // clLHID
            // 
            this.clLHID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clLHID.DataPropertyName = "LoaiHangID";
            this.clLHID.HeaderText = "LHID";
            this.clLHID.Name = "clLHID";
            this.clLHID.ReadOnly = true;
            this.clLHID.Visible = false;
            // 
            // clTenLH
            // 
            this.clTenLH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenLH.DataPropertyName = "TenLoaiHang";
            this.clTenLH.HeaderText = "Loại Hàng";
            this.clTenLH.Name = "clTenLH";
            this.clTenLH.ReadOnly = true;
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
            // clDVTGID
            // 
            this.clDVTGID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDVTGID.DataPropertyName = "DonViTinhGiaID";
            this.clDVTGID.HeaderText = "DVTGID";
            this.clDVTGID.Name = "clDVTGID";
            this.clDVTGID.ReadOnly = true;
            this.clDVTGID.Visible = false;
            // 
            // clLoaiTienTe
            // 
            this.clLoaiTienTe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clLoaiTienTe.DataPropertyName = "LoaiTienTe";
            this.clLoaiTienTe.HeaderText = "Loại Tiền Tệ";
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
            // lblGiaID
            // 
            this.lblGiaID.AutoSize = true;
            this.lblGiaID.Location = new System.Drawing.Point(755, 178);
            this.lblGiaID.Name = "lblGiaID";
            this.lblGiaID.Size = new System.Drawing.Size(0, 13);
            this.lblGiaID.TabIndex = 74;
            this.lblGiaID.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(615, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 75;
            this.button4.Text = "Lọc";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmUpdateSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 498);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblGiaID);
            this.Controls.Add(this.dgvGiaSanPham);
            this.Controls.Add(this.dateTimePickerThoiDiem);
            this.Controls.Add(this.chkVAT);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cboLoaiTienTe);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNguonGia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtThongSo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDiemGiaoHang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHSX);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboDVT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboKhuVuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cboLH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản Phẩm";
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDMH;
        private System.Windows.Forms.ComboBox cboLH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboDVT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.TextBox txtHSX;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiemGiaoHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtThongSo;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNguonGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboLoaiTienTe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkVAT;
        private System.Windows.Forms.DateTimePicker dateTimePickerThoiDiem;
        private System.Windows.Forms.DataGridView dgvGiaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDMHID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLHID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDVTGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoaiTienTe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoiDiem;
        private System.Windows.Forms.Label lblGiaID;
        private System.Windows.Forms.Button button4;
    }
}