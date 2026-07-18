namespace QuanLyTrungTam.FORM
{
    partial class FrmBienLaiHocPhi
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
            dataBienLaiHocPhi = new DataGridView();
            panel1 = new Panel();
            txtNguoiThu = new TextBox();
            label9 = new Label();
            txtMaKH = new TextBox();
            txtMaLop = new TextBox();
            txtTienNop = new TextBox();
            label8 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLoad = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtMaHocVien = new TextBox();
            txtSoBienLai = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataBienLaiHocPhi).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataBienLaiHocPhi);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 135);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(947, 280);
            panel2.TabIndex = 3;
            // 
            // dataBienLaiHocPhi
            // 
            dataBienLaiHocPhi.AllowUserToAddRows = false;
            dataBienLaiHocPhi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataBienLaiHocPhi.Dock = DockStyle.Fill;
            dataBienLaiHocPhi.Location = new Point(0, 0);
            dataBienLaiHocPhi.Margin = new Padding(3, 2, 3, 2);
            dataBienLaiHocPhi.Name = "dataBienLaiHocPhi";
            dataBienLaiHocPhi.ReadOnly = true;
            dataBienLaiHocPhi.RowHeadersWidth = 51;
            dataBienLaiHocPhi.RowTemplate.Height = 29;
            dataBienLaiHocPhi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataBienLaiHocPhi.Size = new Size(947, 280);
            dataBienLaiHocPhi.TabIndex = 1;
            dataBienLaiHocPhi.CellContentClick += dataBienLaiHocPhi_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNguoiThu);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtMaKH);
            panel1.Controls.Add(txtMaLop);
            panel1.Controls.Add(txtTienNop);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtMaHocVien);
            panel1.Controls.Add(txtSoBienLai);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 135);
            panel1.TabIndex = 2;
            // 
            // txtNguoiThu
            // 
            txtNguoiThu.Location = new Point(494, 34);
            txtNguoiThu.Margin = new Padding(3, 2, 3, 2);
            txtNguoiThu.Name = "txtNguoiThu";
            txtNguoiThu.Size = new Size(398, 23);
            txtNguoiThu.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(414, 37);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 40;
            label9.Text = "Người Thu";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(494, 86);
            txtMaKH.Margin = new Padding(3, 2, 3, 2);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(150, 23);
            txtMaKH.TabIndex = 39;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(494, 58);
            txtMaLop.Margin = new Padding(3, 2, 3, 2);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(150, 23);
            txtMaLop.TabIndex = 38;
            // 
            // txtTienNop
            // 
            txtTienNop.Location = new Point(151, 86);
            txtTienNop.Margin = new Padding(3, 2, 3, 2);
            txtTienNop.Name = "txtTienNop";
            txtTienNop.Size = new Size(150, 23);
            txtTienNop.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 88);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 36;
            label8.Text = "Số Tiền Nộp";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(557, 111);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(193, 23);
            txtTimKiem.TabIndex = 35;
            txtTimKiem.Text = "Nhập Số Biên Lai cần tìm";
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(755, 109);
            btnTimKiem.Margin = new Padding(3, 2, 3, 2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(82, 22);
            btnTimKiem.TabIndex = 34;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(414, 110);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 22);
            btnLoad.TabIndex = 33;
            btnLoad.Text = "Làm Mới";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(326, 110);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 22);
            btnXoa.TabIndex = 32;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(239, 110);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 22);
            btnSua.TabIndex = 31;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(151, 110);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 22);
            btnThem.TabIndex = 30;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(151, 59);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 29;
            // 
            // txtMaHocVien
            // 
            txtMaHocVien.Location = new Point(742, 58);
            txtMaHocVien.Margin = new Padding(3, 2, 3, 2);
            txtMaHocVien.Name = "txtMaHocVien";
            txtMaHocVien.Size = new Size(150, 23);
            txtMaHocVien.TabIndex = 26;
            // 
            // txtSoBienLai
            // 
            txtSoBienLai.Location = new Point(151, 36);
            txtSoBienLai.Margin = new Padding(3, 2, 3, 2);
            txtSoBienLai.Name = "txtSoBienLai";
            txtSoBienLai.Size = new Size(150, 23);
            txtSoBienLai.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(414, 58);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 24;
            label7.Text = "Mã Lớp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(681, 61);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 23;
            label6.Text = "Mã HV";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(599, 70);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 82);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 21;
            label4.Text = "Mã KH";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 64);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 20;
            label3.Text = "Ngày Nộp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 41);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 19;
            label2.Text = "Số Biên Lai";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(360, 7);
            label1.Name = "label1";
            label1.Size = new Size(244, 25);
            label1.TabIndex = 18;
            label1.Text = "QUẢN LÝ BIÊN LAI HỌC PHÍ";
            // 
            // FrmBienLaiHocPhi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 415);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmBienLaiHocPhi";
            Text = "FrmBienLaiHocPhi";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataBienLaiHocPhi).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnLoad;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DateTimePicker dateTimePicker1;
        private TextBox txtMaHocVien;
        private TextBox txtSoBienLai;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTienNop;
        private Label label8;
        private DataGridView dataBienLaiHocPhi;
        private TextBox txtMaKH;
        private TextBox txtMaLop;
        private TextBox txtNguoiThu;
        private Label label9;
    }
}