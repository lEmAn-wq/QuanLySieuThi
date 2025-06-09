// Repository cho Ngành hàng
using QuanLySieuThi.Models;

namespace QuanLySieuThi.Repository
{
    public interface INganhHangRepository
    {
        IEnumerable<NganhHang> GetAll();
        NganhHang GetById(int id);
        void Delete(NganhHang nganhHang);
        void Add(NganhHang nganhHang);
        void Update(NganhHang nganhHang);
    }

    public class NganhHangRepository : INganhHangRepository
    {
        private readonly QlsieuThiContext _context;

        public NganhHangRepository(QlsieuThiContext context)
        {
            _context = context;
        }

        public IEnumerable<NganhHang> GetAll()
        {
            return _context.NganhHangs
                .OrderByDescending(n => n.MaNh)
                .ToList();
        }

        public NganhHang GetById(int id)  // thêm
        {
            return _context.NganhHangs.Find(id);
        }

        public void Add(NganhHang nganhHang)
        {
            _context.NganhHangs.Add(nganhHang);
            _context.SaveChanges();
        }

        public void Update(NganhHang nganhHang)
        {
            _context.NganhHangs.Update(nganhHang);
            _context.SaveChanges();
        }

        public void Delete(NganhHang nganhHang)  // thêm
        {
            _context.NganhHangs.Remove(nganhHang);
            _context.SaveChanges();
        }
    }
}
