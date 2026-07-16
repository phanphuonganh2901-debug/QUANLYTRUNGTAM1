namespace QuanLyTrungTam.FORM
{
    partial class FrmKhoaHoc
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
            dataKhoaHoc = new DataGridView();
            panel1 = new Panel();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLoad = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtTenKH = new TextBox();
            txtMaKH = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataKhoaHoc).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataKhoaHoc);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 373);
            panel2.TabIndex = 3;
            // 
            // dataKhoaHoc
            // 
            dataKhoaHoc.AllowUserToAddRows = false;
            dataKhoaHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataKhoaHoc.Dock = DockStyle.Fill;
            dataKhoaHoc.Location = new Point(0, 0);
            dataKhoaHoc.Name = "dataKhoaHoc";
            dataKhoaHoc.ReadOnly = true;
            dataKhoaHoc.RowHeadersWidth = 51;
            dataKhoaHoc.RowTemplate.Height = 29;
            dataKhoaHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataKhoaHoc.Size = new Size(1082, 373);
            dataKhoaHoc.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtTenKH);
            panel1.Controls.Add(txtMaKH);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 180);
            panel1.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(637, 145);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(220, 27);
            txtTimKiem.TabIndex = 35;
            txtTimKiem.Text = "Nhập Mã KH cần tìm";
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
            dateTimePicker1.Location = new Point(609, 80);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 29;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(609, 44);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(398, 27);
            txtTenKH.TabIndex = 26;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(198, 48);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(171, 27);
            txtMaKH.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 85);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 24;
            label7.Text = "Ngày Bắt Đầu";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(488, 51);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 23;
            label6.Text = "Tên Khóa Học";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(685, 94);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(488, 85);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 20;
            label3.Text = "Ngày Kết Thúc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 55);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 19;
            label2.Text = "Mã KH";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(451, 6);
            label1.Name = "label1";
            label1.Size = new Size(238, 32);
            label1.TabIndex = 18;
            label1.Text = "QUẢN LÝ KHÓA HỌC";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(198, 85);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 36;
            // 
            // FrmKhoaHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmKhoaHoc";
            Text = "FrmKhoaHoc";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataKhoaHoc).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataKhoaHoc;
        private Panel panel1;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnLoad;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DateTimePicker dateTimePicker1;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
    }
}