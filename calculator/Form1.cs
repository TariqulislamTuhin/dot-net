using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double firstInput, secondInput = 0;
        private string operand;

        double result;

        private void sevenButton_click(object sender, EventArgs e)
        {
            setValue("7");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            setValue("8");
        }

        private void twoButton_Click_1(object sender, EventArgs e)
        {
            setValue("2");
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            setValue("1");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            setValue("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            setValue("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            setValue("5");
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            setValue("6");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            setValue("9");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            handleOperation("AC");
        }

        private void plsuButton_Click(object sender, EventArgs e)
        {
            handleOperation("p");
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            handleOperation("s");
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            handleOperation("m");
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            handleOperation("d");
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            handleOperation("=");
        }

        private void setValue(string value)
        {
            displayBox.Text += value;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (displayBox.Text != "0" && !String.IsNullOrEmpty(displayBox.Text))
            {
                setValue("0");
            }
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            setValue(".");
        }

        private void handleOperation(string value)
        {
            try
            {

                switch (value)
                {
                    case "p":
                        firstInput = Convert.ToDouble(displayBox.Text);
                        operand = "p";
                        displayBox.Text = string.Empty; break;
                    case "s":
                        firstInput = Convert.ToDouble(displayBox.Text);
                        operand = "s";
                        displayBox.Text = string.Empty; break;
                    case "m":
                        firstInput = Convert.ToDouble(displayBox.Text);
                        operand = "m";
                        displayBox.Text = string.Empty; break;
                    case "d":
                        firstInput = Convert.ToDouble(displayBox.Text);
                        operand = "d";
                        displayBox.Text = string.Empty; break;
                    case "=":
                        secondInput = Convert.ToDouble(displayBox.Text);
                        printResult(operand); break;
                    case "AC":
                        firstInput = 0;
                        secondInput = 0;
                        displayBox.Text = string.Empty; break;
                    default: displayBox.Text = string.Empty; break;
                }
            }
            catch (System.Exception)
            {
                displayBox.Text = string.Empty;
            }
        }

        private void printResult(string value)
        {
            try
            {
                switch (value)
                {
                    case "p":
                        result = firstInput + secondInput;
                        displayBox.Text = result.ToString(); break;
                    case "s":
                        result = firstInput - secondInput;
                        displayBox.Text = result.ToString(); break;
                    case "m":
                        result = firstInput * secondInput;
                        displayBox.Text = result.ToString(); break;
                    case "d":
                        result = firstInput / secondInput;
                        displayBox.Text = result.ToString(); break;
                    default: displayBox.Text = string.Empty; break;
                }
            }
            catch (System.Exception)
            {
                displayBox.Text = string.Empty;
            }
        }
    }
}
