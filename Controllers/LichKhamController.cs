using DACN_Quan_Ly_Kham_Chua_Benh.Data;
using DACN_Quan_Ly_Kham_Chua_Benh.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DACN_Quan_Ly_Kham_Chua_Benh.ViewModel;

namespace DACN_Quan_Ly_Kham_Chua_Benh.Controllers
{
    public class LichKhamController : Controller
    {
        private readonly DBContext _context;
        public LichKhamController(DBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var query = _context.LichKham.ToList();
            return View(query);
        }

        [HttpGet]
        public IActionResult SearchLichBacSi(string? maBacSi, DateTime? ngayTimKiem, int page = 1)
        {
            var lstBacSi = _context.BacSi.Where(o => o.TrangThai == 1).ToList();
            ViewBag.BacSi = lstBacSi;

            ViewBag.SelectedBacSi = maBacSi;

            //ViewBag.SelectedNgayTimKiem = ngayTimKiem?.ToString("dd-MM-yyyy");

            var query = from lk in _context.LichKham
                        join bs in _context.BacSi on lk.idBacSi equals bs.idBacSi
                        join bn in _context.BenhNhan on lk.idBenhNhan equals bn.idBenhNhan into bnGroup
                        from bn in bnGroup.DefaultIfEmpty()
                        join pk in _context.PhongKham on lk.idPhongKham equals pk.idPhongKham
                        select new LichKhamViewModel()
                        {
                            MaLK = lk.MaLK,
                            KetQua = lk != null ? lk.KetQua : "",
                            ThoiGianBatDau = (DateTime)lk.ThoiGianBatDau,
                            ThoiGianKetThuc = (DateTime)lk.ThoiGianKetThuc,
                            TrangThai = lk.TrangThai,
                            MaBN = bn.MaBN != null ? bn.MaBN : "",
                            TenBN = bn.TenBN != null ? bn.TenBN : "",
                            SDT = bn.SDT != null ? bn.SDT : "",
                            TenBS = bs.TenBS,
                            MaPhongKham = pk.MaPhongKham,
                            GhiChu = lk.GhiChu != null ? lk.GhiChu : "",
                            ThanhTien = lk.ThanhTien != null ? lk.ThanhTien : 0,
                            MaBS = bs.MaBS
                        };
            if (!string.IsNullOrEmpty(maBacSi) && ngayTimKiem == null)
            {
                query = query.Where(lk => lk.MaBS.Contains(maBacSi));
            }

            if (ngayTimKiem.HasValue && maBacSi == null)
            {
                DateTime ngayBatDau = ngayTimKiem.Value.Date;
                DateTime ngayKetThuc = ngayBatDau.AddDays(1).AddTicks(-1);
                query = query.Where(lk => lk.ThoiGianBatDau >= ngayBatDau && lk.ThoiGianBatDau <= ngayKetThuc);
            }
            if (!string.IsNullOrEmpty(maBacSi) && ngayTimKiem.HasValue)
            {
                DateTime ngayBatDau = ngayTimKiem.Value.Date;
                DateTime ngayKetThuc = ngayBatDau.AddDays(1).AddTicks(-1);
                query = query.Where(lk => lk.MaBS == maBacSi && lk.ThoiGianBatDau >= ngayBatDau && lk.ThoiGianBatDau <= ngayKetThuc);
            }
            var result = query.ToList();
            ViewBag.Length = result.Count();

            int numberRecord = 7;
            int numberPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(result.Count) / Convert.ToDouble(numberRecord)));
            int soSkip = (page - 1) * numberRecord;
            ViewBag.Page = page;
            ViewBag.PageNumber = numberPage;
            result = result.Skip(soSkip).Take(numberRecord).ToList();
            return View(result);
        }
        public IActionResult RefreshLichBacSi()
        {
            return RedirectToAction("SearchLichBacSi");
        }


        [HttpGet]
        public IActionResult SearchLichBenhNhan(string? Sdt, DateTime? ngayTimKiem, int page = 1)
        {
            //var lstBacSi = _context.BacSi.Where(o => o.TrangThai == 1).ToList();
            //ViewBag.BacSi = lstBacSi;

            ViewBag.SelectedBenhNhan = Sdt;            
            string SdtTemp = Sdt?.Trim();

            //ViewBag.SelectedNgayTimKiem = ngayTimKiem?.ToString("dd-MM-yyyy");

            var query = from lk in _context.LichKham
                        join bn in _context.BenhNhan on lk.idBenhNhan equals bn.idBenhNhan
                        join bs in _context.BacSi on lk.idBacSi equals bs.idBacSi
                        join pk in _context.PhongKham on lk.idPhongKham equals pk.idPhongKham
                        select new LichKhamViewModel()
                        {
                            MaLK = lk.MaLK,
                            KetQua = lk != null ? lk.KetQua : "",
                            ThoiGianBatDau = (DateTime)lk.ThoiGianBatDau,
                            ThoiGianKetThuc = (DateTime)lk.ThoiGianKetThuc,
                            TrangThai = lk.TrangThai,
                            MaBN =  bn.MaBN ,
                            TenBN = bn.TenBN,
                            SDT = bn.SDT,
                            TenBS = bs.TenBS,
                            MaPhongKham = pk.MaPhongKham,
                            GhiChu = lk.GhiChu != null ? lk.GhiChu : "",
                            ThanhTien = lk.ThanhTien != null ? lk.ThanhTien : 0,
                            MaBS = bs.MaBS
                        };
            if (!string.IsNullOrEmpty(SdtTemp) && ngayTimKiem == null)
            {
                query = query.Where(lk => lk.SDT.Contains(SdtTemp));
            }

            if (ngayTimKiem.HasValue && SdtTemp == null)
            {
                DateTime ngayBatDau = ngayTimKiem.Value.Date;
                DateTime ngayKetThuc = ngayBatDau.AddDays(1).AddTicks(-1);
                query = query.Where(lk => lk.ThoiGianBatDau >= ngayBatDau && lk.ThoiGianBatDau <= ngayKetThuc);
            }
            if (!string.IsNullOrEmpty(SdtTemp) && ngayTimKiem.HasValue)
            {
                DateTime ngayBatDau = ngayTimKiem.Value.Date;
                DateTime ngayKetThuc = ngayBatDau.AddDays(1).AddTicks(-1);
                query = query.Where(lk => lk.SDT == SdtTemp && lk.ThoiGianBatDau >= ngayBatDau && lk.ThoiGianBatDau <= ngayKetThuc);
            }
            var result = query.ToList();
            ViewBag.Length = result.Count();

            int numberRecord = 7;
            int numberPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(result.Count) / Convert.ToDouble(numberRecord)));
            int soSkip = (page - 1) * numberRecord;
            ViewBag.Page = page;
            ViewBag.PageNumber = numberPage;
            result = result.Skip(soSkip).Take(numberRecord).ToList();
            return View(result);
        }
    }
}
