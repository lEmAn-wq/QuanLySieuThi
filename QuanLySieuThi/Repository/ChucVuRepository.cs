using System.Collections.Generic;
using System.Linq;
using QuanLySieuThi.Models;

namespace QuanLySieuThi.Repository
{
    public interface IChucVuRepository
    {
        IEnumerable<ChucVu> GetAll();
        ChucVu GetById(int id);         // thêm
        void Add(ChucVu chucVu);
        void Update(ChucVu chucVu);
        void Delete(ChucVu chucVu);     // thêm
    }

    public class ChucVuRepository : IChucVuRepository
    {
        private readonly QlsieuThiContext _context;

        public ChucVuRepository(QlsieuThiContext context)
        {
            _context = context;
        }

        public IEnumerable<ChucVu> GetAll()
        {
            return _context.ChucVus
                .OrderByDescending(c => c.MaCv)
                .ToList();
        }

        public ChucVu GetById(int id)  // thêm
        {
            return _context.ChucVus.Find(id);
        }

        public void Add(ChucVu chucVu)
        {
            _context.ChucVus.Add(chucVu);
            _context.SaveChanges();
        }

        public void Update(ChucVu chucVu)
        {
            _context.ChucVus.Update(chucVu);
            _context.SaveChanges();
        }

        public void Delete(ChucVu chucVu)  // thêm
        {
            _context.ChucVus.Remove(chucVu);
            _context.SaveChanges();
        }
    }
}
