using System.Collections.Generic;
using QuanLySieuThi.Models;
using QuanLySieuThi.Repository;

namespace QuanLySieuThi.Service
{
    public interface ILoaiSanPhamService
    {
        IEnumerable<LoaiSp> GetAll();
        LoaiSp GetById(int id);
        void Create(LoaiSp loaiSanPham);
        void Update(LoaiSp loaiSanPham);
        void Delete(LoaiSp loaiSanPham);
    }

    public class LoaiSanPhamService : ILoaiSanPhamService
    {
        private readonly ILoaiSanPhamRepository _repo;

        public LoaiSanPhamService(ILoaiSanPhamRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<LoaiSp> GetAll()
        {
            return _repo.GetAll();
        }

        public LoaiSp GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Create(LoaiSp loaiSanPham)
        {
            _repo.Add(loaiSanPham);
        }

        public void Update(LoaiSp loaiSanPham)
        {
            _repo.Update(loaiSanPham);
        }

        public void Delete(LoaiSp loaiSanPham)
        {
            _repo.Delete(loaiSanPham);
        }
    }
}
