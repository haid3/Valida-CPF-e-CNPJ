using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validator3000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtInput.Mask = "";
        }

        private void btnCpf_Click(object sender, EventArgs e)
        {
            txtInput.Mask = "000.000.000-00";
            lblTipo.Text = "CPF";


        }

        private void btnCNPJ_Click(object sender, EventArgs e)
        {
            txtInput.Mask = "00.000.000/0000-00";
            lblTipo.Text = "CNPJ";
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int valorValidar = 0,valorValidar2 = 0;

            switch (lblTipo.Text)
            {
                case "CPF":
                    valorValidar = fazerVerificacao(txtInput.Text, valorValidar, 10, 9);
                    valorValidar2 = fazerVerificacao(txtInput.Text, valorValidar2, 11 , 10);

                    if (valorValidar == int.Parse(txtInput.Text.Substring(9,1))&&
                        valorValidar2 == int.Parse(txtInput.Text.Substring(10, 1)))
                    {
                        MessageBox.Show("CPF VÁLIDO");
                    }else
                    {
                        MessageBox.Show("CPF INVÁLIDO");
                    }
                    break;
                case "CNPJ":
                    valorValidar = fazerVerificacao2(txtInput.Text, valorValidar,12, false);
                    valorValidar2 = fazerVerificacao2(txtInput.Text, valorValidar2,13, true);

                    if (valorValidar == int.Parse(txtInput.Text.Substring(12, 1)) &&
                       valorValidar2 == int.Parse(txtInput.Text.Substring(13, 1)))
                    {
                        MessageBox.Show("CNPJ VÁLIDO");
                    }
                    else
                    {
                        MessageBox.Show("CNPJ INVÁLIDO");
                    }
                    break;
                default:
                    MessageBox.Show("ERRO AO INFORMAR O TIPO A SER CONSULTADO");
                    break;
            }

        }

        public int fazerVerificacao(String input, int valorPassado, int operacao, int digitos)
        {
            for (int i = 0; i < digitos; i++)
            {
                int valor = int.Parse(input.Substring(i, 1));
                valorPassado = valorPassado + (valor * (operacao - i));
            }
            


            valorPassado = valorPassado % 11;
            
            valorPassado = 11 - valorPassado;
            if(valorPassado > 9)
            {
                valorPassado = 0;
            }
          
            return valorPassado;
        }
        public int fazerVerificacao2(String input, int valorPassado,int digitos, Boolean segundaCheck)
        {

            String valorRF = "543298765432";

            if (segundaCheck)
            {
                valorRF = "6" + valorRF;
            }


            for (int i = 0; i < digitos; i++)
            {
                int valor = int.Parse(input.Substring(i, 1));
                int valor2 = int.Parse(valorRF.Substring(i, 1));
                valorPassado = valorPassado + (valor * (valor2));
            }
      


            valorPassado = valorPassado % 11;

            valorPassado = 11 - valorPassado;
            return valorPassado;
        }

        private void txtInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
