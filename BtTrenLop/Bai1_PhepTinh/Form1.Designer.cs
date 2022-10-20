namespace Pheptinh2
{
    partial class frmTinhToan
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
            this.btnChia = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtNhapB = new System.Windows.Forms.TextBox();
            this.txtNhapA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(498, 256);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(67, 48);
            this.btnChia.TabIndex = 29;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(409, 256);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(67, 48);
            this.btnNhan.TabIndex = 28;
            this.btnNhan.Text = "x";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(323, 256);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(67, 48);
            this.btnTru.TabIndex = 27;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(239, 256);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(67, 48);
            this.btnCong.TabIndex = 26;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(303, 199);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(262, 22);
            this.txtKetQua.TabIndex = 25;
            // 
            // txtNhapB
            // 
            this.txtNhapB.Location = new System.Drawing.Point(465, 146);
            this.txtNhapB.Name = "txtNhapB";
            this.txtNhapB.Size = new System.Drawing.Size(100, 22);
            this.txtNhapB.TabIndex = 24;
            this.txtNhapB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapB_KeyPress);
            // 
            // txtNhapA
            // 
            this.txtNhapA.Location = new System.Drawing.Point(303, 146);
            this.txtNhapA.Name = "txtNhapA";
            this.txtNhapA.Size = new System.Drawing.Size(100, 22);
            this.txtNhapA.TabIndex = 23;
            this.txtNhapA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapA_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kết quả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "b=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "a=";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTinhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtNhapB);
            this.Controls.Add(this.txtNhapA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTinhToan";
            this.Text = "CongTruNhanChia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTinhToan_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtNhapB;
        private System.Windows.Forms.TextBox txtNhapA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

