using Microsoft.EntityFrameworkCore.Query;
using QuanLySieuThi.Models;
using QuanLySieuThi.Repository;
using QuanLySieuThi.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi.Forms
{
    public partial class ChucVuForm : Form
    {
        private readonly IChucVuService chucVuService;
        private ChucVu chucVu;
        public ChucVuForm(string text, IChucVuService chucVuService, ChucVu chucVu = null)
        {
            InitializeComponent();
            this.chucVuService = chucVuService;
            button1.Text = text;
            if (text == "Sửa")
            {
                if (chucVu == null)
                {
                    TienIch.UIHelper.ShowMessageError("Lỗi: Thông tin chức vụ không tồn tại!");
                    return;
                }
                this.chucVu = chucVu;
                labelTieuDe.Text = "THÔNG TIN CHỨC VỤ " + this.chucVu.MaHienThi;
                txtTenChucVu.Text = this.chucVu.TenCv;
                txtLuong.Text = this.chucVu.Luong.ToString("N0");
                btnXoa.Visible = true;
            }
            else if (text == "Thêm")
            {
                labelTieuDe.Text = "THÊM CHỨC VỤ";
                btnXoa.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.Text == "Thêm")
                {
                    chucVu = new ChucVu();
                    if (string.IsNullOrWhiteSpace(txtTenChucVu.Text))
                    {
                        TienIch.UIHelper.ShowMessageError("Tên chức vụ không được để trống!");
                        return;
                    }
                    chucVu.TenCv = txtTenChucVu.Text.Trim();
                    if (decimal.TryParse(txtLuong.Text.Trim(), out decimal luong) && luong > 0)
                    {
                        chucVu.Luong = luong;
                    }
                    else
                    {
                        TienIch.UIHelper.ShowMessageError("Lương phải là một số hợp lệ!");
                        return;
                    }
                    chucVuService.Create(chucVu);
                    TienIch.UIHelper.ShowMessage("Thêm chức vụ thành công!");
                }
                else if (button1.Text == "Sửa")
                {
                    if (string.IsNullOrWhiteSpace(txtTenChucVu.Text))
                    {
                        TienIch.UIHelper.ShowMessageError("Tên chức vụ không được để trống!");
                        return;
                    }
                    chucVu.TenCv = txtTenChucVu.Text.Trim();
                    if (decimal.TryParse(txtLuong.Text.Trim(), out decimal luong) && luong > 0)
                    {
                        chucVu.Luong = luong;
                    }
                    else
                    {
                        TienIch.UIHelper.ShowMessageError("Lương phải là một số hợp lệ!");
                        return;
                    }
                    chucVuService.Update(chucVu);
                    TienIch.UIHelper.ShowMessage("Cập nhật chức vụ thành công!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                TienIch.UIHelper.ShowMessageError("Lỗi: " + ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                chucVuService.Delete(chucVu);
                TienIch.UIHelper.ShowMessage("Xóa chức vụ thành công!");
                Close();
            }
            catch (Exception ex)
            {
                TienIch.UIHelper.ShowMessageError("Lỗi: " + ex);
            }
           
        }
    }
}
