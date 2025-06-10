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
        IEnumerable<object> GetAllWithDisplay();
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

        public static decimal TinhTienGiam(decimal giaGoc, decimal? phanTramGiam, decimal? soTienGiam)
        {
            if (phanTramGiam == null && soTienGiam == null)
                return 0;

            decimal tienGiamTheoPhanTram = phanTramGiam != null ? giaGoc * (decimal)phanTramGiam.Value / 100 : 0;

            if (phanTramGiam != null && soTienGiam != null)
            {
                return Math.Min(tienGiamTheoPhanTram, soTienGiam.Value);
            }
            else if (phanTramGiam != null)
            {
                return tienGiamTheoPhanTram;
            }
            else // chỉ soTienGiam
            {
                return soTienGiam ?? 0;
            }
        }

        public static string GetTenHienThi(decimal? phanTramGiam, decimal? soTienGiam)
        {
            if (phanTramGiam != null && soTienGiam != null)
                return $"Giảm {phanTramGiam:0.#}% tối đa {soTienGiam:N0}đ";
            if (phanTramGiam != null)
                return $"Giảm {phanTramGiam:0.#}%";
            if (soTienGiam != null)
                return $"Giảm {soTienGiam:N0}đ";
            return null;
        }

        public IEnumerable<object> GetAllWithDisplay()
        {
            var list = _repo.GetAll().ToList(); // Load dữ liệu trước

            var result = list.Select(ggsp => new
            {
                ggsp.MaGgsp,
                ggsp.MaHienThi,
                ggsp.PhanTramGiam,
                ggsp.SoTienGiam,
                TenHienThi = GetTenHienThi(ggsp.PhanTramGiam, ggsp.SoTienGiam)
            }).ToList();

            return result;
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
