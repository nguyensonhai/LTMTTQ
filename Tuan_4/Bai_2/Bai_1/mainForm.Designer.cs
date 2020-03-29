namespace Bai_1
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGallon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhienLieu = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình tính số nhiên liệu tiêu thụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số dặm đường";
            // 
            // txtDam
            // 
            this.txtDam.Location = new System.Drawing.Point(209, 86);
            this.txtDam.Name = "txtDam";
            this.txtDam.Size = new System.Drawing.Size(141, 20);
            this.txtDam.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gallon tiêu thụ";
            // 
            // txtGallon
            // 
            this.txtGallon.Location = new System.Drawing.Point(209, 131);
            this.txtGallon.Name = "txtGallon";
            this.txtGallon.Size = new System.Drawing.Size(141, 20);
            this.txtGallon.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số nhiên liệu";
            // 
            // txtNhienLieu
            // 
            this.txtNhienLieu.Location = new System.Drawing.Point(209, 184);
            this.txtNhienLieu.Name = "txtNhienLieu";
            this.txtNhienLieu.ReadOnly = true;
            this.txtNhienLieu.Size = new System.Drawing.Size(141, 20);
            this.txtNhienLieu.TabIndex = 3;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(209, 227);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(141, 23);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 280);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtNhienLieu);
            this.Controls.Add(this.txtGallon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.Text = "Chương trình tính số nhiên liệu tiêu thụ";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGallon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNhienLieu;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

