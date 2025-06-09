using System.Collections.Generic;
using QuanLySieuThi.Models;
using QuanLySieuThi.Repository;

namespace QuanLySieuThi.Service
{
    public interface INganhHangService
    {
        IEnumerable<NganhHang> GetAll();
        NganhHang GetById(int id);
        void Create(NganhHang nganhHang);
        void Update(NganhHang nganhHang);
        void Delete(NganhHang nganhHang);
    }

    public class NganhHangService : INganhHangService
    {
        private readonly INganhHangRepository _repo;

        public NganhHangService(INganhHangRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<NganhHang> GetAll()
        {
            return _repo.GetAll();
        }

        public NganhHang GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Create(NganhHang nganhHang)
        {
            _repo.Add(nganhHang);
        }

        public void Update(NganhHang nganhHang)
        {
            _repo.Update(nganhHang);
        }

        public void Delete(NganhHang nganhHang)
        {
            _repo.Delete(nganhHang);
        }
    }
}
