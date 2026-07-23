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
    public partial class LoginAdmin : Form
    {
        private readonly DAL.DBContext db = new DAL.DBContext();
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void btBack_MouseClick(object sender, MouseEventArgs e)
        {
            FrmLoginChoose l2 = new FrmLoginChoose();
            l2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void btLogin_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_MouseClick(object sender, MouseEventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            var account = db.TaiKhoans!.FirstOrDefault(tk => tk.TenDangNhap == user && tk.MatKhau == pass && tk.VaiTro == "Admin");

            if (account != null)
            {
                FrmMain fmain = new FrmMain();
                fmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }
    }
}
