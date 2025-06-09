using System.Collections.Generic;
using QuanLySieuThi.Models;
using QuanLySieuThi.Repository;

namespace QuanLySieuThi.Service
{
    public interface IChucVuService
    {
        IEnumerable<ChucVu> GetAll();
        ChucVu GetById(int id);
        void Create(ChucVu chucVu);
        void Update(ChucVu chucVu);
        void Delete(ChucVu chucVu);
    }

    public class ChucVuService : IChucVuService
    {
        private readonly IChucVuRepository _repo;

        public ChucVuService(IChucVuRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<ChucVu> GetAll()
        {
            return _repo.GetAll();
        }

        public ChucVu GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Create(ChucVu chucVu)
        {
            _repo.Add(chucVu);
        }

        public void Update(ChucVu chucVu)
        {
            _repo.Update(chucVu);
        }

        public void Delete(ChucVu chucVu)
        {
            _repo.Delete(chucVu);
        }
    }
}
