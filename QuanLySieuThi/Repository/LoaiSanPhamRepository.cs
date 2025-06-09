using System.Collections.Generic;
using System.Linq;
using QuanLySieuThi.Models;

namespace QuanLySieuThi.Repository
{
    public interface ILoaiSanPhamRepository
    {
        IEnumerable<LoaiSp> GetAll();
        LoaiSp GetById(int id);                 // thêm
        void Add(LoaiSp loaiSanPham);
        void Update(LoaiSp loaiSanPham);
        void Delete(LoaiSp loaiSanPham);        // thêm
    }

    public class LoaiSanPhamRepository : ILoaiSanPhamRepository
    {
        private readonly QlsieuThiContext _context;

        public LoaiSanPhamRepository(QlsieuThiContext context)
        {
            _context = context;
        }

        public IEnumerable<LoaiSp> GetAll()
        {
            return _context.LoaiSps
                .OrderByDescending(l => l.MaLsp)
                .ToList();
        }

        public LoaiSp GetById(int id)  // thêm
        {
            return _context.LoaiSps.Find(id);
        }

        public void Add(LoaiSp loaiSanPham)
        {
            _context.LoaiSps.Add(loaiSanPham);
            _context.SaveChanges();
        }

        public void Update(LoaiSp loaiSanPham)
        {
            _context.LoaiSps.Update(loaiSanPham);
            _context.SaveChanges();
        }

        public void Delete(LoaiSp loaiSanPham)  // thêm
        {
            _context.LoaiSps.Remove(loaiSanPham);
            _context.SaveChanges();
        }
    }
}
