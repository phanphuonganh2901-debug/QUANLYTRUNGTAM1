namespace QuanLyTrungTam.FORM
{
    partial class FrmKetQuaThi
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
            dgvKetQua = new DataGridView();
            btnLamMoi = new Button();
            dateTimePicker1 = new DateTimePicker();
            btnXepLoai = new Button();
            btnTimKiem = new Button();
            cboXepLoai = new ComboBox();
            txtTimKiem = new TextBox();
            btnTop10 = new Button();
            txtTongSo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            SuspendLayout();
            // 
            // dgvKetQua
            // 
            dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQua.Location = new Point(585, 22);
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.RowHeadersWidth = 82;
            dgvKetQua.RowTemplate.Height = 41;
            dgvKetQua.Size = new Size(1119, 911);
            dgvKetQua.TabIndex = 0;
            dgvKetQua.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(110, 498);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(150, 46);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(110, 61);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 2;
            // 
            // btnXepLoai
            // 
            btnXepLoai.Location = new Point(110, 134);
            btnXepLoai.Name = "btnXepLoai";
            btnXepLoai.Size = new Size(186, 46);
            btnXepLoai.TabIndex = 3;
            btnXepLoai.Text = "Xếp loại theo:";
            btnXepLoai.UseVisualStyleBackColor = true;
            btnXepLoai.Click += btnXepLoai_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(110, 323);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 46);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cboXepLoai
            // 
            cboXepLoai.FormattingEnabled = true;
            cboXepLoai.Location = new Point(326, 134);
            cboXepLoai.Name = "cboXepLoai";
            cboXepLoai.Size = new Size(242, 40);
            cboXepLoai.TabIndex = 5;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(310, 323);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(200, 39);
            txtTimKiem.TabIndex = 6;
            // 
            // btnTop10
            // 
            btnTop10.Location = new Point(111, 407);
            btnTop10.Name = "btnTop10";
            btnTop10.Size = new Size(150, 46);
            btnTop10.TabIndex = 7;
            btnTop10.Text = "Top Điểm";
            btnTop10.UseVisualStyleBackColor = true;
            btnTop10.Click += btnTop10_Click;
            // 
            // txtTongSo
            // 
            txtTongSo.Location = new Point(111, 215);
            txtTongSo.Name = "txtTongSo";
            txtTongSo.Size = new Size(457, 39);
            txtTongSo.TabIndex = 8;
            // 
            // FrmKetQuaThi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1716, 984);
            Controls.Add(txtTongSo);
            Controls.Add(btnTop10);
            Controls.Add(txtTimKiem);
            Controls.Add(cboXepLoai);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXepLoai);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnLamMoi);
            Controls.Add(dgvKetQua);
            Margin = new Padding(5);
            Name = "FrmKetQuaThi";
            Text = "FrmKetQuaThi";
            Load += FrmKetQuaThi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKetQua;
        private Button btnLamMoi;
        private DateTimePicker dateTimePicker1;
        private Button btnXepLoai;
        private Button btnTimKiem;
        private ComboBox cboXepLoai;
        private TextBox txtTimKiem;
        private Button btnTop10;
        private TextBox txtTongSo;
    }
}