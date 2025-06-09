using System.Collections.Generic;
using QuanLySieuThi.Models;
using QuanLySieuThi.Repository;

namespace QuanLySieuThi.Service
{
    public interface IKhachHangService
    {
        IEnumerable<KhachHang> GetAll();
        KhachHang GetById(int id);
        void Create(KhachHang khachHang);
        void Update(KhachHang khachHang);
        void Delete(KhachHang khachHang);
    }

    public class KhachHangService : IKhachHangService
    {
        private readonly IKhachHangRepository _repo;

        public KhachHangService(IKhachHangRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<KhachHang> GetAll()
        {
            return _repo.GetAll();
        }

        public KhachHang GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Create(KhachHang khachHang)
        {
            _repo.Add(khachHang);
        }

        public void Update(KhachHang khachHang)
        {
            _repo.Update(khachHang);
        }

        public void Delete(KhachHang khachHang)
        {
            _repo.Delete(khachHang);
        }
    }
}
