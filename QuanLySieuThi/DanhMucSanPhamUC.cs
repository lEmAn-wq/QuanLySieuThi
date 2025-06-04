using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungYte;

namespace QuanLySieuThi
{
    public partial class DanhMucSanPhamUC : UserControl
    {
        public DanhMucSanPhamUC()
        {
            InitializeComponent();
        }

        private void cboDanhMucSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboDanhMucSanPham.SelectedIndex==0)
            {
                MainForm.labelTieuDe.Text = "Quản lý loại sản phẩm";
                UIHelper.LoadUserControlToPanel(panel1, new LoaiSanPhamUC());
            }
            else if (cboDanhMucSanPham.SelectedIndex == 1)
            {
                MainForm.labelTieuDe.Text = "Quản lý thương hiệu";
                UIHelper.LoadUserControlToPanel(panel1, new ThuongHieuUC());
            }
            else if (cboDanhMucSanPham.SelectedIndex == 2)
            {
                MainForm.labelTieuDe.Text = "Quản lý ngành hàng";
                UIHelper.LoadUserControlToPanel(panel1, new NganhHangUC());
            }
            else if (cboDanhMucSanPham.SelectedIndex == 3)
            {
                MainForm.labelTieuDe.Text = "Quản lý ưu đãi";
                UIHelper.LoadUserControlToPanel(panel1, new UuDaiUC());
            }
        }
    }
}
