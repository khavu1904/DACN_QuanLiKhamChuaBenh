using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DACN_Quan_Ly_Kham_Chua_Benh.Models
{
    public class BangCap
    {
        [Key]
        public int idBangCap { get; set; }
        public string TenBangCap { get; set; }
        public string HinhAnh { get; set; }
        [ForeignKey("BacSiTemp")]
        public int idBacSiTemp { get; set; }
        public BacSiTemp BacSiTemp { get; set; }

        [ForeignKey("BacSi")]
        public int? idBacSi { get; set; }
        public BacSi BacSi { get; set; }
        [ForeignKey("ProfileBoSung")]
        public int? idProfileBoSung { get; set; }
        public ProfileBoSung ProfileBoSung { get; set; }
    }
}
