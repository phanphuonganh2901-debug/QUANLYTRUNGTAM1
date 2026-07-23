using QuanLyTrungTam.BUS;
using QuanLyTrungTam.DAL;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyTrungTam.FORM
{
    public partial class FrmMainGV : Form
    {
        private string vaiTro;
        private string maNguoiDung;

        public FrmMainGV(string vaiTro, string maNguoiDung)
        {
            InitializeComponent();

            this.vaiTro = vaiTro;
            this.maNguoiDung = maNguoiDung;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            

        }
        DBContext db = new DBContext();

        private void LoadThongTinGV()
        {
            var gv = db.GiaoViens
                       .FirstOrDefault(x => x.MaGV == maNguoiDung);

            if (gv == null) return;

            lblXinChao.Text = "Xin chào, " + gv.TenGV;

            lblTenGV.Text = gv.TenGV;

            lblMaGV.Text = gv.MaGV;

            lblNgaySinh.Text = gv.NgaySinh.ToString("dd/MM/yyyy");

            lblDiaChi.Text = gv.DiaChi;

            lblSDT.Text = gv.SDT;

            //Nếu có ảnh
            /*
            if(File.Exists(gv.Anh))
                picGV.Image=Image.FromFile(gv.Anh);
            */
        }
        private void LoadThongKe()
        {
            //Số lớp

            int lop = db.LopHocs.Count(x => x.MaGV == maNguoiDung);

            lblTongLop.Text = lop.ToString();


            //Tổng học viên

            int hocVien = db.BienLaiHocPhis
                            .Where(x => x.LopHoc.MaGV == maNguoiDung)
                            .Select(x => x.MaHV)
                            .Distinct()
                            .Count();

            lblTongHV.Text = hocVien.ToString();


            //Số ca hôm nay

            int buoi = db.LichHocs
                         .Count(x => x.LopHoc.MaGV == maNguoiDung
                         && x.NgayHoc.Date == DateTime.Today);

            lblTongBuoi.Text = buoi.ToString();


            //Khóa học

            int khoa = db.LopHocs
                         .Where(x => x.MaGV == maNguoiDung)
                         .Select(x => x.MaKH)
                         .Distinct()
                         .Count();

            lblTongKH.Text = khoa.ToString();
        }
        private void VeBieuDoHocVien()
        {
            chartHocVien.Series.Clear();

            Series s = new Series();

            s.ChartType = SeriesChartType.Column;

            var ds = db.LopHocs
                .Where(x => x.MaGV == maNguoiDung)
                .Select(x => new
                {
                    x.TenLop,
                    SoHV = db.BienLaiHocPhis
                            .Count(bl => bl.MaLop == x.MaLop)
                }).ToList();

            foreach (var item in ds)
            {
                s.Points.AddXY(item.TenLop, item.SoHV);
            }

            chartHocVien.Series.Add(s);
        }
        private void VeBieuDoDiem()
        {
            chartDiem.Series.Clear();

            Series s = new Series("Điểm TB");

            s.ChartType = SeriesChartType.Column;

            var ds = db.LopHocs
                .Where(l => l.MaGV == maNguoiDung)
                .ToList();

            foreach (var lop in ds)
            {
                double diemTB = db.KetQuaThis
                    .Where(k => k.MaLop == lop.MaLop)
                    .Average(k => (double?)k.DiemThi) ?? 0;

                s.Points.AddXY(lop.TenLop, Math.Round(diemTB, 2));
            }

            chartDiem.Series.Add(s);
        }
        private void LoadLichHomNay()
        {
            dataLichHomNay.DataSource =
                db.LichHocs
                .Where(x => x.LopHoc.MaGV == maNguoiDung
                         && x.NgayHoc.Date == DateTime.Today)
                .Select(x => new
                {
                    x.MaLop,
                    x.NgayHoc,
                    x.GioBatDau,
                    x.GioKetThuc,
                    x.PhongHoc,
                    x.NoiDungBuoi
                }).ToList();
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            // FrmThongTinGV frm = new FrmThongTinGV(maGV);

            //frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
            "Bạn có muốn đăng xuất không?",
            "Đăng xuất",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                FrmLoginChoose frm = new FrmLoginChoose();
                frm.Show();

                this.Hide();
            }
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void pnlHome_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
           pnlHome.ClientRectangle,
           Color.FromArgb(255, 236, 210),
           Color.FromArgb(255, 200, 150),
           LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, pnlHome.ClientRectangle);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblTongLop_Click(object sender, EventArgs e)
        {

        }

        private void FrmMainGV_Load(object sender, EventArgs e)
        {
            lblNgay.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");
            pnlHome.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(pnlHome);

            LoadThongTinGV();

            LoadThongKe();

            VeBieuDoHocVien();

            VeBieuDoDiem();

            LoadLichHomNay();

            
        }
    }
}
