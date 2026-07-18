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
    public partial class FrmMainGV : Form
    {
        public FrmMainGV()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblXinChao.Text = "Xin chào, Giáo Viên";

            lblNgay.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void dgvMainGV_SelectionChanged(object sender, EventArgs e)
        {

        }
        private readonly DAL.DBContext db = new DAL.DBContext();
        private void FrmMainGV_Load(object sender, EventArgs e)
        {
            var ds = db.GiaoViens!.Select(gv => new
            {
                gv.MaGV,
                gv.TenGV,
                gv.NgaySinh,
                gv.DiaChi,
                gv.SDT
            }).ToList();
            dgvMainGV.DataSource = ds;
        }
        
    }
}
