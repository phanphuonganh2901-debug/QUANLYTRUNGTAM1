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
    public partial class LoginTeacher : Form
    {
        public LoginTeacher()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btBack_MouseClick(object sender, MouseEventArgs e)
        {
            FrmLoginChoose l1 = new FrmLoginChoose();
            l1.Show();
            this.Hide();
        }
        private readonly DAL.DBContext db = new DAL.DBContext();

        private void LoginTeacher_Load(object sender, EventArgs e)
        {

        }

        private void btLoginGV_MouseClick_1(object sender, MouseEventArgs e)
        {
            string user = txtUserGV.Text;
            string pass = txtPassGV.Text;

            var account = db.TaiKhoans!.FirstOrDefault(tk => tk.TenDangNhap == user && tk.MatKhau == pass && tk.VaiTro == "GiaoVien");

            if (account != null)
            {
                FrmMainGV fmaingv = new FrmMainGV();
                fmaingv.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }
    }
}
