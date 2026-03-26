using System;
using System.Windows.Forms;

/*
Lauren Lashley
ITD 2343 Week 6 - Programming Lab
Due Date: 2/15/26
*/

namespace Module6MethodsProjectDL
{
    public partial class frmMethodActing : Form
    {
        const byte ADD = 0;
        const byte SUBTRACT = 1;
        const byte MULTIPLY = 2;
        const byte DIVIDE = 3;
        const byte MODULUS = 4;

        public frmMethodActing()
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

            string szLeft = txtLeftOperand.Text;
            string szRight = txtRightOperand.Text;

            if (!decimal.TryParse(szLeft.Trim(), out dLeft) ||
             !decimal.TryParse(szRight.Trim(), out dRight))
            {
                return;
            }

            dAnswer = PerformOperation(dLeft, dRight, operationType);

            string szAnswer = dAnswer.ToString();
            string szEquation = szLeft + " " + symbol + " " + szRight + " = " + szAnswer;

            lblResult.Text = "";
            lblResult.Text = szEquation;
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