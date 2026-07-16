namespace QuanLyTrungTam.FORM
{
    partial class FrmGiaoVien
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
            panel1 = new Panel();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLoad = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtHoTen = new TextBox();
            txtMaGV = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dataGiaoVien = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGiaoVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(txtHoTen);
            panel1.Controls.Add(txtMaGV);
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
            panel1.Size = new Size(1082, 189);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(770, 109);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(220, 27);
            txtTimKiem.TabIndex = 17;
            txtTimKiem.Text = "Nhập Mã GV cần tìm";
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(839, 148);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 16;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(449, 149);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 15;
            btnLoad.Text = "Làm Mới";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(349, 149);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(249, 149);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(149, 149);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(466, 80);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(127, 113);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(589, 27);
            txtDiaChi.TabIndex = 10;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(127, 81);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(171, 27);
            txtSDT.TabIndex = 9;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(466, 48);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(524, 27);
            txtHoTen.TabIndex = 8;
            // 
            // txtMaGV
            // 
            txtMaGV.Location = new Point(127, 51);
            txtMaGV.Name = "txtMaGV";
            txtMaGV.Size = new Size(171, 27);
            txtMaGV.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 88);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 6;
            label7.Text = "SĐT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(388, 51);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 5;
            label6.Text = "Họ Tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(661, 97);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 116);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(388, 85);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 58);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã GV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(427, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 32);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ GIÁO VIÊN";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGiaoVien);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 186);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 367);
            panel2.TabIndex = 1;
            // 
            // dataGiaoVien
            // 
            dataGiaoVien.AllowUserToAddRows = false;
            dataGiaoVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGiaoVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGiaoVien.Dock = DockStyle.Fill;
            dataGiaoVien.Location = new Point(0, 0);
            dataGiaoVien.Name = "dataGiaoVien";
            dataGiaoVien.ReadOnly = true;
            dataGiaoVien.RowHeadersVisible = false;
            dataGiaoVien.RowHeadersWidth = 51;
            dataGiaoVien.RowTemplate.Height = 29;
            dataGiaoVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGiaoVien.Size = new Size(1082, 367);
            dataGiaoVien.TabIndex = 0;
            // 
            // FrmGiaoVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmGiaoVien";
            Text = "FrmGiaoVien";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGiaoVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Button btnTimKiem;
        private Button btnLoad;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DateTimePicker dateTimePicker1;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtHoTen;
        private TextBox txtMaGV;
        private TextBox txtTimKiem;
        private DataGridView dataGiaoVien;
    }
}