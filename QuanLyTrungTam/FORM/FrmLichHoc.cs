using QuanLyTrungTam.BUS;
using QuanLyTrungTam.DAL;
using QuanLyTrungTam.Models;
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
    public partial class FrmLichHoc : Form
    {
        private string vaiTro;
        private string maNguoiDung;

        LichHocBUS bus = new LichHocBUS();

        public FrmLichHoc(string vaiTro, string maNguoiDung)
        {
            InitializeComponent();
            LoadLichHoc();

            this.vaiTro = vaiTro;
            this.maNguoiDung = maNguoiDung;
        }
        DBContext db = new DBContext();
        public void LoadLichHoc()
        {
            var ds = db.LichHocs!.Select(lh => new
            {
                lh.MaLich,
                lh.MaLop,
                lh.NgayHoc,
                lh.GioBatDau,
                lh.GioKetThuc,
                lh.PhongHoc,
                lh.NoiDungBuoi

            }).ToList();
            dataLichHoc.DataSource = ds;
        }

        private void FrmLichHoc_Load(object sender, EventArgs e)
        {
            if (vaiTro == "Admin")
            {
                dataLichHoc.DataSource = bus.GetAll();
            }

            else if (vaiTro == "GiaoVien")
            {
                dataLichHoc.DataSource = bus.GetByMaGV(maNguoiDung);

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

                cboGiaoVien.Enabled = false;
            }

            else
            {
                dataLichHoc.DataSource = bus.GetByHocVien(maNguoiDung);

                panelTop.Enabled = false;

                btnThem.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
                btnLoad.Visible = false;
            }
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmLichHoc_Load_1(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
            panelTop.ClientRectangle,
            Color.FromArgb(255, 236, 210),
            Color.FromArgb(255, 200, 150),
            LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, panelTop.ClientRectangle);
            }
        }
    }
}
