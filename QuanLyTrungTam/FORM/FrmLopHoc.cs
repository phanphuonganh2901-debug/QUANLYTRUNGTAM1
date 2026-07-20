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
    public partial class FrmLopHoc : Form
    {
        public FrmLopHoc()
        {
            InitializeComponent();
            LoadLopHoc();
        }

        private readonly DAL.DBContext db = new DAL.DBContext();
        public void LoadLopHoc()
        {
            var ds = db.LopHocs!.Select(lh => new
            {
                lh.MaLop,
                lh.TenLop,
                lh.SiSo,
                lh.PhongHoc,
                lh.MaGV,
                lh.MaKH
            }).ToList();
            dataLopHoc.DataSource = ds;
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
