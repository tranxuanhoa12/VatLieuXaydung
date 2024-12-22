using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VatLieuXaydung.PresentationLayer;

namespace VatLieuXaydung
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }
        public frmMain(string user)
        {
            InitializeComponent();
            lblUserName.Text = "Chào: ";
            lblTaiKhoan.Text = user;
        }
      

    

        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void he65ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = new System.Windows.Forms.DialogResult();
            result = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void quảnTrịNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!CheckExistForm("frmQuanTriNguoiDung"))
            //{
            //    frmQuanTriNguoiDung obj = new frmQuanTriNguoiDung();
            //    obj.MdiParent = this;
            //    obj.Show();
            //}
            //else
            //{
            //    ActiveChildForm("frmQuanTriNguoiDung");
            //}

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


        public void EnableQuanTriNguoiDung() { quảnTrịNgườiDùngToolStripMenuItem.Enabled = true; }
        public void DisableQuanTriNguoiDung() { quảnTrịNgườiDùngToolStripMenuItem.Enabled = false; }

        public void EnableQuanLy() { quảnLýDanhMụcToolStripMenuItem.Enabled = true; }
        public void DisableQuanLy() { quảnLýDanhMụcToolStripMenuItem.Enabled = false; }

        public void EnableNhapLieu() { nhậpLiệuToolStripMenuItem.Enabled = true; }
        public void DisableNhapLieu() { nhậpLiệuToolStripMenuItem.Enabled = false; }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void sảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmXemThongTin frm = new frmXemThongTin();
            frm.MdiParent = this;
            frm.Show();
        }

       

       

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmLoaiHang"))
            {
                frmLoaiHang frm = new frmLoaiHang();
                frm.MdiParent = this;
                frm.Show();
            }
            else ActiveChildForm("frmLoaiHang");
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmSanPham"))
            {
                frmSanPham frm = new frmSanPham();
                frm.MdiParent = this;
                frm.Show();
            }
            else ActiveChildForm("frmSanPham");
        }

        private void vậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmSanPham"))
            {
                frmSanPham frm = new frmSanPham();
                frm.MdiParent = this;
                frm.Show();
            }
            else ActiveChildForm("frmSanPham");

        }




    }
}
