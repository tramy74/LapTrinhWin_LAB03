namespace Bai5_DocChuSo
{
    partial class frmDocChuSo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.txtDocSo = new System.Windows.Forms.TextBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(56, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đọc Số Thành Chữ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập dãy số : ( Từ 1 đến 999)";
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(289, 76);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(119, 28);
            this.txtNhapSo.TabIndex = 2;
            this.txtNhapSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapSo_KeyPress);
            // 
            // txtDocSo
            // 
            this.txtDocSo.Location = new System.Drawing.Point(16, 172);
            this.txtDocSo.Name = "txtDocSo";
            this.txtDocSo.ReadOnly = true;
            this.txtDocSo.Size = new System.Drawing.Size(392, 28);
            this.txtDocSo.TabIndex = 3;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(16, 123);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(99, 30);
            this.btnThucHien.TabIndex = 4;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(168, 123);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 30);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(309, 123);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 30);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDocChuSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 218);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.txtDocSo);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDocChuSo";
            this.Text = "Tâm Gà - Đọc Chữ Số";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDocChuSo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.TextBox txtDocSo;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}

