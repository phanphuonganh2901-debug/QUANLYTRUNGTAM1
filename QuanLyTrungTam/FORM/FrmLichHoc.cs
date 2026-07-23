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

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmLichHoc_Load_1(object sender, EventArgs e)
        {
            LoadLichHoc();

            cboMaLop.DataSource = db.LopHocs.ToList();
            cboMaLop.DisplayMember = "MaLop";
            cboMaLop.ValueMember = "MaLop";

            cboMaGV.DataSource = db.GiaoViens.ToList();
            cboMaGV.DisplayMember = "MaGV";
            cboMaGV.ValueMember = "MaGV";

            cboGioBatDau.Items.AddRange(new object[]
            {
        "07:00","08:00","09:00","10:00",
        "13:00","14:00","15:00","16:00","17:00"
            });

            cboGioKetThuc.Items.AddRange(new object[]
            {
        "08:00","09:00","10:00","11:00",
        "14:00","15:00","16:00","17:00","18:00"
            });

            if (vaiTro == "Admin")
            {
                dataLichHoc.DataSource = bus.GetAll();

                cboMaGV.Enabled = true;
            }

            else if (vaiTro == "GiaoVien")
            {
                dataLichHoc.DataSource = bus.GetByMaGV(maNguoiDung);

                cboMaGV.Text = maNguoiDung;
                cboMaGV.Enabled = false;
            }

            else if (vaiTro == "HocVien")
            {
                dataLichHoc.DataSource = bus.GetByHocVien(maNguoiDung);

                panelTop.Enabled = false;

                btnThem.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
                btnLoad.Visible = false;
            }
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

        private void dataLichHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtMaLich.Text = dataLichHoc.Rows[e.RowIndex].Cells["MaLich"].Value.ToString();

            cboMaLop.Text = dataLichHoc.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();

            cboMaGV.Text = dataLichHoc.Rows[e.RowIndex].Cells["MaGV"].Value.ToString();

            dtNgayHoc.Value = Convert.ToDateTime(
                dataLichHoc.Rows[e.RowIndex].Cells["NgayHoc"].Value);

            cboGioBatDau.Text = dataLichHoc.Rows[e.RowIndex].Cells["GioBatDau"].Value.ToString();

            cboGioKetThuc.Text = dataLichHoc.Rows[e.RowIndex].Cells["GioKetThuc"].Value.ToString();

            txtPhongHoc.Text = dataLichHoc.Rows[e.RowIndex].Cells["PhongHoc"].Value.ToString();

            txtNoiDung.Text = dataLichHoc.Rows[e.RowIndex].Cells["NoiDungBuoi"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLich.Text.Trim() == "")
            {
                MessageBox.Show("Nhập mã lịch!");
                return;
            }

            if (db.LichHocs.Any(x => x.MaLich == txtMaLich.Text))
            {
                MessageBox.Show("Mã lịch đã tồn tại!");
                return;
            }

            LichHoc lh = new LichHoc();

            lh.MaLich = txtMaLich.Text;
            lh.MaLop = cboMaLop.Text;

            if (vaiTro == "GiaoVien")
                lh.MaGV = maNguoiDung;
            else
                lh.MaGV = cboMaGV.Text;

            lh.NgayHoc = dtNgayHoc.Value;
            lh.GioBatDau = cboGioBatDau.Text;
            lh.GioKetThuc = cboGioKetThuc.Text;
            lh.PhongHoc = txtPhongHoc.Text;
            lh.NoiDungBuoi = txtNoiDung.Text;

            db.LichHocs.Add(lh);

            db.SaveChanges();

            LoadLichHoc();

            MessageBox.Show("Thêm thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var lh = db.LichHocs.Find(txtMaLich.Text);

            if (lh == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }

            lh.MaLich = txtMaLich.Text;
            lh.MaLop = cboMaLop.Text;

            if (vaiTro == "GiaoVien")
                lh.MaGV = maNguoiDung;
            else
                lh.MaGV = cboMaGV.Text;

            lh.NgayHoc = dtNgayHoc.Value;
            lh.GioBatDau = cboGioBatDau.Text;
            lh.GioKetThuc = cboGioKetThuc.Text;
            lh.PhongHoc = txtPhongHoc.Text;
            lh.NoiDungBuoi = txtNoiDung.Text;

            db.SaveChanges();

            LoadLichHoc();

            MessageBox.Show("Cập nhật thành công!");
        
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var lh = db.LichHocs.Find(txtMaLich.Text);

            if (lh == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }

            if (MessageBox.Show("Bạn muốn xóa?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.LichHocs.Remove(lh);

                db.SaveChanges();

                LoadLichHoc();

                MessageBox.Show("Đã xóa!");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtMaLich.Clear();
            txtPhongHoc.Clear();
            txtNoiDung.Clear();
            txtTimKiem.Clear();

            cboMaLop.SelectedIndex = -1;
            cboMaGV.SelectedIndex = -1;
            cboGioBatDau.SelectedIndex = -1;
            cboGioKetThuc.SelectedIndex = -1;

            dtNgayHoc.Value = DateTime.Now;

            LoadLichHoc();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = txtTimKiem.Text.Trim();

            dataLichHoc.DataSource = db.LichHocs
                .Where(x => x.MaLich.Contains(ma))
                .Select(x => new
                {
                    x.MaLich,
                    x.MaLop,
                    x.MaGV,
                    x.NgayHoc,
                    x.GioBatDau,
                    x.GioKetThuc,
                    x.PhongHoc,
                    x.NoiDungBuoi
                }).ToList();
        }
    }
}
