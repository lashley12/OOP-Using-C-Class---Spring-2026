namespace Sec3LabExam_Lashley
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEnterText = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblConvertedText = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.radPlainToCipher = new System.Windows.Forms.RadioButton();
            this.radCipherToPlain = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterText
            // 
            this.lblEnterText.AutoSize = true;
            this.lblEnterText.Font = new System.Drawing.Font("Cascadia Mono Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEnterText.Location = new System.Drawing.Point(26, 24);
            this.lblEnterText.Name = "lblEnterText";
            this.lblEnterText.Size = new System.Drawing.Size(96, 17);
            this.lblEnterText.TabIndex = 0;
            this.lblEnterText.Text = "Enter Text:";
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(26, 50);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(1128, 120);
            this.txtInput.TabIndex = 1;
            // 
            // lblConvertedText
            // 
            this.lblConvertedText.AutoSize = true;
            this.lblConvertedText.Font = new System.Drawing.Font("Cascadia Mono Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertedText.Location = new System.Drawing.Point(26, 190);
            this.lblConvertedText.Name = "lblConvertedText";
            this.lblConvertedText.Size = new System.Drawing.Size(128, 17);
            this.lblConvertedText.TabIndex = 0;
            this.lblConvertedText.Text = "Converted Text:";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtOutput.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtOutput.Location = new System.Drawing.Point(26, 216);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(1128, 180);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.TabStop = false;
            // 
            // radPlainToCipher
            // 
            this.radPlainToCipher.AutoSize = true;
            this.radPlainToCipher.Checked = true;
            this.radPlainToCipher.Font = new System.Drawing.Font("Cascadia Mono Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPlainToCipher.Location = new System.Drawing.Point(26, 412);
            this.radPlainToCipher.Name = "radPlainToCipher";
            this.radPlainToCipher.Size = new System.Drawing.Size(218, 21);
            this.radPlainToCipher.TabIndex = 13;
            this.radPlainToCipher.TabStop = false;
            this.radPlainToCipher.Text = "Plain text → Cipher text";
            this.radPlainToCipher.UseVisualStyleBackColor = true;
            // 
            // radCipherToPlain
            // 
            this.radCipherToPlain.AutoSize = true;
            this.radCipherToPlain.Font = new System.Drawing.Font("Cascadia Mono Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCipherToPlain.Location = new System.Drawing.Point(26, 442);
            this.radCipherToPlain.Name = "radCipherToPlain";
            this.radCipherToPlain.Size = new System.Drawing.Size(218, 21);
            this.radCipherToPlain.TabIndex = 14;
            this.radCipherToPlain.TabStop = false;
            this.radCipherToPlain.Text = "Cipher text → Plain text";
            this.radCipherToPlain.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConvert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConvert.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(26, 500);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(130, 40);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(176, 500);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 40);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(326, 500);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1186, 569);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.radCipherToPlain);
            this.Controls.Add(this.radPlainToCipher);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblConvertedText);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblEnterText);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sec3Exam-Lashley";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterText;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblConvertedText;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.RadioButton radPlainToCipher;
        private System.Windows.Forms.RadioButton radCipherToPlain;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}