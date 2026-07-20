using QuanLyTrungTam.DAL;
using QuanLyTrungTam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTam.BUS
{
    public class HocVienBUS
    {
        DBContext db = new DBContext();

        public List<HocVien> GetAll()
        {
            return db.HocViens.ToList();
        }

        public HocVien GetById(string maHV)
        {
            return db.HocViens.Find(maHV);
        }

        public bool Them(HocVien hv)
        {
            db.HocViens.Add(hv);
            return db.SaveChanges() > 0;
        }

        public bool Sua(HocVien hv)
        {
            db.HocViens.Update(hv);
            return db.SaveChanges() > 0;
        }

        public bool Xoa(string maHV)
        {
            var hv = db.HocViens.Find(maHV);

            if (hv == null)
                return false;

            db.HocViens.Remove(hv);

            return db.SaveChanges() > 0;
        }
    }
}
