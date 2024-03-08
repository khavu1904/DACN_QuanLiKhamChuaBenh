using DACN_Quan_Ly_Kham_Chua_Benh.Data;
using DACN_Quan_Ly_Kham_Chua_Benh.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DACN_Quan_Ly_Kham_Chua_Benh.Controllers
{
    public class ThongKeController : Controller
    {
        private readonly DBContext _context;
        public ThongKeController(DBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index(DateTime? ngayBatDau, DateTime? ngayKetThuc, int? selectedTrangThai, string selectedBacSi)
        {
            var query = _context.LichKham
            .Where(lk => lk.ThoiGianBatDau >= ngayBatDau && lk.ThoiGianBatDau <= ngayKetThuc)
            .GroupBy(lk => new { lk.ThoiGianBatDau, lk.ThoiGianKetThuc, lk.TrangThai })
            .Select(group => new ThongKeViewModel
            {
                ThoiGianBatDau = group.Key.ThoiGianBatDau,
                ThoiGianKetThuc = group.Key.ThoiGianKetThuc,
                TrangThai = group.Key.TrangThai,
                SoLuong = group.Count()
            })
            .ToList();
            ViewBag.Length1 = query.Count(lk => lk.TrangThai == 1 && lk.ThoiGianBatDau >= ngayBatDau && lk.ThoiGianBatDau <= ngayKetThuc);
            ViewBag.Length2 = query.Count(lk => lk.TrangThai == 2);
            ViewBag.Length3 = query.Count(lk => lk.TrangThai == 3);
            return View(query);
        }
        [HttpGet]
        public IActionResult ThongKeBacSi(DateTime? ngayBatDau, DateTime? ngayKetThuc, int? selectedTrangThai, string selectedBacSi)
        {
            var query = from lk in _context.LichKham
                        join bs in _context.BacSi on lk.idBacSi equals bs.idBacSi
                        join bn in _context.BenhNhan on lk.idBenhNhan equals bn.idBenhNhan
                        select new ThongKeViewModel
                        {
                            LichKhamId = lk.idLichKham,
                            TrangThai = lk.TrangThai,
                            ThoiGianBatDau = lk.ThoiGianBatDau,
                            ThoiGianKetThuc = lk.ThoiGianKetThuc,
                            TenBS = bs.TenBS ?? string.Empty,
                            TenBN = bn.TenBN ?? string.Empty,
                        };
            if (!string.IsNullOrEmpty(selectedBacSi))
            {
                query = query.Where(lk => (!ngayBatDau.HasValue || (lk.ThoiGianBatDau >= ngayBatDau && lk.ThoiGianBatDau <= ngayKetThuc)) &&
                                           (string.IsNullOrEmpty(selectedBacSi) || lk.TenBS == selectedBacSi));
                ViewBag.ThongKeMessage = $"Thống kê lịch khám theo Bác Sĩ: {selectedBacSi}";
            }
            ViewBag.Length1 = query.Count(lk => lk.TrangThai == 1);
            ViewBag.Length2 = query.Count(lk => lk.TrangThai == 2);
            ViewBag.Length3 = query.Count(lk => lk.TrangThai == 3);
            var lichKhamCount = query.ToList();
            ViewBag.Length = lichKhamCount.Count;
            var dsBacSi = _context.BacSi.ToList();
            ViewBag.BacSiList = new SelectList(dsBacSi, "TenBS", "TenBS");
            return View(lichKhamCount);
        }
    }
}
