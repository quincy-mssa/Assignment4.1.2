using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._1._2
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string operation = "";
        private bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBoxResult.Text == "1" || isOperationPerformed)
                textBoxResult.Clear();

            isOperationPerformed = false;
            textBoxResult.Text += button.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBoxResult.Text == "2" || isOperationPerformed)
                textBoxResult.Clear();

            isOperationPerformed = false;
            textBoxResult.Text += button.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBoxResult.Text == "3" || isOperationPerformed)
                textBoxResult.Clear();

            isOperationPerformed = false;
            textBoxResult.Text += button.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBoxResult.Text == "4" || isOperationPerformed)
                textBoxResult.Clear();

            isOperationPerformed = false;
            textBoxResult.Text += button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBoxResult.Text == "5" || isOperationPerformed)
                textBoxResult.Clear();

            isOperationPerformed = false;
            textBoxResult.Text += button.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBoxResult.Text == "6" || isOperationPerformed)
                textBoxResult.Clear();

            isOperationPerformed = false;
            textBoxResult.Text += button.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBoxResult.Text == "7" || isOperationPerformed)
                textBoxResult.Clear();

            isOperationPerformed = false;
            textBoxResult.Text += button.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBoxResult.Text == "8" || isOperationPerformed)
                textBoxResult.Clear();

            isOperationPerformed = false;
            textBoxResult.Text += button.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBoxResult.Text == "9" || isOperationPerformed)
                textBoxResult.Clear();

            isOperationPerformed = false;
            textBoxResult.Text += button.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBoxResult.Text == "0" || isOperationPerformed)
                textBoxResult.Clear();

            isOperationPerformed = false;
            textBoxResult.Text += button.Text;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                buttonEquals.PerformClick();
                operation = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = double.Parse(textBoxResult.Text);
                isOperationPerformed = true;
            }

        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                buttonEquals.PerformClick();
                operation = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = double.Parse(textBoxResult.Text);
                isOperationPerformed = true;
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                buttonEquals.PerformClick();
                operation = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = double.Parse(textBoxResult.Text);
                isOperationPerformed = true;
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                buttonEquals.PerformClick();
                operation = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = double.Parse(textBoxResult.Text);
                isOperationPerformed = true;
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBoxResult.Text = (result + double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (result - double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (result * double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (result / double.Parse(textBoxResult.Text)).ToString();
                    break;
            }
            result = double.Parse(textBoxResult.Text);
            operation = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            result = 0;
            operation = "";
        }




    }
}
