using Microsoft.EntityFrameworkCore;
using QuanLyTrungTam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTam.DAL
{
    internal class DBContext : DbContext
    {
        // DbSet
        public DbSet<GiaoVien> GiaoViens { get; set; }

        public DbSet<HocVien> HocViens { get; set; }

        public DbSet<KhoaHoc> KhoaHocs { get; set; }

        public DbSet<LopHoc> LopHocs { get; set; }

        public DbSet<BienLaiHocPhi> BienLaiHocPhis { get; set; }

        public DbSet<KetQuaThi> KetQuaThis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QuanLyTrungTam;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Giáo viên - Lớp học
            modelBuilder.Entity<LopHoc>()
                .HasOne(l => l.GiaoVien)
                .WithMany(g => g.LopHocs)
                .HasForeignKey(l => l.MaGV)
                .OnDelete(DeleteBehavior.Restrict);

            // Khóa học - Lớp học
            modelBuilder.Entity<LopHoc>()
                .HasOne(l => l.KhoaHoc)
                .WithMany(k => k.LopHocs)
                .HasForeignKey(l => l.MaKH)
                .OnDelete(DeleteBehavior.Restrict);

            // Học viên - Biên lai
            modelBuilder.Entity<BienLaiHocPhi>()
                .HasOne(b => b.HocVien)
                .WithMany(h => h.BienLaiHocPhis)
                .HasForeignKey(b => b.MaHV)
                .OnDelete(DeleteBehavior.Cascade);

            // Lớp học - Biên lai
            modelBuilder.Entity<BienLaiHocPhi>()
                .HasOne(b => b.LopHoc)
                .WithMany(l => l.BienLaiHocPhis)
                .HasForeignKey(b => b.MaLop)
                .OnDelete(DeleteBehavior.Restrict);

            // Học viên - Kết quả thi
            modelBuilder.Entity<KetQuaThi>()
                .HasOne(k => k.HocVien)
                .WithMany(h => h.KetQuaThis)
                .HasForeignKey(k => k.MaHV)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
