namespace VatLieuXaydung.PresentationLayer
{
    partial class frmLoaiHang
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
            this.dgvLoaiHang = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDanhMucHang = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.clLoaiHangID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDMHID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDMHID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiHang
            // 
            this.dgvLoaiHang.AllowUserToAddRows = false;
            this.dgvLoaiHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clLoaiHangID,
            this.clTenLoaiHang,
            this.clDMHID,
            this.clDMHID1,
            this.clTenHang});
            this.dgvLoaiHang.Location = new System.Drawing.Point(12, 110);
            this.dgvLoaiHang.Name = "dgvLoaiHang";
            this.dgvLoaiHang.ReadOnly = true;
            this.dgvLoaiHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiHang.Size = new System.Drawing.Size(554, 271);
            this.dgvLoaiHang.TabIndex = 22;
            this.dgvLoaiHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiHang_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(362, 50);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(281, 50);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(200, 50);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(119, 50);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quản Lý Loại Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Chọn Danh Mục:";
            // 
            // cboDanhMucHang
            // 
            this.cboDanhMucHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMucHang.FormattingEnabled = true;
            this.cboDanhMucHang.Location = new System.Drawing.Point(107, 83);
            this.cboDanhMucHang.Name = "cboDanhMucHang";
            this.cboDanhMucHang.Size = new System.Drawing.Size(121, 21);
            this.cboDanhMucHang.TabIndex = 24;
            this.cboDanhMucHang.SelectionChangeCommitted += new System.EventHandler(this.cboDanhMucHang_SelectionChangeCommitted);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(443, 50);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 25;
            this.btnLoad.Text = "Lọc tất cả";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // clLoaiHangID
            // 
            this.clLoaiHangID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clLoaiHangID.DataPropertyName = "LoaiHangID";
            this.clLoaiHangID.HeaderText = "Mã Loại Hàng";
            this.clLoaiHangID.Name = "clLoaiHangID";
            this.clLoaiHangID.ReadOnly = true;
            // 
            // clTenLoaiHang
            // 
            this.clTenLoaiHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenLoaiHang.DataPropertyName = "TenLoaiHang";
            this.clTenLoaiHang.HeaderText = "Loại Hàng";
            this.clTenLoaiHang.Name = "clTenLoaiHang";
            this.clTenLoaiHang.ReadOnly = true;
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
            // clDMHID1
            // 
            this.clDMHID1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDMHID1.DataPropertyName = "DanhMucHangID";
            this.clDMHID1.HeaderText = "DMHID1";
            this.clDMHID1.Name = "clDMHID1";
            this.clDMHID1.ReadOnly = true;
            this.clDMHID1.Visible = false;
            // 
            // clTenHang
            // 
            this.clTenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenHang.DataPropertyName = "TenHang";
            this.clTenHang.HeaderText = "Danh Mục Hàng";
            this.clTenHang.Name = "clTenHang";
            this.clTenHang.ReadOnly = true;
            // 
            // frmLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 392);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cboDanhMucHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLoaiHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Name = "frmLoaiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Hàng";
            this.Load += new System.EventHandler(this.frmLoaiHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiHang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDanhMucHang;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoaiHangID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDMHID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDMHID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenHang;
    }
}