namespace Week2_Lashley_Project
{
    partial class frmFall2025
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
            btnWipe = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            lblPrompt = new Label();
            txtInput = new TextBox();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // btnWipe
            // 
            btnWipe.BackColor = Color.White;
            btnWipe.Location = new Point(109, 404);
            btnWipe.Name = "btnWipe";
            btnWipe.Size = new Size(171, 56);
            btnWipe.TabIndex = 0;
            btnWipe.Text = "&Wipe Clear";
            btnWipe.UseVisualStyleBackColor = false;
            btnWipe.Click += btnWipe_Click_1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 192, 255);
            btnSave.Location = new Point(317, 404);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(171, 56);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Black;
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(524, 404);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(171, 56);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Can&cel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Yellow;
            btnExit.Location = new Point(732, 404);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(171, 56);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // lblPrompt
            // 
            lblPrompt.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            lblPrompt.Location = new Point(109, 19);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(180, 32);
            lblPrompt.TabIndex = 4;
            lblPrompt.Text = "Enter Text here";
            lblPrompt.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Times New Roman", 16.2F);
            txtInput.Location = new Point(295, 19);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(608, 32);
            txtInput.TabIndex = 5;
            // 
            // lblDisplay
            // 
            lblDisplay.BackColor = Color.FromArgb(192, 192, 255);
            lblDisplay.Font = new Font("Courier New", 32F, FontStyle.Bold);
            lblDisplay.Location = new Point(109, 70);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(794, 300);
            lblDisplay.TabIndex = 6;
            lblDisplay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmFall2025
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1042, 464);
            Controls.Add(lblDisplay);
            Controls.Add(txtInput);
            Controls.Add(lblPrompt);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnWipe);
            Name = "frmFall2025";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fall 2025 - Lashley";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWipe;
        private Button btnSave;
        private Button btnCancel;
        private Button btnExit;
        private Label lblPrompt;
        private TextBox txtInput;
        private Label lblDisplay;
    }
}
