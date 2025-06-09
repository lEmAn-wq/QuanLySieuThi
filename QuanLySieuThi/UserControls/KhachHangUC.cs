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
    public partial class KhachHangUC : UserControl
    {
        private readonly IKhachHangService khachHangService;
        public KhachHangUC(IKhachHangService khachHangService)
        {
            InitializeComponent();
            this.khachHangService = khachHangService;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new KhachHangForm("Thêm", khachHangService).ShowDialog();

            KhachHangUC_Load(sender, e);
        }

        private void KhachHangUC_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = khachHangService.GetAll();
            dgvKH.Columns["MaKH"].Visible = false;
            dgvKH.Columns["HoaDons"].Visible = false;

            dgvKH.Columns["MaHienThi"].HeaderText = "Mã Khách Hàng";
            dgvKH.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
            dgvKH.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dgvKH.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvKH.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvKH.Columns["DiemTichLuy"].HeaderText = "Điểm tích lũy";
            dgvKH.Columns["NgayDangKy"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
        }

        private void dgvKH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < dgvKH.Rows.Count)
            {
                var selectedRow = dgvKH.Rows[e.RowIndex];
                var maKhachHang = (int)selectedRow.Cells["MaKH"].Value;
                var khachHang = khachHangService.GetById(maKhachHang);

                if (khachHang != null)
                {
                    new KhachHangForm("Sửa", khachHangService, khachHang).ShowDialog();
                    KhachHangUC_Load(sender, e);
                }
            }
        }
    }
}
