namespace QuanLyTrungTam.FORM
{
    partial class LoginStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginStudent));
            btBack = new Button();
            label4 = new Label();
            btLoginHV = new Button();
            txtPassHV = new TextBox();
            txtUserHV = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btBack
            // 
            btBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btBack.Location = new Point(3, 201);
            btBack.Name = "btBack";
            btBack.Size = new Size(137, 47);
            btBack.TabIndex = 25;
            btBack.Text = "Quay lại chọn vai trò";
            btBack.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(308, 201);
            label4.Name = "label4";
            label4.Size = new Size(394, 47);
            label4.TabIndex = 24;
            label4.Text = "ĐĂNG NHẬP HỌC SINH";
            label4.Click += label4_Click;
            // 
            // btLoginHV
            // 
            btLoginHV.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btLoginHV.Location = new Point(421, 397);
            btLoginHV.Name = "btLoginHV";
            btLoginHV.Size = new Size(168, 60);
            btLoginHV.TabIndex = 23;
            btLoginHV.Text = "Đăng nhập";
            btLoginHV.UseVisualStyleBackColor = true;
            btLoginHV.MouseClick += btLoginHV_MouseClick_1;
            // 
            // txtPassHV
            // 
            txtPassHV.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassHV.Location = new Point(346, 336);
            txtPassHV.Name = "txtPassHV";
            txtPassHV.Size = new Size(431, 33);
            txtPassHV.TabIndex = 22;
            // 
            // txtUserHV
            // 
            txtUserHV.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserHV.Location = new Point(346, 286);
            txtUserHV.Name = "txtUserHV";
            txtUserHV.Size = new Size(431, 33);
            txtUserHV.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(161, 338);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 20;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(161, 291);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 19;
            label2.Text = "Tên đăng nhập:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1047, 286);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // LoginStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 490);
            Controls.Add(btBack);
            Controls.Add(label4);
            Controls.Add(btLoginHV);
            Controls.Add(txtPassHV);
            Controls.Add(txtUserHV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "LoginStudent";
            Text = "LoginStudent";
            Load += LoginStudent_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBack;
        private Label label4;
        private Button btLoginHV;
        private TextBox txtPassHV;
        private TextBox txtUserHV;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}