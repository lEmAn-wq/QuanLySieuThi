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

namespace QuanLySieuThi.UserControls
{
    public partial class ChucVuUC : UserControl
    {
        private readonly IChucVuService chucVuService;
        public ChucVuUC(IChucVuService chucVuService)
        {
            InitializeComponent();
            this.chucVuService = chucVuService;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new ChucVuForm("Thêm", chucVuService).ShowDialog();

            ChucVuUC_Load(sender, e); // Refresh the DataGridView after editing
        }

        private void dgvChucVu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvChucVu.Rows.Count)
            {
                var selectedRow = dgvChucVu.Rows[e.RowIndex];
                var maCV = (int)selectedRow.Cells["MaCV"].Value;
                var chucVu = chucVuService.GetById(maCV);
                if (chucVu != null)
                {
                    new ChucVuForm("Sửa", chucVuService, chucVu).ShowDialog();

                    ChucVuUC_Load(sender, e); // Refresh the DataGridView after editing
                }
            }
        }

        private void ChucVuUC_Load(object sender, EventArgs e)
        {
            dgvChucVu.DataSource = chucVuService.GetAll();
            dgvChucVu.Columns["MaCV"].Visible = false; // Ẩn cột Id
            dgvChucVu.Columns["Nhanviens"].Visible = false; // Ẩn cột Id

            dgvChucVu.Columns["MaHienThi"].HeaderText = "Mã chức vụ";
            dgvChucVu.Columns["TenCv"].HeaderText = "Tên Chức Vụ";
            dgvChucVu.Columns["Luong"].HeaderText = "Lương";
        }
    }
}
