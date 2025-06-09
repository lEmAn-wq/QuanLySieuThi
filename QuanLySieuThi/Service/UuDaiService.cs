using QuanLySieuThi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Service
{
    public interface IUuDaiService
    {
        IEnumerable<GiamGiaSanPham> GetAllVouchers();
        GiamGiaSanPham GetByID(int id);
        void CreateVoucher(GiamGiaSanPham uuDai);
        void UpdateVoucher(GiamGiaSanPham uuDai);
        void DeleteVoucher(GiamGiaSanPham uuDai);

    }

    public class UuDaiService : IUuDaiService
    {
        private readonly Repository.IUuDaiRepository _repo;

        public UuDaiService(Repository.IUuDaiRepository repo)
        {
            _repo = repo;
        }
        public GiamGiaSanPham GetByID(int id) 
        {
            return _repo.GetById(id);
        }

        public IEnumerable<GiamGiaSanPham> GetAllVouchers()
        {
            return _repo.GetAll();
        }
        public void CreateVoucher(GiamGiaSanPham uuDai)
        {
            _repo.Add(uuDai);
        }
        public void UpdateVoucher(GiamGiaSanPham uuDai)
        {
            _repo.Update(uuDai);
        }
        public void DeleteVoucher(GiamGiaSanPham uuDai)
        {
            _repo.Delete(uuDai);
        }
    }
}
