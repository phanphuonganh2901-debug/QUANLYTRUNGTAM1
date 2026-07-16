namespace QuanLyTrungTam.FORM
{
    partial class FrmLoginChoose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginChoose));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            btAd = new Button();
            btHV = new Button();
            btGV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -183);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1197, 493);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(345, 36);
            label1.Name = "label1";
            label1.Size = new Size(466, 62);
            label1.TabIndex = 2;
            label1.Text = "XIN CHÀO, BẠN LÀ ...";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btAd);
            panel1.Controls.Add(btHV);
            panel1.Controls.Add(btGV);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 312);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1098, 520);
            panel1.TabIndex = 6;
            // 
            // btAd
            // 
            btAd.AutoSize = true;
            btAd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btAd.Image = (Image)resources.GetObject("btAd.Image");
            btAd.Location = new Point(104, 177);
            btAd.Margin = new Padding(3, 4, 3, 4);
            btAd.Name = "btAd";
            btAd.RightToLeft = RightToLeft.No;
            btAd.Size = new Size(232, 313);
            btAd.TabIndex = 9;
            btAd.Text = "Admin";
            btAd.TextAlign = ContentAlignment.BottomCenter;
            btAd.TextImageRelation = TextImageRelation.ImageAboveText;
            btAd.UseVisualStyleBackColor = true;
            btAd.Click += btAd_Click;
            // 
            // btHV
            // 
            btHV.AutoSize = true;
            btHV.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btHV.Image = (Image)resources.GetObject("btHV.Image");
            btHV.Location = new Point(746, 177);
            btHV.Margin = new Padding(3, 4, 3, 4);
            btHV.Name = "btHV";
            btHV.RightToLeft = RightToLeft.No;
            btHV.Size = new Size(232, 313);
            btHV.TabIndex = 8;
            btHV.Text = "Học viên";
            btHV.TextAlign = ContentAlignment.BottomCenter;
            btHV.TextImageRelation = TextImageRelation.ImageAboveText;
            btHV.UseVisualStyleBackColor = true;
            // 
            // btGV
            // 
            btGV.AutoSize = true;
            btGV.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btGV.Image = (Image)resources.GetObject("btGV.Image");
            btGV.Location = new Point(430, 177);
            btGV.Margin = new Padding(3, 4, 3, 4);
            btGV.Name = "btGV";
            btGV.RightToLeft = RightToLeft.No;
            btGV.Size = new Size(232, 313);
            btGV.TabIndex = 7;
            btGV.Text = "Giáo viên";
            btGV.TextAlign = ContentAlignment.BottomCenter;
            btGV.TextImageRelation = TextImageRelation.ImageAboveText;
            btGV.UseVisualStyleBackColor = true;
            btGV.MouseClick += btGV_MouseClick;
            // 
            // FrmLoginChoose
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 503);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "FrmLoginChoose";
            Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Button btHV;
        private Button btGV;
        private Button btAd;
    }
}