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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataLopHoc).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataLopHoc);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 135);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(947, 280);
            panel2.TabIndex = 3;
            // 
            // dataLopHoc
            // 
            dataLopHoc.AllowUserToAddRows = false;
            dataLopHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLopHoc.Dock = DockStyle.Fill;
            dataLopHoc.Location = new Point(0, 0);
            dataLopHoc.Margin = new Padding(3, 2, 3, 2);
            dataLopHoc.Name = "dataLopHoc";
            dataLopHoc.ReadOnly = true;
            dataLopHoc.RowHeadersWidth = 51;
            dataLopHoc.RowTemplate.Height = 29;
            dataLopHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataLopHoc.Size = new Size(947, 280);
            dataLopHoc.TabIndex = 0;
            dataLopHoc.CellContentClick += dataLopHoc_CellContentClick;
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 135);
            panel1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 83);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 40;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 58);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 39;
            // 
            // txtPhongHoc
            // 
            txtPhongHoc.Location = new Point(451, 58);
            txtPhongHoc.Margin = new Padding(3, 2, 3, 2);
            txtPhongHoc.Name = "txtPhongHoc";
            txtPhongHoc.Size = new Size(150, 23);
            txtPhongHoc.TabIndex = 38;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(451, 80);
            txtMaKH.Margin = new Padding(3, 2, 3, 2);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(150, 23);
            txtMaKH.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(360, 82);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 36;
            label8.Text = "Mã KH";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(695, 80);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(193, 23);
            txtTimKiem.TabIndex = 35;
            txtTimKiem.Text = "Nhập Mã Lớp cần tìm";
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
            // txtTenLop
            // 
            txtTenLop.Location = new Point(451, 34);
            txtTenLop.Margin = new Padding(3, 2, 3, 2);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(459, 23);
            txtTenLop.TabIndex = 26;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(127, 32);
            txtMaLop.Margin = new Padding(3, 2, 3, 2);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(159, 23);
            txtMaLop.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 61);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 24;
            label7.Text = "Sĩ Số";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(360, 36);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 23;
            label6.Text = "Tên Lớp";
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
            label4.Location = new Point(60, 86);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 21;
            label4.Text = "Mã GV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 61);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 20;
            label3.Text = "Phòng Học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 36);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 19;
            label2.Text = "Mã Lớp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(395, 4);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 18;
            label1.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // FrmLopHoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 415);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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