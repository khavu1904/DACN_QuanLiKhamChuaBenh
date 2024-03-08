using Microsoft.AspNetCore.Mvc.Rendering;

namespace DACN_Quan_Ly_Kham_Chua_Benh.ViewModel
{
    public class ThongKeViewModel
    {
        public int LichKhamId { get; set; }
        public int? TrangThai { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public int? idBacSi { get; set; }
        public string TenBS { get; set; }
        public string TenBN { get; set; }
        public List<SelectListItem> BacSiList { get; set; }
        public int TongSoLichKham { get; set; }
        public int SoLuong { get; set; }
    }
}
