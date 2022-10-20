using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmMayTinh : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;

        public frmMayTinh()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtHienThi.Text == "0") || (enter_value))
                txtHienThi.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            txtHienThi.Text = txtHienThi.Text + num.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtHienThi.Text);
            txtHienThi.Text = "";
            lblHienThi.Text = System.Convert.ToString(results) + " " + operation;
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = "";
            switch (operation)
            {
                case "+":
                    txtHienThi.Text = (results + Double.Parse(txtHienThi.Text)).ToString();
                    break;
                case "-":
                    txtHienThi.Text = (results - Double.Parse(txtHienThi.Text)).ToString();
                    break;
                case "*":
                    txtHienThi.Text = (results * Double.Parse(txtHienThi.Text)).ToString();
                    break;
                case "/":
                    txtHienThi.Text = (results / Double.Parse(txtHienThi.Text)).ToString();
                    break;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = "0";
            lblHienThi.Text = "";
        }
    }
}
