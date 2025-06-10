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
    public partial class DoiMatKhauForm : System.Windows.Forms.Form
    {
        private readonly INhanVienService nhanVienService;
        public DoiMatKhauForm(INhanVienService nhanVienService)
        {
            InitializeComponent();
            this.nhanVienService = nhanVienService;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
           var nhanVien = nhanVienService.GetById_Pass(txtTK.Text.Trim(), txtMK.Text.Trim());
            if (nhanVien != null)
            {
                if (txtNewMK.Text != txtNhapLaiMK.Text)
                {
                    TienIch.UIHelper.ShowMessageWarning("Mật khẩu mới và xác nhận mật khẩu không khớp!");
                    return;
                }
                nhanVien.MatKhau = txtNewMK.Text;
                nhanVienService.Update(nhanVien);
                TienIch.UIHelper.ShowMessage("Đổi mật khẩu thành công!");
                this.Close();
            }
            else
            {
                TienIch.UIHelper.ShowMessageError("Mã nhân viên hoặc mật khẩu cũ không đúng!");
            }
        }
    }
}
