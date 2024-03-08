using System.ComponentModel.DataAnnotations;
namespace DACN_Quan_Ly_Kham_Chua_Benh.Models
{
    public class BacSiTemp
    {
        [Key]
        public int idBacSiTemp { get; set; }
        public string? MaBS { get; set; }
        public string TenBS { get; set; }
        public int? TrangThai { get; set; }
        public string KinhNghiem { get; set; }
        public string KyNangChuyenMon { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string GioiThieu { get; set; }
        public string GioiTinh { get; set; }

        public DateTime NgaySinh { get; set; }
        public string QuocTich { get; set; }

        public ICollection<BangCap> BangCaps { get; set; }
        public ICollection<ChungChi> ChungChis { get; set; }
        public ICollection<KetQuaDuyet> KetQuaDuyet { get; set; }
        public ICollection<LichKham> LichKhams { get; set; }
    }
}
