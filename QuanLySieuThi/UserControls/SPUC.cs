using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace QuanLySieuThi
{
    public partial class SPUC : UserControl
    {
        public SanPham sanPham;
        public SPUC(SanPham sanPham)
        {
            InitializeComponent();
            try
            {
                this.sanPham = sanPham;

                InitInfoBox(sanPham);

                // Load ảnh nếu có
                if (!string.IsNullOrWhiteSpace(sanPham.HinhAnh))
                {
                    var folder = Path.Combine(Application.StartupPath, "HinhAnh");
                    var fullPath = Path.Combine(folder, sanPham.HinhAnh);
                    if (File.Exists(fullPath))
                    {
                        picboxSanPham.Image = Image.FromFile(fullPath);
                    }
                }
            }
            catch (Exception ex)
            {
                TienIch.UIHelper.ShowMessageError("Lỗi: " + ex.Message);
            }
        }

        private void InitInfoBox(SanPham sp)
        {
            rtbInfo.ReadOnly = true;
            rtbInfo.BorderStyle = BorderStyle.None;
            rtbInfo.BackColor = Color.FromArgb(245, 245, 245);
            rtbInfo.Clear();

            // 1) Tên sản phẩm (Arial 14pt Semibold, đen đậm)
            rtbInfo.SelectionFont = new Font("Arial", 14, FontStyle.Bold);
            rtbInfo.SelectionColor = Color.FromArgb(20, 20, 20);
            rtbInfo.AppendText(sp.TenSp + Environment.NewLine + Environment.NewLine);
            rtbInfo.Select(rtbInfo.TextLength - sp.TenSp.Length - 2, sp.TenSp.Length + 2);
            rtbInfo.SelectionAlignment = HorizontalAlignment.Center;

            // 2) Giá gốc (Times New Roman 10pt Strikeout, xám nhạt)
            rtbInfo.SelectionFont = new Font("Times New Roman", 10, FontStyle.Strikeout);
            rtbInfo.SelectionColor = Color.FromArgb(120, 120, 120);
            string giaGocText = "Giá gốc: " + sp.GiaGoc.ToString("N0") + "đ" + Environment.NewLine;
            rtbInfo.AppendText(giaGocText);
            rtbInfo.Select(rtbInfo.TextLength - giaGocText.Length, giaGocText.Length);
            rtbInfo.SelectionAlignment = HorizontalAlignment.Center;

            // 3) Giá sau giảm (Segoe UI 12pt Bold, đỏ cam) – chỉ khi có giảm
            var gg = sp.MaGgspNavigation;
            var giam = UuDaiService.TinhTienGiam(sp.GiaGoc, gg?.PhanTramGiam, gg?.SoTienGiam);
            if (giam > 0)
            {
                rtbInfo.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
                rtbInfo.SelectionColor = Color.FromArgb(200, 0, 0);
                string giaKhuyenMaiText = "Giá khuyến mãi: " + (sp.GiaGoc - giam).ToString("N0") + "đ" + Environment.NewLine;
                rtbInfo.AppendText(giaKhuyenMaiText);
                rtbInfo.Select(rtbInfo.TextLength - giaKhuyenMaiText.Length, giaKhuyenMaiText.Length);
                rtbInfo.SelectionAlignment = HorizontalAlignment.Center;
            }

            // 4) Số lượng tồn kho (Arial 10pt Regular, xám đậm)
            rtbInfo.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
            rtbInfo.SelectionColor = Color.FromArgb(50, 50, 50);
            string tonKhoText = "Số lượng tồn kho: " + sp.SoLuong + Environment.NewLine;
            rtbInfo.AppendText(tonKhoText);
            rtbInfo.Select(rtbInfo.TextLength - tonKhoText.Length, tonKhoText.Length);
            rtbInfo.SelectionAlignment = HorizontalAlignment.Center;

            // 5) Mô tả ưu đãi (Times New Roman 10pt Italic, xanh lá nhạt)
            var uuDai = UuDaiService.GetTenHienThi(gg?.PhanTramGiam, gg?.SoTienGiam);
            if (!string.IsNullOrEmpty(uuDai))
            {
                rtbInfo.SelectionFont = new Font("Times New Roman", 10, FontStyle.Italic);
                rtbInfo.SelectionColor = Color.FromArgb(0, 150, 0);
                string uuDaiText = "Ưu đãi: " + uuDai + Environment.NewLine;
                rtbInfo.AppendText(uuDaiText);
                rtbInfo.Select(rtbInfo.TextLength - uuDaiText.Length, uuDaiText.Length);
                rtbInfo.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

      
        private void picboxSanPham_DoubleClick(object sender, EventArgs e)
        {
            new SanPhamForm().ShowDialog();
        }
    }
}
