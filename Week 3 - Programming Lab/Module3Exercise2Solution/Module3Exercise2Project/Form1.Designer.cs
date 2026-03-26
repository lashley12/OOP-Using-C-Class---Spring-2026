namespace Module3Exercise2Project
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

        private void InitializeComponent()
        {
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();     // fixed: renamed
            this.btnR = new System.Windows.Forms.Button();        // fixed: renamed
            this.btnL = new System.Windows.Forms.Button();        // fixed: renamed
            this.btnExit = new System.Windows.Forms.Button();     // fixed: renamed
            this.lblMessage = new System.Windows.Forms.Label();   // fixed: renamed

            this.SuspendLayout();

            // btnRed
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(21, 16);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(93, 45);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "&R";               // fixed to show invisible text + hotkey
            this.btnRed.ForeColor = System.Drawing.Color.Red; // fixed hide text
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);

            // btnBlue
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(376, 16);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(93, 45);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.Text = "&B";               // fixed to show invisible text + hotkey
            this.btnBlue.ForeColor = System.Drawing.Color.Blue; // fixed hide text
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);

            // btnR
            this.btnR.Location = new System.Drawing.Point(376, 175);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(93, 45);
            this.btnR.TabIndex = 3;
            this.btnR.Text = "&R";                  // fixed
            this.btnR.Click += new System.EventHandler(this.btnR_Click);

            // btnL
            this.btnL.Location = new System.Drawing.Point(21, 175);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(93, 45);
            this.btnL.TabIndex = 2;
            this.btnL.Text = "&L";                  // fixed
            this.btnL.Click += new System.EventHandler(this.btnL_Click);

            // btnExit
            this.btnExit.Location = new System.Drawing.Point(136, 234);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(219, 97); // fixed same width as label
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // lblMessage
            this.lblMessage.BackColor = System.Drawing.Color.Yellow;
            this.lblMessage.ForeColor = System.Drawing.Color.Black; // fixed so its visible text
            this.lblMessage.Font = new System.Drawing.Font(
                "Times New Roman", 24F, System.Drawing.FontStyle.Bold); // fixed font size
            this.lblMessage.Location = new System.Drawing.Point(133, 16);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(219, 184);
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; // fixed

            // 
            this.CancelButton = this.btnExit; // fixed so esc is wired to exit 
            this.ClientSize = new System.Drawing.Size(481, 343);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Text = "Week 3 – Fixed Program";

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
    }
}