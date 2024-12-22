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
using System.Text.RegularExpressions;

namespace VatLieuXaydung.PresentationLayer
{
    public partial class frmUpdateSanPham : Form
    {
        Gia g = new Gia();
        SanPham sp = new SanPham();
        DonViTinhBLL dvtBLL = new DonViTinhBLL();
        KhuVucBLL kvBLL = new KhuVucBLL();
        SanPhamBLL spBLL = new SanPhamBLL();
        DanhMucHangBLL dmhBLL = new DanhMucHangBLL();
        LoaiHangBLL lhBLL = new LoaiHangBLL();
        GiaBLL giaBLL = new GiaBLL();
        DVTGiaBLL dvtgBLL = new DVTGiaBLL();
        private decimal id;
        private string tenDMH;
        private string tenLH;
        private string kv;
        private string dvt;
        private string nguongia;
        private decimal giaID;
        private decimal gia;
        private string loaitien;
        private bool VAT;
        DateTime thoidiem;
        public frmUpdateSanPham()
        {
            InitializeComponent();

            cboDMH.DataSource = dmhBLL.LoadDMH();
            cboDMH.DisplayMember = "TenHang";
            cboDMH.ValueMember = "DanhMucHangID";
            cboDMH.SelectedIndex = -1;

            cboKhuVuc.DataSource = kvBLL.LoadKhuVuc();
            cboKhuVuc.DisplayMember = "TenKhuVuc";
            cboKhuVuc.ValueMember = "KhuVucID";
            cboKhuVuc.SelectedIndex = -1;

            cboDVT.DataSource = dvtBLL.LoadDVT();
            cboDVT.DisplayMember = "TenDonViTinh";
            cboDVT.ValueMember = "DonViTinhID";
            cboDVT.SelectedIndex = -1;

            cboLoaiTienTe.DataSource = dvtgBLL.LoadDVTGia();
            cboLoaiTienTe.DisplayMember = "LoaiTienTe";
            cboLoaiTienTe.ValueMember = "DonViTinhGiaID";
            cboLoaiTienTe.SelectedIndex = -1;

            dgvGiaSanPham.Visible = false;            
        }

        public frmUpdateSanPham(decimal id, string dmh, string lh, string kv, decimal giaID, string nguongia, decimal gia, string loaitien, bool VAT, DateTime thoidiem, string dvt)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            dgvGiaSanPham.Visible = false;     
            this.id = id;
            this.tenDMH = dmh;
            this.tenLH = lh;
            this.kv = kv;
            this.dvt = dvt;
            this.giaID = giaID;
            this.nguongia = nguongia;
            this.gia = gia;
            this.loaitien = loaitien;
            this.VAT = VAT;
            this.thoidiem = thoidiem;

            sp = spBLL.GetSanPhamByID(id);
            lblID.Text = id.ToString();
            cboDMH.Text = dmh;
            cboLH.Text = lh;
            cboKhuVuc.Text = kv;
            cboDVT.Text = dvt;
            txtHSX.Text = sp.HangSanXuat;
            txtModel.Text = sp.Model;
            txtDiemGiaoHang.Text = sp.DiemGiaoHang;
            txtThongSo.Text = sp.ThongSoKhac;

            g = giaBLL.GetByID(giaID);
            lblGiaID.Text = giaID.ToString();
            txtNguonGia.Text = nguongia;
            txtGia.Text = gia.ToString();
            cboLoaiTienTe.Text = loaitien;
            chkVAT.Checked = VAT;
            dateTimePickerThoiDiem.Text = thoidiem.ToShortDateString();
        }

        

       

        private void cboDMH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboLH.DataSource = lhBLL.LoadDMH(cboDMH.SelectedValue);
            cboLH.DisplayMember = "TenLoaiHang";
            cboLH.ValueMember = "LoaiHangID";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string giaPattern = "^[0-9]+$";
            Regex regex = new Regex(giaPattern);
            if (cboDMH.SelectedIndex == -1)
            {
                lblMessage.Text = "Bạn chưa chọn Danh Mục Hàng";
            }
            else if (cboKhuVuc.SelectedIndex == -1)
            {
                lblMessage.Text = "Bạn chưa chọn Khu Vực";
            }
            else if (cboDVT.SelectedIndex == -1)
            {
                lblMessage.Text = "Bạn chưa chọn Đơn Vị Tính";
            }
            else if (txtNguonGia.Text == "")
            {
                lblMessage.Text = "Bạn chưa nhập Nguồn Giá";
                txtNguonGia.Focus();
            }
            else if (txtGia.Text == "")
            {
                lblMessage.Text = "Bạn chưa nhập Giá";
                txtGia.Focus();
            }

            else if (!regex.IsMatch(txtGia.Text))
            {
                lblMessage.Text = "Giá không hợp lệ";
                txtGia.Focus();
            }
            else if (cboLoaiTienTe.SelectedIndex == -1)
            {
                lblMessage.Text = "Bạn chưa chọn Loại tiền";
            }
            else
            {
                //Lưu sản phẩm mới
                if (lblID.Text == "" )
                {
                    lblMessage.Text = "";
                    SanPham sp = new SanPham((decimal)cboKhuVuc.SelectedValue, (decimal)cboDVT.SelectedValue, (decimal)cboLH.SelectedValue, txtHSX.Text, txtModel.Text, txtDiemGiaoHang.Text, txtThongSo.Text);
                    bool check = false;
                    if (chkVAT.Checked)
                        check = true;
                    else
                        check = false;
                    decimal gia = decimal.Parse(txtGia.Text);
                    DateTime thoidiem1 = DateTime.Parse(dateTimePickerThoiDiem.Text);
                    Gia g = new Gia(txtNguonGia.Text, gia, thoidiem1, (decimal)cboLoaiTienTe.SelectedValue, check);
                    if (spBLL.Insert(sp, g))
                    {
                        MessageBox.Show("Thêm mới thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvGiaSanPham.Visible = true;
                        dgvGiaSanPham.DataSource = giaBLL.LoadAll();

                    }
                }
                //cập nhật sản phẩm
                else
                {
                    lblMessage.Text = "";
                    bool check = false;
                    if (chkVAT.Checked) check = true;
                    else check = false;
                    SanPham sp = new SanPham(id, (decimal)cboKhuVuc.SelectedValue, (decimal)cboDVT.SelectedValue, (decimal)cboLH.SelectedValue, txtHSX.Text, txtModel.Text, txtDiemGiaoHang.Text, txtThongSo.Text);
                    Gia g = new Gia(decimal.Parse(lblGiaID.Text), txtNguonGia.Text, decimal.Parse(txtGia.Text), DateTime.Parse(dateTimePickerThoiDiem.Text), decimal.Parse(lblID.Text), (decimal)cboLoaiTienTe.SelectedValue, check);
                    spBLL.Update(sp, g);
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvGiaSanPham.Visible = true;
                    dgvGiaSanPham.DataSource = giaBLL.LoadAll();
                }

            }

        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            cboDMH.Text = "";
            cboLH.Text = "";
            cboKhuVuc.Text = "";
            cboDVT.Text = "";
            cboDMH.SelectedIndex = -1;
            cboLH.SelectedIndex = -1;
            cboKhuVuc.SelectedIndex = -1;
            cboDVT.SelectedIndex = -1;
            lblMessage.Text = "";
            txtDiemGiaoHang.Text = "";
            txtHSX.Text = "";
            txtModel.Text = "";
            txtThongSo.Text = "";
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            cboDMH.DataSource = dmhBLL.LoadDMH();
            cboDMH.DisplayMember = "TenHang";
            cboDMH.ValueMember = "DanhMucHangID";
            cboDMH.SelectedIndex = -1;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            cboKhuVuc.DataSource = kvBLL.LoadKhuVuc();
            cboKhuVuc.DisplayMember = "TenKhuVuc";
            cboKhuVuc.ValueMember = "KhuVucID";
            cboKhuVuc.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cboDVT.DataSource = dvtBLL.LoadDVT();
            cboDVT.DisplayMember = "TenDonViTinh";
            cboDVT.ValueMember = "DonViTinhID";
            cboDVT.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cboLoaiTienTe.DataSource = dvtgBLL.LoadDVTGia();
            cboLoaiTienTe.DisplayMember = "LoaiTienTe";
            cboLoaiTienTe.ValueMember = "DonViTinhGiaID";
            cboLoaiTienTe.SelectedIndex = -1;
        }
    }
}
