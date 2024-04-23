namespace QuanLyNhaHang
{
    partial class frmThongKeDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnMonBanChay = new System.Windows.Forms.Button();
            this.rbtnNgay = new System.Windows.Forms.RadioButton();
            this.rbtnThang = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.btnIn = new System.Windows.Forms.Button();
            this.dtgvDTMon = new System.Windows.Forms.DataGridView();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.chartCot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.numNam = new System.Windows.Forms.NumericUpDown();
            this.chkHoaDon = new System.Windows.Forms.CheckBox();
            this.chkBan = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDTMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(54, 272);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnMonBanChay
            // 
            this.btnMonBanChay.Location = new System.Drawing.Point(161, 272);
            this.btnMonBanChay.Name = "btnMonBanChay";
            this.btnMonBanChay.Size = new System.Drawing.Size(114, 23);
            this.btnMonBanChay.TabIndex = 1;
            this.btnMonBanChay.Text = "Món Bán Chạy";
            this.btnMonBanChay.UseVisualStyleBackColor = true;
            this.btnMonBanChay.Click += new System.EventHandler(this.btnMonBanChay_Click);
            // 
            // rbtnNgay
            // 
            this.rbtnNgay.AutoSize = true;
            this.rbtnNgay.Location = new System.Drawing.Point(54, 104);
            this.rbtnNgay.Name = "rbtnNgay";
            this.rbtnNgay.Size = new System.Drawing.Size(71, 20);
            this.rbtnNgay.TabIndex = 2;
            this.rbtnNgay.Text = "1 Ngày";
            this.rbtnNgay.UseVisualStyleBackColor = true;
            // 
            // rbtnThang
            // 
            this.rbtnThang.AutoSize = true;
            this.rbtnThang.Location = new System.Drawing.Point(54, 152);
            this.rbtnThang.Name = "rbtnThang";
            this.rbtnThang.Size = new System.Drawing.Size(67, 20);
            this.rbtnThang.TabIndex = 3;
            this.rbtnThang.Text = "Tháng";
            this.rbtnThang.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(54, 205);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(57, 20);
            this.rbtnNam.TabIndex = 4;
            this.rbtnNam.Text = "Năm";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(177, 336);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Visible = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // dtgvDTMon
            // 
            this.dtgvDTMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDTMon.Location = new System.Drawing.Point(466, 48);
            this.dtgvDTMon.Name = "dtgvDTMon";
            this.dtgvDTMon.RowHeadersWidth = 51;
            this.dtgvDTMon.RowTemplate.Height = 24;
            this.dtgvDTMon.Size = new System.Drawing.Size(666, 247);
            this.dtgvDTMon.TabIndex = 8;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Location = new System.Drawing.Point(463, 325);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(16, 16);
            this.lblDoanhThu.TabIndex = 9;
            this.lblDoanhThu.Text = "...";
            // 
            // chartCot
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCot.Legends.Add(legend1);
            this.chartCot.Location = new System.Drawing.Point(466, 366);
            this.chartCot.Name = "chartCot";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCot.Series.Add(series1);
            this.chartCot.Size = new System.Drawing.Size(666, 171);
            this.chartCot.TabIndex = 10;
            this.chartCot.Text = "chart1";
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(127, 152);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(111, 24);
            this.cboThang.TabIndex = 11;
            // 
            // numNam
            // 
            this.numNam.Location = new System.Drawing.Point(127, 205);
            this.numNam.Name = "numNam";
            this.numNam.Size = new System.Drawing.Size(111, 22);
            this.numNam.TabIndex = 12;
            // 
            // chkHoaDon
            // 
            this.chkHoaDon.AutoSize = true;
            this.chkHoaDon.Location = new System.Drawing.Point(54, 48);
            this.chkHoaDon.Name = "chkHoaDon";
            this.chkHoaDon.Size = new System.Drawing.Size(82, 20);
            this.chkHoaDon.TabIndex = 13;
            this.chkHoaDon.Text = "Hóa Đơn";
            this.chkHoaDon.UseVisualStyleBackColor = true;
            // 
            // chkBan
            // 
            this.chkBan.AutoSize = true;
            this.chkBan.Location = new System.Drawing.Point(199, 48);
            this.chkBan.Name = "chkBan";
            this.chkBan.Size = new System.Drawing.Size(53, 20);
            this.chkBan.TabIndex = 14;
            this.chkBan.Text = "Bàn";
            this.chkBan.UseVisualStyleBackColor = true;
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1185, 549);
            this.Controls.Add(this.chkBan);
            this.Controls.Add(this.chkHoaDon);
            this.Controls.Add(this.numNam);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.chartCot);
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.dtgvDTMon);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.rbtnNam);
            this.Controls.Add(this.rbtnThang);
            this.Controls.Add(this.rbtnNgay);
            this.Controls.Add(this.btnMonBanChay);
            this.Controls.Add(this.btnThongKe);
            this.Name = "frmThongKeDoanhThu";
            this.Text = "Thống Kê Doanh Thu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDTMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnMonBanChay;
        private System.Windows.Forms.RadioButton rbtnNgay;
        private System.Windows.Forms.RadioButton rbtnThang;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridView dtgvDTMon;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCot;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.NumericUpDown numNam;
        private System.Windows.Forms.CheckBox chkHoaDon;
        private System.Windows.Forms.CheckBox chkBan;
    }
}