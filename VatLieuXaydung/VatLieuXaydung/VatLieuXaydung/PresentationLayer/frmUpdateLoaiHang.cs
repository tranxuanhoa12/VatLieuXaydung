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
    public partial class frmUpdateLoaiHang : Form
    {
        LoaiHang lh;
        DanhMucHangBLL bllDMH = new DanhMucHangBLL();
        LoaiHangBLL bllLoaiHang = new LoaiHangBLL();
        private decimal p;
        private string dmhID;
        public frmUpdateLoaiHang()
        {
            InitializeComponent();

            cboDanhMucHang.DataSource = bllDMH.LoadDMH();
            cboDanhMucHang.DisplayMember = "TenHang";
            cboDanhMucHang.ValueMember = "DanhMucHangID";


        }

        public frmUpdateLoaiHang(decimal p, string dmhID)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.p = p;
            this.dmhID = dmhID;
            lh = bllLoaiHang.GetByID(p);
            lblLoaiHangID.Text = p.ToString();
            txtTenLoaiHang.Text = lh.Ten;
            cboDanhMucHang.Text = dmhID;


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiHang.Text == "")
            {
                lblMessage.Text = "Bạn phải nhập vào Loại hàng";
                txtTenLoaiHang.Focus();
            }
            else
            {
                if (lblLoaiHangID.Text == "")
                {
                    try
                    {
                        LoaiHang lh = new LoaiHang(txtTenLoaiHang.Text, (decimal)cboDanhMucHang.SelectedValue);
                        if (bllLoaiHang.Insert(lh))
                        {
                            MessageBox.Show("Thêm mới thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Danh Mục Hàng không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {


                    try
                    {

                        LoaiHang lh = new LoaiHang(p, txtTenLoaiHang.Text, (decimal)cboDanhMucHang.SelectedValue);
                        if (bllLoaiHang.Update(lh))
                        {
                            MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Bạn hãy Làm mới Danh Mục Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboDanhMucHang.DataSource = bllDMH.LoadDMH();
            cboDanhMucHang.DisplayMember = "TenHang";
            cboDanhMucHang.ValueMember = "DanhMucHangID";
        }

        private void frmUpdateLoaiHang_Load(object sender, EventArgs e)
        {

        }
    }
}
