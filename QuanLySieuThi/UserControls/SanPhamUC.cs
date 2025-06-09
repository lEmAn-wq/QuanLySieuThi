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
    public partial class SanPhamUC : UserControl
    {
        public SanPhamUC()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                flpSanPham.Controls.Add(new SPUC());
            }
        }
    }
}
