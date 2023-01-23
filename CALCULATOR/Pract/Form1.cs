using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String opnPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

      

        private void btn_click(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isOperationPerformed))
                textBoxResult.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text==".")
            {
                if (!textBoxResult.Text.Contains("."))
                    textBoxResult.Text = textBoxResult.Text + button.Text;
            }else
            textBoxResult.Text = textBoxResult.Text + button.Text;
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                button15.PerformClick();
                opnPerformed = button.Text;
                labelCurrentOpn.Text = resultValue + " " + opnPerformed;
                isOperationPerformed = true;
            }
            else
            {
                opnPerformed = button.Text;
                resultValue = Double.Parse(textBoxResult.Text);
                labelCurrentOpn.Text = resultValue + " " + opnPerformed;
                isOperationPerformed = true;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            resultValue = 0;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            switch (opnPerformed)
            {
                case "+":
                    textBoxResult.Text = (resultValue + Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (resultValue - Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (resultValue * Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (resultValue / Double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBoxResult.Text);
            labelCurrentOpn.Text = "";
        }
    }
}
