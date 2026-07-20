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
    public partial class FrmLoginChoose : Form
    {
        public FrmLoginChoose()
        {
            InitializeComponent();
        }

        private void btAd_Click(object sender, EventArgs e)
        {
            LoginAdmin l1 = new LoginAdmin();
            l1.Show();
            this.Hide();
        }

        private void btGV_MouseClick(object sender, MouseEventArgs e)
        {
            LoginTeacher l2 = new LoginTeacher();
            l2.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btHV_MouseClick(object sender, MouseEventArgs e)
        {
            LoginStudent l3 = new LoginStudent();
            l3.Show();
            this.Hide();
        }
    }
}
