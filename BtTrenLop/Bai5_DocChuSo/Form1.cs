using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_DocChuSo
{
    public partial class frmDocChuSo : Form
    {
        public frmDocChuSo()
        {
            InitializeComponent();
        }

        private void frmDocChuSo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapSo.Clear();
            txtDocSo.Clear();
            txtNhapSo.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string Don_Vi(int n)
        {
            switch (n)
            {
                case 0: return "Không";
                case 1: return "Một";
                case 2: return "Hai";
                case 3: return "Ba";
                case 4: return "Bốn";
                case 5: return "Năm";
                case 6: return "Sáu";
                case 7: return "Bảy";
                case 8: return "Tám";
                default: return "Chín";
            }
        }

        private string HangChuc(int n)
        {
            switch (n)
            {
                case 0: return "Linh";
                case 1: return "Mười";
                case 2: return "Hai mươi";
                case 3: return "Ba mươi";
                case 4: return "Bốn mươi";
                case 5: return "Năm mươi";
                case 6: return "Sáu mươi";
                case 7: return "Bảy mươi";
                case 8: return "Tám mươi";
                default: return "Chín mươi";
            }
        }

        private string HangTram(int n)
        {
            switch (n)
            {
                case 0: return "Không trăm";
                case 1: return "Một trăm";
                case 2: return "Hai trăm";
                case 3: return "Ba trăm";
                case 4: return "Bốn trăm";
                case 5: return "Năm trăm";
                case 6: return "Sáu trăm";
                case 7: return "Bảy trăm";
                case 8: return "Tám trăm";
                default: return "Chín trăm";
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            string s, s1, s2, s3, k1, k2, k3;
            int dv, chuc, tram;
            s = txtNhapSo.Text;

            if (s.Length == 1)
            {
                k1 = s.Substring(s.Length - 1, 1);
                dv = int.Parse(k1);
                s1 = Don_Vi(dv);
                txtDocSo.Text = s1;
            }

            else if (s.Length == 2)
            {
                k1 = s.Substring(s.Length - 1, 1);
                k2 = s.Substring(s.Length - 2, 1);
                dv = int.Parse(k1);
                chuc = int.Parse(k2);
                s1 = Don_Vi(dv);
                s2 = HangChuc(chuc);
                txtDocSo.Text = s2 + " " + s1 + " ";
            }

            else if (s.Length == 3)
            {
                k1 = s.Substring(s.Length - 1, 1);
                k2 = s.Substring(s.Length - 2, 1);
                k3 = s.Substring(s.Length - 3, 1);
                dv = int.Parse(k1);
                chuc = int.Parse(k2);
                tram = int.Parse(k3);
                s1 = Don_Vi(dv);
                s2 = HangChuc(chuc);
                s3 = HangTram(tram);
                txtDocSo.Text = s3 + " " + s2 + " " + s1 + " ";
            }

            else
            {
                txtDocSo.Text = "Chua lap trinh toi!";
            }
        }
    }
}
