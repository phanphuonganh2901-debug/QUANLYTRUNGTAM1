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
    public partial class FrmKhoaHoc : Form
    {
        public FrmKhoaHoc()
        {
            InitializeComponent();
            LoadKhoaHoc();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private readonly DAL.DBContext db = new DAL.DBContext();

        public void LoadKhoaHoc()
        {
            var ds = db.KhoaHocs!.Select(kh => new
            {
                kh.MaKH,
                kh.TenKH,
                kh.NgayBatDau,
                kh.NgayKetThuc,
            }).ToList();
            dataKhoaHoc.DataSource = ds;
        }
        private void dataKhoaHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
