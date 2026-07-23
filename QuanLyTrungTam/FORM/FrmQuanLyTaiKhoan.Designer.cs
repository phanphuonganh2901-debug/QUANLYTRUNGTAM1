namespace QuanLyTrungTam.FORM
{
    partial class FrmQuanLyTaiKhoan
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
            panel2 = new Panel();
            dataTaiKhoan = new DataGridView();
            panelTop = new Panel();
            cboVaiTro = new ComboBox();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLoad = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label3 = new Label();
            label1 = new Label();
            txtMaNguoiDung = new TextBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataTaiKhoan).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataTaiKhoan);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 198);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 355);
            panel2.TabIndex = 3;
            // 
            // dataTaiKhoan
            // 
            dataTaiKhoan.AllowUserToAddRows = false;
            dataTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTaiKhoan.Location = new Point(0, 3);
            dataTaiKhoan.Name = "dataTaiKhoan";
            dataTaiKhoan.ReadOnly = true;
            dataTaiKhoan.RowHeadersWidth = 51;
            dataTaiKhoan.RowTemplate.Height = 29;
            dataTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTaiKhoan.Size = new Size(1082, 370);
            dataTaiKhoan.TabIndex = 0;
            dataTaiKhoan.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(cboVaiTro);
            panelTop.Controls.Add(txtTimKiem);
            panelTop.Controls.Add(btnTimKiem);
            panelTop.Controls.Add(btnLoad);
            panelTop.Controls.Add(btnXoa);
            panelTop.Controls.Add(btnSua);
            panelTop.Controls.Add(btnThem);
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(label1);
            panelTop.Controls.Add(txtMaNguoiDung);
            panelTop.Controls.Add(txtMatKhau);
            panelTop.Controls.Add(txtTenDangNhap);
            panelTop.Controls.Add(label7);
            panelTop.Controls.Add(label4);
            panelTop.Controls.Add(label2);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1082, 198);
            panelTop.TabIndex = 2;
            panelTop.Paint += panelTop_Paint;
            // 
            // cboVaiTro
            // 
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Location = new Point(623, 56);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(181, 28);
            cboVaiTro.TabIndex = 56;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(560, 163);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(220, 27);
            txtTimKiem.TabIndex = 55;
            txtTimKiem.Text = "Nhập Mã Người Dùng cần tìm";
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.LightSalmon;
            btnTimKiem.Location = new Point(817, 162);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 54;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.LightSalmon;
            btnLoad.Location = new Point(396, 163);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 53;
            btnLoad.Text = "Làm Mới";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightSalmon;
            btnXoa.Location = new Point(296, 163);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 52;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightSalmon;
            btnSua.Location = new Point(196, 163);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 51;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightSalmon;
            btnThem.Location = new Point(96, 163);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 50;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(502, 62);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 48;
            label3.Text = "Vai trò";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(413, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 31);
            label1.TabIndex = 47;
            label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // txtMaNguoiDung
            // 
            txtMaNguoiDung.Location = new Point(623, 106);
            txtMaNguoiDung.Name = "txtMaNguoiDung";
            txtMaNguoiDung.Size = new Size(181, 27);
            txtMaNguoiDung.TabIndex = 46;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(209, 102);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(181, 27);
            txtMatKhau.TabIndex = 45;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(209, 59);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(181, 27);
            txtTenDangNhap.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(90, 106);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 43;
            label7.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(502, 109);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 42;
            label4.Text = "Mã người dùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(90, 59);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 41;
            label2.Text = "Tên đăng nhập";
            // 
            // FrmQuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 553);
            Controls.Add(panel2);
            Controls.Add(panelTop);
            Name = "FrmQuanLyTaiKhoan";
            Text = "FrmQuanLyTaiKhoan";
            Load += FrmQuanLyTaiKhoan_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataTaiKhoan).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataTaiKhoan;
        private Panel panelTop;
        private TextBox txtMaNguoiDung;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label7;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button btnLoad;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private ComboBox cboVaiTro;
    }
}