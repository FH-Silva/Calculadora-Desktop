using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Double? primeiroValor, segundoValor, resultado;
        String operador, input, sinal;

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
            input = string.Empty;
            primeiroValor = null;
            segundoValor = null;
            resultado = null;
            operador = string.Empty;
            sinal = string.Empty;
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
            if (String.IsNullOrEmpty(sinal) || sinal == "-")
            {
                sinal = "+";
            }
            else
            {
                sinal = "-";
            }
            display.Text = sinal;
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            display.Text = ",";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            operador = "+";
            display.Text = operador;

            if (!primeiroValor.HasValue)
            {
                primeiroValor = Double.Parse(input);
                input = string.Empty;
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
            //Verifica se a variável "segundoValor" é "vazia" e se a variável "operador" está vazia
            if (!segundoValor.HasValue && !String.IsNullOrEmpty(operador))
            {
                //Arrumar, erro quando tenta ver o resultado com segundoValor vazio: [1] [+] [ ] = [ ]
                segundoValor = Double.Parse(input);
                resultado = primeiroValor + segundoValor;
                display.Text = resultado.ToString();
            }
        }
    }
}
