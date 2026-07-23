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
    public partial class FrmQuanLyTaiKhoan : Form
    {
        DBContext db = new DBContext();
        public FrmQuanLyTaiKhoan()
        {
            InitializeComponent();
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



        private void FrmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            cboVaiTro.Items.Clear();
            cboVaiTro.Items.Add("Admin");
            cboVaiTro.Items.Add("GiaoVien");
            cboVaiTro.Items.Add("HocVien");

            cboVaiTro.SelectedIndex = 0;

            LoadData();
        }
        private void LoadData()
        {
            dataTaiKhoan.DataSource = db.TaiKhoans
                .Select(x => new
                {
                    x.TenDangNhap,
                    x.MatKhau,
                    x.VaiTro,
                    x.MaNguoiDung
                })
                .ToList();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtTenDangNhap.Text = dataTaiKhoan.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();

            txtMatKhau.Text = dataTaiKhoan.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();

            cboVaiTro.Text = dataTaiKhoan.Rows[e.RowIndex].Cells["VaiTro"].Value.ToString();

            txtMaNguoiDung.Text = dataTaiKhoan.Rows[e.RowIndex].Cells["MaNguoiDung"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "" ||
        txtMatKhau.Text.Trim() == "" ||
        txtMaNguoiDung.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // 1. Kiểm tra tên đăng nhập
            if (db.TaiKhoans.Any(x => x.TenDangNhap == txtTenDangNhap.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                return;
            }

            // 2. Kiểm tra mã người dùng đã có tài khoản
            if (db.TaiKhoans.Any(x => x.MaNguoiDung == txtMaNguoiDung.Text))
            {
                MessageBox.Show("Mã người dùng đã có tài khoản!");
                return;
            }

            
            // 3. Kiểm tra mã tồn tại
            bool tonTai = false;

            if (cboVaiTro.Text == "GiaoVien")
                tonTai = db.GiaoViens.Any(x => x.MaGV == txtMaNguoiDung.Text);

            else if (cboVaiTro.Text == "HocVien")
                tonTai = db.HocViens.Any(x => x.MaHV == txtMaNguoiDung.Text);

            else if (cboVaiTro.Text == "Admin")
                tonTai = true;

            if (!tonTai)
            {
                MessageBox.Show("Mã người dùng không tồn tại!");
                return;
            }
            // 4. Thêm tài khoản
            TaiKhoan tk = new TaiKhoan();

            tk.TenDangNhap = txtTenDangNhap.Text;
            tk.MatKhau = txtMatKhau.Text;
            tk.VaiTro = cboVaiTro.Text;
            tk.MaNguoiDung = txtMaNguoiDung.Text;

            db.TaiKhoans.Add(tk);
            db.SaveChanges();

            LoadData();

            MessageBox.Show("Thêm thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var tk = db.TaiKhoans.Find(txtTenDangNhap.Text);

            if (tk == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản!");
                return;
            }

            tk.MatKhau = txtMatKhau.Text;
            tk.VaiTro = cboVaiTro.Text;
            tk.MaNguoiDung = txtMaNguoiDung.Text;

            db.SaveChanges();

            LoadData();

            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var tk = db.TaiKhoans.Find(txtTenDangNhap.Text);

            if (tk == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.TaiKhoans.Remove(tk);

                db.SaveChanges();

                LoadData();

                MessageBox.Show("Đã xóa!");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtMaNguoiDung.Clear();
            txtTimKiem.Clear();

            cboVaiTro.SelectedIndex = 0;

            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = txtTimKiem.Text.Trim();

            dataTaiKhoan.DataSource = db.TaiKhoans
                .Where(x => x.MaNguoiDung.Contains(ma))
                .Select(x => new
                {
                    x.TenDangNhap,
                    x.MatKhau,
                    x.VaiTro,
                    x.MaNguoiDung
                })
                .ToList();
        }
    }
}
