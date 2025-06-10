using Microsoft.EntityFrameworkCore;
using QuanLySieuThi.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuanLySieuThi.Repository
{
    // Repository cho Nhân viên  
    public interface INhanVienRepository
    {
        IEnumerable<NhanVien> GetAll();
        NhanVien GetById(int id);
        void Add(NhanVien nhanVien);
        void Update(NhanVien nhanVien);
        void Delete(NhanVien nhanVien);
        IEnumerable<object> GetNhanVienView();
        NhanVien GetById_Pass(string maHienThi, string password);
    }
    public class NhanVienRepository : INhanVienRepository
    {
        private readonly QlsieuThiContext _context;

        public NhanVienRepository(QlsieuThiContext context)
        {
            _context = context;
        }

        public NhanVien GetById_Pass(string maHienThi, string password)
        {
            return _context.NhanViens
                .Include(nv => nv.MaCvNavigation) // Tải dữ liệu ChucVu
              .FirstOrDefault(nv => nv.MaHienThi == maHienThi && nv.MatKhau == password);
        }


        public IEnumerable<object> GetNhanVienView()
        {
            return _context.NhanViens
                .OrderByDescending(nv => nv.MaNv)
                 .Include(nv => nv.MaCvNavigation)
                 .Where(nv => nv.DaXoa != true)
                 .Select(nv => new
                 {
                     nv.MaNv,
                     nv.MaHienThi,
                     nv.TenNv,
                     nv.GioiTinh,
                     nv.NgaySinh,
                     nv.Sdt,
                     nv.Cccd,
                     ChucVu = nv.MaCvNavigation.TenCv
                 }).ToList();
        }
        public IEnumerable<NhanVien> GetAll()
        {
            return _context.NhanViens
                .Include(nv => nv.MaCvNavigation)
                .OrderByDescending(nv => nv.MaNv)
                .ToList();
        }

        public NhanVien GetById(int id)
        {
            return _context.NhanViens
                .Include(nv => nv.MaCvNavigation)
                .FirstOrDefault(nv => nv.MaNv == id);
        }

        public void Add(NhanVien nhanVien)
        {
            _context.NhanViens.Add(nhanVien);
            _context.SaveChanges();
        }

        public void Update(NhanVien nhanVien)
        {
            _context.NhanViens.Update(nhanVien);
            _context.SaveChanges();
        }

        public void Delete(NhanVien nhanVien)
        {
            _context.NhanViens.Remove(nhanVien);
            _context.SaveChanges();
        }
    }
}