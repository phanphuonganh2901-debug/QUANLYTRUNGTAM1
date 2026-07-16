namespace QuanLyTrungTam.FORM
{
    partial class FrmLichHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            cboGioKT = new ComboBox();
            cboGioBD = new ComboBox();
            cboGiaoVien = new ComboBox();
            label10 = new Label();
            cboLop = new ComboBox();
            dtpNgayHoc = new DateTimePicker();
            txtNoiDung = new TextBox();
            label9 = new Label();
            txtPhongHoc = new TextBox();
            label8 = new Label();
            txtMaLich = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            dgvLichHoc = new DataGridView();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLoad = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panelTop.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichHoc).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(txtTimKiem);
            panelTop.Controls.Add(btnTimKiem);
            panelTop.Controls.Add(btnLoad);
            panelTop.Controls.Add(btnXoa);
            panelTop.Controls.Add(btnSua);
            panelTop.Controls.Add(btnThem);
            panelTop.Controls.Add(cboGioKT);
            panelTop.Controls.Add(cboGioBD);
            panelTop.Controls.Add(cboGiaoVien);
            panelTop.Controls.Add(label10);
            panelTop.Controls.Add(cboLop);
            panelTop.Controls.Add(dtpNgayHoc);
            panelTop.Controls.Add(txtNoiDung);
            panelTop.Controls.Add(label9);
            panelTop.Controls.Add(txtPhongHoc);
            panelTop.Controls.Add(label8);
            panelTop.Controls.Add(txtMaLich);
            panelTop.Controls.Add(label7);
            panelTop.Controls.Add(label6);
            panelTop.Controls.Add(label5);
            panelTop.Controls.Add(label4);
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(label2);
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1082, 226);
            panelTop.TabIndex = 4;
            panelTop.Paint += panelTop_Paint;
            // 
            // cboGioKT
            // 
            cboGioKT.FormattingEnabled = true;
            cboGioKT.Location = new Point(828, 82);
            cboGioKT.Name = "cboGioKT";
            cboGioKT.Size = new Size(151, 28);
            cboGioKT.TabIndex = 46;
            // 
            // cboGioBD
            // 
            cboGioBD.FormattingEnabled = true;
            cboGioBD.Location = new Point(466, 77);
            cboGioBD.Name = "cboGioBD";
            cboGioBD.Size = new Size(151, 28);
            cboGioBD.TabIndex = 45;
            // 
            // cboGiaoVien
            // 
            cboGiaoVien.FormattingEnabled = true;
            cboGiaoVien.Location = new Point(156, 114);
            cboGiaoVien.Name = "cboGiaoVien";
            cboGiaoVien.Size = new Size(151, 28);
            cboGiaoVien.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(69, 117);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 43;
            label10.Text = "Giáo Viên";
            label10.Click += label10_Click;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(156, 81);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(151, 28);
            cboLop.TabIndex = 42;
            // 
            // dtpNgayHoc
            // 
            dtpNgayHoc.Location = new Point(468, 46);
            dtpNgayHoc.Name = "dtpNgayHoc";
            dtpNgayHoc.Size = new Size(250, 27);
            dtpNgayHoc.TabIndex = 41;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(504, 115);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(410, 27);
            txtNoiDung.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(373, 117);
            label9.Name = "label9";
            label9.Size = new Size(125, 20);
            label9.TabIndex = 39;
            label9.Text = "Nội dung lớp học";
            // 
            // txtPhongHoc
            // 
            txtPhongHoc.Location = new Point(828, 45);
            txtPhongHoc.Name = "txtPhongHoc";
            txtPhongHoc.Size = new Size(171, 27);
            txtPhongHoc.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(720, 84);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 36;
            label8.Text = "Giờ kết thúc";
            label8.Click += label8_Click;
            // 
            // txtMaLich
            // 
            txtMaLich.Location = new Point(156, 52);
            txtMaLich.Name = "txtMaLich";
            txtMaLich.Size = new Size(151, 27);
            txtMaLich.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 86);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 24;
            label7.Text = "Mã Lớp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(373, 51);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 23;
            label6.Text = "Ngày Học";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(685, 89);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 85);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 21;
            label4.Text = "Giờ bắt đầu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(726, 52);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 20;
            label3.Text = "Phòng Học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 55);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 19;
            label2.Text = "Mã Lịch";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(451, 6);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 18;
            label1.Text = "QUẢN LÝ LỊCH ";
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvLichHoc);
            panel4.Location = new Point(0, 229);
            panel4.Name = "panel4";
            panel4.Size = new Size(1082, 327);
            panel4.TabIndex = 6;
            // 
            // dgvLichHoc
            // 
            dgvLichHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichHoc.Location = new Point(0, 3);
            dgvLichHoc.Name = "dgvLichHoc";
            dgvLichHoc.RowHeadersWidth = 51;
            dgvLichHoc.RowTemplate.Height = 29;
            dgvLichHoc.Size = new Size(1082, 327);
            dgvLichHoc.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(565, 177);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(220, 27);
            txtTimKiem.TabIndex = 52;
            txtTimKiem.Text = "Nhập Mã Lịch cần tìm";
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(791, 177);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 51;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(401, 178);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 50;
            btnLoad.Text = "Làm Mới";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(301, 178);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 49;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(201, 178);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 48;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(101, 178);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 47;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // FrmLichHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 553);
            Controls.Add(panel4);
            Controls.Add(panelTop);
            Name = "FrmLichHoc";
            Text = "FrmLichHoc";
            Load += FrmLichHoc_Load_1;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLichHoc).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTop;
        private TextBox txtNoiDung;
        private Label label9;
        private TextBox txtPhongHoc;
        private Label label8;
        private TextBox txtMaLich;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpNgayHoc;
        private Panel panel4;
        private Label label10;
        private ComboBox cboLop;
        private ComboBox cboGioKT;
        private ComboBox cboGioBD;
        private ComboBox cboGiaoVien;
        private DataGridView dgvLichHoc;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnLoad;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}