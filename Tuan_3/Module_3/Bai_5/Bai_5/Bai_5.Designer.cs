namespace Bai_5
{
    partial class Bai_5
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
            this.gbTTN = new System.Windows.Forms.GroupBox();
            this.gbTTTK = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBanMoi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTB = new System.Windows.Forms.TextBox();
            this.gbTTN.SuspendLayout();
            this.gbTTTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTTN
            // 
            this.gbTTN.Controls.Add(this.button3);
            this.gbTTN.Controls.Add(this.button2);
            this.gbTTN.Controls.Add(this.btnBanMoi);
            this.gbTTN.Controls.Add(this.txtThanhTien);
            this.gbTTN.Controls.Add(this.label3);
            this.gbTTN.Controls.Add(this.txtDonGia);
            this.gbTTN.Controls.Add(this.label2);
            this.gbTTN.Controls.Add(this.txtSoLuong);
            this.gbTTN.Controls.Add(this.label1);
            this.gbTTN.Location = new System.Drawing.Point(13, 13);
            this.gbTTN.Name = "gbTTN";
            this.gbTTN.Size = new System.Drawing.Size(416, 177);
            this.gbTTN.TabIndex = 0;
            this.gbTTN.TabStop = false;
            this.gbTTN.Text = "Thông Tin Nhập";
            // 
            // gbTTTK
            // 
            this.gbTTTK.Controls.Add(this.txtTongTien);
            this.gbTTTK.Controls.Add(this.label4);
            this.gbTTTK.Controls.Add(this.txtTongSL);
            this.gbTTTK.Controls.Add(this.txtTB);
            this.gbTTTK.Controls.Add(this.label5);
            this.gbTTTK.Controls.Add(this.label6);
            this.gbTTTK.Location = new System.Drawing.Point(13, 196);
            this.gbTTTK.Name = "gbTTTK";
            this.gbTTTK.Size = new System.Drawing.Size(416, 177);
            this.gbTTTK.TabIndex = 1;
            this.gbTTTK.TabStop = false;
            this.gbTTTK.Text = "Thông Tin Thống Kê";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(95, 20);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(158, 20);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(95, 65);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(158, 20);
            this.txtDonGia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn giá";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(95, 113);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(158, 20);
            this.txtThanhTien.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thành tiền";
            // 
            // btnBanMoi
            // 
            this.btnBanMoi.Location = new System.Drawing.Point(300, 16);
            this.btnBanMoi.Name = "btnBanMoi";
            this.btnBanMoi.Size = new System.Drawing.Size(75, 23);
            this.btnBanMoi.TabIndex = 6;
            this.btnBanMoi.Text = "Bàn mới";
            this.btnBanMoi.UseVisualStyleBackColor = true;
            this.btnBanMoi.Click += new System.EventHandler(this.btnBanMoi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Tính";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng SL";
            // 
            // txtTongSL
            // 
            this.txtTongSL.Location = new System.Drawing.Point(95, 38);
            this.txtTongSL.Name = "txtTongSL";
            this.txtTongSL.ReadOnly = true;
            this.txtTongSL.Size = new System.Drawing.Size(158, 20);
            this.txtTongSL.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(95, 83);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(158, 20);
            this.txtTongTien.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Trung bình/lần";
            // 
            // txtTB
            // 
            this.txtTB.Location = new System.Drawing.Point(95, 131);
            this.txtTB.Name = "txtTB";
            this.txtTB.ReadOnly = true;
            this.txtTB.Size = new System.Drawing.Size(158, 20);
            this.txtTB.TabIndex = 5;
            // 
            // Bai_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 387);
            this.Controls.Add(this.gbTTTK);
            this.Controls.Add(this.gbTTN);
            this.Name = "Bai_5";
            this.Text = "CHƯƠNG TRÌNH BÁN HÀNG";
            this.gbTTN.ResumeLayout(false);
            this.gbTTN.PerformLayout();
            this.gbTTTK.ResumeLayout(false);
            this.gbTTTK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTTN;
        private System.Windows.Forms.GroupBox gbTTTK;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBanMoi;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongSL;
        private System.Windows.Forms.TextBox txtTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

