namespace QuanLyTrungTam.FORM
{
    partial class FrmMainHV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainHV));
            lblNgay = new Label();
            lblXinChao = new Label();
            button8 = new Button();
            SuspendLayout();
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNgay.Location = new Point(204, 64);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(241, 20);
            lblNgay.TabIndex = 8;
            lblNgay.Text = "Thứ bảy, ngày tháng năm để đây ";
            // 
            // lblXinChao
            // 
            lblXinChao.AutoSize = true;
            lblXinChao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblXinChao.Location = new Point(204, 19);
            lblXinChao.Name = "lblXinChao";
            lblXinChao.Size = new Size(234, 41);
            lblXinChao.TabIndex = 7;
            lblXinChao.Text = "Xin chào, Admin";
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(30, 12);
            button8.Name = "button8";
            button8.RightToLeft = RightToLeft.No;
            button8.Size = new Size(155, 69);
            button8.TabIndex = 6;
            button8.Text = "Canada English";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = true;
            // 
            // FrmMainHV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(lblNgay);
            Controls.Add(lblXinChao);
            Controls.Add(button8);
            Name = "FrmMainHV";
            Text = "FrmMainHV";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNgay;
        private Label lblXinChao;
        private Button button8;
    }
}