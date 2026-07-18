using Microsoft.EntityFrameworkCore;
using QuanLyTrungTam.Models;
using QuanLyTrungTam.DAL;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.WebSockets;

namespace QuanLyTrungTam.FORM
{
    public partial class FrmGiaoVien : Form
    {
        public FrmGiaoVien()
        {
            InitializeComponent();
            LoadGiaoVien();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private readonly DAL.DBContext db = new DAL.DBContext();
        public void LoadGiaoVien()
        {
            var ds = db.GiaoViens!.Select(gv => new
            {
                gv.MaGV,
                gv.TenGV,
                gv.NgaySinh,
                gv.DiaChi,
                gv.SDT
            }).ToList();
            dataGiaoVien.DataSource = ds;
        }
        private void dataGiaoVien_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void FrmGiaoVien_Load(object sender, EventArgs e)
        {

        }

    }
}
