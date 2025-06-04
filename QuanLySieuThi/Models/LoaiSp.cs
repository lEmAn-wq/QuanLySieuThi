using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models;

public partial class LoaiSp
{
    public int MaLsp { get; set; }

    public string? MaHienThi { get; set; }

    public string TenLsp { get; set; } = null!;

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
