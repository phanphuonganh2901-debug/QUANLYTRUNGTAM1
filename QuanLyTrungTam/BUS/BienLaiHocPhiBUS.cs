using QuanLyTrungTam.DAL;
using QuanLyTrungTam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTam.BUS
{
    public class BienLaiHocPhiBUS
    {
        DBContext db = new DBContext();

        public List<BienLaiHocPhi> GetAll()
        {
            return db.BienLaiHocPhis.ToList();
        }

        public BienLaiHocPhi GetById(string soBienLai)
        {
            return db.BienLaiHocPhis.Find(soBienLai);
        }

        public bool Them(BienLaiHocPhi bl)
        {
            db.BienLaiHocPhis.Add(bl);
            return db.SaveChanges() > 0;
        }

        public bool Sua(BienLaiHocPhi bl)
        {
            db.BienLaiHocPhis.Update(bl);
            return db.SaveChanges() > 0;
        }

        public bool Xoa(string soBienLai)
        {
            var bl = db.BienLaiHocPhis.Find(soBienLai);

            if (bl == null)
                return false;

            db.BienLaiHocPhis.Remove(bl);

            return db.SaveChanges() > 0;
        }
    }
}
