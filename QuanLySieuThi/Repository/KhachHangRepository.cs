using System.Collections.Generic;
using System.Linq;
using QuanLySieuThi.Models;

namespace QuanLySieuThi.Repository
{
    public interface IKhachHangRepository
    {
        IEnumerable<KhachHang> GetAll();
        KhachHang GetById(int id);
        KhachHang GetByMaHienThi(string maHienThi); 
        void Add(KhachHang khachHang);
        void Update(KhachHang khachHang);
        void Delete(KhachHang khachHang);    // thêm
    }

    public class KhachHangRepository : IKhachHangRepository
    {
        private readonly QlsieuThiContext _context;

        public KhachHangRepository(QlsieuThiContext context)
        {
            _context = context;
        }
        public KhachHang GetByMaHienThi(string maHienThi)
        {
            return _context.KhachHangs.FirstOrDefault(k => k.MaHienThi == maHienThi);
        }

        public IEnumerable<KhachHang> GetAll()
        {
            return _context.KhachHangs
                .OrderByDescending(k => k.MaKh)
                .ToList();
        }

        public KhachHang GetById(int id)
        {
            return _context.KhachHangs.Find(id);
        }

        public void Add(KhachHang khachHang)
        {
            _context.KhachHangs.Add(khachHang);
            _context.SaveChanges();
        }

        public void Update(KhachHang khachHang)
        {
            _context.KhachHangs.Update(khachHang);
            _context.SaveChanges();
        }

        public void Delete(KhachHang khachHang)
        {
            _context.KhachHangs.Remove(khachHang);
            _context.SaveChanges();
        }
    }
}
