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
    public partial class FrmGiaoVien : Form
    {
        public FrmGiaoVien()
        {
            InitializeComponent();
            LoadGiaoVien();
        }
        DBContext db = new DBContext();
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Nhập mã giáo viên");
                return;
            }

            if (db.GiaoViens.Any(x => x.MaGV == txtMaGV.Text))
            {
                MessageBox.Show("Mã giáo viên đã tồn tại");
                return;
            }

            GiaoVien gv = new GiaoVien();

            gv.MaGV = txtMaGV.Text;
            gv.TenGV = txtHoTen.Text;
            gv.NgaySinh = dtNgaySinh.Value;
            gv.SDT = txtSDT.Text;
            gv.DiaChi = txtDiaChi.Text;

            db.GiaoViens.Add(gv);
            db.SaveChanges();

            LoadGiaoVien();

            MessageBox.Show("Thêm thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var gv = db.GiaoViens.Find(txtMaGV.Text);

            if (gv == null)
            {
                MessageBox.Show("Không tìm thấy giáo viên");
                return;
            }

            gv.TenGV = txtHoTen.Text;
            gv.NgaySinh = dtNgaySinh.Value;
            gv.SDT = txtSDT.Text;
            gv.DiaChi = txtDiaChi.Text;

            db.SaveChanges();

            LoadGiaoVien();

            MessageBox.Show("Sửa thành công");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var gv = db.GiaoViens.Find(txtMaGV.Text);

            if (gv == null)
            {
                MessageBox.Show("Không tìm thấy giáo viên");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.GiaoViens.Remove(gv);

                db.SaveChanges();

                LoadGiaoVien();

                MessageBox.Show("Đã xóa");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtMaGV.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();

            dtNgaySinh.Value = DateTime.Now;

            txtMaGV.Focus();

            LoadGiaoVien();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = txtTimKiem.Text.Trim();

            if (ma == "")
            {
                LoadGiaoVien();
                return;
            }

            dataGiaoVien.DataSource = db.GiaoViens
                .Where(x => x.MaGV.Contains(ma))
                .Select(x => new
                {
                    x.MaGV,
                    x.TenGV,
                    x.NgaySinh,
                    x.SDT,
                    x.DiaChi
                })
                .ToList();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtMaGV.Text = dataGiaoVien.Rows[e.RowIndex].Cells["MaGV"].Value.ToString();
            txtHoTen.Text = dataGiaoVien.Rows[e.RowIndex].Cells["TenGV"].Value.ToString();
            txtHoTen.Text = dataGiaoVien.Rows[e.RowIndex].Cells["TenGV"].Value.ToString();
            txtSDT.Text = dataGiaoVien.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            txtDiaChi.Text = dataGiaoVien.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();

            dtNgaySinh.Value = Convert.ToDateTime(
                dataGiaoVien.Rows[e.RowIndex].Cells["NgaySinh"].Value);
        }
    }
}
