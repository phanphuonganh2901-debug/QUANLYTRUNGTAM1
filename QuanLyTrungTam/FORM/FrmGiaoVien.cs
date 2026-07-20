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
    public partial class FrmGiaoVien : Form
    {
        public FrmGiaoVien()
        {
            InitializeComponent();
            LoadGiaoVien();
        }
        DBContext db = new DBContext();
        public void LoadGiaoVien()
        {
            var ds = db.GiaoViens!.Select(gv => new
            {
                gv.MaGV,
                gv.TenGV,
                gv.NgaySinh,
                gv.DiaChi,
                gv.SDT
            }).ToList();
            dataGiaoVien.DataSource = ds;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
