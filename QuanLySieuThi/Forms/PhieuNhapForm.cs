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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi.Forms
{
    public partial class PhieuNhapForm : System.Windows.Forms.Form
    {
        private readonly INhaCungCapService nhaCungCapService;
        private readonly ISanPhamService sanPhamService;
        private readonly IChiTietPhieuNhapService chiTietPhieuNhapService;
        public PhieuNhapForm(ISanPhamService sanPhamService, Dictionary<string, string> keyValuePairs = null)
        {
            InitializeComponent();
            this.sanPhamService = sanPhamService;
            nhaCungCapService = new NhaCungCapService(new NhaCungCapRepository(new Models.QlsieuThiContext()));

            if (keyValuePairs != null)
            {
                foreach (var kvp in keyValuePairs)
                {
                    AddRowToDataGridView(kvp.Key, kvp.Value);
                }
            }
        }

        private void btnXacNhanNCC_Click(object sender, EventArgs e)
        {
            if (cboNCC.SelectedIndex < 0)
            {
                TienIch.UIHelper.ShowMessageWarning("Vui lòng chọn nhà cung cấp!");
                cboNCC.Focus(); // Đưa con trỏ về ComboBox
                return;
            }
            txtMaNCC.Text = (cboNCC.SelectedItem as NhaCungCap).MaHienThi;
            txtTenNCC.Text = (cboNCC.SelectedItem as NhaCungCap).TenNcc;
            txtSDT.Text = (cboNCC.SelectedItem as NhaCungCap).Sdt;
        }

        private void btnXacNhanSP_Click(object sender, EventArgs e)
        {
            var sp = sanPhamService.GetByMaHienThi(txtMaSP.Text.Trim());
            if (sp == null)
            {
                TienIch.UIHelper.ShowMessageWarning("Sản phẩm không tồn tại!");
                txtMaSP.Focus(); // Đưa con trỏ về TextBox
                return;
            }
            AddRowToDataGridView(sp.MaHienThi, sp.TenSp);

        }

        private void AddRowToDataGridView(string maHienThi, string tenSP)
        {
            dgvSP_Nhap.Rows.Add(
                maHienThi,
                tenSP,
                null,
                null
                );
        }

        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra txtMaNCC.Text rỗng hoặc null
            if (string.IsNullOrEmpty(txtMaNCC.Text))
            {
                TienIch.UIHelper.ShowMessageWarning("Vui lòng nhập mã nhà cung cấp!");
                txtMaNCC.Focus();
                return;
            }

            // Kiểm tra DataGridView có dòng nào không
            if (dgvSP_Nhap.Rows.Count == 0)
            {
                TienIch.UIHelper.ShowMessageWarning("Không có sản phẩm nào trong danh sách để tạo phiếu nhập!");
                return;
            }

            // Kiểm tra ngày giao dự kiến
            if (dtpNgayGiaoDuKien.Value < DateTime.Now)
            {
                TienIch.UIHelper.ShowMessageWarning("Ngày giao dự kiến không được nhỏ hơn ngày hiện tại!");
                dtpNgayGiaoDuKien.Focus();
                return;
            }
            // Kiểm tra phạm vi ngày hợp lệ của SQL Server
            if (dtpNgayGiaoDuKien.Value < new DateTime(1753, 1, 1) || dtpNgayGiaoDuKien.Value > new DateTime(9999, 12, 31))
            {
                TienIch.UIHelper.ShowMessageWarning("Ngày giao dự kiến phải nằm trong khoảng từ 01/01/1753 đến 31/12/9999!");
                dtpNgayGiaoDuKien.Focus();
                return;
            }

            // Tiếp tục xử lý logic tạo phiếu nhập
            try
            {
                using (var context = new QlsieuThiContext())
                {
                    decimal tongTienPhaiTra = 0;

                    foreach (DataGridViewRow row in dgvSP_Nhap.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value ?? 0); // Kiểm tra null
                        decimal giaNhap = Convert.ToDecimal(row.Cells["GiaNhap"].Value ?? 0); // Kiểm tra null

                        tongTienPhaiTra += soLuong * giaNhap;
                    }

                    var nhaCungCap = nhaCungCapService.GetByMaHienThi(txtMaNCC.Text.Trim());
                    if (nhaCungCap == null)
                    {
                        TienIch.UIHelper.ShowMessageWarning("Nhà cung cấp không tồn tại!");
                        return;
                    }
                    // Kiểm tra ngày giao dự kiến
                    if (dtpNgayGiaoDuKien.Value < new DateTime(1753, 1, 1) || dtpNgayGiaoDuKien.Value > new DateTime(9999, 12, 31))
                    {
                        TienIch.UIHelper.ShowMessageWarning("Ngày giao dự kiến phải nằm trong khoảng từ 01/01/1753 đến 31/12/9999!");
                        dtpNgayGiaoDuKien.Focus();
                        return;
                    }
                    var phieuNhap = new PhieuNhap
                    {
                        MaNcc = nhaCungCap.MaNcc,
                        NgayDatHang = DateTime.Now,
                        NgayGiaoDuKien = dtpNgayGiaoDuKien.Value,
                        MaNvlap = MainForm.nhanVien?.MaNv ?? 0,
                        TrangThai = "Chờ duyệt",
                        TongTienPhaiTra = tongTienPhaiTra
                    };

                    context.PhieuNhaps.Add(phieuNhap);
                    context.SaveChanges(); // Lưu để lấy MaPn

                    var chitietPhieuNhapList = new List<ChiTietPhieuNhap>();
                    foreach (DataGridViewRow row in dgvSP_Nhap.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string maHienThi = row.Cells["MaSP"].Value?.ToString() ?? string.Empty;
                        if (string.IsNullOrEmpty(maHienThi)) continue;

                        int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value ?? 0);
                        decimal giaNhap = Convert.ToDecimal(row.Cells["GiaNhap"].Value ?? 0);

                        var sanPham = sanPhamService.GetByMaHienThi(maHienThi);
                        if (sanPham == null)
                        {
                            TienIch.UIHelper.ShowMessageWarning($"Không tìm thấy sản phẩm với mã hiển thị: {maHienThi}");
                            continue;
                        }

                        var chiTietPhieuNhap = new ChiTietPhieuNhap
                        {
                            MaPn = phieuNhap.MaPn,
                            MaSp = sanPham.MaSp,
                            SoLuong = soLuong,
                            GiaNhap = giaNhap
                        };

                        chitietPhieuNhapList.Add(chiTietPhieuNhap);
                    }

                    context.ChiTietPhieuNhaps.AddRange(chitietPhieuNhapList);
                    context.SaveChanges(); // Lưu chi tiết phiếu nhập

                    TienIch.UIHelper.ShowMessage("Đã tạo phiếu nhập thành công cho các sản phẩm đã chọn.");
                }
            }
            catch (Exception ex)
            {
                TienIch.UIHelper.ShowMessageError("Lỗi: " + ex.Message);
            }
        }
        private void PhieuNhapForm_Load(object sender, EventArgs e)
        {
            cboNCC.DataSource = nhaCungCapService.GetAll();
            cboNCC.DisplayMember = "TenNCC"; // Hiển thị tên nhà cung cấp
            cboNCC.ValueMember = "MaNCC"; // Giá trị là mã nhà cung cấp
            cboNCC.SelectedIndex = -1; // Đặt không chọn mặc định
        }
    }
}
