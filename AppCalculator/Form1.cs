using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculator
{
    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_selesai = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "7";
            }
            else
            {
                textDisplay.Text += "7";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(textDisplay.Text == "0")
            {
                textDisplay.Text = "1";
            }
            else
            {
                textDisplay.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "2";
            }
            else
            {
                textDisplay.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "3";
            }
            else
            {
                textDisplay.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "4";
            }
            else
            {
                textDisplay.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "5";
            }
            else
            {
                textDisplay.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "6";
            }
            else
            {
                textDisplay.Text += "6";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "8";
            }
            else
            {
                textDisplay.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "9";
            }
            else
            {
                textDisplay.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(textDisplay.Text != "0")
            {
                textDisplay.Text += "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            bil1 = 0;
            bil2 = 0;
            textDisplay2.Text = " ";
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textDisplay.Text);
            textDisplay2.Text = "x";
            textDisplay.Text = " ";
            opr = 1;
            opr_selesai = true;
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textDisplay.Text);
            textDisplay2.Text = "/";
            textDisplay.Text = " ";
            opr = 2;
            opr_selesai = true;
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textDisplay.Text);
            textDisplay2.Text = "-";
            textDisplay.Text = " ";
            opr = 3;
            opr_selesai = true;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textDisplay.Text);
            textDisplay2.Text = "+";
            textDisplay.Text = " ";
            opr = 4;
            opr_selesai = true;
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            if(opr_selesai == true)
                bil2 = Convert.ToDecimal(textDisplay.Text);
            {
                switch(opr)
                {
                    case 1:
                        textDisplay.Text = Convert.ToString(bil1 * bil2);
                        break;
                    case 2:
                        textDisplay.Text = Convert.ToString(bil1 / bil2);
                        break;
                    case 3:
                        textDisplay.Text = Convert.ToString(bil1 - bil2);
                        break;
                    case 4:
                        textDisplay.Text = Convert.ToString(bil1 + bil2);
                        break;
                }
                opr_selesai = false;
            }
        }
    }
}
