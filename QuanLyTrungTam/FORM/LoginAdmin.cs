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
    }
}
