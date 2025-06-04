using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models;

public partial class DoiTraHang
{
    public int MaDt { get; set; }

    public string? MaHienThi { get; set; }

    public int MaHd { get; set; }

    public int MaNv { get; set; }

    public DateTime NgayDoiTra { get; set; }

    public string LyDo { get; set; } = null!;

    public decimal TongTienTraLai { get; set; }

    public virtual ICollection<ChiTietDoiTraHang> ChiTietDoiTraHangs { get; set; } = new List<ChiTietDoiTraHang>();

    public virtual HoaDon MaHdNavigation { get; set; } = null!;

    public virtual NhanVien MaNvNavigation { get; set; } = null!;
}
