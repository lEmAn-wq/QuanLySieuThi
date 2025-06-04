using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models;

public partial class KhachHang
{
    public int MaKh { get; set; }

    public string? MaHienThi { get; set; }

    public string TenKh { get; set; } = null!;

    public DateOnly NgaySinh { get; set; }

    public string GioiTinh { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public int DiemTichLuy { get; set; }

    public DateTime NgayDangKy { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
