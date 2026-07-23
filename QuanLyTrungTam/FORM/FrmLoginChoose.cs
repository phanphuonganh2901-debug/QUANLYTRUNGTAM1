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
    public partial class FrmLoginChoose : Form
    {
        public FrmLoginChoose()
        {
            InitializeComponent();


        }

        private void btAd_Click(object sender, EventArgs e)
        {

        }

        private void btGV_MouseClick(object sender, MouseEventArgs e)
        {
            
        }



        private void FrmLoginChoose_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"C:\Users\Admin\Pictures\p1.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
            panel1.ClientRectangle,
            Color.FromArgb(255, 236, 210),
            Color.FromArgb(255, 200, 150),
            LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }

        }

        private void btAd_Click_1(object sender, EventArgs e)
        {
            LoginAdmin l1 = new LoginAdmin();
            l1.Show();
            this.Hide();
        }

        private void btGV_Click(object sender, EventArgs e)
        {

            LoginTeacher l2 = new LoginTeacher();
            l2.Show();
            this.Hide();
        }

        private void btHV_Click(object sender, EventArgs e)
        {
            LoginStudent l3 = new LoginStudent();
            l3.Show();
            this.Hide();
        }
    }
}