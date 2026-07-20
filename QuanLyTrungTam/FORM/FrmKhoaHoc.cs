using QuanLyTrungTam.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        DBContext db = new DBContext();
        public void LoadKhoaHoc()
        {
            var ds = db.KhoaHocs!.Select(kh => new
            {
                kh.MaKH,
                kh.TenKH,
                kh.NgayBatDau,
                kh.NgayKetThuc

            }).ToList();
            dataKhoaHoc.DataSource = ds;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
            panelTop.ClientRectangle,
            Color.FromArgb(255, 236, 210),
            Color.FromArgb(255, 200, 150),
            LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, panelTop.ClientRectangle);
            }
        }
    }
}
