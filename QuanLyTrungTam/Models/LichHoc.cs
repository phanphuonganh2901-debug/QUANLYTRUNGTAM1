using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTam.Models
{
    [Table("LichHoc")]
    public class LichHoc
    {
        [Key]
        public string MaLich { get; set; }
        public string MaLop { get; set; }
        public DateTime NgayHoc { get; set; }
        public string GioBatDau { get; set; }
        public string GioKetThuc { get; set; }
        public string PhongHoc { get; set; }
        public string NoiDungBuoi { get; set; }
        public LopHoc? LopHoc { get; set; }
       
    }
}
