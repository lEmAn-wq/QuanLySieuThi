using QuanLySieuThi.Models;
using Stimulsoft.Blockly.Model;
using System.Collections.Generic;
using System.Linq;

namespace QuanLySieuThi.Repository
{
    // Repository cho Nhà cung cấp
    public interface INhaCungCapRepository
    {
        IEnumerable<NhaCungCap> GetAll();
        NhaCungCap GetById(int id);
        void Add(NhaCungCap nhaCungCap);
        void Update(NhaCungCap nhaCungCap);
        void Delete(NhaCungCap nhaCungCap);
        NhaCungCap GetByMaHienThi(string maHienThi);
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
        public NhaCungCap GetByMaHienThi(string maHienThi)
        {
            return _context.NhaCungCaps.FirstOrDefault(n => n.MaHienThi == maHienThi);
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
