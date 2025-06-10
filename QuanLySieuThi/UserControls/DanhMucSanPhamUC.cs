using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.Models;
using QuanLySieuThi.Repository;
using QuanLySieuThi.Service;
using QuanLySieuThi.TienIch;
using Stimulsoft.Controls.Win.DotNetBar.Controls;
using QuanLySieuThi.Forms;

namespace QuanLySieuThi
{
    public partial class DanhMucSanPhamUC : UserControl
    {
        private readonly IUuDaiService _uuDaiService;
        private readonly INganhHangService _nganhHangService;
        private readonly ILoaiSanPhamService _loaiSanPhamService;
        private readonly IThuongHieuService _thuongHieuService;

        public DanhMucSanPhamUC(IUuDaiService uuDaiService, INganhHangService nganhHangService, ILoaiSanPhamService loaiSanPhamService, IThuongHieuService thuongHieuService)
        {
            InitializeComponent();
            _uuDaiService = uuDaiService;
            _nganhHangService = nganhHangService;
            _loaiSanPhamService = loaiSanPhamService;
            _thuongHieuService = thuongHieuService;
        }
        private void DanhMucSanPhamUC_Load(object sender, EventArgs e)
        {
            dgvUuDaiSanPham.DataSource = _uuDaiService.GetAllWithDisplay();
            dgvUuDaiSanPham.Columns["MaHienThi"].HeaderText = "Mã ưu đãi";
            dgvUuDaiSanPham.Columns["PhanTramGiam"].HeaderText = "% Giảm";
            dgvUuDaiSanPham.Columns["SoTienGiam"].HeaderText = "Số Tiền Giảm";
            dgvUuDaiSanPham.Columns["TenHienThi"].HeaderText = "Tên hiển thị";

            dgvUuDaiSanPham.Columns["MaGgsp"].Visible = false; // Ẩn cột MaGgsp


            dgvLoaiSanPham.DataSource = _loaiSanPhamService.GetAll();
            dgvLoaiSanPham.Columns["MaHienThi"].HeaderText = "Mã loại sản phẩm";
            dgvLoaiSanPham.Columns["TenLSP"].HeaderText = "Tên loại sản phẩm";

            dgvLoaiSanPham.Columns["MaLsp"].Visible = false; // Ẩn cột MaLsp
            dgvLoaiSanPham.Columns["SanPhams"].Visible = false; // Ẩn cột ThuongHieu


            dgvNganhHang.DataSource = _nganhHangService.GetAll();
            dgvNganhHang.Columns["MaHienThi"].HeaderText = "Mã ngành hàng";
            dgvNganhHang.Columns["TenNH"].HeaderText = "Tên ngành hàng";

            dgvNganhHang.Columns["MaNH"].Visible = false; // Ẩn cột MaNganhHang
            dgvNganhHang.Columns["SanPhams"].Visible = false; // Ẩn cột SanPhams


            dgvThuongHieu.DataSource = _thuongHieuService.GetAllBrands();
            dgvThuongHieu.Columns["MaHienThi"].HeaderText = "Mã thương hiệu";
            dgvThuongHieu.Columns["TenTH"].HeaderText = "Tên thương hiệu";

            dgvThuongHieu.Columns["MaTh"].Visible = false; // Ẩn cột MaThuongHieu
            dgvThuongHieu.Columns["SanPhams"].Visible = false; // Ẩn cột SanPhams
        }

        #region Ưu đãi

        private void btnThemUuDai_Click(object sender, EventArgs e)
        {
            new UuDaiSanPhamForm(_uuDaiService, "Thêm").ShowDialog();
            DanhMucSanPhamUC_Load(sender, e); // Tải lại dữ liệu sau khi thêm
        }

        private void dgvUuDaiSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvUuDaiSanPham.Rows.Count)
                return;

            var id = (int)dgvUuDaiSanPham.Rows[e.RowIndex].Cells["MaGgsp"].Value; // hoặc tên cột ID đúng
            var uuDai = _uuDaiService.GetByID(id);
            new UuDaiSanPhamForm(_uuDaiService, "Sửa", uuDai).ShowDialog();

            DanhMucSanPhamUC_Load(sender, e); // Tải lại dữ liệu sau khi sửa
        }

        #endregion

        #region Ngành hàng

        private void btnThemNganhHang_Click(object sender, EventArgs e)
        {
            new DanhMucSanPhamForm("Thêm", 1, nganhHangService: _nganhHangService).ShowDialog();

            DanhMucSanPhamUC_Load(sender, e); // Tải lại dữ liệu sau khi sửa
        }
        private void dgvNganhHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvNganhHang.Rows.Count)
                return;

            var id = (int)dgvNganhHang.Rows[e.RowIndex].Cells["MaNH"].Value; // hoặc tên cột ID đúng
            var nganhHang = _nganhHangService.GetById(id);
            new DanhMucSanPhamForm("Sửa",1, nganhHangService: _nganhHangService, nganhHang: nganhHang).ShowDialog();

            DanhMucSanPhamUC_Load(sender, e); // Tải lại dữ liệu sau khi sửa
        }

        #endregion

        #region Loại sản phẩm

        private void btnThemLoaiSanPham_Click(object sender, EventArgs e)
        {
            new DanhMucSanPhamForm("Thêm", 2, loaiSanPhamService: _loaiSanPhamService).ShowDialog();

            DanhMucSanPhamUC_Load(sender, e); // Tải lại dữ liệu sau khi sửa
        }

        private void dgvLoaiSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvLoaiSanPham.Rows.Count)
                return;

            var id = (int)dgvLoaiSanPham.Rows[e.RowIndex].Cells["MaLSP"].Value; // hoặc tên cột ID đúng
            var loaiSanPham = _loaiSanPhamService.GetById(id);
            new DanhMucSanPhamForm("Sửa", 2, loaiSanPhamService: _loaiSanPhamService, loaiSp: loaiSanPham).ShowDialog();

            DanhMucSanPhamUC_Load(sender, e); // Tải lại dữ liệu sau khi sửa
        }

        #endregion

        #region Thương hiệu

        private void btnThemThuongHieu_Click(object sender, EventArgs e)
        {
            new DanhMucSanPhamForm("Thêm", 3, thuongHieuService: _thuongHieuService).ShowDialog();

            DanhMucSanPhamUC_Load(sender, e); // Tải lại dữ liệu sau khi sửa
        }

        private void dgvThuongHieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvThuongHieu.Rows.Count)
                return;

            var id = (int)dgvThuongHieu.Rows[e.RowIndex].Cells["MaTH"].Value; // hoặc tên cột ID đúng
            var thuongHieu = _thuongHieuService.GetByID(id);
            new DanhMucSanPhamForm("Sửa", 3, thuongHieuService: _thuongHieuService, thuongHieu: thuongHieu).ShowDialog();

            DanhMucSanPhamUC_Load(sender, e); // Tải lại dữ liệu sau khi sửa
        }

        #endregion
    }
}
