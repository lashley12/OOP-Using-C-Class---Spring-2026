namespace GettysburgsAddress
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInputPrompt = new System.Windows.Forms.Label();
            this.lstWords = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOutputPrompt = new System.Windows.Forms.Label();
            this.lblChars = new System.Windows.Forms.Label();
            this.txtChars = new System.Windows.Forms.TextBox();
            this.lblSentences = new System.Windows.Forms.Label();
            this.txtSentences = new System.Windows.Forms.TextBox();
            this.lblWords = new System.Windows.Forms.Label();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.lblUniqueWords = new System.Windows.Forms.Label();
            this.txtUniqueWords = new System.Windows.Forms.TextBox();
            this.lblTwoWordPairs = new System.Windows.Forms.Label();
            this.txtTwoWordPairs = new System.Windows.Forms.TextBox();
            this.lblAvgWordLen = new System.Windows.Forms.Label();
            this.txtAvgWordLen = new System.Windows.Forms.TextBox();
            this.lblAvgUniqueLen = new System.Windows.Forms.Label();
            this.txtAvgUniqueLen = new System.Windows.Forms.TextBox();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.rdoShowWordList = new System.Windows.Forms.RadioButton();
            this.rdoShowUniqueWordList = new System.Windows.Forms.RadioButton();
            this.chkIncludeFrequency = new System.Windows.Forms.CheckBox();
            this.rdoShowTwoWordPairList = new System.Windows.Forms.RadioButton();
            this.grpListOptions = new System.Windows.Forms.GroupBox();
            this.grpStats.SuspendLayout();
            this.grpListOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(20, 46);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(450, 590);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblInputPrompt
            // 
            this.lblInputPrompt.AutoSize = true;
            this.lblInputPrompt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputPrompt.Location = new System.Drawing.Point(16, 17);
            this.lblInputPrompt.Name = "lblInputPrompt";
            this.lblInputPrompt.Size = new System.Drawing.Size(184, 23);
            this.lblInputPrompt.TabIndex = 7;
            this.lblInputPrompt.Text = "Input Text for Analysis:";
            // 
            // lstWords
            // 
            this.lstWords.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWords.FormattingEnabled = true;
            this.lstWords.ItemHeight = 23;
            this.lstWords.Location = new System.Drawing.Point(750, 45);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(220, 487);
            this.lstWords.TabIndex = 1;
            this.lstWords.SelectedIndexChanged += new System.EventHandler(this.lstWords_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightBlue;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(650, 572);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 55);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.LightBlue;
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(490, 500);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(140, 55);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightBlue;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(490, 572);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 55);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear / Reset";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOutputPrompt
            // 
            this.lblOutputPrompt.AutoSize = true;
            this.lblOutputPrompt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputPrompt.Location = new System.Drawing.Point(746, 17);
            this.lblOutputPrompt.Name = "lblOutputPrompt";
            this.lblOutputPrompt.Size = new System.Drawing.Size(93, 23);
            this.lblOutputPrompt.TabIndex = 8;
            this.lblOutputPrompt.Text = "Word Lists:";
            // 
            // lblChars
            // 
            this.lblChars.AutoSize = true;
            this.lblChars.Location = new System.Drawing.Point(10, 32);
            this.lblChars.Name = "lblChars";
            this.lblChars.Size = new System.Drawing.Size(81, 20);
            this.lblChars.TabIndex = 0;
            this.lblChars.Text = "Characters:";
            // 
            // txtChars
            // 
            this.txtChars.Location = new System.Drawing.Point(140, 29);
            this.txtChars.Name = "txtChars";
            this.txtChars.ReadOnly = true;
            this.txtChars.Size = new System.Drawing.Size(80, 27);
            this.txtChars.TabIndex = 1;
            // 
            // lblSentences
            // 
            this.lblSentences.AutoSize = true;
            this.lblSentences.Location = new System.Drawing.Point(10, 65);
            this.lblSentences.Name = "lblSentences";
            this.lblSentences.Size = new System.Drawing.Size(78, 20);
            this.lblSentences.TabIndex = 2;
            this.lblSentences.Text = "Sentences:";
            // 
            // txtSentences
            // 
            this.txtSentences.Location = new System.Drawing.Point(140, 62);
            this.txtSentences.Name = "txtSentences";
            this.txtSentences.ReadOnly = true;
            this.txtSentences.Size = new System.Drawing.Size(80, 27);
            this.txtSentences.TabIndex = 3;
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(10, 98);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(54, 20);
            this.lblWords.TabIndex = 4;
            this.lblWords.Text = "Words:";
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(140, 95);
            this.txtWords.Name = "txtWords";
            this.txtWords.ReadOnly = true;
            this.txtWords.Size = new System.Drawing.Size(80, 27);
            this.txtWords.TabIndex = 5;
            // 
            // lblUniqueWords
            // 
            this.lblUniqueWords.AutoSize = true;
            this.lblUniqueWords.Location = new System.Drawing.Point(10, 131);
            this.lblUniqueWords.Name = "lblUniqueWords";
            this.lblUniqueWords.Size = new System.Drawing.Size(105, 20);
            this.lblUniqueWords.TabIndex = 6;
            this.lblUniqueWords.Text = "Unique Words:";
            // 
            // txtUniqueWords
            // 
            this.txtUniqueWords.Location = new System.Drawing.Point(140, 128);
            this.txtUniqueWords.Name = "txtUniqueWords";
            this.txtUniqueWords.ReadOnly = true;
            this.txtUniqueWords.Size = new System.Drawing.Size(80, 27);
            this.txtUniqueWords.TabIndex = 7;
            // 
            // lblTwoWordPairs
            // 
            this.lblTwoWordPairs.AutoSize = true;
            this.lblTwoWordPairs.Location = new System.Drawing.Point(10, 164);
            this.lblTwoWordPairs.Name = "lblTwoWordPairs";
            this.lblTwoWordPairs.Size = new System.Drawing.Size(115, 20);
            this.lblTwoWordPairs.TabIndex = 8;
            this.lblTwoWordPairs.Text = "Two-Word Pairs:";
            // 
            // txtTwoWordPairs
            // 
            this.txtTwoWordPairs.Location = new System.Drawing.Point(140, 161);
            this.txtTwoWordPairs.Name = "txtTwoWordPairs";
            this.txtTwoWordPairs.ReadOnly = true;
            this.txtTwoWordPairs.Size = new System.Drawing.Size(80, 27);
            this.txtTwoWordPairs.TabIndex = 9;
            // 
            // lblAvgWordLen
            // 
            this.lblAvgWordLen.AutoSize = true;
            this.lblAvgWordLen.Location = new System.Drawing.Point(10, 197);
            this.lblAvgWordLen.Name = "lblAvgWordLen";
            this.lblAvgWordLen.Size = new System.Drawing.Size(105, 20);
            this.lblAvgWordLen.TabIndex = 10;
            this.lblAvgWordLen.Text = "Avg Word Len:";
            // 
            // txtAvgWordLen
            // 
            this.txtAvgWordLen.Location = new System.Drawing.Point(140, 194);
            this.txtAvgWordLen.Name = "txtAvgWordLen";
            this.txtAvgWordLen.ReadOnly = true;
            this.txtAvgWordLen.Size = new System.Drawing.Size(80, 27);
            this.txtAvgWordLen.TabIndex = 11;
            // 
            // lblAvgUniqueLen
            // 
            this.lblAvgUniqueLen.AutoSize = true;
            this.lblAvgUniqueLen.Location = new System.Drawing.Point(10, 230);
            this.lblAvgUniqueLen.Name = "lblAvgUniqueLen";
            this.lblAvgUniqueLen.Size = new System.Drawing.Size(116, 20);
            this.lblAvgUniqueLen.TabIndex = 12;
            this.lblAvgUniqueLen.Text = "Avg Unique Len:";
            // 
            // txtAvgUniqueLen
            // 
            this.txtAvgUniqueLen.Location = new System.Drawing.Point(140, 227);
            this.txtAvgUniqueLen.Name = "txtAvgUniqueLen";
            this.txtAvgUniqueLen.ReadOnly = true;
            this.txtAvgUniqueLen.Size = new System.Drawing.Size(80, 27);
            this.txtAvgUniqueLen.TabIndex = 13;
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.txtAvgUniqueLen);
            this.grpStats.Controls.Add(this.lblAvgUniqueLen);
            this.grpStats.Controls.Add(this.txtAvgWordLen);
            this.grpStats.Controls.Add(this.lblAvgWordLen);
            this.grpStats.Controls.Add(this.txtTwoWordPairs);
            this.grpStats.Controls.Add(this.lblTwoWordPairs);
            this.grpStats.Controls.Add(this.txtUniqueWords);
            this.grpStats.Controls.Add(this.lblUniqueWords);
            this.grpStats.Controls.Add(this.txtWords);
            this.grpStats.Controls.Add(this.lblWords);
            this.grpStats.Controls.Add(this.txtSentences);
            this.grpStats.Controls.Add(this.lblSentences);
            this.grpStats.Controls.Add(this.txtChars);
            this.grpStats.Controls.Add(this.lblChars);
            this.grpStats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStats.Location = new System.Drawing.Point(490, 40);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(240, 270);
            this.grpStats.TabIndex = 2;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Text Statistics";
            // 
            // rdoShowWordList
            // 
            this.rdoShowWordList.AutoSize = true;
            this.rdoShowWordList.Checked = true;
            this.rdoShowWordList.Location = new System.Drawing.Point(14, 30);
            this.rdoShowWordList.Name = "rdoShowWordList";
            this.rdoShowWordList.Size = new System.Drawing.Size(132, 24);
            this.rdoShowWordList.TabIndex = 0;
            this.rdoShowWordList.TabStop = true;
            this.rdoShowWordList.Text = "Show Word List";
            this.rdoShowWordList.UseVisualStyleBackColor = true;
            this.rdoShowWordList.CheckedChanged += new System.EventHandler(this.rdoOptions_CheckedChanged);
            // 
            // rdoShowUniqueWordList
            // 
            this.rdoShowUniqueWordList.AutoSize = true;
            this.rdoShowUniqueWordList.Location = new System.Drawing.Point(14, 60);
            this.rdoShowUniqueWordList.Name = "rdoShowUniqueWordList";
            this.rdoShowUniqueWordList.Size = new System.Drawing.Size(183, 24);
            this.rdoShowUniqueWordList.TabIndex = 1;
            this.rdoShowUniqueWordList.Text = "Show Unique Word List";
            this.rdoShowUniqueWordList.UseVisualStyleBackColor = true;
            this.rdoShowUniqueWordList.CheckedChanged += new System.EventHandler(this.rdoShowUniqueWordList_CheckedChanged);
            // 
            // chkIncludeFrequency
            // 
            this.chkIncludeFrequency.AutoSize = true;
            this.chkIncludeFrequency.Enabled = false;
            this.chkIncludeFrequency.Location = new System.Drawing.Point(34, 90);
            this.chkIncludeFrequency.Name = "chkIncludeFrequency";
            this.chkIncludeFrequency.Size = new System.Drawing.Size(199, 24);
            this.chkIncludeFrequency.TabIndex = 2;
            this.chkIncludeFrequency.Text = "Include Frequency Counts";
            this.chkIncludeFrequency.UseVisualStyleBackColor = true;
            // 
            // rdoShowTwoWordPairList
            // 
            this.rdoShowTwoWordPairList.AutoSize = true;
            this.rdoShowTwoWordPairList.Location = new System.Drawing.Point(14, 120);
            this.rdoShowTwoWordPairList.Name = "rdoShowTwoWordPairList";
            this.rdoShowTwoWordPairList.Size = new System.Drawing.Size(193, 24);
            this.rdoShowTwoWordPairList.TabIndex = 3;
            this.rdoShowTwoWordPairList.Text = "Show Two-Word Pair List";
            this.rdoShowTwoWordPairList.UseVisualStyleBackColor = true;
            this.rdoShowTwoWordPairList.CheckedChanged += new System.EventHandler(this.rdoOptions_CheckedChanged);
            // 
            // grpListOptions
            // 
            this.grpListOptions.Controls.Add(this.rdoShowTwoWordPairList);
            this.grpListOptions.Controls.Add(this.chkIncludeFrequency);
            this.grpListOptions.Controls.Add(this.rdoShowUniqueWordList);
            this.grpListOptions.Controls.Add(this.rdoShowWordList);
            this.grpListOptions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpListOptions.Location = new System.Drawing.Point(490, 320);
            this.grpListOptions.Name = "grpListOptions";
            this.grpListOptions.Size = new System.Drawing.Size(240, 160);
            this.grpListOptions.TabIndex = 3;
            this.grpListOptions.TabStop = false;
            this.grpListOptions.Text = "List Output Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(990, 660);
            this.Controls.Add(this.lblOutputPrompt);
            this.Controls.Add(this.lblInputPrompt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.grpListOptions);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.lstWords);
            this.Controls.Add(this.txtInput);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gettysburg Address";
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.grpListOptions.ResumeLayout(false);
            this.grpListOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInputPrompt;
        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblOutputPrompt;
        private System.Windows.Forms.Label lblChars;
        private System.Windows.Forms.TextBox txtChars;
        private System.Windows.Forms.Label lblSentences;
        private System.Windows.Forms.TextBox txtSentences;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.Label lblUniqueWords;
        private System.Windows.Forms.TextBox txtUniqueWords;
        private System.Windows.Forms.Label lblTwoWordPairs;
        private System.Windows.Forms.TextBox txtTwoWordPairs;
        private System.Windows.Forms.Label lblAvgWordLen;
        private System.Windows.Forms.TextBox txtAvgWordLen;
        private System.Windows.Forms.Label lblAvgUniqueLen;
        private System.Windows.Forms.TextBox txtAvgUniqueLen;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.RadioButton rdoShowWordList;
        private System.Windows.Forms.RadioButton rdoShowUniqueWordList;
        private System.Windows.Forms.CheckBox chkIncludeFrequency;
        private System.Windows.Forms.RadioButton rdoShowTwoWordPairList;
        private System.Windows.Forms.GroupBox grpListOptions;
    }
}

