using QuanLyTrungTam.DAL;
using QuanLyTrungTam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTam.BUS
{
    public class KetQuaThiBUS
    {
        DBContext db = new DBContext();

        public List<KetQuaThi> GetAll()
        {
            return db.KetQuaThis.ToList();
        }

        public KetQuaThi GetById(string maKQ)
        {
            return db.KetQuaThis.Find(maKQ);
        }

        public Dictionary<string, int> ThongKeXepLoai()
        {
            var ds = db.KetQuaThis.ToList();

            Dictionary<string, int> kq = new Dictionary<string, int>();

            foreach (var item in ds)
            {
                if (kq.ContainsKey(item.XepLoai))
                    kq[item.XepLoai]++;
                else
                    kq.Add(item.XepLoai, 1);
            }

            return kq;
        }
        public bool Them(KetQuaThi kq)
        {
            db.KetQuaThis.Add(kq);
            return db.SaveChanges() > 0;
        }

        public bool Sua(KetQuaThi kq)
        {
            db.KetQuaThis.Update(kq);
            return db.SaveChanges() > 0;
        }

        public bool Xoa(string maKQ)
        {
            var kq = db.KetQuaThis.Find(maKQ);

            if (kq == null)
                return false;

            db.KetQuaThis.Remove(kq);

            return db.SaveChanges() > 0;
        }
    }
}
