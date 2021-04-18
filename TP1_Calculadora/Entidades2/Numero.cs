using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        private double numero;
        #endregion
       
        #region Metodos
        /// <summary>
        /// Consturctor sin parametros por defecto 0
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Constructor con parametro DOUBLE
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero) :this()
        {
            this.numero = numero;
        }
        public Numero(string strNumero) :this()
        {
            this.SetNumero = strNumero;
        }
        /// <summary>
        /// Setea el valor en Numero
        /// </summary>
        public string SetNumero
        {
            set { this.numero = this.ValidarNumero(value); }
        }
        /// <summary>
        /// Comprueba que el valor recibido como parametro sea numerico, caso contrario retorna 0
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            if(double.TryParse(strNumero, out retorno))
            { }
            return retorno;
        }
        /// <summary>
        /// Valida que la cadena de string este formada solo por 1 o 0
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private static bool EsBinario(string binario)
        {
            bool esBinario = true;
            foreach (char i in binario)
            {
                if (i != '0' && i != '1')
                {
                    esBinario = false;
                }
            }
            return esBinario;
        }
        /// <summary>
        /// Convierte en caso de ser posible un numero binario a decimal sino retornara Valor invalido
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            string resultado = string.Empty;
            if (EsBinario(binario))
            {
                char[] binarioArray = binario.ToCharArray();
                Array.Reverse(binarioArray);
                int resultadoDecimal = 0;
                for(int i = 0; i < binarioArray.Length; i++)
                {
                    if(binarioArray[i].Equals('1'))
                    {
                        resultadoDecimal += (int)Math.Pow(2, i);
                    }
                }
                resultado = resultadoDecimal.ToString();
            }
            else
            {
                resultado = "Valor inválido";
            }
            return resultado;
        }
        /// <summary>
        /// Convierte en caso de ser posible un Double a un string con el numeros en binario
        /// sino retorna valor invalido
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            string resultado = string.Empty;
            int absNumero = (int)Math.Abs(numero);
            if (absNumero > 0)
            {
                int resto;
                while(absNumero >= 1)
                {
                    resto = absNumero % 2;
                    absNumero /= 2;
                    resultado = resto.ToString() + resultado;
                }
            }
            else
            {
                resultado = "Valor inválido";
            }
            return resultado;
        }
        /// <summary>
        /// Recibe un string que validara si es de formato numerico al parsearlo a un double,
        /// Luego invoca al metodo DecimalBinario(double) para retornar el resultado
        /// caso de error en algun metodo retorna valor invalido
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            string resultado= "Valor inválido";
            double numeroPasado;
            bool esNumerico = double.TryParse(numero, out numeroPasado);
            if (esNumerico)
            {
                resultado = DecimalBinario(numeroPasado);
            }
            return resultado;
        }
        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// sobrecarga operador *
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// Sobrecarga operador +
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Sobrecarga operador /, en caso de ser 0 el denominador retorna double.MinValue
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }
        #endregion

    }
}
