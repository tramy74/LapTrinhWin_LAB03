namespace Bai4_TinhTongDaySo
{
    partial class frmNhapDaySovaTinhTong
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.txtTongMang = new System.Windows.Forms.TextBox();
            this.txtDayVuaNhap = new System.Windows.Forms.TextBox();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongLe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(274, 266);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(132, 36);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(104, 266);
            this.btnThucHien.Margin = new System.Windows.Forms.Padding(4);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(132, 36);
            this.btnThucHien.TabIndex = 24;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(334, 82);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(109, 28);
            this.btnNhap.TabIndex = 22;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtTongChan
            // 
            this.txtTongChan.Location = new System.Drawing.Point(181, 214);
            this.txtTongChan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.ReadOnly = true;
            this.txtTongChan.Size = new System.Drawing.Size(54, 28);
            this.txtTongChan.TabIndex = 21;
            // 
            // txtTongMang
            // 
            this.txtTongMang.Location = new System.Drawing.Point(334, 168);
            this.txtTongMang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongMang.Name = "txtTongMang";
            this.txtTongMang.ReadOnly = true;
            this.txtTongMang.Size = new System.Drawing.Size(108, 28);
            this.txtTongMang.TabIndex = 20;
            // 
            // txtDayVuaNhap
            // 
            this.txtDayVuaNhap.Location = new System.Drawing.Point(181, 125);
            this.txtDayVuaNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtDayVuaNhap.Name = "txtDayVuaNhap";
            this.txtDayVuaNhap.ReadOnly = true;
            this.txtDayVuaNhap.Size = new System.Drawing.Size(260, 28);
            this.txtDayVuaNhap.TabIndex = 19;
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(181, 82);
            this.txtNhapSo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(124, 28);
            this.txtNhapSo.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tổng chẵn : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tổng các phần tử trong dãy : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Dãy vừa nhập : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nhập số : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(62, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nhập Dãy Số và Tính Tổng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tổng lẻ : ";
            // 
            // txtTongLe
            // 
            this.txtTongLe.Location = new System.Drawing.Point(388, 210);
            this.txtTongLe.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.ReadOnly = true;
            this.txtTongLe.Size = new System.Drawing.Size(54, 28);
            this.txtTongLe.TabIndex = 28;
            // 
            // frmNhapDaySovaTinhTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 345);
            this.Controls.Add(this.txtTongLe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtTongChan);
            this.Controls.Add(this.txtTongMang);
            this.Controls.Add(this.txtDayVuaNhap);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapDaySovaTinhTong";
            this.Text = "Dãy số và Tính Tổng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.TextBox txtTongMang;
        private System.Windows.Forms.TextBox txtDayVuaNhap;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongLe;
    }
}

