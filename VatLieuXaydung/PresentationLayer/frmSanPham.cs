using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VatLieuXaydung.BusinessLayer;
using VatLieuXaydung.Entities;

namespace VatLieuXaydung.PresentationLayer
{
    public partial class frmSanPham : Form
    {
        LoaiHangBLL lhBLL = new LoaiHangBLL();
        DanhMucHangBLL dmhBLL = new DanhMucHangBLL();
        SanPhamBLL spBLL = new SanPhamBLL();
        // Page
        private int mintTotalRecords = 0;
        private int mintPageSize = 0;
        private int mintPageCount = 0;
        private int mintCurrentPage = 1;
        public frmSanPham()
        {
            InitializeComponent();



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            this.fillGrid();
            this.btnFillGrid.Enabled = true;
            this.btnFirst.Enabled = true;
            this.btnPrevious.Enabled = true;
            this.lblStatus.Enabled = true;
            this.btnNext.Enabled = true;
            this.btnLast.Enabled = true;
        }

        private void fillGrid()
        {
            try
            {
                //For page view           
                this.mintPageSize = int.Parse(tbPageSize.Text);
                this.mintTotalRecords = spBLL.Getcount();
                this.mintPageCount = this.mintTotalRecords / this.mintPageSize;

                if (this.mintTotalRecords % this.mintPageSize > 0)
                {
                    this.mintPageCount++;
                }
                this.mintCurrentPage = 0;
                loadPage();
            }
            catch (Exception)
            {

                MessageBox.Show("Số dòng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadPage()
        {

            int intSkip = 0;
            intSkip = (this.mintCurrentPage * this.mintPageSize);

            dgvSanPham.DataSource = spBLL.Paging(mintPageSize, intSkip);

            this.lblStatus.Text = (this.mintCurrentPage + 1).ToString() + " / " + this.mintPageCount.ToString();

        }

        private void btnFillGrid_Click(object sender, EventArgs e)
        {
            this.fillGrid();
            this.btnFillGrid.Enabled = true;
            this.btnFirst.Enabled = true;
            this.btnPrevious.Enabled = true;
            this.lblStatus.Enabled = true;
            this.btnNext.Enabled = true;
            this.btnLast.Enabled = true;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.mintCurrentPage = 0;

            loadPage();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (this.mintCurrentPage == this.mintPageCount)
                this.mintCurrentPage = this.mintPageCount - 1;

            this.mintCurrentPage--;
            if (this.mintCurrentPage < 1)
            {
                this.mintCurrentPage = 0;
            }
            loadPage();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.mintCurrentPage++;
            if (this.mintCurrentPage > this.mintPageCount - 1)
            {
                this.mintCurrentPage = this.mintPageCount - 1;
            }
            loadPage();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.mintCurrentPage = this.mintPageCount - 1;

            loadPage();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmUpdateSanPham frm = new frmUpdateSanPham();
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            decimal spID = (decimal)dgvSanPham.SelectedRows[0].Cells["clSanPhamID"].Value;
            string tenDMH = (string)dgvSanPham.SelectedRows[0].Cells["clTenHang"].Value;
            string tenLH = (string)dgvSanPham.SelectedRows[0].Cells["clTenLoaiHang"].Value;
            string kv = (string)dgvSanPham.SelectedRows[0].Cells["clTenKhuVuc"].Value;
            string dvt = (string)dgvSanPham.SelectedRows[0].Cells["clTenDonViTinh"].Value;

            decimal giaID = (decimal)dgvSanPham.SelectedRows[0].Cells["clGiaID"].Value;
            string nguongia = (string)dgvSanPham.SelectedRows[0].Cells["clNguonGia"].Value;
            decimal gia = (decimal)dgvSanPham.SelectedRows[0].Cells["clGia"].Value;
            string loaitien = (string)dgvSanPham.SelectedRows[0].Cells["clLoaiTienTe"].Value;
            bool VAT = (bool)dgvSanPham.SelectedRows[0].Cells["clVAT"].Value;
            DateTime thoidiem = (DateTime)dgvSanPham.SelectedRows[0].Cells["clThoiDiem"].Value;
            frmUpdateSanPham frm = new frmUpdateSanPham(spID, tenDMH, tenLH, kv, giaID, nguongia, gia, loaitien, VAT, thoidiem, dvt);
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            decimal spID = (decimal)dgvSanPham.SelectedRows[0].Cells[0].Value;
            string tenDMH = (string)dgvSanPham.SelectedRows[0].Cells[4].Value;
            string tenLH = (string)dgvSanPham.SelectedRows[0].Cells[2].Value;
            if (MessageBox.Show("Bạn có muốn xóa: " + tenDMH + " " + tenLH + " không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SanPham sp = spBLL.GetSanPhamByID(spID);
                if (spBLL.Delete(sp))
                {
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.fillGrid();
                }
            }
        }

        private void cboDMH_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //dgvSanPham.DataSource = spBLL.LoadSanPhamByLoaiHang(txtSearch.Text);
            if (radNguonGia.Checked == true)
            {
                dgvSanPham.DataSource = spBLL.GetByNguonGia(txtSearch.Text);
            }
            else if (radHangSanXuat.Checked == true)
            {
                dgvSanPham.DataSource = spBLL.GetByHangSanXuat(txtSearch.Text);
            }
            else if (radAll.Checked == true)
            {
               // dgvSanPham.DataSource = spBLL.GetAll(txtSearch.Text);
            }
        }
    }
}
