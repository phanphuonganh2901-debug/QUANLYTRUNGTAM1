using Microsoft.IdentityModel.Tokens;
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
    public partial class LoginAdmin : Form
    {
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
        private readonly DAL.DBContext db = new DAL.DBContext();

        private void LoginAdmin_Load(object sender, EventArgs e)
        {


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
