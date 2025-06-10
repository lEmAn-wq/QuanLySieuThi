using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.Forms;
using QuanLySieuThi.Models;
using QuanLySieuThi.Service;

namespace QuanLySieuThi.UserControls
{
    public partial class TaoHoaDonUC : UserControl
    {
        KhachHangService khachHangService;
        SanPhamService sanPhamService;
        UuDaiService uuDaiService;
        HoaDonService hoaDonService;

        public TaoHoaDonUC()
        {
            InitializeComponent();
            new KhachHangService(new Repository.KhachHangRepository(new Models.QlsieuThiContext()));
            sanPhamService = new SanPhamService(new Repository.SanPhamRepository(new Models.QlsieuThiContext()));
            uuDaiService = new UuDaiService(new Repository.UuDaiRepository(new Models.QlsieuThiContext()));
            new HoaDonService(new Repository.HoaDonRepository(new Models.QlsieuThiContext()));
        }

        private void btnLuuGioHang_Click(object sender, EventArgs e)
        {
            new DatTenGioHangForm().ShowDialog();
        }

        private void btnXacNhanKH_Click(object sender, EventArgs e)
        {
            var khachHang = khachHangService.GetByMaHienThi(txtNhapMaKH.Text);
            if (khachHang == null)
            {
                TienIch.UIHelper.ShowMessageWarning("Khách hàng không tồn tại!");
                txtMaKH.Focus();
                return;
            }
            txtMaKH.Text = khachHang.MaHienThi;
            txtTenKH.Text = khachHang.TenKh;
            txtSDT.Text = khachHang.Sdt;
            txtDiemTichLuy.Text = khachHang.DiemTichLuy.ToString();
        }

        private void btnXacNhanSP_Click(object sender, EventArgs e)
        {
            var sanPham = sanPhamService.GetByMaHienThi(txtNhapMaSP.Text);
            if (sanPham == null)
            {
                TienIch.UIHelper.ShowMessageWarning("Sản phẩm không tồn tại!");
                txtNhapMaSP.Focus();
                return;
            }
            dgvSP_Ban.Rows.Add(
                sanPham.MaHienThi,
                sanPham.TenSp,
                UuDaiService.TinhTienGiam(sanPham.GiaGoc, sanPham.MaGgspNavigation.PhanTramGiam, sanPham.MaGgspNavigation.SoTienGiam),
                null
            );
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(txtMaKH.Text))
                {
                    TienIch.UIHelper.ShowMessageWarning("Vui lòng nhập mã khách hàng!");
                    txtMaKH.Focus();
                    return;
                }

                var khachHang = khachHangService.GetByMaHienThi(txtMaKH.Text.Trim());
                if (khachHang == null)
                {
                    TienIch.UIHelper.ShowMessageWarning("Khách hàng không tồn tại! Tiếp tục với khách hàng không xác định.");
                    // Giả định MaKh = 0 hoặc null cho khách vãng lai (tùy cấu hình)
                }

                if (dgvSP_Ban.Rows.Count == 0 || dgvSP_Ban.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
                {
                    TienIch.UIHelper.ShowMessageWarning("Không có sản phẩm nào trong danh sách để tạo hóa đơn!");
                    return;
                }

                // Tính tổng tiền phải trả
                decimal tongTienPhaiTra = 0;
                foreach (DataGridViewRow row in dgvSP_Ban.Rows)
                {
                    if (row.IsNewRow) continue;
                    decimal giaBan = Convert.ToDecimal(row.Cells["GiaBan"].Value ?? 0);
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value ?? 0);
                    tongTienPhaiTra += giaBan * soLuong;
                }

                // Tạo hóa đơn
                var hoaDon = new HoaDon
                {
                    NgayTao = DateTime.Now,
                    MaKh = khachHang?.MaKh ?? 0,
                    TongTienPhaiTra = tongTienPhaiTra,
                    HinhThucThanhToan = cboHinhThucThanhToan.SelectedItem?.ToString() ?? "Tiền mặt",
                    MaNv = MainForm.nhanVien?.MaNv ?? 0,
                    TrangThai = "Không đổi trả",
                    DaDoiDiem = ckboxDoiDiem.Checked
                };

                using (var context = new QlsieuThiContext()) // Đảm bảo context được sử dụng
                {
                    context.HoaDons.Add(hoaDon);
                    context.SaveChanges(); // Lưu để lấy MaHd (nếu là khóa tự động tăng)

                    // Tạo chi tiết hóa đơn
                    foreach (DataGridViewRow row in dgvSP_Ban.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string maSP = row.Cells["MaSP"].Value?.ToString() ?? string.Empty;
                        if (string.IsNullOrEmpty(maSP)) continue;

                        var sanPham = sanPhamService.GetByMaHienThi(maSP);
                        if (sanPham == null)
                        {
                            TienIch.UIHelper.ShowMessageWarning($"Sản phẩm với mã {maSP} không tồn tại!");
                            continue;
                        }

                        var uuDai = sanPham.MaGgspNavigation;
                        var chiTietHoaDon = new ChiTietHoaDon
                        {
                            MaHd = hoaDon.MaHd, // Sử dụng MaHd đã được gán
                            MaSp = sanPham.MaSp,
                            SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value ?? 0),
                            GiaGoc = sanPham.GiaGoc,
                            GiaMua = Convert.ToDecimal(row.Cells["GiaBan"].Value ?? 0),
                            PhanTramGiam = uuDai?.PhanTramGiam ?? 0,
                            SoTienGiam = uuDai?.SoTienGiam ?? 0
                        };

                        context.ChiTietHoaDons.Add(chiTietHoaDon); // Thêm trực tiếp bằng EF
                    }

                    context.SaveChanges(); // Lưu tất cả chi tiết hóa đơn

                    TienIch.UIHelper.ShowMessage("Đã tạo hóa đơn thành công!");
                }
            }
            catch (Exception ex)
            {
                TienIch.UIHelper.ShowMessageError("Lỗi khi tạo hóa đơn: " + ex.Message);
            }
        }
    }
}
