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
            btBack.Location = new Point(1, 244);
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
            label4.Location = new Point(306, 244);
            label4.Name = "label4";
            label4.Size = new Size(394, 47);
            label4.TabIndex = 24;
            label4.Text = "ĐĂNG NHẬP HỌC SINH";
            label4.Click += label4_Click;
            // 
            // btLogin
            // 
            btLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btLogin.Location = new Point(381, 441);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(168, 60);
            btLogin.TabIndex = 23;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(306, 380);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(431, 33);
            txtPass.TabIndex = 22;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(306, 330);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(431, 33);
            txtUser.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(159, 388);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 20;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(159, 338);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 19;
            label2.Text = "Tên đăng nhập:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1047, 370);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // LoginStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 517);
            Controls.Add(btBack);
            Controls.Add(label4);
            Controls.Add(btLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
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