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
namespace QuanLySieuThi
{
    public partial class NhaCungCapUC : UserControl
    {
        private readonly INhaCungCapService nhaCungCapService;
        public NhaCungCapUC(INhaCungCapService nhaCungCapService, NhaCungCap nhaCungCap = null)
        {
            InitializeComponent();
            this.nhaCungCapService = nhaCungCapService;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new NhaCungCapForm("Thêm", nhaCungCapService).ShowDialog();
            NhaCungCapUC_Load(sender, e);
        }

        private void dgvNCC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNCC.Rows.Count)
            {
                var selectedRow = dgvNCC.Rows[e.RowIndex];
                var maNCC = (int)selectedRow.Cells["MaNCC"].Value;
                var nhaCungCap = nhaCungCapService.GetById(maNCC);
                if (nhaCungCap != null)
                {
                    new NhaCungCapForm("Sửa",nhaCungCapService, nhaCungCap).ShowDialog();
                    NhaCungCapUC_Load(sender, e);
                }
            }
        }

        private void NhaCungCapUC_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = nhaCungCapService.GetAll();
            dgvNCC.Columns["MaNCC"].Visible = false;
            dgvNCC.Columns["PhieuNhaps"].Visible = false;

            dgvNCC.Columns["MaHienThi"].HeaderText = "Mã Nhà Cung Cấp";
            dgvNCC.Columns["TenNCC"].HeaderText = "Tên Nhà Cung Cấp";
            dgvNCC.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvNCC.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dgvNCC.Columns["Email"].HeaderText = "Email";
        }
    }
}
