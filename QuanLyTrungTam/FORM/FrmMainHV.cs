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
    public partial class FrmMainHV : Form
    {
        public FrmMainHV()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblXinChao.Text = "Xin chào, Học Viên";

            lblNgay.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");


        }

        private void pnlHome_Paint(object sender, PaintEventArgs e)
        {

            using (LinearGradientBrush brush = new LinearGradientBrush(
           pnlHome.ClientRectangle,
           Color.FromArgb(255, 236, 210),
           Color.FromArgb(255, 200, 150),
           LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, pnlHome.ClientRectangle);
            }
        }
    }
}
