using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GettysburgsAddress
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            btnProcess.Enabled = false; 
            UpdateStatsVisibility();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            btnProcess.Enabled = !string.IsNullOrWhiteSpace(txtInput.Text);
        }

        private void rdoOptions_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStatsVisibility();
        }

        private void rdoShowUniqueWordList_CheckedChanged(object sender, EventArgs e)
        {
            chkIncludeFrequency.Enabled = rdoShowUniqueWordList.Checked;
            if (!rdoShowUniqueWordList.Checked)
            {
                chkIncludeFrequency.Checked = false;
            }
            UpdateStatsVisibility();
        }

        private void UpdateStatsVisibility()
        {
            bool isUniqueView = rdoShowUniqueWordList.Checked;
            
            lblUniqueWords.Visible = txtUniqueWords.Visible = isUniqueView;
            lblAvgUniqueLen.Visible = txtAvgUniqueLen.Visible = isUniqueView;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lstWords.Items.Clear();
            
            txtChars.Clear();
            txtSentences.Clear();
            txtWords.Clear();
            txtUniqueWords.Clear();
            txtTwoWordPairs.Clear();
            txtAvgWordLen.Clear();
            txtAvgUniqueLen.Clear();

            rdoShowWordList.Checked = true;
            chkIncludeFrequency.Checked = false;
            chkIncludeFrequency.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Please enter some text to process.", "No Text Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string input = txtInput.Text;

                // char counts
                int charCount = input.Length;

                // sent. counts
                int sentenceCount = 0;
                foreach (char c in input)
                {
                    if (c == '.' || c == '?' || c == '!')
                    {
                        sentenceCount++;
                    }
                }

                // extract words
                var matches = Regex.Matches(input, @"[a-zA-Z]+(?:[-'][a-zA-Z]+)*");
                List<string> originalWords = new List<string>();
                int totalWordLength = 0;
                
                foreach (Match m in matches)
                {
                    string word = m.Value.ToLower(); 
                    originalWords.Add(word);
                    totalWordLength += word.Length;
                }

                // stat calculations
                int wordCount = originalWords.Count;
                double avgWordLen = wordCount > 0 ? (double)totalWordLength / wordCount : 0;

                var uniqueWordsDict = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
                foreach (var w in originalWords)
                {
                    if (uniqueWordsDict.ContainsKey(w))
                        uniqueWordsDict[w]++;
                    else
                        uniqueWordsDict.Add(w, 1);
                }

                int uniqueWordCount = uniqueWordsDict.Count;
                int totalUniqueLen = uniqueWordsDict.Keys.Sum(w => w.Length);
                double avgUniqueLen = uniqueWordCount > 0 ? (double)totalUniqueLen / uniqueWordCount : 0;

                // two-word pairs credit
                var twoWordPairsDict = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
                for (int i = 0; i < originalWords.Count - 1; i++)
                {
                    string pair = originalWords[i] + " " + originalWords[i + 1];
                    if (twoWordPairsDict.ContainsKey(pair))
                        twoWordPairsDict[pair]++;
                    else
                        twoWordPairsDict.Add(pair, 1);
                }

                var multiPairs = twoWordPairsDict.Where(kvp => kvp.Value > 1).ToList();
                int multiPairCount = multiPairs.Count; 

                txtChars.Text = charCount.ToString();
                txtSentences.Text = sentenceCount.ToString();
                txtWords.Text = wordCount.ToString();
                txtUniqueWords.Text = uniqueWordCount.ToString();
                txtTwoWordPairs.Text = multiPairCount.ToString(); 
                txtAvgWordLen.Text = avgWordLen.ToString("0.##");
                txtAvgUniqueLen.Text = avgUniqueLen.ToString("0.##");

                lstWords.BeginUpdate();
                lstWords.Items.Clear();

                if (rdoShowWordList.Checked)
                {
                    // list it all in alpha order.
                    var sortedWords = originalWords.OrderBy(w => w).ToList();
                    foreach (var w in sortedWords)
                    {
                        lstWords.Items.Add(w);
                    }
                }
                else if (rdoShowUniqueWordList.Checked)
                {
                    var sortedUnique = uniqueWordsDict.Keys.OrderBy(k => k).ToList();
                    bool showFreq = chkIncludeFrequency.Checked;
                    foreach (var key in sortedUnique)
                    {
                        if (showFreq)
                            lstWords.Items.Add($"{key} ({uniqueWordsDict[key]})");
                        else
                            lstWords.Items.Add(key);
                    }
                }
                else if (rdoShowTwoWordPairList.Checked)
                {
                    var sortedPairs = multiPairs.OrderBy(k => k.Key).ToList();
                    foreach (var kvp in sortedPairs)
                    {
                        for (int i = 0; i < kvp.Value; i++)
                        {
                            lstWords.Items.Add(kvp.Key);
                        }
                    }
                }

                lstWords.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during processing: {ex.Message}", "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lstWords.EndUpdate();
            }
        }

        private void lstWords_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}