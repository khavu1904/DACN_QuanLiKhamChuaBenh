using System.ComponentModel.DataAnnotations;
namespace DACN_Quan_Ly_Kham_Chua_Benh.Models
{
    public class BenhNhan
    {
        [Key]
        public int idBenhNhan { get; set; }
        public string MaBN { get; set; }
        public string TenBN { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string MaBHYT { get; set; }
        public string QuocTich { get; set; }

        public ICollection<LichKham> LichKhams { get; set; }

    }
}
