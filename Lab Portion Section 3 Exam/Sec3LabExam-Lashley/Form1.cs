using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Sec3LabExam_Lashley
{
    public partial class Form1 : Form
    {
        // This line counts how many times it converted plain text to cipher text
        private int _plainToCipherConversionCount;
        // This line counts how many times it converted cipher text to plain text
        private int _cipherToPlainConversionCount;
        // This is the decoder wheel: index 0 = 'A' … 25 = 'Z'; so each entry is the cipher letter for that plain letter
        private static readonly char[] PlainLetterToCipherLetter = new char[26]
        {
            'S', 'R', 'E', 'N', 'A', 'C', 'H', 'P', 'T', 'I', 'M', 'G', 'L', 'X', 'W', 'V', 'F', 'U', 'J', 'B', 'K', 'O', 'Z', 'Y', 'D', 'Q'
        };

        // This is the inverse wheel: index 0 = cipher 'A' … 25 = 'Z'; so each entry is the plain letter that the cipher letter represents
        private static readonly char[] CipherLetterToPlainLetter = BuildCipherToPlainLookup();
        // This is the upper limit on message length to mee tthe invalid-range validation
        private const int MaxMessageLength = 50000;
        public Form1()
        {
            InitializeComponent();
        }

        private static char[] BuildCipherToPlainLookup()
        {
            char[] inverse = new char[26];
            for (int plainIndex = 0; plainIndex < 26; plainIndex++)
            {
                char cipherCh = PlainLetterToCipherLetter[plainIndex];
                inverse[cipherCh - 'A'] = (char)('A' + plainIndex);
            }
            return inverse;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string rawInput = txtInput.Text;
            List<string> errors = CollectValidationErrors(rawInput);

            if (errors.Count > 0)
            {
                MessageBox.Show(
                    this,
                    "Please fix the following:" + Environment.NewLine + Environment.NewLine + string.Join(Environment.NewLine, errors),
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            bool plainToCipher = radPlainToCipher.Checked;
            txtOutput.Text = ConvertMessage(rawInput, plainToCipher);

            if (plainToCipher)
                _plainToCipherConversionCount++;
            else
                _cipherToPlainConversionCount++;
        }

        /// This is the validation errors for the Empty data, Invalid data type, or Invalid range of data part of the assignement
        private static List<string> CollectValidationErrors(string text)
        {
            List<string> errors = new List<string>();

            if (text == null)
            {
                errors.Add("• Invalid data type: the message cannot be null.");
                return errors;
            }

            if (text.Trim().Length == 0)
                errors.Add("• Empty data: enter a message to convert.");

            if (text.Length > MaxMessageLength)
                errors.Add("• Invalid range: message is too long (maximum " + MaxMessageLength + " characters).");

            return errors;
        }

        private static string ConvertMessage(string input, bool plainToCipher)
        {
            StringBuilder sb = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c >= 'a' && c <= 'z')
                    c = (char)(c - 'a' + 'A');
                if (c >= 'A' && c <= 'Z')
                {
                    int idx = c - 'A';
                    sb.Append(plainToCipher ? PlainLetterToCipherLetter[idx] : CipherLetterToPlainLetter[idx]);
                }
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            radPlainToCipher.Checked = true;
            txtInput.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string msg =
                "Conversion Summary:" + Environment.NewLine + Environment.NewLine +
                "Plain text → cipher text conversions: " + _plainToCipherConversionCount + Environment.NewLine +
                "Cipher text → plain text conversions: " + _cipherToPlainConversionCount + Environment.NewLine + Environment.NewLine +
                "Goodbye.";
            MessageBox.Show(this, msg, "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}