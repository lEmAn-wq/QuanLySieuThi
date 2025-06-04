using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models;

public partial class ChucVu
{
    public int MaCv { get; set; }

    public string? MaHienThi { get; set; }

    public string TenCv { get; set; } = null!;

    public decimal Luong { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
