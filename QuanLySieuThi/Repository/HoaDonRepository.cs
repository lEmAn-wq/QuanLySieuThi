using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLySieuThi.Models;

namespace QuanLySieuThi.Repository
{
    public interface IHoaDonRepository
    {
        IEnumerable<HoaDon> GetAll();
        HoaDon GetById(int id);
        IEnumerable<ChiTietHoaDon> GetChiTietHoaDon(int hoaDonId); // Thêm
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
                .Include(hd => hd.ChiTietHoaDons)
                    .ThenInclude(ct => ct.MaSpNavigation) // Bao gồm thông tin sản phẩm
                .Include(hd => hd.DoiTraHangs)
                     .ThenInclude(dt => dt.ChiTietDoiTraHangs) // Bao gồm thông tin sản phẩm trong đổi trả
                           .ThenInclude(ct => ct.MaSpNavigation) // Bao gồm thông tin sản phẩm
                .OrderByDescending(hd => hd.MaHd)
                .ToList();
        }

        public HoaDon GetById(int id)
        {
            return _context.HoaDons
                .Include(hd => hd.MaKhNavigation)
                .Include(hd => hd.MaNvNavigation)
                .Include(hd => hd.ChiTietHoaDons)
                    .ThenInclude(ct => ct.MaSpNavigation) // Bao gồm thông tin sản phẩm
                .FirstOrDefault(hd => hd.MaHd == id);
        }

        public IEnumerable<ChiTietHoaDon> GetChiTietHoaDon(int hoaDonId)
        {
            return _context.ChiTietHoaDons
                .Include(ct => ct.MaSpNavigation) // Bao gồm thông tin sản phẩm
                .Where(ct => ct.MaHd == hoaDonId)
                .ToList();
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
