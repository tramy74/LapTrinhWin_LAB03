using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_TinhTongDaySo
{
    public partial class frmNhapDaySovaTinhTong : Form
    {
        List<int> _list = new List<int>();
        public frmNhapDaySovaTinhTong()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }





        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int nhapN;
            if (!int.TryParse(txtNhapSo.Text, out nhapN))
            {
                throw new Exception("Số không hợp lệ, vui lòng nhập số nguyên!!!");
                MessageBox.Show("Vui lòng nhập số", "LỖI!!!");
                return;
            }

            _list.Add(nhapN);
            txtNhapSo.Text = null;
            txtNhapSo.Focus();
            string result = "";
            foreach (var item in _list)
            {
                result = result + item.ToString() + " ";
            }
            txtDayVuaNhap.Text = result;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            int sum = 0;
            sum = _list.Sum();
            txtTongMang.Text = sum.ToString();

            int sumChan = 0;
            sumChan = _list.Where(x => x % 2 == 0).Sum();
            txtTongChan.Text = sumChan.ToString();

            int sumLe = 0;
            sumLe = _list.Where(x => x % 2 != 0).Sum();
            txtTongLe.Text = sumLe.ToString();
        }
    }
}
