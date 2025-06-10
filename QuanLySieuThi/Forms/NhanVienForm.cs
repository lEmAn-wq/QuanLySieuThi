using QuanLySieuThi.Models;
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
    public partial class NhanVienForm : Form
    {
        private readonly Service.INhanVienService nhanVienService;
        private readonly Service.IChucVuService chucVuService = new ChucVuService(new ChucVuRepository(new Models.QlsieuThiContext()));
        NhanVien nhanVien;
        public NhanVienForm(string text, INhanVienService nhanVienService, NhanVien nhanVien = null)
        {
            InitializeComponent();
            this.nhanVienService = nhanVienService;
            button1.Text = text;
            cboChucVu.DataSource = chucVuService.GetAll();
            cboChucVu.DisplayMember = "TenCv";
            cboChucVu.ValueMember = "MaCv";

            if (text == "Sửa")
            {
                if (nhanVien == null)
                {
                    TienIch.UIHelper.ShowMessageError("Không tìm thấy nhân viên để xem");
                    return;
                }
                this.nhanVien = nhanVien;
                labelTieuDe.Text = "THÔNG TIN NHÂN VIÊN " + this.nhanVien.MaHienThi;
                txtCMND.Text = this.nhanVien.Cccd;
                txtSDT.Text = this.nhanVien.Sdt;
                txtTen.Text = this.nhanVien.TenNv;
                dtpNgaySinh.Value = this.nhanVien.NgaySinh.ToDateTime(TimeOnly.MinValue);
                cboGioiTinh.SelectedItem = this.nhanVien.GioiTinh == "Nam" ? "Nam" : "Nữ";
                cboChucVu.SelectedValue = this.nhanVien.MaCv;
                btnResetMK.Visible = true;
                btnXoa.Visible = true;
            }
            else if (text == "Thêm")
            {
                labelTieuDe.Text = "THÊM NHÂN VIÊN";
                btnResetMK.Visible = false;
                btnXoa.Visible = false;
            }
            else
            {
                TienIch.UIHelper.ShowMessageError("Không xác định được hành động");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtCMND.Text))
            {
                TienIch.UIHelper.ShowMessageError("Vui lòng điền đầy đủ thông tin");
                return;
            }
            if (cboGioiTinh.SelectedItem == null)
            {
                TienIch.UIHelper.ShowMessageError("Vui lòng chọn giới tính");
                return;
            }
            if (cboChucVu.SelectedValue == null)
            {
                TienIch.UIHelper.ShowMessageError("Vui lòng chọn chức vụ");
                return;
            }
            if (dtpNgaySinh.Value.Date >= DateTime.Now.Date)
            {
                TienIch.UIHelper.ShowMessageError("Ngày sinh không hợp lệ, vui lòng chọn lại");
                return;
            }
            if (button1.Text == "Thêm")
            {
                nhanVien = new NhanVien
                {
                    TenNv = txtTen.Text,
                    Sdt = txtSDT.Text,
                    Cccd = txtCMND.Text,
                    NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value),
                    GioiTinh = cboGioiTinh.SelectedItem.ToString(),
                    MaCv = (int)cboChucVu.SelectedValue,
                    MatKhau = "12345678", // Mật khẩu mặc định
                    DaXoa = false,
                };

                nhanVienService.Create(nhanVien);
                TienIch.UIHelper.ShowMessage("Thêm nhân viên thành công");
            }
            else if (button1.Text == "Sửa")
            {
                if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtCMND.Text))
                {
                    TienIch.UIHelper.ShowMessageError("Vui lòng điền đầy đủ thông tin");
                    return;
                }

                nhanVien.TenNv = txtTen.Text;
                nhanVien.Sdt = txtSDT.Text;
                nhanVien.Cccd = txtCMND.Text;
                nhanVien.NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value);
                nhanVien.GioiTinh = cboGioiTinh.SelectedItem.ToString();
                nhanVien.MaCv = (int)cboChucVu.SelectedValue;

                nhanVienService.Update(nhanVien);
                TienIch.UIHelper.ShowMessage("Cập nhật nhân viên thành công");
                Close(); // Đóng form sau khi cập nhật
            }
        }

        private void btnResetMK_Click(object sender, EventArgs e)
        {
            nhanVien.MatKhau = "12345678"; // Đặt lại mật khẩu về mặc định
            nhanVienService.Update(nhanVien);
            TienIch.UIHelper.ShowMessage("Reset mật khẩu thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (TienIch.UIHelper.ShowMessageQuestion("Bạn có chắc muốn xóa nhân viên này?") == DialogResult.Yes)
            {
                nhanVien.DaXoa = true; // Đánh dấu là đã xóa
                nhanVienService.Update(nhanVien);
                TienIch.UIHelper.ShowMessage("Xóa nhân viên thành công");
                Close(); // Đóng form sau khi xóa
            }
        }
    }
}
