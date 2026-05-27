using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalFormCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != '+' && ch != '-' && ch != '*' && ch != '/' && ch != '.' && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
        }
        private void num9_Click(object sender, EventArgs e)
        {
            txtNum.Text += "9";
        }

        private void num9_hoverin(object sender, EventArgs e)
        {
            num9.FillColor = Color.DeepPink;
            num9.ForeColor = Color.LavenderBlush;
            num9.BorderColor = Color.Crimson;
        }

        private void num9_hoverout(object sender, EventArgs e)
        {
            num9.FillColor = Color.LavenderBlush;
            num9.ForeColor = Color.Maroon;
            num9.BorderColor = Color.Maroon;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            txtNum.Text += "8";
        }

        private void num8_hoverin(object sender, EventArgs e)
        {
            num8.FillColor = Color.DeepPink;
            num8.ForeColor = Color.LavenderBlush;
            num8.BorderColor = Color.Crimson;
        }

        private void num8_hoverout(object sender, EventArgs e)
        {
            num8.FillColor = Color.LavenderBlush;
            num8.ForeColor = Color.Maroon;
            num8.BorderColor = Color.Maroon;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            txtNum.Text += "7";
        }

        private void num7_hoverin(object sender, EventArgs e)
        {
            num7.FillColor = Color.DeepPink;
            num7.ForeColor = Color.LavenderBlush;
            num7.BorderColor = Color.Crimson;
        }

        private void num7_hoverout(object sender, EventArgs e)
        {
            num7.FillColor = Color.LavenderBlush;
            num7.ForeColor = Color.Maroon;
            num7.BorderColor = Color.Maroon;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            txtNum.Text += "6";
        }

        private void num6_hoverin(object sender, EventArgs e)
        {
            num6.FillColor = Color.DeepPink;
            num6.ForeColor = Color.LavenderBlush;
            num6.BorderColor = Color.Crimson;
        }

        private void num6_hoverout(object sender, EventArgs e)
        {
            num6.FillColor = Color.LavenderBlush;
            num6.ForeColor = Color.Maroon;
            num6.BorderColor = Color.Maroon;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            txtNum.Text += "5";
        }

        private void num5_hoverin(object sender, EventArgs e)
        {
            num5.FillColor = Color.DeepPink;
            num5.ForeColor = Color.LavenderBlush;
            num5.BorderColor = Color.Crimson;
        }

        private void num5_hoverout(object sender, EventArgs e)
        {
            num5.FillColor = Color.LavenderBlush;
            num5.ForeColor = Color.Maroon;
            num5.BorderColor = Color.Maroon;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            txtNum.Text += "4";
        }

        private void num4_hoverin(object sender, EventArgs e)
        {
            num4.FillColor = Color.DeepPink;
            num4.ForeColor = Color.LavenderBlush;
            num4.BorderColor = Color.Crimson;
        }

        private void num4_hoverout(object sender, EventArgs e)
        {
            num4.FillColor = Color.LavenderBlush;
            num4.ForeColor = Color.Maroon;
            num4.BorderColor = Color.Maroon;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            txtNum.Text += "3";
        }

        private void num3_hoverin(object sender, EventArgs e)
        {
            num3.FillColor = Color.DeepPink;
            num3.ForeColor = Color.LavenderBlush;
            num3.BorderColor = Color.Crimson;
        }

        private void num3_hoverout(object sender, EventArgs e)
        {
            num3.FillColor = Color.LavenderBlush;
            num3.ForeColor = Color.Maroon;
            num3.BorderColor = Color.Maroon;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            txtNum.Text += "2";
        }

        private void num2_hoverin(object sender, EventArgs e)
        {
            num2.FillColor = Color.DeepPink;
            num2.ForeColor = Color.LavenderBlush;
            num2.BorderColor = Color.Crimson;
        }

        private void num2_hoverout(object sender, EventArgs e)
        {
            num2.FillColor = Color.LavenderBlush;
            num2.ForeColor = Color.Maroon;
            num2.BorderColor = Color.Maroon;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            txtNum.Text += "0";
        }

        private void num0_hoverin(object sender, EventArgs e)
        {
            num0.FillColor = Color.DeepPink;
            num0.ForeColor = Color.LavenderBlush;
            num0.BorderColor = Color.Crimson;
        }

        private void num0_hoverout(object sender, EventArgs e)
        {
            num0.FillColor = Color.LavenderBlush;
            num0.ForeColor = Color.Maroon;
            num0.BorderColor = Color.Maroon;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            txtNum.Text += "1";
        }

        private void num1_hoverin(object sender, EventArgs e)
        {
            num1.FillColor = Color.DeepPink;
            num1.ForeColor = Color.LavenderBlush;
            num1.BorderColor = Color.Crimson;
        }

        private void num1_hoverout(object sender, EventArgs e)
        {
            num1.FillColor = Color.LavenderBlush;
            num1.ForeColor = Color.Maroon;
            num1.BorderColor = Color.Maroon;
        }

        private void num00_Click(object sender, EventArgs e)
        {
            txtNum.Text += "00";
        }

        private void num00_hoverin(object sender, EventArgs e)
        {
            num00.FillColor = Color.DeepPink;
            num00.ForeColor = Color.LavenderBlush;
            num00.BorderColor = Color.Crimson;
        }

        private void num00_hoverout(object sender, EventArgs e)
        {
            num00.FillColor = Color.LavenderBlush;
            num00.ForeColor = Color.Maroon;
            num00.BorderColor = Color.Maroon;
        }

        private void btnperiod_Click(object sender, EventArgs e)
        {
            string text = txtNum.Text;


            if (text.Length == 0 || IsLastCharOperator(text))
            {
                txtNum.Text += "0.";
            }
            else
            {

                string[] parts = text.Split('+', '-', '*', '/');
                string lastPart = parts[parts.Length - 1];

                if (!lastPart.Contains("."))
                {
                    txtNum.Text += ".";
                }
            }
        }

        private bool IsLastCharOperator(string input)
        {
            char lastChar = input[input.Length - 1];
            return "+-*/".Contains(lastChar);
        }

        private void btnperiod_hoverin(object sender, EventArgs e)
        {
            btnperiod.FillColor = Color.DeepPink;
            btnperiod.ForeColor = Color.LavenderBlush;
            btnperiod.BorderColor = Color.Crimson;
        }

        private void btnperiod_hoverout(object sender, EventArgs e)
        {
            btnperiod.FillColor = Color.LavenderBlush;
            btnperiod.ForeColor = Color.Maroon;
            btnperiod.BorderColor = Color.Maroon;
        }

        private void btnclear_hoverin(object sender, EventArgs e)
        {
            btnclear.FillColor = Color.DeepPink;
            btnclear.ForeColor = Color.LavenderBlush;
            btnclear.BorderColor = Color.Crimson;
        }

        private void btnclear_hoverout(object sender, EventArgs e)
        {
            btnclear.FillColor = Color.LavenderBlush;
            btnclear.ForeColor = Color.Maroon;
            btnclear.BorderColor = Color.Maroon;
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtNum.Text.Length > 0)
            {
                txtNum.Text = txtNum.Text.Substring(0, txtNum.Text.Length - 1);
            }
        }

        private void btndel_hoverin(object sender, EventArgs e)
        {
            btndel.FillColor = Color.Crimson;
            btndel.ForeColor = Color.LavenderBlush;
            btndel.BorderColor = Color.Crimson;
        }

        private void btndel_hoverout(object sender, EventArgs e)
        {
            btndel.FillColor = Color.LavenderBlush;
            btndel.ForeColor = Color.Crimson;
            btndel.BorderColor = Color.Crimson;
        }

        private void btnpercnt_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txtNum.Text;


                string[] parts = text.Split('+', '-', '*', '/');
                string lastNum = parts[parts.Length - 1];

                if (double.TryParse(lastNum, out double num))
                {
                    double percent = num / 100;


                    txtNum.Text = text.Substring(0, text.Length - lastNum.Length) + percent.ToString();
                }
            }
            catch
            {
                txtNum.Text = "Error";
            }
        }

        private void btnpercnt_hoverin(object sender, EventArgs e)
        {
            btnpercnt.FillColor= Color.DeepPink;
            btnpercnt.ForeColor = Color.LavenderBlush;
            btnpercnt.BorderColor = Color.Crimson;

        }

        private void btnpercnt_hoverout(object sender, EventArgs e)
        {
            btnpercnt.FillColor = Color.LavenderBlush;
            btnpercnt.ForeColor = Color.Maroon;
            btnpercnt.BorderColor = Color.Maroon;
        }

        private void divbtn_hoverin(object sender, EventArgs e)
        {
            divbtn.FillColor = Color.DeepPink;
            divbtn.ForeColor = Color.LavenderBlush;
            divbtn.BorderColor = Color.Crimson;
        }

        private void divbtn_hoverout(object sender, EventArgs e)
        {
            divbtn.FillColor = Color.LavenderBlush;
            divbtn.ForeColor = Color.Maroon;
            divbtn.BorderColor = Color.Maroon;
        }

        private void divbtn_Click(object sender, EventArgs e)
        {
            txtNum.Text += "/";
        }

        private void mulbtn_Click(object sender, EventArgs e)
        {
            txtNum.Text += "*";
        }

        private void mulbtn_hoverin(object sender, EventArgs e)
        {
            mulbtn.FillColor = Color.DeepPink;
            mulbtn.ForeColor = Color.LavenderBlush;
            mulbtn.BorderColor = Color.Crimson;
        }

        private void mulbtn_hoverout(object sender, EventArgs e)
        {
            mulbtn.FillColor = Color.LavenderBlush;
            mulbtn.ForeColor = Color.Maroon;
            mulbtn.BorderColor = Color.Maroon;
        }

        private void subbtn_hoverin(object sender, EventArgs e)
        {
            subbtn.FillColor = Color.DeepPink;
            subbtn.ForeColor = Color.LavenderBlush;
            subbtn.BorderColor = Color.Crimson;
        }

        private void subbtn_hoverout(object sender, EventArgs e)
        {
            subbtn.FillColor = Color.LavenderBlush;
            subbtn.ForeColor = Color.Maroon;
            subbtn.BorderColor = Color.Maroon;
        }

        private void subbtn_Click_1(object sender, EventArgs e)
        {
            txtNum.Text += "-";
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            txtNum.Text += "+";
        }

        private void addbtn_hoverin(object sender, EventArgs e)
        {
            addbtn.FillColor = Color.DeepPink;
            addbtn.ForeColor = Color.LavenderBlush;
            addbtn.BorderColor = Color.Crimson;
        }

        private void addbtn_hoverout(object sender, EventArgs e)
        {
            addbtn.FillColor = Color.LavenderBlush;
            addbtn.ForeColor = Color.Maroon;
            addbtn.BorderColor = Color.Maroon;
        }

        private void equalsbtn_Click(object sender, EventArgs e)
        {
            string expression = txtNum.Text;

            
            var result = new DataTable().Compute(expression, null);

            txtNum.Text = result.ToString();
        }

        private void equalsbtn_hoverin(object sender, EventArgs e)
        {
            equalsbtn.FillColor = Color.LavenderBlush;
            equalsbtn.ForeColor = Color.Crimson;
            equalsbtn.BorderColor = Color.Crimson;
        }

        private void equalsbtn_hoverout(object sender, EventArgs e)
        {
            equalsbtn.FillColor = Color.Crimson;
            equalsbtn.ForeColor = Color.LavenderBlush;
            equalsbtn.BorderColor = Color.LavenderBlush;
        }
    }
}