namespace Module6MethodsProjectDL
{
    partial class frmMethodActing
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
            this.txtRightOperand = new System.Windows.Forms.TextBox();
            this.txtLeftOperand = new System.Windows.Forms.TextBox();
            this.lblLeftOperand = new System.Windows.Forms.Label();
            this.lblRightOperand = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnModulus = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRightOperand
            // 
            this.txtRightOperand.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRightOperand.Location = new System.Drawing.Point(265, 45);
            this.txtRightOperand.Margin = new System.Windows.Forms.Padding(2);
            this.txtRightOperand.Name = "txtRightOperand";
            this.txtRightOperand.Size = new System.Drawing.Size(122, 32);
            this.txtRightOperand.TabIndex = 0;
            // 
            // txtLeftOperand
            // 
            this.txtLeftOperand.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeftOperand.Location = new System.Drawing.Point(265, 6);
            this.txtLeftOperand.Margin = new System.Windows.Forms.Padding(2);
            this.txtLeftOperand.Name = "txtLeftOperand";
            this.txtLeftOperand.Size = new System.Drawing.Size(122, 32);
            this.txtLeftOperand.TabIndex = 1;
            // 
            // lblLeftOperand
            // 
            this.lblLeftOperand.AutoSize = true;
            this.lblLeftOperand.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftOperand.Location = new System.Drawing.Point(139, 8);
            this.lblLeftOperand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeftOperand.Name = "lblLeftOperand";
            this.lblLeftOperand.Size = new System.Drawing.Size(128, 25);
            this.lblLeftOperand.TabIndex = 2;
            this.lblLeftOperand.Text = "Left Operand";
            // 
            // lblRightOperand
            // 
            this.lblRightOperand.AutoSize = true;
            this.lblRightOperand.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightOperand.Location = new System.Drawing.Point(128, 48);
            this.lblRightOperand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRightOperand.Name = "lblRightOperand";
            this.lblRightOperand.Size = new System.Drawing.Size(139, 25);
            this.lblRightOperand.TabIndex = 3;
            this.lblRightOperand.Text = "Right Operand";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(116, 89);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 37);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(175, 89);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(32, 37);
            this.btnSubtract.TabIndex = 5;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(235, 89);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(2);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(32, 37);
            this.btnMultiply.TabIndex = 6;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(294, 89);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(2);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(32, 37);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnModulus
            // 
            this.btnModulus.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulus.Location = new System.Drawing.Point(353, 89);
            this.btnModulus.Margin = new System.Windows.Forms.Padding(2);
            this.btnModulus.Name = "btnModulus";
            this.btnModulus.Size = new System.Drawing.Size(32, 37);
            this.btnModulus.TabIndex = 8;
            this.btnModulus.Text = "%";
            this.btnModulus.UseVisualStyleBackColor = true;
            this.btnModulus.Click += new System.EventHandler(this.btnModulus_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(116, 137);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(269, 84);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Answer Shows Here";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(84, 247);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(353, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMethodActing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(525, 361);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtLeftOperand);
            this.Controls.Add(this.txtRightOperand);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnModulus);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblRightOperand);
            this.Controls.Add(this.lblLeftOperand);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMethodActing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lashley Methods";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRightOperand;
        private System.Windows.Forms.TextBox txtLeftOperand;
        private System.Windows.Forms.Label lblLeftOperand;
        private System.Windows.Forms.Label lblRightOperand;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnModulus;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

