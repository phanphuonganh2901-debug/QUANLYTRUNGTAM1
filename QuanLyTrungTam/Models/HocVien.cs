using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTam.Models
{
    [Table("HocVien")]
    public class HocVien
    {
        [Key]
        public string MaHV { get; set; }
        public string CMND { get; set; }
        public string TenHV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string NgheNghiep { get; set; }
        public ICollection<BienLaiHocPhi>? BienLaiHocPhis { get; set; }

        public ICollection<KetQuaThi>? KetQuaThis { get; set; }
        public ICollection<DanhGiaHocVien>? DanhGiaHocViens { get; set; }
    }
}
