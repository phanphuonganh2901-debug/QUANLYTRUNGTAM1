using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTam.Models
{
    public class KhoaHoc
    {
        [Key]
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public ICollection<LopHoc>? LopHocs { get; set; }
    }
}
