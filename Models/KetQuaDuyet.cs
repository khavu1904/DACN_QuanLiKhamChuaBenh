using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DACN_Quan_Ly_Kham_Chua_Benh.Models
{
    public class KetQuaDuyet
    {
        [Key]
        public int idKetQuaDuyet { get; set; }
        public string ThongBao { get; set; }
        public DateTime NgayDuyet { get; set; }
        public string BangBoSung { get; set; }
        [ForeignKey("BacSiTemp")]
        public int idBacSiTemp { get; set; }

        public BacSiTemp BacSiTemp { get; set; }
    }
}
