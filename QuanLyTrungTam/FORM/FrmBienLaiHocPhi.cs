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
    public partial class FrmBienLaiHocPhi : Form
    {
        public FrmBienLaiHocPhi()
        {
            InitializeComponent();
            LoadBienLaiHocPhi();
        }
        private readonly DAL.DBContext db = new DAL.DBContext();

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

        private void dataBienLaiHocPhi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
