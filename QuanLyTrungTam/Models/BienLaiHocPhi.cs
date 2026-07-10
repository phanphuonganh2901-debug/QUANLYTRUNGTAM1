using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTam.Models
{
    public class BienLaiHocPhi
    {
        [Key]
        public string SoBienLai { get; set; }
        [ForeignKey("KhoaHoc")]
        public string MaHV { get; set; }
        [ForeignKey("LopHoc")]
        public string MaLop { get; set; }
        [ForeignKey("KhoaHoc")]
        public string MaKH { get; set; }
        public decimal TienNop { get; set; }
        public DateTime NgayNop { get; set; }
        public string NguoiThu { get; set; }
        public HocVien? HocVien { get; set; }
        public LopHoc?  LopHoc {  get; set; }

    }
}
