namespace QuanLyTrungTam.FORM
{
    partial class FrmHocVien
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
            dataHocVien = new DataGridView();
            panel1 = new Panel();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLoad = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtNgheNghiep = new TextBox();
            txtCMND = new TextBox();
            txtHoTen = new TextBox();
            txtMaHV = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataHocVien).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataHocVien);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 140);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(947, 275);
            panel2.TabIndex = 3;
            // 
            // dataHocVien
            // 
            dataHocVien.AllowUserToAddRows = false;
            dataHocVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataHocVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataHocVien.Dock = DockStyle.Fill;
            dataHocVien.Location = new Point(0, 0);
            dataHocVien.Margin = new Padding(3, 2, 3, 2);
            dataHocVien.Name = "dataHocVien";
            dataHocVien.ReadOnly = true;
            dataHocVien.RowHeadersVisible = false;
            dataHocVien.RowHeadersWidth = 51;
            dataHocVien.RowTemplate.Height = 29;
            dataHocVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataHocVien.Size = new Size(947, 275);
            dataHocVien.TabIndex = 0;
            dataHocVien.CellContentClick += dataHocVien_CellContentClick;
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
            panel1.Controls.Add(txtNgheNghiep);
            panel1.Controls.Add(txtCMND);
            panel1.Controls.Add(txtHoTen);
            panel1.Controls.Add(txtMaHV);
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
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(674, 82);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(193, 23);
            txtTimKiem.TabIndex = 17;
            txtTimKiem.Text = "Nhập Mã HV cần tìm";
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(734, 111);
            btnTimKiem.Margin = new Padding(3, 2, 3, 2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(82, 22);
            btnTimKiem.TabIndex = 16;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(393, 112);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 22);
            btnLoad.TabIndex = 15;
            btnLoad.Text = "Làm Mới";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(305, 112);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 22);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(218, 112);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 22);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(130, 112);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 22);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(408, 60);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // txtNgheNghiep
            // 
            txtNgheNghiep.Location = new Point(152, 85);
            txtNgheNghiep.Margin = new Padding(3, 2, 3, 2);
            txtNgheNghiep.Name = "txtNgheNghiep";
            txtNgheNghiep.Size = new Size(475, 23);
            txtNgheNghiep.TabIndex = 10;
            // 
            // txtCMND
            // 
            txtCMND.Location = new Point(152, 61);
            txtCMND.Margin = new Padding(3, 2, 3, 2);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(150, 23);
            txtCMND.TabIndex = 9;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(408, 36);
            txtHoTen.Margin = new Padding(3, 2, 3, 2);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(459, 23);
            txtHoTen.TabIndex = 8;
            // 
            // txtMaHV
            // 
            txtMaHV.Location = new Point(152, 38);
            txtMaHV.Margin = new Padding(3, 2, 3, 2);
            txtMaHV.Name = "txtMaHV";
            txtMaHV.Size = new Size(150, 23);
            txtMaHV.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 66);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 6;
            label7.Text = "CMND";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(340, 38);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 5;
            label6.Text = "Họ Tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(578, 73);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 90);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 3;
            label4.Text = "Nghề Nghiệp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(340, 64);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 44);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã HV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(374, 7);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ HỌC VIÊN";
            // 
            // FrmHocVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 415);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmHocVien";
            Text = "FrmHocVien";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataHocVien).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataHocVien;
        private Panel panel1;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnLoad;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DateTimePicker dateTimePicker1;
        private TextBox txtNgheNghiep;
        private TextBox txtCMND;
        private TextBox txtHoTen;
        private TextBox txtMaHV;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}