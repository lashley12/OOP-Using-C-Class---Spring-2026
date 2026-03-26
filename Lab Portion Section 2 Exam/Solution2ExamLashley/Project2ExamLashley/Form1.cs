using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Name: Lauren Lashley
Class: Obj-Oriented Prg with C#
Semester: Spring 2026
Assignment: Lab Portion Section 2 Exam
*/

namespace Project2ExamLashley
{
    public partial class frmOperations : Form
    {
        public frmOperations()
        {
            InitializeComponent();
        }

        private bool ValidateRange(int value, int max)
        {
            if (value < 0 || value > max)
            {
                lblMessageArea.Text += $"\nValue must be between 0 and {max}.";
                return false;
            }

            return true;
        }

        private void btnShowModulus_Click(object sender, EventArgs e)
        {
            lblMessageArea.Text = "Enter two whole numbers to perform long division.";

            txtOperand1.Visible = true;
            txtOperand2.Visible = true;

            btnDoModulus.Enabled = true;
            btnDoFactorial.Enabled = false;
            btnDoFibonacci.Enabled = false;
        }

        private void btnShowFactorial_Click(object sender, EventArgs e)
        {
            lblMessageArea.Text = "Enter one whole number between 0 and 15 to calculate factorial.";

            txtOperand1.Visible = true;
            txtOperand2.Visible = false;

            btnDoModulus.Enabled = false;
            btnDoFactorial.Enabled = true;
            btnDoFibonacci.Enabled = false;
        }

        private void btnShowFibonacci_Click(object sender, EventArgs e)
        {
            lblMessageArea.Text = "Enter one whole number between 0 and 45 to calculate Fibonacci.";

            txtOperand1.Visible = true;
            txtOperand2.Visible = false;

            btnDoModulus.Enabled = false;
            btnDoFactorial.Enabled = false;
            btnDoFibonacci.Enabled = true;
        }

        private void btnDoModulus_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtOperand1.Text) ||
                    string.IsNullOrWhiteSpace(txtOperand2.Text))
                {
                    lblMessageArea.Text += "\nBoth operands must be entered.";
                    return;
                }

                int dividend = int.Parse(txtOperand1.Text);
                int divisor = int.Parse(txtOperand2.Text);

                if (divisor == 0)
                {
                    lblMessageArea.Text += "\nCannot divide by zero.";
                    return;
                }

                int quotient = 0;
                int remainder = dividend;

                while (remainder >= divisor)
                {
                    remainder -= divisor;
                    quotient++;
                }

                lblMessageArea.Text +=
                    $"\n{dividend} divided by {divisor} is {quotient} with a remainder of {remainder}";
            }
            catch (FormatException)
            {
                lblMessageArea.Text += "\nOnly whole numbers are allowed. Decimal values are prohibited.";
            }
            catch (Exception)
            {
                lblMessageArea.Text += "\nAn unexpected error occurred.";
            }
        }

        private void btnDoFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtOperand1.Text))
                {
                    lblMessageArea.Text += "\nOperand cannot be empty.";
                    return;
                }

                int number = int.Parse(txtOperand1.Text);

                if (!ValidateRange(number, 15))
                    return;

                if (number == 0 || number == 1)
                {
                    lblMessageArea.Text += $"\nThe answer to {number}! is 1";
                    return;
                }

                int f = 1;
                int i = 1;

                while (i <= number)
                {
                    f *= i;
                    i++;
                }

                lblMessageArea.Text += $"\nThe answer to {number}! is {f}";
            }
            catch (FormatException)
            {
                lblMessageArea.Text += "\nOnly whole numbers are allowed. Decimal values are prohibited.";
            }
            catch (Exception)
            {
                lblMessageArea.Text += "\nAn unexpected error occurred.";
            }
        }

        private void btnDoFibonacci_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtOperand1.Text))
                {
                    lblMessageArea.Text += "\nOperand cannot be empty.";
                    return;
                }

                int number = int.Parse(txtOperand1.Text);

                if (!ValidateRange(number, 45))
                    return;

                if (number == 0)
                {
                    lblMessageArea.Text += "\nFibonacci(0) = 0";
                    return;
                }

                if (number == 1)
                {
                    lblMessageArea.Text += "\nFibonacci(1) = 1";
                    return;
                }

                int prev = 0;
                int current = 1;
                int next = 0;

                for (int i = 2; i <= number; i++)
                {
                    next = prev + current;
                    prev = current;
                    current = next;
                }

                lblMessageArea.Text += $"\nFibonacci({number}) = {current}";
            }
            catch (FormatException)
            {
                lblMessageArea.Text += "\nOnly whole numbers are allowed. Decimal values are prohibited.";
            }
            catch (Exception)
            {
                lblMessageArea.Text += "\nAn unexpected error occurred.";
            }
        }

        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOperand2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmOperations_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMessageArea.Text = "Message area cleared. Operands remain unchanged.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using the Operations App!",
                            "Goodbye");

            this.Close();
        }
    }
}