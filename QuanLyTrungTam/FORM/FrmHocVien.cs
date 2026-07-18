using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTam.FORM
{
    public partial class FrmHocVien : Form
    {
        public FrmHocVien()
        {
            InitializeComponent();
            LoadHocVien();
        }
        private readonly DAL.DBContext db = new DAL.DBContext();
        public void LoadHocVien()
        {
            var ds = db.HocViens!.Select(hv => new
            {
                hv.MaHV,
                hv.CMND,
                hv.TenHV,
                hv.NgaySinh,
                hv.NgheNghiep,
            }).ToList();
            dataHocVien.DataSource = ds;
        }
        private void dataHocVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
