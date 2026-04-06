using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap_B2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        double result = 0;
        string operation = "";
        bool isOperationPerformed = false;
        double memory = 0;

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationPerformed))
                textDisplay.Clear();

            isOperationPerformed = false;

            Button btn = (Button)sender;
            textDisplay.Text += btn.Text;
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationPerformed))
                textDisplay.Clear();

            isOperationPerformed = false;

            Button btn = (Button)sender;
            textDisplay.Text += btn.Text;
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationPerformed))
                textDisplay.Clear();

            isOperationPerformed = false;

            Button btn = (Button)sender;
            textDisplay.Text += btn.Text;
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationPerformed))
                textDisplay.Clear();

            isOperationPerformed = false;

            Button btn = (Button)sender;
            textDisplay.Text += btn.Text;
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationPerformed))
                textDisplay.Clear();

            isOperationPerformed = false;

            Button btn = (Button)sender;
            textDisplay.Text += btn.Text;
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationPerformed))
                textDisplay.Clear();

            isOperationPerformed = false;

            Button btn = (Button)sender;
            textDisplay.Text += btn.Text;
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationPerformed))
                textDisplay.Clear();

            isOperationPerformed = false;

            Button btn = (Button)sender;
            textDisplay.Text += btn.Text;
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationPerformed))
                textDisplay.Clear();

            isOperationPerformed = false;

            Button btn = (Button)sender;
            textDisplay.Text += btn.Text;
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationPerformed))
                textDisplay.Clear();

            isOperationPerformed = false;

            Button btn = (Button)sender;
            textDisplay.Text += btn.Text;
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationPerformed))
                textDisplay.Clear();

            isOperationPerformed = false;

            Button btn = (Button)sender;
            textDisplay.Text += btn.Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            operation = btn.Text;
            result = Double.Parse(textDisplay.Text);
            isOperationPerformed = true;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            operation = btn.Text;
            result = Double.Parse(textDisplay.Text);
            isOperationPerformed = true;
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            operation = btn.Text;
            result = Double.Parse(textDisplay.Text);
            isOperationPerformed = true;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            operation = btn.Text;
            result = Double.Parse(textDisplay.Text);
            isOperationPerformed = true;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textDisplay.Text = (result + Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "-":
                    textDisplay.Text = (result - Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "*":
                    textDisplay.Text = (result * Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "/":
                    textDisplay.Text = (result / Double.Parse(textDisplay.Text)).ToString();
                    break;
            }
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text != "0")
            {
                if (textDisplay.Text.StartsWith("-"))
                    textDisplay.Text = textDisplay.Text.Substring(1);
                else
                    textDisplay.Text = "-" + textDisplay.Text;
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!textDisplay.Text.Contains("."))
                textDisplay.Text += ".";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 1)
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1);
            else
                textDisplay.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            textDisplay.Text = memory.ToString();
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(textDisplay.Text);
        }

        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            memory -= Double.Parse(textDisplay.Text);
        }
    }
}
