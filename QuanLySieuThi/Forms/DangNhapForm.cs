using QuanLySieuThi.Repository;
using QuanLySieuThi.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi.Forms
{
    public partial class DangNhapForm : System.Windows.Forms.Form
    {
        private readonly INhanVienService nhanVienService;
        public DangNhapForm()
        {
            InitializeComponent();
            nhanVienService = new NhanVienService(new NhanVienRepository(new Models.QlsieuThiContext()));
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            var nhanVien = nhanVienService.GetById_Pass((txtTK.Text.Trim()), txtMK.Text.Trim());
            if (nhanVien != null)
            {
                if (nhanVien.DaXoa == true)
                {
                    TienIch.UIHelper.ShowMessageWarning("Nhân viên đã bị xóa");
                    return;
                }
                this.Hide();
                new MainForm(nhanVien).ShowDialog();
                txtTK.Clear();
                txtMK.Clear();
                this.Show();
            }
            else
            {
                TienIch.UIHelper.ShowMessageError("Tài khoản hoặc mật khẩu không đúng!");
            }
        }

        private void llDoiMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new DoiMatKhauForm(nhanVienService).ShowDialog();
            txtMK.Clear();
            txtTK.Clear();
            Show();
        }
    }
}
