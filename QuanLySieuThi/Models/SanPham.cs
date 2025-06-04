using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models;

public partial class SanPham
{
    public int MaSp { get; set; }

    public string? MaHienThi { get; set; }

    public string TenSp { get; set; } = null!;

    public decimal GiaGoc { get; set; }

    public string? HinhAnh { get; set; }

    public int? MaGgsp { get; set; }

    public int MaLsp { get; set; }

    public int MaNh { get; set; }

    public int MaTh { get; set; }

    public virtual ICollection<ChiTietDoiTraHang> ChiTietDoiTraHangs { get; set; } = new List<ChiTietDoiTraHang>();

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; } = new List<ChiTietPhieuNhap>();

    public virtual GiamGiaSanPham? MaGgspNavigation { get; set; }

    public virtual LoaiSp MaLspNavigation { get; set; } = null!;

    public virtual NganhHang MaNhNavigation { get; set; } = null!;

    public virtual ThuongHieu MaThNavigation { get; set; } = null!;
}
