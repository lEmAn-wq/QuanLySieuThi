using UngDungYte;

namespace QuanLySieuThi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "Quản lý nhân viên";
            UIHelper.LoadUserControlToPanel(panel1, new NhanVienUC());
        }

        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "Tính tiền khách hàng";
            UIHelper.LoadUserControlToPanel(panel1, new TaoHoaDonUC());
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "Quản lý chức vụ";
            UIHelper.LoadUserControlToPanel(panel1, new ChucVuUC());
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "Quản lý khách hàng";
            UIHelper.LoadUserControlToPanel(panel1, new KhachHangUC());
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "Quản lý nhà cung cấp";
            UIHelper.LoadUserControlToPanel(panel1, new NhaCungCapUC());
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "Quản lý sản phẩm";
            UIHelper.LoadUserControlToPanel(panel1, new SanPhamUC());
        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "Quản lý danh mục sản phẩm";
            UIHelper.LoadUserControlToPanel(panel1, new DanhMucSanPhamUC());
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "Quản lý hóa đơn";
            UIHelper.LoadUserControlToPanel(panel1, new HoaDonUC());
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "Quản lý phiếu nhập";
            UIHelper.LoadUserControlToPanel(panel1, new PhieuNhapUC());
        }
    }
}
