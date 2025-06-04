using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models;

public partial class GiamGiaSanPham
{
    public int MaGgsp { get; set; }

    public string? MaHienThi { get; set; }

    public decimal? PhanTramGiam { get; set; }

    public decimal? SoTienGiam { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
