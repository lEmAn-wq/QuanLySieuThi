using Microsoft.EntityFrameworkCore;
using QuanLySieuThi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Repository
{
    // Repository cho Ưu đãi (Giảm giá sản phẩm)
    public interface IUuDaiRepository
    {
        IEnumerable<GiamGiaSanPham> GetAll();
        GiamGiaSanPham GetById(int id);   // lấy
        void Add(GiamGiaSanPham uuDai);
        void Update(GiamGiaSanPham uuDai);
        void Delete(GiamGiaSanPham uuDai);
    }

    public class UuDaiRepository : IUuDaiRepository
    {
        private readonly QlsieuThiContext _context;

        public UuDaiRepository(QlsieuThiContext context)
        {
            _context = context;
        }

        public GiamGiaSanPham GetById(int id)
        {
            return _context.GiamGiaSanPhams.Find(id);
        }

        public IEnumerable<GiamGiaSanPham> GetAll()
        {
            return _context.GiamGiaSanPhams
                .OrderByDescending(g => g.MaGgsp)
                .ToList();
        }

        public void Add(GiamGiaSanPham uuDai)
        {
            _context.GiamGiaSanPhams.Add(uuDai);
            _context.SaveChanges();
        }

        public void Update(GiamGiaSanPham uuDai)
        {
            _context.GiamGiaSanPhams.Update(uuDai);
            _context.SaveChanges();
        }
        public void Delete(GiamGiaSanPham uuDai)
        {
            _context.GiamGiaSanPhams.Remove(uuDai);
            _context.SaveChanges();
        }
    }
}
