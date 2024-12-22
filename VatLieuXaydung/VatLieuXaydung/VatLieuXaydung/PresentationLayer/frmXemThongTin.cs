using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VatLieuXaydung.BusinessLayer;

namespace VatLieuXaydung.PresentationLayer
{
    public partial class frmXemThongTin : Form
    {
        public frmXemThongTin()
        {
            InitializeComponent();
            LoadSanPham();
        }

        private void LoadSanPham()
        {            
            grvSanPham.DataSource = SanPhamBLL.GetList();
        }
    }
}
