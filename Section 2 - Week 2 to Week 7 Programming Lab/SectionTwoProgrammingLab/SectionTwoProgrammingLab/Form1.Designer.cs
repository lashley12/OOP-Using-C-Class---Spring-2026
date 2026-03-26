namespace SectionTwoProgrammingLab
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
            this.lblConvertFrom = new System.Windows.Forms.Label();
            this.txtConvertFrom = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.btnBinary = new System.Windows.Forms.Button();
            this.btnOctal = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnBase6 = new System.Windows.Forms.Button();
            this.btnBase9 = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConvertFrom
            // 
            this.lblConvertFrom.AutoSize = true;
            this.lblConvertFrom.Location = new System.Drawing.Point(78, 9);
            this.lblConvertFrom.Name = "lblConvertFrom";
            this.lblConvertFrom.Size = new System.Drawing.Size(124, 13);
            this.lblConvertFrom.TabIndex = 0;
            this.lblConvertFrom.Text = "Enter Decimal Number:";
            // 
            // txtConvertFrom
            // 
            this.txtConvertFrom.Location = new System.Drawing.Point(208, 6);
            this.txtConvertFrom.Name = "txtConvertFrom";
            this.txtConvertFrom.Size = new System.Drawing.Size(100, 22);
            this.txtConvertFrom.TabIndex = 1;
            this.txtConvertFrom.TextChanged += new System.EventHandler(this.txtConvertFrom_TextChanged);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(78, 54);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(97, 13);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Enter Base (2–16):";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(181, 51);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 22);
            this.txtBase.TabIndex = 3;
            this.txtBase.TextChanged += new System.EventHandler(this.txtBase_TextChanged);
            // 
            // btnBinary
            // 
            this.btnBinary.Enabled = false;
            this.btnBinary.Location = new System.Drawing.Point(151, 121);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(75, 23);
            this.btnBinary.TabIndex = 4;
            this.btnBinary.Text = "&Binary";
            this.btnBinary.UseVisualStyleBackColor = true;
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // btnOctal
            // 
            this.btnOctal.Enabled = false;
            this.btnOctal.Location = new System.Drawing.Point(262, 121);
            this.btnOctal.Name = "btnOctal";
            this.btnOctal.Size = new System.Drawing.Size(75, 23);
            this.btnOctal.TabIndex = 5;
            this.btnOctal.Text = "&Octal";
            this.btnOctal.UseVisualStyleBackColor = true;
            this.btnOctal.Click += new System.EventHandler(this.btnOctal_Click);
            // 
            // btnHex
            // 
            this.btnHex.Enabled = false;
            this.btnHex.Location = new System.Drawing.Point(383, 121);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(75, 23);
            this.btnHex.TabIndex = 6;
            this.btnHex.Text = "&Hex";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnBase6
            // 
            this.btnBase6.Enabled = false;
            this.btnBase6.Location = new System.Drawing.Point(488, 121);
            this.btnBase6.Name = "btnBase6";
            this.btnBase6.Size = new System.Drawing.Size(75, 23);
            this.btnBase6.TabIndex = 7;
            this.btnBase6.Text = "Base &6";
            this.btnBase6.UseVisualStyleBackColor = true;
            this.btnBase6.Click += new System.EventHandler(this.btnBase6_Click);
            // 
            // btnBase9
            // 
            this.btnBase9.Enabled = false;
            this.btnBase9.Location = new System.Drawing.Point(597, 121);
            this.btnBase9.Name = "btnBase9";
            this.btnBase9.Size = new System.Drawing.Size(75, 23);
            this.btnBase9.TabIndex = 8;
            this.btnBase9.Text = "Base &9";
            this.btnBase9.UseVisualStyleBackColor = true;
            this.btnBase9.Click += new System.EventHandler(this.btnBase9_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.Location = new System.Drawing.Point(383, 188);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 9;
            this.btnProcess.Text = "&Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(22, 227);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(874, 110);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(713, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(821, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(918, 379);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnBase9);
            this.Controls.Add(this.btnBase6);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnOctal);
            this.Controls.Add(this.btnBinary);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.txtConvertFrom);
            this.Controls.Add(this.lblConvertFrom);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decimal to Base Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConvertFrom;
        private System.Windows.Forms.TextBox txtConvertFrom;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.Button btnOctal;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnBase6;
        private System.Windows.Forms.Button btnBase9;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

