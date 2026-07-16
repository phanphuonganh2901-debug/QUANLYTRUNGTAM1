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
            btBack.Location = new Point(3, 268);
            btBack.Margin = new Padding(3, 4, 3, 4);
            btBack.Name = "btBack";
            btBack.Size = new Size(157, 63);
            btBack.TabIndex = 25;
            btBack.Text = "Quay lại chọn vai trò";
            btBack.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(352, 268);
            label4.Name = "label4";
            label4.Size = new Size(490, 60);
            label4.TabIndex = 24;
            label4.Text = "ĐĂNG NHẬP HỌC SINH";
            label4.Click += label4_Click;
            // 
            // btLogin
            // 
            btLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btLogin.Location = new Point(481, 529);
            btLogin.Margin = new Padding(3, 4, 3, 4);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(192, 80);
            btLogin.TabIndex = 23;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(396, 448);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(492, 39);
            txtPass.TabIndex = 22;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(396, 381);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(492, 39);
            txtUser.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(184, 451);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 20;
            label3.Text = "Mật khẩu:";
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(184, 388);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 19;
            label2.Text = "Tên đăng nhập:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -141);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1197, 382);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // LoginStudent
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
            Name = "LoginStudent";
            Text = "LoginStudent";
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