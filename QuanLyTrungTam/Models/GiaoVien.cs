using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTam.Models
{
    [Table("GiaoVien")]
    public class GiaoVien
    {
        [Key] 
        public string MaGV { get; set; }
        public string TenGV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public ICollection<LopHoc>? LopHocs { get; set; }

    }
}
