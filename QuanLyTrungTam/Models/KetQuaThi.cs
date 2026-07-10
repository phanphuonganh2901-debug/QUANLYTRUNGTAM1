using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTam.Models
{
    public class KetQuaThi
    {
        [Key]
        public int MaKQT { get; set; }
        public string SoBienLai { get; set; }
        [ForeignKey("HocVien")]
        public string MaHV { get; set; }
        [ForeignKey("GiaoVien")]
        public string MaGV { get; set; }
        public DateTime NgayThi { get; set; }
        public decimal DiemThi { get; set; }
        public string XepLoai { get; set; }
        public HocVien? HocVien { get; set; }
        public LichHoc? LichHoc { get; set; }
        

    }
}
