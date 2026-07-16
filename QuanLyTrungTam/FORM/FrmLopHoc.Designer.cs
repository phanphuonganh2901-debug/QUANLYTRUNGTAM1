namespace QuanLyTrungTam.FORM
{
    partial class FrmLopHoc
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
            dataLopHoc = new DataGridView();
            panel1 = new Panel();
            txtPhongHoc = new TextBox();
            txtMaKH = new TextBox();
            label8 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLoad = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenLop = new TextBox();
            txtMaLop = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataLopHoc).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataLopHoc);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 373);
            panel2.TabIndex = 3;
            // 
            // dataLopHoc
            // 
            dataLopHoc.AllowUserToAddRows = false;
            dataLopHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLopHoc.Dock = DockStyle.Fill;
            dataLopHoc.Location = new Point(0, 0);
            dataLopHoc.Name = "dataLopHoc";
            dataLopHoc.ReadOnly = true;
            dataLopHoc.RowHeadersWidth = 51;
            dataLopHoc.RowTemplate.Height = 29;
            dataLopHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataLopHoc.Size = new Size(1082, 373);
            dataLopHoc.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(txtPhongHoc);
            panel1.Controls.Add(txtMaKH);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtTenLop);
            panel1.Controls.Add(txtMaLop);
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
            // txtPhongHoc
            // 
            txtPhongHoc.Location = new Point(515, 78);
            txtPhongHoc.Name = "txtPhongHoc";
            txtPhongHoc.Size = new Size(171, 27);
            txtPhongHoc.TabIndex = 38;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(515, 107);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(171, 27);
            txtMaKH.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(412, 110);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 36;
            label8.Text = "Mã KH";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(794, 106);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(220, 27);
            txtTimKiem.TabIndex = 35;
            txtTimKiem.Text = "Nhập Mã Lớp cần tìm";
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
            // txtTenLop
            // 
            txtTenLop.Location = new Point(515, 45);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(524, 27);
            txtTenLop.TabIndex = 26;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(145, 43);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(181, 27);
            txtMaLop.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 81);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 24;
            label7.Text = "Sĩ Số";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(412, 48);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 23;
            label6.Text = "Tên Lớp";
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
            label4.Location = new Point(69, 114);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 21;
            label4.Text = "Mã GV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 81);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 20;
            label3.Text = "Phòng Học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 48);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 19;
            label2.Text = "Mã Lớp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(451, 6);
            label1.Name = "label1";
            label1.Size = new Size(217, 32);
            label1.TabIndex = 18;
            label1.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 27);
            textBox1.TabIndex = 39;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(145, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 27);
            textBox2.TabIndex = 40;
            // 
            // FrmLopHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmLopHoc";
            Text = "FrmLopHoc";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataLopHoc).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataLopHoc;
        private Panel panel1;
        private Label label8;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnLoad;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DateTimePicker dateTimePicker1;
        private TextBox txtNgheNghiep;
        private TextBox txtCMND;
        private TextBox txtTenLop;
        private TextBox txtMaLop;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPhongHoc;
        private TextBox txtMaKH;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}