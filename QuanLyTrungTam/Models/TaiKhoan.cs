using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTam.Models
{
    public class TaiKhoan
    {
        [Key]
        public string TenDangNhap { get; set; }

        public string MatKhau { get; set; }

        public string VaiTro { get; set; }

        public string MaNguoiDung { get; set; }

        public bool TrangThai { get; set; } = true;
    }
}
