using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

/*
Lauren Lashley
Object-Oriented Prg Using C# - ITD 2343
Week 9 Programming Lab
Due: March 8, 2026
*/

namespace Week9Prg_Lashley
{
    public partial class frmCheckDigit : Form
    {
        private bool ValidateInputs(string account, string confirm,
                            string paymentInput,
                            out decimal payment)
        {
            payment = 0;

            if (string.IsNullOrWhiteSpace(account) ||
                string.IsNullOrWhiteSpace(confirm) ||
                string.IsNullOrWhiteSpace(paymentInput))
            {
                rtbMessage.Text = "All fields are required.";
                return false;
            }

            if (!account.All(char.IsDigit) ||
                !confirm.All(char.IsDigit))
            {
                rtbMessage.Text = "Account numbers must be numeric.";
                return false;
            }

            if (account.Length != 8 || confirm.Length != 8)
            {
                rtbMessage.Text = "Account number must be exactly 8 digits.";
                return false;
            }

            if (account != confirm)
            {
                rtbMessage.Text = "Account numbers do not match.";
                return false;
            }

            if (!decimal.TryParse(paymentInput,
                NumberStyles.Currency,
                CultureInfo.CurrentCulture,
                out payment))
            {
                rtbMessage.Text = "Invalid payment amount.";
                return false;
            }
            return true;
        }

        private bool IsValidCheckDigit(string account)
        {
            int total = 0;

            for (int i = 0; i < account.Length - 1; i++)
            {
                total += int.Parse(account[i].ToString());
            }

            int checkDigit = total % 10;
            int lastDigit = int.Parse(account[account.Length - 1].ToString());

            return checkDigit == lastDigit;
        }

        private void DisplaySuccess(string account, decimal payment)
        {
            string date = DateTime.Now.ToString("MMMM dd, yyyy");

            rtbMessage.Text =
                $"A payment of {payment.ToString("C")} was applied to account {account} on {date}.";
        }

        public frmCheckDigit()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            rtbMessage.Text = "";

            string account = txtAccount.Text.Trim();
            string confirm = txtConfirm.Text.Trim();
            string paymentInput = txtPayment.Text.Trim();

            if (!ValidateInputs(account, confirm, paymentInput, out decimal payment))
                return;

            if (!IsValidCheckDigit(account))
            {
                rtbMessage.Text = "Invalid account number. Check digit does not match.";
                return;
            }

            DisplaySuccess(account, payment);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAccount.Text = "";
            txtConfirm.Text = "";
            txtPayment.Text = "";
            rtbMessage.Text = "";
            txtAccount.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}