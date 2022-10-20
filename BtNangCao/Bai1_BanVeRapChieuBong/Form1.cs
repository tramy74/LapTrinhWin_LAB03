using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_BanVeRapChieuBong
{
    public partial class frmBanVe : Form
    {
        List<Button> DanhSachChon = new List<Button>();
        int intThanhTien = 0;

        private string phepToan;
        public frmBanVe()
        {
            InitializeComponent();
            txtThanhTien.Enabled = false;
        }

        private void frmBanVe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            foreach (Button b in DanhSachChon)
            {
                b.BackColor = Color.White;
            }
            txtThanhTien.Text = "";
            DanhSachChon = new List<Button>();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }

                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Add(btn);
                }
            }

            else
            {
                MessageBox.Show("Co nguoi ngoi roi!!!");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }

                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Add(btn);
                }
            }

            else
            {
                MessageBox.Show("Co nguoi ngoi roi!!!");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }

                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Add(btn);
                }
            }

            else
            {
                MessageBox.Show("Co nguoi ngoi roi!!!");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }

                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Add(btn);
                }
            }

            else
            {
                MessageBox.Show("Co nguoi ngoi roi!!!");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }

                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Add(btn);
                }
            }

            else
            {
                MessageBox.Show("Co nguoi ngoi roi!!!");
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }

                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Add(btn);
                }
            }

            else
            {
                MessageBox.Show("Co nguoi ngoi roi!!!");
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }

                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Add(btn);
                }
            }

            else
            {
                MessageBox.Show("Co nguoi ngoi roi!!!");
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }

                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Add(btn);
                }
            }

            else
            {
                MessageBox.Show("Co nguoi ngoi roi!!!");
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }

                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Add(btn);
                }
            }

            else
            {
                MessageBox.Show("Co nguoi ngoi roi!!!");
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }

                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Add(btn);
                }
            }

            else
            {
                MessageBox.Show("Co nguoi ngoi roi!!!");
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }

                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Add(btn);
                }
            }

            else
            {
                MessageBox.Show("Co nguoi ngoi roi!!!");
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }

                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Add(btn);
                }
            }

            else
            {
                MessageBox.Show("Co nguoi ngoi roi!!!");
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }

                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Add(btn);
                }
            }

            else
            {
                MessageBox.Show("Co nguoi ngoi roi!!!");
            }
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }

                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Add(btn);
                }
            }

            else
            {
                MessageBox.Show("Co nguoi ngoi roi!!!");
            }
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }

                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Add(btn);
                }
            }

            else
            {
                MessageBox.Show("Co nguoi ngoi roi!!!");
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            foreach (Button b in DanhSachChon)
            {
                int a = int.Parse(b.Text);
                if (a <= 5)
                {
                    b.BackColor = Color.Yellow;
                    intThanhTien += 1000;
                }
                if (6 < a && a <= 10)
                {
                    b.BackColor = Color.Yellow;
                    intThanhTien += 1500;
                }
                if (10 < a && a <= 15)
                {
                    b.BackColor = Color.Yellow;
                    intThanhTien += 2000;
                }
            }
            txtThanhTien.Text = intThanhTien.ToString();
            intThanhTien = 0;
            DanhSachChon = new List<Button>();

        }
    }
}
