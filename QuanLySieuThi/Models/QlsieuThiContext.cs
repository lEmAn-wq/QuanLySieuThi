using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QuanLySieuThi.Models;

public partial class QlsieuThiContext : DbContext
{
    public QlsieuThiContext()
    {
    }

    public QlsieuThiContext(DbContextOptions<QlsieuThiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietDoiTraHang> ChiTietDoiTraHangs { get; set; }

    public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }

    public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<DoiTraHang> DoiTraHangs { get; set; }

    public virtual DbSet<GiamGiaSanPham> GiamGiaSanPhams { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LoaiSp> LoaiSps { get; set; }

    public virtual DbSet<NganhHang> NganhHangs { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<ThuongHieu> ThuongHieus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("workstation id=QLSieuThi.mssql.somee.com;packet size=4096;user id=LeMan_SQLLogin_1;pwd=sango123321;data source=QLSieuThi.mssql.somee.com;persist security info=False;initial catalog=QLSieuThi;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietDoiTraHang>(entity =>
        {
            entity.HasKey(e => new { e.MaDt, e.MaSp }).HasName("PK_ChiTietTraHang");

            entity.ToTable("ChiTietDoiTraHang");

            entity.Property(e => e.MaDt).HasColumnName("MaDT");
            entity.Property(e => e.MaSp).HasColumnName("MaSP");

            entity.HasOne(d => d.MaDtNavigation).WithMany(p => p.ChiTietDoiTraHangs)
                .HasForeignKey(d => d.MaDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChiTietTraHang_TraHang_HoanTien");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.ChiTietDoiTraHangs)
                .HasForeignKey(d => d.MaSp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChiTietTraHang_SanPham");
        });

        modelBuilder.Entity<ChiTietHoaDon>(entity =>
        {
            entity.HasKey(e => new { e.MaHd, e.MaSp });

            entity.ToTable("ChiTietHoaDon");

            entity.Property(e => e.MaHd).HasColumnName("MaHD");
            entity.Property(e => e.MaSp).HasColumnName("MaSP");
            entity.Property(e => e.GiaGoc).HasColumnType("money");
            entity.Property(e => e.GiaMua).HasColumnType("money");
            entity.Property(e => e.PhanTramGiam).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.SoTienGiam).HasColumnType("money");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.ChiTietHoaDons)
                .HasForeignKey(d => d.MaHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChiTietHoaDon_HoaDon");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.ChiTietHoaDons)
                .HasForeignKey(d => d.MaSp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChiTietHoaDon_SanPham");
        });

        modelBuilder.Entity<ChiTietPhieuNhap>(entity =>
        {
            entity.HasKey(e => new { e.MaPn, e.MaSp });

            entity.ToTable("ChiTietPhieuNhap");

            entity.Property(e => e.MaPn).HasColumnName("MaPN");
            entity.Property(e => e.MaSp).HasColumnName("MaSP");
            entity.Property(e => e.GiaNhap).HasColumnType("money");

            entity.HasOne(d => d.MaPnNavigation).WithMany(p => p.ChiTietPhieuNhaps)
                .HasForeignKey(d => d.MaPn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChiTietPhieuNhap_PhieuNhap");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.ChiTietPhieuNhaps)
                .HasForeignKey(d => d.MaSp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChiTietPhieuNhap_SanPham");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.MaCv);

            entity.ToTable("ChucVu");

            entity.HasIndex(e => e.TenCv, "IX_ChucVu_TenChucVu").IsUnique();

            entity.Property(e => e.MaCv).HasColumnName("MaCV");
            entity.Property(e => e.Luong).HasColumnType("money");
            entity.Property(e => e.MaHienThi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComputedColumnSql("('CV'+right('000'+CONVERT([varchar](3),[MaCV]),(3)))", true);
            entity.Property(e => e.TenCv)
                .HasMaxLength(50)
                .HasColumnName("TenCV");
        });

        modelBuilder.Entity<DoiTraHang>(entity =>
        {
            entity.HasKey(e => e.MaDt).HasName("PK_TraHang_HoanTien");

            entity.ToTable("DoiTraHang");

            entity.HasIndex(e => e.MaHienThi, "IX_TraHang_HoanTien_MaHT").IsUnique();

            entity.Property(e => e.MaDt).HasColumnName("MaDT");
            entity.Property(e => e.LyDo).HasMaxLength(255);
            entity.Property(e => e.MaHd).HasColumnName("MaHD");
            entity.Property(e => e.MaHienThi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComputedColumnSql("('DT'+right('000'+CONVERT([varchar](3),[MaDT]),(3)))", true);
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.NgayDoiTra).HasColumnType("datetime");
            entity.Property(e => e.TongTienTraLai).HasColumnType("money");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.DoiTraHangs)
                .HasForeignKey(d => d.MaHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TraHang_HoanTien_HoaDon");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.DoiTraHangs)
                .HasForeignKey(d => d.MaNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TraHang_HoanTien_NhanVien");
        });

        modelBuilder.Entity<GiamGiaSanPham>(entity =>
        {
            entity.HasKey(e => e.MaGgsp).HasName("PK_GiamGiaSanPham_1");

            entity.ToTable("GiamGiaSanPham");

            entity.HasIndex(e => new { e.SoTienGiam, e.PhanTramGiam }, "UQ_GiamGiaSanPham_GiamGia").IsUnique();

            entity.Property(e => e.MaGgsp).HasColumnName("MaGGSP");
            entity.Property(e => e.MaHienThi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComputedColumnSql("('UD'+right('000'+CONVERT([varchar](3),[MaGGSP]),(3)))", true);
            entity.Property(e => e.PhanTramGiam).HasColumnType("decimal(5, 3)");
            entity.Property(e => e.SoTienGiam).HasColumnType("money");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHd);

            entity.ToTable("HoaDon");

            entity.HasIndex(e => e.MaHienThi, "IX_HoaDon_MaHienThi").IsUnique();

            entity.Property(e => e.MaHd).HasColumnName("MaHD");
            entity.Property(e => e.HinhThucThanhToan).HasMaxLength(50);
            entity.Property(e => e.MaHienThi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComputedColumnSql("('HD'+right('000'+CONVERT([varchar](3),[MaHD]),(3)))", true);
            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.TongTienPhaiTra).HasColumnType("money");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK_HoaDon_KhachHang");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HoaDon_NhanVien");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh);

            entity.ToTable("KhachHang");

            entity.HasIndex(e => e.MaHienThi, "IX_KhachHang_MaHienThi").IsUnique();

            entity.HasIndex(e => e.Sdt, "IX_KhachHang_SDT").IsUnique();

            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.GioiTinh).HasMaxLength(3);
            entity.Property(e => e.MaHienThi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComputedColumnSql("('KH'+right('000'+CONVERT([varchar](3),[MaKH]),(3)))", true);
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SDT");
            entity.Property(e => e.TenKh)
                .HasMaxLength(100)
                .HasColumnName("TenKH");
        });

        modelBuilder.Entity<LoaiSp>(entity =>
        {
            entity.HasKey(e => e.MaLsp);

            entity.ToTable("LoaiSP");

            entity.HasIndex(e => e.MaHienThi, "IX_LoaiSP_MaHT").IsUnique();

            entity.HasIndex(e => e.TenLsp, "UQ_LoaiSP_TenLSP").IsUnique();

            entity.Property(e => e.MaLsp).HasColumnName("MaLSP");
            entity.Property(e => e.MaHienThi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComputedColumnSql("('LSP'+right('00'+CONVERT([varchar](2),[MaLSP]),(2)))", true);
            entity.Property(e => e.TenLsp)
                .HasMaxLength(50)
                .HasColumnName("TenLSP");
        });

        modelBuilder.Entity<NganhHang>(entity =>
        {
            entity.HasKey(e => e.MaNh);

            entity.ToTable("NganhHang");

            entity.Property(e => e.MaNh).HasColumnName("MaNH");
            entity.Property(e => e.MaHienThi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComputedColumnSql("('NH'+right('000'+CONVERT([varchar](3),[MaNH]),(3)))", true);
            entity.Property(e => e.TenNh)
                .HasMaxLength(50)
                .HasColumnName("TenNH");
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.HasKey(e => e.MaNcc);

            entity.ToTable("NhaCungCap");

            entity.HasIndex(e => e.MaNcc, "IX_NhaCungCap_MaHienThi").IsUnique();

            entity.HasIndex(e => e.DiaChi, "UQ_NhaCungCap_DiaChi").IsUnique();

            entity.HasIndex(e => e.Email, "UQ_NhaCungCap_Email").IsUnique();

            entity.HasIndex(e => e.Sdt, "UQ_NhaCungCap_SDT").IsUnique();

            entity.HasIndex(e => e.TenNcc, "UQ_NhaCungCap_TenNCC").IsUnique();

            entity.Property(e => e.MaNcc).HasColumnName("MaNCC");
            entity.Property(e => e.DiaChi).HasMaxLength(200);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaHienThi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComputedColumnSql("('NCC'+right('00'+CONVERT([varchar](2),[MaNCC]),(2)))", true);
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SDT");
            entity.Property(e => e.TenNcc)
                .HasMaxLength(100)
                .HasColumnName("TenNCC");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv);

            entity.ToTable("NhanVien");

            entity.HasIndex(e => e.MaHienThi, "IX_NhanVien_MaHienThi").IsUnique();

            entity.HasIndex(e => e.Cccd, "UQ_NhanVien_CCCD").IsUnique();

            entity.HasIndex(e => e.Sdt, "UQ_NhanVien_SDT").IsUnique();

            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.Cccd)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CCCD");
            entity.Property(e => e.GioiTinh).HasMaxLength(3);
            entity.Property(e => e.MaCv).HasColumnName("MaCV");
            entity.Property(e => e.MaHienThi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComputedColumnSql("('NV'+right('000'+CONVERT([varchar](3),[MaNV]),(3)))", true);
            entity.Property(e => e.MatKhau)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SDT");
            entity.Property(e => e.TenNv)
                .HasMaxLength(100)
                .HasColumnName("TenNV");

            entity.HasOne(d => d.MaCvNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaCv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NhanVien_ChucVu");
        });

        modelBuilder.Entity<PhieuNhap>(entity =>
        {
            entity.HasKey(e => e.MaPn);

            entity.ToTable("PhieuNhap");

            entity.HasIndex(e => e.MaHienThi, "IX_PhieuNhap_MaHT").IsUnique();

            entity.Property(e => e.MaPn).HasColumnName("MaPN");
            entity.Property(e => e.MaHienThi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComputedColumnSql("('PN'+right('000'+CONVERT([varchar](3),[MaPN]),(3)))", true);
            entity.Property(e => e.MaNcc).HasColumnName("MaNCC");
            entity.Property(e => e.MaNvduyet).HasColumnName("MaNVDuyet");
            entity.Property(e => e.MaNvlap).HasColumnName("MaNVLap");
            entity.Property(e => e.NgayDatHang).HasColumnType("datetime");
            entity.Property(e => e.NgayGiao).HasColumnType("datetime");
            entity.Property(e => e.NgayGiaoDuKien)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TongTienPhaiTra).HasColumnType("money");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.MaNccNavigation).WithMany(p => p.PhieuNhaps)
                .HasForeignKey(d => d.MaNcc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhieuNhap_NhaCungCap");

            entity.HasOne(d => d.MaNvduyetNavigation).WithMany(p => p.PhieuNhapMaNvduyetNavigations)
                .HasForeignKey(d => d.MaNvduyet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhieuNhap_NhanVien2");

            entity.HasOne(d => d.MaNvlapNavigation).WithMany(p => p.PhieuNhapMaNvlapNavigations)
                .HasForeignKey(d => d.MaNvlap)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhieuNhap_NhanVien");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSp);

            entity.ToTable("SanPham");

            entity.HasIndex(e => e.MaHienThi, "IX_SanPham_MaHienThi").IsUnique();

            entity.HasIndex(e => e.TenSp, "UQ_SanPham_TenSP").IsUnique();

            entity.Property(e => e.MaSp).HasColumnName("MaSP");
            entity.Property(e => e.GiaGoc).HasColumnType("money");
            entity.Property(e => e.HinhAnh).HasMaxLength(50);
            entity.Property(e => e.MaGgsp).HasColumnName("MaGGSP");
            entity.Property(e => e.MaHienThi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComputedColumnSql("('SP'+right('000'+CONVERT([varchar](3),[MaSP]),(3)))", true);
            entity.Property(e => e.MaLsp).HasColumnName("MaLSP");
            entity.Property(e => e.MaNh).HasColumnName("MaNH");
            entity.Property(e => e.MaTh).HasColumnName("MaTH");
            entity.Property(e => e.TenSp)
                .HasMaxLength(100)
                .HasColumnName("TenSP");

            entity.HasOne(d => d.MaGgspNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaGgsp)
                .HasConstraintName("FK_SanPham_GiamGiaSanPham");

            entity.HasOne(d => d.MaLspNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaLsp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SanPham_LoaiSP");

            entity.HasOne(d => d.MaNhNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaNh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SanPham_NganhHang");

            entity.HasOne(d => d.MaThNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaTh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SanPham_ThuongHieu");
        });

        modelBuilder.Entity<ThuongHieu>(entity =>
        {
            entity.HasKey(e => e.MaTh);

            entity.ToTable("ThuongHieu");

            entity.HasIndex(e => e.MaHienThi, "IX_ThuongHieu_MaHT").IsUnique();

            entity.HasIndex(e => e.TenTh, "UQ_ThuongHieu_TenTH").IsUnique();

            entity.Property(e => e.MaTh).HasColumnName("MaTH");
            entity.Property(e => e.MaHienThi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComputedColumnSql("('TH'+right('000'+CONVERT([varchar](3),[MaTH]),(3)))", true);
            entity.Property(e => e.TenTh)
                .HasMaxLength(50)
                .HasColumnName("TenTH");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
