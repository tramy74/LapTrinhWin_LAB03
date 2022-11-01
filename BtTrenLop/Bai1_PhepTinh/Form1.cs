using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pheptinh2
{
    public partial class frmTinhToan : Form
    {
        public frmTinhToan()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNhapA.Text);
            int b = int.Parse(txtNhapB.Text);
            int c;
            c = a + b;
            txtKetQua.Text = c.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNhapA.Text);
            int b = int.Parse(txtNhapB.Text);
            int c;
            c = a - b;
            txtKetQua.Text = c.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNhapA.Text);
            int b = int.Parse(txtNhapB.Text);
            int c;
            c = a * b;
            txtKetQua.Text = c.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNhapA.Text);
            double b = double.Parse(txtNhapB.Text);
            double c;
            if (b == 0)
            {
                MessageBox.Show("Gia tri cua b khong hop le. Yeu cau nhap lai b!!");
               // return;
               txtNhapB.Clear();
                
            }
            else
            {
                c = a / b;
                txtKetQua.Text = c.ToString();
            }
        }

        private void frmTinhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtNhapA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtNhapB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {
            txtKetQua.Enabled = false;
        }
    }
}
