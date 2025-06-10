using QuanLySieuThi.TienIch;
using QuanLySieuThi.UserControls;
using QuanLySieuThi.Service;
using QuanLySieuThi.Models;
namespace QuanLySieuThi.Forms
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public static NhanVien nhanVien;
        private bool isClosedByCode = false;

        public MainForm(NhanVien nhanVien)
        {
            InitializeComponent();
            MainForm.nhanVien = nhanVien;
            lblThongTinNhanVien.Text = $"{nhanVien.TenNv} - {nhanVien.MaHienThi}\n Chức vụ: {nhanVien.MaCvNavigation.TenCv}";
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "NHÂN VIÊN";
            var nhanVienService = new Service.NhanVienService(new Repository.NhanVienRepository(new Models.QlsieuThiContext()));
            UIHelper.LoadUserControlToPanel(panel1, new NhanVienUC(nhanVienService));
        }

        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "LẬP HÓA ĐƠN";
            UIHelper.LoadUserControlToPanel(panel1, new TaoHoaDonUC());
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "CHỨC VỤ";
            var chucVuService = new Service.ChucVuService(new Repository.ChucVuRepository(new Models.QlsieuThiContext()));
            UIHelper.LoadUserControlToPanel(panel1, new ChucVuUC(chucVuService));
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "KHÁCH HÀNG";
            var khachHangService = new Service.KhachHangService(new Repository.KhachHangRepository(new Models.QlsieuThiContext()));
            UIHelper.LoadUserControlToPanel(panel1, new KhachHangUC(khachHangService));
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "NHÀ CUNG CẤP";
            var nhaCungCapService = new Service.NhaCungCapService(new Repository.NhaCungCapRepository(new Models.QlsieuThiContext()));
            UIHelper.LoadUserControlToPanel(panel1, new NhaCungCapUC(nhaCungCapService));
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "SẢN PHẨM";
            UIHelper.LoadUserControlToPanel(panel1, new SanPhamUC());
        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "DANH MỤC SẢN PHẨM";
            var uuDaiService = new Service.UuDaiService(new Repository.UuDaiRepository(new Models.QlsieuThiContext()));
            var nganhHangService = new Service.NganhHangService(new Repository.NganhHangRepository(new Models.QlsieuThiContext()));
            var loaiSanPhamService = new Service.LoaiSanPhamService(new Repository.LoaiSanPhamRepository(new Models.QlsieuThiContext()));
            var thuongHieuService = new Service.ThuongHieuService(new Repository.ThuongHieuRepository(new Models.QlsieuThiContext()));
            UIHelper.LoadUserControlToPanel(panel1, new DanhMucSanPhamUC(uuDaiService, nganhHangService, loaiSanPhamService, thuongHieuService));
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "HÓA ĐƠN";
            var hoaDonService = new Service.HoaDonService(new Repository.HoaDonRepository(new Models.QlsieuThiContext()));
            UIHelper.LoadUserControlToPanel(panel1, new HoaDonUC(hoaDonService));
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "PHIẾU NHẬP";
            UIHelper.LoadUserControlToPanel(panel1, new PhieuNhapUC());
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            var xacNhan = UIHelper.ShowMessageQuestion("Bạn có chắc muốn đăng xuất không?");
            if (xacNhan == DialogResult.Yes)
            {
                isClosedByCode = true; // Đánh dấu đóng bằng code
                Close();
            }
        }
    }
}
