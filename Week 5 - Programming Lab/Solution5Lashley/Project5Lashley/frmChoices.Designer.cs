namespace Project5Lashley
{
    partial class frmChoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoices));
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblLeftNumber = new System.Windows.Forms.Label();
            this.lblRightNumber = new System.Windows.Forms.Label();
            this.txtLeftNumber = new System.Windows.Forms.TextBox();
            this.txtRightNumber = new System.Windows.Forms.TextBox();
            this.lblCheckNumber = new System.Windows.Forms.Label();
            this.txtCheckNumber = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(3, -2);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(785, 106);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLeftNumber
            // 
            this.lblLeftNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftNumber.Location = new System.Drawing.Point(199, 138);
            this.lblLeftNumber.Name = "lblLeftNumber";
            this.lblLeftNumber.Size = new System.Drawing.Size(151, 23);
            this.lblLeftNumber.TabIndex = 1;
            this.lblLeftNumber.Text = "Left Number";
            this.lblLeftNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRightNumber
            // 
            this.lblRightNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightNumber.Location = new System.Drawing.Point(369, 138);
            this.lblRightNumber.Name = "lblRightNumber";
            this.lblRightNumber.Size = new System.Drawing.Size(181, 23);
            this.lblRightNumber.TabIndex = 2;
            this.lblRightNumber.Text = "Right Number";
            this.lblRightNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLeftNumber
            // 
            this.txtLeftNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeftNumber.Location = new System.Drawing.Point(224, 164);
            this.txtLeftNumber.Name = "txtLeftNumber";
            this.txtLeftNumber.Size = new System.Drawing.Size(100, 34);
            this.txtLeftNumber.TabIndex = 3;
            this.txtLeftNumber.TabStop = false;
            // 
            // txtRightNumber
            // 
            this.txtRightNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRightNumber.Location = new System.Drawing.Point(415, 164);
            this.txtRightNumber.Name = "txtRightNumber";
            this.txtRightNumber.Size = new System.Drawing.Size(100, 34);
            this.txtRightNumber.TabIndex = 4;
            this.txtRightNumber.TabStop = false;
            // 
            // lblCheckNumber
            // 
            this.lblCheckNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckNumber.Location = new System.Drawing.Point(209, 231);
            this.lblCheckNumber.Name = "lblCheckNumber";
            this.lblCheckNumber.Size = new System.Drawing.Size(321, 23);
            this.lblCheckNumber.TabIndex = 5;
            this.lblCheckNumber.Text = "Number to be Checked";
            this.lblCheckNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCheckNumber
            // 
            this.txtCheckNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckNumber.Location = new System.Drawing.Point(312, 267);
            this.txtCheckNumber.Name = "txtCheckNumber";
            this.txtCheckNumber.Size = new System.Drawing.Size(100, 34);
            this.txtCheckNumber.TabIndex = 6;
            this.txtCheckNumber.TabStop = false;
            this.txtCheckNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(204, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(337, 330);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "&Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(475, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(8, 356);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(785, 63);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmChoices
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtCheckNumber);
            this.Controls.Add(this.lblCheckNumber);
            this.Controls.Add(this.txtRightNumber);
            this.Controls.Add(this.txtLeftNumber);
            this.Controls.Add(this.lblRightNumber);
            this.Controls.Add(this.lblLeftNumber);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmChoices";
            this.Text = "Lashley Choices";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblLeftNumber;
        private System.Windows.Forms.Label lblRightNumber;
        private System.Windows.Forms.TextBox txtLeftNumber;
        private System.Windows.Forms.TextBox txtRightNumber;
        private System.Windows.Forms.Label lblCheckNumber;
        private System.Windows.Forms.TextBox txtCheckNumber;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
    }
}

