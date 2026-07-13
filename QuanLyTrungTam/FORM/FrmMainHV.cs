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
    }
}
