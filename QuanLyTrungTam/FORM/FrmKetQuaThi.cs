using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTam.FORM
{
    public partial class FrmKetQuaThi : Form
    {
        public FrmKetQuaThi()
        {
            InitializeComponent();
        }
        private readonly DAL.DBContext db = new DAL.DBContext();
        private void LoadKetQuaThi()
        {
            var ds = db.KetQuaThis!.Select(kq => new
            {
                kq.MaKQT,
                kq.SoBienLai,
                kq.MaHV,
                kq.MaGV,
                kq.NgayThi,
                kq.DiemThi,
                kq.XepLoai
            }).ToList();
            dgvKetQua.DataSource = ds;
        }
        private void FrmKetQuaThi_Load(object sender, EventArgs e)
        {
            LoadKetQuaThi();
            LoadLocKetQua();
        }
        private void LoadLocKetQua()
        {
            cboXepLoai.Items.Add("Tất cả");
            cboXepLoai.Items.Add("Gioi");
            cboXepLoai.Items.Add("Kha");
            cboXepLoai.Items.Add("Trung binh");
            cboXepLoai.Items.Add("Kem");
            cboXepLoai.SelectedIndex = 0;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            string xepLoai = cboXepLoai.Text;
            if (xepLoai == "Tất cả")
            {
                LoadKetQuaThi();
            }
            else
            {
                var results = db.KetQuaThis!.Where(k => k.XepLoai == xepLoai).ToList();
                dgvKetQua.DataSource = results;
                txtTongSo.Text = $"Loại {xepLoai}: {results.Count} kết quả";
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadKetQuaThi();
                return;
            }

            var results = db.KetQuaThis!.Where(k => k.MaHV.Contains(keyword) || k.MaGV.Contains(keyword)).ToList();
            dgvKetQua.DataSource = results;
            txtTongSo.Text = $"Tìm được: {results.Count} kết quả";
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            var results = db.KetQuaThis!.OrderByDescending(k => k.DiemThi).Take(10).ToList();
            dgvKetQua.DataSource = results;
            txtTongSo.Text = $"Top 10 điểm cao: {results.Count} kết quả";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cboXepLoai.SelectedIndex = 0;
            LoadKetQuaThi();
        }
    }
}
