using QuanLySieuThi.Forms;
using QuanLySieuThi.Models;
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
    public partial class NhanVienUC : UserControl
    {
        private readonly INhanVienService nhanVienService;
        public NhanVienUC(INhanVienService nhanVienService)
        {
            InitializeComponent();
            this.nhanVienService = nhanVienService;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new NhanVienForm("Thêm", nhanVienService).ShowDialog();
            NhanVienUC_Load(sender, e);
        }

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count)
            {
                var selectedRow = dgvNhanVien.Rows[e.RowIndex];
                var maNV = (int)selectedRow.Cells["MaNV"].Value;
                var nhanVien = nhanVienService.GetById(maNV);
                if (nhanVien != null)
                {
                    new NhanVienForm("Sửa", nhanVienService, nhanVien).ShowDialog();
                    NhanVienUC_Load(sender, e);
                }
            }
        }

        private void NhanVienUC_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nhanVienService.GetNhanVienView();
            dgvNhanVien.Columns["MaNV"].Visible = false;

            dgvNhanVien.Columns["MaHienThi"].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns["TenNV"].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvNhanVien.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dgvNhanVien.Columns["CCCD"].HeaderText = "Căn cước công dân";
            dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức Vụ";
        }
    }
}
