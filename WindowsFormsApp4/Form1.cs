using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        bool memorySaveFlag = false;
        const string PATH = @"C:\calc\ms.txt"; 
        bool proverkaDot = false;
        bool flag = false; 
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
                case "%":
                    return a * b / 100;
                
                case "*":
                    return a * b;
                case "/":
                    if (b == 0)
                    {
                        MessageBox.Show("На 0 делить нельзя");
                        return 0;
                    }
                    return a / b;
                default:
                    return Convert.ToDouble(textBox1.Text);
            }
        }
        private void number1_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text[10] == '1') ;
            }
            catch
            {
                MessageBox.Show("Ошибка теста");
            }
           
           
            if (flag)
            {
                flag = false;
                textBox1.Clear();
            }
            textBox1.Text += "1";
        }

        private void number2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                textBox1.Clear();
            }
            textBox1.Text += "2";
        }

        private void number3_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                textBox1.Clear();
            }
            textBox1.Text += "3";
        }

        private void number4_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                textBox1.Clear();
            }
            textBox1.Text += "4";
        }

        private void number5_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                textBox1.Clear();
            }
            textBox1.Text += "5";
        }

        private void number6_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                textBox1.Clear();
            }
            textBox1.Text += "6";
        }

        private void number7_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                textBox1.Clear();
            }
            textBox1.Text += "7";
        }

        private void number8_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                textBox1.Clear();
            }
            textBox1.Text += "8";
        }

        private void number9_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                textBox1.Clear();
            }
            textBox1.Text += "9";
        }

        private void number0_Click(object sender, EventArgs e)
        {
            // если первый символ равен 0 а второй не равен Запятой 0 не ставим
            // если ни чего не стоит ставим 0
            // если первый символ равен 0 а второй символ запятоя то можно ставить 0
            // если стоит цифра ставим 0
            if (flag)
            {
                flag = false;
                textBox1.Clear();
            }
            
            if (textBox1.Text!="" && textBox1.Text[0] == '0' && textBox1.Text.Length == 1)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
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
            flag = true;
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
               if( textBox1.Text[i] == ',')
                {
                    proverkaDot = true;
                }
            }
            if (!proverkaDot)
            {
                if (flag)
                {
                    flag = false;
                    textBox1.Clear();
                }
                textBox1.Text += ",";
            }
        }
        

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            oper.Text = "";
            number.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void MemorySave_Click(object sender, EventArgs e)
        {
            string save = textBox1.Text;
            if (save != "")
            {
                memorySaveFlag = true;
                File.WriteAllText(PATH, save);
                Memory.Text = "M";
            }
        }

        private void MemoryRead_Click(object sender, EventArgs e)
        {
            if (memorySaveFlag)
            {
                textBox1.Text = File.ReadAllText(PATH);
            }
        }

        private void MemoryClear_Click(object sender, EventArgs e)
        {
            if (memorySaveFlag)
            {
                File.WriteAllText(PATH, "");
                Memory.Text = "";
            }
        }

        private void MemoryMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double minus;
                if (!memorySaveFlag)
                {
                    minus = 0 - Convert.ToDouble(textBox1.Text);
                }
                else
                {
                    minus = Convert.ToDouble(File.ReadAllText(PATH)) - Convert.ToDouble(textBox1.Text);
                }
                memorySaveFlag = true;
                File.WriteAllText(PATH, minus.ToString());
                textBox1.Text = minus.ToString();
                Memory.Text = "M-";
            }
        }

        private void MemoryPlus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double plus;
                if (!memorySaveFlag)
                {
                    plus = 0 + Convert.ToDouble(textBox1.Text);
                }
                else
                {
                    plus = Convert.ToDouble(File.ReadAllText(PATH)) + Convert.ToDouble(textBox1.Text);
                }
                memorySaveFlag = true;
                File.WriteAllText(PATH, plus.ToString());
                textBox1.Text = plus.ToString();
                if (textBox1.Text != "") Memory.Text = "M+";
            }
        }

        private void korenButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) < 0)
            {
                MessageBox.Show("Отрицательное нельзя");
            }
            else
            {
                textBox1.Text = Math.Sqrt(Convert.ToDouble(textBox1.Text)).ToString();
            }
        }

        private void procentButton_Click(object sender, EventArgs e)
        {
            number.Text = $"{Calculation()}";
            oper.Text = "%";
            textBox1.Clear();
            
            
        }
    }
}
