using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models;

public partial class PhieuNhap
{
    public int MaPn { get; set; }

    public string? MaHienThi { get; set; }

    public int? MaNvduyet { get; set; }

    public int MaNvlap { get; set; }

    public int MaNcc { get; set; }

    public DateTime NgayDatHang { get; set; }

    public DateTime? NgayGiaoDuKien { get; set; }

    public DateTime? NgayGiao { get; set; }

    public decimal TongTienPhaiTra { get; set; }

    public string TrangThai { get; set; } = null!;

    public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; } = new List<ChiTietPhieuNhap>();

    public virtual NhaCungCap MaNccNavigation { get; set; } = null!;

    public virtual NhanVien? MaNvduyetNavigation { get; set; }

    public virtual NhanVien MaNvlapNavigation { get; set; } = null!;
}
