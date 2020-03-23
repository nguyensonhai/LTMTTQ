namespace Bai_4
{
    partial class Bai_4
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
            this.grGPTB1 = new System.Windows.Forms.GroupBox();
            this.btnTiepTuc1 = new System.Windows.Forms.Button();
            this.btnTimNghiem = new System.Windows.Forms.Button();
            this.txtNghiem = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grGPTB2 = new System.Windows.Forms.GroupBox();
            this.btnTiepTuc2 = new System.Windows.Forms.Button();
            this.btnTimNghiemPTB2 = new System.Windows.Forms.Button();
            this.txtNghiemPTB2 = new System.Windows.Forms.TextBox();
            this.txtHSB = new System.Windows.Forms.TextBox();
            this.txtHSC = new System.Windows.Forms.TextBox();
            this.txtHSA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grGPTB1.SuspendLayout();
            this.grGPTB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grGPTB1
            // 
            this.grGPTB1.Controls.Add(this.btnTiepTuc1);
            this.grGPTB1.Controls.Add(this.btnTimNghiem);
            this.grGPTB1.Controls.Add(this.txtNghiem);
            this.grGPTB1.Controls.Add(this.txtB);
            this.grGPTB1.Controls.Add(this.txtA);
            this.grGPTB1.Controls.Add(this.label3);
            this.grGPTB1.Controls.Add(this.label2);
            this.grGPTB1.Controls.Add(this.label1);
            this.grGPTB1.Location = new System.Drawing.Point(12, 12);
            this.grGPTB1.Name = "grGPTB1";
            this.grGPTB1.Size = new System.Drawing.Size(313, 202);
            this.grGPTB1.TabIndex = 0;
            this.grGPTB1.TabStop = false;
            this.grGPTB1.Text = "Giải Phương Tình Bậc 1";
            // 
            // btnTiepTuc1
            // 
            this.btnTiepTuc1.Location = new System.Drawing.Point(141, 157);
            this.btnTiepTuc1.Name = "btnTiepTuc1";
            this.btnTiepTuc1.Size = new System.Drawing.Size(75, 23);
            this.btnTiepTuc1.TabIndex = 7;
            this.btnTiepTuc1.Text = "Tiếp tục";
            this.btnTiepTuc1.UseVisualStyleBackColor = true;
            this.btnTiepTuc1.Click += new System.EventHandler(this.btnTiepTucB1_Click);
            // 
            // btnTimNghiem
            // 
            this.btnTimNghiem.Location = new System.Drawing.Point(141, 101);
            this.btnTimNghiem.Name = "btnTimNghiem";
            this.btnTimNghiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimNghiem.TabIndex = 6;
            this.btnTimNghiem.Text = "Tìm Nghiệm";
            this.btnTimNghiem.UseVisualStyleBackColor = true;
            this.btnTimNghiem.Click += new System.EventHandler(this.btnTimNghiem_Click);
            // 
            // txtNghiem
            // 
            this.txtNghiem.Location = new System.Drawing.Point(74, 131);
            this.txtNghiem.Name = "txtNghiem";
            this.txtNghiem.ReadOnly = true;
            this.txtNghiem.Size = new System.Drawing.Size(212, 20);
            this.txtNghiem.TabIndex = 5;
            this.txtNghiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(74, 72);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(212, 20);
            this.txtB.TabIndex = 4;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(74, 45);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(212, 20);
            this.txtA.TabIndex = 3;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nghiệm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hệ số b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ số a";
            // 
            // grGPTB2
            // 
            this.grGPTB2.Controls.Add(this.btnTiepTuc2);
            this.grGPTB2.Controls.Add(this.btnTimNghiemPTB2);
            this.grGPTB2.Controls.Add(this.txtNghiemPTB2);
            this.grGPTB2.Controls.Add(this.txtHSB);
            this.grGPTB2.Controls.Add(this.txtHSC);
            this.grGPTB2.Controls.Add(this.txtHSA);
            this.grGPTB2.Controls.Add(this.label7);
            this.grGPTB2.Controls.Add(this.label4);
            this.grGPTB2.Controls.Add(this.label5);
            this.grGPTB2.Controls.Add(this.label6);
            this.grGPTB2.Location = new System.Drawing.Point(334, 12);
            this.grGPTB2.Name = "grGPTB2";
            this.grGPTB2.Size = new System.Drawing.Size(313, 212);
            this.grGPTB2.TabIndex = 0;
            this.grGPTB2.TabStop = false;
            this.grGPTB2.Text = "Giải Phương Tình Bậc 2";
            // 
            // btnTiepTuc2
            // 
            this.btnTiepTuc2.Location = new System.Drawing.Point(143, 179);
            this.btnTiepTuc2.Name = "btnTiepTuc2";
            this.btnTiepTuc2.Size = new System.Drawing.Size(75, 23);
            this.btnTiepTuc2.TabIndex = 7;
            this.btnTiepTuc2.Text = "Tiếp tục";
            this.btnTiepTuc2.UseVisualStyleBackColor = true;
            this.btnTiepTuc2.Click += new System.EventHandler(this.btnTiepTucB2_Click);
            // 
            // btnTimNghiemPTB2
            // 
            this.btnTimNghiemPTB2.Location = new System.Drawing.Point(143, 124);
            this.btnTimNghiemPTB2.Name = "btnTimNghiemPTB2";
            this.btnTimNghiemPTB2.Size = new System.Drawing.Size(75, 23);
            this.btnTimNghiemPTB2.TabIndex = 6;
            this.btnTimNghiemPTB2.Text = "Tìm Nghiệm";
            this.btnTimNghiemPTB2.UseVisualStyleBackColor = true;
            this.btnTimNghiemPTB2.Click += new System.EventHandler(this.btnTimNghiemPTB2_Click);
            // 
            // txtNghiemPTB2
            // 
            this.txtNghiemPTB2.Location = new System.Drawing.Point(74, 153);
            this.txtNghiemPTB2.Name = "txtNghiemPTB2";
            this.txtNghiemPTB2.ReadOnly = true;
            this.txtNghiemPTB2.Size = new System.Drawing.Size(212, 20);
            this.txtNghiemPTB2.TabIndex = 5;
            this.txtNghiemPTB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHSB
            // 
            this.txtHSB.Location = new System.Drawing.Point(74, 72);
            this.txtHSB.Name = "txtHSB";
            this.txtHSB.Size = new System.Drawing.Size(212, 20);
            this.txtHSB.TabIndex = 4;
            this.txtHSB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHSB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtHSC
            // 
            this.txtHSC.Location = new System.Drawing.Point(74, 98);
            this.txtHSC.Name = "txtHSC";
            this.txtHSC.Size = new System.Drawing.Size(212, 20);
            this.txtHSC.TabIndex = 4;
            this.txtHSC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHSC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtHSA
            // 
            this.txtHSA.Location = new System.Drawing.Point(74, 45);
            this.txtHSA.Name = "txtHSA";
            this.txtHSA.Size = new System.Drawing.Size(212, 20);
            this.txtHSA.TabIndex = 3;
            this.txtHSA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHSA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hệ số c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nghiệm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hệ số b";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hệ số a";
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(572, 230);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Bai_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(669, 264);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grGPTB2);
            this.Controls.Add(this.grGPTB1);
            this.KeyPreview = true;
            this.Name = "Bai_4";
            this.Text = "PTBN - PTBH";
            this.grGPTB1.ResumeLayout(false);
            this.grGPTB1.PerformLayout();
            this.grGPTB2.ResumeLayout(false);
            this.grGPTB2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grGPTB1;
        private System.Windows.Forms.Button btnTimNghiem;
        private System.Windows.Forms.TextBox txtNghiem;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grGPTB2;
        private System.Windows.Forms.Button btnTimNghiemPTB2;
        private System.Windows.Forms.TextBox txtNghiemPTB2;
        private System.Windows.Forms.TextBox txtHSB;
        private System.Windows.Forms.TextBox txtHSC;
        private System.Windows.Forms.TextBox txtHSA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTiepTuc1;
        private System.Windows.Forms.Button btnTiepTuc2;
    }
}

