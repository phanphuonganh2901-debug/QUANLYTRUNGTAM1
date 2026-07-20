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
    public partial class LoginStudent : Form
    {
        public LoginStudent()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private readonly DAL.DBContext db = new DAL.DBContext();

        private void LoginStudent_Load(object sender, EventArgs e)
        {

        }

        private void btLoginHV_MouseClick_1(object sender, MouseEventArgs e)
        {
            string user = txtUserHV.Text;
            string pass = txtPassHV.Text;

            var account = db.TaiKhoans!.FirstOrDefault(tk => tk.TenDangNhap == user && tk.MatKhau == pass && tk.VaiTro == "HocVien");

            if (account != null)
            {
                FrmMainHV fmaingv = new FrmMainHV();
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
