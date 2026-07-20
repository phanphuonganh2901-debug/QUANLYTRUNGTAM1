namespace QuanLyTrungTam.FORM
{
    partial class LoginTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginTeacher));
            btBack = new Button();
            label4 = new Label();
            btLoginGV = new Button();
            txtPassGV = new TextBox();
            txtUserGV = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btBack
            // 
            btBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btBack.Location = new Point(1, 189);
            btBack.Name = "btBack";
            btBack.Size = new Size(137, 47);
            btBack.TabIndex = 17;
            btBack.Text = "Quay lại chọn vai trò";
            btBack.UseVisualStyleBackColor = true;
            btBack.MouseClick += btBack_MouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(306, 189);
            label4.Name = "label4";
            label4.Size = new Size(398, 47);
            label4.TabIndex = 16;
            label4.Text = "ĐĂNG NHẬP GIÁO VIÊN";
            label4.Click += label4_Click;
            // 
            // btLoginGV
            // 
            btLoginGV.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btLoginGV.Location = new Point(384, 385);
            btLoginGV.Name = "btLoginGV";
            btLoginGV.Size = new Size(168, 60);
            btLoginGV.TabIndex = 15;
            btLoginGV.Text = "Đăng nhập";
            btLoginGV.UseVisualStyleBackColor = true;
            btLoginGV.MouseClick += btLoginGV_MouseClick_1;
            // 
            // txtPassGV
            // 
            txtPassGV.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassGV.Location = new Point(310, 324);
            txtPassGV.Name = "txtPassGV";
            txtPassGV.Size = new Size(431, 33);
            txtPassGV.TabIndex = 14;
            // 
            // txtUserGV
            // 
            txtUserGV.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserGV.Location = new Point(310, 274);
            txtUserGV.Name = "txtUserGV";
            txtUserGV.Size = new Size(431, 33);
            txtUserGV.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(163, 332);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 12;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(163, 282);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 11;
            label2.Text = "Tên đăng nhập:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1034, 272);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // LoginTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 490);
            Controls.Add(btBack);
            Controls.Add(label4);
            Controls.Add(btLoginGV);
            Controls.Add(txtPassGV);
            Controls.Add(txtUserGV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "LoginTeacher";
            Text = "LoginTeacher";
            Load += LoginTeacher_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBack;
        private Label label4;
        private Button btLoginGV;
        private TextBox txtPassGV;
        private TextBox txtUserGV;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}