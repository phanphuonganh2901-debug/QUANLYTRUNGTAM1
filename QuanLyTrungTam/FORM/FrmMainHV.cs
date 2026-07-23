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
    public partial class FrmMainHV : Form
    {
        DBContext db = new DBContext();

        private string vaiTro;
        private string maNguoiDung;
        public FrmMainHV(string vaiTro, string maNguoiDung)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
            this.maNguoiDung = maNguoiDung;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

            lblNgay.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");

            pnlHome.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(pnlHome);

            LoadThongTinHV();


            VeBieuDoDiem();

            LoadLichHomNay();


        }
        private void LoadThongTinHV()
        {
            var hv = db.HocViens.FirstOrDefault(x => x.MaHV == maNguoiDung);

            if (hv == null) return;

            lblXinChao.Text = "Xin chào, " + hv.TenHV;

            lblTenHV.Text = hv.TenHV;
            lblMaHV.Text = hv.MaHV;
            lblNgaySinh.Text = hv.NgaySinh.ToString("dd/MM/yyyy");
            lblNgheNghiep.Text = hv.NgheNghiep;
            lblCMND.Text = hv.CMND;
        }

        private void LoadLichHomNay()
        {
            var ds = from bl in db.BienLaiHocPhis
                     join lh in db.LichHocs
                     on bl.MaLop equals lh.MaLop
                     where bl.MaHV == maNguoiDung
                     && lh.NgayHoc.Date == DateTime.Today
                     select new
                     {
                         lh.MaLop,
                         lh.NgayHoc,
                         lh.GioBatDau,
                         lh.GioKetThuc,
                         lh.PhongHoc,
                         lh.NoiDungBuoi
                     };

            dataLichHomNay.DataSource = ds.ToList();
        }

        private void VeBieuDoDiem()
        {
            chartDiem.Series.Clear();

            Series s = new Series("Điểm");

            s.ChartType = SeriesChartType.Column;

            var ds = db.KetQuaThis
                .Where(x => x.MaHV == maNguoiDung)
                .Select(x => new
                {
                    x.MaLop,
                    x.DiemThi
                }).ToList();

            foreach (var item in ds)
            {
                s.Points.AddXY(item.MaLop, item.DiemThi);
            }

            chartDiem.Series.Add(s);
        }
        private void OpenForm(Form frm)
        {
            pnlMain.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(frm);
            frm.Show();
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(pnlHome);
            pnlHome.Dock = DockStyle.Fill;
            pnlHome.BringToFront();
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

        private void lblHocPhiCon_Click(object sender, EventArgs e)
        {
            decimal tongHocPhi = db.BienLaiHocPhis
                        .Where(x => x.MaHV == maNguoiDung)
                        .Sum(x => (decimal?)x.TienNop) ?? 0;

            lblHocPhiCon.Text = tongHocPhi.ToString("N0");
        }

        private void FrmMainHV_Load(object sender, EventArgs e)
        {

        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void lblTongHV_Click(object sender, EventArgs e)
        {
            int soLop = db.BienLaiHocPhis
            .Where(x => x.MaHV == maNguoiDung)
            .Select(x => x.MaLop)
            .Distinct()
            .Count();

            lblTongLop.Text = soLop.ToString();
        }

        private void lblTongKH_Click(object sender, EventArgs e)
        {
            int khoaHoc = db.BienLaiHocPhis
        .Where(x => x.MaHV == maNguoiDung)
        .Select(x => x.MaKH)
        .Distinct()
        .Count();

            lblTongKH.Text = khoaHoc.ToString();
        }

        private void lblDiemTB_Click(object sender, EventArgs e)
        {
            double diemTB = db.KetQuaThis
                .Where(x => x.MaHV == maNguoiDung)
                .Average(x => (double?)x.DiemThi) ?? 0;

            lblDiemTB.Text = diemTB.ToString("0.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmHocVien frm = new FrmHocVien();

            frm.ShowDialog();
        }

        private void btnKetQuaThi_Click(object sender, EventArgs e)
        {
            FrmKetQuaThi frm = new FrmKetQuaThi(vaiTro, maNguoiDung);
            OpenForm(frm);
        }

        private void btnLichHoc_Click(object sender, EventArgs e)
        {
            FrmLichHoc frm = new FrmLichHoc(vaiTro, maNguoiDung);
            OpenForm(frm);
        }

        private void btnKhoaHoc_Click(object sender, EventArgs e)
        {
            FrmKhoaHoc frm = new FrmKhoaHoc(vaiTro, maNguoiDung);
            OpenForm(frm);
        }

        private void btnHocPhi_Click(object sender, EventArgs e)
        {
            FrmBienLaiHocPhi frm = new FrmBienLaiHocPhi();
            OpenForm(frm);
        }
    }
}
