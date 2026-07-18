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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainGV));
            lblNgay = new Label();
            lblXinChao = new Label();
            button8 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dgvMainGV = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnCapNhat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMainGV).BeginInit();
            SuspendLayout();
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNgay.Location = new Point(320, 102);
            lblNgay.Margin = new Padding(5, 0, 5, 0);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(395, 32);
            lblNgay.TabIndex = 8;
            lblNgay.Text = "Thứ bảy, ngày tháng năm để đây ";
            // 
            // lblXinChao
            // 
            lblXinChao.AutoSize = true;
            lblXinChao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblXinChao.Location = new Point(320, 30);
            lblXinChao.Margin = new Padding(5, 0, 5, 0);
            lblXinChao.Name = "lblXinChao";
            lblXinChao.Size = new Size(371, 65);
            lblXinChao.TabIndex = 7;
            lblXinChao.Text = "Xin chào, Admin";
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(37, 19);
            button8.Margin = new Padding(5);
            button8.Name = "button8";
            button8.RightToLeft = RightToLeft.No;
            button8.Size = new Size(252, 110);
            button8.TabIndex = 6;
            button8.Text = "Canada English";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(320, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 9;
            // 
            // dgvMainGV
            // 
            dgvMainGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMainGV.Location = new Point(811, 30);
            dgvMainGV.Name = "dgvMainGV";
            dgvMainGV.RowHeadersWidth = 82;
            dgvMainGV.RowTemplate.Height = 41;
            dgvMainGV.Size = new Size(1078, 1091);
            dgvMainGV.TabIndex = 10;
            dgvMainGV.SelectionChanged += dgvMainGV_SelectionChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(83, 237);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(83, 419);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(83, 331);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(150, 46);
            btnCapNhat.TabIndex = 13;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // FrmMainGV
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2190, 1154);
            Controls.Add(btnCapNhat);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvMainGV);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblNgay);
            Controls.Add(lblXinChao);
            Controls.Add(button8);
            Margin = new Padding(5);
            Name = "FrmMainGV";
            Text = "FrmMainGV";
            Load += FrmMainGV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMainGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNgay;
        private Label lblXinChao;
        private Button button8;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgvMainGV;
        private Button btnThem;
        private Button btnSua;
        private Button btnCapNhat;
    }
}