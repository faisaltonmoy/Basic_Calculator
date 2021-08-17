using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        string Input = "";
        string first_val = "";
        string sec_val = "";
        char function;
        double result = 0.0;


        public Form1()
        {
            InitializeComponent();
        }

        private void num_1_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            Input += '1';
            Display.Text += Input;
        }

        private void num_2_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            Input += '2';
            Display.Text += Input;
        }

        private void num_3_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            Input += '3';
            Display.Text += Input;
        }

        private void num_4_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            Input += '4';
            Display.Text += Input;
        }

        private void num_5_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            Input += '5';
            Display.Text += Input;
        }

        private void num_6_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            Input += '6';
            Display.Text += Input;
        }

        private void num_7_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            Input += '7';
            Display.Text += Input;
        }

        private void num_8_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            Input += '8';
            Display.Text += Input;
        }

        private void num_9_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            Input += '9';
            Display.Text += Input;
        }

        private void num_0_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            Input += '0';
            Display.Text += Input;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            Input += '.';
            Display.Text += Input;
        }

        private void div_Click(object sender, EventArgs e)
        {
            function = '/';
            first_val = Input;
            Input = "";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            function = '*';
            first_val = Input;
            Input = "";
        }

        private void min_Click(object sender, EventArgs e)
        {
            function = '-';
            first_val = Input;
            Input = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            function = '+';
            first_val = Input;
            Input = "";
        }

        private void ac_Click(object sender, EventArgs e)
        {
            first_val = "";
            sec_val = "";
            Input = "";
            result = 0.0;
            Display.Text = "0";
        }

        private void res_Click(object sender, EventArgs e)
        {
            sec_val = Input;
            double firstNum, SecNum;
            firstNum = Convert.ToDouble(first_val);
            SecNum = Convert.ToDouble(sec_val);

            if(function == '+')
            {
                result = firstNum + SecNum;
                Display.Text = result.ToString();
            }
            else if(function == '-')
            {
                result = firstNum - SecNum;
                Display.Text = result.ToString();
            }
            else if (function == '*')
            {
                result = firstNum * SecNum;
                Display.Text = result.ToString();
            }
            else if (function == '/')
            {
                if(SecNum == '0')
                {
                    Display.Text = "Error";
                }
                else
                {
                    result = firstNum / SecNum;
                    Display.Text = result.ToString();
                }         
            }
            Input = "";
        }
    }
}
