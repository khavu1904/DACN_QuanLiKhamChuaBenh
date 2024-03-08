using Microsoft.EntityFrameworkCore;
using DACN_Quan_Ly_Kham_Chua_Benh.Models;
using System.Linq;

namespace DACN_Quan_Ly_Kham_Chua_Benh.Data
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<BacSi> BacSi { get; set; }
        public DbSet<BacSiTemp> bacSiTemp { get; set; }
        public DbSet<ProfileBoSung> proFileBoSung { get; set; }

        public DbSet<BenhNhan> BenhNhan { get; set; }
        public DbSet<BangCap> bangCap { get; set; }
        public DbSet<ChungChi> chungChi { get; set; }
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<LichKham> LichKham { get; set; }
        public DbSet<KetQuaDuyet> ketQuaDuyet { get; set; }
        public DbSet<PhongKham> PhongKham { get; set; }
        public DbSet<DACN_Quan_Ly_Kham_Chua_Benh.Models.BacSiViewModel>? BacSiViewModel { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<LichKham>()
        //        .HasKey(o => o.idLichKham);
        //    modelBuilder.Entity<LichKham>()
        //        .HasOne(lk => lk.BacSi)
        //        .WithMany(bs => bs.LichKhams)
        //        .HasForeignKey(lk => lk.idBacSi);
        //    modelBuilder.Entity<LichKham>()
        //        .HasOne(lk => lk.BenhNhan)
        //        .WithMany(bn => bn.LichKhams)
        //        .HasForeignKey(lk => lk.idBenhNhan);
        //    modelBuilder.Entity<LichKham>()
        //        .HasOne(lk => lk.PhongKham)
        //        .WithMany(pk => pk.LichKhams)
        //        .HasForeignKey(lk => lk.idPhongKham);

        //    modelBuilder.Entity<BacSi>()
        //        .HasKey(o => o.idBacSi);

        //    modelBuilder.Entity<BenhNhan>()
        //        .HasKey(o => o.idBenhNhan);

        //    modelBuilder.Entity<PhongKham>()
        //        .HasKey(o => o.idPhongKham);
        //}
    }
}
