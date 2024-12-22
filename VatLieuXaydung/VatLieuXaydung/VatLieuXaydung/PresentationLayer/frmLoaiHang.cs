using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VatLieuXaydung.DataLayer;
using System.Data.SqlClient;
using VatLieuXaydung.BusinessLayer;
using VatLieuXaydung.Entities;

namespace VatLieuXaydung.PresentationLayer
{
    public partial class frmLoaiHang : Form
    {
        LoaiHangBLL bll = new LoaiHangBLL();

        public frmLoaiHang()
        {
            InitializeComponent();
            this.fillCombobox();
            this.fillGrid();
        }

        private void fillCombobox()
        {
            
            cboDanhMucHang.DataSource = DanhMucHangBLL.GetList();
            cboDanhMucHang.DisplayMember = "TenHang";
            cboDanhMucHang.ValueMember = "DanhMucHangID";
            cboDanhMucHang.SelectedIndex = -1;
        }
        private void fillGrid()
        {
            dgvLoaiHang.DataSource = bll.LoadAll();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmUpdateLoaiHang frm = new frmUpdateLoaiHang();
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmUpdateLoaiHang frm = new frmUpdateLoaiHang((decimal)dgvLoaiHang.SelectedRows[0].Cells[0].Value, (string)dgvLoaiHang.SelectedRows[0].Cells[4].Value);
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            decimal id = (decimal)dgvLoaiHang.SelectedRows[0].Cells[0].Value;
            string name = (string)dgvLoaiHang.SelectedRows[0].Cells[1].Value;
            if (MessageBox.Show("Bạn có muốn xóa: " + name + " không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoaiHang lh = bll.GetByID(id);
                if (bll.Delete(lh))
                {
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.fillGrid();
                }
            }
        }

        private void cboDanhMucHang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Hiển thị danh sách Loại Hàng tương ứng
            object value = cboDanhMucHang.SelectedValue;

            //dgvLoaiHang.DataSource = LoaiHangBLL.GetLoaiHangByDMH(value);
            dgvLoaiHang.DataSource = bll.LoadDMH(value);

            // 
            //string sql = "select LoaiHangID,TenLoaiHang from tblLoaiHang where DanhMucHangID =" + cboDanhMucHang.SelectedValue + "";
            //DataAccessHelper db = new DataAccessHelper();
            //SqlConnection con = db.GetConnection();
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandText = sql;
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "tblLoaiHang");
            //this.dgvLoaiHang.DataSource = ds.Tables["tblLoaiHang"].DefaultView;
            //cmd.Dispose();
            //da.Dispose();
            //ds.Dispose();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.fillGrid();
        }

        private void frmLoaiHang_Load(object sender, EventArgs e)
        {

        }

        private void dgvLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
