using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DACN_Quan_Ly_Kham_Chua_Benh.Models
{
    public class LichKham
    {
        [Key]
        public int idLichKham { get; set; }
        public int? TrangThai { get; set; }
        public string MaLK { get; set; }
        public string KetQua { get; set; }

        [ForeignKey("BacSi")]
        public int? idBacSi { get; set; }

        [ForeignKey("BenhNhan")]
        public int? idBenhNhan { get; set; }

        [ForeignKey("PhongKham")]
        public int? idPhongKham { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public string GhiChu {  get; set; }
        public double ThanhTien { get; set; }

        public BacSi BacSi { get; set; }
        public BenhNhan BenhNhan { get; set; }
        public PhongKham PhongKham { get; set; }
    }
}
