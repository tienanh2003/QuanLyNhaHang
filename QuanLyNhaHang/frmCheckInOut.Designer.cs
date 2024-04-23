namespace QuanLyNhaHang
{
    partial class frmCheckInOut
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
            this.radioButtonSang = new System.Windows.Forms.RadioButton();
            this.radioButtonTrua = new System.Windows.Forms.RadioButton();
            this.radioButtonToi = new System.Windows.Forms.RadioButton();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonSang
            // 
            this.radioButtonSang.AutoSize = true;
            this.radioButtonSang.Location = new System.Drawing.Point(55, 69);
            this.radioButtonSang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonSang.Name = "radioButtonSang";
            this.radioButtonSang.Size = new System.Drawing.Size(60, 20);
            this.radioButtonSang.TabIndex = 0;
            this.radioButtonSang.TabStop = true;
            this.radioButtonSang.Text = "Sáng";
            this.radioButtonSang.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrua
            // 
            this.radioButtonTrua.AutoSize = true;
            this.radioButtonTrua.Location = new System.Drawing.Point(55, 124);
            this.radioButtonTrua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonTrua.Name = "radioButtonTrua";
            this.radioButtonTrua.Size = new System.Drawing.Size(56, 20);
            this.radioButtonTrua.TabIndex = 1;
            this.radioButtonTrua.TabStop = true;
            this.radioButtonTrua.Text = "Trưa";
            this.radioButtonTrua.UseVisualStyleBackColor = true;
            // 
            // radioButtonToi
            // 
            this.radioButtonToi.AutoSize = true;
            this.radioButtonToi.Location = new System.Drawing.Point(55, 178);
            this.radioButtonToi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonToi.Name = "radioButtonToi";
            this.radioButtonToi.Size = new System.Drawing.Size(48, 20);
            this.radioButtonToi.TabIndex = 2;
            this.radioButtonToi.TabStop = true;
            this.radioButtonToi.Text = "Tối";
            this.radioButtonToi.UseVisualStyleBackColor = true;
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(195, 92);
            this.btnBatDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(75, 23);
            this.btnBatDau.TabIndex = 3;
            this.btnBatDau.Text = "Bắt Đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(195, 148);
            this.btnKetThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(75, 23);
            this.btnKetThuc.TabIndex = 4;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // frmCheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1192, 496);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.radioButtonToi);
            this.Controls.Add(this.radioButtonTrua);
            this.Controls.Add(this.radioButtonSang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCheckInOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In Out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonSang;
        private System.Windows.Forms.RadioButton radioButtonTrua;
        private System.Windows.Forms.RadioButton radioButtonToi;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnKetThuc;
    }
}