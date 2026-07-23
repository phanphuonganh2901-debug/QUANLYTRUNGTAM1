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
    public partial class FrmKetQuaThi : Form
    {
        private string vaiTro;
        private string maNguoiDung;
        public FrmKetQuaThi(string vaiTro, string maNguoiDung)
        {
            InitializeComponent();
            this.vaiTro = vaiTro;
            this.maNguoiDung = maNguoiDung;
        }
        DBContext db = new DBContext();
        private void LoadKetQuaThi()
        {
            dataKetQuaThi.DataSource = db.KetQuaThis
                .Select(x => new
                {
                    x.MaKQT,
                    x.NgayThi,
                    x.DiemThi,
                    x.SoBienLai,
                    x.MaLop,
                    x.MaGV,
                    x.MaHV,
                    x.XepLoai
                })
                .ToList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
            panel1.ClientRectangle,
            Color.FromArgb(255, 236, 210),
            Color.FromArgb(255, 200, 150),
            LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }
        }
        private string XepLoai(double diem)
        {
            if (diem >= 8)
                return "Giỏi";

            if (diem >= 6.5)
                return "Khá";

            if (diem >= 5)
                return "Trung bình";

            return "Yếu";
        }

        private void FrmKetQuaThi_Load(object sender, EventArgs e)
        {
            LoadKetQuaThi();
            PhanQuyen();
        }
        private void PhanQuyen()
        {
            if (vaiTro == "Admin")
            {
                // Admin chỉ được xem

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

                txtMaKQT.ReadOnly = true;
                txtDiemThi.ReadOnly = true;
                txtMaBL.ReadOnly = true;
                txtMaLop.ReadOnly = true;
                txtMaGV.ReadOnly = true;
                txtMaHV.ReadOnly = true;
                txtXepLoai.ReadOnly = true;

                dtNgayThi.Enabled = false;
            }
            else if (vaiTro == "GiaoVien")
            {
                // Giáo viên được thao tác

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                txtMaKQT.ReadOnly = false;
                txtDiemThi.ReadOnly = false;
                txtMaBL.ReadOnly = false;
                txtMaLop.ReadOnly = false;
                txtMaGV.ReadOnly = false;
                txtMaHV.ReadOnly = false;
                txtXepLoai.ReadOnly = true;
                // xếp loại tự tính

                dtNgayThi.Enabled = true;
            }
            else if (vaiTro == "HocVien")
            {
                // Học viên chỉ được xem
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                txtMaKQT.ReadOnly = true;
                txtDiemThi.ReadOnly = true;
                txtMaBL.ReadOnly = true;
                txtMaLop.ReadOnly = true;
                txtMaGV.ReadOnly = true;
                txtMaHV.ReadOnly = true;
                txtXepLoai.ReadOnly = true;
                dtNgayThi.Enabled = false;
            }
        }

        private void dataKetQuaThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtMaKQT.Text = dataKetQuaThi.Rows[e.RowIndex].Cells["MaKQT"].Value.ToString();

            dtNgayThi.Value = Convert.ToDateTime(
                dataKetQuaThi.Rows[e.RowIndex].Cells["NgayThi"].Value);

            txtDiemThi.Text = dataKetQuaThi.Rows[e.RowIndex].Cells["DiemThi"].Value.ToString();

            txtMaBL.Text = dataKetQuaThi.Rows[e.RowIndex].Cells["MaBienLai"].Value.ToString();

            txtMaLop.Text = dataKetQuaThi.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();

            txtMaGV.Text = dataKetQuaThi.Rows[e.RowIndex].Cells["MaGV"].Value.ToString();

            txtMaHV.Text = dataKetQuaThi.Rows[e.RowIndex].Cells["MaHV"].Value.ToString();

            txtXepLoai.Text = dataKetQuaThi.Rows[e.RowIndex].Cells["XepLoai"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKQT.Text.Trim() == "")
            {
                MessageBox.Show("Nhập mã kết quả thi");
                return;
            }

            if (db.KetQuaThis.Any(x => x.MaKQT == txtMaKQT.Text))
            {
                MessageBox.Show("Mã kết quả đã tồn tại");
                return;
            }

            double diem = Convert.ToDouble(txtDiemThi.Text);

            KetQuaThi kq = new KetQuaThi();

            kq.MaKQT = txtMaKQT.Text;
            kq.NgayThi = dtNgayThi.Value;
            kq.DiemThi = diem;
            kq.SoBienLai = txtMaBL.Text;
            kq.MaLop = txtMaLop.Text;
            kq.MaGV = txtMaGV.Text;
            kq.MaHV = txtMaHV.Text;
            kq.XepLoai = XepLoai(diem);

            db.KetQuaThis.Add(kq);

            db.SaveChanges();

            LoadKetQuaThi();

            MessageBox.Show("Thêm thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var kq = db.KetQuaThis.Find(txtMaKQT.Text);

            if (kq == null)
            {
                MessageBox.Show("Không tìm thấy kết quả");
                return;
            }

            double diem = Convert.ToDouble(txtDiemThi.Text);

            kq.NgayThi = dtNgayThi.Value;
            kq.DiemThi = diem;
            kq.SoBienLai = txtMaBL.Text;
            kq.MaLop = txtMaLop.Text;
            kq.MaGV = txtMaGV.Text;
            kq.MaHV = txtMaHV.Text;
            kq.XepLoai = XepLoai(diem);

            db.SaveChanges();

            LoadKetQuaThi();

            MessageBox.Show("Sửa thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var kq = db.KetQuaThis.Find(txtMaKQT.Text);

            if (kq == null)
            {
                MessageBox.Show("Không tìm thấy kết quả");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.KetQuaThis.Remove(kq);

                db.SaveChanges();

                LoadKetQuaThi();

                MessageBox.Show("Đã xóa");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtMaKQT.Clear();
            txtDiemThi.Clear();
            txtMaBL.Clear();
            txtMaLop.Clear();
            txtMaGV.Clear();
            txtMaHV.Clear();
            txtXepLoai.Clear();
            txtTimKiem.Clear();

            dtNgayThi.Value = DateTime.Now;

            txtMaKQT.Focus();

            LoadKetQuaThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = txtTimKiem.Text.Trim();

            if (ma == "")
            {
                LoadKetQuaThi();
                return;
            }

            dataKetQuaThi.DataSource = db.KetQuaThis
                .Where(x => x.MaKQT.Contains(ma))
                .Select(x => new
                {
                    x.MaKQT,
                    x.NgayThi,
                    x.DiemThi,
                    x.SoBienLai,
                    x.MaLop,
                    x.MaGV,
                    x.MaHV,
                    x.XepLoai
                })
                .ToList();
        }
        private void txtDiemThi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
