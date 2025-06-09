using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLySieuThi.Models;

namespace QuanLySieuThi.Repository
{
    public interface IHoaDonRepository
    {
        IEnumerable<HoaDon> GetAll();
        HoaDon GetById(int id);    // thêm
        void Add(HoaDon hoaDon);
        void Update(HoaDon hoaDon);
    }

    public class HoaDonRepository : IHoaDonRepository
    {
        private readonly QlsieuThiContext _context;

        public HoaDonRepository(QlsieuThiContext context)
        {
            _context = context;
        }

        public IEnumerable<HoaDon> GetAll()
        {
            return _context.HoaDons
                .Include(hd => hd.MaKhNavigation)
                .Include(hd => hd.MaNvNavigation)
                .OrderByDescending(hd => hd.MaHd)
                .ToList();
        }

        public HoaDon GetById(int id)
        {
            return _context.HoaDons
                .Include(hd => hd.MaKhNavigation)
                .Include(hd => hd.MaNvNavigation)
                .FirstOrDefault(hd => hd.MaHd == id);
        }

        public void Add(HoaDon hoaDon)
        {
            _context.HoaDons.Add(hoaDon);
            _context.SaveChanges();
        }

        public void Update(HoaDon hoaDon)
        {
            _context.HoaDons.Update(hoaDon);
            _context.SaveChanges();
        }
    }
}
