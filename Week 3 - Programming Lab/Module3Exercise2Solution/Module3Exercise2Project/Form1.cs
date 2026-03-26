using System;
using System.Windows.Forms;

// FIX: Removed unused imports that were originally included but not needed.
// These namespaces were not used anywhere in this file and caused clutter.
// using System.Collections.Generic;
// using System.ComponentModel;
// using System.Data;
// using System.Drawing;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace Module3Exercise2Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            // fixed - uses the correct label control name (lblMessage)
            lblMessage.Text = btnR.Text;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            // fixed - set the label background color to match the Red button color
            // This logic was already correct so i used it as a reference for other fixes
            lblMessage.BackColor = btnRed.BackColor;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            // fixed - added logic to set the label background color
            lblMessage.BackColor = btnBlue.BackColor;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            // fixed - uses the correct label control name (lblMessage)
            lblMessage.Text = btnL.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // fixed - I renamed this to match btnExit Click event name
            this.Close();
        }

    }
}