using QuanLySieuThi.TienIch;
using QuanLySieuThi.UserControls;
namespace QuanLySieuThi.Forms
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "NHÂN VIÊN";
            UIHelper.LoadUserControlToPanel(panel1, new NhanVienUC());
        }

        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "LẬP HÓA ĐƠN";
            UIHelper.LoadUserControlToPanel(panel1, new TaoHoaDonUC());
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "CHỨC VỤ";
            UIHelper.LoadUserControlToPanel(panel1, new ChucVuUC());
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "KHÁCH HÀNG";
            UIHelper.LoadUserControlToPanel(panel1, new KhachHangUC());
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "NHÀ CUNG CẤP";
            UIHelper.LoadUserControlToPanel(panel1, new NhaCungCapUC());
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
            UIHelper.LoadUserControlToPanel(panel1, new DanhMucSanPhamUC(uuDaiService,nganhHangService,loaiSanPhamService,thuongHieuService));
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "HÓA ĐƠN";
            UIHelper.LoadUserControlToPanel(panel1, new HoaDonUC());
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "PHIẾU NHẬP";
            UIHelper.LoadUserControlToPanel(panel1, new PhieuNhapUC());
        }
    }
}
