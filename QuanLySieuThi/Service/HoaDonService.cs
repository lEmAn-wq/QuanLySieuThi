using System.Collections.Generic;
using QuanLySieuThi.Models;
using QuanLySieuThi.Repository;

namespace QuanLySieuThi.Service
{
    public interface IHoaDonService
    {
        IEnumerable<HoaDon> GetAll();
        HoaDon GetById(int id);
        void Create(HoaDon hoaDon);
        void Update(HoaDon hoaDon);
    }

    public class HoaDonService : IHoaDonService
    {
        private readonly IHoaDonRepository _repo;

        public HoaDonService(IHoaDonRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<HoaDon> GetAll()
        {
            return _repo.GetAll();
        }

        public HoaDon GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Create(HoaDon hoaDon)
        {
            _repo.Add(hoaDon);
        }

        public void Update(HoaDon hoaDon)
        {
            _repo.Update(hoaDon);
        }
    }
}
