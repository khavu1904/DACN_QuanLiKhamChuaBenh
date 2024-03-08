using System.ComponentModel.DataAnnotations;
namespace DACN_Quan_Ly_Kham_Chua_Benh.Models
{
    public class PhongKham
    {
        [Key]
        public int idPhongKham { get; set; }
        public string MaPhongKham { get; set; }
        public string TenPhongKham { get; set; }

        public ICollection<LichKham> LichKhams { get; set; }
    }
}
