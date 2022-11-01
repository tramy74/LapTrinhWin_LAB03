using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Bai3_DangKyTaiKhoan
{
    public partial class Form1 : Form
    {
        public static bool IsEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(strRegex);

            return regex.IsMatch(email);
        }

        public Form1()
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

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Bạn phải nhập tên đăng nhập");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Length == 0 || txtDiaChiEmail.Text.Length == 0 || txtMatKhau.Text.Length == 0 || txtXacNhanMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Mời bạn nhập đầy đủ các ô!!");
            }

            else
            {
                string Ten = txtTen.Text;
                string email = txtDiaChiEmail.Text;
                string matKhau = txtMatKhau.Text;
                string xacNhanMK = txtXacNhanMatKhau.Text;
                if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
                {
                    MessageBox.Show("Mật khẩu không giống nhau!!!");
                    txtXacNhanMatKhau.Focus();
                }
                DialogResult r;
                r = MessageBox.Show("Bạn có muốn đăng kí không?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    MessageBox.Show($"Tên đăng nhập: {Ten}\nEmail:{email}");
                }
            }
        }

        private void txtDiaChiEmail_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (IsEmail(txtDiaChiEmail.Text) == false)
            {
                errorProvider1.SetError(ctr, "Sai định dạng email!!!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtDiaChiEmail_Leave(object sender, EventArgs e)
        {
            if (IsEmail(txtDiaChiEmail.Text) == false)
            {
                MessageBox.Show("Nhập lại email!!!");
                //
                //txtDiaChiEmail.Focus();
                return;
            }
            // else
        }
    }
}
