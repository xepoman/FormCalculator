using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double Calculation()
        {
            double a = 0;
            double b = 0;
             if (number.Text != "" && textBox1.Text != "")
            {
                a = Convert.ToDouble(number.Text);
                b = Convert.ToDouble(textBox1.Text);
            }

            switch (oper.Text)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                default:
                    return Convert.ToDouble(textBox1.Text);
            }
        }
        private void number1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void number2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void number3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void number4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void number5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void number6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void number7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void number8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void number9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void number0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            number.Text = $"{Calculation()}";
            oper.Text = "-";
            textBox1.Clear();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            number.Text = $"{Calculation()}";
            oper.Text = "+";
            textBox1.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            number.Text = $"{Calculation()}";
            oper.Text = "/";
            textBox1.Clear();
        }

        private void umnogenieButton_Click(object sender, EventArgs e)
        {
            number.Text = $"{Calculation()}";
            oper.Text = "*";
            textBox1.Clear();
        }

        private void ravno_Click(object sender, EventArgs e)
        {
           textBox1.Text = $"{Calculation()}";
            oper.Text = "";
            number.Text = "";
        }

        private void dotButton_Click(object sender, EventArgs e)
        {

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            oper.Text = "";
            number.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
