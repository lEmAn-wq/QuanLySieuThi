using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models;

public partial class ChiTietHoaDon
{
    public int MaHd { get; set; }

    public int MaSp { get; set; }

    public int SoLuong { get; set; }

    public decimal GiaMua { get; set; }

    public decimal? PhanTramGiam { get; set; }

    public decimal? SoTienGiam { get; set; }

    public decimal GiaGoc { get; set; }

    public virtual HoaDon MaHdNavigation { get; set; } = null!;

    public virtual SanPham MaSpNavigation { get; set; } = null!;
}
