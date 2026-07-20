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
            panelTop = new Panel();
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
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataBienLaiHocPhi);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 212);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 341);
            panel2.TabIndex = 3;
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
            dataBienLaiHocPhi.Size = new Size(1082, 341);
            dataBienLaiHocPhi.TabIndex = 1;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(txtNguoiThu);
            panelTop.Controls.Add(label9);
            panelTop.Controls.Add(txtMaKH);
            panelTop.Controls.Add(txtMaLop);
            panelTop.Controls.Add(txtTienNop);
            panelTop.Controls.Add(label8);
            panelTop.Controls.Add(txtTimKiem);
            panelTop.Controls.Add(btnTimKiem);
            panelTop.Controls.Add(btnLoad);
            panelTop.Controls.Add(btnXoa);
            panelTop.Controls.Add(btnSua);
            panelTop.Controls.Add(btnThem);
            panelTop.Controls.Add(dateTimePicker1);
            panelTop.Controls.Add(txtMaHocVien);
            panelTop.Controls.Add(txtSoBienLai);
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
            panelTop.Size = new Size(1082, 212);
            panelTop.TabIndex = 2;
            panelTop.Paint += panel1_Paint;
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
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(473, 49);
            label9.Name = "label9";
            label9.Size = new Size(84, 20);
            label9.TabIndex = 40;
            label9.Text = "Người Thu";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(565, 115);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(171, 27);
            txtMaKH.TabIndex = 39;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(565, 78);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(171, 27);
            txtMaLop.TabIndex = 38;
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
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(69, 118);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 36;
            label8.Text = "Số Tiền Nộp";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(637, 160);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(220, 27);
            txtTimKiem.TabIndex = 35;
            txtTimKiem.Text = "Nhập Số Biên Lai cần tìm";
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Salmon;
            btnTimKiem.Location = new Point(863, 157);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 34;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.LightSalmon;
            btnLoad.Location = new Point(473, 158);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 33;
            btnLoad.Text = "Làm Mới";
            btnLoad.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightSalmon;
            btnXoa.Location = new Point(373, 158);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 32;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightSalmon;
            btnSua.Location = new Point(273, 158);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 31;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightSalmon;
            btnThem.Location = new Point(173, 158);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 30;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
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
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(473, 78);
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
            label6.Location = new Point(788, 85);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 23;
            label6.Text = "Mã HV";
            label6.Click += label6_Click;
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
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(473, 110);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 21;
            label4.Text = "Mã KH";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(69, 86);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 20;
            label3.Text = "Ngày Nộp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(69, 55);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 19;
            label2.Text = "Số Biên Lai";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(412, 9);
            label1.Name = "label1";
            label1.Size = new Size(313, 31);
            label1.TabIndex = 18;
            label1.Text = "QUẢN LÝ BIÊN LAI HỌC PHÍ";
            // 
            // FrmBienLaiHocPhi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 553);
            Controls.Add(panel2);
            Controls.Add(panelTop);
            Name = "FrmBienLaiHocPhi";
            Text = "FrmBienLaiHocPhi";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataBienLaiHocPhi).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panelTop;
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