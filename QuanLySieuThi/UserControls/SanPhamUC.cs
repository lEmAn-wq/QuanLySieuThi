using QuanLySieuThi.Forms;
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

namespace QuanLySieuThi
{
    public partial class SanPhamUC : UserControl
    {
        private readonly IThuongHieuService thuongHieuService;
        private readonly ISanPhamService sanPhamService;
        private readonly ILoaiSanPhamService loaiSanPhamService;
        private readonly INganhHangService nganhHangService;
        private readonly IUuDaiService uuDaiService;
        public SanPhamUC()
        {
            InitializeComponent();

            thuongHieuService = new ThuongHieuService(new ThuongHieuRepository(new Models.QlsieuThiContext()));
            sanPhamService = new SanPhamService(new SanPhamRepository(new Models.QlsieuThiContext()));
            loaiSanPhamService = new LoaiSanPhamService(new LoaiSanPhamRepository(new Models.QlsieuThiContext()));
            nganhHangService = new NganhHangService(new NganhHangRepository(new Models.QlsieuThiContext()));
            uuDaiService = new UuDaiService(new UuDaiRepository(new Models.QlsieuThiContext()));
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            new SanPhamForm().ShowDialog();
            SanPhamUC_Load(sender, e);
        }

        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            var selectedProducts = new Dictionary<string, string>();
            foreach (SPUC uc in flpSanPham.Controls)
            {
                if (uc.ckboxSP.Checked)
                {
                    selectedProducts.Add(uc.sanPham.MaHienThi, uc.sanPham.TenSp);
                }
            }
            new PhieuNhapForm(sanPhamService, selectedProducts).ShowDialog();
            SanPhamUC_Load(sender, e);
        }

        private void btnHuyGiamGia_Click(object sender, EventArgs e)
        {
            try
            {
                var xacNhan = TienIch.UIHelper.ShowMessageQuestion("Bạn có chắc muốn hủy giảm giá cho sản phẩm này không?");
                if (xacNhan == DialogResult.Yes)
                {
                    TienIch.UIHelper.ShowMessage("Đã hủy giảm giá thành công.");
                    SanPhamUC_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                TienIch.UIHelper.ShowMessageError("Lỗi: " + ex);
            }

        }

        private void btnApDungGiamGia_Click(object sender, EventArgs e)
        {
            try
            {
                TienIch.UIHelper.ShowMessage("Đã hủy giảm giá thành công.");
                SanPhamUC_Load(sender, e);
            }
            catch (Exception ex)
            {
                TienIch.UIHelper.ShowMessageError("Lỗi: " + ex);
            }
        }

        private void ckboxTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (flpSanPham.Controls.Count > 0)
            {
                foreach (SPUC uc in flpSanPham.Controls)
                {
                    if (uc != null && uc.ckboxSP != null) // Giả sử SPUC có một CheckBox tên là checkBox1
                    {
                        uc.ckboxSP.Checked = ckboxTatCa.Checked;
                    }
                }
            }
        }

        private void ckboxShowCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (flpSanPham.Controls.Count > 0)
            {
                foreach (SPUC uc in flpSanPham.Controls)
                {
                    if (uc != null && uc.ckboxSP != null)
                    {
                        if (ckboxShowCheck.Checked)
                        {
                            ckboxTatCa.Visible = true; // Hiển thị checkbox "Chọn tất cả"
                            uc.ckboxSP.Visible = true; // Hiển thị checkbox
                        }
                        else
                        {
                            ckboxTatCa.Checked = false; // Bỏ chọn checkbox "Chọn tất cả"
                            ckboxTatCa.Visible = false; // Ẩn checkbox "Chọn tất cả"

                            uc.ckboxSP.Checked = false; // Bỏ chọn checkbox
                            uc.ckboxSP.Visible = false; // Ẩn checkbox
                        }
                    }
                }
            }
        }
        private void SanPhamUC_Load(object sender, EventArgs e)
        {
            cboLoaiSanPham.DataSource = loaiSanPhamService.GetAll();
            cboLoaiSanPham.DisplayMember = "TenLSP";
            cboLoaiSanPham.ValueMember = "MaLSP";

            cboNganhHang.DataSource = nganhHangService.GetAll();
            cboNganhHang.DisplayMember = "TenNH";
            cboNganhHang.ValueMember = "MaNH";

            cboThuongHieu.DataSource = thuongHieuService.GetAllBrands();
            cboThuongHieu.DisplayMember = "TenTH";
            cboThuongHieu.ValueMember = "MaTH";

            cboUuDai.DataSource = uuDaiService.GetAllWithDisplay();
            cboUuDai.DisplayMember = "TenHienThi";
            cboUuDai.ValueMember = "MaGgsp";

            cboLoaiSanPham.SelectedIndex = cboNganhHang.SelectedIndex = cboThuongHieu.SelectedIndex = cboUuDai.SelectedIndex = cboSanPhamTonKho.SelectedIndex = -1;

            // Tải dữ liệu sản phẩm vào flpSanPham
            var sanPhams = sanPhamService.GetAll();
            foreach (var sp in sanPhams)
            {
                var uc = new SPUC(sp);
                flpSanPham.Controls.Add(uc);
            }
        }
    }
}
