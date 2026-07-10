using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTam.Models
{
    public class LopHoc
    {
        [Key]
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public int  SiSo { get; set; }
        public string PhongHoc { get; set; }
        [ForeignKey("GiaoVien")]
        public string MaGV { get; set; }
        [ForeignKey("KhoaHoc")]
        public string MaKH { get; set; }
        public GiaoVien? GiaoVien { get; set; }

        public KhoaHoc? KhoaHoc { get; set; }

        public ICollection<BienLaiHocPhi>? BienLaiHocPhis { get; set; }
        public ICollection<LichHoc>? LichHocs { get; set; }
        

    }
}
