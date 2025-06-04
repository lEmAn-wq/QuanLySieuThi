using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models;

public partial class HoaDon
{
    public int MaHd { get; set; }

    public string? MaHienThi { get; set; }

    public int? MaKh { get; set; }

    public int MaNv { get; set; }

    public DateTime NgayTao { get; set; }

    public decimal TongTienPhaiTra { get; set; }

    public string TrangThai { get; set; } = null!;

    public bool DaDoiDiem { get; set; }

    public string HinhThucThanhToan { get; set; } = null!;

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual ICollection<DoiTraHang> DoiTraHangs { get; set; } = new List<DoiTraHang>();

    public virtual KhachHang? MaKhNavigation { get; set; }

    public virtual NhanVien MaNvNavigation { get; set; } = null!;
}
