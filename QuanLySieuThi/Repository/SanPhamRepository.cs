using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLySieuThi.Models;

namespace QuanLySieuThi.Repository
{
    public interface ISanPhamRepository
    {
        IEnumerable<SanPham> GetAll();
        SanPham GetById(int id);        // thêm
        void Add(SanPham sanPham);
        void Update(SanPham sanPham);
        void Delete(SanPham sanPham);   // thêm
    }

    public class SanPhamRepository : ISanPhamRepository
    {
        private readonly QlsieuThiContext _context;

        public SanPhamRepository(QlsieuThiContext context)
        {
            _context = context;
        }

        public IEnumerable<SanPham> GetAll()
        {
            return _context.SanPhams
                .Include(sp => sp.MaGgspNavigation)
                .Include(sp => sp.MaLspNavigation)
                .Include(sp => sp.MaNhNavigation)
                .Include(sp => sp.MaThNavigation)
                .OrderByDescending(sp => sp.MaSp)
                .ToList();
        }

        public SanPham GetById(int id)
        {
            return _context.SanPhams
                .Include(sp => sp.MaGgspNavigation)
                .Include(sp => sp.MaLspNavigation)
                .Include(sp => sp.MaNhNavigation)
                .Include(sp => sp.MaThNavigation)
                .FirstOrDefault(sp => sp.MaSp == id);
        }

        public void Add(SanPham sanPham)
        {
            _context.SanPhams.Add(sanPham);
            _context.SaveChanges();
        }

        public void Update(SanPham sanPham)
        {
            _context.SanPhams.Update(sanPham);
            _context.SaveChanges();
        }

        public void Delete(SanPham sanPham)
        {
            _context.SanPhams.Remove(sanPham);
            _context.SaveChanges();
        }
    }
}
