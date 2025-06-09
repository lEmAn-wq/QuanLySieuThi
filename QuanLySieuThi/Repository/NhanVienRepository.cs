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
        NhanVien GetById(int id);                 // thêm
        void Add(NhanVien nhanVien);
        void Update(NhanVien nhanVien);
        void Delete(NhanVien nhanVien);           // thêm
    }

    public class NhanVienRepository : INhanVienRepository
    {
        private readonly QlsieuThiContext _context;

        public NhanVienRepository(QlsieuThiContext context)
        {
            _context = context;
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
