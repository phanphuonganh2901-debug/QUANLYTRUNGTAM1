namespace QuanLyTrungTam.FORM
{
    partial class FrmMainHV
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainHV));
            panel2 = new Panel();
            lblEmail = new Label();
            button3 = new Button();
            lblCMND = new Label();
            lblSDT = new Label();
            lblNgheNghiep = new Label();
            lblNgaySinh = new Label();
            lblMaHV = new Label();
            lblTenHV = new Label();
            pnlMain = new Panel();
            pnlHome = new Panel();
            lblHocPhiCon = new Label();
            label6 = new Label();
            dataLichHomNay = new DataGridView();
            label11 = new Label();
            chartDiem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblTongKH = new Label();
            lblDiemTB = new Label();
            lblTongLop = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnHocPhi = new Button();
            panelGV = new Panel();
            button2 = new Button();
            button1 = new Button();
            panelHV = new Panel();
            btnKetQua = new Button();
            btnDSHV = new Button();
            btnKhoaHoc = new Button();
            btnDangXuat = new Button();
            btnLichHoc = new Button();
            btnKetQuaThi = new Button();
            btnTrangChu = new Button();
            lblNgay = new Label();
            lblXinChao = new Label();
            button8 = new Button();
            panel2.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataLichHomNay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDiem).BeginInit();
            panel1.SuspendLayout();
            panelGV.SuspendLayout();
            panelHV.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(lblCMND);
            panel2.Controls.Add(lblSDT);
            panel2.Controls.Add(lblNgheNghiep);
            panel2.Controls.Add(lblNgaySinh);
            panel2.Controls.Add(lblMaHV);
            panel2.Controls.Add(lblTenHV);
            panel2.Location = new Point(3, 408);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 276);
            panel2.TabIndex = 34;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(9, 191);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "email";
            // 
            // button3
            // 
            button3.Location = new Point(55, 232);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "Chi Tiết";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblCMND
            // 
            lblCMND.AutoSize = true;
            lblCMND.Location = new Point(9, 75);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new Size(53, 20);
            lblCMND.TabIndex = 7;
            lblCMND.Text = "CMND";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(9, 162);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(36, 20);
            lblSDT.TabIndex = 5;
            lblSDT.Text = "SĐT";
            // 
            // lblNgheNghiep
            // 
            lblNgheNghiep.AutoSize = true;
            lblNgheNghiep.Location = new Point(9, 133);
            lblNgheNghiep.Name = "lblNgheNghiep";
            lblNgheNghiep.Size = new Size(98, 20);
            lblNgheNghiep.TabIndex = 4;
            lblNgheNghiep.Text = "Nghề Nghiệp";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(9, 104);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(74, 20);
            lblNgaySinh.TabIndex = 3;
            lblNgaySinh.Text = "Ngày sinh";
            lblNgaySinh.Click += lblNgaySinh_Click;
            // 
            // lblMaHV
            // 
            lblMaHV.AutoSize = true;
            lblMaHV.Location = new Point(9, 46);
            lblMaHV.Name = "lblMaHV";
            lblMaHV.Size = new Size(49, 20);
            lblMaHV.TabIndex = 2;
            lblMaHV.Text = "mã hv";
            // 
            // lblTenHV
            // 
            lblTenHV.AutoSize = true;
            lblTenHV.Location = new Point(9, 17);
            lblTenHV.Name = "lblTenHV";
            lblTenHV.Size = new Size(49, 20);
            lblTenHV.TabIndex = 1;
            lblTenHV.Text = "tên hv";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlHome);
            pnlMain.Location = new Point(236, 87);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1100, 600);
            pnlMain.TabIndex = 33;
            // 
            // pnlHome
            // 
            pnlHome.Controls.Add(lblHocPhiCon);
            pnlHome.Controls.Add(label6);
            pnlHome.Controls.Add(dataLichHomNay);
            pnlHome.Controls.Add(label11);
            pnlHome.Controls.Add(chartDiem);
            pnlHome.Controls.Add(lblTongKH);
            pnlHome.Controls.Add(lblDiemTB);
            pnlHome.Controls.Add(lblTongLop);
            pnlHome.Controls.Add(label4);
            pnlHome.Controls.Add(label3);
            pnlHome.Controls.Add(label1);
            pnlHome.Controls.Add(label2);
            pnlHome.Location = new Point(12, 3);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(1077, 594);
            pnlHome.TabIndex = 1;
            pnlHome.Paint += pnlHome_Paint;
            // 
            // lblHocPhiCon
            // 
            lblHocPhiCon.AutoSize = true;
            lblHocPhiCon.BackColor = Color.Transparent;
            lblHocPhiCon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHocPhiCon.Location = new Point(105, 38);
            lblHocPhiCon.Name = "lblHocPhiCon";
            lblHocPhiCon.Size = new Size(60, 20);
            lblHocPhiCon.TabIndex = 65;
            lblHocPhiCon.Text = "học phí";
            lblHocPhiCon.Click += lblHocPhiCon_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(399, 82);
            label6.Name = "label6";
            label6.Size = new Size(152, 23);
            label6.TabIndex = 64;
            label6.Text = "Lịch Học hôm nay";
            // 
            // dataLichHomNay
            // 
            dataLichHomNay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLichHomNay.Location = new Point(399, 117);
            dataLichHomNay.Name = "dataLichHomNay";
            dataLichHomNay.RowHeadersWidth = 51;
            dataLichHomNay.RowTemplate.Height = 29;
            dataLichHomNay.Size = new Size(629, 439);
            dataLichHomNay.TabIndex = 63;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.OrangeRed;
            label11.Location = new Point(16, 82);
            label11.Name = "label11";
            label11.Size = new Size(124, 23);
            label11.TabIndex = 61;
            label11.Text = "Điểm các môn";
            // 
            // chartDiem
            // 
            chartArea1.Name = "ChartArea1";
            chartDiem.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiem.Legends.Add(legend1);
            chartDiem.Location = new Point(16, 108);
            chartDiem.Name = "chartDiem";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiem.Series.Add(series1);
            chartDiem.Size = new Size(300, 212);
            chartDiem.TabIndex = 59;
            chartDiem.Text = "chart1";
            // 
            // lblTongKH
            // 
            lblTongKH.AutoSize = true;
            lblTongKH.BackColor = Color.Transparent;
            lblTongKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongKH.Location = new Point(728, 38);
            lblTongKH.Name = "lblTongKH";
            lblTongKH.Size = new Size(146, 20);
            lblTongKH.TabIndex = 58;
            lblTongKH.Text = "Số khóa học của gv ";
            lblTongKH.Click += lblTongKH_Click;
            // 
            // lblDiemTB
            // 
            lblDiemTB.AutoSize = true;
            lblDiemTB.BackColor = Color.Transparent;
            lblDiemTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiemTB.Location = new Point(506, 38);
            lblDiemTB.Name = "lblDiemTB";
            lblDiemTB.Size = new Size(99, 20);
            lblDiemTB.TabIndex = 57;
            lblDiemTB.Text = "điểm tb môn";
            lblDiemTB.Click += lblDiemTB_Click;
            // 
            // lblTongLop
            // 
            lblTongLop.AutoSize = true;
            lblTongLop.BackColor = Color.Transparent;
            lblTongLop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongLop.Location = new Point(308, 38);
            lblTongLop.Name = "lblTongLop";
            lblTongLop.Size = new Size(156, 20);
            lblTongLop.TabIndex = 56;
            lblTongLop.Text = "hiển thị lớp đang học";
            lblTongLop.Click += lblTongHV_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(717, 10);
            label4.Name = "label4";
            label4.Size = new Size(127, 28);
            label4.TabIndex = 54;
            label4.Text = "Số khóa học";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(502, 10);
            label3.Name = "label3";
            label3.Size = new Size(168, 28);
            label3.TabIndex = 53;
            label3.Text = "Điểm trung bình";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(308, 10);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 51;
            label1.Text = "Lớp đang học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(96, 10);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 49;
            label2.Text = "Học phí còn lại";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHocPhi);
            panel1.Controls.Add(panelGV);
            panel1.Controls.Add(panelHV);
            panel1.Controls.Add(btnKhoaHoc);
            panel1.Controls.Add(btnDangXuat);
            panel1.Controls.Add(btnLichHoc);
            panel1.Controls.Add(btnKetQuaThi);
            panel1.Controls.Add(btnTrangChu);
            panel1.Location = new Point(68, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 315);
            panel1.TabIndex = 32;
            // 
            // btnHocPhi
            // 
            btnHocPhi.BackColor = Color.Orange;
            btnHocPhi.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHocPhi.Location = new Point(4, 215);
            btnHocPhi.Name = "btnHocPhi";
            btnHocPhi.Size = new Size(155, 47);
            btnHocPhi.TabIndex = 11;
            btnHocPhi.Text = "Học Phí";
            btnHocPhi.TextAlign = ContentAlignment.MiddleLeft;
            btnHocPhi.UseVisualStyleBackColor = false;
            btnHocPhi.Click += btnHocPhi_Click;
            // 
            // panelGV
            // 
            panelGV.Controls.Add(button2);
            panelGV.Controls.Add(button1);
            panelGV.Location = new Point(164, 47);
            panelGV.Name = "panelGV";
            panelGV.Size = new Size(136, 88);
            panelGV.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(3, 49);
            button2.Name = "button2";
            button2.Size = new Size(130, 36);
            button2.TabIndex = 1;
            button2.Text = "Lịch Dạy";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 10);
            button1.Name = "button1";
            button1.Size = new Size(133, 40);
            button1.TabIndex = 0;
            button1.Text = "Danh sách";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelHV
            // 
            panelHV.Controls.Add(btnKetQua);
            panelHV.Controls.Add(btnDSHV);
            panelHV.Location = new Point(164, 96);
            panelHV.Name = "panelHV";
            panelHV.Size = new Size(133, 92);
            panelHV.TabIndex = 10;
            // 
            // btnKetQua
            // 
            btnKetQua.AutoSize = true;
            btnKetQua.Location = new Point(0, 53);
            btnKetQua.Name = "btnKetQua";
            btnKetQua.Size = new Size(130, 36);
            btnKetQua.TabIndex = 2;
            btnKetQua.Text = "Kết Quả thi";
            btnKetQua.UseVisualStyleBackColor = true;
            // 
            // btnDSHV
            // 
            btnDSHV.Location = new Point(0, 13);
            btnDSHV.Name = "btnDSHV";
            btnDSHV.Size = new Size(130, 36);
            btnDSHV.TabIndex = 1;
            btnDSHV.Text = "Danh Sách ";
            btnDSHV.UseVisualStyleBackColor = true;
            // 
            // btnKhoaHoc
            // 
            btnKhoaHoc.BackColor = Color.Orange;
            btnKhoaHoc.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhoaHoc.Location = new Point(4, 162);
            btnKhoaHoc.Name = "btnKhoaHoc";
            btnKhoaHoc.Size = new Size(155, 47);
            btnKhoaHoc.TabIndex = 9;
            btnKhoaHoc.Text = "Khóa Học";
            btnKhoaHoc.TextAlign = ContentAlignment.MiddleLeft;
            btnKhoaHoc.UseVisualStyleBackColor = false;
            btnKhoaHoc.Click += btnKhoaHoc_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Orange;
            btnDangXuat.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangXuat.Location = new Point(3, 265);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(155, 47);
            btnDangXuat.TabIndex = 8;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnLichHoc
            // 
            btnLichHoc.BackColor = Color.Orange;
            btnLichHoc.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLichHoc.Location = new Point(3, 109);
            btnLichHoc.Name = "btnLichHoc";
            btnLichHoc.Size = new Size(155, 47);
            btnLichHoc.TabIndex = 3;
            btnLichHoc.Text = "Lịch Học";
            btnLichHoc.TextAlign = ContentAlignment.MiddleLeft;
            btnLichHoc.UseVisualStyleBackColor = false;
            btnLichHoc.Click += btnLichHoc_Click;
            // 
            // btnKetQuaThi
            // 
            btnKetQuaThi.BackColor = Color.Orange;
            btnKetQuaThi.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKetQuaThi.Location = new Point(3, 53);
            btnKetQuaThi.Name = "btnKetQuaThi";
            btnKetQuaThi.Size = new Size(155, 47);
            btnKetQuaThi.TabIndex = 2;
            btnKetQuaThi.Text = "Kết Quả Thi";
            btnKetQuaThi.TextAlign = ContentAlignment.MiddleLeft;
            btnKetQuaThi.UseVisualStyleBackColor = false;
            btnKetQuaThi.Click += btnKetQuaThi_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.Orange;
            btnTrangChu.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrangChu.Location = new Point(3, 0);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(155, 47);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang chủ";
            btnTrangChu.TextAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.UseVisualStyleBackColor = false;
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNgay.Location = new Point(255, 64);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(241, 20);
            lblNgay.TabIndex = 31;
            lblNgay.Text = "Thứ bảy, ngày tháng năm để đây ";
            // 
            // lblXinChao
            // 
            lblXinChao.AutoSize = true;
            lblXinChao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblXinChao.Location = new Point(255, 19);
            lblXinChao.Name = "lblXinChao";
            lblXinChao.Size = new Size(212, 41);
            lblXinChao.TabIndex = 30;
            lblXinChao.Text = "Xin chào, HV B";
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(71, 12);
            button8.Name = "button8";
            button8.RightToLeft = RightToLeft.No;
            button8.Size = new Size(155, 69);
            button8.TabIndex = 29;
            button8.Text = "Canada English";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = true;
            // 
            // FrmMainHV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 721);
            Controls.Add(panel2);
            Controls.Add(pnlMain);
            Controls.Add(panel1);
            Controls.Add(lblNgay);
            Controls.Add(lblXinChao);
            Controls.Add(button8);
            Name = "FrmMainHV";
            Text = "FrmMainHV";
            Load += FrmMainHV_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlHome.ResumeLayout(false);
            pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataLichHomNay).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDiem).EndInit();
            panel1.ResumeLayout(false);
            panelGV.ResumeLayout(false);
            panelHV.ResumeLayout(false);
            panelHV.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button button3;
        private Label lblSDT;
        private Label lblNgheNghiep;
        private Label lblNgaySinh;
        private Label lblMaHV;
        private Label lblTenHV;
        private Panel pnlMain;
        private Panel pnlHome;
        private Label lblHocPhiCon;
        private Label label6;
        private DataGridView dataLichHomNay;
        private Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiem;
        private Label lblTongKH;
        private Label lblDiemTB;
        private Label lblTongLop;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panelGV;
        private Button button2;
        private Button button1;
        private Panel panelHV;
        private Button btnKetQua;
        private Button btnDSHV;
        private Button btnKhoaHoc;
        private Button btnDangXuat;
        private Button btnLichHoc;
        private Button btnKetQuaThi;
        private Button btnTrangChu;
        private Label lblNgay;
        private Label lblXinChao;
        private Button button8;
        private Button btnHocPhi;
        private Label lblCMND;
        private Label lblEmail;
    }
}