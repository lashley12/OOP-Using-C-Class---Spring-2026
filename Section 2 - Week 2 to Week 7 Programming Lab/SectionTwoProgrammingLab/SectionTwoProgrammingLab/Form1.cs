using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SectionTwoProgrammingLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string ConvertFromDecimal(int number, int targetBase)
        {
            const string digits = "0123456789ABCDEF";
            string result = "";

            if (number == 0)
                result = "0";
            else
            {
                while (number > 0)
                {
                    int remainder = number % targetBase;
                    result = digits[remainder] + result;
                    number /= targetBase;
                }
            }
            string prefix = targetBase == 16 ? "0x" : targetBase + "x";
            return prefix + result;
        }


        private void txtConvertFrom_TextChanged(object sender, EventArgs e)
        {
            bool hasDecimal = txtConvertFrom.Text.Trim() != "";
            bool hasBase = txtBase.Text.Trim() != "";
            btnBinary.Enabled = hasDecimal;
            btnOctal.Enabled = hasDecimal;
            btnHex.Enabled = hasDecimal;
            btnBase6.Enabled = hasDecimal;
            btnBase9.Enabled = hasDecimal;
            btnProcess.Enabled = hasDecimal && hasBase;
        }


        private void txtBase_TextChanged(object sender, EventArgs e)
        {
            bool hasDecimal = txtConvertFrom.Text.Trim() != "";
            bool hasBase = txtBase.Text.Trim() != "";
            btnProcess.Enabled = hasDecimal && hasBase;
        }



        private void btnBinary_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Black;

            if (!int.TryParse(txtConvertFrom.Text, out int number))
            {
                lblMessage.Text = "Convert From must be a whole number.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            if (number < 0)
            {
                lblMessage.Text = "Negative numbers are not allowed.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            lblMessage.Text = ConvertFromDecimal(number, 2);
        }



        private void btnOctal_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Black;

            if (!int.TryParse(txtConvertFrom.Text, out int number))
            {
                lblMessage.Text = "Convert From must be a whole number.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            if (number < 0)
            {
                lblMessage.Text = "Negative numbers are not allowed.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            lblMessage.Text = ConvertFromDecimal(number, 8);
        }



        private void btnHex_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Black;

            if (!int.TryParse(txtConvertFrom.Text, out int number))
            {
                lblMessage.Text = "Convert From must be a whole number.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            if (number < 0)
            {
                lblMessage.Text = "Negative numbers are not allowed.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            lblMessage.Text = ConvertFromDecimal(number, 16);
        }



        private void btnBase6_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Black;

            if (!int.TryParse(txtConvertFrom.Text, out int number))
            {
                lblMessage.Text = "Convert From must be a whole number.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            if (number < 0)
            {
                lblMessage.Text = "Negative numbers are not allowed.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            lblMessage.Text = ConvertFromDecimal(number, 6);
        }



        private void btnBase9_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Black;

            if (!int.TryParse(txtConvertFrom.Text, out int number))
            {
                lblMessage.Text = "Convert From must be a whole number.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            if (number < 0)
            {
                lblMessage.Text = "Negative numbers are not allowed.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            lblMessage.Text = ConvertFromDecimal(number, 9);
        }



        private void btnProcess_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Black;
            if (!int.TryParse(txtConvertFrom.Text, out int number))
            {
                lblMessage.Text = "Convert From must be a whole number.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            if (number < 0)
            {
                lblMessage.Text = "Negative numbers are not allowed.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            if (!int.TryParse(txtBase.Text, out int baseValue))
            {
                lblMessage.Text = "Base must be a whole number.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            if (baseValue < 2 || baseValue > 16)
            {
                lblMessage.Text = "Base must be between 2 and 16.";
                lblMessage.ForeColor = Color.Red;
                return;
            }
            lblMessage.Text = ConvertFromDecimal(number, baseValue);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConvertFrom.Text = "";
            txtBase.Text = "";
            lblMessage.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}