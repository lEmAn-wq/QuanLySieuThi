using QuanLySieuThi.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuanLySieuThi.Repository
{
    // Repository cho Nhà cung cấp
    public interface INhaCungCapRepository
    {
        IEnumerable<NhaCungCap> GetAll();
        NhaCungCap GetById(int id);                // thêm
        void Add(NhaCungCap nhaCungCap);
        void Update(NhaCungCap nhaCungCap);
        void Delete(NhaCungCap nhaCungCap);        // thêm
    }

    public class NhaCungCapRepository : INhaCungCapRepository
    {
        private readonly QlsieuThiContext _context;

        public NhaCungCapRepository(QlsieuThiContext context)
        {
            _context = context;
        }

        public IEnumerable<NhaCungCap> GetAll()
        {
            return _context.NhaCungCaps
                .OrderByDescending(n => n.MaNcc)
                .ToList();
        }

        public NhaCungCap GetById(int id)
        {
            return _context.NhaCungCaps.Find(id);
        }

        public void Add(NhaCungCap nhaCungCap)
        {
            _context.NhaCungCaps.Add(nhaCungCap);
            _context.SaveChanges();
        }

        public void Update(NhaCungCap nhaCungCap)
        {
            _context.NhaCungCaps.Update(nhaCungCap);
            _context.SaveChanges();
        }

        public void Delete(NhaCungCap nhaCungCap)
        {
            _context.NhaCungCaps.Remove(nhaCungCap);
            _context.SaveChanges();
        }
    }
}
