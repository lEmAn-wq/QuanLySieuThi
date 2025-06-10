//using QuanLySieuThi.Models;
//using QuanLySieuThi.Service;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace QuanLySieuThi.Forms
//{
//    public partial class ChiTietHoaDonForm : Form
//    {
//        private readonly IHoaDonService _hoaDonService;

//        public ChiTietHoaDonForm(HoaDon hoaDon, IHoaDonService hoaDonService)
//        {
//            InitializeComponent();
//            _hoaDonService = hoaDonService;

//            if (hoaDon == null)
//            {
//                MessageBox.Show("Không tìm thấy thông tin hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                Close();
//                return;
//            }

//            // Hiển thị thông tin hóa đơn
//            LoadHoaDonDetails(hoaDon);
//        }

//        private void LoadHoaDonDetails(HoaDon hoaDon)
//        {
//            try
//            {
//                // Gán giá trị cho các TextBox
//                labelTieuDe.Text = $"CHI TIẾT HÓA ĐƠN {hoaDon.MaHd}";
//                txtNgayMua.Text = hoaDon.NgayTao.ToString("dd/MM/yyyy HH:mm:ss");
//                txtMaKH.Text = hoaDon.MaHienThi;
//                txtHinhThucThanhToan.Text = hoaDon.HinhThucThanhToan;
//                txtTongTien.Text = FormatCurrency(hoaDon.TongTienPhaiTra);
//                txtTongTienTraLai.Text = FormatCurrency(hoaDon.TongTienThanhToan);
//                txtTongTienGiamGia.Text = FormatCurrency(hoaDon.TongTienGiamGia);
//                txtDoiDiem.Text = hoaDon.DoiDiem.ToString();

//                // Tải danh sách chi tiết hóa đơn
//                LoadChiTietHoaDon(hoaDon.MaHd);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Lỗi khi hiển thị thông tin hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void LoadChiTietHoaDon(string maHoaDon)
//        {
//            try
//            {
//                var chiTietHoaDonList = _hoaDonService.GetChiTietHoaDon(maHoaDon);
//                if (chiTietHoaDonList == null || !chiTietHoaDonList.Any())
//                {
//                    MessageBox.Show("Không có chi tiết hóa đơn nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    return;
//                }

//                // Hiển thị danh sách chi tiết hóa đơn trong DataGridView
//                dgvChiTietHoaDon.DataSource = chiTietHoaDonList.Select(ct => new
//                {
//                    ct.MaSp,
//                    ct.TenSp,
//                    ct.SoLuong,
//                    GiaBan = FormatCurrency(ct.GiaBan),
//                    ThanhTien = FormatCurrency(ct.ThanhTien)
//                }).ToList();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Lỗi khi tải chi tiết hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private string FormatCurrency(decimal value)
//        {
//            return value.ToString("N0") + " VNĐ";
//        }

//        private void btnDoiTra_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
