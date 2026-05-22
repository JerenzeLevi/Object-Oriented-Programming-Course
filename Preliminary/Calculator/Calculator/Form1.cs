using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private TextBox activeBox;
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeBox != null || activeBox == null)
                {
                    activeBox.Text += "1";
                }
               
            } catch (Exception ex)
            {
                MessageBox.Show("Select a box before entering a number!");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeBox != null || activeBox == null)
                {
                    activeBox.Text += "6";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a box before entering a number!");
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperator.Text = "+";
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);

                double sum = addition(num1, num2);

                lblResult.Text = sum.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show("Please ensure both numerator and denominatot has a number!");
            }
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperator.Text = "-";
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);

                double difference = subtraction(num1, num2);

                lblResult.Text = difference.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show("Please ensure both numerator and denominatot has a number!");
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperator.Text = "x";
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);

                double product = multiplication(num1, num2);

                lblResult.Text = product.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show("Please ensure both numerator and denominatot has a number!");
            }
                
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperator.Text = "÷";
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);

                double quotient = division(num1, num2);

                lblResult.Text = quotient.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show("Please ensure both numerator and denominatot has a number!");
            }
                
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeBox != null || activeBox == null)
                {
                    activeBox.Text += "2";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a box before entering a number!");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeBox != null || activeBox == null)
                {
                    activeBox.Text += "3";
                }
                
            } catch (Exception ex)
            {
                MessageBox.Show("Select a box before entering a number!");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeBox != null || activeBox == null)
                {
                    activeBox.Text += "4";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a box before entering a number!");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeBox != null || activeBox == null)
                {
                    activeBox.Text += "5";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a box before entering a number!");
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeBox != null || activeBox == null)
                {
                    activeBox.Text += "7";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a box before entering a number!");
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeBox != null || activeBox == null)
                {
                    activeBox.Text += "8";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a box before entering a number!");
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeBox != null || activeBox == null)
                {
                    activeBox.Text += "9";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a box before entering a number!");
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeBox != null || activeBox == null)
                {
                    activeBox.Text += "0";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a box before entering a number!");
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtNum1.Text = null;
            txtNum2.Text = null;
            lblOperator.Text = "";
            lblResult.Text = "Result";
        }

        public double addition(double num1, double num2)
        {
            return num1 + num2;
        }
        public double subtraction(double num1, double num2)
        {
            return num1 - num2;
        }
        public double multiplication(double num1, double num2)
        {
            return num1 * num2;
        }
        public double division(double num1, double num2)
        {
            return num1 / num2;
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNum1_MouseDown(object sender, MouseEventArgs e)
        {
            activeBox = txtNum1;
        }

        private void txtNum2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNum2_MouseDown(object sender, MouseEventArgs e)
        {
            activeBox = txtNum2;
        }

        private void txtNum1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
