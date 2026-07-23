namespace QuanLyTrungTam.FORM
{
    partial class FrmKetQuaThi
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
            dataKetQuaThi = new DataGridView();
            txtMaBL = new TextBox();
            label9 = new Label();
            txtMaGV = new TextBox();
            txtMaLop = new TextBox();
            txtDiemThi = new TextBox();
            label8 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLoad = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dtNgayThi = new DateTimePicker();
            txtMaHV = new TextBox();
            txtMaKQT = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            txtXepLoai = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataKetQuaThi).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataKetQuaThi
            // 
            dataKetQuaThi.AllowUserToAddRows = false;
            dataKetQuaThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataKetQuaThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataKetQuaThi.Location = new Point(0, 192);
            dataKetQuaThi.Name = "dataKetQuaThi";
            dataKetQuaThi.ReadOnly = true;
            dataKetQuaThi.RowHeadersVisible = false;
            dataKetQuaThi.RowHeadersWidth = 51;
            dataKetQuaThi.RowTemplate.Height = 29;
            dataKetQuaThi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataKetQuaThi.Size = new Size(1082, 361);
            dataKetQuaThi.TabIndex = 1;
            dataKetQuaThi.CellContentClick += dataKetQuaThi_CellContentClick;
            // 
            // txtMaBL
            // 
            txtMaBL.Location = new Point(503, 48);
            txtMaBL.Name = "txtMaBL";
            txtMaBL.Size = new Size(171, 27);
            txtMaBL.TabIndex = 63;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(411, 52);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 62;
            label9.Text = "Mã biên lai";
            // 
            // txtMaGV
            // 
            txtMaGV.Location = new Point(503, 118);
            txtMaGV.Name = "txtMaGV";
            txtMaGV.Size = new Size(171, 27);
            txtMaGV.TabIndex = 61;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(503, 81);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(171, 27);
            txtMaLop.TabIndex = 60;
            // 
            // txtDiemThi
            // 
            txtDiemThi.Location = new Point(111, 118);
            txtDiemThi.Name = "txtDiemThi";
            txtDiemThi.Size = new Size(171, 27);
            txtDiemThi.TabIndex = 59;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(28, 118);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 58;
            label8.Text = "Điểm Thi";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(575, 163);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(220, 27);
            txtTimKiem.TabIndex = 57;
            txtTimKiem.Text = "Nhập mã KQT cần tìm";
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Salmon;
            btnTimKiem.Location = new Point(801, 160);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 56;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.LightSalmon;
            btnLoad.Location = new Point(411, 161);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 55;
            btnLoad.Text = "Làm Mới";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightSalmon;
            btnXoa.Location = new Point(311, 161);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 54;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightSalmon;
            btnSua.Location = new Point(211, 161);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 53;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightSalmon;
            btnThem.Location = new Point(111, 161);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 52;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dtNgayThi
            // 
            dtNgayThi.Location = new Point(111, 82);
            dtNgayThi.Name = "dtNgayThi";
            dtNgayThi.Size = new Size(250, 27);
            dtNgayThi.TabIndex = 51;
            // 
            // txtMaHV
            // 
            txtMaHV.Location = new Point(801, 81);
            txtMaHV.Name = "txtMaHV";
            txtMaHV.Size = new Size(171, 27);
            txtMaHV.TabIndex = 50;
            // 
            // txtMaKQT
            // 
            txtMaKQT.Location = new Point(111, 51);
            txtMaKQT.Name = "txtMaKQT";
            txtMaKQT.Size = new Size(171, 27);
            txtMaKQT.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(411, 84);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 48;
            label7.Text = "Mã Lớp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(730, 87);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 47;
            label6.Text = "Mã HV";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(623, 97);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(411, 121);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 45;
            label4.Text = "Mã GV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 86);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 44;
            label3.Text = "Ngày Thi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 55);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 43;
            label2.Text = "Mã KQT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(411, 12);
            label1.Name = "label1";
            label1.Size = new Size(259, 31);
            label1.TabIndex = 42;
            label1.Text = "QUẢN LÝ KẾT QUẢ THI";
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtXepLoai);
            panel1.Controls.Add(txtMaBL);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMaGV);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMaLop);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtDiemThi);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(txtMaKQT);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(txtMaHV);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(dtNgayThi);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Location = new Point(0, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 194);
            panel1.TabIndex = 64;
            panel1.Paint += panel1_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(730, 51);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 64;
            label10.Text = "Xếp loại";
            // 
            // txtXepLoai
            // 
            txtXepLoai.Location = new Point(801, 45);
            txtXepLoai.Name = "txtXepLoai";
            txtXepLoai.Size = new Size(171, 27);
            txtXepLoai.TabIndex = 65;
            // 
            // FrmKetQuaThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 553);
            Controls.Add(dataKetQuaThi);
            Controls.Add(panel1);
            Name = "FrmKetQuaThi";
            Text = "FrmKetQuaThi";
            Load += FrmKetQuaThi_Load;
            ((System.ComponentModel.ISupportInitialize)dataKetQuaThi).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataKetQuaThi;
        private TextBox txtMaBL;
        private Label label9;
        private TextBox txtMaGV;
        private TextBox txtMaLop;
        private TextBox txtDiemThi;
        private Label label8;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnLoad;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DateTimePicker dtNgayThi;
        private TextBox txtMaHV;
        private TextBox txtMaKQT;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label10;
        private TextBox txtXepLoai;
    }
}