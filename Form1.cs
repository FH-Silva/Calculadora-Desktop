namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHist_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {

        }

        private void display_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            //Pega o valor que está no display e concatena com 1
            display.Text += "1";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            //Esvaziar display
            display.Text = " ";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {

        }

        private void btnSinais_Click(object sender, EventArgs e)
        {

        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            display.Text = ",";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            display.Text = "+";
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            display.Text = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            display.Text = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            display.Text = "/";
        }
    }
}
