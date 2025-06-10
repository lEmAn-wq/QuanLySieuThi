using System.Collections.Generic;
using QuanLySieuThi.Models;
using QuanLySieuThi.Repository;

namespace QuanLySieuThi.Service
{
    public interface INhaCungCapService
    {
        IEnumerable<NhaCungCap> GetAll();
        NhaCungCap GetById(int id);
        void Create(NhaCungCap nhaCungCap);
        void Update(NhaCungCap nhaCungCap);
        void Delete(NhaCungCap nhaCungCap);
        NhaCungCap GetByMaHienThi(string maHienThi);
    }

    public class NhaCungCapService : INhaCungCapService
    {
        private readonly INhaCungCapRepository _repo;

        public NhaCungCapService(INhaCungCapRepository repo)
        {
            _repo = repo;
        }

        public NhaCungCap GetByMaHienThi(string maHienThi)
        {
            return _repo.GetByMaHienThi(maHienThi);
        }

        public IEnumerable<NhaCungCap> GetAll()
        {
            return _repo.GetAll();
        }

        public NhaCungCap GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Create(NhaCungCap nhaCungCap)
        {
            _repo.Add(nhaCungCap);
        }

        public void Update(NhaCungCap nhaCungCap)
        {
            _repo.Update(nhaCungCap);
        }

        public void Delete(NhaCungCap nhaCungCap)
        {
            _repo.Delete(nhaCungCap);
        }
    }
}
