namespace Project2ExamLashley
{
    partial class frmOperations
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
            this.btnShowModulus = new System.Windows.Forms.Button();
            this.btnShowFactorial = new System.Windows.Forms.Button();
            this.btnShowFibonacci = new System.Windows.Forms.Button();
            this.btnDoModulus = new System.Windows.Forms.Button();
            this.btnDoFactorial = new System.Windows.Forms.Button();
            this.btnDoFibonacci = new System.Windows.Forms.Button();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.lblMessageArea = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowModulus
            // 
            this.btnShowModulus.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnShowModulus.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowModulus.Location = new System.Drawing.Point(135, 30);
            this.btnShowModulus.Name = "btnShowModulus";
            this.btnShowModulus.Size = new System.Drawing.Size(216, 84);
            this.btnShowModulus.TabIndex = 1;
            this.btnShowModulus.Text = "Show Modulus\n";
            this.btnShowModulus.UseVisualStyleBackColor = false;
            this.btnShowModulus.Click += new System.EventHandler(this.btnShowModulus_Click);
            // 
            // btnShowFactorial
            // 
            this.btnShowFactorial.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnShowFactorial.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFactorial.Location = new System.Drawing.Point(381, 29);
            this.btnShowFactorial.Name = "btnShowFactorial";
            this.btnShowFactorial.Size = new System.Drawing.Size(216, 84);
            this.btnShowFactorial.TabIndex = 3;
            this.btnShowFactorial.Text = "Show Factorial\n";
            this.btnShowFactorial.UseVisualStyleBackColor = false;
            this.btnShowFactorial.Click += new System.EventHandler(this.btnShowFactorial_Click);
            // 
            // btnShowFibonacci
            // 
            this.btnShowFibonacci.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnShowFibonacci.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFibonacci.Location = new System.Drawing.Point(633, 30);
            this.btnShowFibonacci.Name = "btnShowFibonacci";
            this.btnShowFibonacci.Size = new System.Drawing.Size(216, 84);
            this.btnShowFibonacci.TabIndex = 5;
            this.btnShowFibonacci.Text = "Show Fibonacci";
            this.btnShowFibonacci.UseVisualStyleBackColor = false;
            this.btnShowFibonacci.Click += new System.EventHandler(this.btnShowFibonacci_Click);
            // 
            // btnDoModulus
            // 
            this.btnDoModulus.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnDoModulus.Enabled = false;
            this.btnDoModulus.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoModulus.Location = new System.Drawing.Point(135, 129);
            this.btnDoModulus.Name = "btnDoModulus";
            this.btnDoModulus.Size = new System.Drawing.Size(216, 84);
            this.btnDoModulus.TabIndex = 2;
            this.btnDoModulus.Text = "&Do Modulus\n";
            this.btnDoModulus.UseVisualStyleBackColor = false;
            this.btnDoModulus.Click += new System.EventHandler(this.btnDoModulus_Click);
            // 
            // btnDoFactorial
            // 
            this.btnDoFactorial.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnDoFactorial.Enabled = false;
            this.btnDoFactorial.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoFactorial.Location = new System.Drawing.Point(381, 129);
            this.btnDoFactorial.Name = "btnDoFactorial";
            this.btnDoFactorial.Size = new System.Drawing.Size(216, 84);
            this.btnDoFactorial.TabIndex = 4;
            this.btnDoFactorial.Text = "&Do Factorial\n";
            this.btnDoFactorial.UseVisualStyleBackColor = false;
            this.btnDoFactorial.Click += new System.EventHandler(this.btnDoFactorial_Click);
            // 
            // btnDoFibonacci
            // 
            this.btnDoFibonacci.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnDoFibonacci.Enabled = false;
            this.btnDoFibonacci.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoFibonacci.Location = new System.Drawing.Point(633, 130);
            this.btnDoFibonacci.Name = "btnDoFibonacci";
            this.btnDoFibonacci.Size = new System.Drawing.Size(216, 84);
            this.btnDoFibonacci.TabIndex = 6;
            this.btnDoFibonacci.Text = "&Do Fibonacci";
            this.btnDoFibonacci.UseVisualStyleBackColor = false;
            this.btnDoFibonacci.Click += new System.EventHandler(this.btnDoFibonacci_Click);
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(359, 244);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(161, 20);
            this.txtOperand1.TabIndex = 6;
            this.txtOperand1.TabStop = false;
            this.txtOperand1.TextChanged += new System.EventHandler(this.txtOperand1_TextChanged);
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(359, 270);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(161, 20);
            this.txtOperand2.TabIndex = 7;
            this.txtOperand2.TabStop = false;
            this.txtOperand2.Visible = false;
            this.txtOperand2.TextChanged += new System.EventHandler(this.txtOperand2_TextChanged);
            // 
            // lblMessageArea
            // 
            this.lblMessageArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblMessageArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessageArea.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageArea.Location = new System.Drawing.Point(54, 308);
            this.lblMessageArea.Name = "lblMessageArea";
            this.lblMessageArea.Size = new System.Drawing.Size(850, 128);
            this.lblMessageArea.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(599, 456);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 54);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(768, 456);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 54);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1207, 536);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMessageArea);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.btnDoFibonacci);
            this.Controls.Add(this.btnDoFactorial);
            this.Controls.Add(this.btnDoModulus);
            this.Controls.Add(this.btnShowFibonacci);
            this.Controls.Add(this.btnShowFactorial);
            this.Controls.Add(this.btnShowModulus);
            this.KeyPreview = true;
            this.Name = "frmOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operations Lauren Lashley";
            this.Load += new System.EventHandler(this.frmOperations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowModulus;
        private System.Windows.Forms.Button btnShowFactorial;
        private System.Windows.Forms.Button btnShowFibonacci;
        private System.Windows.Forms.Button btnDoModulus;
        private System.Windows.Forms.Button btnDoFactorial;
        private System.Windows.Forms.Button btnDoFibonacci;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.Label lblMessageArea;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

