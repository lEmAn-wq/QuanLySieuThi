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

namespace QuanLySieuThi.UserControls
{
    public partial class TaoHoaDonUC : UserControl
    {
        public TaoHoaDonUC()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuGioHang_Click(object sender, EventArgs e)
        {
            new DatTenGioHangForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
