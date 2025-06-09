using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLySieuThi.Models;

namespace QuanLySieuThi.Repository
{
    public interface IChiTietPhieuNhapRepository
    {
        IEnumerable<ChiTietPhieuNhap> GetAll();
        ChiTietPhieuNhap GetById(int id);

        void Add(ChiTietPhieuNhap chiTietPhieuNhap);
        void Update(ChiTietPhieuNhap chiTietPhieuNhap);
    }

    public class ChiTietPhieuNhapRepository : IChiTietPhieuNhapRepository
    {
        private readonly QlsieuThiContext _context;

        public ChiTietPhieuNhapRepository(QlsieuThiContext context)
        {
            _context = context;
        }

        public IEnumerable<ChiTietPhieuNhap> GetAll()
        {
            return _context.ChiTietPhieuNhaps
                .Include(ctpn => ctpn.MaPnNavigation)
                .Include(ctpn => ctpn.MaSpNavigation)
                .ToList();
        }

        public ChiTietPhieuNhap GetById(int id)
        {
            return _context.ChiTietPhieuNhaps
                .Include(ctpn => ctpn.MaPnNavigation)
                .Include(ctpn => ctpn.MaSpNavigation)
                .FirstOrDefault(ctpn => ctpn.MaPn == id);
        }

        public void Add(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            _context.ChiTietPhieuNhaps.Add(chiTietPhieuNhap);
            _context.SaveChanges();
        }

        public void Update(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            _context.ChiTietPhieuNhaps.Update(chiTietPhieuNhap);
            _context.SaveChanges();
        }
    }
}
