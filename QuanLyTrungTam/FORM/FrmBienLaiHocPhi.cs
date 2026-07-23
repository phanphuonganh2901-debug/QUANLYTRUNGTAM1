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
    public partial class FrmBienLaiHocPhi : Form
    {
        public FrmBienLaiHocPhi()
        {
            InitializeComponent();
            LoadBienLaiHocPhi();
        }

        DBContext db = new DBContext();
        public void LoadBienLaiHocPhi()
        {
            var ds = db.BienLaiHocPhis!.Select(bl => new
            {
                bl.SoBienLai,
                bl.MaHV,
                bl.MaLop,
                bl.MaKH,
                bl.TienNop,
                bl.NgayNop,
                bl.NguoiThu
            }).ToList();
            dataBienLaiHocPhi.DataSource = ds;
        }
        private void label4_Click(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataBienLaiHocPhi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtSoBienLai.Text = dataBienLaiHocPhi.Rows[e.RowIndex].Cells["MaBienLai"].Value.ToString();

            dtNgayNop.Value = Convert.ToDateTime(
                dataBienLaiHocPhi.Rows[e.RowIndex].Cells["NgayNop"].Value);

            txtTienNop.Text = dataBienLaiHocPhi.Rows[e.RowIndex].Cells["SoTienNop"].Value.ToString();

            txtNguoiThu.Text = dataBienLaiHocPhi.Rows[e.RowIndex].Cells["NguoiThu"].Value.ToString();

            txtMaLop.Text = dataBienLaiHocPhi.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();

            txtMaKH.Text = dataBienLaiHocPhi.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();

            txtMaHV.Text = dataBienLaiHocPhi.Rows[e.RowIndex].Cells["MaHV"].Value.ToString();

        }

        private void FrmBienLaiHocPhi_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoBienLai.Text.Trim() == "")
            {
                MessageBox.Show("Nhập số biên lai");
                return;
            }

            if (db.BienLaiHocPhis.Any(x => x.SoBienLai == txtSoBienLai.Text))
            {
                MessageBox.Show("Biên lai đã tồn tại");
                return;
            }

            BienLaiHocPhi bl = new BienLaiHocPhi();

            bl.SoBienLai = txtSoBienLai.Text;
            bl.NgayNop = dtNgayNop.Value;
            bl.TienNop = decimal.Parse(txtTienNop.Text);
            bl.NguoiThu = txtNguoiThu.Text;
            bl.MaLop = txtMaLop.Text;
            bl.MaKH = txtMaKH.Text;
            bl.MaHV = txtMaHV.Text;

            db.BienLaiHocPhis.Add(bl);

            db.SaveChanges();

            LoadBienLaiHocPhi();

            MessageBox.Show("Thêm thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var bl = db.BienLaiHocPhis.Find(txtSoBienLai.Text);

            if (bl == null)
            {
                MessageBox.Show("Không tìm thấy biên lai");
                return;
            }

            bl.NgayNop = dtNgayNop.Value;
            bl.TienNop = decimal.Parse(txtTienNop.Text);
            bl.NguoiThu = txtNguoiThu.Text;
            bl.MaLop = txtMaLop.Text;
            bl.MaKH = txtMaKH.Text;
            bl.MaHV = txtMaHV.Text;

            db.SaveChanges();

            LoadBienLaiHocPhi();

            MessageBox.Show("Sửa thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var bl = db.BienLaiHocPhis.Find(txtSoBienLai.Text);

            if (bl == null)
            {
                MessageBox.Show("Không tìm thấy biên lai");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.BienLaiHocPhis.Remove(bl);

                db.SaveChanges();

                LoadBienLaiHocPhi();

                MessageBox.Show("Đã xóa");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtSoBienLai.Clear();

            txtNguoiThu.Clear();

            txtTienNop.Clear();

            txtMaLop.Clear();

            txtMaKH.Clear();

            txtMaHV.Clear();

            txtTimKiem.Clear();

            dtNgayNop.Value = DateTime.Now;

            txtSoBienLai.Focus();

            LoadBienLaiHocPhi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = txtTimKiem.Text.Trim();

            if (ma == "")
            {
                LoadBienLaiHocPhi();
                return;
            }

            dataBienLaiHocPhi.DataSource = db.BienLaiHocPhis
                .Where(x => x.SoBienLai.Contains(ma))
                .Select(x => new
                {
                    x.SoBienLai,
                    x.NgayNop,
                    x.TienNop,
                    x.NguoiThu,
                    x.MaLop,
                    x.MaKH,
                    x.MaHV
                })
                .ToList();
        }
        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
