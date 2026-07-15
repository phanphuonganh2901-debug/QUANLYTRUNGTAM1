namespace QuanLyTrungTam.FORM
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            btnKhoaHoc = new Button();
            btnDangXuat = new Button();
            btnReset = new Button();
            btnTaiKhoan = new Button();
            btnKetQuaThi = new Button();
            btnHocPhi = new Button();
            btnLopHoc = new Button();
            btnHocVien = new Button();
            btnGiaoVien = new Button();
            btnTrangChu = new Button();
            button8 = new Button();
            lblXinChao = new Label();
            lblNgay = new Label();
            label1 = new Label();
            pnlMain = new Panel();
            pnlHome = new Panel();
            label2 = new Label();
            chartKetQua = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            chartHocVien = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label12 = new Label();
            label11 = new Label();
            lblTongHocPhi = new Label();
            lblTongLop = new Label();
            lblTongGiaoVien = new Label();
            lblTongHocVien = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartKetQua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartHocVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnKhoaHoc);
            panel1.Controls.Add(btnDangXuat);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnTaiKhoan);
            panel1.Controls.Add(btnKetQuaThi);
            panel1.Controls.Add(btnHocPhi);
            panel1.Controls.Add(btnLopHoc);
            panel1.Controls.Add(btnHocVien);
            panel1.Controls.Add(btnGiaoVien);
            panel1.Controls.Add(btnTrangChu);
            panel1.Location = new Point(45, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 475);
            panel1.TabIndex = 2;
            // 
            // btnKhoaHoc
            // 
            btnKhoaHoc.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhoaHoc.Location = new Point(3, 188);
            btnKhoaHoc.Name = "btnKhoaHoc";
            btnKhoaHoc.Size = new Size(155, 47);
            btnKhoaHoc.TabIndex = 9;
            btnKhoaHoc.Text = "Khóa Học";
            btnKhoaHoc.TextAlign = ContentAlignment.MiddleLeft;
            btnKhoaHoc.UseVisualStyleBackColor = true;
            btnKhoaHoc.Click += btnKhoaHoc_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangXuat.Location = new Point(3, 423);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(155, 47);
            btnDangXuat.TabIndex = 8;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(3, 376);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(155, 47);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset Mật Khẩu";
            btnReset.TextAlign = ContentAlignment.MiddleLeft;
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaiKhoan.Location = new Point(3, 329);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Size = new Size(155, 47);
            btnTaiKhoan.TabIndex = 6;
            btnTaiKhoan.Text = "Tài khoản";
            btnTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            btnTaiKhoan.UseVisualStyleBackColor = true;
            btnTaiKhoan.Click += btnTaiKhoan_Click;
            // 
            // btnKetQuaThi
            // 
            btnKetQuaThi.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKetQuaThi.Location = new Point(3, 235);
            btnKetQuaThi.Name = "btnKetQuaThi";
            btnKetQuaThi.Size = new Size(155, 47);
            btnKetQuaThi.TabIndex = 5;
            btnKetQuaThi.Text = "Kết quả";
            btnKetQuaThi.TextAlign = ContentAlignment.MiddleLeft;
            btnKetQuaThi.UseVisualStyleBackColor = true;
            btnKetQuaThi.Click += btnKetQuaThi_Click;
            // 
            // btnHocPhi
            // 
            btnHocPhi.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHocPhi.Location = new Point(3, 282);
            btnHocPhi.Name = "btnHocPhi";
            btnHocPhi.Size = new Size(155, 47);
            btnHocPhi.TabIndex = 4;
            btnHocPhi.Text = "Học phí";
            btnHocPhi.TextAlign = ContentAlignment.MiddleLeft;
            btnHocPhi.UseVisualStyleBackColor = true;
            btnHocPhi.Click += btnHocPhi_Click;
            // 
            // btnLopHoc
            // 
            btnLopHoc.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLopHoc.Location = new Point(3, 141);
            btnLopHoc.Name = "btnLopHoc";
            btnLopHoc.Size = new Size(155, 47);
            btnLopHoc.TabIndex = 3;
            btnLopHoc.Text = "Lớp học";
            btnLopHoc.TextAlign = ContentAlignment.MiddleLeft;
            btnLopHoc.UseVisualStyleBackColor = true;
            btnLopHoc.Click += btnLopHoc_Click;
            // 
            // btnHocVien
            // 
            btnHocVien.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHocVien.Location = new Point(3, 94);
            btnHocVien.Name = "btnHocVien";
            btnHocVien.Size = new Size(155, 47);
            btnHocVien.TabIndex = 2;
            btnHocVien.Text = "Học viên";
            btnHocVien.TextAlign = ContentAlignment.MiddleLeft;
            btnHocVien.UseVisualStyleBackColor = true;
            btnHocVien.Click += button3_Click;
            // 
            // btnGiaoVien
            // 
            btnGiaoVien.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiaoVien.Location = new Point(3, 47);
            btnGiaoVien.Name = "btnGiaoVien";
            btnGiaoVien.Size = new Size(155, 47);
            btnGiaoVien.TabIndex = 1;
            btnGiaoVien.Text = "Giáo viên";
            btnGiaoVien.TextAlign = ContentAlignment.MiddleLeft;
            btnGiaoVien.UseVisualStyleBackColor = true;
            btnGiaoVien.Click += btnGiaoVien_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrangChu.Location = new Point(3, 0);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(155, 47);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang chủ";
            btnTrangChu.TextAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(52, 21);
            button8.Name = "button8";
            button8.RightToLeft = RightToLeft.No;
            button8.Size = new Size(155, 69);
            button8.TabIndex = 3;
            button8.Text = "Canada English";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = true;
            // 
            // lblXinChao
            // 
            lblXinChao.AutoSize = true;
            lblXinChao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblXinChao.Location = new Point(226, 28);
            lblXinChao.Name = "lblXinChao";
            lblXinChao.Size = new Size(234, 41);
            lblXinChao.TabIndex = 4;
            lblXinChao.Text = "Xin chào, Admin";
            lblXinChao.Click += label1_Click_1;
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNgay.Location = new Point(226, 73);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(241, 20);
            lblNgay.TabIndex = 5;
            lblNgay.Text = "Thứ bảy, ngày tháng năm để đây ";
            lblNgay.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 24;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlHome);
            pnlMain.Location = new Point(226, 93);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1100, 600);
            pnlMain.TabIndex = 25;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // pnlHome
            // 
            pnlHome.Controls.Add(label2);
            pnlHome.Controls.Add(chartKetQua);
            pnlHome.Controls.Add(label15);
            pnlHome.Controls.Add(label14);
            pnlHome.Controls.Add(label13);
            pnlHome.Controls.Add(chartHocVien);
            pnlHome.Controls.Add(label12);
            pnlHome.Controls.Add(label11);
            pnlHome.Controls.Add(lblTongHocPhi);
            pnlHome.Controls.Add(lblTongLop);
            pnlHome.Controls.Add(lblTongGiaoVien);
            pnlHome.Controls.Add(lblTongHocVien);
            pnlHome.Controls.Add(label6);
            pnlHome.Controls.Add(label5);
            pnlHome.Controls.Add(label4);
            pnlHome.Controls.Add(label3);
            pnlHome.Location = new Point(3, 3);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(1077, 594);
            pnlHome.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(593, 102);
            label2.Name = "label2";
            label2.Size = new Size(164, 28);
            label2.TabIndex = 49;
            label2.Text = "Tỷ lệ học viên đạt";
            label2.Click += label2_Click_1;
            // 
            // chartKetQua
            // 
            chartArea1.Name = "ChartArea1";
            chartKetQua.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartKetQua.Legends.Add(legend1);
            chartKetQua.Location = new Point(593, 143);
            chartKetQua.Name = "chartKetQua";
            chartKetQua.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartKetQua.Series.Add(series1);
            chartKetQua.Size = new Size(423, 212);
            chartKetQua.TabIndex = 48;
            chartKetQua.Text = "chart2";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(135, 497);
            label15.Name = "label15";
            label15.Size = new Size(199, 20);
            label15.TabIndex = 47;
            label15.Text = "Số lớp chưa nhập kết quả thi";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(135, 465);
            label14.Name = "label14";
            label14.Size = new Size(219, 20);
            label14.TabIndex = 46;
            label14.Text = "Số đánh giá điểm thấp cần xem";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(135, 438);
            label13.Name = "label13";
            label13.Size = new Size(185, 20);
            label13.TabIndex = 45;
            label13.Text = "Số lớp khai giảng tuần này";
            // 
            // chartHocVien
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.Maximum = 12D;
            chartArea2.AxisX.Minimum = 1D;
            chartArea2.AxisX.Title = "Tháng";
            chartArea2.AxisY.Interval = 1D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.Title = "Số học viên";
            chartArea2.Name = "ChartArea1";
            chartHocVien.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartHocVien.Legends.Add(legend2);
            chartHocVien.Location = new Point(135, 144);
            chartHocVien.Name = "chartHocVien";
            chartHocVien.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "Số học viên đăng ký";
            series2.Name = "Series1";
            series2.SmartLabelStyle.Enabled = false;
            chartHocVien.Series.Add(series2);
            chartHocVien.Size = new Size(423, 212);
            chartHocVien.TabIndex = 44;
            chartHocVien.Text = "chart1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(135, 397);
            label12.Name = "label12";
            label12.Size = new Size(96, 28);
            label12.TabIndex = 43;
            label12.Text = "Cần chú ý";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(135, 104);
            label11.Name = "label11";
            label11.Size = new Size(264, 28);
            label11.TabIndex = 42;
            label11.Text = "Học viên đăng ký theo tháng";
            // 
            // lblTongHocPhi
            // 
            lblTongHocPhi.AutoSize = true;
            lblTongHocPhi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongHocPhi.Location = new Point(736, 46);
            lblTongHocPhi.Name = "lblTongHocPhi";
            lblTongHocPhi.Size = new Size(205, 20);
            lblTongHocPhi.TabIndex = 41;
            lblTongHocPhi.Text = "Số học phí tháng này để đây";
            // 
            // lblTongLop
            // 
            lblTongLop.AutoSize = true;
            lblTongLop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongLop.Location = new Point(492, 46);
            lblTongLop.Name = "lblTongLop";
            lblTongLop.Size = new Size(168, 20);
            lblTongLop.TabIndex = 40;
            lblTongLop.Text = "Số lớp đang mở để đây";
            // 
            // lblTongGiaoVien
            // 
            lblTongGiaoVien.AutoSize = true;
            lblTongGiaoVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongGiaoVien.Location = new Point(301, 46);
            lblTongGiaoVien.Name = "lblTongGiaoVien";
            lblTongGiaoVien.Size = new Size(143, 20);
            lblTongGiaoVien.TabIndex = 39;
            lblTongGiaoVien.Text = "Số giáo viên để đây";
            // 
            // lblTongHocVien
            // 
            lblTongHocVien.AutoSize = true;
            lblTongHocVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongHocVien.Location = new Point(122, 46);
            lblTongHocVien.Name = "lblTongHocVien";
            lblTongHocVien.Size = new Size(138, 20);
            lblTongHocVien.TabIndex = 38;
            lblTongHocVien.Text = "Số học viên để đây";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(736, 2);
            label6.Name = "label6";
            label6.Size = new Size(234, 37);
            label6.TabIndex = 37;
            label6.Text = "Học phí tháng này";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(492, 2);
            label5.Name = "label5";
            label5.Size = new Size(176, 37);
            label5.TabIndex = 36;
            label5.Text = "Lớp đang mở";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(301, 2);
            label4.Name = "label4";
            label4.Size = new Size(133, 37);
            label4.TabIndex = 35;
            label4.Text = "Giáo Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(122, 2);
            label3.Name = "label3";
            label3.Size = new Size(124, 37);
            label3.TabIndex = 34;
            label3.Text = "Học Viên";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(pnlMain);
            Controls.Add(label1);
            Controls.Add(lblNgay);
            Controls.Add(lblXinChao);
            Controls.Add(button8);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMain";
            Text = "FrmMain";
            Load += FrmMain_Load_1;
            panel1.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlHome.ResumeLayout(false);
            pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartKetQua).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartHocVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button btnHocVien;
        private Button btnGiaoVien;
        private Button btnTrangChu;
        private Button btnKetQuaThi;
        private Button btnHocPhi;
        private Button btnLopHoc;
        private Button btnTaiKhoan;
        private Button button8;
        private Label lblXinChao;
        private Label lblNgay;
        private Button btnReset;
        private Button btnDangXuat;
        private Label label1;
        private Panel pnlMain;
        private Panel pnlHome;
        private Label label15;
        private Label label14;
        private Label label13;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHocVien;
        private Label label12;
        private Label label11;
        private Label lblTongHocPhi;
        private Label lblTongLop;
        private Label lblTongGiaoVien;
        private Label lblTongHocVien;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnKhoaHoc;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKetQua;
    }
}