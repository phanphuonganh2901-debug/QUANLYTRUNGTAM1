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
        public DbSet<LichHoc> LichHocs { get; set; }
        public DbSet<DanhGiaHocVien> DanhGiaHocViens { get; set; }

        public DbSet<HocVien> HocViens { get; set; }

        public DbSet<KhoaHoc> KhoaHocs { get; set; }

        public DbSet<LopHoc> LopHocs { get; set; }

        public DbSet<BienLaiHocPhi> BienLaiHocPhis { get; set; }

        public DbSet<KetQuaThi> KetQuaThis { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QuanLyTrungTam;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //=========================
            // GiaoVien -> LopHoc
            //=========================
            modelBuilder.Entity<LopHoc>()
                .HasOne(l => l.GiaoVien)
                .WithMany(g => g.LopHocs)
                .HasForeignKey(l => l.MaGV)
                .OnDelete(DeleteBehavior.Restrict);

            //=========================
            // KhoaHoc -> LopHoc
            //=========================
            modelBuilder.Entity<LopHoc>()
                .HasOne(l => l.KhoaHoc)
                .WithMany(k => k.LopHocs)
                .HasForeignKey(l => l.MaKH)
                .OnDelete(DeleteBehavior.Restrict);

            //=========================
            // LopHoc -> LichHoc
            //=========================
            modelBuilder.Entity<LichHoc>()
                .HasOne(lh => lh.LopHoc)
                .WithMany(l => l.LichHocs)
                .HasForeignKey(lh => lh.MaLop)
                .OnDelete(DeleteBehavior.Cascade);

            //=========================
            // HocVien -> BienLaiHocPhi
            //=========================
            modelBuilder.Entity<BienLaiHocPhi>()
                .HasOne(bl => bl.HocVien)
                .WithMany(hv => hv.BienLaiHocPhis)
                .HasForeignKey(bl => bl.MaHV)
                .OnDelete(DeleteBehavior.Cascade);

            //=========================
            // LopHoc -> BienLaiHocPhi
            //=========================
            modelBuilder.Entity<BienLaiHocPhi>()
                .HasOne(bl => bl.LopHoc)
                .WithMany(l => l.BienLaiHocPhis)
                .HasForeignKey(bl => bl.MaLop)
                .OnDelete(DeleteBehavior.Restrict);

            //=========================
            // HocVien -> KetQuaThi
            //=========================
            modelBuilder.Entity<KetQuaThi>()
                .HasOne(kq => kq.HocVien)
                .WithMany(hv => hv.KetQuaThis)
                .HasForeignKey(kq => kq.MaHV)
                .OnDelete(DeleteBehavior.Cascade);

            
            //=========================
            // HocVien -> DanhGiaHocVien
            //=========================
            modelBuilder.Entity<DanhGiaHocVien>()
                .HasOne(dg => dg.HocVien)
                .WithMany(hv => hv.DanhGiaHocViens)
                .HasForeignKey(dg => dg.MaHV)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }
}
