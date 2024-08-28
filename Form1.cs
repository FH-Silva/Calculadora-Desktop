namespace Calculadora
{
    public partial class Form1 : Form
    {
        Double primeiroValor, segundoValor, resultado;
        String operador, input;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void btnHist_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            //Apaga os valores e exibe o input
            input = "";
            primeiroValor = 0;
            segundoValor = 0;
            operador = "";
            display.Text = input;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            input += "1";
            display.Text = input;
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            //primeiroValor += 2;
            //display.Text = primeiroValor;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            //Tres
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            //Quatro
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            //Cinco
        }
        private void btnSeis_Click(object sender, EventArgs e)
        {
            //Seis
        }

        private void btnSete_Click_1(object sender, EventArgs e)
        {
            //Sete
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            //Oito
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            //Nove
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            //Zero
        }

        private void btnSinais_Click(object sender, EventArgs e)
        {
            //Sinais
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            display.Text = ",";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            //Verifica se NÃO está vazio
            if (!String.IsNullOrEmpty(input))
            {
                //Verifica se o operador ESTÁ vazio
                if (String.IsNullOrEmpty(operador))
                {
                    primeiroValor = Double.Parse(input);
                    operador = "+";
                    input = "";
                }
                display.Text = operador;
            }
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

        private void btnResult_Click(object sender, EventArgs e)
        {
            segundoValor = Double.Parse(input);
            display.Text = primeiroValor.ToString() + operador + segundoValor.ToString();
        }
    }
}
