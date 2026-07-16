using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTrungTam.DAL;
using QuanLyTrungTam.Models;

namespace QuanLyTrungTam.BUS
{
   
        public class LichHocBUS
        {
            DBContext db = new DBContext();

            public List<LichHoc> GetAll()
            {
                return db.LichHocs.ToList();
            }

            public LichHoc GetById(string maLich)
            {
                return db.LichHocs.Find(maLich);
            }
            public bool Them(LichHoc lh)
            {
                db.LichHocs.Add(lh);
                return db.SaveChanges() > 0;
            }
            public bool Sua(LichHoc lh)
            {
                db.LichHocs.Update(lh);
                return db.SaveChanges() > 0;
            }
            public bool Xoa(string maLich)
            {
                var lh = db.LichHocs.Find(maLich);

                if (lh == null)
                    return false;

                db.LichHocs.Remove(lh);

                return db.SaveChanges() > 0;
            }
            public List<LichDayView> GetLichDay()
            {
                var ds = from lh in db.LichHocs
                         join lp in db.LopHocs
                            on lh.MaLop equals lp.MaLop

                         join gv in db.GiaoViens
                            on lp.MaGV equals gv.MaGV

                         join kh in db.KhoaHocs
                            on lp.MaKH equals kh.MaKH

                         select new LichDayView
                         {
                             MaLich = lh.MaLich,
                             MaGV = gv.MaGV,
                             TenGV = gv.TenGV,

                             MaLop = lp.MaLop,
                             TenLop = lp.TenLop,

                             TenKH = kh.TenKH,

                             NgayHoc = lh.NgayHoc,
                             GioBatDau = lh.GioBatDau,
                             GioKetThuc = lh.GioKetThuc,

                             PhongHoc = lh.PhongHoc,
                             NoiDungBuoi = lh.NoiDungBuoi
                         };

                return ds.OrderBy(x => x.NgayHoc).ToList();
            }
            public List<LichDayView> GetLichTheoGV(string maGV)
            {
                return GetLichDay()
                    .Where(x => x.MaGV == maGV)
                    .ToList();
            }
            public List<LichDayView> GetLichTheoNgay(DateTime ngay)
            {
                return GetLichDay()
                    .Where(x => x.NgayHoc.Date == ngay.Date)
                    .ToList();
            }

            public bool PhanCongGiaoVien(string maLop, string maGV)
            {
                var lop = db.LopHocs.Find(maLop);

                if (lop == null)
                    return false;

                lop.MaGV = maGV;

                return db.SaveChanges() > 0;
            
        }
        public List<LichHoc> GetByMaGV(string maGV)
        {
            return db.LichHocs
                     .Where(x => x.LopHoc.MaGV == maGV)
                     .ToList();
        }
        public List<LichHoc> GetByHocVien(string maHV)
        {
            var maLop = db.BienLaiHocPhis
                          .Where(x => x.MaHV == maHV)
                          .Select(x => x.MaLop)
                          .FirstOrDefault();

            return db.LichHocs
                     .Where(x => x.MaLop == maLop)
                     .ToList();
        }
    }
}
