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
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLoad = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboGioKetThuc = new ComboBox();
            cboGioBatDau = new ComboBox();
            cboMaGV = new ComboBox();
            label10 = new Label();
            cboMaLop = new ComboBox();
            dtNgayHoc = new DateTimePicker();
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
            dataLichHoc = new DataGridView();
            panelTop.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataLichHoc).BeginInit();
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
            panelTop.Controls.Add(cboGioKetThuc);
            panelTop.Controls.Add(cboGioBatDau);
            panelTop.Controls.Add(cboMaGV);
            panelTop.Controls.Add(label10);
            panelTop.Controls.Add(cboMaLop);
            panelTop.Controls.Add(dtNgayHoc);
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
            panelTop.Size = new Size(1082, 198);
            panelTop.TabIndex = 4;
            panelTop.Paint += panelTop_Paint;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(568, 165);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(220, 27);
            txtTimKiem.TabIndex = 52;
            txtTimKiem.Text = "Nhập Mã Lịch cần tìm";
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.LightSalmon;
            btnTimKiem.Location = new Point(794, 165);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 51;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.LightSalmon;
            btnLoad.Location = new Point(404, 166);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 50;
            btnLoad.Text = "Làm Mới";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightSalmon;
            btnXoa.Location = new Point(304, 166);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 49;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightSalmon;
            btnSua.Location = new Point(204, 166);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 48;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightSalmon;
            btnThem.Location = new Point(104, 166);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 47;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // cboGioKetThuc
            // 
            cboGioKetThuc.FormattingEnabled = true;
            cboGioKetThuc.Location = new Point(828, 82);
            cboGioKetThuc.Name = "cboGioKetThuc";
            cboGioKetThuc.Size = new Size(151, 28);
            cboGioKetThuc.TabIndex = 46;
            // 
            // cboGioBatDau
            // 
            cboGioBatDau.FormattingEnabled = true;
            cboGioBatDau.Location = new Point(466, 77);
            cboGioBatDau.Name = "cboGioBatDau";
            cboGioBatDau.Size = new Size(151, 28);
            cboGioBatDau.TabIndex = 45;
            // 
            // cboMaGV
            // 
            cboMaGV.FormattingEnabled = true;
            cboMaGV.Location = new Point(156, 114);
            cboMaGV.Name = "cboMaGV";
            cboMaGV.Size = new Size(151, 28);
            cboMaGV.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(69, 117);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 43;
            label10.Text = "Mã GV";
            label10.Click += label10_Click;
            // 
            // cboMaLop
            // 
            cboMaLop.FormattingEnabled = true;
            cboMaLop.Location = new Point(156, 81);
            cboMaLop.Name = "cboMaLop";
            cboMaLop.Size = new Size(151, 28);
            cboMaLop.TabIndex = 42;
            // 
            // dtNgayHoc
            // 
            dtNgayHoc.Location = new Point(468, 46);
            dtNgayHoc.Name = "dtNgayHoc";
            dtNgayHoc.Size = new Size(250, 27);
            dtNgayHoc.TabIndex = 41;
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
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(373, 117);
            label9.Name = "label9";
            label9.Size = new Size(129, 20);
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
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(720, 84);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
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
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(69, 86);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 24;
            label7.Text = "Mã Lớp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(373, 51);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
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
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(373, 85);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 21;
            label4.Text = "Giờ bắt đầu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(726, 52);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 20;
            label3.Text = "Phòng Học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(69, 55);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 19;
            label2.Text = "Mã Lịch";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(451, 6);
            label1.Name = "label1";
            label1.Size = new Size(176, 31);
            label1.TabIndex = 18;
            label1.Text = "QUẢN LÝ LỊCH ";
            // 
            // panel4
            // 
            panel4.Controls.Add(dataLichHoc);
            panel4.Location = new Point(0, 198);
            panel4.Name = "panel4";
            panel4.Size = new Size(1082, 358);
            panel4.TabIndex = 6;
            // 
            // dataLichHoc
            // 
            dataLichHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLichHoc.Location = new Point(0, 0);
            dataLichHoc.Name = "dataLichHoc";
            dataLichHoc.RowHeadersWidth = 51;
            dataLichHoc.RowTemplate.Height = 29;
            dataLichHoc.Size = new Size(1082, 330);
            dataLichHoc.TabIndex = 0;
            dataLichHoc.CellContentClick += dataLichHoc_CellContentClick;
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
            ((System.ComponentModel.ISupportInitialize)dataLichHoc).EndInit();
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
        private DateTimePicker dtNgayHoc;
        private Panel panel4;
        private Label label10;
        private ComboBox cboMaLop;
        private ComboBox cboGioKetThuc;
        private ComboBox cboGioBatDau;
        private ComboBox cboMaGV;
        private DataGridView dataLichHoc;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnLoad;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}