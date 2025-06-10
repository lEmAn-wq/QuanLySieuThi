using System.Collections.Generic;
using QuanLySieuThi.Models;
using QuanLySieuThi.Repository;

namespace QuanLySieuThi.Service
{
    public interface INhanVienService
    {
        IEnumerable<NhanVien> GetAll();
        NhanVien GetById(int id);
        Object GetNhanVienView();
        void Create(NhanVien nhanVien);
        void Update(NhanVien nhanVien);
        void Delete(NhanVien nhanVien);
        NhanVien GetById_Pass(string maHienThi, string password);
    }

    public class NhanVienService : INhanVienService
    {
        private readonly INhanVienRepository _repo;

        public NhanVienService(INhanVienRepository repo)
        {
            _repo = repo;
        }

        public NhanVien GetById_Pass(string maHienThi, string password)
        {
            return _repo.GetById_Pass(maHienThi, password);
        }
        public IEnumerable<NhanVien> GetAll()
        {
            return _repo.GetAll();
        }

        public Object GetNhanVienView()
        {
            return _repo.GetNhanVienView();
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
