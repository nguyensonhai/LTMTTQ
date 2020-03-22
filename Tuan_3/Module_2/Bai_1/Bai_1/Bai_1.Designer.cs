namespace Bai_1
{
    partial class Bai_1
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
            this.lblPW = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtHienThi = new System.Windows.Forms.TextBox();
            this.lblHT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(12, 23);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(85, 13);
            this.lblPW.TabIndex = 0;
            this.lblPW.Text = "Nhập Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(111, 23);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(231, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(15, 134);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 23);
            this.btnHienThi.TabIndex = 2;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(144, 134);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(75, 23);
            this.btnTiep.TabIndex = 3;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(267, 134);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtHienThi
            // 
            this.txtHienThi.Location = new System.Drawing.Point(111, 71);
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.ReadOnly = true;
            this.txtHienThi.Size = new System.Drawing.Size(231, 20);
            this.txtHienThi.TabIndex = 6;
            this.txtHienThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHT
            // 
            this.lblHT.AutoSize = true;
            this.lblHT.Location = new System.Drawing.Point(12, 71);
            this.lblHT.Name = "lblHT";
            this.lblHT.Size = new System.Drawing.Size(46, 13);
            this.lblHT.TabIndex = 5;
            this.lblHT.Text = "Hiển thị:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 174);
            this.Controls.Add(this.txtHienThi);
            this.Controls.Add(this.lblHT);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPW);
            this.Name = "mainForm";
            this.Text = "Sử Dụng Label & TextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtHienThi;
        private System.Windows.Forms.Label lblHT;
    }
}

