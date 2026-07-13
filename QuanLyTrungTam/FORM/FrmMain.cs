using QuanLyTrungTam.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public FrmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;
        }
        private Form currentForm = null;

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
        private void VeBieuDo()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            ChartArea area = new ChartArea();
            chart1.ChartAreas.Add(area);

            Series series = new Series("Số học viên");

            series.ChartType = SeriesChartType.Column;

            Random rd = new Random();

            for (int i = 1; i <= 12; i++)
            {
                series.Points.AddXY("T" + i, rd.Next(20, 100));
            }

            chart1.Series.Add(series);
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblXinChao.Text = "Xin chào, Admin";

            lblNgay.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");

            pnlHome.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(pnlHome);

            LoadThongKe();

            VeBieuDo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHocVien());
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
            OpenChildForm(new FrmGiaoVien());
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
            OpenChildForm(new FrmKetQuaThi());
        }

        private void btnHocPhi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBienLaiHocPhi());
        }
    }
}
