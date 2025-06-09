using QuanLySieuThi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Repository
{
    // Repository cho Thương hiệu
    public interface IThuongHieuRepository
    {
        IEnumerable<ThuongHieu> GetAll();
        ThuongHieu GetById(int id);
        void Delete(ThuongHieu thuongHieu);      
        void Add(ThuongHieu thuongHieu);
        void Update(ThuongHieu thuongHieu);
    }

    public class ThuongHieuRepository : IThuongHieuRepository
    {
        private readonly QlsieuThiContext _context;

        public ThuongHieuRepository(QlsieuThiContext context)
        {
            _context = context;
        }

        public IEnumerable<ThuongHieu> GetAll()
        {
            return _context.ThuongHieus
                .OrderByDescending(t => t.MaTh)
                .ToList();
        }

        public ThuongHieu GetById(int id)  // thêm
        {
            return _context.ThuongHieus.Find(id);
        }

        public void Add(ThuongHieu thuongHieu)
        {
            _context.ThuongHieus.Add(thuongHieu);
            _context.SaveChanges();
        }

        public void Update(ThuongHieu thuongHieu)
        {
            _context.ThuongHieus.Update(thuongHieu);
            _context.SaveChanges();
        }

        public void Delete(ThuongHieu thuongHieu)  // thêm
        {
            _context.ThuongHieus.Remove(thuongHieu);
            _context.SaveChanges();
        }
    }
}
