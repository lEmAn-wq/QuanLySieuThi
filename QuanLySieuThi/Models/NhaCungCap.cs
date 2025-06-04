using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models;

public partial class NhaCungCap
{
    public int MaNcc { get; set; }

    public string? MaHienThi { get; set; }

    public string TenNcc { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; } = new List<PhieuNhap>();
}
