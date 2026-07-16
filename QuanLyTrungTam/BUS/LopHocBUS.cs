using QuanLyTrungTam.DAL;
using QuanLyTrungTam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTam.BUS
{
    public class LopHocBUS
    {
        DBContext db = new DBContext();

        public List<LopHoc> GetAll()
        {
            return db.LopHocs.ToList();
        }

        public LopHoc GetById(string maLop)
        {
            return db.LopHocs.Find(maLop);
        }

        public bool Them(LopHoc lop)
        {
            db.LopHocs.Add(lop);
            return db.SaveChanges() > 0;
        }

        public bool Sua(LopHoc lop)
        {
            db.LopHocs.Update(lop);
            return db.SaveChanges() > 0;
        }

        public bool Xoa(string maLop)
        {
            var lop = db.LopHocs.Find(maLop);

            if (lop == null)
                return false;

            db.LopHocs.Remove(lop);

            return db.SaveChanges() > 0;
        }
    }
}
