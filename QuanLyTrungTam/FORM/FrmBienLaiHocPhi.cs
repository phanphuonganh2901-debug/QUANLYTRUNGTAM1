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
using QuanLyTrungTam.DAL;

namespace QuanLyTrungTam.FORM
{
    public partial class FrmBienLaiHocPhi : Form
    {
        public FrmBienLaiHocPhi()
        {
            InitializeComponent();
            LoadBienLaiHocPhi();
        }

        DBContext db = new DBContext();
        public void LoadBienLaiHocPhi()
        {
            var ds = db.BienLaiHocPhis!.Select(bl => new
            {
                bl.SoBienLai,
                bl.MaHV,
                bl.MaLop,
                bl.MaKH,
                bl.TienNop,
                bl.NgayNop,
                bl.NguoiThu
            }).ToList();
            dataBienLaiHocPhi.DataSource = ds;
        }
        private void label4_Click(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
