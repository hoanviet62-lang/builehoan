using System;
using System.Windows.Forms;

namespace QuanLyResponsive
{
    public partial class Form1 : Form
    {
        private double operand1 = 0;
        private string pendingOperation = "";
        private bool isNewNumber = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isNewNumber || txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
                isNewNumber = false;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operand1 = double.Parse(txtDisplay.Text);
            pendingOperation = btn.Text;
            isNewNumber = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double operand2 = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (pendingOperation)
            {
                case "+": result = operand1 + operand2; break;
                case "-": result = operand1 - operand2; break;
                case "*": result = operand1 * operand2; break;
                case "/":
                    if (operand2 != 0)
                        result = operand1 / operand2;
                    else
                    {
                        MessageBox.Show("Không thể chia cho 0!");
                        return;
                    }
                    break;
            }

            txtDisplay.Text = result.ToString();
            isNewNumber = true;
            pendingOperation = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            operand1 = 0;
            pendingOperation = "";
            isNewNumber = true;
        }
    }
}