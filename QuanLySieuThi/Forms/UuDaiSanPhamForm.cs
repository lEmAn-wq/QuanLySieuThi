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
    public partial class UuDaiSanPhamForm : Form
    {
        IUuDaiService _uuDaiService;
        GiamGiaSanPham _uuDai;
        public UuDaiSanPhamForm(IUuDaiService uuDaiService, string text, GiamGiaSanPham giamGiaSanPham = null)
        {
            InitializeComponent();
            _uuDaiService = uuDaiService;
            button1.Text = text;
            _uuDai = giamGiaSanPham ?? new GiamGiaSanPham();
        }

        private bool ValidateInput()
        {
            var loaiUuDai = cboLoaiUuDai.SelectedIndex;

            if (loaiUuDai == 1)
            {
                if (!decimal.TryParse(txtSoTienGiam.Text, out decimal soTien) || soTien <= 0)
                {
                    TienIch.UIHelper.ShowMessageError("Số tiền giảm phải là số hợp lệ lớn hơn 0.");
                    return false;
                }
                _uuDai.SoTienGiam = soTien;
                _uuDai.PhanTramGiam = null;
            }
            else if (loaiUuDai == 0)
            {
                if (!decimal.TryParse(txtPhanTramGiam.Text, out decimal phanTram) || phanTram <= 0 || phanTram >= 100)
                {
                    TienIch.UIHelper.ShowMessageError("Phần trăm giảm phải từ 1 đến nhỏ hơn 100.");
                    return false;
                }
                _uuDai.PhanTramGiam = phanTram;

                if (!string.IsNullOrWhiteSpace(txtSoTienGiam.Text))
                {
                    if (!decimal.TryParse(txtSoTienGiam.Text, out decimal giamToiDa) || giamToiDa <= 0)
                    {
                        TienIch.UIHelper.ShowMessageError("Số tiền giảm tối đa phải là số hợp lệ lớn hơn 0.");
                        return false;
                    }
                    _uuDai.SoTienGiam = giamToiDa;
                }
                else
                {
                    _uuDai.SoTienGiam = null;
                }
            }
            else
            {
                TienIch.UIHelper.ShowMessageError("Vui lòng nhập phần trăm giảm hoặc số tiền giảm.");
                return false;
            }
            return true;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var xacNhan = TienIch.UIHelper.ShowMessageQuestion("Bạn có chắc chắn muốn xóa ưu đãi này?");
                if (xacNhan != System.Windows.Forms.DialogResult.Yes)
                    return;
                _uuDaiService.DeleteVoucher(_uuDai);
                TienIch.UIHelper.ShowMessage("Xóa ưu đãi thành công!");
                Close();
            }
            catch (Exception ex)
            {
                TienIch.UIHelper.ShowMessageError("Lỗi khi xóa ưu đãi: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    if (button1.Text == "Thêm")
                    {
                        _uuDaiService.CreateVoucher(_uuDai);
                        TienIch.UIHelper.ShowMessage($"Ưu đãi đã được thêm thành công!");
                    }
                    else if (button1.Text == "Sửa")
                    {
                        _uuDaiService.UpdateVoucher(_uuDai);
                        TienIch.UIHelper.ShowMessage($"Ưu đãi đã được sửa thành công!");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                TienIch.UIHelper.ShowMessageError($"Lỗi: " + ex.Message);
            }
        }

        private void cboLoaiUuDai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiUuDai.SelectedIndex == 1) // Chọn "Số tiền giảm")
            {
                txtPhanTramGiam.ReadOnly = true;
                txtSoTienGiam.ReadOnly = false;
                txtPhanTramGiam.Text = null;
                grboxSoTienGiam.Text = "Số tiền giảm";
            }
            else if (cboLoaiUuDai.SelectedIndex == 0) // Chọn "% Giảm")
            {
                txtPhanTramGiam.ReadOnly = false;
                txtSoTienGiam.ReadOnly = false;
                grboxSoTienGiam.Text = "Số tiền giảm tối đa (nếu có)";
            }
            else if (cboLoaiUuDai.SelectedIndex == -1)
            {
                txtPhanTramGiam.ReadOnly = true;
                txtSoTienGiam.ReadOnly = true;
                grboxSoTienGiam.Text = "Số tiền giảm";
            }
        }

        private void UuDaiSanPhamForm_Load(object sender, EventArgs e)
        {
            if (button1.Text == "Sửa")
            {
                labelTieuDe.Text = "THÔNG TIN ƯU ĐÃI " + _uuDai.MaHienThi;
                btnXoa.Visible = true;
                txtPhanTramGiam.Text = _uuDai.PhanTramGiam?.ToString();
                txtSoTienGiam.Text = _uuDai.SoTienGiam?.ToString();
                if (txtPhanTramGiam.Text == string.Empty)
                {
                    cboLoaiUuDai.SelectedIndex = 1; // Chọn "Số tiền giảm"
                }
                else
                {
                    cboLoaiUuDai.SelectedIndex = 0; // Chọn "% Giảm"
                }
            }
            else if (button1.Text == "Thêm")
            {
                cboLoaiUuDai.SelectedIndex = -1;
                labelTieuDe.Text = "THÊM ƯU ĐÃI SẢN PHẨM";
                btnXoa.Visible = false;

                txtPhanTramGiam.ReadOnly = true;
                txtSoTienGiam.ReadOnly = true;
                grboxSoTienGiam.Text = "Số tiền giảm";
            }
        }
    }
}