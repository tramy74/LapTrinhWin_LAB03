using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Bai3_UocChungvsBoiSo
{
    public partial class frmUocChungBoiSo : Form
    {
        public frmUocChungBoiSo()
        {
            InitializeComponent();
        }

        static int GetGreatestCommonDivisor(int a, int b)
        {
            if (b == 0) return a;
            return GetGreatestCommonDivisor(b, a % b);
        }

        static int GetLeastCommonMultiple(int a, int b)
        {
            return (a * b) / GetGreatestCommonDivisor(a, b);
        }

        private void frmUocChungBoiSo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            int soA = int.Parse(txtNhapSoA.Text);
            int soB = int.Parse(txtNhapSoB.Text);
            int uCLN = GetGreatestCommonDivisor(soA, soB);
            int bCNN = GetLeastCommonMultiple(soA, soB);
            txtUCLN.Text = uCLN.ToString();
            txtBCNN.Text = bCNN.ToString();
        }

        private void txtNhapSoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtNhapSoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtNhapSoA.Clear();
            txtNhapSoB.Clear();
            txtUCLN.Clear();
            txtBCNN.Clear();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
