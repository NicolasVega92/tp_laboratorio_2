using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            this.InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            if ((double.TryParse(this.txtNumero1.Text, out _)) &&
                (double.TryParse(this.txtNumero2.Text, out _)))
            {
                if (this.txtNumero2.Text.Equals("0") && this.cmbOperador.Text.Equals("/"))
                {
                    lblResultado.Text = "NO SE PUEDE DIVIDIR POR CERO";
                }
                else
                {
                    if (!(ValidarOperadorInput(cmbOperador.Text)))
                    {
                        cmbOperador.SelectedIndex = 1;
                    }
                    resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                    lblResultado.Text = Math.Round(resultado, 2).ToString();
                    btnConvertirABinario.Enabled = true;
                    btnConvertirADecimal.Enabled = false;
                }

            }
            else
            {
                lblResultado.Text = "VALOR INVALIDO EN LOS INPUTS";
            }
        }
        private static bool ValidarOperadorInput(string operador)
        {
            bool retorno = false;
            if (operador.Equals("+") || operador.Equals("-") || operador.Equals("/") || operador.Equals("*"))
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Recibe 2 numeros y un operador como strings y realiza el llamado a Operar de la Calculadora
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado;
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            resultado = Calculadora.Operar(num1, num2, operador);
            return resultado;
        }
        /// <summary>
        /// Llama al metodo Limpiar()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Limpia los textos de todas las cajas y posiciona el comboBox en indice -1
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            lblResultado.Text = string.Empty;
            cmbOperador.SelectedIndex = 0;
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }
        /// <summary>
        /// Cierra el formulario en uso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        /// <summary>
        /// Convierte el texto en el label a un numero Binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero numeroAConvertir = new Numero();
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
            lblResultado.Text = numeroAConvertir.DecimalBinario(lblResultado.Text);
        }
        /// <summary>
        /// Convierte el texto en el label a un numero Decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numeroAConvertir = new Numero();
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
            lblResultado.Text = numeroAConvertir.BinarioDecimal(lblResultado.Text);
        }
    }
}
