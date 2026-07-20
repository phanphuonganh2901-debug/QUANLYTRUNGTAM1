using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTam.Models
{
    public class LichDayView
    {
        public string MaLich { get; set; }

        public string MaGV { get; set; }

        public string TenGV { get; set; }

        public string MaLop { get; set; }

        public string TenLop { get; set; }

        public string TenKH { get; set; }

        public DateTime NgayHoc { get; set; }

        public string GioBatDau { get; set; }

        public string GioKetThuc { get; set; }

        public string PhongHoc { get; set; }

        public string NoiDungBuoi { get; set; }
    }
}
