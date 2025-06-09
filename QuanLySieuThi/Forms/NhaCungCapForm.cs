using QuanLySieuThi.Models;
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
    public partial class NhaCungCapForm : Form
    {
        private readonly INhaCungCapService nhaCungCapService;
        NhaCungCap nhaCungCap;
        public NhaCungCapForm(string text, INhaCungCapService nhaCungCapService, NhaCungCap nhaCungCap = null)
        {
            InitializeComponent();
            this.nhaCungCapService = nhaCungCapService;
            button1.Text = text;
            if (text == "Sửa")
            {
                if (nhaCungCap == null)
                {
                    TienIch.UIHelper.ShowMessageError("Nhà cung cấp không tồn tại!");
                    return;
                }
                this.nhaCungCap = nhaCungCap;

                labelTieuDe.Text = "THÔNG TIN NHÀ CUNG CẤP " + this.nhaCungCap.MaHienThi;
                txtTenNCC.Text = this.nhaCungCap.TenNcc;
                txtDiaChi.Text = this.nhaCungCap.DiaChi;
                txtSDT.Text = this.nhaCungCap.Sdt;
                txtEmail.Text = this.nhaCungCap.Email;
                btnXoa.Visible = true; // Show delete button when editing an existing supplier
            }
            else if (text == "Thêm")
            {
                labelTieuDe.Text = "THÊM NHÀ CUNG CẤP MỚI";
                btnXoa.Visible = false; // Hide delete button when adding a new supplier
            }
            else
            {
                TienIch.UIHelper.ShowMessageError("Không xác định được hành động!");
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenNCC.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
             string.IsNullOrWhiteSpace(txtSDT.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    TienIch.UIHelper.ShowMessageError("Vui lòng điền đầy đủ thông tin!");
                    return;
                }
                if (button1.Text == "Thêm")
                {
                    nhaCungCap = new NhaCungCap
                    {
                        TenNcc = txtTenNCC.Text,
                        DiaChi = txtDiaChi.Text,
                        Sdt = txtSDT.Text,
                        Email = txtEmail.Text
                    };
                    nhaCungCapService.Create(nhaCungCap);
                    TienIch.UIHelper.ShowMessage("Thêm nhà cung cấp thành công!");
                }
                else if (button1.Text == "Sửa")
                {
                    nhaCungCap.TenNcc = txtTenNCC.Text;
                    nhaCungCap.DiaChi = txtDiaChi.Text;
                    nhaCungCap.Sdt = txtSDT.Text;
                    nhaCungCap.Email = txtEmail.Text;
                    nhaCungCapService.Update(nhaCungCap);
                    TienIch.UIHelper.ShowMessage("Cập nhật nhà cung cấp thành công!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                TienIch.UIHelper.ShowMessageError("Lỗi: " + ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var xacNhan = TienIch.UIHelper.ShowMessageQuestion("Bạn có chắc chắn muốn xóa nhà cung cấp này?");
                if (xacNhan != System.Windows.Forms.DialogResult.Yes)
                    return;
                nhaCungCapService.Delete(nhaCungCap);
                TienIch.UIHelper.ShowMessage("Xóa nhà cung cấp thành công!");
                Close();
            }
            catch (Exception ex)
            {
                TienIch.UIHelper.ShowMessageError("Lỗi: " + ex);
            }
        }
    }
}
