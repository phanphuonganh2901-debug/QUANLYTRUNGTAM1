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
            pnlTop = new Panel();
            pnlMenu = new Panel();
            pnlMain = new Panel();
            label1 = new Label();
            btnGiaoVien = new Button();
            btnHocVien = new Button();
            btnKhoaHoc = new Button();
            btnLopHoc = new Button();
            btnHocPhi = new Button();
            btnKetQuaThi = new Button();
            btnThoat = new Button();
            pnlTop.SuspendLayout();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(label1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(800, 70);
            pnlTop.TabIndex = 0;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(btnGiaoVien);
            pnlMenu.Controls.Add(btnThoat);
            pnlMenu.Controls.Add(btnHocVien);
            pnlMenu.Controls.Add(btnKetQuaThi);
            pnlMenu.Controls.Add(btnHocPhi);
            pnlMenu.Controls.Add(btnLopHoc);
            pnlMenu.Controls.Add(btnKhoaHoc);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 70);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(200, 380);
            pnlMenu.TabIndex = 1;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(200, 70);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(600, 380);
            pnlMain.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(139, 40);
            label1.Name = "label1";
            label1.Size = new Size(391, 20);
            label1.TabIndex = 0;
            label1.Text = "PHẦN MỀM QUẢN LÝ TRUNG TÂM ĐÀO TẠO TIẾNG ANH ";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // btnGiaoVien
            // 
            btnGiaoVien.FlatStyle = FlatStyle.Flat;
            btnGiaoVien.Location = new Point(12, 21);
            btnGiaoVien.Name = "btnGiaoVien";
            btnGiaoVien.Size = new Size(180, 45);
            btnGiaoVien.TabIndex = 0;
            btnGiaoVien.Text = "Giáo Viên";
            btnGiaoVien.UseVisualStyleBackColor = true;
            // 
            // btnHocVien
            // 
            btnHocVien.FlatStyle = FlatStyle.Flat;
            btnHocVien.Location = new Point(12, 72);
            btnHocVien.Name = "btnHocVien";
            btnHocVien.Size = new Size(180, 45);
            btnHocVien.TabIndex = 1;
            btnHocVien.Text = "Học Viên";
            btnHocVien.UseVisualStyleBackColor = true;
            btnHocVien.Click += button2_Click;
            // 
            // btnKhoaHoc
            // 
            btnKhoaHoc.FlatStyle = FlatStyle.Flat;
            btnKhoaHoc.Location = new Point(12, 123);
            btnKhoaHoc.Name = "btnKhoaHoc";
            btnKhoaHoc.Size = new Size(180, 45);
            btnKhoaHoc.TabIndex = 2;
            btnKhoaHoc.Text = "Khóa Học";
            btnKhoaHoc.UseVisualStyleBackColor = true;
            // 
            // btnLopHoc
            // 
            btnLopHoc.FlatStyle = FlatStyle.Flat;
            btnLopHoc.Location = new Point(12, 174);
            btnLopHoc.Name = "btnLopHoc";
            btnLopHoc.Size = new Size(180, 45);
            btnLopHoc.TabIndex = 3;
            btnLopHoc.Text = "Lớp Học";
            btnLopHoc.UseVisualStyleBackColor = true;
            // 
            // btnHocPhi
            // 
            btnHocPhi.FlatStyle = FlatStyle.Flat;
            btnHocPhi.Location = new Point(12, 225);
            btnHocPhi.Name = "btnHocPhi";
            btnHocPhi.Size = new Size(180, 45);
            btnHocPhi.TabIndex = 4;
            btnHocPhi.Text = "Học Phí";
            btnHocPhi.UseVisualStyleBackColor = true;
            // 
            // btnKetQuaThi
            // 
            btnKetQuaThi.FlatStyle = FlatStyle.Flat;
            btnKetQuaThi.Location = new Point(12, 276);
            btnKetQuaThi.Name = "btnKetQuaThi";
            btnKetQuaThi.Size = new Size(180, 45);
            btnKetQuaThi.TabIndex = 5;
            btnKetQuaThi.Text = "Kết Quả Thi";
            btnKetQuaThi.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Location = new Point(12, 327);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(180, 45);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMain);
            Controls.Add(pnlMenu);
            Controls.Add(pnlTop);
            Name = "FrmMain";
            Text = "FrmMain";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Label label1;
        private Panel pnlMenu;
        private Panel pnlMain;
        private Button btnKetQuaThi;
        private Button btnHocPhi;
        private Button btnLopHoc;
        private Button btnKhoaHoc;
        private Button btnHocVien;
        private Button btnGiaoVien;
        private Button btnThoat;
    }
}