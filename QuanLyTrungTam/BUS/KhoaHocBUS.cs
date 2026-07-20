using QuanLyTrungTam.DAL;
using QuanLyTrungTam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTam.BUS
{
    public class KhoaHocBUS
    {
        DBContext db = new DBContext();

        public List<KhoaHoc> GetAll()
        {
            return db.KhoaHocs.ToList();
        }

        public KhoaHoc GetById(string maKH)
        {
            return db.KhoaHocs.Find(maKH);
        }

        public bool Them(KhoaHoc kh)
        {
            db.KhoaHocs.Add(kh);
            return db.SaveChanges() > 0;
        }

        public bool Sua(KhoaHoc kh)
        {
            db.KhoaHocs.Update(kh);
            return db.SaveChanges() > 0;
        }

        public bool Xoa(string maKH)
        {
            var kh = db.KhoaHocs.Find(maKH);

            if (kh == null)
                return false;

            db.KhoaHocs.Remove(kh);

            return db.SaveChanges() > 0;
        }
    }
}
