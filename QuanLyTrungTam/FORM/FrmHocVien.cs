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
    public partial class FrmHocVien : Form
    {
        public FrmHocVien()
        {
            InitializeComponent();
            LoadHocVien();
        }
        DBContext db = new DBContext();
        public void LoadHocVien()
        {
            var ds = db.HocViens!.Select(hv => new
            {
                hv.MaHV,
                hv.CMND,
                hv.TenHV,
                hv.NgaySinh,
                hv.NgheNghiep
            }).ToList();
            dataHocVien.DataSource = ds;
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

        private void dataHocVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtMaHV.Text = dataHocVien.Rows[e.RowIndex].Cells["MaHV"].Value.ToString();

            txtHoTen.Text = dataHocVien.Rows[e.RowIndex].Cells["TenHV"].Value.ToString();

            dtNgaySinh.Value = Convert.ToDateTime(
                dataHocVien.Rows[e.RowIndex].Cells["NgaySinh"].Value);

            txtCMND.Text = dataHocVien.Rows[e.RowIndex].Cells["CMND"].Value.ToString();

            txtNgheNghiep.Text = dataHocVien.Rows[e.RowIndex].Cells["NgheNghiep"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHV.Text.Trim() == "")
            {
                MessageBox.Show("Nhập mã học viên");
                return;
            }

            if (db.HocViens.Any(x => x.MaHV == txtMaHV.Text))
            {
                MessageBox.Show("Mã học viên đã tồn tại");
                return;
            }

            HocVien hv = new HocVien();

            hv.MaHV = txtMaHV.Text;
            hv.TenHV = txtHoTen.Text;
            hv.NgaySinh = dtNgaySinh.Value;
            hv.CMND = txtCMND.Text;
            hv.NgheNghiep = txtNgheNghiep.Text;

            db.HocViens.Add(hv);

            db.SaveChanges();

            LoadHocVien();

            MessageBox.Show("Thêm thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var hv = db.HocViens.Find(txtMaHV.Text);

            if (hv == null)
            {
                MessageBox.Show("Không tìm thấy học viên");
                return;
            }

            hv.TenHV = txtHoTen.Text;
            hv.NgaySinh = dtNgaySinh.Value;
            hv.CMND = txtCMND.Text;
            hv.NgheNghiep = txtNgheNghiep.Text;

            db.SaveChanges();

            LoadHocVien();

            MessageBox.Show("Sửa thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var hv = db.HocViens.Find(txtMaHV.Text);

            if (hv == null)
            {
                MessageBox.Show("Không tìm thấy học viên");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.HocViens.Remove(hv);

                db.SaveChanges();

                LoadHocVien();

                MessageBox.Show("Đã xóa");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtMaHV.Clear();
            txtHoTen.Clear();
            txtCMND.Clear();
            txtNgheNghiep.Clear();
            txtTimKiem.Clear();

            dtNgaySinh.Value = DateTime.Now;

            txtMaHV.Focus();

            LoadHocVien();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = txtTimKiem.Text.Trim();

            if (ma == "")
            {
                LoadHocVien();
                return;
            }

            dataHocVien.DataSource = db.HocViens
                .Where(x => x.MaHV.Contains(ma))
                .Select(x => new
                {
                    x.MaHV,
                    x.TenHV,
                    x.NgaySinh,
                    x.CMND,
                    x.NgheNghiep
                }).ToList();
        }
        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
