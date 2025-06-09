using System.Collections.Generic;
using QuanLySieuThi.Models;
using QuanLySieuThi.Repository;

namespace QuanLySieuThi.Service
{
    public interface INhanVienService
    {
        IEnumerable<NhanVien> GetAll();
        NhanVien GetById(int id);
        void Create(NhanVien nhanVien);
        void Update(NhanVien nhanVien);
        void Delete(NhanVien nhanVien);
    }

    public class NhanVienService : INhanVienService
    {
        private readonly INhanVienRepository _repo;

        public NhanVienService(INhanVienRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<NhanVien> GetAll()
        {
            return _repo.GetAll();
        }

        public NhanVien GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Create(NhanVien nhanVien)
        {
            _repo.Add(nhanVien);
        }

        public void Update(NhanVien nhanVien)
        {
            _repo.Update(nhanVien);
        }

        public void Delete(NhanVien nhanVien)
        {
            _repo.Delete(nhanVien);
        }
    }
}
