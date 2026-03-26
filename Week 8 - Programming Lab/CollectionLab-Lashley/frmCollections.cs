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
Object-Oriented Prg Using C# - ITD-2343
Due: March 4, 2026
Week 8 Programming Lab - Collection Lab
*/

namespace CollectionLab_Lashley
{
    public partial class frmCollections : Form
    {
        private const int MAX_ELEMENTS = 17;
        private const int MAX_VALUE = 1217;
        private const int MIN_VALUE = -1217;

        private List<int> numbers = new List<int>();

        public frmCollections()
        {
            InitializeComponent();
        }

        private bool ValidateInput(out int value)
        {
            value = 0;

            if (string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                rtbStats.Text = "Please enter a number.";
                txtNumber.Text = "";
                return false;
            }

            // makes sure only whole numbers were entered
            if (!int.TryParse(txtNumber.Text, out value))
            {
                rtbStats.Text = "Only whole numbers are allowed.";
                txtNumber.Text = "";
                return false;
            }

            // the min value
            if (value < MIN_VALUE)
            {
                rtbStats.Text = "Value is too small.";
                txtNumber.Text = "";
                return false;
            }

            // the max value
            if (value > MAX_VALUE)
            {
                rtbStats.Text = "Value is too big.";
                txtNumber.Text = "";
                return false;
            }

            return true;
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            rtbCollection.Clear();
            rtbStats.Clear();
            int value;

            if (!ValidateInput(out value))
                return;
            if (numbers.Count >= MAX_ELEMENTS)
            {
                rtbStats.Text = "Collection is full. Maximum of 17 numbers allowed.";
                txtNumber.Text = "";
                return;
            }

            numbers.Add(value);
            txtNumber.Text = "";
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 0)
            {
                rtbStats.Text = "Collection is empty.";
                return;
            }

            rtbCollection.Clear();

            int highest = numbers[0];
            int lowest = numbers[0];
            int total = 0;

            foreach (int num in numbers)
            {
                rtbCollection.AppendText(num.ToString() + Environment.NewLine);

                total += num;

                if (num > highest)
                    highest = num;

                if (num < lowest)
                    lowest = num;
            }

            double average = (double)total / numbers.Count;

            rtbStats.Text =
                "High Number: " + highest + Environment.NewLine +
                "Low Number: " + lowest + Environment.NewLine +
                "Average: " + average.ToString("F4") + Environment.NewLine +
                "Count: " + numbers.Count;

            numbers.Clear();
            txtNumber.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            rtbCollection.Clear();
            rtbStats.Text = "Collection has been cleared.";
            txtNumber.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
              this.Close();
        }

        private void rtbCollection_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbStats_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
