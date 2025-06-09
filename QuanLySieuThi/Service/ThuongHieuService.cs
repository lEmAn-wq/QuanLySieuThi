using QuanLySieuThi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Service
{
    public interface IThuongHieuService
    {
        IEnumerable<ThuongHieu> GetAllBrands();
        ThuongHieu GetByID(int id);
        void CreateBrand(ThuongHieu thuongHieu);
        void UpdateBrand(ThuongHieu thuongHieu);
        void DeleteBrand(ThuongHieu thuongHieu);
    }

    public class ThuongHieuService : IThuongHieuService
    {
        private readonly Repository.IThuongHieuRepository _repo;

        public ThuongHieuService(Repository.IThuongHieuRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<ThuongHieu> GetAllBrands()
        {
            return _repo.GetAll();
        }

        public ThuongHieu GetByID(int id)
        {
            return _repo.GetById(id);
        }

        public void CreateBrand(ThuongHieu thuongHieu)
        {
            _repo.Add(thuongHieu);
        }

        public void UpdateBrand(ThuongHieu thuongHieu)
        {
            _repo.Update(thuongHieu);
        }

        public void DeleteBrand(ThuongHieu thuongHieu)
        {
            _repo.Delete(thuongHieu);
        }
    }
}
