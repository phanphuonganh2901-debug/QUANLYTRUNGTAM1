namespace QuanLyTrungTam.FORM
{
    partial class FrmMainGV
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainGV));
            lblNgay = new Label();
            lblXinChao = new Label();
            pnlMain = new Panel();
            pnlHome = new Panel();
            lblTongLop = new Label();
            label6 = new Label();
            dataLichHomNay = new DataGridView();
            label5 = new Label();
            label11 = new Label();
            chartDiem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartHocVien = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblTongKH = new Label();
            lblTongBuoi = new Label();
            lblTongHV = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panelGV = new Panel();
            button2 = new Button();
            button1 = new Button();
            panelHV = new Panel();
            btnKetQua = new Button();
            btnDSHV = new Button();
            btnKhoaHoc = new Button();
            btnDangXuat = new Button();
            btnLichDay = new Button();
            btnHocVien = new Button();
            btnTrangChu = new Button();
            panel2 = new Panel();
            button3 = new Button();
            lblSDT = new Label();
            lblDiaChi = new Label();
            lblNgaySinh = new Label();
            lblMaGV = new Label();
            lblTenGV = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel5 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            pnlMain.SuspendLayout();
            pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataLichHomNay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartHocVien).BeginInit();
            panel1.SuspendLayout();
            panelGV.SuspendLayout();
            panelHV.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNgay.Location = new Point(223, 48);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(188, 15);
            lblNgay.TabIndex = 8;
            lblNgay.Text = "Thứ bảy, ngày tháng năm để đây ";
            // 
            // lblXinChao
            // 
            lblXinChao.AutoSize = true;
            lblXinChao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblXinChao.Location = new Point(223, 14);
            lblXinChao.Name = "lblXinChao";
            lblXinChao.Size = new Size(171, 32);
            lblXinChao.TabIndex = 7;
            lblXinChao.Text = "Xin chào, GV A";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlHome);
            pnlMain.Location = new Point(206, 65);
            pnlMain.Margin = new Padding(3, 2, 3, 2);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(962, 450);
            pnlMain.TabIndex = 27;
            // 
            // pnlHome
            // 
            pnlHome.Controls.Add(lblTongLop);
            pnlHome.Controls.Add(label6);
            pnlHome.Controls.Add(dataLichHomNay);
            pnlHome.Controls.Add(label5);
            pnlHome.Controls.Add(label11);
            pnlHome.Controls.Add(chartDiem);
            pnlHome.Controls.Add(chartHocVien);
            pnlHome.Controls.Add(lblTongKH);
            pnlHome.Controls.Add(lblTongBuoi);
            pnlHome.Controls.Add(lblTongHV);
            pnlHome.Controls.Add(label4);
            pnlHome.Controls.Add(label3);
            pnlHome.Controls.Add(label1);
            pnlHome.Controls.Add(label2);
            pnlHome.Location = new Point(10, 2);
            pnlHome.Margin = new Padding(3, 2, 3, 2);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(942, 446);
            pnlHome.TabIndex = 1;
            pnlHome.Paint += pnlHome_Paint;
            // 
            // lblTongLop
            // 
            lblTongLop.AutoSize = true;
            lblTongLop.BackColor = Color.Transparent;
            lblTongLop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongLop.Location = new Point(102, 28);
            lblTongLop.Name = "lblTongLop";
            lblTongLop.Size = new Size(64, 15);
            lblTongLop.TabIndex = 65;
            lblTongLop.Text = "Số lớp dạy";
            lblTongLop.Click += lblTongLop_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(349, 62);
            label6.Name = "label6";
            label6.Size = new Size(126, 19);
            label6.TabIndex = 64;
            label6.Text = "Lịch dạy hôm nay";
            // 
            // dataLichHomNay
            // 
            dataLichHomNay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLichHomNay.Location = new Point(349, 88);
            dataLichHomNay.Margin = new Padding(3, 2, 3, 2);
            dataLichHomNay.Name = "dataLichHomNay";
            dataLichHomNay.RowHeadersWidth = 51;
            dataLichHomNay.RowTemplate.Height = 29;
            dataLichHomNay.Size = new Size(550, 329);
            dataLichHomNay.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.OrangeRed;
            label5.Location = new Point(15, 256);
            label5.Name = "label5";
            label5.Size = new Size(178, 19);
            label5.TabIndex = 62;
            label5.Text = "Điểm trung bình từng lớp";
            label5.Click += label5_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.OrangeRed;
            label11.Location = new Point(14, 62);
            label11.Name = "label11";
            label11.Size = new Size(181, 19);
            label11.TabIndex = 61;
            label11.Text = "Số học viên theo từng lớp";
            // 
            // chartDiem
            // 
            chartArea1.Name = "ChartArea1";
            chartDiem.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiem.Legends.Add(legend1);
            chartDiem.Location = new Point(14, 276);
            chartDiem.Margin = new Padding(3, 2, 3, 2);
            chartDiem.Name = "chartDiem";
            chartDiem.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiem.Series.Add(series1);
            chartDiem.Size = new Size(262, 159);
            chartDiem.TabIndex = 60;
            chartDiem.Text = "chart2";
            // 
            // chartHocVien
            // 
            chartArea2.Name = "ChartArea1";
            chartHocVien.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartHocVien.Legends.Add(legend2);
            chartHocVien.Location = new Point(14, 81);
            chartHocVien.Margin = new Padding(3, 2, 3, 2);
            chartHocVien.Name = "chartHocVien";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartHocVien.Series.Add(series2);
            chartHocVien.Size = new Size(262, 159);
            chartHocVien.TabIndex = 59;
            chartHocVien.Text = "chart1";
            // 
            // lblTongKH
            // 
            lblTongKH.AutoSize = true;
            lblTongKH.BackColor = Color.Transparent;
            lblTongKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongKH.Location = new Point(637, 28);
            lblTongKH.Name = "lblTongKH";
            lblTongKH.Size = new Size(116, 15);
            lblTongKH.TabIndex = 58;
            lblTongKH.Text = "Số khóa học của gv ";
            // 
            // lblTongBuoi
            // 
            lblTongBuoi.AutoSize = true;
            lblTongBuoi.BackColor = Color.Transparent;
            lblTongBuoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongBuoi.Location = new Point(443, 28);
            lblTongBuoi.Name = "lblTongBuoi";
            lblTongBuoi.Size = new Size(108, 15);
            lblTongBuoi.TabIndex = 57;
            lblTongBuoi.Text = "Số ca dạy hôm nay";
            // 
            // lblTongHV
            // 
            lblTongHV.AutoSize = true;
            lblTongHV.BackColor = Color.Transparent;
            lblTongHV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongHV.Location = new Point(270, 28);
            lblTongHV.Name = "lblTongHV";
            lblTongHV.Size = new Size(93, 15);
            lblTongHV.TabIndex = 56;
            lblTongHV.Text = "Số học viên dạy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(627, 8);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 54;
            label4.Text = "Số khóa học";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(439, 8);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 53;
            label3.Text = "Buổi hôm nay";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(254, 8);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 51;
            label1.Text = "Số học viên dạy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(84, 8);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 49;
            label2.Text = "Lớp đang dạy";
            // 
            // panel1
            // 
            panel1.Controls.Add(panelGV);
            panel1.Controls.Add(panelHV);
            panel1.Controls.Add(btnKhoaHoc);
            panel1.Controls.Add(btnDangXuat);
            panel1.Controls.Add(btnLichDay);
            panel1.Controls.Add(btnHocVien);
            panel1.Controls.Add(btnTrangChu);
            panel1.Location = new Point(60, 65);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 210);
            panel1.TabIndex = 26;
            panel1.Paint += panel1_Paint;
            // 
            // panelGV
            // 
            panelGV.Controls.Add(button2);
            panelGV.Controls.Add(button1);
            panelGV.Location = new Point(144, 35);
            panelGV.Margin = new Padding(3, 2, 3, 2);
            panelGV.Name = "panelGV";
            panelGV.Size = new Size(119, 66);
            panelGV.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(3, 37);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(114, 27);
            button2.TabIndex = 1;
            button2.Text = "Lịch Dạy";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 8);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(116, 30);
            button1.TabIndex = 0;
            button1.Text = "Danh sách";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelHV
            // 
            panelHV.Controls.Add(btnKetQua);
            panelHV.Controls.Add(btnDSHV);
            panelHV.Location = new Point(144, 72);
            panelHV.Margin = new Padding(3, 2, 3, 2);
            panelHV.Name = "panelHV";
            panelHV.Size = new Size(116, 69);
            panelHV.TabIndex = 10;
            // 
            // btnKetQua
            // 
            btnKetQua.AutoSize = true;
            btnKetQua.Location = new Point(0, 40);
            btnKetQua.Margin = new Padding(3, 2, 3, 2);
            btnKetQua.Name = "btnKetQua";
            btnKetQua.Size = new Size(114, 27);
            btnKetQua.TabIndex = 2;
            btnKetQua.Text = "Kết Quả thi";
            btnKetQua.UseVisualStyleBackColor = true;
            // 
            // btnDSHV
            // 
            btnDSHV.Location = new Point(0, 10);
            btnDSHV.Margin = new Padding(3, 2, 3, 2);
            btnDSHV.Name = "btnDSHV";
            btnDSHV.Size = new Size(114, 27);
            btnDSHV.TabIndex = 1;
            btnDSHV.Text = "Danh Sách ";
            btnDSHV.UseVisualStyleBackColor = true;
            // 
            // btnKhoaHoc
            // 
            btnKhoaHoc.BackColor = Color.Orange;
            btnKhoaHoc.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhoaHoc.Location = new Point(4, 122);
            btnKhoaHoc.Margin = new Padding(3, 2, 3, 2);
            btnKhoaHoc.Name = "btnKhoaHoc";
            btnKhoaHoc.Size = new Size(136, 35);
            btnKhoaHoc.TabIndex = 9;
            btnKhoaHoc.Text = "Khóa Học";
            btnKhoaHoc.TextAlign = ContentAlignment.MiddleLeft;
            btnKhoaHoc.UseVisualStyleBackColor = false;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Orange;
            btnDangXuat.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangXuat.Location = new Point(3, 161);
            btnDangXuat.Margin = new Padding(3, 2, 3, 2);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(136, 35);
            btnDangXuat.TabIndex = 8;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnLichDay
            // 
            btnLichDay.BackColor = Color.Orange;
            btnLichDay.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLichDay.Location = new Point(3, 82);
            btnLichDay.Margin = new Padding(3, 2, 3, 2);
            btnLichDay.Name = "btnLichDay";
            btnLichDay.Size = new Size(136, 35);
            btnLichDay.TabIndex = 3;
            btnLichDay.Text = "Lịch Dạy";
            btnLichDay.TextAlign = ContentAlignment.MiddleLeft;
            btnLichDay.UseVisualStyleBackColor = false;
            // 
            // btnHocVien
            // 
            btnHocVien.BackColor = Color.Orange;
            btnHocVien.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHocVien.Location = new Point(3, 40);
            btnHocVien.Margin = new Padding(3, 2, 3, 2);
            btnHocVien.Name = "btnHocVien";
            btnHocVien.Size = new Size(136, 35);
            btnHocVien.TabIndex = 2;
            btnHocVien.Text = "Học viên";
            btnHocVien.TextAlign = ContentAlignment.MiddleLeft;
            btnHocVien.UseVisualStyleBackColor = false;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.Orange;
            btnTrangChu.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrangChu.Location = new Point(3, 0);
            btnTrangChu.Margin = new Padding(3, 2, 3, 2);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(136, 35);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang chủ";
            btnTrangChu.TextAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(lblSDT);
            panel2.Controls.Add(lblDiaChi);
            panel2.Controls.Add(lblNgaySinh);
            panel2.Controls.Add(lblMaGV);
            panel2.Controls.Add(lblTenGV);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(10, 280);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 252);
            panel2.TabIndex = 28;
            // 
            // button3
            // 
            button3.Location = new Point(52, 214);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 6;
            button3.Text = "Chi Tiết";
            button3.UseVisualStyleBackColor = true;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(3, 154);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(28, 15);
            lblSDT.TabIndex = 5;
            lblSDT.Text = "SĐT";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(3, 130);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(42, 15);
            lblDiaChi.TabIndex = 4;
            lblDiaChi.Text = "địa chỉ";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(3, 107);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(60, 15);
            lblNgaySinh.TabIndex = 3;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblMaGV
            // 
            lblMaGV.AutoSize = true;
            lblMaGV.Location = new Point(3, 86);
            lblMaGV.Name = "lblMaGV";
            lblMaGV.Size = new Size(40, 15);
            lblMaGV.TabIndex = 2;
            lblMaGV.Text = "mã gv";
            // 
            // lblTenGV
            // 
            lblTenGV.AutoSize = true;
            lblTenGV.Location = new Point(3, 64);
            lblTenGV.Name = "lblTenGV";
            lblTenGV.Size = new Size(40, 15);
            lblTenGV.TabIndex = 1;
            lblTenGV.Text = "tên gv";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(30, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(60, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(142, 55);
            panel3.TabIndex = 29;
            // 
            // panel5
            // 
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(64, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(78, 55);
            panel5.TabIndex = 1;
            // 
            // label9
            // 
            label9.AllowDrop = true;
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Popup;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 38);
            label9.Name = "label9";
            label9.Size = new Size(41, 13);
            label9.TabIndex = 2;
            label9.Text = "Center";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AllowDrop = true;
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 21);
            label8.Name = "label8";
            label8.Size = new Size(45, 13);
            label8.TabIndex = 1;
            label8.Text = "English";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AllowDrop = true;
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 4);
            label7.Name = "label7";
            label7.Size = new Size(46, 13);
            label7.TabIndex = 0;
            label7.Text = "Canada";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(65, 55);
            panel4.TabIndex = 0;
            // 
            // FrmMainGV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 541);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlMain);
            Controls.Add(panel1);
            Controls.Add(lblNgay);
            Controls.Add(lblXinChao);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMainGV";
            Text = "FrmMainGV";
            Load += FrmMainGV_Load;
            pnlMain.ResumeLayout(false);
            pnlHome.ResumeLayout(false);
            pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataLichHomNay).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartHocVien).EndInit();
            panel1.ResumeLayout(false);
            panelGV.ResumeLayout(false);
            panelHV.ResumeLayout(false);
            panelHV.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNgay;
        private Label lblXinChao;
        private Panel pnlMain;
        private Panel panel1;
        private Panel panelGV;
        private Button button2;
        private Button button1;
        private Panel panelHV;
        private Button btnKetQua;
        private Button btnDSHV;
        private Button btnKhoaHoc;
        private Button btnDangXuat;
        private Button btnLichDay;
        private Button btnHocVien;
        private Button btnTrangChu;
        private Panel pnlHome;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHocVien;
        private Label lblTongKH;
        private Label lblTongBuoi;
        private Label lblTongHV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiem;
        private Label label5;
        private Label label11;
        private Label label6;
        private DataGridView dataLichHomNay;
        private Panel panel2;
        private Label lblMaGV;
        private Label lblTenGV;
        private PictureBox pictureBox1;
        private Button button3;
        private Label lblSDT;
        private Label lblDiaChi;
        private Label lblNgaySinh;
        private Label lblTongLop;
        private Panel panel3;
        private Panel panel5;
        private Label label7;
        private Panel panel4;
        private Label label9;
        private Label label8;
    }
}