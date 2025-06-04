using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models;

public partial class ThuongHieu
{
    public int MaTh { get; set; }

    public string? MaHienThi { get; set; }

    public string TenTh { get; set; } = null!;

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
