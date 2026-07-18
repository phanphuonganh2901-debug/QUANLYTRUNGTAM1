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
    public partial class FrmHocVien : Form
    {
        public FrmHocVien()
        {
            InitializeComponent();
            LoadHocVien();
        }
        DBContext db = new DBContext();
        public void LoadHocVien()
        {
            var ds = db.HocViens!.Select(hv => new
            {
                hv.MaHV,
                hv.CMND,
                hv.TenHV,
                hv.NgaySinh,
                hv.NgheNghiep
            }).ToList();
            dataHocVien.DataSource = ds;
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
