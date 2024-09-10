using System.Globalization;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Diagnostics.Eventing.Reader;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        List<Double> valores = new List<double>();
        Double? resultado;
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
            resultado = null;
            operador = string.Empty;
            sinal = string.Empty;
            display.Text = input;

            valores.Clear();
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
            input += "2";
            display.Text = input;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            input += "3";
            display.Text = input;
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            input += "4";
            display.Text = input;
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            input += "5";
            display.Text = input;
        }
        private void btnSeis_Click(object sender, EventArgs e)
        {
            input += "6";
            display.Text = input;
        }

        private void btnSete_Click_1(object sender, EventArgs e)
        {
            input += "7";
            display.Text = input;
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            input += "8";
            display.Text = input;
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            input += "9";
            display.Text = input;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            input += "0";
            display.Text = input;
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

            valores.Add(Double.Parse(input));
            input = string.Empty;
        } 

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            operador = "-";
            display.Text = operador;

            valores.Add(Double.Parse(input));
            input = string.Empty;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            display.Text = operador;

            valores.Add(Double.Parse(input));
            input = string.Empty;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operador = "/";
            display.Text = operador;

            valores.Add(Double.Parse(input));
            input = string.Empty;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (valores.Count > 0)
            {
                //fazer com que seja possivel fazer operações com os valores da lista
                valores.Add(Double.Parse(input));
                input = string.Empty;

                switch (operador)
                {
                    case "+":
                        resultado = valores.Sum();
                        display.Text = resultado.ToString();
                        break;
                    case "-":
                        // Armazena apenas o primeiro valor da lista
                        resultado = valores[0];

                        for (int i = 1; valores.Count > i; i++)
                        {
                            resultado -= valores[i];
                        }
                        display.Text = resultado.ToString();
                        break;
                    case "*":
                        display.Text = "*";
                        break;
                    case "/":
                        display.Text = "/";
                        break;
                }
            }
            else
            {
                display.Text = "Nenhum valor selecionado";
            }
        }
    }
}
