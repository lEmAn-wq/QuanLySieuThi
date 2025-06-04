using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models;

public partial class ChiTietDoiTraHang
{
    public int MaDt { get; set; }

    public int MaSp { get; set; }

    public int SoLuong { get; set; }

    public bool LaDoi { get; set; }

    public virtual DoiTraHang MaDtNavigation { get; set; } = null!;

    public virtual SanPham MaSpNavigation { get; set; } = null!;
}
