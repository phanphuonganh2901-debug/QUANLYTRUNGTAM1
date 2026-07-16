using QuanLyTrungTam.BUS;
using QuanLyTrungTam.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyTrungTam.FORM
{
    public partial class FrmMain : Form
    {
        GiaoVienBUS gvBUS = new GiaoVienBUS();
        HocVienBUS hvBUS = new HocVienBUS();
        LopHocBUS lopBUS = new LopHocBUS();
        BienLaiHocPhiBUS blBUS = new BienLaiHocPhiBUS();
        KetQuaThiBUS kqBUS = new KetQuaThiBUS();

        public FrmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;

        }
        private Form currentForm = null;

        private string vaiTro;
        private string maNguoiDung;

        public FrmMain(string vaiTro, string maNguoiDung)
        {
            InitializeComponent();

            this.vaiTro = vaiTro;
            this.maNguoiDung = maNguoiDung;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblXinChao.Text = "Xin chào, Admin";

            lblNgay.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");

            pnlHome.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(pnlHome);

            LoadThongKe();

            VeBieuDoHocVien();

            VeChartKetQua();

            panelGiaoVien.Visible = false;
            panelHocVien.Visible = false;
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentForm != null)
                currentForm.Close();

            currentForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(childForm);

            childForm.BringToFront();
            childForm.Show();
        }
        private void LoadThongKe()
        {
            lblTongHocVien.Text = hvBUS.GetAll().Count.ToString();

            lblTongGiaoVien.Text = gvBUS.GetAll().Count.ToString();

            lblTongLop.Text = lopBUS.GetAll().Count.ToString();

            decimal tongHocPhi = 0;

            foreach (var item in blBUS.GetAll())
            {
                tongHocPhi += item.TienNop;
            }

            lblTongHocPhi.Text = tongHocPhi.ToString("N0") + " VNĐ";
        }
        private void VeBieuDoHocVien()
        {
            chartHocVien.Series.Clear();
            chartHocVien.ChartAreas.Clear();

            ChartArea area = new ChartArea();
            chartHocVien.ChartAreas.Add(area);

            Series s = new Series("Học viên đăng ký");
            s.ChartType = SeriesChartType.Column;
            s.IsValueShownAsLabel = true;
            s["PointWidth"] = "0.5";
            chartHocVien.Series.Add(s);

            var ds = blBUS.GetAll();

            // Mỗi tháng chỉ có 1 giá trị
            var thongKe = ds
                .GroupBy(x => x.NgayNop.Month)
                .Select(g => new
                {
                    Thang = g.Key,
                    SoHV = g.Select(x => x.MaHV).Distinct().Count()
                })
                .OrderBy(x => x.Thang)
                .ToList();

            for (int thang = 1; thang <= 12; thang++)
            {
                var item = thongKe.FirstOrDefault(x => x.Thang == thang);

                if (item == null)
                    s.Points.AddXY("T" + thang, 0);
                else
                    s.Points.AddXY("T" + thang, item.SoHV);
            }
        }
        private void VeChartKetQua()
        {
            chartKetQua.Series.Clear();
            chartKetQua.ChartAreas.Clear();
            chartKetQua.Legends.Clear();
            chartKetQua.Titles.Clear();

            ChartArea area = new ChartArea();
            chartKetQua.ChartAreas.Add(area);

            chartKetQua.Titles.Add("Tỷ lệ học viên theo xếp loại");

            Legend legend = new Legend();
            legend.Docking = Docking.Right;
            chartKetQua.Legends.Add(legend);

            Series s = new Series("Xếp loại");
            s.ChartType = SeriesChartType.Pie;

            s.IsValueShownAsLabel = true;

            //Hiển thị:
            //Giỏi
            //25%
            s.Label = "#VALX\n#PERCENT{P0}";

            s["PieLabelStyle"] = "Outside";
            s["PieLineColor"] = "Black";

            var data = kqBUS.ThongKeXepLoai();

            foreach (var item in data)
            {
                int index = s.Points.AddXY(item.Key, item.Value);

                switch (item.Key)
                {
                    case "Gioi":
                        s.Points[index].Color = Color.LimeGreen;
                        break;

                    case "Kha":
                        s.Points[index].Color = Color.DeepSkyBlue;
                        break;

                    case "TrungBinh":
                        s.Points[index].Color = Color.Gold;
                        break;

                    case "Kem":
                        s.Points[index].Color = Color.IndianRed;
                        break;
                }
            }

            chartKetQua.Series.Add(s);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelHocVien.Visible = !panelHocVien.Visible;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void lblTongHocVien_Click(object sender, EventArgs e)
        {

        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            panelGiaoVien.Visible = !panelGiaoVien.Visible;
        }

        private void FrmMain_Load_1(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm = null;
            }

            pnlMain.Controls.Clear();

            pnlHome.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(pnlHome);

            pnlHome.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQuanLyTaiKhoan());
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLopHoc());
        }

        private void btnKhoaHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKhoaHoc());
        }

        private void btnKetQuaThi_Click(object sender, EventArgs e)
        {

        }

        private void btnHocPhi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBienLaiHocPhi());
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDSHV_Click(object sender, EventArgs e)
        {

        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKetQuaThi());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGiaoVien());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLichHoc(vaiTro, maNguoiDung));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHocVien());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKetQuaThi());
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
    }
}
