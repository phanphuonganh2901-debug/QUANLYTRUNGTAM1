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
            panel2.Location = new Point(0, 148);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(947, 267);
            panel2.TabIndex = 3;
            // 
            // dataTaiKhoan
            // 
            dataTaiKhoan.AllowUserToAddRows = false;
            dataTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTaiKhoan.Location = new Point(0, 2);
            dataTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            dataTaiKhoan.Name = "dataTaiKhoan";
            dataTaiKhoan.ReadOnly = true;
            dataTaiKhoan.RowHeadersWidth = 51;
            dataTaiKhoan.RowTemplate.Height = 29;
            dataTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTaiKhoan.Size = new Size(947, 278);
            dataTaiKhoan.TabIndex = 0;
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
            panelTop.Margin = new Padding(3, 2, 3, 2);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(947, 148);
            panelTop.TabIndex = 2;
            panelTop.Paint += panelTop_Paint;
            // 
            // cboVaiTro
            // 
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Location = new Point(545, 42);
            cboVaiTro.Margin = new Padding(3, 2, 3, 2);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(159, 23);
            cboVaiTro.TabIndex = 56;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(490, 122);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(193, 23);
            txtTimKiem.TabIndex = 55;
            txtTimKiem.Text = "Nhập Mã Người Dùng cần tìm";
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.LightSalmon;
            btnTimKiem.Location = new Point(715, 122);
            btnTimKiem.Margin = new Padding(3, 2, 3, 2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(82, 22);
            btnTimKiem.TabIndex = 54;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.LightSalmon;
            btnLoad.Location = new Point(346, 122);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 22);
            btnLoad.TabIndex = 53;
            btnLoad.Text = "Làm Mới";
            btnLoad.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightSalmon;
            btnXoa.Location = new Point(259, 122);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 22);
            btnXoa.TabIndex = 52;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightSalmon;
            btnSua.Location = new Point(172, 122);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 22);
            btnSua.TabIndex = 51;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightSalmon;
            btnThem.Location = new Point(84, 122);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 22);
            btnThem.TabIndex = 50;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(439, 46);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 48;
            label3.Text = "Vai trò";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(361, 7);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 47;
            label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // txtMaNguoiDung
            // 
            txtMaNguoiDung.Location = new Point(545, 80);
            txtMaNguoiDung.Margin = new Padding(3, 2, 3, 2);
            txtMaNguoiDung.Name = "txtMaNguoiDung";
            txtMaNguoiDung.Size = new Size(159, 23);
            txtMaNguoiDung.TabIndex = 46;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(183, 76);
            txtMatKhau.Margin = new Padding(3, 2, 3, 2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(159, 23);
            txtMatKhau.TabIndex = 45;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(183, 44);
            txtTenDangNhap.Margin = new Padding(3, 2, 3, 2);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(159, 23);
            txtTenDangNhap.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(79, 80);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 43;
            label7.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(439, 82);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 42;
            label4.Text = "Mã người dùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(79, 44);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 41;
            label2.Text = "Tên đăng nhập";
            // 
            // FrmQuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 415);
            Controls.Add(panel2);
            Controls.Add(panelTop);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmQuanLyTaiKhoan";
            Text = "FrmQuanLyTaiKhoan";
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