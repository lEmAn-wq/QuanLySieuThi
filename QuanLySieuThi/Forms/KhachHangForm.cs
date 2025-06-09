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
    public partial class KhachHangForm : Form
    {
        private readonly IKhachHangService khachHangService;
        KhachHang khachHang;
        public KhachHangForm(string text, IKhachHangService khachHangService, KhachHang khachHang = null)
        {
            InitializeComponent();
            button1.Text = text;
            this.khachHangService = khachHangService;
            if (text == "Sửa")
            {
                if (khachHang == null)
                {
                    TienIch.UIHelper.ShowMessageError("Lỗi: Thông tin khách hàng không tồn tại!");
                    return;
                }
                this.khachHang = khachHang;
                labelTieuDe.Text = "THÔNG TIN KHÁCH HÀNG " + khachHang.MaHienThi;
                txtTenKH.Text = khachHang.TenKh;
                txtSDT.Text = khachHang.Sdt;
                dtpNgaySinh.Value = khachHang.NgaySinh.ToDateTime(TimeOnly.MinValue);
                cboGioiTinh.SelectedItem = khachHang.GioiTinh == "Nam" ? "Nam" : "Nữ";
                txtDiemTichLuy.Text = khachHang.DiemTichLuy.ToString();
                txtNgayDangKyThanhVien.Text = khachHang.NgayDangKy.ToString("dd/MM/yyyy HH:mm:ss");
                btnXoa.Visible = true;
            }
            else if (text == "Thêm")
            {
                labelTieuDe.Text = "THÊM KHÁCH HÀNG MỚI";
                btnXoa.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenKH.Text))
                {
                    TienIch.UIHelper.ShowMessageError("Tên khách hàng không được để trống!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    TienIch.UIHelper.ShowMessageError("Số điện thoại không hợp lệ!");
                    return;
                }
                if (cboGioiTinh.SelectedItem == null)
                {
                    TienIch.UIHelper.ShowMessageError("Vui lòng chọn giới tính!");
                    return;
                }
                if (dtpNgaySinh.Value > DateTime.Now)
                {
                    TienIch.UIHelper.ShowMessageError("Ngày sinh không hợp lệ!");
                    return;
                }
                if (button1.Text == "Thêm")
                {
                    khachHang = new KhachHang();

                    khachHang.TenKh = txtTenKH.Text.Trim();
                    khachHang.Sdt = txtSDT.Text.Trim();
                    khachHang.DiemTichLuy = 0;
                    khachHang.NgayDangKy = DateTime.Now;
                    khachHang.NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value);
                    khachHang.GioiTinh = cboGioiTinh.SelectedItem.ToString();
                    khachHangService.Create(khachHang);
                    TienIch.UIHelper.ShowMessage("Thêm khách hàng thành công!");
                }
                else if (button1.Text == "Sửa")
                {
                    khachHang.TenKh = txtTenKH.Text.Trim();
                    khachHang.Sdt = txtSDT.Text.Trim();
                    khachHang.NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value);
                    khachHang.GioiTinh = cboGioiTinh.SelectedItem.ToString();
                    khachHangService.Update(khachHang);
                    TienIch.UIHelper.ShowMessage("Cập nhật thông tin khách hàng thành công!");
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
                var xacNhan = TienIch.UIHelper.ShowMessageQuestion("Bạn có chắc chắn muốn xóa khách hàng này?");
                if (xacNhan != System.Windows.Forms.DialogResult.Yes)
                    return;
                khachHangService.Delete(khachHang);
                TienIch.UIHelper.ShowMessage("Xóa khách hàng thành công!");
                Close();
            }
            catch (Exception ex)
            {
                TienIch.UIHelper.ShowMessageError("Lỗi: "+ex);
            }
        }
    }
}
