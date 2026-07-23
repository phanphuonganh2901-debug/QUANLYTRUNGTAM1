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
    public partial class FrmLopHoc : Form
    {
        public FrmLopHoc()
        {
            InitializeComponent();
        }
        DBContext db = new DBContext();

        private void LoadData()
        {
            dataLopHoc.DataSource = db.LopHocs
                .Select(x => new
                {
                    x.MaLop,
                    x.TenLop,
                    x.SiSo,
                    x.PhongHoc,
                    x.MaGV,
                    x.MaKH
                })
                .ToList();
        }

        private void FrmLopHoc_Load(object sender, EventArgs e)
        {
            LoadData();
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

        private void dataLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtMaLop.Text = dataLopHoc.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();

            txtTenLop.Text = dataLopHoc.Rows[e.RowIndex].Cells["TenLop"].Value.ToString();

            txtSiSo.Text = dataLopHoc.Rows[e.RowIndex].Cells["SiSo"].Value.ToString();

            txtPhongHoc.Text = dataLopHoc.Rows[e.RowIndex].Cells["PhongHoc"].Value.ToString();

            txtMaGV.Text = dataLopHoc.Rows[e.RowIndex].Cells["MaGV"].Value.ToString();

            txtMaKH.Text = dataLopHoc.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã lớp!");
                return;
            }

            // Kiểm tra sĩ số
            if (!int.TryParse(txtSiSo.Text, out int siSo))
            {
                MessageBox.Show("Sĩ số phải là số nguyên!");
                txtSiSo.Focus();
                return;
            }

            if (siSo <= 0)
            {
                MessageBox.Show("Sĩ số phải lớn hơn 0!");
                txtSiSo.Focus();
                return;
            }

            if (db.LopHocs.Any(x => x.MaLop == txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp đã tồn tại!");
                return;
            }

            LopHoc lh = new LopHoc();

            lh.MaLop = txtMaLop.Text;
            lh.TenLop = txtTenLop.Text;
            lh.SiSo = siSo;        // dùng biến đã kiểm tra
            lh.PhongHoc = txtPhongHoc.Text;
            lh.MaGV = txtMaGV.Text;
            lh.MaKH = txtMaKH.Text;

            db.LopHocs.Add(lh);
            db.SaveChanges();

            LoadData();

            MessageBox.Show("Thêm thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra sĩ số
            if (!int.TryParse(txtSiSo.Text, out int siSo))
            {
                MessageBox.Show("Sĩ số phải là số nguyên!");
                txtSiSo.Focus();
                return;
            }

            if (siSo <= 0)
            {
                MessageBox.Show("Sĩ số phải lớn hơn 0!");
                txtSiSo.Focus();
                return;
            }

            var lh = db.LopHocs.Find(txtMaLop.Text);

            if (lh == null)
            {
                MessageBox.Show("Không tìm thấy lớp!");
                return;
            }

            lh.TenLop = txtTenLop.Text;
            lh.SiSo = siSo;        // dùng biến đã kiểm tra
            lh.PhongHoc = txtPhongHoc.Text;
            lh.MaGV = txtMaGV.Text;
            lh.MaKH = txtMaKH.Text;

            db.SaveChanges();

            LoadData();

            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var lh = db.LopHocs.Find(txtMaLop.Text);

            if (lh == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.LopHocs.Remove(lh);

                db.SaveChanges();

                LoadData();

                MessageBox.Show("Đã xóa!");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtSiSo.Clear();
            txtPhongHoc.Clear();
            txtMaGV.Clear();
            txtMaKH.Clear();
            txtTimKiem.Clear();

            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = txtTimKiem.Text.Trim();

            dataLopHoc.DataSource = db.LopHocs
                .Where(x => x.MaLop.Contains(ma))
                .Select(x => new
                {
                    x.MaLop,
                    x.TenLop,
                    x.SiSo,
                    x.PhongHoc,
                    x.MaGV,
                    x.MaKH
                })
                .ToList();
        }

        
    }
}
