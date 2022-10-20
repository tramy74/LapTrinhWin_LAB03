namespace Bai1
{
    partial class frmMayTinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHienThi = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnBang = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Máy Tính Bỏ Túi";
            // 
            // txtHienThi
            // 
            this.txtHienThi.Location = new System.Drawing.Point(12, 47);
            this.txtHienThi.Multiline = true;
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.Size = new System.Drawing.Size(226, 60);
            this.txtHienThi.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 113);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(52, 36);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(70, 155);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(52, 36);
            this.btn6.TabIndex = 3;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.button_Click);
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(12, 239);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(52, 36);
            this.btnCong.TabIndex = 5;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(70, 239);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(52, 36);
            this.btnTru.TabIndex = 9;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(128, 155);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(52, 36);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(70, 113);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(52, 36);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(128, 239);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(52, 36);
            this.btnNhan.TabIndex = 13;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnBang
            // 
            this.btnBang.Location = new System.Drawing.Point(128, 197);
            this.btnBang.Name = "btnBang";
            this.btnBang.Size = new System.Drawing.Size(52, 36);
            this.btnBang.TabIndex = 12;
            this.btnBang.Text = "=";
            this.btnBang.UseVisualStyleBackColor = true;
            this.btnBang.Click += new System.EventHandler(this.btnBang_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(186, 155);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(52, 36);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(128, 113);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(52, 36);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(186, 239);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(52, 36);
            this.btnChia.TabIndex = 17;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(186, 197);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(52, 36);
            this.btnC.TabIndex = 16;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(12, 197);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(52, 36);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.button_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(186, 113);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(52, 36);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(70, 197);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(52, 36);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(12, 155);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(52, 36);
            this.btn5.TabIndex = 18;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button_Click);
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Location = new System.Drawing.Point(28, 50);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(0, 20);
            this.lblHienThi.TabIndex = 20;
            // 
            // frmMayTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 452);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnBang);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtHienThi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMayTinh";
            this.Text = "Máy tính bỏ túi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHienThi;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnBang;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Label lblHienThi;
    }
}

