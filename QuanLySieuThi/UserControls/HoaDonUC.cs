using QuanLySieuThi.Forms;
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
    public partial class HoaDonUC : UserControl
    {
        private readonly IHoaDonService hoaDonService; // Service để xử lý dữ liệu hóa đơn

        public HoaDonUC(IHoaDonService hoaDonService)
        {
            InitializeComponent();
            this.hoaDonService = hoaDonService;
        }

        private void HoaDonUC_Load(object sender, EventArgs e)
        {
            LoadHoaDonList();
        }

        private void LoadHoaDonList()
        {
            try
            {
                var hoaDonList = hoaDonService.GetAll(); // Lấy danh sách hóa đơn từ service
                dgvHoaDon.DataSource = hoaDonList.Select(hd => new
                {
                    hd.MaHd,
                    hd.NgayTao,
                    hd.MaKh,
                    hd.TongTienPhaiTra
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //var keyword = txtTimKiem.Text.Trim();
            //if (string.IsNullOrEmpty(keyword))
            //{
            //    LoadHoaDonList();
            //    return;
            //}

            //try
            //{
            //    var hoaDonList = hoaDonService.Search(keyword); // Tìm kiếm hóa đơn theo từ khóa
            //    dgvHoaDon.DataSource = hoaDonList.Select(hd => new
            //    {
            //        hd.MaHoaDon,
            //        hd.NgayLap,
            //        hd.TenKhachHang,
            //        hd.TongTien
            //    }).ToList();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi tìm kiếm hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var maHoaDon = dgvHoaDon.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();
            var hoaDon = hoaDonService.GetById(Convert.ToInt32(maHoaDon));
            //var chiTietHoaDonForm = new ChiTietHoaDonForm(hoaDon); // Form hiển thị chi tiết hóa đơn
            //chiTietHoaDonForm.ShowDialog();
        }
    }
}
