using QuanLyTrungTam.DAL;
using QuanLyTrungTam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyTrungTam.BUS
{
    public class GiaoVienBUS
    {
        DBContext db = new DBContext();

        public List<GiaoVien> GetAll()
        {
            return db.GiaoViens.ToList();
        }

        

        public GiaoVien GetById(string maGV)
        {
            return db.GiaoViens.Find(maGV);
        }

        public bool Them(GiaoVien gv)
        {
            db.GiaoViens.Add(gv);
            return db.SaveChanges() > 0;
        }

        public bool Sua(GiaoVien gv)
        {
            db.GiaoViens.Update(gv);
            return db.SaveChanges() > 0;
        }

        public bool Xoa(string maGV)
        {
            var gv = db.GiaoViens.Find(maGV);

            if (gv == null)
                return false;

            db.GiaoViens.Remove(gv);

            return db.SaveChanges() > 0;
        }
    }
}
