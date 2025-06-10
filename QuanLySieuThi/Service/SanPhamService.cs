using System.Collections.Generic;
using QuanLySieuThi.Models;
using QuanLySieuThi.Repository;

namespace QuanLySieuThi.Service
{
    public interface ISanPhamService
    {
        IEnumerable<SanPham> GetAll();
        SanPham GetById(int id);
        void Create(SanPham sanPham);
        void Update(SanPham sanPham);
        void Delete(SanPham sanPham);
         SanPham GetByMaHienThi(string maHienThi); // thêm
    }

    public class SanPhamService : ISanPhamService
    {
        private readonly ISanPhamRepository _repo;

        public SanPhamService(ISanPhamRepository repo)
        {
            _repo = repo;
        }

        public SanPham GetByMaHienThi(string maHienThi)
        {
            return _repo.GetByMaHienThi(maHienThi);
        }

        public IEnumerable<SanPham> GetAll()
        {
            return _repo.GetAll();
        }

        public SanPham GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Create(SanPham sanPham)
        {
            _repo.Add(sanPham);
        }

        public void Update(SanPham sanPham)
        {
            _repo.Update(sanPham);
        }

        public void Delete(SanPham sanPham)
        {
            _repo.Delete(sanPham);
        }
    }
}
