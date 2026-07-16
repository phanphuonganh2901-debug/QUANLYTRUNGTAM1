using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTam.Models
{
    [Table("DanhGiaHocVien")]
    public class DanhGiaHocVien
    {
        [Key]
        public int MaDanhGia { get; set; }
        public string MaHV { get; set; }
        public string MaLop { get; set; }
        public int DiemDanhGia { get; set; }
        public string NoiDung  { get; set; }
        public DateTime NgayDanhGia { get; set; }
        public HocVien? HocVien { get; set; }
    }
}
