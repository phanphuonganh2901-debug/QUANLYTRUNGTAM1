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
            btLogin = new Button();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btBack
            // 
            btBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btBack.Location = new Point(1, 252);
            btBack.Margin = new Padding(3, 4, 3, 4);
            btBack.Name = "btBack";
            btBack.Size = new Size(157, 63);
            btBack.TabIndex = 17;
            btBack.Text = "Quay lại chọn vai trò";
            btBack.UseVisualStyleBackColor = true;
            btBack.MouseClick += btBack_MouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(350, 252);
            label4.Name = "label4";
            label4.Size = new Size(496, 60);
            label4.TabIndex = 16;
            label4.Text = "ĐĂNG NHẬP GIÁO VIÊN";
            label4.Click += label4_Click;
            // 
            // btLogin
            // 
            btLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btLogin.Location = new Point(439, 513);
            btLogin.Margin = new Padding(3, 4, 3, 4);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(192, 80);
            btLogin.TabIndex = 15;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(354, 432);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(492, 39);
            txtPass.TabIndex = 14;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(354, 365);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(492, 39);
            txtUser.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(186, 443);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 12;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(186, 376);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 11;
            label2.Text = "Tên đăng nhập:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -124);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1182, 362);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // LoginTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(btBack);
            Controls.Add(label4);
            Controls.Add(btLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginTeacher";
            Text = "LoginTeacher";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBack;
        private Label label4;
        private Button btLogin;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}