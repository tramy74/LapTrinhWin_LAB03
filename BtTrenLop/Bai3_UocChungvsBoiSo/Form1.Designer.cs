namespace Bai3_UocChungvsBoiSo
{
    partial class frmUocChungBoiSo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhapSoA = new System.Windows.Forms.TextBox();
            this.txtNhapSoB = new System.Windows.Forms.TextBox();
            this.txtUCLN = new System.Windows.Forms.TextBox();
            this.txtBCNN = new System.Windows.Forms.TextBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ước Số Chung - Bội Số Chung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số a: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập số b: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ước số chung lớn nhất: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bội số chung lớn nhất: ";
            // 
            // txtNhapSoA
            // 
            this.txtNhapSoA.Location = new System.Drawing.Point(164, 100);
            this.txtNhapSoA.Name = "txtNhapSoA";
            this.txtNhapSoA.Size = new System.Drawing.Size(199, 28);
            this.txtNhapSoA.TabIndex = 5;
            this.txtNhapSoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapSoA_KeyPress);
            // 
            // txtNhapSoB
            // 
            this.txtNhapSoB.Location = new System.Drawing.Point(164, 134);
            this.txtNhapSoB.Name = "txtNhapSoB";
            this.txtNhapSoB.Size = new System.Drawing.Size(199, 28);
            this.txtNhapSoB.TabIndex = 6;
            this.txtNhapSoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapSoB_KeyPress);
            // 
            // txtUCLN
            // 
            this.txtUCLN.Location = new System.Drawing.Point(242, 168);
            this.txtUCLN.Multiline = true;
            this.txtUCLN.Name = "txtUCLN";
            this.txtUCLN.Size = new System.Drawing.Size(59, 37);
            this.txtUCLN.TabIndex = 7;
            // 
            // txtBCNN
            // 
            this.txtBCNN.Location = new System.Drawing.Point(242, 211);
            this.txtBCNN.Multiline = true;
            this.txtBCNN.Name = "txtBCNN";
            this.txtBCNN.Size = new System.Drawing.Size(59, 37);
            this.txtBCNN.TabIndex = 8;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(55, 281);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(130, 35);
            this.btnThucHien.TabIndex = 9;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(233, 281);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(130, 35);
            this.btnTiepTuc.TabIndex = 10;
            this.btnTiepTuc.Text = "Tiếp Tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(407, 281);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 35);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frmUocChungBoiSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 352);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.txtBCNN);
            this.Controls.Add(this.txtUCLN);
            this.Controls.Add(this.txtNhapSoB);
            this.Controls.Add(this.txtNhapSoA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUocChungBoiSo";
            this.Text = "Ước chung- Bội số";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUocChungBoiSo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNhapSoA;
        private System.Windows.Forms.TextBox txtNhapSoB;
        private System.Windows.Forms.TextBox txtUCLN;
        private System.Windows.Forms.TextBox txtBCNN;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

