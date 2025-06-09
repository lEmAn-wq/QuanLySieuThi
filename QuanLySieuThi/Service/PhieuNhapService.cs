using System.Collections.Generic;
using QuanLySieuThi.Models;
using QuanLySieuThi.Repository;

namespace QuanLySieuThi.Service
{
    public interface IChiTietPhieuNhapService
    {
        IEnumerable<ChiTietPhieuNhap> GetAll();
        ChiTietPhieuNhap GetById(int id);
        void Create(ChiTietPhieuNhap chiTietPhieuNhap);
        void Update(ChiTietPhieuNhap chiTietPhieuNhap);
    }

    public class ChiTietPhieuNhapService : IChiTietPhieuNhapService
    {
        private readonly IChiTietPhieuNhapRepository _repo;

        public ChiTietPhieuNhapService(IChiTietPhieuNhapRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<ChiTietPhieuNhap> GetAll()
        {
            return _repo.GetAll();
        }

        public ChiTietPhieuNhap GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Create(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            _repo.Add(chiTietPhieuNhap);
        }

        public void Update(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            _repo.Update(chiTietPhieuNhap);
        }
    }
}
