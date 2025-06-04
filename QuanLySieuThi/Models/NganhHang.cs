using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models;

public partial class NganhHang
{
    public int MaNh { get; set; }

    public string? MaHienThi { get; set; }

    public string TenNh { get; set; } = null!;

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
