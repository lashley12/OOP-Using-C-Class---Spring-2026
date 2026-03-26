using System;
using System.Windows.Forms;

/*
Lauren Lashley
ITD 2343 Week 7 - Programming Lab
Due Date: 2/22/26
*/

namespace Module6MethodsProjectDL
{
    public partial class frmRealID : Form
    {
        const byte ADD = 0;
        const byte SUBTRACT = 1;
        const byte MULTIPLY = 2;
        const byte DIVIDE = 3;
        const byte MODULUS = 4;

        public frmRealID()
        {
            InitializeComponent();
        }

        private decimal PerformOperation(decimal left, decimal right, byte operation)
        {
            decimal result = 0.0m;

            if (operation == ADD)
            {
                result = left + right;
            }
            else if (operation == SUBTRACT)
            {
                result = left - right;
            }
            else if (operation == MULTIPLY)
            {
                result = left * right;
            }
            else if (operation == DIVIDE)
            {
                result = left / right;
            }
            else if (operation == MODULUS)
            {
                result = left % right;
            }
            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DoMath(ADD, "+");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            DoMath(SUBTRACT, "-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            DoMath(MULTIPLY, "*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            DoMath(DIVIDE, "/");
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            DoMath(MODULUS, "%");
        }

        private void DoMath(byte operationType, string symbol)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;

            string szLeft = txtLeftOperand.Text.Trim();
            string szRight = txtRightOperand.Text.Trim();

            string errorMessage = "";

            try
            {
                // setting up the validation messages
                if (szLeft == "")
                    errorMessage += "Left operand cannot be empty.\n";

                if (szRight == "")
                    errorMessage += "Right operand cannot be empty.\n";

                if (errorMessage == "")
                {
                    if (!decimal.TryParse(szLeft, out dLeft))
                        errorMessage += "Left operand must be a valid number.\n";

                    if (!decimal.TryParse(szRight, out dRight))
                        errorMessage += "Right operand must be a valid number.\n";
                }

                if (errorMessage == "")
                {
                    if (operationType == DIVIDE && dRight == 0)
                        errorMessage += "Cannot divide by zero.\n";

                    if (operationType == MODULUS && (dLeft < 0 || dRight < 0))
                        errorMessage += "Modulus cannot use negative numbers.\n";
                }

                // for when it shows validation error 
                if (errorMessage != "")
                {
                    lblResult.ForeColor = System.Drawing.Color.Red;
                    lblResult.Text = errorMessage;
                    return;
                }

                dAnswer = PerformOperation(dLeft, dRight, operationType);

                string szAnswer = dAnswer.ToString();
                string szEquation = szLeft + " " + symbol + " " + szRight + " = " + szAnswer;

                lblResult.ForeColor = System.Drawing.Color.Black;
                lblResult.Text = szEquation;
            }
            catch (Exception)
            {
                lblResult.ForeColor = System.Drawing.Color.Red;
                lblResult.Text = "Unexpected error occurred.";
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLeftOperand.Text = "";
            txtRightOperand.Text = "";
            lblResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}