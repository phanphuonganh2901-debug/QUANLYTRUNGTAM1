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
    public partial class FrmKhoaHoc : Form
    {
        private string vaiTro;
        private string maNguoiDung;
        public FrmKhoaHoc(string vaiTro, string maNguoiDung)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
            this.maNguoiDung = maNguoiDung;
        }
        DBContext db = new DBContext();
        public void LoadKhoaHoc()
        {
            var ds = db.KhoaHocs!.Select(kh => new
            {
                kh.MaKH,
                kh.TenKH,
                kh.NgayBatDau,
                kh.NgayKetThuc

            }).ToList();
            dataKhoaHoc.DataSource = ds;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
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

        private void FrmKhoaHoc_Load(object sender, EventArgs e)
        {
            LoadKhoaHoc();
        }

        private void dataKhoaHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtMaKH.Text = dataKhoaHoc.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();

            txtTenKH.Text = dataKhoaHoc.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();

            dtNgayBatDau.Value = Convert.ToDateTime(
                dataKhoaHoc.Rows[e.RowIndex].Cells["NgayBatDau"].Value);

            dtNgayKetThuc.Value = Convert.ToDateTime(
                dataKhoaHoc.Rows[e.RowIndex].Cells["NgayKetThuc"].Value);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() == "" || txtTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (db.KhoaHocs.Any(x => x.MaKH == txtMaKH.Text))
            {
                MessageBox.Show("Mã khóa học đã tồn tại!");
                return;
            }

            if (dtNgayKetThuc.Value < dtNgayBatDau.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!");
                return;
            }

            KhoaHoc kh = new KhoaHoc();

            kh.MaKH = txtMaKH.Text;
            kh.TenKH = txtTenKH.Text;
            kh.NgayBatDau = dtNgayBatDau.Value;
            kh.NgayKetThuc = dtNgayKetThuc.Value;

            db.KhoaHocs.Add(kh);

            db.SaveChanges();

            LoadKhoaHoc();

            MessageBox.Show("Thêm thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var kh = db.KhoaHocs.Find(txtMaKH.Text);

            if (kh == null)
            {
                MessageBox.Show("Không tìm thấy khóa học!");
                return;
            }

            if (dtNgayKetThuc.Value < dtNgayBatDau.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!");
                return;
            }

            kh.TenKH = txtTenKH.Text;
            kh.NgayBatDau = dtNgayBatDau.Value;
            kh.NgayKetThuc = dtNgayKetThuc.Value;

            db.SaveChanges();

            LoadKhoaHoc();

            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var kh = db.KhoaHocs.Find(txtMaKH.Text);

            if (kh == null)
            {
                MessageBox.Show("Không tìm thấy khóa học!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xóa?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                db.KhoaHocs.Remove(kh);

                db.SaveChanges();

                LoadKhoaHoc();

                MessageBox.Show("Đã xóa!");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtTimKiem.Clear();

            dtNgayBatDau.Value = DateTime.Now;
            dtNgayKetThuc.Value = DateTime.Now;

            txtMaKH.Focus();

            LoadKhoaHoc();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = txtTimKiem.Text.Trim();

            if (ma == "")
            {
                LoadKhoaHoc();
                return;
            }

            dataKhoaHoc.DataSource = db.KhoaHocs
                .Where(x => x.MaKH.Contains(ma))
                .Select(x => new
                {
                    x.MaKH,
                    x.TenKH,
                    x.NgayBatDau,
                    x.NgayKetThuc
                })
                .ToList();

        }
    }
}
