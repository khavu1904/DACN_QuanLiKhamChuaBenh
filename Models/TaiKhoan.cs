using System.ComponentModel.DataAnnotations;
namespace DACN_Quan_Ly_Kham_Chua_Benh.Models
{
    public class TaiKhoan
    {
        [Key]
        public int idTaiKhoan { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int? Quyen { get; set; }
        public int? TrangThai { get; set; }
    }
}
