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
Lauren Lashley
ITD 2343 – OOP using C#
Week 4 – Data Types Assignment
Due: 02/04/2025
*/


namespace Module4Project
{
    public partial class frmOfDataTypes : Form
    {
        public frmOfDataTypes()
        {
            InitializeComponent();
        }

        private void btnByte_Click(object sender, EventArgs e)
        {
            byte leftOperand = 10;
            byte rightOperand = 5;
            byte result = (byte)(leftOperand + rightOperand);

            lblDisplay.Text = string.Format("{0} + {1} = {2}",
                leftOperand, rightOperand, result);

        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            short leftOperand = 20;
            short rightOperand = 8;
            short result = (short)(leftOperand - rightOperand);

            lblDisplay.Text = string.Format("{0} - {1} = {2}",
                leftOperand, rightOperand, result);
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int leftOperand = 7;
            int rightOperand = 2;
            int result = leftOperand / rightOperand;

            lblDisplay.Text = string.Format("{0} / {1} = {2}",
                leftOperand, rightOperand, result);
        }

        private void btnLong_Click(object sender, EventArgs e)
        {
            long leftOperand = 25;
            long rightOperand = 4;
            long result = leftOperand % rightOperand;

            lblDisplay.Text = string.Format("{0} % {1} = {2}",
                leftOperand, rightOperand, result);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            float leftOperand = 7.0f;
            float rightOperand = 2.0f;
            float result = leftOperand % rightOperand;

            lblDisplay.Text = string.Format("{0:F7} % {1:F7} = {2:F7}",
                leftOperand, rightOperand, result);
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double leftOperand = 7.0;
            double rightOperand = 2.0;
            double result = leftOperand / rightOperand;

            lblDisplay.Text = string.Format("{0:F15} / {1:F15} = {2:F15}",
                leftOperand, rightOperand, result);
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            decimal leftOperand = 1.234567890123456m;
            decimal rightOperand = 2.0m;
            decimal result = leftOperand * rightOperand;

            lblDisplay.Text = string.Format("{0:F28} * {1:F28} = {2:F28}",
                leftOperand, rightOperand, result);
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            double baseValue = 2;
            double exponent = 3;
            double result = Math.Pow(baseValue, exponent);

            lblDisplay.Text = $"The result of {baseValue} raised to the power of {exponent} is {result}.";
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            double value = 3.14159265;
            int decimals = 3;
            double result = Math.Round(value, decimals);

            lblDisplay.Text = $"The value {value} rounded to {decimals} decimal places is {result}.";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double value = 16;
            double result = Math.Sqrt(value);

            lblDisplay.Text = $"The square root of {value} is {result}.";
        }
    }
}