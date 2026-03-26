using System;
using System.Windows.Forms;

/*
Name: Lauren Lashley
Class: Week 2 Assignment
Due Date: January 18, 2025
*/

namespace Week2_Lashley_Project
{
    public partial class frmFall2025 : Form
    {
        public frmFall2025()
        {
            InitializeComponent();

            // ESC key will exit 
            this.CancelButton = btnExit;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            lblDisplay.Text = txtInput.Text;
        }

        private void btnWipe_Click_1(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
