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
            panel1 = new Panel();
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
            dataBienLaiHocPhi = new DataGridView();
            txtMaLop = new TextBox();
            txtMaKH = new TextBox();
            txtNguoiThu = new TextBox();
            label9 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataBienLaiHocPhi).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataBienLaiHocPhi);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 373);
            panel2.TabIndex = 3;
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 180);
            panel1.TabIndex = 2;
            // 
            // txtTienNop
            // 
            txtTienNop.Location = new Point(173, 115);
            txtTienNop.Name = "txtTienNop";
            txtTienNop.Size = new Size(171, 27);
            txtTienNop.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(69, 118);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 36;
            label8.Text = "Số Tiền Nộp";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(637, 148);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(220, 27);
            txtTimKiem.TabIndex = 35;
            txtTimKiem.Text = "Nhập Số Biên Lai cần tìm";
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(863, 145);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 34;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(473, 146);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 33;
            btnLoad.Text = "Làm Mới";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(373, 146);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 32;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(273, 146);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 31;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(173, 146);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 30;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(173, 79);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 29;
            // 
            // txtMaHocVien
            // 
            txtMaHocVien.Location = new Point(848, 78);
            txtMaHocVien.Name = "txtMaHocVien";
            txtMaHocVien.Size = new Size(171, 27);
            txtMaHocVien.TabIndex = 26;
            // 
            // txtSoBienLai
            // 
            txtSoBienLai.Location = new Point(173, 48);
            txtSoBienLai.Name = "txtSoBienLai";
            txtSoBienLai.Size = new Size(171, 27);
            txtSoBienLai.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(473, 78);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 24;
            label7.Text = "Mã Lớp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(778, 81);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 23;
            label6.Text = "Mã HV";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(685, 94);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(473, 110);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 21;
            label4.Text = "Mã KH";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 86);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 20;
            label3.Text = "Ngày Nộp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 55);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 19;
            label2.Text = "Số Biên Lai";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(412, 9);
            label1.Name = "label1";
            label1.Size = new Size(308, 32);
            label1.TabIndex = 18;
            label1.Text = "QUẢN LÝ BIÊN LAI HỌC PHÍ";
            // 
            // dataBienLaiHocPhi
            // 
            dataBienLaiHocPhi.AllowUserToAddRows = false;
            dataBienLaiHocPhi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataBienLaiHocPhi.Dock = DockStyle.Fill;
            dataBienLaiHocPhi.Location = new Point(0, 0);
            dataBienLaiHocPhi.Name = "dataBienLaiHocPhi";
            dataBienLaiHocPhi.ReadOnly = true;
            dataBienLaiHocPhi.RowHeadersWidth = 51;
            dataBienLaiHocPhi.RowTemplate.Height = 29;
            dataBienLaiHocPhi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataBienLaiHocPhi.Size = new Size(1082, 373);
            dataBienLaiHocPhi.TabIndex = 1;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(565, 78);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(171, 27);
            txtMaLop.TabIndex = 38;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(565, 115);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(171, 27);
            txtMaKH.TabIndex = 39;
            // 
            // txtNguoiThu
            // 
            txtNguoiThu.Location = new Point(565, 45);
            txtNguoiThu.Name = "txtNguoiThu";
            txtNguoiThu.Size = new Size(454, 27);
            txtNguoiThu.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(473, 49);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 40;
            label9.Text = "Người Thu";
            // 
            // FrmBienLaiHocPhi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmBienLaiHocPhi";
            Text = "FrmBienLaiHocPhi";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataBienLaiHocPhi).EndInit();
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