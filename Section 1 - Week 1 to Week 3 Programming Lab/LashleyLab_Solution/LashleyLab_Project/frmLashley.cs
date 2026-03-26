using System;
using System.Drawing;
using System.Windows.Forms;

/*
Name: Lauren Lashley
Class: Programming Lab
Due Date: 01/20/2026
*/

namespace LashleyLab_Project
{
    public partial class frmLashley : Form
    {
        public frmLashley()
        {
            InitializeComponent();

            lblTheDominator.Text = "";
            lblTheDominator.BackColor = Color.White;
            lblTheDominator.ForeColor = Color.Black;
        }

        /*  COLOR */
        private void ColorButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            lblTheDominator.BackColor = clickedButton.BackColor;
        }

        /* DIGIT */
        private void DigitButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            lblTheDominator.Text = clickedButton.Text;
        }

        /* CLEAR */
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "";
            lblTheDominator.BackColor = Color.White;
            lblTheDominator.ForeColor = Color.Black;
        }

        /* EXIT */
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLashley_Load(object sender, EventArgs e)
        {

        }
    }
}