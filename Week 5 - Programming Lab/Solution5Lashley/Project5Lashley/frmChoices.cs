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
ITD 2343 – Week 5 Assignment
Solution 5 – Decision Making
Due Date: 2/8/2026
*/


namespace Project5Lashley
{
    public partial class frmChoices : Form
    {
        public frmChoices()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLeftNumber.Text = "";
            txtRightNumber.Text = "";
            txtCheckNumber.Text = "";

            lblMessage.Text = "";

            txtLeftNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int leftNumber;
            int rightNumber;
            int checkNumber;

            leftNumber = int.Parse(txtLeftNumber.Text);
            rightNumber = int.Parse(txtRightNumber.Text);
            checkNumber = int.Parse(txtCheckNumber.Text);

            if (checkNumber == leftNumber)
            {
                lblMessage.Text = "The number is equal to the lower end of the range.";
            }
            else if (checkNumber == rightNumber)
            {
                lblMessage.Text = "The number is equal to the upper end of the range.";
            }
            else if (checkNumber < leftNumber)
            {
                lblMessage.Text = "The number is lower than the low end of the range.";
            }
            else if (checkNumber > rightNumber)
            {
                lblMessage.Text = "The number is higher than the high end of the range.";
            }
            else
            {
                lblMessage.Text = "The number is in the range of " +
                                  leftNumber + " and " + rightNumber + ".";
            }

            txtCheckNumber.Text = "";

            txtCheckNumber.Focus();
        }
    }
}
