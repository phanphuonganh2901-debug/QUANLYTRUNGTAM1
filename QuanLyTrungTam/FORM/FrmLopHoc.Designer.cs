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
            panelTop = new Panel();
            txtMaGV = new TextBox();
            txtSiSo = new TextBox();
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
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataLopHoc);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 198);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 355);
            panel2.TabIndex = 3;
            // 
            // dataLopHoc
            // 
            dataLopHoc.AllowUserToAddRows = false;
            dataLopHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLopHoc.Location = new Point(0, 0);
            dataLopHoc.Name = "dataLopHoc";
            dataLopHoc.ReadOnly = true;
            dataLopHoc.RowHeadersWidth = 51;
            dataLopHoc.RowTemplate.Height = 29;
            dataLopHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataLopHoc.Size = new Size(1082, 373);
            dataLopHoc.TabIndex = 0;
            dataLopHoc.CellContentClick += dataLopHoc_CellContentClick;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(txtMaGV);
            panelTop.Controls.Add(txtSiSo);
            panelTop.Controls.Add(txtPhongHoc);
            panelTop.Controls.Add(txtMaKH);
            panelTop.Controls.Add(label8);
            panelTop.Controls.Add(txtTimKiem);
            panelTop.Controls.Add(btnTimKiem);
            panelTop.Controls.Add(btnLoad);
            panelTop.Controls.Add(btnXoa);
            panelTop.Controls.Add(btnSua);
            panelTop.Controls.Add(btnThem);
            panelTop.Controls.Add(txtTenLop);
            panelTop.Controls.Add(txtMaLop);
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
            panelTop.Size = new Size(1082, 198);
            panelTop.TabIndex = 2;
            panelTop.Paint += panelTop_Paint;
            // 
            // txtMaGV
            // 
            txtMaGV.Location = new Point(145, 111);
            txtMaGV.Name = "txtMaGV";
            txtMaGV.Size = new Size(181, 27);
            txtMaGV.TabIndex = 40;
            // 
            // txtSiSo
            // 
            txtSiSo.Location = new Point(145, 78);
            txtSiSo.Name = "txtSiSo";
            txtSiSo.Size = new Size(181, 27);
            txtSiSo.TabIndex = 39;
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
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(412, 110);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
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
            btnTimKiem.BackColor = Color.LightSalmon;
            btnTimKiem.Location = new Point(863, 145);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 34;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.LightSalmon;
            btnLoad.Location = new Point(473, 146);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 33;
            btnLoad.Text = "Làm Mới";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightSalmon;
            btnXoa.Location = new Point(373, 146);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 32;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightSalmon;
            btnSua.Location = new Point(273, 146);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 31;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightSalmon;
            btnThem.Location = new Point(173, 146);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 30;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
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
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(69, 81);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 24;
            label7.Text = "Sĩ Số";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(412, 48);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
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
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(69, 114);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 21;
            label4.Text = "Mã GV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(412, 81);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 20;
            label3.Text = "Phòng Học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(69, 48);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 19;
            label2.Text = "Mã Lớp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(451, 6);
            label1.Name = "label1";
            label1.Size = new Size(218, 31);
            label1.TabIndex = 18;
            label1.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // FrmLopHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 553);
            Controls.Add(panel2);
            Controls.Add(panelTop);
            Name = "FrmLopHoc";
            Text = "FrmLopHoc";
            Load += FrmLopHoc_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataLopHoc).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataLopHoc;
        private Panel panelTop;
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
        private TextBox txtMaGV;
        private TextBox txtSiSo;
    }
}