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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lblNgay = new Label();
            lblXinChao = new Label();
            button8 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(183, 164);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(637, 529);
            chart1.TabIndex = 9;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // FrmMainGV
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2190, 1154);
            Controls.Add(chart1);
            Controls.Add(lblNgay);
            Controls.Add(lblXinChao);
            Controls.Add(button8);
            Margin = new Padding(5);
            Name = "FrmMainGV";
            Text = "FrmMainGV";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNgay;
        private Label lblXinChao;
        private Button button8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}