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
    public partial class DanhMucSanPhamForm : Form
    {
        private readonly INganhHangService nganhHangService;
        private readonly ILoaiSanPhamService loaiSanPhamService;
        private readonly IThuongHieuService thuongHieuService;

        ThuongHieu thuongHieu;
        NganhHang nganhHang;
        LoaiSp loaiSanPham;

        int luaChon = 0; // 1: ngành hàng   2: loại sản phẩm   3: thương hiệu
        public DanhMucSanPhamForm(string text, int _luaChon, ILoaiSanPhamService loaiSanPhamService = null, IThuongHieuService thuongHieuService = null, INganhHangService nganhHangService = null, ThuongHieu thuongHieu = null, LoaiSp loaiSp = null, NganhHang nganhHang = null)
        {
            InitializeComponent();
            button1.Text = text;

            luaChon = _luaChon;
            if (loaiSanPhamService != null && luaChon == 2)
            {
                this.loaiSanPhamService = loaiSanPhamService;
                if (text == "Sửa")
                {
                    loaiSanPham = loaiSp;
                    labelTieuDe.Text = "THÔNG TIN LOẠI SẢN PHẨM " + loaiSanPham.MaHienThi;
                    txtTen.Text = loaiSanPham.TenLsp;
                    btnXoa.Visible = true;
                }
                else if (text == "Thêm" && loaiSp == null)
                {
                    labelTieuDe.Text = "THÊM LOẠI SẢN PHẨM";
                    txtTen.Text = string.Empty;
                    loaiSanPham = new LoaiSp();
                    btnXoa.Visible = false;
                }
                groupBox5.Text = "Tên loại sản phẩm";
            }
            else if (thuongHieuService != null && luaChon == 3)
            {
                this.thuongHieuService = thuongHieuService;
                if (text == "Sửa")
                {
                    this.thuongHieu = thuongHieu;
                    labelTieuDe.Text = "THÔNG TIN THƯƠNG HIỆU " + this.thuongHieu.MaHienThi;
                    txtTen.Text = this.thuongHieu.TenTh;
                    btnXoa.Visible = true;
                }
                else if (text == "Thêm" && thuongHieu == null)
                {
                    labelTieuDe.Text = "THÊM THƯƠNG HIỆU";
                    this.thuongHieu = new ThuongHieu();
                    txtTen.Text = string.Empty;
                    btnXoa.Visible = false;
                }
                groupBox5.Text = "Tên thương hiệu";
            }
            else if (nganhHangService != null && luaChon == 1)
            {
                this.nganhHangService = nganhHangService;
                if (text == "Sửa")
                {
                    this.nganhHang = nganhHang;
                    labelTieuDe.Text = "THÔNG TIN NGÀNH HÀNG " + this.nganhHang.MaHienThi;
                    txtTen.Text = this.nganhHang.TenNh;
                    btnXoa.Visible = true;
                }
                else if (text == "Thêm" && nganhHang == null)
                {
                    labelTieuDe.Text = "THÊM NGÀNH HÀNG";
                    this.nganhHang = new NganhHang();
                    txtTen.Text = string.Empty;
                    btnXoa.Visible = false;
                }
                groupBox5.Text = "Tên ngành hàng";
            }
            else
            {
                TienIch.UIHelper.ShowMessageError("Dữ liệu không hợp lệ hoặc không được cung cấp đúng cách. Vui lòng kiểm tra lại tham số đầu vào.");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.Text == "Thêm")
                {
                    if (luaChon == 1)
                    {
                        nganhHang.TenNh = txtTen.Text.Trim();
                        nganhHangService.Create(nganhHang);
                        TienIch.UIHelper.ShowMessage("Thêm ngành hàng thành công!");
                    }
                    else if (luaChon == 2)
                    {
                        loaiSanPham.TenLsp = txtTen.Text.Trim();
                        loaiSanPhamService.Create(loaiSanPham);
                        TienIch.UIHelper.ShowMessage("Thêm loại sản phẩm thành công!");
                    }
                    else if (luaChon == 3)
                    {
                        thuongHieu.TenTh = txtTen.Text.Trim();
                        thuongHieuService.CreateBrand(thuongHieu);
                        TienIch.UIHelper.ShowMessage("Thêm thương hiệu thành công!");
                    }
                }
                else if (button1.Text == "Sửa")
                {
                    if (luaChon == 1)
                    {
                        nganhHang.TenNh = txtTen.Text.Trim();
                        nganhHangService.Update(nganhHang);
                        TienIch.UIHelper.ShowMessage("Sửa ngành hàng thành công!");
                    }
                    else if (luaChon == 2)
                    {
                        loaiSanPham.TenLsp = txtTen.Text.Trim();
                        loaiSanPhamService.Update(loaiSanPham);
                        TienIch.UIHelper.ShowMessage("Sửa loại sản phẩm thành công!");
                    }
                    else if (luaChon == 3)
                    {
                        thuongHieu.TenTh = txtTen.Text.Trim();
                        thuongHieuService.UpdateBrand(thuongHieu);
                        TienIch.UIHelper.ShowMessage("Sửa thương hiệu thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                TienIch.UIHelper.ShowMessageError("Lỗi: " + ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (luaChon == 1)
                {
                    nganhHangService.Delete(nganhHang);
                    TienIch.UIHelper.ShowMessage("Xóa ngành hàng thành công!");
                }
                else if (luaChon == 2)
                {
                    loaiSanPhamService.Delete(loaiSanPham);
                    TienIch.UIHelper.ShowMessage("Xóa loại sản phẩm thành công!");
                }
                else if (luaChon == 3)
                {
                    thuongHieuService.DeleteBrand(thuongHieu);
                    TienIch.UIHelper.ShowMessage("Xóa thương hiệu thành công!");
                }
                Close();
            }
        }
    }
}
