using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models;

public partial class NhanVien
{
    public int MaNv { get; set; }

    public string? MaHienThi { get; set; }

    public string TenNv { get; set; } = null!;

    public string GioiTinh { get; set; } = null!;

    public DateOnly NgaySinh { get; set; }

    public string Sdt { get; set; } = null!;

    public string Cccd { get; set; } = null!;

    public int MaCv { get; set; }

    public string MatKhau { get; set; } = null!;

    public bool DaXoa { get; set; }

    public virtual ICollection<DoiTraHang> DoiTraHangs { get; set; } = new List<DoiTraHang>();

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual ChucVu MaCvNavigation { get; set; } = null!;

    public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; } = new List<PhieuNhap>();
}
