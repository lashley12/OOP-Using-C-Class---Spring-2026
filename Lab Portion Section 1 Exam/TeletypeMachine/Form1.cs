namespace TeletypeMachine
{
    public partial class frmTeletype : Form
    {
        public frmTeletype()
        {
            InitializeComponent();
        }

        private void AppendCharacter(string value)
        {
            txtMessage.Text += value;
        }

        private void btnA_Click(object sender, EventArgs e) => AppendCharacter("A");
        private void btnB_Click(object sender, EventArgs e) => AppendCharacter("B");
        private void btnC_Click(object sender, EventArgs e) => AppendCharacter("C");
        private void btnD_Click(object sender, EventArgs e) => AppendCharacter("D");
        private void btnE_Click(object sender, EventArgs e) => AppendCharacter("E");
        private void btnF_Click(object sender, EventArgs e) => AppendCharacter("F");
        private void btnG_Click(object sender, EventArgs e) => AppendCharacter("G");
        private void btnH_Click(object sender, EventArgs e) => AppendCharacter("H");
        private void btnI_Click(object sender, EventArgs e) => AppendCharacter("I");
        private void btnJ_Click(object sender, EventArgs e) => AppendCharacter("J");
        private void btnK_Click(object sender, EventArgs e) => AppendCharacter("K");
        private void btnL_Click(object sender, EventArgs e) => AppendCharacter("L");
        private void btnM_Click(object sender, EventArgs e) => AppendCharacter("M");
        private void btnN_Click(object sender, EventArgs e) => AppendCharacter("N");
        private void btnO_Click(object sender, EventArgs e) => AppendCharacter("O");
        private void btnP_Click(object sender, EventArgs e) => AppendCharacter("P");
        private void btnQ_Click(object sender, EventArgs e) => AppendCharacter("Q");
        private void btnR_Click(object sender, EventArgs e) => AppendCharacter("R");
        private void btnS_Click(object sender, EventArgs e) => AppendCharacter("S");
        private void btnT_Click(object sender, EventArgs e) => AppendCharacter("T");
        private void btnU_Click(object sender, EventArgs e) => AppendCharacter("U");
        private void btnV_Click(object sender, EventArgs e) => AppendCharacter("V");
        private void btnW_Click(object sender, EventArgs e) => AppendCharacter("W");
        private void btnX_Click(object sender, EventArgs e) => AppendCharacter("X");
        private void btnY_Click(object sender, EventArgs e) => AppendCharacter("Y");
        private void btnZ_Click(object sender, EventArgs e) => AppendCharacter("Z");

        private void btn0_Click(object sender, EventArgs e) => AppendCharacter("0");
        private void btn1_Click(object sender, EventArgs e) => AppendCharacter("1");
        private void btn2_Click(object sender, EventArgs e) => AppendCharacter("2");
        private void btn3_Click(object sender, EventArgs e) => AppendCharacter("3");
        private void btn4_Click(object sender, EventArgs e) => AppendCharacter("4");
        private void btn5_Click(object sender, EventArgs e) => AppendCharacter("5");
        private void btn6_Click(object sender, EventArgs e) => AppendCharacter("6");
        private void btn7_Click(object sender, EventArgs e) => AppendCharacter("7");
        private void btn8_Click(object sender, EventArgs e) => AppendCharacter("8");
        private void btn9_Click(object sender, EventArgs e) => AppendCharacter("9");

        private void btnBlank_Click(object sender, EventArgs e)
        {
            AppendCharacter(" ");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            lblLastSent.Text = txtMessage.Text;
            txtMessage.Clear();
        }

    }
}