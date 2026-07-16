using QuanLyTrungTam.DAL;
using QuanLyTrungTam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTam.BUS
{
    public class LoginBUS
    {
        DBContext db = new DBContext();

        public TaiKhoan Login(string user, string pass)
        {
            return db.TaiKhoans
                     .FirstOrDefault(x =>
                         x.TenDangNhap == user &&
                         x.MatKhau == pass);
        }
    }
}
